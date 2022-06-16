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
                this.Text = "Neuen Mitarbeiter hinzufügen";

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
            DialogResult result = MessageBox.Show("Soll der Mitarbeiter " + this.employee.surname + " " + this.employee.name + " wirklich gelöscht werden?", "Enfernen eines Mitarbeiters", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            DialogResult result = MessageBox.Show("Das Passwort von " + this.employee.surname + " " + this.employee.name + " wurde erfolgreich zurückgesetzt", "Passwort eines Mitarbeiters zurücksetzen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.employee.resetPassword();
        }

        private void btnAddSickdays_Click(object sender, EventArgs e)
        {
            EditTimeSpanView addSickDays = new EditTimeSpanView(); 
            addSickDays.StartPosition = FormStartPosition.CenterParent;
            addSickDays.changeToDate();
            DialogResult result = addSickDays.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                employee.addSickday(addSickDays.getTimePeriod());
                updateLvSickdays();
            }
            else
            {
                //do nothing
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnRemoveSickdays_Click(object sender, EventArgs e)
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
            bool enableState = lvPause.SelectedItems.Count > 0;
            btnRemovePause.Enabled = enableState;
        }

        private void btnRemovePause_click(object sender, EventArgs e)
        {
            int index = (int)lvPause.SelectedItems[0].Tag;
            employee.pauseTimes.RemoveAt(index);
            updateLvPauseTimes();
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

        private void lvCheckInOutTimes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            bool enableState = lvCheckInOutTimes.SelectedItems.Count > 0;
            btnEditCheckInOutTime .Enabled = enableState;
        }

        private void lvSickDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enableState = lvSickDays.SelectedItems.Count > 0;
            btnRemoveSickDays .Enabled = enableState; //TODO rename button
        }


    }
}