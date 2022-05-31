using Mitarbeiterverwaltung.DAL;
using Mitarbeiterverwaltung.LL;

namespace Mitarbeiterverwaltung
{
    internal static class PresentationLayer
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String iniPath =  Directory.GetCurrentDirectory() + "\\data\\config.ini";
            InitFileParser initFileParser = new InitFileParser(iniPath);
            Settings settings = initFileParser.loadSettings();


            CompanyData companyData = new CompanyData("Chio Chips uns Knabberartikel GmbH");

            var csvStorageHandler = new CSVStorageHandler(settings.csvPath);
            //
            var loadedEmployees = csvStorageHandler.load();
            companyData.employees = loadedEmployees;

            Application.EnableVisualStyles();
            Application.Run(new MainView(companyData, settings));
            csvStorageHandler.save(companyData.employees);
            initFileParser.updateFromSettings(settings);
            initFileParser.saveFile();

            return;

        }
    }
}
