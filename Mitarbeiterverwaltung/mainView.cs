namespace Mitarbeiterverwaltung
{
    public partial class mainView : Form
    {
        public mainView()
        {
            InitializeComponent();
            LoginWindow newLogin = new LoginWindow();
            newLogin.ShowDialog();
            if (String.Equals(newLogin.getUserRole(), "admin"))
            {
                label_headerAdmin.Show();
                button_add_newStaffMember.Show();
                button_removeStaffMember.Show();
                listBox_staffMembers.Show();
                listView_staffMembers.Show();
            }
            else
            {
                label_headerUser.Show();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            //hier wird der aktuelle Nutzer abgemeldet
            //alle Felder deaktivieren
            label_headerAdmin.Hide();
            button_add_newStaffMember.Hide();
            button_removeStaffMember.Hide();
            listBox_staffMembers.Hide();
            listView_staffMembers.Hide();
            LoginWindow newLogin = new LoginWindow();
            newLogin.ShowDialog();
        }

        private void button_add_newStaffMember_Click(object sender, EventArgs e)
        {
            NewStaffMember newStaffMember = new NewStaffMember(null);
            DialogResult result = newStaffMember.ShowDialog();
            if(result == DialogResult.OK)
            {
                Employee staffMember = new HourlyRatedEmployee("Damian", "Goldbach", "Oberhausstraﬂe 7", "01251 1351354", 30, "1234Super", new TimeSpan(37, 0, 0));
                staffMember = newStaffMember.getUserData();
                //update ListView
                listBox_staffMembers.Items.Add(staffMember.name);
                ListViewItem item1 = new ListViewItem("item1", 0);
                listView_staffMembers.Items.Add(item1);
                listView_staffMembers.View = View.Details;
                //write Member to CSV
            }
        }

        private void button_removeStaffMember_Click(object sender, EventArgs e)
        {
            int index = listBox_staffMembers.SelectedIndex;
            if(index == -1)
            {
                MessageBox.Show("No Item selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox_staffMembers.Items.RemoveAt(index);
            }
        }

        private void listView_staffMembers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}