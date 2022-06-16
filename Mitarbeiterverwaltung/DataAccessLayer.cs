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

    public class CSVStorageHandler
    {
        public string path;

        public CSVStorageHandler(string path)
        {
            this.path = path;
        }

        public Dictionary<string, Employee> load()
        {
            string csvString = File.ReadAllText(path);

            var actualPropertyNames = HourlyRatedEmployee.getPropertyNames();
           
            List<string> csvLines = csvString.Split("\r\n").ToList();

            var propertyNames = csvLines[0].Split(" ,").ToList();

            var sProptertyNames = new HashSet<string>(propertyNames);
            
            //If headers aren't equal, the csv file is not compatible
            if (!sProptertyNames.SetEquals(actualPropertyNames))
            {
                throw new CustomException("CSV file is not compatible", exceptionType.error);
            }
            
            //remove header from lines
            csvLines.RemoveAt(0);

            Dictionary<string, Employee> employees = new Dictionary<string, Employee>();
            
            foreach (var line in csvLines)
            {
                
                List<string> values = line.Split(" ,").ToList();
                var p = propertyNames.Zip(values, (k, v) => new { k, v }).ToDictionary(x => x.k, x => x.v);
                HourlyRatedEmployee employee = new HourlyRatedEmployee();
                employee.parse(p);

                employees.Add(p["Id"], employee);
            }
            foreach (var line in csvLines)
            {
                List<string> values = line.Split(" ,").ToList();
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

        public void save(Dictionary<string, Employee> employees)
        {
            string csvString = "";
            var propertyNames = typeof(HourlyRatedEmployee).GetProperties().Select(field => field.Name).ToList();
            propertyNames.Sort();
            string header = string.Join(" ,", propertyNames);
            csvString += header;

            foreach (HourlyRatedEmployee employee in employees.Values)
            {
                csvString += "\r\n";
                csvString += employee.ToString();

            }
            File.WriteAllText(path, csvString);
        }
    }

    public class InitFileParser
    {
        public string path;
        private Dictionary<string, Dictionary<string, string>> data;
        public InitFileParser(string filePath = "init.ini")
        {
            path = filePath;
        }
        public void updateFromSettings(Settings settings)
        {
            string currentDir = Directory.GetCurrentDirectory();
            if (settings.csvPath.Contains(currentDir))
            {
                data["settings"]["csvPath"] = "." + settings.csvPath.Substring(currentDir.Length);
            }
            else
            {
                data["settings"]["csvPath"] = settings.csvPath;
            }
            if (settings.logoPath.Contains(currentDir))
            {
                data["settings"]["logoPath"] = "." + settings.logoPath.Substring(currentDir.Length);
            }
            else
            {
                data["settings"]["logoPath"] = settings.logoPath;
            }
            data["settings"]["companyName"] = settings.companyName;
            data["settings"]["timeRounding"] = settings.timeRounding.ToString();
            data["settings"]["autoLogoutTimeout"] = settings.autoLogoutTimeout.ToString();
        }
        public void saveFile()
        {
            String currentSection = "NoSection";
            String outputString = String.Empty;
            // Read the file and display it line by line.  
            foreach (String line in System.IO.File.ReadLines(path))
            {
                String currentLine = line;
                String trimmedLine = String.Empty;
                //remove comments
                int commentStart = currentLine.IndexOf('#');
                if (commentStart != -1)
                {
                    trimmedLine = currentLine.Substring(0, commentStart);
                }
                else
                {
                    trimmedLine = currentLine;
                }

                //remove whitespace
                trimmedLine = trimmedLine.Trim();

                //handle sections
                if (trimmedLine.Contains('['))
                {
                    if (!trimmedLine.Contains(']'))
                    {
                        // TODO raise error
                        throw new CustomException("Invalid ini File", exceptionType.error);
                    }

                    int sectionStart = trimmedLine.IndexOf('[') + 1;
                    int sectionEnd = trimmedLine.IndexOf(']');

                    currentSection = trimmedLine.Substring(sectionStart, sectionEnd - sectionStart);
                }
                else if (trimmedLine.Contains('='))
                {
                    //parse key value pair
                    int keyEnd = trimmedLine.IndexOf("=");
                    String key = trimmedLine.Substring(0, keyEnd);
                    key = key.Trim();


                    String oldValue = trimmedLine.Substring(keyEnd + 1);
                    oldValue = oldValue.Trim();

                    //TODO: Validate if section and key exists in dict
                    String newValue = data[currentSection][key];

                    // add " if there are whitespaces in the value
                    if (newValue.Any(Char.IsWhiteSpace))
                    {
                        newValue = "\"" + newValue + "\""; 
                    }

                    currentLine = currentLine.Replace(oldValue, newValue);

                }
                else
                {
                    // neihter section nor key/value pair -> ignore
                }

                outputString += currentLine + "\n";
            }

            File.WriteAllText(path, outputString);
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
            data = result;
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
                    throw new CustomException("Invalid ini file", exceptionType.error);
                }
            }
            string currentDir = Directory.GetCurrentDirectory();
            settings.companyName = fileContent["settings"]["companyName"];
            settings.logoPath = fileContent["settings"]["logoPath"];
            if (settings.logoPath[0] == '.')
            {
                settings.logoPath = currentDir + settings.logoPath.Substring(1);
            }
            settings.csvPath = fileContent["settings"]["csvPath"];
            if (settings.csvPath[0] == '.')
            {
                settings.csvPath = currentDir + settings.csvPath.Substring(1);
            }
            settings.timeRounding = Int32.Parse(fileContent["settings"]["timeRounding"]);
            settings.autoLogoutTimeout = Int32.Parse(fileContent["settings"]["autoLogoutTimeout"]);


            return settings;
        }
    }
}