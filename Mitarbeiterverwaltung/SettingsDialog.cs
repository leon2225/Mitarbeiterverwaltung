using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitarbeiterverwaltung
{
    public partial class SettingsDialog : Form
    {
        private Settings startValues;
        public SettingsDialog(Settings settings)
        {
            InitializeComponent();
            startValues = settings;
            txtCompanyName.Text = startValues.companyName;
            txtFilePathCsv.Text = startValues.csvPath;
            txtfilePathIcon.Text = startValues.logoPath;
            int itemIdx = nmbrRounding.FindStringExact(startValues.timeRounding.ToString());
            if (itemIdx == -1) 
                itemIdx = 0;
                //throw new Exception("Invalid time rounding"); //Todo exception
            nmbrRounding.SelectedIndex = itemIdx;
            nmbrAutoLogoutTimeout.Text = startValues.autoLogoutTimeout.ToString();
        }

        public Settings getSettings()
        {
            Settings settings = new Settings();
            startValues.companyName = txtCompanyName.Text;
            startValues.csvPath = txtFilePathCsv.Text;
            startValues.logoPath = txtfilePathIcon.Text;
            startValues.timeRounding = Int32.Parse((string)nmbrRounding.SelectedItem);
            startValues.autoLogoutTimeout = Int32.Parse(nmbrAutoLogoutTimeout.Text);
            return settings;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            openFileDialogCsv.FileName = txtFilePathCsv.Text;
            DialogResult result = openFileDialogCsv.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFilePathCsv.Text = openFileDialogCsv.FileName;

            }
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            openFileDialogPng.FileName = txtfilePathIcon.Text;
            DialogResult result = openFileDialogPng.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtfilePathIcon.Text = openFileDialogPng.FileName;
            }
        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
