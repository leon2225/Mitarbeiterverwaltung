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
                this.txtName.Text = employee.name;
                this.txtSurname.Text = employee.surname;
                this.txtAddress.Text = employee.adress;
                this.txtPhone.Text = employee.phone;
                this.txtHolidays.Text = employee.vacationDays.ToString();
                this.txtWeekTimeLimit.Text = employee.weekTimeLimit.TotalHours.ToString();
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
                    this.txtName.Text,
                    this.txtSurname.Text,
                    this.txtAddress.Text,
                    this.txtPhone.Text,
                    Int32.Parse(this.txtHolidays.Text),
                    "",
                    new TimeSpan(Int32.Parse(this.txtWeekTimeLimit.Text), 0, 0)
                );
                newEmployee.supervisor = this.supervisor;
            }
            else
            {
                newEmployee = employee;
                newEmployee.name = this.txtName.Text;
                newEmployee.surname = this.txtSurname.Text;
                newEmployee.adress = this.txtAddress.Text;
                newEmployee.phone = this.txtPhone.Text;
                newEmployee.vacationDays = Int32.Parse(this.txtHolidays.Text);
                newEmployee.weekTimeLimit = new TimeSpan(Int32.Parse(this.txtWeekTimeLimit.Text), 0, 0);
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

        private void txtWeekTimeLimit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtWeekTimeLimit.Text.Any(char.IsLetter))
            {
                txtWeekTimeLimit.Clear();
                throw new CustomException("The working time per week can only contain numbers, not characters", exceptionType.info);
                e.Cancel = true;
            }
            else
            {
                //validation ok, do nothing
            }
        }

        private void txtHolidays_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtHolidays.Text.Any(char.IsLetter))
            {
                txtHolidays.Clear();
                throw new CustomException("The number of holidays can only contain numbers, not characters", exceptionType.info);
                e.Cancel = true;
            }
            else
            {
                //validation ok, do nothing
            }
        }
    }
}