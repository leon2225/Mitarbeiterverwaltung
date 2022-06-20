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
        /// Returning the date selected in the DateTimePicker
        /// </summary>
        /// <returns>DateTime Value selected in the Dialog</returns>
        public DateTime getDateTime()
        {
            return dtpDateTime.Value;
        }
    }
}
