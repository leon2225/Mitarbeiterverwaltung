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
            return "[" + startTime.ToString() + " " + endTime.ToString() + " " + state.ToString() + "]";
        }
    }
    public class Employee
    {
        public string Id { get; set; }
        public string passwordHash { get; set; }
        public string name { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }
        public int holidays { get; set; }
        public Employee supervisor { get; set; }
        public Dictionary<string, Employee> subordinates { get; set; }
        public List<HolidayRequest> holidayRequests { get; set; }

        public Employee(string Id, string name, string adress, string phone, int holidays, string password)
        {
            this.Id = Id; //TODO add auto Id
            this.name = name;
            this.adress = adress;
            this.phone = phone; 
            this.holidays = holidays;

            this.subordinates = new Dictionary<string, Employee>();
            this.holidayRequests = new List<HolidayRequest>();

            setPassword(password);
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

        public HourlyRatedEmployee(string Id, string name, string adress, string phone, int holidays, string password, TimeSpan weekTimeLimit) : base(Id, name, adress, phone, holidays, password)
        {
            this.weekTimeLimit = weekTimeLimit;
        }
    }

    public class Administrator : HourlyRatedEmployee
    {
        public Administrator(string Id, string name, string adress, string phone, int holidays, string password, TimeSpan weekTimeLimit) : base(Id, name, adress, phone, holidays, password, weekTimeLimit)
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
        }
    }

    public interface IStorageHandler
    {
        CompanyData? load();
        void save(CompanyData data);
    }

    public class JSONHandler : IStorageHandler
    {
        public string jsonPath;
        public JSONHandler(string fileName)
        {
            jsonPath = fileName;
        }

        public CompanyData? load()
        {
            string jsonString = File.ReadAllText(jsonPath);
            CompanyData? result =
                JsonSerializer.Deserialize<CompanyData>(jsonString);


            return result;
        }

        public void save(CompanyData data)
        {
            string jsonString = JsonSerializer.Serialize(data);
            File.WriteAllText(jsonPath, jsonString);
        }
    }

    public class InitFileParser
    {
        public Dictionary<string, Dictionary<string, string>> parseFile(string fileName)
        {
            Dictionary<string, Dictionary<string, string>> result = new Dictionary<string, Dictionary<string, string>>();


            //TODO check if file exists

            string currentSection = "NoSection";
            // Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines(fileName))
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

            return result;
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
            Application.EnableVisualStyles();
            Application.Run(new mainView());
            

            InitFileParser initFileParser = new InitFileParser();
            initFileParser.parseFile("C:\\Users\\Leon Farchau\\OneDrive\\Hochschule\\S2\\aktuellesThema\\Mitarbeiterverwaltung\\Mitarbeiterverwaltung\\config.ini");

            CompanyData companyData = new CompanyData("Chio Chips uns Knabberartikel GmbH");
            HourlyRatedEmployee damian = new HourlyRatedEmployee("1", "Damian Goldbach", "Oberhausstra�e 7", "01251 1351354", 30, "1234Super", new TimeSpan(37,0,0));
            HourlyRatedEmployee leon = new HourlyRatedEmployee("2", "Leon Farchau", "Unterhausstra�e 19", "05654 568423", 27, "qwertzuiop�", new TimeSpan(30,0,0));
            leon.supervisor = damian;
            companyData.addEmployee(damian);
            companyData.addEmployee(leon);


            JSONHandler jsonHandler = new JSONHandler("C:\\Users\\Leon Farchau\\OneDrive\\Hochschule\\S2\\aktuellesThema\\Mitarbeiterverwaltung\\Mitarbeiterverwaltung\\test.json");
            jsonHandler.save(staffData);
            CompanyData? loadedStaff = jsonHandler.load();

            return;

        }
    }
}