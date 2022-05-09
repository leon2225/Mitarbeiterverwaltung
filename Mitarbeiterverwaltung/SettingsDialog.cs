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
            nmbrRounding.Value = startValues.timeRounding;
        }

        public Settings getSettings()
        {
            Settings settings = new Settings();
            startValues.companyName = txtCompanyName.Text;
            startValues.csvPath = txtFilePathCsv.Text;
            startValues.logoPath = txtfilePathIcon.Text;
            startValues.timeRounding = (int) nmbrRounding.Value;
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
    }
}
