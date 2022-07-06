using Mitarbeiterverwaltung.LL;

namespace Mitarbeiterverwaltung
{
    /// <summary>
    /// Dialog to add a new TimePeriod including a simple validity check. Can be used for Time or Date periods.  
    /// </summary>
    public partial class AddTimePeriodView : Form
    {
        private List<TimePeriod> otherPeriods;
        private bool isTime = false;
        public AddTimePeriodView(List<TimePeriod> otherPeriods)
        {
            InitializeComponent();
            setBounds(new Object(), new EventArgs());
            this.otherPeriods = otherPeriods;
        }

        /// <summary>
        /// Changes the view of the two DateTimePickers to select only times with format HH:mm.
        /// </summary>
        public void changeToTime()
        {
            isTime = true;
            this.Text = "Pausenzeiten hinzufügen";
            dtpBegin.Format = DateTimePickerFormat.Custom;
            dtpBegin.ShowUpDown = true;
            dtpBegin.CustomFormat = "HH:mm";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.ShowUpDown = true;
            dtpEnd.CustomFormat = "HH:mm";
            dtpEnd.Value = dtpBegin.Value + new TimeSpan(0, 30, 0);
        }

        /// <summary>
        /// Changes the view of the two DateTimePickers to select only dates.
        /// </summary>
        public void changeToDate()
        {
            isTime = false;
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
            DateTime startDate = isTime ? DateTime.MinValue + dtpBegin.Value.TimeOfDay : dtpBegin.Value;
            DateTime endDate = isTime ? DateTime.MinValue + dtpEnd.Value.TimeOfDay : dtpEnd.Value;

            if(isTime)
            {
                startDate -= new TimeSpan(0, 0, startDate.Second);
                endDate -= new TimeSpan(0, 0, endDate.Second);
            }
            else
            {
                startDate = startDate.Date;
                endDate = endDate.Date + new TimeSpan(23,59,59);
            }


            TimePeriod period = new TimePeriod(startDate, endDate);
            bool overlapping = false;
            foreach (TimePeriod otherPeriod in otherPeriods)
            {
                overlapping |= otherPeriod.boundTo(period).getDuration() != TimeSpan.Zero;
            }

            if (overlapping)
            {

                throw new WarningException("Der Zeitraum überschneidet sich mit einem anderem.");
            }
            else
            {
                return new TimePeriod(dtpBegin.Value, dtpEnd.Value);
            }

        }

        private void setBounds(object sender, EventArgs e)
        {
            dtpBegin.MaxDate = dtpEnd.Value;
            dtpEnd.MinDate = dtpBegin.Value;


        }
    }
}
