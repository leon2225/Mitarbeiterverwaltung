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
