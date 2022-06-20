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
    /// <summary>
    /// Dialog to add a new TimePeriod including a simple validity check. Can be used for Time or Date periods.  
    /// </summary>
    public partial class AddTimePeriodView : Form
    {
        public AddTimePeriodView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Changes the view of the two DateTimePickers to select only times with format HH:mm.
        /// </summary>
        public void changeToTime()
        {
            this.Text = "Pausenzeiten hinzufügen";
            dtpBegin.Format = DateTimePickerFormat.Custom;
            dtpBegin.ShowUpDown = true;
            dtpBegin.CustomFormat = "HH:mm";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.ShowUpDown = true;
            dtpEnd.CustomFormat = "HH:mm";
        }

        /// <summary>
        /// Changes the view of the two DateTimePickers to select only dates.
        /// </summary>
        public void changeToDate()
        {
            this.Text = "Krankheitstage hinzufügen";
            dtpBegin.Format = DateTimePickerFormat.Short;
            dtpBegin.ShowUpDown = false;
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.ShowUpDown= false;
        }

        /// <summary>
        /// Read the input values from the two DateTimePickers and compare if the period is valid. If the period is invalid a WarningExceptions is throwed.
        /// </summary>
        /// <returns>The period between two times or dates</returns>
        /// <exception cref="WarningException"></exception>
        public TimePeriod getTimePeriod()
        {
            var begin = dtpBegin.Value;
            var end = dtpEnd.Value;
            if (begin > end)
            {

                throw new WarningException("Der Anfangszeitpunkt muss vor dem Endzeitpunkt liegen");
            }
            else
            {
                return new TimePeriod(dtpBegin.Value, dtpEnd.Value);
            }

        }

    }
}
