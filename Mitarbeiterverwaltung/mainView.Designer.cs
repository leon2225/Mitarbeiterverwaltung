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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
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
            this.pnlStatistics = new System.Windows.Forms.TableLayoutPanel();
            this.lblHolidaysRemaining = new System.Windows.Forms.Label();
            this.lblOvertimeRemaining = new System.Windows.Forms.Label();
            this.lblHolidaysRemainingTitle = new System.Windows.Forms.Label();
            this.lblOvertimeRemainingTitle = new System.Windows.Forms.Label();
            this.lblWorkingTimeTitle = new System.Windows.Forms.Label();
            this.lblWorkingTime = new System.Windows.Forms.Label();
            this.btnRequestHolidays = new System.Windows.Forms.Button();
            this.pnlCheckInMain = new System.Windows.Forms.Panel();
            this.lblCheckInState = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.pnlMainLogin = new System.Windows.Forms.Panel();
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
            this.pnlChangePassword = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPasswordRepeated = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPasswordChangeFailed = new System.Windows.Forms.Label();
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
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.checkInPanel.SuspendLayout();
            this.pnlStatistics.SuspendLayout();
            this.pnlCheckInMain.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.pnlMainLogin.SuspendLayout();
            this.pnlSecureLogin.SuspendLayout();
            this.pnlChangePassword.SuspendLayout();
            this.managementPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1353, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClock.Location = new System.Drawing.Point(1272, 35);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(81, 24);
            this.lblClock.TabIndex = 1;
            this.lblClock.Text = "22:18";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblClock.Click += new System.EventHandler(this.lblClock_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(1254, 791);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(86, 31);
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
            this.checkInPanel.Controls.Add(this.pnlStatistics);
            this.checkInPanel.Controls.Add(this.pnlCheckInMain);
            this.checkInPanel.Location = new System.Drawing.Point(0, 63);
            this.checkInPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkInPanel.Name = "checkInPanel";
            this.checkInPanel.Size = new System.Drawing.Size(1353, 713);
            this.checkInPanel.TabIndex = 3;
            // 
            // pnlStatistics
            // 
            this.pnlStatistics.ColumnCount = 2;
            this.pnlStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.01942F));
            this.pnlStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.98058F));
            this.pnlStatistics.Controls.Add(this.lblHolidaysRemaining, 1, 2);
            this.pnlStatistics.Controls.Add(this.lblOvertimeRemaining, 1, 1);
            this.pnlStatistics.Controls.Add(this.lblHolidaysRemainingTitle, 0, 2);
            this.pnlStatistics.Controls.Add(this.lblOvertimeRemainingTitle, 0, 1);
            this.pnlStatistics.Controls.Add(this.lblWorkingTimeTitle, 0, 0);
            this.pnlStatistics.Controls.Add(this.lblWorkingTime, 1, 0);
            this.pnlStatistics.Controls.Add(this.btnRequestHolidays, 0, 3);
            this.pnlStatistics.Location = new System.Drawing.Point(3, 576);
            this.pnlStatistics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlStatistics.Name = "pnlStatistics";
            this.pnlStatistics.RowCount = 4;
            this.pnlStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlStatistics.Size = new System.Drawing.Size(353, 133);
            this.pnlStatistics.TabIndex = 6;
            // 
            // lblHolidaysRemaining
            // 
            this.lblHolidaysRemaining.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHolidaysRemaining.AutoSize = true;
            this.lblHolidaysRemaining.Location = new System.Drawing.Point(333, 67);
            this.lblHolidaysRemaining.Name = "lblHolidaysRemaining";
            this.lblHolidaysRemaining.Size = new System.Drawing.Size(17, 20);
            this.lblHolidaysRemaining.TabIndex = 8;
            this.lblHolidaysRemaining.Text = "0";
            // 
            // lblOvertimeRemaining
            // 
            this.lblOvertimeRemaining.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOvertimeRemaining.AutoSize = true;
            this.lblOvertimeRemaining.Location = new System.Drawing.Point(333, 36);
            this.lblOvertimeRemaining.Name = "lblOvertimeRemaining";
            this.lblOvertimeRemaining.Size = new System.Drawing.Size(17, 20);
            this.lblOvertimeRemaining.TabIndex = 7;
            this.lblOvertimeRemaining.Text = "0";
            // 
            // lblHolidaysRemainingTitle
            // 
            this.lblHolidaysRemainingTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHolidaysRemainingTitle.AutoSize = true;
            this.lblHolidaysRemainingTitle.Location = new System.Drawing.Point(3, 67);
            this.lblHolidaysRemainingTitle.Name = "lblHolidaysRemainingTitle";
            this.lblHolidaysRemainingTitle.Size = new System.Drawing.Size(181, 20);
            this.lblHolidaysRemainingTitle.TabIndex = 4;
            this.lblHolidaysRemainingTitle.Text = "Verbleibende Urlaubstage";
            // 
            // lblOvertimeRemainingTitle
            // 
            this.lblOvertimeRemainingTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOvertimeRemainingTitle.AutoSize = true;
            this.lblOvertimeRemainingTitle.Location = new System.Drawing.Point(3, 36);
            this.lblOvertimeRemainingTitle.Name = "lblOvertimeRemainingTitle";
            this.lblOvertimeRemainingTitle.Size = new System.Drawing.Size(185, 20);
            this.lblOvertimeRemainingTitle.TabIndex = 5;
            this.lblOvertimeRemainingTitle.Text = "Verbleibende Überstunden";
            this.lblOvertimeRemainingTitle.Click += new System.EventHandler(this.lblOvertimeRemaining_Click);
            // 
            // lblWorkingTimeTitle
            // 
            this.lblWorkingTimeTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWorkingTimeTitle.AutoSize = true;
            this.lblWorkingTimeTitle.Location = new System.Drawing.Point(3, 0);
            this.lblWorkingTimeTitle.Name = "lblWorkingTimeTitle";
            this.lblWorkingTimeTitle.Size = new System.Drawing.Size(197, 31);
            this.lblWorkingTimeTitle.TabIndex = 3;
            this.lblWorkingTimeTitle.Text = "Arbeitsstunden im aktuellen Monat";
            this.lblWorkingTimeTitle.Click += new System.EventHandler(this.lblWorkingTime_Click);
            // 
            // lblWorkingTime
            // 
            this.lblWorkingTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblWorkingTime.AutoSize = true;
            this.lblWorkingTime.Location = new System.Drawing.Point(333, 5);
            this.lblWorkingTime.Name = "lblWorkingTime";
            this.lblWorkingTime.Size = new System.Drawing.Size(17, 20);
            this.lblWorkingTime.TabIndex = 6;
            this.lblWorkingTime.Text = "0";
            // 
            // btnRequestHolidays
            // 
            this.btnRequestHolidays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatistics.SetColumnSpan(this.btnRequestHolidays, 2);
            this.btnRequestHolidays.Location = new System.Drawing.Point(3, 97);
            this.btnRequestHolidays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRequestHolidays.Name = "btnRequestHolidays";
            this.btnRequestHolidays.Size = new System.Drawing.Size(347, 31);
            this.btnRequestHolidays.TabIndex = 9;
            this.btnRequestHolidays.Text = "Urlaubsverwaltung";
            this.btnRequestHolidays.UseVisualStyleBackColor = true;
            this.btnRequestHolidays.Click += new System.EventHandler(this.btnRequestHolidays_Click);
            // 
            // pnlCheckInMain
            // 
            this.pnlCheckInMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCheckInMain.AutoSize = true;
            this.pnlCheckInMain.Controls.Add(this.lblCheckInState);
            this.pnlCheckInMain.Controls.Add(this.lblWelcome);
            this.pnlCheckInMain.Controls.Add(this.btnCheckIn);
            this.pnlCheckInMain.Location = new System.Drawing.Point(496, 273);
            this.pnlCheckInMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCheckInMain.Name = "pnlCheckInMain";
            this.pnlCheckInMain.Size = new System.Drawing.Size(362, 157);
            this.pnlCheckInMain.TabIndex = 2;
            // 
            // lblCheckInState
            // 
            this.lblCheckInState.AutoSize = true;
            this.lblCheckInState.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCheckInState.Location = new System.Drawing.Point(3, 81);
            this.lblCheckInState.Name = "lblCheckInState";
            this.lblCheckInState.Size = new System.Drawing.Size(173, 32);
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
            this.lblWelcome.Size = new System.Drawing.Size(362, 67);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Hallo LangerLulatschName!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckIn.Location = new System.Drawing.Point(206, 71);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(157, 53);
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
            this.loginPanel.Controls.Add(this.pnlMainLogin);
            this.loginPanel.Controls.Add(this.pnlSecureLogin);
            this.loginPanel.Controls.Add(this.pnlChangePassword);
            this.loginPanel.Location = new System.Drawing.Point(0, 63);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(1353, 713);
            this.loginPanel.TabIndex = 6;
            // 
            // pnlMainLogin
            // 
            this.pnlMainLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMainLogin.Controls.Add(this.label5);
            this.pnlMainLogin.Controls.Add(this.txtEmployeeId);
            this.pnlMainLogin.Controls.Add(this.btnLogin);
            this.pnlMainLogin.Controls.Add(this.label3);
            this.pnlMainLogin.Location = new System.Drawing.Point(520, 209);
            this.pnlMainLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMainLogin.Name = "pnlMainLogin";
            this.pnlMainLogin.Size = new System.Drawing.Size(366, 175);
            this.pnlMainLogin.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(366, 43);
            this.label5.TabIndex = 5;
            this.label5.Text = "Herzlich Willkommen!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmployeeId.Location = new System.Drawing.Point(155, 71);
            this.txtEmployeeId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(206, 34);
            this.txtEmployeeId.TabIndex = 1;
            this.txtEmployeeId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmployeeId_KeyUp);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(233, 117);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 47);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Anmelden";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
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
            this.pnlSecureLogin.Location = new System.Drawing.Point(519, 221);
            this.pnlSecureLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSecureLogin.Name = "pnlSecureLogin";
            this.pnlSecureLogin.Size = new System.Drawing.Size(366, 205);
            this.pnlSecureLogin.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(208, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
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
            this.label8.Size = new System.Drawing.Size(366, 43);
            this.label8.TabIndex = 5;
            this.label8.Text = "Bitte Passwort angeben";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(155, 69);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(206, 34);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
            // 
            // btnSecureLogin
            // 
            this.btnSecureLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSecureLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSecureLogin.Location = new System.Drawing.Point(233, 116);
            this.btnSecureLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSecureLogin.Name = "btnSecureLogin";
            this.btnSecureLogin.Size = new System.Drawing.Size(129, 47);
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
            this.label9.Location = new System.Drawing.Point(3, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Passwort:";
            // 
            // lblWrongPassword
            // 
            this.lblWrongPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWrongPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWrongPassword.ForeColor = System.Drawing.Color.Red;
            this.lblWrongPassword.Location = new System.Drawing.Point(7, 129);
            this.lblWrongPassword.Name = "lblWrongPassword";
            this.lblWrongPassword.Size = new System.Drawing.Size(360, 31);
            this.lblWrongPassword.TabIndex = 6;
            this.lblWrongPassword.Text = "Falsches Passwort!";
            this.lblWrongPassword.Visible = false;
            // 
            // pnlChangePassword
            // 
            this.pnlChangePassword.ColumnCount = 2;
            this.pnlChangePassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlChangePassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.pnlChangePassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.pnlChangePassword.Controls.Add(this.label2, 0, 2);
            this.pnlChangePassword.Controls.Add(this.label1, 0, 1);
            this.pnlChangePassword.Controls.Add(this.btnChangePassword, 1, 3);
            this.pnlChangePassword.Controls.Add(this.txtNewPassword, 1, 1);
            this.pnlChangePassword.Controls.Add(this.txtNewPasswordRepeated, 1, 2);
            this.pnlChangePassword.Controls.Add(this.label6, 0, 0);
            this.pnlChangePassword.Controls.Add(this.lblPasswordChangeFailed, 0, 3);
            this.pnlChangePassword.Location = new System.Drawing.Point(496, 256);
            this.pnlChangePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlChangePassword.Name = "pnlChangePassword";
            this.pnlChangePassword.RowCount = 4;
            this.pnlChangePassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.pnlChangePassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlChangePassword.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlChangePassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlChangePassword.Size = new System.Drawing.Size(414, 211);
            this.pnlChangePassword.TabIndex = 14;
            this.pnlChangePassword.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passwort wiederholen:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Neues Passwort:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangePassword.Location = new System.Drawing.Point(305, 132);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(106, 35);
            this.btnChangePassword.TabIndex = 2;
            this.btnChangePassword.Text = "Speichern";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(225, 57);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(185, 27);
            this.txtNewPassword.TabIndex = 3;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPasswordRepeated
            // 
            this.txtNewPasswordRepeated.Location = new System.Drawing.Point(225, 97);
            this.txtNewPasswordRepeated.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPasswordRepeated.Name = "txtNewPasswordRepeated";
            this.txtNewPasswordRepeated.Size = new System.Drawing.Size(185, 27);
            this.txtNewPasswordRepeated.TabIndex = 4;
            this.txtNewPasswordRepeated.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.pnlChangePassword.SetColumnSpan(this.label6, 2);
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(408, 41);
            this.label6.TabIndex = 5;
            this.label6.Text = "Änderung des Passworts";
            // 
            // lblPasswordChangeFailed
            // 
            this.lblPasswordChangeFailed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPasswordChangeFailed.AutoSize = true;
            this.lblPasswordChangeFailed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordChangeFailed.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordChangeFailed.Location = new System.Drawing.Point(3, 128);
            this.lblPasswordChangeFailed.Name = "lblPasswordChangeFailed";
            this.lblPasswordChangeFailed.Size = new System.Drawing.Size(149, 83);
            this.lblPasswordChangeFailed.TabIndex = 6;
            this.lblPasswordChangeFailed.Text = "Änderung des Passworts nicht möglich!";
            this.lblPasswordChangeFailed.Visible = false;
            // 
            // managementPanel
            // 
            this.managementPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managementPanel.Controls.Add(this.lvEmployees);
            this.managementPanel.Location = new System.Drawing.Point(0, 63);
            this.managementPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.managementPanel.Name = "managementPanel";
            this.managementPanel.Size = new System.Drawing.Size(1353, 713);
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
            listViewItem2.StateImageIndex = 0;
            this.lvEmployees.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvEmployees.Location = new System.Drawing.Point(0, 0);
            this.lvEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvEmployees.MultiSelect = false;
            this.lvEmployees.Name = "lvEmployees";
            this.lvEmployees.Size = new System.Drawing.Size(1353, 713);
            this.lvEmployees.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvEmployees.TabIndex = 12;
            this.lvEmployees.UseCompatibleStateImageBehavior = false;
            this.lvEmployees.View = System.Windows.Forms.View.Details;
            this.lvEmployees.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvEmployees_ItemSelectionChanged);
            this.lvEmployees.DoubleClick += new System.EventHandler(this.lvEmployees_DoubleClick);
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
            this.btnPanelCtrl.Location = new System.Drawing.Point(1090, 791);
            this.btnPanelCtrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPanelCtrl.Name = "btnPanelCtrl";
            this.btnPanelCtrl.Size = new System.Drawing.Size(157, 31);
            this.btnPanelCtrl.TabIndex = 0;
            this.btnPanelCtrl.Text = "Mitarbeiter verwalten";
            this.btnPanelCtrl.UseVisualStyleBackColor = true;
            this.btnPanelCtrl.Visible = false;
            this.btnPanelCtrl.Click += new System.EventHandler(this.btnPanelCtrl_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddEmployee.Location = new System.Drawing.Point(14, 791);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(176, 31);
            this.btnAddEmployee.TabIndex = 4;
            this.btnAddEmployee.Text = "Mitarbeiter Hinzufügen";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Visible = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditEmployee.Enabled = false;
            this.btnEditEmployee.Location = new System.Drawing.Point(197, 791);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(160, 31);
            this.btnEditEmployee.TabIndex = 5;
            this.btnEditEmployee.Text = "Mitarbeiter Bearbeiten";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Visible = false;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(1170, 32);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(94, 27);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 828);
            this.Controls.Add(this.managementPanel);
            this.Controls.Add(this.checkInPanel);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPanelCtrl);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainView";
            this.Text = "Mitarbeiter Verwaltung";
            this.Load += new System.EventHandler(this.MainViewL_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.checkInPanel.ResumeLayout(false);
            this.checkInPanel.PerformLayout();
            this.pnlStatistics.ResumeLayout(false);
            this.pnlStatistics.PerformLayout();
            this.pnlCheckInMain.ResumeLayout(false);
            this.pnlCheckInMain.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.pnlMainLogin.ResumeLayout(false);
            this.pnlMainLogin.PerformLayout();
            this.pnlSecureLogin.ResumeLayout(false);
            this.pnlSecureLogin.PerformLayout();
            this.pnlChangePassword.ResumeLayout(false);
            this.pnlChangePassword.PerformLayout();
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
        private Button btnEditEmployee;
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
        private Label lblPasswordChangeFailed;
        private Panel pnlSecureLogin;
        private Label lblWrongPassword;
        private Label label8;
        private TextBox txtPassword;
        private Button btnSecureLogin;
        private Label label9;
        private Label label4;
        private PrintPreviewDialog printPreviewDialog1;
        private TableLayoutPanel pnlStatistics;
        private Panel pnlCheckInMain;
        private Panel pnlMainLogin;
        private TableLayoutPanel pnlChangePassword;
    }
}