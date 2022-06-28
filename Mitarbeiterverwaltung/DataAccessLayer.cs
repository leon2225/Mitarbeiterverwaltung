using Mitarbeiterverwaltung.LL;

namespace Mitarbeiterverwaltung.DAL
{
    /// <summary>
    /// Holding the system settings loaded from Ini-File or changed in settings window
    /// </summary>
    public class Settings
    {
        public string companyName { get; set; }
        public string logoPath { get; set; }
        public string csvPath { get; set; }
        public int timeRounding { get; set; }
        public int autoLogoutTimeout { get; set; }
    }

    /// <summary>
    /// Handler for reading and writing Data to CSV-File.
    /// </summary>
    public class CSVStorageHandler
    {
        public string path;

        public CSVStorageHandler(string path)
        {
            this.path = path;
        }

        /// <summary>
        /// Reading the properties of all HourlyRatedEmployees from CSV-File.
        /// </summary>
        /// <remarks>The properties are sorted alphabetically.</remarks>
        /// <returns>Dictionary with all employees of the CSV-File.</returns>
        /// <exception cref="ErrorException"></exception>
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
                throw new ErrorException("Laden der CSV-Datei fehlgeschlagen");
            }

            //remove header from lines
            csvLines.RemoveAt(0);

            Dictionary<string, Employee> employees = new Dictionary<string, Employee>();
            
            foreach (var line in csvLines)
            {
                HourlyRatedEmployee employee = new HourlyRatedEmployee();
                employee.parse(propertyNames, line);
                employees.Add(employee.Id, employee);
            }
            foreach (var line in csvLines)
            {
                List<string> values = line.Split(" ,").ToList();
                var p = propertyNames.Zip(values, (k, v) => new { k, v }).ToDictionary(x => x.k, x => Employee.unescapeString(x.v));
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

        /// <summary>
        /// Save the properties of all employees to CSV-File.
        /// </summary>
        /// <param name="employees">Dictionary with all employees of the system.</param>
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

    /// <summary>
    /// Handler for managing Archive Files
    /// </summary>
    public class ArchiveHandler
    {
        private string path;

        public ArchiveHandler(string path = "archives\\")
        {
            this.path = path;
        }

        /// <summary>
        /// Returns file name
        /// </summary>
        /// <returns></returns>
        private String getFileName()
        {
            return DateTime.Now.ToString("yyyy_MM") + ".csv";
        }

        /// <summary>
        /// Checks if arhciveing has be done for the current month
        /// </summary>
        /// <returns></returns>
        public bool isNewMonth()
        {
            string fileString = getFileName();
            var files = Directory.GetFiles(path).ToList();
            Directory.GetCurrentDirectory();
            return files.Contains(fileString);
        }

        public void writeArchive(CompanyData company)
        {
            String fileName = Directory.GetCurrentDirectory() + "\\" + path + getFileName();
            String outputString = "";
            TimeHandler timeHandler = new TimeHandler();
            foreach (HourlyRatedEmployee employee in company.employees.Values)
            {
                List<DateTime> checkInOutTimes = employee.newMonth(timeHandler);

                for (int i = 0; i < checkInOutTimes.Count; i++)
                {
                    outputString += String.Format("{0},{1},{2}\n", employee.Id, ((i % 2 == 0) ? "ein" : "aus"), checkInOutTimes[i]);
                }
            }

            File.WriteAllText(fileName, outputString);
        }
    }

    /// <summary>
    /// Handler for reading and writing Data to Ini-File.
    /// </summary>
    public class InitFileParser
    {
        public string path;
        private Dictionary<string, Dictionary<string, string>> iniData;
        public InitFileParser(string filePath = "init.ini")
        {
            path = filePath;
        }

        /// <summary>
        /// Loading the settings from the settings dialog to internal Dictionary.
        /// </summary>
        /// <remarks>For better readability the absolute filepaths are reduced to relative paths.</remarks>
        /// <param name="settings"></param>
        public void updateFromSettings(Settings settings)
        {
            string currentDir = Directory.GetCurrentDirectory();
            if (settings.csvPath.Contains(currentDir))
            {
                iniData["settings"]["csvPath"] = "." + settings.csvPath.Substring(currentDir.Length);
            }
            else
            {
                iniData["settings"]["csvPath"] = settings.csvPath;
            }
            if (settings.logoPath.Contains(currentDir))
            {
                iniData["settings"]["logoPath"] = "." + settings.logoPath.Substring(currentDir.Length);
            }
            else
            {
                iniData["settings"]["logoPath"] = settings.logoPath;
            }
            iniData["settings"]["companyName"] = settings.companyName;
            iniData["settings"]["timeRounding"] = settings.timeRounding.ToString();
            iniData["settings"]["autoLogoutTimeout"] = settings.autoLogoutTimeout.ToString();
        }

        /// <summary>
        /// Save the Settings to Ini-File without deleting comments
        /// </summary>
        /// <exception cref="ErrorException"></exception>
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
                        throw new ErrorException("Ungültige Initalisierungsdatei");
                    }
                    else
                    {
                        // Ini-File is valid -> do nothing
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

                    if (iniData.ContainsKey(currentSection) && iniData[currentSection].ContainsKey(key))
                    {
                        String newValue = iniData[currentSection][key];

                        // add " if there are whitespaces in the value
                        if (newValue.Any(Char.IsWhiteSpace))
                        {
                            newValue = "\"" + newValue + "\""; 
                        }
                        else
                        {
                            //no chars to escape -> do nothing
                        }

                        currentLine = currentLine.Replace(oldValue, newValue);
                    }
                    else
                    {
                        //section/key pair does not exist-> ignore
                    }
                    

                }
                else
                {
                    // neihter section nor key/value pair -> ignore
                }

                outputString += currentLine + "\n";
            }

