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

namespace Mitarbeiterverwaltung
{
    public partial class MainViewL : Form
    {
        Panel ?activePanel;
        private CompanyData companyData;
        private Dictionary<string, ListViewItem> lvItems;

        public MainViewL(CompanyData companyData)
        {
            this.companyData = companyData;
            lvItems = new Dictionary<string, ListViewItem > ();
            InitializeComponent();
        }

        private void saveIniFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainViewL_Load(object sender, EventArgs e)
        {
            lvEmployees.Items.Clear();
            updatelvEmployees();
            changeToLogin();

        }

        private void updatelvEmployees()
        {
            
            foreach (var employee in companyData.employees.Values)
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

        private ListViewItem employeeToItem(HourlyRatedEmployee employee)
        {
            List<string> subordinates = ((Dictionary<string, Employee>)employee.subordinates).Select(kvp => (kvp.Value.name + ", " + kvp.Value.surname)).ToList(); ;
            string subordinatesString = string.Join("; ", subordinates);

            ListViewItem listItem = new ListViewItem(new string[] {
                employee.Id,
                employee.surname,
                employee.name,
                subordinatesString,
                employee.weekTimeLimit.TotalHours.ToString(),
                employee.totalWorktime.ToString(),
                employee.overtime.ToString(),
                employee.holidays.ToString()
            });
            return listItem;
        }

        private void addEmployeeToList(HourlyRatedEmployee employee)
        {
            ListViewItem newItem = employeeToItem(employee);
            lvEmployees.Items.Add(newItem);
            lvItems.Add(employee.Id, newItem);
            
            /*
            int Id = Int32.Parse(employee.Id);
            if (lvEmployees.Items.Count > Id)
            {
                for (int i = 0; i < newItem.SubItems.Count; i++)
                {
                    lvEmployees.Items[Id].SubItems[i] = newItem.SubItems[i];
                }
            }
            else
            {
                
            }*/
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewStaffMember newStaffMember = new NewStaffMember(null);
            DialogResult result = newStaffMember.ShowDialog();
            if (result == DialogResult.OK)
            {
                companyData.addEmployee(newStaffMember.getUserData());
                updatelvEmployees();
            }
        }

        private void listView_staffMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

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
            changeToCheckin();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
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
        private void changeToCheckin()
        {
            hideAll();
            checkInPanel.Visible = true;
            btnLogout.Visible = true;
            btnPanelCtrl.Visible = true;
            checkInPanel.BringToFront();
            btnPanelCtrl.Text = "Mitarbeiter verwalten";
            activePanel = checkInPanel;
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            string id = lvEmployees.SelectedItems[0].Text;
            HourlyRatedEmployee currentEmployee = (HourlyRatedEmployee)companyData.employees[id];
            if (currentEmployee != null)
            {
                NewStaffMember newStaffMember = new NewStaffMember(currentEmployee);
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
    }
}
