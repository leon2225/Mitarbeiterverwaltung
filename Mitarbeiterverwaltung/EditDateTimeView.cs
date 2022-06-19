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
    /// <summary>
    /// Dialog to edit a given DateTime element.
    /// </summary>
    public partial class EditDateTimeView : Form
    {
        public EditDateTimeView(DateTime currentTime,DateTime minTime, DateTime maxTime)
        {
            InitializeComponent();
            dtpDateTime.MinDate = minTime;
            dtpDateTime.MaxDate = maxTime;
            dtpDateTime.Value = currentTime;
        }

        /// <summary>
        /// Closing the Dialog with ok argument to save the selected changes.
        /// </summary>
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Closing the Dialog with cancel argument to discard the selected changes.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Returning the date selected in the DateTimePicker
        /// </summary>
        /// <returns>DateTime Value selected in the Dialog</returns>
        public DateTime getDateTime()
        {
            return dtpDateTime.Value;
        }
    }
}
