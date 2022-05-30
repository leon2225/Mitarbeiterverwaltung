using Mitarbeiterverwaltung.LL;

namespace Mitarbeiterverwaltung.DAL
{

public class Settings
{
    public string companyName { get; set; }
    public string logoPath { get; set; }
    public string csvPath { get; set; }
    public int timeRounding { get; set; }
    public int autoLogoutTimeout { get; set; }
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
        if (!csvLines[0].Equals(header))
        {
            return null;
        }

        //remove header from lines
        csvLines.RemoveAt(0);

        Dictionary<string, Employee> employees = new Dictionary<string, Employee>();

        foreach (var line in csvLines)
        {
            List<string> values = line.Split(",").ToList();
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
            employee.absenteeism = new List<Absenteeism>();
                if(p["absenteeism"].Contains(";"))
                {
                        List<string> absenteeismElements = p["absenteeism"].Split(";").ToList();
                        foreach (var element in absenteeismElements)
                        {
                            List<string> elementItem = element.Split(" ").ToList();
                            Absenteeism item = new Absenteeism(elementItem[0], elementItem[1], elementItem[2], elementItem[3]);
                            employee.absenteeism.Add(item);
                        }
                    }
                

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
            foreach (string key in propertyNames)
            {
                var value = employee.GetType().GetProperty(key).GetValue(employee);

                switch (key)
                {
                    case "holidays":
                        value = value.ToString();
                        break;

                    case "supervisor":
                        if (value == null)
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
                        value = string.Join(";", subordinates);
                        break;


                    case "absenteeism":
                        List<Absenteeism> absenteeism = (List<Absenteeism>)value;
                        if(absenteeism.Count > 0)
                        {
                             value = string.Join(";", absenteeism);
                        }
                        else
                            {
                                value = "";
                            }
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
        loadedData["settings"]["autoLogoutTimeout"] = settings.autoLogoutTimeout.ToString();
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
            else if (currentLine.Contains('='))
            {
                //parse key value pair
                int keyEnd = currentLine.IndexOf("=");
                string key = currentLine.Substring(0, keyEnd);
                key = key.Trim();
                string value = currentLine.Substring(keyEnd + 1);
                value = value.Trim();

                // remove " if they exists
                if (value[value.Length - 1] == '"' && value[0] == '"')
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
            if (!fileContent.ContainsKey("settings") || !fileContent["settings"].ContainsKey(property))
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
        settings.autoLogoutTimeout = Int32.Parse(fileContent["settings"]["autoLogoutTimeout"]);


        return settings;
    }
}
}