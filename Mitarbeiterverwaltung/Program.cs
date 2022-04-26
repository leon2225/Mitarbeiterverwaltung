using System.Text.Json;

namespace Mitarbeiterverwaltung
{
    public class Staff
    {
        public string name { get; set; }
        public string surname  { get; set; }
        public int age  { get; set; }
        public DateTime startTime  { get; set; }
        public TimeSpan weekWorkingTime { get; set; }
        public TimeSpan totalWorktime { get; set; }
    }

    public class CompanyData
    {
        public List<Staff> staffList { get; set; }
        public string companyName { get; set; }

        public CompanyData()
        {
            staffList = new List<Staff>();
            companyName = string.Empty;
        }

        public void addStaff(Staff staff)
        {
            staffList.Add(staff);
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
            //Application.Run(new Form1());

            InitFileParser initFileParser = new InitFileParser();
            initFileParser.parseFile("C:\\Users\\Leon Farchau\\OneDrive\\Hochschule\\S2\\aktuellesThema\\Mitarbeiterverwaltung\\Mitarbeiterverwaltung\\config.ini");


            CompanyData staffData = new CompanyData();
            Staff staff = new Staff();
            staff.surname = "Nachname";
            staffData.addStaff(staff);

            JSONHandler jsonHandler = new JSONHandler("C:\\Users\\Leon Farchau\\OneDrive\\Hochschule\\S2\\aktuellesThema\\Mitarbeiterverwaltung\\Mitarbeiterverwaltung\\test.json");
            jsonHandler.save(staffData);
            CompanyData? loadedStaff = jsonHandler.load();

            return;

        }
    }
}