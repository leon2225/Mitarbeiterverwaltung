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
        private System.Timers.Timer logoutTimer;

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
            string seperator = timeHandler.getTime().Second % 2 == 0 ? ":" : " ";
            string timeString = timeHandler.getTime().Hour.ToString("D2")+ seperator + timeHandler.getTime().Minute.ToString("D2");
            lblClock.Text = timeString;
        }

        private void saveIniFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainViewL_Load(object sender, EventArgs e)
        {
            lvEmployees.Items.Clear();
            changeToLogin();

        }

        private void startLogoutCountdown()
        {
            logoutTimer = new System.Timers.Timer();
            logoutTimer.Interval = 1000*60*settings.autoLogoutTimeout; //timout after 15 minutes [ms]

            // Hook up the Elapsed event for the timer. 
            logoutTimer.Elapsed += timeoutReached;

            // Have the timer fire repeated events (true is the default)
            logoutTimer.AutoReset = true;
            // Start the timer
            logoutTimer.Enabled = true;
        }

        private void timeoutReached(Object source, System.Timers.ElapsedEventArgs e)
        {
            this.BeginInvoke(new Action(btnLogout.PerformClick));
        }

        private void loadStatistics()
        {
            lblWorkingTime.Text = currentEmployee.totalWorktime.ToString(@"hh\:mm");
            lblOvertimeRemaining.Text = currentEmployee.overtime.ToString(@"hh\:mm");
            lblHolidaysRemaining.Text = currentEmployee.holidays.ToString();
        }

        private void checkForPendingHolidayRequests()
        {
            int counter = 0;
            foreach (var employee in currentEmployee.subordinates.Values)
            {
                foreach(var holidayRequest in employee.absenteeism)
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
                }
            }
            //if(counter != 0)
            //{
            //    MessageBox.Show("Es gibt noch " + counter.ToString() + " offene Urlaubsanfragen.", "Offene Urlaubsanfragen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void updatelvEmployees()
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
                roundTimeSpan(employee.totalWorktime, settings.timeRounding).ToString(),
                roundTimeSpan(employee.overtime, settings.timeRounding).ToString(),
                employee.holidays.ToString()
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
            EditEmployee newStaffMember = new EditEmployee(null, currentEmployee);
            DialogResult result = newStaffMember.ShowDialog();
            if (result == DialogResult.OK)
            {

                companyData.addEmployee(newStaffMember.getUserData());
                updatelvEmployees();
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
                changeToSecureLogin();
            }
            else if (activePanel == loginPanel)
            {
                //called from pnlSecureLogin
                changeToCheckin();
            }
            else
            {
                throw new Exception("activePanelNotSupported");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Id = txtEmployeeId.Text;
            //TODO transform key into valid pattern i.e. 0001 -> 1 
            if (!companyData.employees.Keys.Contains(Id))
            {
                //TODO throw Error here
            }

            currentEmployee = (HourlyRatedEmployee) companyData.employees[Id];
            
            startLogoutCountdown();
            loadStatistics();
            changeToCheckin();
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
            btnRemoveEmployee.Visible = false;
            managementPanel.Visible = false;
            btnLogout.Visible = false;
            btnPanelCtrl.Visible = false;
            checkInPanel.Visible = false;
            loginPanel.Visible = false;
            changePasswordPanel.Visible = false;
            pnlSecureLogin.Visible = false;
        }

        private void updateCheckInState()
        {
            bool checkedIn = currentEmployee.startTime > currentEmployee.endTime;
            if (checkedIn)
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
            fullLoginPanel.Visible = false;
            changePasswordPanel.Visible = true;
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
        }


        private void changeToManagement()
        {
            hideAll();
            btnAddEmployee.Visible = true;
            btnRemoveEmployee.Visible = true;
            managementPanel.Visible = true;
            btnLogout.Visible = true;
            btnPanelCtrl.Visible = true;
            managementPanel.BringToFront();
            btnPanelCtrl.Text = "Ein / Ausstemplen";
            activePanel = managementPanel;
            updatelvEmployees();
            checkForPendingHolidayRequests();
        }

        private void changeToLogin()
        {
            hideAll();
            txtEmployeeId.Text = "";
            activePanel = loginPanel;
            loginPanel.Visible = true;
            fullLoginPanel.Visible = true;
            loginPanel.BringToFront();
        }

        /// <summary>
        /// Changes MainView to Panel for Login into secured area
        /// </summary>
        private void changeToSecureLogin()
        {
            changeToLogin();
            fullLoginPanel.Visible = false;
            pnlSecureLogin.Visible = true;
            txtPassword.Text = "";
            lblWrongPassword.Visible = false;
            btnLogout.Visible = true;
            btnPanelCtrl.Visible = true;
            btnPanelCtrl.Text = "Ein / Ausstemplen";
            activePanel = loginPanel;
        }

        private void lvEmployees_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                btnRemoveEmployee.Enabled = true;
            }
            else
            {
                btnRemoveEmployee.Enabled = false;
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            string id = lvEmployees.SelectedItems[0].Text;
            HourlyRatedEmployee currentEmployee = (HourlyRatedEmployee)companyData.employees[id];
            if (currentEmployee != null)
            {
                EditEmployee newStaffMember = new EditEmployee(currentEmployee, this.currentEmployee);
                DialogResult result = newStaffMember.ShowDialog();
                if (result == DialogResult.OK)
                {
                    newStaffMember.getUserData();
                    updatelvEmployees();
                }
                else if (result == DialogResult.Abort)
                {
                    companyData.removeEmployee(currentEmployee);
                    lvEmployees.SelectedItems[0].Remove();
                    updatelvEmployees();
                }
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (currentEmployee.startTime > currentEmployee.endTime)
                currentEmployee.checkOut(timeHandler);
            else
                currentEmployee.checkIn(timeHandler);

            updateCheckInState();
        }

        private void btnRequestHolidays_Click(object sender, EventArgs e)
        {
            //Todo hier das Fenster für Urlaub beantragen öffnen
            HolidayRequestView holidayRequest = new HolidayRequestView(currentEmployee);
            DialogResult result = holidayRequest.ShowDialog();
            if(result == DialogResult.OK)
            {
                holidayRequest.sendHolidayRequest();
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
            SettingsDialog settingsDialog = new SettingsDialog(this.settings);
            DialogResult result = settingsDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                settingsDialog.getSettings();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutBox1 = new About(settings);
            aboutBox1.ShowDialog();
        }

        private void lblWorkingTime_Click(object sender, EventArgs e)
        {

        }

        private void lblOvertimeRemaining_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == txtNewPasswordRepeated.Text)
            {
                //save new password
                currentEmployee.setPassword(txtNewPassword.Text);
                lblPasswordsNotEqual.Visible = false;
                startLogoutCountdown();
                loadStatistics();
                changeToCheckin();
            }
            else
            {
                lblPasswordsNotEqual.Visible = true;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployeeId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSecureLogin_Click(sender, e);
                e.Handled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            changeToUpdatePassword();
        }
    }
}
