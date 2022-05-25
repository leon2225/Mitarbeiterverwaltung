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

namespace Mitarbeiterverwaltung
{
    public partial class MainViewL : Form
    {
        Panel ?activePanel;
        private CompanyData companyData;
        private HourlyRatedEmployee currentEmployee;
        private Dictionary<string, ListViewItem> lvItems;
        private TimeHandler timeHandler;
        private Settings settings;

        public MainViewL(CompanyData companyData, Settings settings)
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

        private System.Timers.Timer logoutTimer;
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

        private void button4_Click(object sender, EventArgs e)
        {
            EditEmployee newStaffMember = new EditEmployee(null, currentEmployee);
            DialogResult result = newStaffMember.ShowDialog();
            if (result == DialogResult.OK)
            {

                companyData.addEmployee(newStaffMember.getUserData());
                updatelvEmployees();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (activePanel == managementPanel)
            {
                changeToCheckin();
            }
            else if (activePanel == checkInPanel)
            {
                changeToManagement();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string Id = txtEmployeeId.Text;
            if(companyData.employees[Id].checkPassword(txtPassword.Text))
            {
                txtPassword.Text = "";
                txtEmployeeId.Text = "";
                lblWrongPwd.Visible = false;
                currentEmployee = (HourlyRatedEmployee) companyData.employees[Id];
                startLogoutCountdown();
                changeToCheckin();
            }
            else
            {
                lblWrongPwd.Visible = true;
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
        private void changeToCheckin()
        {
            hideAll();
            checkInPanel.Visible = true;
            btnLogout.Visible = true;
            btnPanelCtrl.Visible = true;
            checkInPanel.BringToFront();
            btnPanelCtrl.Text = "Mitarbeiter verwalten";
            lblWelcome.Text = "Willkommen " + currentEmployee.name + "!";
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
        }

        private void changeToLogin()
        {
            hideAll();
            activePanel = loginPanel;
            loginPanel.Visible = true;
            loginPanel.BringToFront();
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
    }
}
