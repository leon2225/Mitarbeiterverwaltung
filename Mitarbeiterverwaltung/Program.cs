using System.Text.Json;
using System.Text;
using System.Security.Cryptography;

namespace Mitarbeiterverwaltung
{
    public enum RequestState
    {
        pending,
        accepted,
        denied
    }

    public class HolidayRequest
    {
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public RequestState state { get; set; }

        public string toString()
        {
            return startTime.ToString() + " " + endTime.ToString() + " " + state.ToString();
        }
    }
    public class TimeHandler
    {
        private TimeSpan offset;

        public TimeHandler()
        {
            offset = TimeSpan.Zero;
        }

        public DateTime getTime()
        {
            return DateTime.Now + offset;
        }

        public void setTime(DateTime time)
        {
            offset = time - DateTime.Now;
        }

        public void setOffset(TimeSpan offset)
        {
            this.offset = offset;
        }
    }
    public class Settings
    {
        public string companyName { get; set; }
        public string logoPath { get; set; }
        public string csvPath { get; set; }
        public int timeRounding { get; set; }
    }

    public class Employee
    {
        private static int numberOfEmployees = 0;
        public string Id { get; set; }
        public string passwordHash { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }
        public int holidays { get; set; }
        public Employee ?supervisor { get; set; }
        public Dictionary<string, Employee> subordinates { get; set; }
        public List<HolidayRequest> holidayRequests { get; set; }

        public Employee(string name, string surname, string adress, string phone, int holidays, string password)
        {
            this.Id = ((numberOfEmployees++) + 1).ToString(); //TODO add auto Id
            this.name = name;
            this.surname = surname;
            this.adress = adress;
            this.phone = phone; 
            this.holidays = holidays;

            this.subordinates = new Dictionary<string, Employee>();
            this.holidayRequests = new List<HolidayRequest>();

            setPassword(password);
        }

        public void requestHoliday(DateTime startTime, DateTime endTime)
        {
            HolidayRequest holidayRequest = new HolidayRequest();
            holidayRequest.startTime = startTime;
            holidayRequest.endTime = endTime;
            holidayRequest.state = RequestState.pending;

            this.holidayRequests.Add(holidayRequest);
        }
        private byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        private string hashPassword(string password)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(password))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        public void setPassword(string password)
        {
            passwordHash = hashPassword(password);
        }

