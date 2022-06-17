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
    public partial class EditDateTimeView : Form
    {
        public EditDateTimeView(DateTime currentTime,DateTime minTime, DateTime maxTime)
        {
            InitializeComponent();
            dtpDateTime.MinDate = minTime;
            dtpDateTime.MaxDate = maxTime;
            dtpDateTime.Value = currentTime;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public DateTime getDateTime()
        {
            return dtpDateTime.Value;
        }
    }
}
