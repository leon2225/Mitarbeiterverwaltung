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
    /// <summary>
    /// Main window of the application displaying the checkInView, statistics and the ManagementView. 
    /// </summary>
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

        /// <summary>
        /// Updates the time for the system used for automatic logout and displaying current time to the employee.
        /// </summary>
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

        /// <summary>
        /// Reset the window to login and clear employee list when the application is loaded.
        /// </summary>
        private void onLoad(object sender, EventArgs e)
        {
            lvEmployees.Items.Clear();
            changeToLogin();
        }

        /// <summary>
        /// Set or reset the start time for the auto logout timer to current system time.
        /// </summary>
        private void startLogoutCountdown()
        {
            logoutTimerBegin = DateTime.Now;
        }

        /// <summary>
        /// Logout current employee if timer is expired.
        /// </summary>
        private void timeoutReached()
        {
            this.BeginInvoke(new Action(btnLogout.PerformClick));
        }

        /// <summary>
        /// Loads the latest statistics to make the working and vacation times visible for the current employee.
        /// </summary>
        private void loadStatistics()
        {
            TimeSpan timeWorked = currentEmployee.getTimeWorkedIn(timeHandler.getMonth());
            lblWorkingTime.Text = String.Format("{0} ({1})",
                TimeSpanToString( roundTimeSpan(timeWorked, settings.timeRounding)), 
                TimeSpanToString( timeWorked));
            lblOvertimeRemaining.Text = TimeSpanToString(currentEmployee.getOvertime(timeHandler));
            lblHolidaysRemaining.Text = currentEmployee.getVacationDaysLeft().ToString();
        }

        /// <summary>
        /// Check for all subordinates if there are open vacation requests to remind the supervisor to decide over them.
        /// </summary>
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

        /// <summary>
        /// Clear the ListView for subordinates and add all subordinates to ListView
        /// </summary>
        private void updateLvEmployees()
        {
            // load date for colum title 
            lvEmployees.Columns[lvEmployees.Columns.Count - 2].Text = "Arbeitsstunden " + timeHandler.getMonthName();
            lvEmployees.Columns[lvEmployees.Columns.Count - 3].Text = "Verbleibende Urlaubstage " + timeHandler.getYear();
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

        /// <summary>
        /// Round a TimeSpan to a given precision of minutes 
        /// </summary>
        /// <param name="inTimeSpan">TimeSpan to round</param>
        /// <param name="numberOfMinutes">rounding precision</param>
        /// <returns>rounded TimeSpan</returns>
        private TimeSpan roundTimeSpan(TimeSpan inTimeSpan, int numberOfMinutes)
        {
            int roundedMinutes = ((inTimeSpan.Minutes + numberOfMinutes / 2) / numberOfMinutes) * numberOfMinutes;
            TimeSpan timeSpan = new TimeSpan(inTimeSpan.Days ,inTimeSpan.Hours, roundedMinutes, 0);
            return timeSpan;
        }

        /// <summary>
        /// Converts TimeSpan into string, but with totalhours
        /// </summary>
        /// <param name="timeSpan">TimeSpan to transform into string</param>
        /// <returns>String that represents TimeSpan</returns>
        private String TimeSpanToString(TimeSpan timeSpan)
        {
            return (int)timeSpan.TotalHours + timeSpan.ToString(@"\:mm");
        }

        /// <summary>
        /// Convert the properties of an Employee to a ListViewItem to display in ListView
        /// </summary>
        /// <param name="employee">hourly payed employee</param>
        /// <returns>ListViewItem to Display in a ListView</returns>
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
                employee.vacationDays.ToString(),
                employee.getVacationDaysLeft().ToString(),
                TimeSpanToString( roundTimeSpan(employee.getTimeWorkedIn(timeHandler.getMonth()), settings.timeRounding)),
                TimeSpanToString( roundTimeSpan( employee.getOvertime(timeHandler), settings.timeRounding)),
            });
            return listItem;
        }

        /// <summary>
        /// Adds a single employee to the ListView in ManagmentView.
        /// </summary>
        /// <param name="employee"></param>
        private void addEmployeeToList(HourlyRatedEmployee employee)
        {
            ListViewItem newItem = employeeToItem(employee);
            lvEmployees.Items.Add(newItem);
            lvItems.Add(employee.Id, newItem);
        }

        /// <summary>
        /// Opens a Dialog to register a new Employee in the system and updates the ListView.
        /// </summary>
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
            else
            {
                //Employee should not be added -> do nothing
            }
        }

        /// <summary>
        /// Change the Panel from CheckInOut to ManagementView and the other way round.
        /// </summary>
        /// <remarks>To become access to ManagementView the user must be authenticated via a password first.</remarks>
        /// <exception cref="ErrorException"></exception>
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
                throw new ErrorException("Panel kann nicht gesetzt werden.");
            }
        }

        /// <summary>
        /// Sign in the current user to checkInOutView if id is assigned to a valid employee.
        /// </summary>
        /// <remarks>At this stage no additional authentication is required to access checkInOutView.</remarks>
        /// <exception cref="WarningException"></exception>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Id = txtEmployeeId.Text;
            if (companyData.employees.Keys.Contains(Id))
            {
                currentEmployee = (HourlyRatedEmployee)companyData.employees[Id];

                startLogoutCountdown();
                changeToCheckin();
            }
            else
            {
                throw new WarningException("Es existiert kein Mitarbeiter mit der Id " + Id + ".");
            }
        }

        /// <summary>
        /// Sign in the current user to ManagementView if password is correct.
        /// </summary>
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

        /// <summary>
        /// Sign out the current employee and load LoginView.
        /// </summary>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            currentEmployee = null;
            changeToLogin();
        }

        /// <summary>
        /// Hide all elements from MainView to load next view.
        /// </summary>
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

        /// <summary>
        /// Toggle the title of the button and the corresponding label when checkIn state changes.
        /// </summary>
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

        /// <summary>
        /// Load the Panel to enter a new password.
        /// </summary>
        private void changeToUpdatePassword()
        {
            changeToLogin();
            pnlMainLogin.Visible = false;
            pnlChangePassword.Visible = true;
        }

        /// <summary>
        /// Change the view to CheckInPanel and update statistics.
        /// </summary>
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

        /// <summary>
        /// Change the view to ManagementView and load ListView of subordinates.
        /// </summary>
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

        /// <summary>
        /// Change the view to LoginView.
        /// </summary>
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
        /// Changes MainView to Panel for Login into secured area.
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

        /// <summary>
        /// Toggle the button for edit the selected employee if any is selected.
        /// </summary>
        private void lvEmployees_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            bool enableState = lvEmployees.SelectedItems.Count > 0;
            btnEditEmployee.Enabled = enableState;
        }

        /// <summary>
        /// Opens a Dialog to edit a selected employee and updates the ListView if employee is deleted.
        /// </summary>
        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            startLogoutCountdown();
            string id = lvEmployees.SelectedItems[0].Text;

            //No check needed, because only valid employee-IDs are selectable
            HourlyRatedEmployee selectedEmployee = (HourlyRatedEmployee)companyData.employees[id];
            
            EmployeeView employeeView = new EmployeeView(selectedEmployee, currentEmployee);
            employeeView.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = employeeView.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                employeeView.getUserData();
                updateLvEmployees();
            }
            else if (result == DialogResult.Abort)
            {
                companyData.removeEmployee(ref selectedEmployee);
                //lvEmployees.SelectedItems[0].Remove();
                updateLvEmployees();
            }
        }

        /// <summary>
        /// Check in or check out the current employee.
        /// </summary>
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

        /// <summary>
        /// Opens a Dialog to manage personal vacation.
        /// </summary>
        /// <remarks>Possibility to view old requests or add a new request</remarks>
        private void btnVacationManagement_Click(object sender, EventArgs e)
        {
            startLogoutCountdown();
            VacationManagementView vacationRequest = new VacationManagementView(currentEmployee, timeHandler);
            vacationRequest.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = vacationRequest.ShowDialog(this);
            
        }

        /// <summary>
        /// Enables the testing possibility to change the current system time.
        /// </summary>
        private void lblClock_Click(object sender, EventArgs e)
        {
            dtpManipulateTime.Visible = !dtpManipulateTime.Visible;
        }

        /// <summary>
        /// Updates the system time if value is changed manually. 
        /// </summary>
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedTime = ((DateTimePicker)sender).Value;
            timeHandler.setTime(selectedTime);
            updateTime(null, null);
        }

        /// <summary>
        /// Opens a new Dialog with system settings. 
        /// </summary>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //User needs to be logged in and have the right (be supervisor of some kind) to edit settings
            if(activePanel == managementPanel && currentEmployee.subordinates.Count > 0)
            {
                SettingsView settingsDialog = new SettingsView(this.settings);
                settingsDialog.StartPosition = FormStartPosition.CenterParent;
                DialogResult result = settingsDialog.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    settingsDialog.getSettings();
                }
                else
                {
                    //Not pressed ok -> do nothing
                }
            }
            else
            {
                throw new WarningException("Nur angemeldete, berechtigte Personen dürfen die Einstellungen ändern.");
            }
            
        }

        /// <summary>
        /// Changes the password to the new one if password check was successful otherwise show error. 
        /// </summary>
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (currentEmployee.setPassword(txtNewPassword.Text, txtNewPasswordRepeated.Text))
            {
                lblPasswordChangeFailed.Visible = false;
                startLogoutCountdown();
                changeToCheckin();
                MessageBox.Show("Passwort wurde erfolgreich geändert","Passwortänderung", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblPasswordChangeFailed.Visible = true;
            }
            txtNewPassword.Clear();
            txtNewPasswordRepeated.Clear();
        }

        /// <summary>
        /// Loading the EmployeeView via double click on the listViewItem of the employee. 
        /// </summary>
        private void lvEmployees_DoubleClick(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(btnEditEmployee.PerformClick));
        }

        /// <summary>
        /// Accept also an enter key press on the keyboard as click on the login button to login the employee
        /// </summary>
        private void txtEmployeeId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.BeginInvoke(new Action(btnLogin.PerformClick));
                e.Handled = true;
            }
            else
            {
                //Only login on enter -> do nothing
            }
        }

        /// <summary>
        /// Accept also an enter key press on the keyboard as click on the login button to authenticate the employee.
        /// </summary>
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.BeginInvoke(new Action(btnSecureLogin.PerformClick));
                e.Handled = true;
            } //Only accept on enter -> do nothing
        }

        /// <summary>
        /// EventHandler for displaying help message
        /// </summary>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpView helpView = new HelpView();
            helpView.StartPosition = FormStartPosition.CenterParent;
            helpView.ShowDialog(this);
        }

        /// <summary>
        /// Opens a new Dialog with the about view
        /// </summary>
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutView aboutView = new AboutView(settings);
            aboutView.StartPosition = FormStartPosition.CenterParent;
            aboutView.ShowDialog(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
