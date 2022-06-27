using Mitarbeiterverwaltung.LL;

namespace Mitarbeiterverwaltung
{
    /// <summary>
    /// Dialog to view and edit data of a selected employee.
    /// <remarks>In reduced form used to sign up new employees.</remarks>
    /// </summary>
    public partial class EmployeeView : Form
    {
        private HourlyRatedEmployee employee;
        private HourlyRatedEmployee? supervisor;
        private bool newEmployee;

        /// <summary>
        /// Loading the data of an existing employee or create a new employee an disable unavailable tabs.
        /// </summary>
        /// <param name="employee">Employee that should be loaded</param>
        /// <param name="supervisor">Supervisor of the Employee</param>
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

                btnRemoveEmployee.Visible = false;
            }
            else
            {
                this.txtName.Text = employee.name;
                this.txtSurname.Text = employee.surname;
                this.txtAddress.Text = employee.adress;
                this.txtPhone.Text = employee.phone;
                this.mtxtVacationDays.Text = employee.vacationDays.ToString();
                this.mtxtWeekTimeLimit.Text = employee.weekTimeLimit.TotalHours.ToString();
                this.btnResetPassword.Enabled = true;
            }

        }

        /// <summary>
        /// Getting the data from Dialog and save them to employee TODO maybe change 
        /// </summary>
        /// <returns>The employee with the values from the Dialog</returns>
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
            data.Add("vacationDays", mtxtVacationDays.Text);
            data.Add("weekTimeLimit", new TimeSpan(Int32.Parse(this.mtxtWeekTimeLimit.Text), 0, 0).ToString());

            //Get diff between old and new vacationdays and add the diff if there now are more vacationDyas than before
            double newVacationDays = Double.Parse(mtxtVacationDays.Text);
            if (employee.vacationDays < newVacationDays )
            {
                double newVacationDaysLeft = employee.getVacationDaysLeft();
                newVacationDaysLeft += newVacationDays - employee.vacationDays;
                data.Add("vacationsHalfDaysLeft", (newVacationDaysLeft * 2).ToString());
            }

            employee.parse(data);
            employee.supervisor = this.supervisor; 

            return employee; //todo pauseTime, vacation, workingTimes and Sick days
        }

        /// <summary>
        /// Remove the selected employee after a second confirmation
        /// </summary>
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

        /// <summary>
        /// Reset the Password of the current Employee.
        /// </summary>
        /// <remarks>If the current employee will sign in next time, he will be notified to change his password.</remarks>
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Das Passwort von " + this.employee.surname + " " + this.employee.name + " wurde erfolgreich zurückgesetzt", "Passwort eines Mitarbeiters zurücksetzen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.employee.resetPassword();
        }

        /// <summary>
        /// Opens a new Dialog to add a new TimePeriod of Sick Days to selected Employee.
        /// </summary>
        private void btnAddSickdays_Click(object sender, EventArgs e)
        {
            AddTimePeriodView addSickDays = new AddTimePeriodView(employee.sickDays); 
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

        /// <summary>
        /// Convert the entries of a <c>VacationRequest</c> to a <c>ListViewItem</c> to display in a ListView.
        /// </summary>
        /// <param name="vacationRequest">VacationRequest containing start Date, end Date and a state.</param>
        /// <returns>ListViewItem to Display in a ListView</returns>
        private ListViewItem vacationRequestToItem(VacationRequest vacationRequest)
        {
            ListViewItem newItem = new ListViewItem(new string[] {
                vacationRequest.startDate.ToString("dd.MM.yyyy"),
                vacationRequest.endDate.ToString("dd.MM.yyyy"),
                vacationRequest.state.GetName()
            });
            return newItem;
        }

        /// <summary>
        /// Convert a timestamp from checkInOutTimes to a <c>ListViewItem</c> to display in a ListView.
        /// </summary>
        /// <param name="timestamp">Time and Date</param>
        /// <param name="stampType">Type of Stamp (in or out)</param>
        /// <returns>ListViewItem to Display in a ListView</returns>
        private ListViewItem checkInOutTimeToItem(DateTime timestamp, string stampType)
        {
            ListViewItem newItem = new ListViewItem(new string[] {
               stampType,
               timestamp.ToString("HH:mm"),
               timestamp.ToString("dd.MM.yyyy"),
            });
            return newItem;
        }

        /// <summary>
        /// Convert a <c>TimePeriod</c> to a <c>ListViewItem</c> to display in a ListView.
        /// </summary>
        /// <param name="timePeriod">start and end of <c>TimePeriod</c></param>
        /// <param name="format">text format of ListViewItem in ListView</param>
        /// <returns>ListViewItem to Display in a ListView</returns>
        private ListViewItem timePeriodToItem(TimePeriod timePeriod, string format = "dd.MM.yyyy")
        {
            ListViewItem newItem = new ListViewItem(new string[] {
                timePeriod.startDate.ToString(format),
                timePeriod.endDate.ToString(format),
            });
            return newItem;
        }

        /// <summary>
        /// Clear the ListView for Vacations and add all vacation requests of employee to ListView
        /// </summary>
        private void updateLvVacations()
        {
            lvVacations.Items.Clear();
            for (int i = 0; i < employee.vacations.Count; i++)
            {
                ListViewItem newItem = vacationRequestToItem(employee.vacations[i]);
                newItem.Tag = i; // tag used to identify index of item
                lvVacations.Items.Add(newItem);
            }
        }

        /// <summary>
        /// Clear the ListView for SickDays and add all SickDay periods of employee to ListView
        /// </summary>
        private void updateLvSickdays()
        {
            lvSickDays.Items.Clear();
            int index = 0;
            foreach (TimePeriod sickday in employee.sickDays)
            {
                ListViewItem newItem = timePeriodToItem(sickday);
                newItem.Tag = index++; // tag used to identify index of item
                lvSickDays.Items.Add(newItem);
            }
        }

        /// <summary>
        /// Clear the ListView for PauseTimes and add all PauseTimes of employee to ListView
        /// </summary>
        private void updateLvPauseTimes()
        {
            lvPause.Items.Clear();
            int index = 0;
            
            foreach (TimePeriod pauseTime in employee.pauseTimes)
            {
                ListViewItem newItem = timePeriodToItem(pauseTime, "HH:mm");
                newItem.Tag = index++; // tag used to identify index of item
                lvPause.Items.Add(newItem);
            }
        }

        /// <summary>
        /// Clear the ListView for CheckInOutTimes and add all stamp times of employee to ListView
        /// </summary>
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

        /// <summary>
        /// Update the ListViews of the selected Tab on every change
        /// </summary>
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

        /// <summary>
        /// Deletes the selected SickDays period and updates ListView.
        /// </summary>
        /// <remarks>The button is disabled if no Item is selected.</remarks>
        private void btnRemoveSickdays_Click(object sender, EventArgs e)
        {
            int index = (int)lvSickDays.SelectedItems[0].Tag;
            employee.sickDays.RemoveAt(index);
            lvSickDays.SelectedItems[0].Remove();
            updateLvSickdays();
        }

        /// <summary>
        /// Toggle the buttons for changing the state of a pending VacationRequest if any item is selected.
        /// </summary>
        private void lvVacations_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            bool enableState = lvVacations.SelectedItems.Count > 0;
            btnAllowVacationRequest.Enabled = enableState;
            btnDenyVacationRequest.Enabled = enableState;
        }

        /// <summary>
        /// Set the state of a vacation request to accepted.
        /// </summary>
        private void btnAllowVacationRequest_Click(object sender, EventArgs e)
        {
            int index = (int)lvVacations.SelectedItems[0].Tag;
            employee.grantVacation(index);
            updateLvVacations();
        }

        /// <summary>
        /// Set the state of a vacation request to denied.
        /// </summary>
        private void btnDenyVacationRequest_Click(object sender, EventArgs e)
        {
            int index = (int)lvVacations.SelectedItems[0].Tag;
            employee.vacations[index].state = RequestState.denied;
            updateLvVacations();
        }

        /// <summary>
        /// Starts the Dialog to add a new pausetime for the employee and updates ListView.
        /// </summary>
        private void btnAddPause_Click(object sender, EventArgs e)
        {
            AddTimePeriodView addPauseView = new AddTimePeriodView(employee.pauseTimes);
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

        /// <summary>
        /// Toggle the button for editing a pause time if any item is selected.
        /// </summary>
        private void lvPause_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            bool enableState = lvPause.SelectedItems.Count > 0;
            btnRemovePause.Enabled = enableState;
        }

        /// <summary>
        /// Deletes the selected pause time for the employee and updates ListView.
        /// </summary>
        private void btnRemovePause_click(object sender, EventArgs e)
        {
            int index = (int)lvPause.SelectedItems[0].Tag;
            employee.pauseTimes.RemoveAt(index);
            updateLvPauseTimes();
        }

        /// <summary>
        /// Opens a new Dialog to adjust the selected stamp time and updates the ListView.
        /// </summary>
        /// <remarks>
        /// The timestamp can only be adjusted between the previous and next timestamp. 
        /// If the selected timestamp is the first or the last it can only be adjusted 
        /// in the opposite direction.
        /// </remarks>
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

            EditDateTimeView form = new EditDateTimeView(employee.checkInOutTimes[index], minTime, maxTime);

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

        /// <summary>
        /// Toggle the button for editing a checkInOutTimes if any item is selected.
        /// </summary>
        private void lvCheckInOutTimes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            bool enableState = lvCheckInOutTimes.SelectedItems.Count > 0;
            btnEditCheckInOutTime .Enabled = enableState;
        }

        /// <summary>
        /// Toggle the button for deleting a sick day period if any item is selected.
        /// </summary>
        private void lvSickDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enableState = lvSickDays.SelectedItems.Count > 0;
            btnRemoveSickDays.Enabled = enableState;
        }


    }
}