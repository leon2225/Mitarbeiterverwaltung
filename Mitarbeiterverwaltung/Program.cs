using Mitarbeiterverwaltung.DAL;
using Mitarbeiterverwaltung.LL;

namespace Mitarbeiterverwaltung
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
                InitFileParser initFileParser = new InitFileParser("C:\\Users\\Damian Goldbach\\source\\repos\\leon2225\\Mitarbeiterverwaltung\\Mitarbeiterverwaltung\\data\\config.ini");
                Settings settings = initFileParser.loadSettings();


                CompanyData companyData = new CompanyData("Chio Chips uns Knabberartikel GmbH");

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
