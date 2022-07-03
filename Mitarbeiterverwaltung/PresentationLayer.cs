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
            String archivePath = Directory.GetCurrentDirectory() + "\\data\\config.ini";
            InitFileParser initFileParser = new InitFileParser(iniPath);
            Settings settings = initFileParser.loadSettings();

            var csvStorageHandler = new CSVStorageHandler(settings.csvPath);
            var loadedEmployees = csvStorageHandler.load();

            CompanyData companyData = new CompanyData("", loadedEmployees);

            //archive handling
            ArchiveHandler archiveHandler = new ArchiveHandler();
            if (archiveHandler.isNewMonth())
            {
                archiveHandler.writeArchive(companyData);
            }

            // Enable the Windows version depended design settings
            Application.EnableVisualStyles();
            // Enable WinForms exception handling
            Application.ThreadException += new ThreadExceptionEventHandler(PresentationLayer.GuiThreadException);
            // Run Application
            Application.Run(new MainView(companyData, settings));
            csvStorageHandler.save(companyData.employees);
            initFileParser.updateFromSettings(settings);
            initFileParser.saveFile();
            return;
        }

        /// <summary>
        /// Loading the Exceptions from WinForms and classify warning level
        /// </summary>
        private static void GuiThreadException(object sender, ThreadExceptionEventArgs t)
        {
            MessageBoxIcon selectedIcon;
            String messageTitle;
            if (t.Exception is WarningException)
            {
                selectedIcon = MessageBoxIcon.Warning;
                messageTitle = "Warnung";
            }
            else if (t.Exception is ErrorException)
            {
                selectedIcon = MessageBoxIcon.Error;
                messageTitle = "Fehler";
            }
            else
            {
                selectedIcon = MessageBoxIcon.Error;
                messageTitle = "Unbekannter Fehler";
            }
            MessageBox.Show(t.Exception.Message, messageTitle, MessageBoxButtons.OK, selectedIcon);

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

    /// <summary>
    /// Opens a MessageBox with a warning message.
    /// </summary>
    /// <remarks>A warning that something failed is shown but the application does not terminate. </remarks>
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

    /// <summary>
    /// Opens a MessageBox with a error message.
    /// </summary>
    /// <remarks>A error that something failed is shown and the application is closed immediately. Unsaved data are maybe lost. </remarks>
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
