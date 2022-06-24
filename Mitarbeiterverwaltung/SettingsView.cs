using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mitarbeiterverwaltung.DAL;

namespace Mitarbeiterverwaltung
{
    /// <summary>
    /// Dialog loading the system settings from Ini-File and make it possible to change and save it from user interface.
    /// </summary>
    public partial class SettingsView : Form
    {
        private Settings startValues;
        public SettingsView(Settings settings)
        {
            InitializeComponent();
            startValues = settings;
            txtCompanyName.Text = startValues.companyName;
            txtFilePathCsv.Text = startValues.csvPath;
            txtfilePathIcon.Text = startValues.logoPath;
            int itemIdx = nmbrRounding.FindStringExact(startValues.timeRounding.ToString());
            if (itemIdx == -1) 
            {
                throw new WarningException("Ungültige Rundungszeit in der Ini-Datei!");
                itemIdx = 0;
            }
            else
            {
                //Valid value read from ini-file -> do nothing
            }

            nmbrRounding.SelectedIndex = itemIdx;
            mtxtAutoLogoutTimeout.Text = startValues.autoLogoutTimeout.ToString();
        }

        /// <summary>
        /// Load the setting values from Dialog input fields and return them to system.
        /// </summary>
        /// <returns>system settings</returns>
        public Settings getSettings()
        {
            Settings settings = new Settings();
            startValues.companyName = txtCompanyName.Text;
            startValues.csvPath = txtFilePathCsv.Text;
            startValues.logoPath = txtfilePathIcon.Text;
            startValues.timeRounding = Int32.Parse((string)nmbrRounding.SelectedItem);
            startValues.autoLogoutTimeout = Int32.Parse(mtxtAutoLogoutTimeout.Text);
            return settings;
        }

        /// <summary>
        /// Opens a new FileDialog to set a new path to CSV-File. 
        /// </summary>
        private void btnCsv_Click(object sender, EventArgs e)
        {
            openFileDialogCsv.FileName = txtFilePathCsv.Text;
            DialogResult result = openFileDialogCsv.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFilePathCsv.Text = openFileDialogCsv.FileName;
            }
            else
            {
                //No file was selected with ok -> do nothing
            }
        }

        /// <summary>
        /// Opens a new FileDialog to set a new path to Ini-File. 
        /// </summary>
        private void btnIcon_Click(object sender, EventArgs e)
        {
            openFileDialogPng.FileName = txtfilePathIcon.Text;
            DialogResult result = openFileDialogPng.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtfilePathIcon.Text = openFileDialogPng.FileName;
            }
            else
            {
                //No file was selected with ok -> do nothing
            }
        }
    }
}
