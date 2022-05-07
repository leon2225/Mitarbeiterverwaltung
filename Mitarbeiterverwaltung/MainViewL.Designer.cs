namespace Mitarbeiterverwaltung
{
    partial class MainViewL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "5",
            "Rolf",
            "12"}, -1);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveIniFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.checkInPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvEmployees = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Nachname = new System.Windows.Forms.ColumnHeader();
            this.Vorname = new System.Windows.Forms.ColumnHeader();
            this.Wochenarbeitszeit = new System.Windows.Forms.ColumnHeader();
            this.Urlaubstage = new System.Windows.Forms.ColumnHeader();
            this.subordinates = new System.Windows.Forms.ColumnHeader();
            this.totalWorktime = new System.Windows.Forms.ColumnHeader();
            this.overtime = new System.Windows.Forms.ColumnHeader();
            this.managementPanel = new System.Windows.Forms.Panel();
            this.btnPanelCtrl = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.checkInPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.managementPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveIniFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveIniFileToolStripMenuItem
            // 
            this.saveIniFileToolStripMenuItem.Name = "saveIniFileToolStripMenuItem";
            this.saveIniFileToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveIniFileToolStripMenuItem.Text = "Save .ini-File";
            this.saveIniFileToolStripMenuItem.Click += new System.EventHandler(this.saveIniFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1140, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "22:18";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(1097, 593);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Abmelden";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // checkInPanel
            // 
            this.checkInPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkInPanel.Controls.Add(this.panel1);
            this.checkInPanel.Location = new System.Drawing.Point(0, 47);
            this.checkInPanel.Name = "checkInPanel";
            this.checkInPanel.Size = new System.Drawing.Size(1184, 535);
            this.checkInPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(434, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 96);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hallo Leon!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(180, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "Einstempeln";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginPanel.Controls.Add(this.panel2);
            this.loginPanel.Location = new System.Drawing.Point(0, 47);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(1184, 535);
            this.loginPanel.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtEmployeeId);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(455, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 165);
            this.panel2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Herzlich Willkommen!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(136, 87);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(181, 29);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmployeeId.Location = new System.Drawing.Point(136, 53);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(181, 29);
            this.txtEmployeeId.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(204, 122);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Anmelden";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Passwort:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mitarbeiter ID:";
            // 
            // lvEmployees
            // 
            this.lvEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nachname,
            this.Vorname,
            this.subordinates,
            this.Wochenarbeitszeit,
            this.totalWorktime,
            this.overtime,
            this.Urlaubstage});
            this.lvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEmployees.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvEmployees.Location = new System.Drawing.Point(0, 0);
            this.lvEmployees.MultiSelect = false;
            this.lvEmployees.Name = "lvEmployees";
            this.lvEmployees.Size = new System.Drawing.Size(1184, 535);
            this.lvEmployees.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvEmployees.TabIndex = 12;
            this.lvEmployees.UseCompatibleStateImageBehavior = false;
            this.lvEmployees.View = System.Windows.Forms.View.Details;
            this.lvEmployees.SelectedIndexChanged += new System.EventHandler(this.listView_staffMembers_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Nachname
            // 
            this.Nachname.Text = "Nachname";
            this.Nachname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Nachname.Width = 120;
            // 
            // Vorname
            // 
            this.Vorname.Text = "Vorname";
            this.Vorname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Vorname.Width = 120;
            // 
            // Wochenarbeitszeit
            // 
            this.Wochenarbeitszeit.Text = "Wochenarbeitszeit";
            this.Wochenarbeitszeit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Wochenarbeitszeit.Width = 120;
            // 
            // Urlaubstage
            // 
            this.Urlaubstage.Text = "Urlaubstage";
            this.Urlaubstage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Urlaubstage.Width = 80;
            // 
            // subordinates
            // 
            this.subordinates.Text = "Untergebene";
            this.subordinates.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.subordinates.Width = 200;
            // 
            // totalWorktime
            // 
            this.totalWorktime.Text = "Bereits gearbeitet";
            this.totalWorktime.Width = 105;
            // 
            // overtime
            // 
            this.overtime.Text = "Überstunden";
            this.overtime.Width = 80;
            // 
            // managementPanel
            // 
            this.managementPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managementPanel.Controls.Add(this.lvEmployees);
            this.managementPanel.Location = new System.Drawing.Point(0, 47);
            this.managementPanel.Name = "managementPanel";
            this.managementPanel.Size = new System.Drawing.Size(1184, 535);
            this.managementPanel.TabIndex = 4;
            this.managementPanel.Visible = false;
            // 
            // btnPanelCtrl
            // 
            this.btnPanelCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPanelCtrl.Location = new System.Drawing.Point(954, 593);
            this.btnPanelCtrl.Name = "btnPanelCtrl";
            this.btnPanelCtrl.Size = new System.Drawing.Size(137, 23);
            this.btnPanelCtrl.TabIndex = 0;
            this.btnPanelCtrl.Text = "Mitarbeiter verwalten";
            this.btnPanelCtrl.UseVisualStyleBackColor = true;
            this.btnPanelCtrl.Visible = false;
            this.btnPanelCtrl.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddEmployee.Location = new System.Drawing.Point(12, 593);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(154, 23);
            this.btnAddEmployee.TabIndex = 4;
            this.btnAddEmployee.Text = "Mitarbeiter Hinzufügen";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Visible = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveEmployee.Location = new System.Drawing.Point(172, 593);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(140, 23);
            this.btnRemoveEmployee.TabIndex = 5;
            this.btnRemoveEmployee.Text = "Mitarbeiter Entfernen";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Visible = false;
            // 
            // MainViewL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 621);
            this.Controls.Add(this.managementPanel);
            this.Controls.Add(this.btnRemoveEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPanelCtrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.checkInPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainViewL";
            this.Text = "MainViewL";
            this.Load += new System.EventHandler(this.MainViewL_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.checkInPanel.ResumeLayout(false);
            this.checkInPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.managementPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveIniFileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label label1;
        private Panel checkInPanel;
        private Button btnPanelCtrl;
        private Button btnLogout;
        private Label label2;
        private Button button3;
        private Panel panel1;
        private Panel managementPanel;
        private ListView lvEmployees;
        private ColumnHeader ID;
        private ColumnHeader Nachname;
        private ColumnHeader Vorname;
        private ColumnHeader Wochenarbeitszeit;
        private ColumnHeader Urlaubstage;
        private Button btnAddEmployee;
        private Button btnRemoveEmployee;
        private ColumnHeader subordinates;
        private ColumnHeader totalWorktime;
        private ColumnHeader overtime;
        private Panel loginPanel;
        private Panel panel2;
        private Label label5;
        private TextBox txtPassword;
        private TextBox txtEmployeeId;
        private Button btnLogin;
        private Label label4;
        private Label label3;
    }
}