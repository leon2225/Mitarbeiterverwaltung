using Mitarbeiterverwaltung.DAL;
using Mitarbeiterverwaltung.LL;
using System.Diagnostics;

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
            // Enable the Windows version depended design settings
            Application.EnableVisualStyles();
            // Enable WinForms excaption handling
            Application.ThreadException += new ThreadExceptionEventHandler(PresentationLayer.GuiThreadException);
            // Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException); //TODO non GUI exceptions
            // Run Application
            Application.Run(new MainView(companyData, settings));
            csvStorageHandler.save(companyData.employees);
            initFileParser.updateFromSettings(settings);
            initFileParser.saveFile();

            return;

        }

        // exception handling winforms event queue
        // from Microsoft Documentation
        // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.application.threadexception?redirectedfrom=MSDN&view=windowsdesktop-6.0
        private static void GuiThreadException(object sender, ThreadExceptionEventArgs t)
        {
            CustomException exception = (CustomException)t.Exception;
            ShowExceptionDialog(exception);
            if(exception.type == exceptionType.error)
                Application.Exit();
        }

        // Creates the error message and displays it.
        private static DialogResult ShowExceptionDialog(CustomException e)
        {
            MessageBoxButtons selectedButtons;
            MessageBoxIcon selectedIcon;
            switch (e.type)
            {
                case exceptionType.info:
                    selectedButtons = MessageBoxButtons.OK;
                    selectedIcon = MessageBoxIcon.Information;
                    break;
                case exceptionType.warning:
                    selectedButtons = MessageBoxButtons.OK;
                    selectedIcon = MessageBoxIcon.Warning;
                    break;
                case exceptionType.error:
                    selectedButtons = MessageBoxButtons.OK;
                    selectedIcon = MessageBoxIcon.Error;
                    break;
                default:
                    selectedButtons = MessageBoxButtons.OK;
                    selectedIcon = MessageBoxIcon.Error;
                    break;
            }
            return MessageBox.Show(e.Message, e.type.ToString().ToUpper(), selectedButtons, selectedIcon);
        }
    }

    public enum exceptionType
    {
        info,
        warning,
        error
    }
    class CustomException : Exception
    {
        public CustomException()
        {

        }

        public CustomException(string message) :base (message)
        {

        }

        public CustomException(string message, Exception inner) :base(message, inner)
        {

        }

        public CustomException(string message, exceptionType type) :base(message)
        {
            this.type = type;
        }

        public exceptionType type;
    }

}