            File.WriteAllText(path, outputString);
        }


        /// <summary>
        /// Reading the Settings from Ini-File and a convert data to a dictionary.
        /// </summary>
        /// <returns>Dictionary containing all key/value pairs of the Ini-File.</returns>
        public Dictionary<string, Dictionary<string, string>> parseFile()
        {
            Dictionary<string, Dictionary<string, string>> result = new Dictionary<string, Dictionary<string, string>>();

            //check if file exists
            if ( !System.IO.File.Exists(path))
            {
                throw new ErrorException("Es existiert keine Ini-Datei!");
            }
            else
            {
                // path does exist -> do nothing
            }

            string currentSection = "NoSection";
            // Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines(path))
            {
                string currentLine = line;

                //remove comments from ini file
                int commentStart = currentLine.IndexOf('#');
                if (commentStart != -1)
                {
                    currentLine = currentLine.Substring(0, commentStart);
                }
                else
                {
                    //no comment -> do nothing
                }

                //remove whitespace
                currentLine = currentLine.Trim();

                //handle sections
                if (currentLine.Contains('['))
                {
                    if (!currentLine.Contains(']'))
                    {
                        throw new ErrorException("Ini Datei is ungültig.");
                    }
                    else
                    {
                        // line valid -> do nothing
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
                    else
                    {
                        //There are no " to remove -> do nothing
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
            iniData = result;
            return result;
        }

        /// <summary>
        /// Assign the raw key/value pairs to internal system setting parameters
        /// </summary>
        /// <returns>Internal system setting values</returns>
        /// <exception cref="ErrorException"></exception>
        public Settings loadSettings()
        {
            Dictionary<string, Dictionary<string, string>> fileContent = parseFile();
            Settings settings = new Settings();

            foreach (var property in typeof(Settings).GetProperties().Select(field => field.Name))
            {
                if (!fileContent.ContainsKey("settings") || !fileContent["settings"].ContainsKey(property))
                {
                    throw new ErrorException("Ungültige Initalisierungsdatei");
                }
                else
                {
                    //Ini-File valid -> do nothing
                }
            }
            string currentDir = Directory.GetCurrentDirectory();
            settings.companyName = fileContent["settings"]["companyName"];
            settings.logoPath = fileContent["settings"]["logoPath"];
            if (settings.logoPath[0] == '.')
            {
                settings.logoPath = currentDir + settings.logoPath.Substring(1);
            }
            else
            {
                //path is absolute -> take string and don't change it
            }
            settings.csvPath = fileContent["settings"]["csvPath"];
            if (settings.csvPath[0] == '.')
            {
                settings.csvPath = currentDir + settings.csvPath.Substring(1);
            }
            else
            {
                //path is absolute -> take string and don't change it
            }
            settings.timeRounding = Int32.Parse(fileContent["settings"]["timeRounding"]);
            settings.autoLogoutTimeout = Int32.Parse(fileContent["settings"]["autoLogoutTimeout"]);


            return settings;
        }
    }
}