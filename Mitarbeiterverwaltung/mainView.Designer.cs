namespace Mitarbeiterverwaltung
{
    partial class mainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Mitarbeiter 1",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Mitarbeiter 2");
            this.label_headerAdmin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_add_newStaffMember = new System.Windows.Forms.Button();
            this.listBox_staffMembers = new System.Windows.Forms.ListBox();
            this.button_removeStaffMember = new System.Windows.Forms.Button();
            this.label_headerUser = new System.Windows.Forms.Label();
            this.listView_staffMembers = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Nachname = new System.Windows.Forms.ColumnHeader();
            this.Vorname = new System.Windows.Forms.ColumnHeader();
            this.Benutzername = new System.Windows.Forms.ColumnHeader();
            this.Passwort = new System.Windows.Forms.ColumnHeader();
            this.Wochenarbeitszeit = new System.Windows.Forms.ColumnHeader();
            this.Urlaubstage = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label_headerAdmin
            // 
            this.label_headerAdmin.AutoSize = true;
            this.label_headerAdmin.Location = new System.Drawing.Point(12, 9);
            this.label_headerAdmin.Name = "label_headerAdmin";
            this.label_headerAdmin.Size = new System.Drawing.Size(248, 15);
            this.label_headerAdmin.TabIndex = 0;
            this.label_headerAdmin.Text = "Hier ist die Ansicht als Administrator zu sehen";
            this.label_headerAdmin.Visible = false;
            this.label_headerAdmin.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Liste der Mitarbeiter";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(905, 231);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(75, 23);
            this.button_logout.TabIndex = 6;
            this.button_logout.Text = "Abmelden";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_add_newStaffMember
            // 
            this.button_add_newStaffMember.Location = new System.Drawing.Point(12, 172);
            this.button_add_newStaffMember.Name = "button_add_newStaffMember";
            this.button_add_newStaffMember.Size = new System.Drawing.Size(79, 23);
            this.button_add_newStaffMember.TabIndex = 7;
            this.button_add_newStaffMember.Text = "Hinzufügen";
            this.button_add_newStaffMember.UseVisualStyleBackColor = true;
            this.button_add_newStaffMember.Visible = false;
            this.button_add_newStaffMember.Click += new System.EventHandler(this.button_add_newStaffMember_Click);
            // 
            // listBox_staffMembers
            // 
            this.listBox_staffMembers.FormattingEnabled = true;
            this.listBox_staffMembers.ItemHeight = 15;
            this.listBox_staffMembers.Location = new System.Drawing.Point(12, 72);
            this.listBox_staffMembers.MultiColumn = true;
            this.listBox_staffMembers.Name = "listBox_staffMembers";
            this.listBox_staffMembers.ScrollAlwaysVisible = true;
            this.listBox_staffMembers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_staffMembers.Size = new System.Drawing.Size(160, 94);
            this.listBox_staffMembers.TabIndex = 8;
            this.listBox_staffMembers.Visible = false;
            // 
            // button_removeStaffMember
            // 
            this.button_removeStaffMember.Location = new System.Drawing.Point(97, 172);
            this.button_removeStaffMember.Name = "button_removeStaffMember";
            this.button_removeStaffMember.Size = new System.Drawing.Size(75, 23);
            this.button_removeStaffMember.TabIndex = 9;
            this.button_removeStaffMember.Text = "Entfernen";
            this.button_removeStaffMember.UseVisualStyleBackColor = true;
            this.button_removeStaffMember.Visible = false;
            this.button_removeStaffMember.Click += new System.EventHandler(this.button_removeStaffMember_Click);
            // 
            // label_headerUser
            // 
            this.label_headerUser.AutoSize = true;
            this.label_headerUser.Location = new System.Drawing.Point(12, 9);
            this.label_headerUser.Name = "label_headerUser";
            this.label_headerUser.Size = new System.Drawing.Size(212, 15);
            this.label_headerUser.TabIndex = 10;
            this.label_headerUser.Text = "Hier ist die Ansicht als normaler Nutzer";
            this.label_headerUser.Visible = false;
            // 
            // listView_staffMembers
            // 
            this.listView_staffMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nachname,
            this.Vorname,
            this.Benutzername,
            this.Passwort,
            this.Wochenarbeitszeit,
            this.Urlaubstage});
            this.listView_staffMembers.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView_staffMembers.Location = new System.Drawing.Point(178, 72);
            this.listView_staffMembers.MultiSelect = false;
            this.listView_staffMembers.Name = "listView_staffMembers";
            this.listView_staffMembers.Size = new System.Drawing.Size(741, 142);
            this.listView_staffMembers.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView_staffMembers.TabIndex = 11;
            this.listView_staffMembers.UseCompatibleStateImageBehavior = false;
            this.listView_staffMembers.View = System.Windows.Forms.View.Details;
            this.listView_staffMembers.SelectedIndexChanged += new System.EventHandler(this.listView_staffMembers_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Nachname
            // 
            this.Nachname.Text = "Nachname";
            this.Nachname.Width = 120;
            // 
            // Vorname
            // 
            this.Vorname.Text = "Vorname";
            this.Vorname.Width = 120;
            // 
            // Benutzername
            // 
            this.Benutzername.Text = "Benutzername";
            this.Benutzername.Width = 100;
            // 
            // Passwort
            // 
            this.Passwort.Text = "Passwort";
            this.Passwort.Width = 80;
            // 
            // Wochenarbeitszeit
            // 
            this.Wochenarbeitszeit.DisplayIndex = 6;
            this.Wochenarbeitszeit.Text = "Wochenarbeitszeit";
            this.Wochenarbeitszeit.Width = 120;
            // 
            // Urlaubstage
            // 
            this.Urlaubstage.DisplayIndex = 5;
            this.Urlaubstage.Text = "Urlaubstage";
            this.Urlaubstage.Width = 80;
            // 
            // mainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 261);
            this.Controls.Add(this.listView_staffMembers);
            this.Controls.Add(this.label_headerUser);
            this.Controls.Add(this.button_removeStaffMember);
            this.Controls.Add(this.listBox_staffMembers);
            this.Controls.Add(this.button_add_newStaffMember);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_headerAdmin);
            this.Name = "mainView";
            this.Text = "Mitarbeiterverwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private Button button3;
        private Button button_logout;
        private Button button_add_newStaffMember;
        private ListBox listBox_staffMembers;
        private Button button_removeStaffMember;
        private Label label_headerAdmin;
        private Label label_headerUser;
        private ListView listView_staffMembers;
        private ColumnHeader Nachname;
        private ColumnHeader Vorname;
        private ColumnHeader Benutzername;
        private ColumnHeader Passwort;
        private ColumnHeader Wochenarbeitszeit;
        private ColumnHeader Urlaubstage;
        private ColumnHeader ID;
    }
}