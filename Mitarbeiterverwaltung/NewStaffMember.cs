namespace Mitarbeiterverwaltung
{
    public partial class NewStaffMember : Form
    {
        private HourlyRatedEmployee employee;
        public NewStaffMember(HourlyRatedEmployee? employee)
        {
            InitializeComponent();
            this.employee = employee;
            //TODO init fields with data
        }

        public HourlyRatedEmployee getUserData()
        {
            employee = new HourlyRatedEmployee
            (
                this.textBox_name.Text,
                this.textBox_surname.Text,
                this.label_adress.Text,
                this.textBox_phone.Text,
                Int32.Parse(this.textBox_holidays.Text),
                this.txtPassword.Text,
                new TimeSpan(Int32.Parse(this.textBox_workingTimeWeek.Text), 0,0)
            );
            return employee;
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}