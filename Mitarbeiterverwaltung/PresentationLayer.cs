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
            String iniPath = Directory.GetCurrentDirectory() + "\\data\\config.ini";
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
            MessageBoxIcon selectedIcon;
            if (t.Exception is WarningException)
            {
                selectedIcon = MessageBoxIcon.Warning;
            }
            else if (t.Exception is ErrorException)
            {
                selectedIcon = MessageBoxIcon.Error;
            }
            else
            {
                selectedIcon = MessageBoxIcon.Error;
            }
            MessageBox.Show(t.Exception.Message, selectedIcon.ToString().ToUpper(), MessageBoxButtons.OK, selectedIcon);

            if (selectedIcon == MessageBoxIcon.Error)
            {
                Application.Exit();
            }
            else
            {
                // programm can stay open -> do nothing 
            }
        }
    }

    public enum exceptionType
    {
        info,
        warning,
        error
    }

    class WarningException : Exception
    {
        public WarningException()
        {
        }
        public WarningException(string message) : base(message)
        {
        }
        public WarningException(string message, Exception inner) : base(message, inner)
        {
        }
    }

        class ErrorException : Exception
        {
            public ErrorException()
            {
            }
            public ErrorException(string message) : base(message)
            {
            }
            public ErrorException(string message, Exception inner) : base(message, inner)
            {
            }
        }
    }
