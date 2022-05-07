namespace Mitarbeiterverwaltung
{
    public partial class NewStaffMember : Form
    {
        public NewStaffMember()
        {
            InitializeComponent();
        }

        public Employee getUserData()
        {
            HourlyRatedEmployee staff = new HourlyRatedEmployee
            (
                this.textBox_name.Text,
                this.textBox_surname.Text,
                this.label_adress.Text,
                this.textBox_phone.Text,
                Int32.Parse(this.label_holidays.Text),
                "hasdasd",
                new TimeSpan(Int32.Parse(this.label_workingTimeWeek.Text), 0,0)
            );
            return staff;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}