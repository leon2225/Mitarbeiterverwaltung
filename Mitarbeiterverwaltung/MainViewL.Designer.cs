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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainViewL));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblClock = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.checkInPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCheckInState = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWrongPwd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.managementPanel = new System.Windows.Forms.Panel();
            this.lvEmployees = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Nachname = new System.Windows.Forms.ColumnHeader();
            this.Vorname = new System.Windows.Forms.ColumnHeader();
            this.subordinates = new System.Windows.Forms.ColumnHeader();
            this.Wochenarbeitszeit = new System.Windows.Forms.ColumnHeader();
            this.totalWorktime = new System.Windows.Forms.ColumnHeader();
            this.overtime = new System.Windows.Forms.ColumnHeader();
            this.Urlaubstage = new System.Windows.Forms.ColumnHeader();
            this.btnPanelCtrl = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblWorkingTimeTitle = new System.Windows.Forms.Label();
            this.lblHolidaysRemainingTitle = new System.Windows.Forms.Label();
            this.lblOvertimeRemainingTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWorkingTime = new System.Windows.Forms.Label();
            this.lblOvertimeRemaining = new System.Windows.Forms.Label();
            this.lblHolidaysRemaining = new System.Windows.Forms.Label();
            this.btnRequestHolidays = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.checkInPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.managementPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClock.Location = new System.Drawing.Point(1113, 26);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(71, 18);
            this.lblClock.TabIndex = 1;
            this.lblClock.Text = "22:18";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblClock.Click += new System.EventHandler(this.lblClock_Click);
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
            this.checkInPanel.Controls.Add(this.tableLayoutPanel1);
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
            this.panel1.Controls.Add(this.lblCheckInState);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.btnCheckIn);
            this.panel1.Location = new System.Drawing.Point(434, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 118);
            this.panel1.TabIndex = 2;
            // 
            // lblCheckInState
            // 
            this.lblCheckInState.AutoSize = true;
            this.lblCheckInState.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCheckInState.Location = new System.Drawing.Point(3, 61);
            this.lblCheckInState.Name = "lblCheckInState";
            this.lblCheckInState.Size = new System.Drawing.Size(136, 25);
            this.lblCheckInState.TabIndex = 2;
            this.lblCheckInState.Text = "Eingestempelt!";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(317, 50);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Hallo Leon!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckIn.Location = new System.Drawing.Point(180, 53);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(137, 40);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Einstempeln";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
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
            this.panel2.Controls.Add(this.lblWrongPwd);
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
            // lblWrongPwd
            // 
            this.lblWrongPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWrongPwd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWrongPwd.ForeColor = System.Drawing.Color.Red;
            this.lblWrongPwd.Location = new System.Drawing.Point(3, 128);
            this.lblWrongPwd.Name = "lblWrongPwd";
            this.lblWrongPwd.Size = new System.Drawing.Size(195, 23);
            this.lblWrongPwd.TabIndex = 6;
            this.lblWrongPwd.Text = "Falsches Passwort!";
            this.lblWrongPwd.Visible = false;
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
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            this.lvEmployees.FullRowSelect = true;
            listViewItem1.StateImageIndex = 0;
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
            this.lvEmployees.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvEmployees_ItemSelectionChanged);
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
            // subordinates
            // 
            this.subordinates.Text = "Untergebene";
            this.subordinates.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.subordinates.Width = 200;
            // 
            // Wochenarbeitszeit
            // 
            this.Wochenarbeitszeit.Text = "Wochenarbeitszeit";
            this.Wochenarbeitszeit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Wochenarbeitszeit.Width = 120;
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
            // Urlaubstage
            // 
            this.Urlaubstage.Text = "Urlaubstage";
            this.Urlaubstage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Urlaubstage.Width = 80;
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
            this.btnPanelCtrl.Click += new System.EventHandler(this.btnPanelCtrl_Click);
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
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveEmployee.Enabled = false;
            this.btnRemoveEmployee.Location = new System.Drawing.Point(172, 593);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(140, 23);
            this.btnRemoveEmployee.TabIndex = 5;
            this.btnRemoveEmployee.Text = "Mitarbeiter Bearbeiten";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Visible = false;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(1024, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(83, 23);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblWorkingTimeTitle
            // 
            this.lblWorkingTimeTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWorkingTimeTitle.AutoSize = true;
            this.lblWorkingTimeTitle.Location = new System.Drawing.Point(3, 4);
            this.lblWorkingTimeTitle.Name = "lblWorkingTimeTitle";
            this.lblWorkingTimeTitle.Size = new System.Drawing.Size(193, 15);
            this.lblWorkingTimeTitle.TabIndex = 3;
            this.lblWorkingTimeTitle.Text = "Arbeitsstunden im aktuellen Monat";
            this.lblWorkingTimeTitle.Click += new System.EventHandler(this.lblWorkingTime_Click);
            // 
            // lblHolidaysRemainingTitle
            // 
            this.lblHolidaysRemainingTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHolidaysRemainingTitle.AutoSize = true;
            this.lblHolidaysRemainingTitle.Location = new System.Drawing.Point(3, 50);
            this.lblHolidaysRemainingTitle.Name = "lblHolidaysRemainingTitle";
            this.lblHolidaysRemainingTitle.Size = new System.Drawing.Size(141, 15);
            this.lblHolidaysRemainingTitle.TabIndex = 4;
            this.lblHolidaysRemainingTitle.Text = "Verbleibende Urlaubstage";
            // 
            // lblOvertimeRemainingTitle
            // 
            this.lblOvertimeRemainingTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOvertimeRemainingTitle.AutoSize = true;
            this.lblOvertimeRemainingTitle.Location = new System.Drawing.Point(3, 27);
            this.lblOvertimeRemainingTitle.Name = "lblOvertimeRemainingTitle";
            this.lblOvertimeRemainingTitle.Size = new System.Drawing.Size(146, 15);
            this.lblOvertimeRemainingTitle.TabIndex = 5;
            this.lblOvertimeRemainingTitle.Text = "Verbleibende Überstunden";
            this.lblOvertimeRemainingTitle.Click += new System.EventHandler(this.lblOvertimeRemaining_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblHolidaysRemaining, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblOvertimeRemaining, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHolidaysRemainingTitle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblOvertimeRemainingTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblWorkingTimeTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblWorkingTime, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRequestHolidays, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 432);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(269, 100);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lblWorkingTime
            // 
            this.lblWorkingTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblWorkingTime.AutoSize = true;
            this.lblWorkingTime.Location = new System.Drawing.Point(253, 4);
            this.lblWorkingTime.Name = "lblWorkingTime";
            this.lblWorkingTime.Size = new System.Drawing.Size(13, 15);
            this.lblWorkingTime.TabIndex = 6;
            this.lblWorkingTime.Text = "0";
            // 
            // lblOvertimeRemaining
            // 
            this.lblOvertimeRemaining.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOvertimeRemaining.AutoSize = true;
            this.lblOvertimeRemaining.Location = new System.Drawing.Point(253, 27);
            this.lblOvertimeRemaining.Name = "lblOvertimeRemaining";
            this.lblOvertimeRemaining.Size = new System.Drawing.Size(13, 15);
            this.lblOvertimeRemaining.TabIndex = 7;
            this.lblOvertimeRemaining.Text = "0";
            // 
            // lblHolidaysRemaining
            // 
            this.lblHolidaysRemaining.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHolidaysRemaining.AutoSize = true;
            this.lblHolidaysRemaining.Location = new System.Drawing.Point(253, 50);
            this.lblHolidaysRemaining.Name = "lblHolidaysRemaining";
            this.lblHolidaysRemaining.Size = new System.Drawing.Size(13, 15);
            this.lblHolidaysRemaining.TabIndex = 8;
            this.lblHolidaysRemaining.Text = "0";
            // 
            // btnRequestHolidays
            // 
            this.btnRequestHolidays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRequestHolidays.Location = new System.Drawing.Point(3, 73);
            this.btnRequestHolidays.Name = "btnRequestHolidays";
            this.btnRequestHolidays.Size = new System.Drawing.Size(209, 23);
            this.btnRequestHolidays.TabIndex = 9;
            this.btnRequestHolidays.Text = "Urlaub beantragen";
            this.btnRequestHolidays.UseVisualStyleBackColor = true;
            this.btnRequestHolidays.Click += new System.EventHandler(this.btnRequestHolidays_Click);
            // 
            // MainViewL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 621);
            this.Controls.Add(this.checkInPanel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnRemoveEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPanelCtrl);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.managementPanel);
            this.Controls.Add(this.loginPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainViewL";
            this.Text = "Mitarbeiter Verwaltung";
            this.Load += new System.EventHandler(this.MainViewL_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.checkInPanel.ResumeLayout(false);
            this.checkInPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.managementPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label lblClock;
        private Panel checkInPanel;
        private Button btnPanelCtrl;
        private Button btnLogout;
        private Label lblWelcome;
        private Button btnCheckIn;
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
        private Label lblWrongPwd;
        private Label lblCheckInState;
        private DateTimePicker dateTimePicker1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblHolidaysRemainingTitle;
        private Label lblOvertimeRemainingTitle;
        private Label lblWorkingTimeTitle;
        private Label lblWorkingTime;
        private Label lblHolidaysRemaining;
        private Label lblOvertimeRemaining;
        private Button btnRequestHolidays;
    }
}