        public bool checkPassword(string password)
        {
            return hashPassword(password).Equals(passwordHash);
        }
    }

    public class HourlyRatedEmployee : Employee
    {
        public TimeSpan weekTimeLimit { get; set; } = TimeSpan.Zero; //worktime/week due to contract
        public TimeSpan totalWorktime { get; set; } = TimeSpan.Zero; //worktime for this month until now
        public DateTime startTime { get; set; } = DateTime.MinValue;
        public DateTime endTime { get; set; } = DateTime.MinValue;
        public TimeSpan timeWorkedToday { get; set; } = TimeSpan.Zero; //worktime today until last pause
        public TimeSpan pauseTime { get; set; } = TimeSpan.Zero;
        public TimeSpan overtime { get; set; } = TimeSpan.Zero; //overtime until last month

        public HourlyRatedEmployee(string name, string surname, string adress, string phone, int holidays, string password, TimeSpan weekTimeLimit) : base(name, surname, adress, phone, holidays, password)
        {
            this.weekTimeLimit = weekTimeLimit;
        }

        public bool checkIn(TimeHandler timeHandler)
        {
            //checkIn only possible if last action was a checkOut
            if (startTime > endTime)
            {
                return false;
            }

            DateTime now = timeHandler.getTime();

            //if endTime was today, then add time between endTime and now to pausetime
            if (endTime > DateTime.Today)
            {
                pauseTime += now - endTime;
            }
            else
            {
                //TODO handle holidays

                //start of new day
                timeWorkedToday = TimeSpan.Zero;

                //if endTime was last week reset totalWorktime and add overtime
                if (endTime.DayOfWeek > now.DayOfWeek)
                {
                    overtime += totalWorktime - weekTimeLimit;
                    totalWorktime = TimeSpan.Zero;
                }

            }

            startTime = now;
            return true;
        }

        public bool checkOut(TimeHandler timeHandler)
        {
            //checkOut only possible if last action was a checkIn
            if (endTime > startTime)
            {
                return false;
            }

            DateTime now = timeHandler.getTime();

            timeWorkedToday += now - startTime;
            totalWorktime += now - startTime;

            endTime = now;
            return true;
        }
    }

    public class Administrator : HourlyRatedEmployee
    {
        public Administrator(string name, string surname, string adress, string phone, int holidays, string password, TimeSpan weekTimeLimit) : base(name, surname, adress, phone, holidays, password, weekTimeLimit)
        {

        }
    }

    public class CompanyData
    {
        public Dictionary<string, Employee> employees { get; set; }
        public string logoPath { get; set; }
        public string companyName { get; set; }


        public CompanyData(string companyName, string logoPath = "logo.png")
        {
            employees = new Dictionary<string, Employee>();
            this.companyName = companyName;
            this.logoPath = logoPath;
        }

        public void addEmployee(Employee employee)
        {
            employees.Add(employee.Id, employee);
            if(employee.supervisor != null)
            {
                employee.supervisor.subordinates.Add(employee.Id, employee);
            }
        }

        public void removeEmployee(Employee employee)
        {
            employees.Remove(employee.Id);
            if (employee.supervisor != null)
            {
                employee.supervisor.subordinates.Remove(employee.Id);
            }
            foreach (Employee subordinate in employee.subordinates.Values)
            {
                subordinate.supervisor = employee.supervisor;
            }
        }
    }
    public interface IStorageHandler
    {
        Dictionary<string, Employee> load();
        bool save(Dictionary<string, Employee> employees);
    }

    public class CSVStorageHandler : IStorageHandler
    {
        public string path;

        public CSVStorageHandler(string path)
        {
            this.path = path;
        }

        public Dictionary<string, Employee> load()
        {
            string csvString = File.ReadAllText(path);

            var propertyNames = typeof(HourlyRatedEmployee).GetProperties().Select(field => field.Name).ToList();
            propertyNames.Sort();
            string header = string.Join(",", propertyNames);
            
            List<string> csvLines = csvString.Split("\r\n").ToList();

            //If headers aren't equal, the csv file is not compatible
            if(!csvLines[0].Equals(header))
            {
                return null;
            }

            //remove header from lines
            csvLines.RemoveAt(0);

            Dictionary<string, Employee> employees = new Dictionary<string, Employee>();

            foreach (var line in csvLines)
            {
                List <string> values = line.Split(",").ToList();
                var p = propertyNames.Zip(values, (k, v) => new { k, v }).ToDictionary(x => x.k, x => x.v);
                int holidays = int.Parse(p["holidays"]);
                TimeSpan weekTimeLimit = TimeSpan.Parse(p["weekTimeLimit"]);
                HourlyRatedEmployee employee = new HourlyRatedEmployee(p["name"], p["surname"], p["adress"], p["phone"], holidays, "", weekTimeLimit);
                employee.Id = p["Id"];
                employee.overtime = TimeSpan.Parse(p["overtime"]);
                employee.endTime = DateTime.Parse(p["endTime"]);
                employee.startTime = DateTime.Parse(p["startTime"]);
                employee.totalWorktime = TimeSpan.Parse(p["totalWorktime"]);
                employee.timeWorkedToday = TimeSpan.Parse(p["timeWorkedToday"]);
                employee.pauseTime = TimeSpan.Parse(p["pauseTime"]);
                employee.overtime = TimeSpan.Parse(p["overtime"]);
                employee.passwordHash = p["passwordHash"];

                //parse holidayRequests TODO correctly implement!
                employee.holidayRequests = new List<HolidayRequest>();
                employees.Add(p["Id"], employee);
            }
            foreach (var line in csvLines)
            {
                List<string> values = line.Split(",").ToList();
                var p = propertyNames.Zip(values, (k, v) => new { k, v }).ToDictionary(x => x.k, x => x.v);
                string id = p["Id"];
                Employee employee = employees[id];
                string supervisorId = p["supervisor"];
                if (supervisorId != "")
                    employee.supervisor = employees[supervisorId];
                List<string> subordinateIds = p["subordinates"].Split(";").ToList();
                Dictionary<string, Employee> subordinates = new Dictionary<string, Employee>();
                foreach (var subordinateId in subordinateIds)
                {
                    if (subordinateId != "")
                        subordinates.Add(subordinateId, employees[subordinateId]);
                }

                employee.subordinates = subordinates;
            }
                

            return employees;
        }

        public bool save(Dictionary<string, Employee> employees)
        {
            string csvString = "";
            var propertyNames = typeof(HourlyRatedEmployee).GetProperties().Select(field => field.Name).ToList();
            propertyNames.Sort();
            string header = string.Join(",", propertyNames);
            csvString += header;

            foreach (HourlyRatedEmployee employee in employees.Values)
            {
                csvString += "\r\n";
                foreach(string key in propertyNames)
                {
                    var value = employee.GetType().GetProperty(key).GetValue(employee);

                    switch (key)
                    {
                        case "holidays":
                            value = value.ToString();
                            break;

                        case "supervisor":
                            if(value == null)
                            {
                                value = "";
                            }
                            else 
                            {
                                HourlyRatedEmployee supervisor = (HourlyRatedEmployee)value;
                                value = supervisor.Id;
                            }
                            
                            break;

                        case "subordinates":
                            List<string> subordinates = ((Dictionary<string, Employee>)value).Select(kvp => kvp.Key).ToList(); ;
                            value = string.Join(";",subordinates);
                            break;


                        case "holidayRequests":
                            List<HolidayRequest> holidayRequests = (List<HolidayRequest>)value;
                            value = string.Join(";", holidayRequests);
                            //value = value.toString();
                            break;

                        default:
                            break;
                    }

                    csvString += value + ",";
                }
            }
            File.WriteAllText(path, csvString);
            return true;
        }
    }

    public class InitFileParser
    {
        public string path;
        private Dictionary<string, Dictionary<string, string>> loadedData;
        public InitFileParser(string filePath = "init.ini")
        {
            path = filePath;
        }
        public bool updateFromSettings(Settings settings)
        {
            loadedData["settings"]["csvPath"] = settings.csvPath;
            loadedData["settings"]["logoPath"] = settings.logoPath;
            loadedData["settings"]["companyName"] = settings.companyName;
            loadedData["settings"]["timeRounding"] = settings.timeRounding.ToString();
            return true;
        }
        public bool saveFile()
        {
            string iniString = "";

            foreach (var kvp in loadedData)
            {
                iniString += "\n[" + kvp.Key + "]\n";

                foreach (var kvp2 in kvp.Value)
                {
                    iniString += kvp2.Key + "=\"" + kvp2.Value.ToString() + "\"\n";
                }
            }

            File.WriteAllText(path, iniString);
            return true;
        }
        public Dictionary<string, Dictionary<string, string>> parseFile()
        {
            Dictionary<string, Dictionary<string, string>> result = new Dictionary<string, Dictionary<string, string>>();


            //TODO check if file exists

            string currentSection = "NoSection";
            // Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines(path))
            {
                string currentLine = line;
                //remove comments
                int commentStart = currentLine.IndexOf('#');
                if (commentStart != -1)
                {
                    currentLine = currentLine.Substring(0, commentStart);
                }

                //remove whitespace
                currentLine = currentLine.Trim();

                //handle sections
                if (currentLine.Contains('['))
                {
                    if (!currentLine.Contains(']'))
                    {
                        // TODO raise error
                    }
                    int sectionStart = currentLine.IndexOf('[') + 1;
                    int sectionEnd = currentLine.IndexOf(']');

                    currentSection = currentLine.Substring(sectionStart, sectionEnd - sectionStart);

                    result.Add(currentSection, new Dictionary<string, string>());

                    continue;
                }
                else if(currentLine.Contains('='))
                {
                    //parse key value pair
                    int keyEnd = currentLine.IndexOf("=");
                    string key = currentLine.Substring(0, keyEnd);
                    key = key.Trim();
                    string value = currentLine.Substring(keyEnd + 1);
                    value = value.Trim();

                    // remove " if they exists
                    if(value[value.Length - 1] == '"' && value[0] == '"')
                    {
                        value = value.Substring(1, value.Length - 2);
                    }

                    result[currentSection].Add(key, value);
                }
                else
                {
                    // neihter section nor key/value pair -> ignore
                    continue;
                }
            }
            // Suspend the screen.  
            loadedData = result;
            return result;
        }

        public Settings loadSettings()
        {
            Dictionary<string, Dictionary<string, string>> fileContent = parseFile();
            Settings settings = new Settings();

            foreach (var property in typeof(Settings).GetProperties().Select(field => field.Name))
            {
                if(!fileContent.ContainsKey("settings") || !fileContent["settings"].ContainsKey(property))
                {
                    throw new Exception("Invalid ini file");
                }
            }
            string currentDir = AppDomain.CurrentDomain.BaseDirectory;
            settings.companyName = fileContent["settings"]["companyName"];
            settings.logoPath = fileContent["settings"]["logoPath"];
            if (settings.logoPath[0] == '.')
            {
                settings.logoPath = currentDir + settings.logoPath.Substring(2);
            }
            settings.csvPath = fileContent["settings"]["csvPath"];
            if (settings.csvPath[0] == '.')
            {
                settings.csvPath = currentDir + settings.csvPath.Substring(2);
            }
            settings.timeRounding = Int32.Parse(fileContent["settings"]["timeRounding"]);

            return settings;
        }
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            
            
            

            InitFileParser initFileParser = new InitFileParser("C:\\Users\\Leon Farchau\\OneDrive\\Hochschule\\S2\\aktuellesThema\\Mitarbeiterverwaltung\\Mitarbeiterverwaltung\\config.ini");
            Settings settings = initFileParser.loadSettings();


            CompanyData companyData = new CompanyData("Chio Chips uns Knabberartikel GmbH");
            //HourlyRatedEmployee karl = new HourlyRatedEmployee("Karl", "Heiner", "Oberhausstrasse 7", "01251 1351354", 30, "1234Super", new TimeSpan(37,0,0));
            //HourlyRatedEmployee emil = new HourlyRatedEmployee("Emil", "Jansen", "Unterhausstrasse 19", "05654 568423", 27, "qwertzuiop", new TimeSpan(30, 0, 0));
            //HourlyRatedEmployee jens = new HourlyRatedEmployee("Jens", "Hohtal", "Mittelhausstrasse 68", "05694 3254315", 27, "asdfwefdas", new TimeSpan(30, 0, 0));
            //karl.supervisor = jens;
            //emil.supervisor = jens;
            //companyData.addEmployee(jens);
            //companyData.addEmployee(karl);
            //companyData.addEmployee(emil);

            //JSONHandler jsonHandler = new JSONHandler("C:\\Users\\Leon Farchau\\OneDrive\\Hochschule\\S2\\aktuellesThema\\Mitarbeiterverwaltung\\Mitarbeiterverwaltung\\test.json");
            //jsonHandler.save(companyData);
            //CompanyData? loadedStaff = jsonHandler.load();

            var csvStorageHandler = new CSVStorageHandler(settings.csvPath);
            //
            var loadedEmployees = csvStorageHandler.load();
            companyData.employees = loadedEmployees;

            Application.EnableVisualStyles();
            Application.Run(new MainViewL(companyData, settings));
            csvStorageHandler.save(companyData.employees);
            initFileParser.updateFromSettings(settings);
            initFileParser.saveFile();
            return;

        }
    }
}
