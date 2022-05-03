namespace Mitarbeiterverwaltung
{
    public partial class NewStaffMember : Form
    {
        public NewStaffMember()
        {
            InitializeComponent();
        }

        public Staff getUserData()
        {
            Staff staff = new Staff
            {
                name = this.textBox_name.Text,
                surname = this.textBox_surname.Text,
                adress = this.label_adress.Text,
                phone = this.textBox_phone.Text,
                age = this.dateTimePicker_birthday.Value
            };
            //weekWorkingTime = Int32.Parse(this.label_workingTimeWeek.Text),
            //holidays = Int32.Parse(this.label_holidays.Text)
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