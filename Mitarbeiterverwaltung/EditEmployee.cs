using Mitarbeiterverwaltung.LL;

namespace Mitarbeiterverwaltung
{
    public partial class EditEmployee : Form
    {
        private HourlyRatedEmployee? employee;
        private HourlyRatedEmployee? supervisor;
        public EditEmployee(HourlyRatedEmployee? employee, HourlyRatedEmployee? supervisor)
        {
            InitializeComponent();
            this.employee = employee;
            this.supervisor = supervisor;

            if (employee != null)
            {
                this.textBox_name.Text = employee.name ;
                this.textBox_surname.Text = employee.surname ;
                this.textBox_adress.Text = employee.adress ;
                this.textBox_phone.Text = employee.phone ;
                this.textBox_holidays.Text = employee.holidays.ToString() ;
                this.textBox_weekTimeLimit.Text = employee.weekTimeLimit.TotalHours.ToString();
                this.btnResetPassword.Enabled = true;
            }
            else
            {
                btnRemove.Visible = false;
            }
            
        }

        public HourlyRatedEmployee getUserData()
        {
            HourlyRatedEmployee newEmployee;
            if (employee == null)
            {
                newEmployee = new HourlyRatedEmployee
                (
                    this.textBox_name.Text,
                    this.textBox_surname.Text,
                    this.textBox_adress.Text,
                    this.textBox_phone.Text,
                    Int32.Parse(this.textBox_holidays.Text),
                    "0000",
                    new TimeSpan(Int32.Parse(this.textBox_weekTimeLimit.Text), 0,0)
                );
                newEmployee.supervisor = this.supervisor;
            }
            else
            {
                newEmployee = this.employee;
                newEmployee.name = this.textBox_name.Text;
                newEmployee.surname = this.textBox_surname.Text;
                newEmployee.adress = this.textBox_adress.Text;
                newEmployee.phone = this.textBox_phone.Text;
                newEmployee.holidays = Int32.Parse(this.textBox_holidays.Text);
                newEmployee.weekTimeLimit = new TimeSpan(Int32.Parse(this.textBox_weekTimeLimit.Text), 0, 0);
            }

            return newEmployee;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            this.employee.setPassword("0000");
        }
    }
}