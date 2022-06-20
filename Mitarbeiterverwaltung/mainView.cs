using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Timers;
using Mitarbeiterverwaltung.LL;
using Mitarbeiterverwaltung.DAL;

namespace Mitarbeiterverwaltung
{
    public partial class MainView : Form
    {
        Panel ?activePanel;
        private CompanyData companyData;
        private HourlyRatedEmployee currentEmployee;
        private Dictionary<string, ListViewItem> lvItems;
        private TimeHandler timeHandler;
        private Settings settings;
        private DateTime logoutTimerBegin = DateTime.MinValue;

        public MainView(CompanyData companyData, Settings settings)
        {
            this.timeHandler = new TimeHandler();
            this.companyData = companyData;
            this.settings = settings;
            lvItems = new Dictionary<string, ListViewItem > ();
            InitializeComponent();
            var timer = new System.Windows.Forms.Timer ();
            timer.Tick += new EventHandler (updateTime);
            timer.Interval = 1000;
            timer.Start ();
            updateTime(new object(), new EventArgs ());
        }

        private void updateTime(Object myObject, EventArgs myEventArgs)
        {
            //handle time display
            string seperator = timeHandler.getTime().Second % 2 == 0 ? ":" : " ";
            string timeString = timeHandler.getTime().Hour.ToString("D2")+ seperator + timeHandler.getTime().Minute.ToString("D2");
            lblClock.Text = timeString;

            //handle logout
            if(logoutTimerBegin != DateTime.MinValue)
            {
                TimeSpan loggedInTime = DateTime.Now - logoutTimerBegin;
                if(loggedInTime.TotalMinutes > settings.autoLogoutTimeout)
                {
                    timeoutReached();
                    logoutTimerBegin = DateTime.MinValue;
                }
                else
                {
                    //Time since login is less then autoLogoutTimeout -> do nothing
                }
            }
            else
            {
                //logout Timer is inactive -> do nothing
            }
        }

        private void onLoad(object sender, EventArgs e) //TODO rename to mainviewL
        {
            lvEmployees.Items.Clear();
            changeToLogin();

        }

        private void startLogoutCountdown()
        {
            logoutTimerBegin = timeHandler.getTime();
        }

        private void timeoutReached()
        {
            this.BeginInvoke(new Action(btnLogout.PerformClick));
        }

        private void loadStatistics()
        {
            lblWorkingTime.Text = String.Format("{0} ({1})", roundTimeSpan(currentEmployee.getTimeWorkedThisWeek(), settings.timeRounding).ToString(@"hh\:mm"), currentEmployee.getTimeWorkedThisWeek().ToString(@"hh\:mm"));
            lblOvertimeRemaining.Text = currentEmployee.getOvertime().ToString(@"hh\:mm");
            lblHolidaysRemaining.Text = currentEmployee.vacationDays.ToString();
        }

