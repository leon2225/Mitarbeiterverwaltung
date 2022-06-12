using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mitarbeiterverwaltung.LL;

namespace Mitarbeiterverwaltung
{
    public partial class FormAddPause : Form
    {
        public FormAddPause()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public TimePeriod getTimePeriod()
        {
            var begin = dtpBegin.Value;
            var end = dtpEnd.Value;
            if(begin > end)
            {
                throw new CustomException("Pause shall be later then the begin", exceptionType.info);
            }
            else
            {
                return new TimePeriod(dtpBegin.Value, dtpEnd.Value);
            }
            
        }
    }
}
