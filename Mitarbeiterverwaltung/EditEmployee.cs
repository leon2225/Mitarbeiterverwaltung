using Mitarbeiterverwaltung.LL;

namespace Mitarbeiterverwaltung
{
    public partial class EditEmployee : Form
    {
        Panel? activePanel;
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
                this.Text = "Neuen Mitarbeiter hinzufügen";
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
                newEmployee = employee;
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

        private void btnAddAbsenteeism_Click(object sender, EventArgs e)
        {
            changeToNewAbsenteeism();

        }

        private void btnCancelAddAbsenteeism_Click(object sender, EventArgs e)
        {
            changeToAbsenteeismList();
            //discard new item 
        }

        private void btnSaveAbsenteeism_Click(object sender, EventArgs e)
        {
            changeToAbsenteeismList();
            //save absenteeism and display in list
            DateTime startDate = dtpBeginnAbsenteeism.Value;
            DateTime endDate = dtpEndAbsenteeism.Value;

            if (endDate < startDate)
            {
                throw new Exception("Selected Enddate is before Startdate");
            }
            //add to list 
            employee.setSickDays(startDate, endDate);
            //update view 
            updatelvAbsenteeism();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changeToNewAbsenteeism()
        {
            absenteeismListPanel.Visible = false;
            newAbsenteeismPanel.Visible = true;
            button_save.Enabled = false;
            button_cancel.Enabled = false;
        }

        private void changeToAbsenteeismList()
        {
            newAbsenteeismPanel.Visible = false;
            absenteeismListPanel.Visible = true;
            button_save.Enabled = true;
            button_cancel.Enabled=true;
        }

        private ListViewItem absenteeismToItem(Absenteeism absenteeism)
        {
                ListViewItem newItem = new ListViewItem(new string[] {
                absenteeism.type.ToString(),
                absenteeism.startTime.ToString("dd.MM.yyyy"),
                absenteeism.endTime.ToString("dd.MM.yyyy"),
                absenteeism.state.ToString()
            });
            return newItem;
        }

        private ListViewItem timestampToItem(DateTime timestamp, string stampType)
        {
            ListViewItem newItem = new ListViewItem(new string[] {
               stampType,
               timestamp.ToString("dd.MM.yyyy"),
               timestamp.ToString("HH:mm"),
            });
            return newItem;
        }

        private void updatelvAbsenteeism()
        {
            lvSickDays.Items.Clear();
            for (int i = 0; i < employee.absenteeism.Count; i++)
            {
                ListViewItem newItem = absenteeismToItem(employee.absenteeism[i]);
                newItem.Tag = i;
                lvSickDays.Items.Add(newItem);
            }          
        }

        private void updatelvTimestamps()
        {
            lvTimestamps.Items.Clear();
            for (int i = 0; i < employee.timestamps.Count; i++)
            {
                ListViewItem newItem = timestampToItem(employee.timestamps[i], "Test in");
                newItem.Tag = i;
                lvTimestamps.Items.Add(newItem);
            }
        }

        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == sickDates)
            {
                updatelvAbsenteeism();
                btnRemove.Enabled = false;
            }
            else if(e.TabPage == workingTimes)
            {
                updatelvTimestamps();
                btnRemove.Enabled = false;
            }
            else
            {
                btnRemove.Enabled = true;
            }
        }

        private void btnDeleteAbsenteeism_Click(object sender, EventArgs e)
        {
            int index = (int)lvSickDays.SelectedItems[0].Tag;
            employee.absenteeism.RemoveAt(index);
            lvSickDays.SelectedItems[0].Remove();
        }
    }
}