        private void checkForPendingVacationRequests()
        {
            int counter = 0;
            foreach (var employee in currentEmployee.subordinates.Values)
            {
                /*foreach(var holidayRequest in employee.absenteeism)
                {
                    if (holidayRequest.state == RequestState.pending)
                    {
                        counter++;
                        var result = MessageBox.Show(employee.surname + " " + employee.name + " beantragt Urlaub vom " + holidayRequest.startTime.ToString("dd.MM.yyyy") + " bis zum " + holidayRequest.endTime.ToString("dd.MM.yyyy") + "\n\n Soll der Urlaub genehmigt werden?", "Urlaubsanfrage", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                        switch (result)
                        {
                            case DialogResult.Yes:
                                holidayRequest.state = RequestState.accepted;
                                break;
                            case DialogResult.No:
                                holidayRequest.state = RequestState.denied;
                                break;
                            default:
                                break;
                        }
                    }
                }*/
            }
            //if(counter != 0)
            //{
            //    MessageBox.Show("Es gibt noch " + counter.ToString() + " offene Urlaubsanfragen.", "Offene Urlaubsanfragen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void updateLvEmployees()
        {
            lvItems.Clear();
            lvEmployees.Items.Clear ();
            foreach (var employee in currentEmployee.subordinates.Values)
            {
                string Id = employee.Id;
                if (!lvItems.ContainsKey(Id))
                    addEmployeeToList((HourlyRatedEmployee)employee);
                else
                {
                    ListViewItem newItem = employeeToItem((HourlyRatedEmployee)employee);
                    for (int i = 0; i < newItem.SubItems.Count; i++)
                    {
                        lvItems[Id].SubItems[i] = newItem.SubItems[i];
                    }
                }
            }
        }

        private TimeSpan roundTimeSpan(TimeSpan inTimeSpan, int numberOfMinutes)
        {
            int roundedMinutes = ((inTimeSpan.Minutes + numberOfMinutes / 2) / numberOfMinutes) * numberOfMinutes;
            TimeSpan timeSpan = new TimeSpan(inTimeSpan.Days ,inTimeSpan.Hours, roundedMinutes, 0);
            return timeSpan;
        }

        private ListViewItem employeeToItem(HourlyRatedEmployee employee)
        {
            List<string> subordinates = ((Dictionary<string, Employee>)employee.subordinates).Select(kvp => (kvp.Value.surname + ", " + kvp.Value.name)).ToList(); ;
            string subordinatesString = string.Join("; ", subordinates);

            ListViewItem listItem = new ListViewItem(new string[] {
                employee.Id,
                employee.surname,
                employee.name,
                subordinatesString,
                employee.weekTimeLimit.TotalHours.ToString(),
                roundTimeSpan(employee.getTimeWorkedThisWeek(), settings.timeRounding).ToString(),
                roundTimeSpan(employee.getOvertime(), settings.timeRounding).ToString(),
                employee.vacationDays.ToString()
            });
            return listItem;
        }

        private void addEmployeeToList(HourlyRatedEmployee employee)
        {
            ListViewItem newItem = employeeToItem(employee);
            lvEmployees.Items.Add(newItem);
            lvItems.Add(employee.Id, newItem);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            startLogoutCountdown();
            EmployeeView newStaffMember = new EmployeeView(null, currentEmployee);
            newStaffMember.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = newStaffMember.ShowDialog(this);
            

            if (result == DialogResult.OK)
            {

                companyData.addEmployee(newStaffMember.getUserData());
                updateLvEmployees();
            }
        }

        private void btnPanelCtrl_Click(object sender, EventArgs e)
        {
            if (activePanel == managementPanel)
            {
                changeToCheckin();
            }
            else if (activePanel == checkInPanel)
            {
                if(currentEmployee.isPasswordInResetState())
                {
                    changeToUpdatePassword();
                }
                else
                {
                    changeToSecureLogin();
                }
            }
            else if (activePanel == loginPanel)
            {
                //called from pnlSecureLogin
                changeToCheckin();
            }
            else
            {
                throw new ErrorException("Panel kann nicht gesetzt werden");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Id = txtEmployeeId.Text;
            //TODO transform key into valid pattern i.e. 0001 -> 1 
            if (companyData.employees.Keys.Contains(Id))
            {
                currentEmployee = (HourlyRatedEmployee)companyData.employees[Id];

                startLogoutCountdown();
                changeToCheckin();
            }
            else
            {
                throw new WarningException("No employee with ID " + Id);
            }

            
        }

        private void btnSecureLogin_Click(object sender, EventArgs e)
        {
            if (currentEmployee.checkPassword(txtPassword.Text))
            {
                lblWrongPassword.Visible = false;
                txtPassword.Text = "";
                startLogoutCountdown();
                changeToManagement();
            }
            else
            {
                lblWrongPassword.Visible = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            currentEmployee = null;
            changeToLogin();
        }

        private void hideAll()
        {
            btnAddEmployee.Visible = false;
            btnEditEmployee.Visible = false;
            managementPanel.Visible = false;
            btnLogout.Visible = false;
            btnPanelCtrl.Visible = false;
            checkInPanel.Visible = false;
            loginPanel.Visible = false;
            pnlChangePassword.Visible = false;
            pnlSecureLogin.Visible = false;
        }

        private void updateCheckInState()
        {
            if (currentEmployee.isCheckedIn())
            {
                lblCheckInState.Text = "Eingestempelt";
                btnCheckIn.Text = "Ausstempeln";
            }
            else
            {
                btnCheckIn.Text = "Einstempeln";
                lblCheckInState.Text = "Ausgestempelt";
            }
        }

        private void changeToUpdatePassword()
        {
            changeToLogin();
            pnlMainLogin.Visible = false;
            pnlChangePassword.Visible = true;
        }

        private void changeToCheckin()
        {
            hideAll();
            checkInPanel.Visible = true;
            btnLogout.Visible = true;
            btnPanelCtrl.Visible = true;
            checkInPanel.BringToFront();
            btnPanelCtrl.Text = "Mitarbeiter verwalten";
            lblWelcome.Text = "Hallo " + currentEmployee.name;
            activePanel = checkInPanel;
            updateCheckInState();
            loadStatistics();
        }


        private void changeToManagement()
        {
            hideAll();
            btnAddEmployee.Visible = true;
            btnEditEmployee.Visible = true;
            managementPanel.Visible = true;
            btnLogout.Visible = true;
            btnPanelCtrl.Visible = true;
            managementPanel.BringToFront();
            btnPanelCtrl.Text = "Ein / Ausstemplen";
            activePanel = managementPanel;
            updateLvEmployees();
            checkForPendingVacationRequests();
        }

        private void changeToLogin()
        {
            hideAll();
            txtEmployeeId.Text = "";
            activePanel = loginPanel;
            loginPanel.Visible = true;
            pnlMainLogin.Visible = true;
            loginPanel.BringToFront();
        }

        /// <summary>
        /// Changes MainView to Panel for Login into secured area
        /// </summary>
        private void changeToSecureLogin()
        {
            changeToLogin();
            pnlMainLogin.Visible = false;
            pnlSecureLogin.Visible = true;
            txtPassword.Text = "";
            lblWrongPassword.Visible = false;
            btnLogout.Visible = true;
            btnPanelCtrl.Visible = true;
            btnPanelCtrl.Text = "Ein / Ausstemplen";
            activePanel = loginPanel;
            this.ActiveControl = txtPassword;
        }

        private void lvEmployees_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                btnEditEmployee.Enabled = true;
            }
            else
            {
                btnEditEmployee.Enabled = false;
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            startLogoutCountdown();
            string id = lvEmployees.SelectedItems[0].Text;
            HourlyRatedEmployee currentEmployee = (HourlyRatedEmployee)companyData.employees[id];
            if (currentEmployee != null)
            {
                EmployeeView newStaffMember = new EmployeeView(currentEmployee, this.currentEmployee); //todo rename to understand difference
                newStaffMember.StartPosition = FormStartPosition.CenterParent;
                DialogResult result = newStaffMember.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    newStaffMember.getUserData();
                    updateLvEmployees();
                }
                else if (result == DialogResult.Abort)
                {
                    companyData.removeEmployee(currentEmployee);
                    lvEmployees.SelectedItems[0].Remove();
                    updateLvEmployees();
                }
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (currentEmployee.isCheckedIn())
            {
                currentEmployee.checkOut(timeHandler);
                loadStatistics();
            }
            else
            {
                currentEmployee.checkIn(timeHandler);
            }
            updateCheckInState();
        }

        private void btnRequestHolidays_Click(object sender, EventArgs e)
        {
            //Todo hier das Fenster für Urlaub beantragen öffnen
            startLogoutCountdown();
            VacationRequestView holidayRequest = new VacationRequestView(currentEmployee);
            holidayRequest.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = holidayRequest.ShowDialog(this);
            if(result == DialogResult.OK)
            {
                holidayRequest.sendVacationRequest();
            }
        }

        private void lblClock_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = !dateTimePicker1.Visible;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedTime = ((DateTimePicker)sender).Value;
            timeHandler.setTime(selectedTime);
            updateTime(null, null);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsView settingsDialog = new SettingsView(this.settings);
            settingsDialog.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = settingsDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                settingsDialog.getSettings();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutView aboutBox1 = new AboutView(settings);
            aboutBox1.StartPosition = FormStartPosition.CenterParent;
            aboutBox1.ShowDialog(this);
        }

        private void lblWorkingTime_Click(object sender, EventArgs e)
        {

        }

        private void lblOvertimeRemaining_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (currentEmployee.setPassword(txtNewPassword.Text, txtNewPasswordRepeated.Text))
            {
                //save new password
                lblPasswordChangeFailed.Visible = false;
                startLogoutCountdown();
                changeToCheckin();
                MessageBox.Show("Passwort wurde erfolgreich geändert","Passwortänderung", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblPasswordChangeFailed.Visible = true;
            }
            // clear password input fields
            txtNewPassword.Clear();
            txtNewPasswordRepeated.Clear();
        }

        private void lblPasswordForgottten_Click(object sender, EventArgs e)
        {
            startLogoutCountdown();
            changeToUpdatePassword();
        }

        private void lvEmployees_DoubleClick(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(btnEditEmployee.PerformClick));
        }

        private void txtEmployeeId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.BeginInvoke(new Action(btnLogin.PerformClick));
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.BeginInvoke(new Action(btnSecureLogin.PerformClick));
                e.Handled = true;
            }
        }
    }
}
