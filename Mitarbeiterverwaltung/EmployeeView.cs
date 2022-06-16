using Mitarbeiterverwaltung.LL;

namespace Mitarbeiterverwaltung
{
    public partial class EmployeeView : Form
    {
        private HourlyRatedEmployee employee;
        private HourlyRatedEmployee? supervisor;
        private bool newEmployee;

        public EmployeeView(HourlyRatedEmployee? employee, HourlyRatedEmployee? supervisor)
        {
            InitializeComponent();
            newEmployee = employee == null;
            this.employee = employee;
            this.supervisor = supervisor;

            if (newEmployee)
            {
                this.Text = "Neuen Mitarbeiter hinzuf�gen";

                this.employee = new HourlyRatedEmployee();

                // Remove tabs other then Personal Data
                this.tabCtrlEditEmployee.Controls.Remove(this.tabVacations);
                this.tabCtrlEditEmployee.Controls.Remove(this.tabWorkingTimes);
                this.tabCtrlEditEmployee.Controls.Remove(this.tabSickDates);

                btnRemove.Visible = false;
            }
            else
            {
                this.txtName.Text = employee.name;
                this.txtSurname.Text = employee.surname;
                this.txtAddress.Text = employee.adress;
                this.txtPhone.Text = employee.phone;
                this.mtxtHolidays.Text = employee.vacationDays.ToString();
                this.mtxtWeekTimeLimit.Text = employee.weekTimeLimit.TotalHours.ToString();
                this.btnResetPassword.Enabled = true;
            }

        }

        public HourlyRatedEmployee getUserData()
        {
            if(newEmployee)
            {
                employee.resetPassword();
            }

            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("name", txtName.Text);
            data.Add("surname", txtSurname.Text);
            data.Add("adress", txtAddress.Text);
            data.Add("phone", txtPhone.Text);
            data.Add("vacationDays", mtxtHolidays.Text);
            data.Add("weekTimeLimit", new TimeSpan(Int32.Parse(this.mtxtWeekTimeLimit.Text), 0, 0).ToString());
            employee.parse(data);
            employee.supervisor = this.supervisor;

            return employee;
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
            DialogResult result = MessageBox.Show("Soll der Mitarbeiter " + this.employee.surname + " " + this.employee.name + " wirklich gel�scht werden?", "Enfernen eines Mitarbeiters", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
            else
            {
                // do nothing
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Das Passwort von " + this.employee.surname + " " + this.employee.name + " wurde erfolgreich zur�ckgesetzt", "Passwort eines Mitarbeiters zur�cksetzen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.employee.resetPassword();
        }

        private void btnAddSickday_Click(object sender, EventArgs e)
        {
            EditTimeSpanView addSickDays = new EditTimeSpanView(); 
            addSickDays.StartPosition = FormStartPosition.CenterParent;
            addSickDays.changeToDate();
            DialogResult result = addSickDays.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                List<DateTime> days = new List<DateTime>();
                days = addSickDays.getDatePeriod();
                employee.addSickday(days[0], days[1]);
                updateLvSickdays();
            }
            else
            {
                //do nothing
            }

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
            lvCheckInOutTimes.Items.Clear();
            for (int i = 0; i < employee.checkInOutTimes.Count; i++)
            {
                String type = (i % 2 == 0) ? "Eingestempelt" : "Ausgestempelt";
                ListViewItem newItem = checkInOutTimeToItem(employee.checkInOutTimes[i], type);
                newItem.Tag = i;
                lvCheckInOutTimes.Items.Add(newItem);
            }
        }

        private void tabCtrlEditEmployee_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabVacations)
            {
                updateLvVacations();
            }
            else if (e.TabPage == tabSickDates)
            {
                updateLvSickdays();
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
                //personal data, no need to refresh field
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
            bool enableState = lvVacations.SelectedItems.Count > 0;
            btnAllowVacationRequest.Enabled = enableState;
            btnDenyVacationRequest.Enabled = enableState;
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
            EditTimeSpanView addPauseView = new EditTimeSpanView();
            addPauseView.StartPosition = FormStartPosition.CenterParent;
            addPauseView.changeToTime();
            DialogResult result = addPauseView.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                employee.addPause(addPauseView.getTimePeriod());
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

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtName.Text.Any(char.IsDigit))
            {
                txtName.Clear();
                throw new CustomException("A name can only contain characters, not numbers", exceptionType.info);
            }
            else
            {
                //validation ok, do nothing
            }
        }

        private void txtSurname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtSurname.Text.Any(char.IsDigit))
            {
                txtSurname.Clear();
                throw new CustomException("A surname can only contain characters, not numbers", exceptionType.info);
            }
            else
            {
                //validation ok, do nothing
            }
        }

        private void btnEditCheckInOutTime_Click(object sender, EventArgs e)
        {
            int index = (int)lvCheckInOutTimes.SelectedItems[0].Tag;

            DateTime minTime;
            DateTime maxTime;

            if(index > 0)
            {
                minTime = employee.checkInOutTimes[index-1];
            }
            else
            {
                minTime = DateTime.MinValue;
            }

            if(index < (employee.checkInOutTimes.Count - 1))
            {
                maxTime = employee.checkInOutTimes[index+1];
            }
            else
            {
                maxTime = DateTime.MaxValue;
            }

            FormEditCheckInOutTime form = new FormEditCheckInOutTime(employee.checkInOutTimes[index], minTime, maxTime);

            form.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = form.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                employee.checkInOutTimes[index] = form.getDateTime();
            }
            else
            {
                //do nothing
            }

            updateLvCheckInOutTimes();
        }
    }
}