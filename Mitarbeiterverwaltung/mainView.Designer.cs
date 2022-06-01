namespace Mitarbeiterverwaltung
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblClock = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.checkInPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHolidaysRemaining = new System.Windows.Forms.Label();
            this.lblOvertimeRemaining = new System.Windows.Forms.Label();
            this.lblHolidaysRemainingTitle = new System.Windows.Forms.Label();
            this.lblOvertimeRemainingTitle = new System.Windows.Forms.Label();
            this.lblWorkingTimeTitle = new System.Windows.Forms.Label();
            this.lblWorkingTime = new System.Windows.Forms.Label();
            this.btnRequestHolidays = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCheckInState = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.fullLoginPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSecureLogin = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSecureLogin = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblWrongPassword = new System.Windows.Forms.Label();
            this.changePasswordPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPasswordRepeated = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPasswordsNotEqual = new System.Windows.Forms.Label();
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
            this.menuStrip1.SuspendLayout();
            this.checkInPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.fullLoginPanel.SuspendLayout();
            this.pnlSecureLogin.SuspendLayout();
            this.changePasswordPanel.SuspendLayout();
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
            this.lblClock.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            // btnRequestHolidays
            // 
            this.btnRequestHolidays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnRequestHolidays, 2);
            this.btnRequestHolidays.Location = new System.Drawing.Point(3, 73);
            this.btnRequestHolidays.Name = "btnRequestHolidays";
            this.btnRequestHolidays.Size = new System.Drawing.Size(263, 23);
            this.btnRequestHolidays.TabIndex = 9;
            this.btnRequestHolidays.Text = "Urlaub beantragen";
            this.btnRequestHolidays.UseVisualStyleBackColor = true;
            this.btnRequestHolidays.Click += new System.EventHandler(this.btnRequestHolidays_Click);
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
            this.lblWelcome.AutoEllipsis = true;
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(317, 50);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Hallo LangerLulatschName!";
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
            this.loginPanel.Controls.Add(this.fullLoginPanel);
            this.loginPanel.Controls.Add(this.pnlSecureLogin);
            this.loginPanel.Controls.Add(this.changePasswordPanel);
            this.loginPanel.Location = new System.Drawing.Point(0, 47);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(1184, 535);
            this.loginPanel.TabIndex = 6;
            // 
            // fullLoginPanel
            // 
            this.fullLoginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullLoginPanel.Controls.Add(this.label5);
            this.fullLoginPanel.Controls.Add(this.txtEmployeeId);
            this.fullLoginPanel.Controls.Add(this.btnLogin);
            this.fullLoginPanel.Controls.Add(this.label3);
            this.fullLoginPanel.Location = new System.Drawing.Point(455, 157);
            this.fullLoginPanel.Name = "fullLoginPanel";
            this.fullLoginPanel.Size = new System.Drawing.Size(320, 131);
            this.fullLoginPanel.TabIndex = 13;
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
            // txtEmployeeId
            // 
            this.txtEmployeeId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmployeeId.Location = new System.Drawing.Point(136, 53);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(181, 29);
            this.txtEmployeeId.TabIndex = 3;
            this.txtEmployeeId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeId_KeyUp);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(204, 88);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Anmelden";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            // pnlSecureLogin
            // 
            this.pnlSecureLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSecureLogin.Controls.Add(this.label4);
            this.pnlSecureLogin.Controls.Add(this.label8);
            this.pnlSecureLogin.Controls.Add(this.txtPassword);
            this.pnlSecureLogin.Controls.Add(this.btnSecureLogin);
            this.pnlSecureLogin.Controls.Add(this.label9);
            this.pnlSecureLogin.Controls.Add(this.lblWrongPassword);
            this.pnlSecureLogin.Location = new System.Drawing.Point(454, 166);
            this.pnlSecureLogin.Name = "pnlSecureLogin";
            this.pnlSecureLogin.Size = new System.Drawing.Size(320, 154);
            this.pnlSecureLogin.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(182, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Passwort vergessen";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(320, 32);
            this.label8.TabIndex = 5;
            this.label8.Text = "Bitte Passwort angeben";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(136, 52);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(181, 29);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
            // 
            // btnSecureLogin
            // 
            this.btnSecureLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSecureLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSecureLogin.Location = new System.Drawing.Point(204, 87);
            this.btnSecureLogin.Name = "btnSecureLogin";
            this.btnSecureLogin.Size = new System.Drawing.Size(113, 35);
            this.btnSecureLogin.TabIndex = 2;
            this.btnSecureLogin.Text = "Anmelden";
            this.btnSecureLogin.UseVisualStyleBackColor = true;
            this.btnSecureLogin.Click += new System.EventHandler(this.btnSecureLogin_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Passwort:";
            // 
            // lblWrongPassword
            // 
            this.lblWrongPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWrongPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWrongPassword.ForeColor = System.Drawing.Color.Red;
            this.lblWrongPassword.Location = new System.Drawing.Point(6, 97);
            this.lblWrongPassword.Name = "lblWrongPassword";
            this.lblWrongPassword.Size = new System.Drawing.Size(315, 23);
            this.lblWrongPassword.TabIndex = 6;
            this.lblWrongPassword.Text = "Falsches Passwort!";
            this.lblWrongPassword.Visible = false;
            // 
            // changePasswordPanel
            // 
            this.changePasswordPanel.ColumnCount = 2;
            this.changePasswordPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.changePasswordPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.changePasswordPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.changePasswordPanel.Controls.Add(this.label2, 0, 2);
            this.changePasswordPanel.Controls.Add(this.label1, 0, 1);
            this.changePasswordPanel.Controls.Add(this.btnChangePassword, 1, 3);
            this.changePasswordPanel.Controls.Add(this.txtNewPassword, 1, 1);
            this.changePasswordPanel.Controls.Add(this.txtNewPasswordRepeated, 1, 2);
            this.changePasswordPanel.Controls.Add(this.label6, 0, 0);
            this.changePasswordPanel.Controls.Add(this.lblPasswordsNotEqual, 0, 3);
            this.changePasswordPanel.Location = new System.Drawing.Point(434, 192);
            this.changePasswordPanel.Name = "changePasswordPanel";
            this.changePasswordPanel.RowCount = 4;
            this.changePasswordPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.changePasswordPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.changePasswordPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.changePasswordPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.changePasswordPanel.Size = new System.Drawing.Size(362, 158);
            this.changePasswordPanel.TabIndex = 14;
            this.changePasswordPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passwort wiederholen:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Neues Passwort:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangePassword.Location = new System.Drawing.Point(266, 102);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(93, 30);
            this.btnChangePassword.TabIndex = 2;
            this.btnChangePassword.Text = "Speichern";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(197, 43);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(162, 23);
            this.txtNewPassword.TabIndex = 3;
            // 
            // txtNewPasswordRepeated
            // 
            this.txtNewPasswordRepeated.Location = new System.Drawing.Point(197, 73);
            this.txtNewPasswordRepeated.Name = "txtNewPasswordRepeated";
            this.txtNewPasswordRepeated.Size = new System.Drawing.Size(162, 23);
            this.txtNewPasswordRepeated.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.changePasswordPanel.SetColumnSpan(this.label6, 2);
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(356, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Änderung des Initalpassworts";
            // 
            // lblPasswordsNotEqual
            // 
            this.lblPasswordsNotEqual.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPasswordsNotEqual.AutoSize = true;
            this.lblPasswordsNotEqual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordsNotEqual.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordsNotEqual.Location = new System.Drawing.Point(3, 107);
            this.lblPasswordsNotEqual.Name = "lblPasswordsNotEqual";
            this.lblPasswordsNotEqual.Size = new System.Drawing.Size(155, 42);
            this.lblPasswordsNotEqual.TabIndex = 6;
            this.lblPasswordsNotEqual.Text = "Passwörter stimmen nicht überein!";
            this.lblPasswordsNotEqual.Visible = false;
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
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 621);
            this.Controls.Add(this.checkInPanel);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.managementPanel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnRemoveEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPanelCtrl);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Mitarbeiter Verwaltung";
            this.Load += new System.EventHandler(this.MainViewL_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.checkInPanel.ResumeLayout(false);
            this.checkInPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.fullLoginPanel.ResumeLayout(false);
            this.fullLoginPanel.PerformLayout();
            this.pnlSecureLogin.ResumeLayout(false);
            this.pnlSecureLogin.PerformLayout();
            this.changePasswordPanel.ResumeLayout(false);
            this.changePasswordPanel.PerformLayout();
            this.managementPanel.ResumeLayout(false);
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
        private Panel fullLoginPanel;
        private Label label5;
        private TextBox txtEmployeeId;
        private Button btnLogin;
        private Label label3;
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
        private TableLayoutPanel changePasswordPanel;
        private Label label2;
        private Label label1;
        private Button btnChangePassword;
        private TextBox txtNewPassword;
        private TextBox txtNewPasswordRepeated;
        private Label label6;
        private Label lblPasswordsNotEqual;
        private Panel pnlSecureLogin;
        private Label lblWrongPassword;
        private Label label8;
        private TextBox txtPassword;
        private Button btnSecureLogin;
        private Label label9;
        private Label label4;
    }
}