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
                this.textBox_name.Text = employee.name;
                this.textBox_surname.Text = employee.surname;
                this.textBox_adress.Text = employee.adress;
                this.textBox_phone.Text = employee.phone;
                this.textBox_holidays.Text = employee.vacationDays.ToString();
                this.textBox_weekTimeLimit.Text = employee.weekTimeLimit.TotalHours.ToString();
                this.btnResetPassword.Enabled = true;
            }
            else
            {
                this.Text = "Neuen Mitarbeiter hinzufügen";

                // Remove tabs other then Personal Data
                this.tabCtrlEditEmployee.Controls.Remove(this.tabVacations);
                this.tabCtrlEditEmployee.Controls.Remove(this.tabWorkingTimes);
                this.tabCtrlEditEmployee.Controls.Remove(this.tabSickDates);
                // Create default pause time

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
                    "",
                    new TimeSpan(Int32.Parse(this.textBox_weekTimeLimit.Text), 0, 0)
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
                newEmployee.vacationDays = Int32.Parse(this.textBox_holidays.Text);
                newEmployee.weekTimeLimit = new TimeSpan(Int32.Parse(this.textBox_weekTimeLimit.Text), 0, 0);
            }

            return newEmployee;
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            this.employee.setPassword("einmalPasswort", "einmalPasswort");
        }

        private void btnAddSickday_Click(object sender, EventArgs e)
        {
            changeToNewSickday();

        }

        private void btnCancelAddSickday_Click(object sender, EventArgs e)
        {
            changeToSickdayList();
            //discard new item 
        }

        private void btnSaveSickday_Click(object sender, EventArgs e)
        {
            changeToSickdayList();
            //save absenteeism and display in list
            DateTime startDate = dtpBeginnAbsenteeism.Value;
            DateTime endDate = dtpEndAbsenteeism.Value;

            if (endDate < startDate)
            {
                throw new CustomException("Selected Enddate is before Startdate", exceptionType.info);
            }
            else
            {
                //add to list
                employee.addSickday(startDate, endDate);
                //update view
                updateLvSickdays();
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changeToNewSickday()
        {
            pnlSickdays.Visible = false;
            pnlNewSickday.Visible = true;
            button_save.Enabled = false;
            button_cancel.Enabled = false;
        }

        private void changeToSickdayList()
        {
            pnlNewSickday.Visible = false;
            pnlSickdays.Visible = true;
            button_save.Enabled = true;
            button_cancel.Enabled = true;
        }

        private ListViewItem vacationRequestToItem(VacationRequest vacationRequest)
        {
            ListViewItem newItem = new ListViewItem(new string[] {
                vacationRequest.startDate.ToString("dd.MM.yyyy"),
                vacationRequest.endDate.ToString("dd.MM.yyyy"),
                vacationRequest.state.ToString()
            });
            return newItem;
        }

        private ListViewItem checkInOutTimeToItem(DateTime timestamp, string stampType)
        {
            ListViewItem newItem = new ListViewItem(new string[] {
               stampType,
               timestamp.ToString("HH:mm"),
               timestamp.ToString("dd.MM.yyyy"),
            });
            return newItem;
        }

        private ListViewItem timePeriodToItem(TimePeriod timePeriod, string format = "dd.MM.yyyy")
        {
            ListViewItem newItem = new ListViewItem(new string[] {
                timePeriod.startDate.ToString(format),
                timePeriod.endDate.ToString(format),
            });
            return newItem;
        }

        private void updateLvVacations()
        {
            lvVacations.Items.Clear();
            for (int i = 0; i < employee.vacations.Count; i++)
            {
                ListViewItem newItem = vacationRequestToItem(employee.vacations[i]);
                newItem.Tag = i;
                lvVacations.Items.Add(newItem);
            }
        }

        private void updateLvSickdays()
        {
            lvSickDays.Items.Clear();
            int index = 0;
            foreach (TimePeriod sickday in employee.sickDays)
            {
                ListViewItem newItem = timePeriodToItem(sickday);
                newItem.Tag = index++;
                lvSickDays.Items.Add(newItem);
            }
        }

        private void updateLvPauseTimes()
        {
            lvPause.Items.Clear();
            int index = 0;
            if (employee != null)
            {
                foreach (TimePeriod pauseTime in employee.pauseTimes)
                {
                    ListViewItem newItem = timePeriodToItem(pauseTime, "HH:mm");
                    newItem.Tag = index++;
                    lvPause.Items.Add(newItem);
                }
            }
            else
            {
                // skip loading pause times if empty
            }
        }

        private void updateLvCheckInOutTimes()
        {
            lbCheckInOutTimes.Items.Clear();
            for (int i = 0; i < employee.checkInOutTimes.Count; i++)
            {
                String type = (i % 2 == 0) ? "Eingestempelt" : "Ausgestempelt";
                ListViewItem newItem = checkInOutTimeToItem(employee.checkInOutTimes[i], type);
                newItem.Tag = i;
                lbCheckInOutTimes.Items.Add(newItem);
            }
        }

        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabVacations)
            {
                updateLvVacations();
            }
            if (e.TabPage == tabSickDates)
            {
                updateLvSickdays();
            }
            else if (e.TabPage == tabWorkingTimes)
            {
                updateLvCheckInOutTimes();
            }
            else if (e.TabPage == tabWorkingTimes)
            {
                updateLvCheckInOutTimes();
            }
            else if (e.TabPage == tabPause)
            {
                updateLvPauseTimes();
            }
            else
            {
                btnRemove.Enabled = true;
            }
        }

        private void btnDeleteSickday_Click(object sender, EventArgs e)
        {
            int index = (int)lvSickDays.SelectedItems[0].Tag;
            employee.sickDays.RemoveAt(index);
            lvSickDays.SelectedItems[0].Remove();
            updateLvSickdays();
        }

        private void lvVacations_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btnAllowVacationRequest.Enabled = true;
            btnDenyVacationRequest.Enabled = true;
        }

        private void btnAllowVacationRequest_Click(object sender, EventArgs e)
        {
            int index = (int)lvVacations.SelectedItems[0].Tag;
            employee.vacations[index].state = RequestState.accepted;
            updateLvVacations();
        }

        private void btnDenyVacationRequest_Click(object sender, EventArgs e)
        {
            int index = (int)lvVacations.SelectedItems[0].Tag;
            employee.vacations[index].state = RequestState.denied;
            updateLvVacations();
        }

        private void btnAddPause_Click(object sender, EventArgs e)
        {
            FormAddPause formAddPause = new FormAddPause();
            formAddPause.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = formAddPause.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                employee.addPause(formAddPause.getTimePeriod());
                updateLvPauseTimes();
            }
            else
            {
                //do nothing
            }
        }

        private void lvPause_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btnRemovePause.Enabled = true;
        }

        private void btnRemovePause_click(object sender, EventArgs e)
        {
            int index = (int)lvPause.SelectedItems[0].Tag;
            employee.pauseTimes.RemoveAt(index);
            updateLvPauseTimes();
        }
    }
}