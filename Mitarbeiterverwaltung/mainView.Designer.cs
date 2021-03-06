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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblClock = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.checkInPanel = new System.Windows.Forms.Panel();
            this.pnlStatistics = new System.Windows.Forms.TableLayoutPanel();
            this.btnVacationManagement = new System.Windows.Forms.Button();
            this.lblHolidaysRemainingTitle = new System.Windows.Forms.Label();
            this.lblOvertimeRemainingTitle = new System.Windows.Forms.Label();
            this.lblWorkingTimeTitle = new System.Windows.Forms.Label();
            this.lblHolidaysRemaining = new System.Windows.Forms.Label();
            this.lblOvertimeRemaining = new System.Windows.Forms.Label();
            this.lblWorkingTime = new System.Windows.Forms.Label();
            this.lblHorizontalLine = new System.Windows.Forms.Label();
            this.pnlCheckInMain = new System.Windows.Forms.Panel();
            this.lblCheckInState = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.pnlSecureLogin = new System.Windows.Forms.Panel();
            this.lblSecureLoginTitle = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSecureLogin = new System.Windows.Forms.Button();
            this.lblPasswordInputTitle = new System.Windows.Forms.Label();
            this.lblWrongPassword = new System.Windows.Forms.Label();
            this.pnlMainLogin = new System.Windows.Forms.Panel();
            this.lblReception = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblEmployeeIdTitle = new System.Windows.Forms.Label();
            this.pnlChangePassword = new System.Windows.Forms.TableLayoutPanel();
            this.lblRepeatPasswordTitle = new System.Windows.Forms.Label();
            this.lblNewPasswordTitle = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPasswordRepeated = new System.Windows.Forms.TextBox();
            this.lblChangePasswordTitle = new System.Windows.Forms.Label();
            this.lblPasswordChangeFailed = new System.Windows.Forms.Label();
            this.managementPanel = new System.Windows.Forms.Panel();
            this.lvEmployees = new System.Windows.Forms.ListView();
            this.chEmployeeId = new System.Windows.Forms.ColumnHeader();
            this.chSurname = new System.Windows.Forms.ColumnHeader();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chSubordinates = new System.Windows.Forms.ColumnHeader();
            this.chWeekTimeLimit = new System.Windows.Forms.ColumnHeader();
            this.chVacationDays = new System.Windows.Forms.ColumnHeader();
            this.chVacationDaysRemaining = new System.Windows.Forms.ColumnHeader();
            this.chTotalWorktime = new System.Windows.Forms.ColumnHeader();
            this.chOvertime = new System.Windows.Forms.ColumnHeader();
            this.btnPanelCtrl = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.dtpManipulateTime = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.checkInPanel.SuspendLayout();
            this.pnlStatistics.SuspendLayout();
            this.pnlCheckInMain.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.pnlSecureLogin.SuspendLayout();
            this.pnlMainLogin.SuspendLayout();
            this.pnlChangePassword.SuspendLayout();
            this.managementPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.hilfeToolStripMenuItem});
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "Datei";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.settingsToolStripMenuItem.Text = "Einstellungen";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exitToolStripMenuItem.Text = "Beenden";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            this.hilfeToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
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
            this.btnLogout.TabIndex = 99;
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
            this.checkInPanel.Location = new System.Drawing.Point(0, 47);
            this.checkInPanel.Name = "checkInPanel";
            this.checkInPanel.Size = new System.Drawing.Size(1184, 535);
            this.checkInPanel.TabIndex = 3;
            // 
            // pnlStatistics
            // 
            this.pnlStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlStatistics.ColumnCount = 2;
            this.pnlStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.01942F));
            this.pnlStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.98058F));
            this.pnlStatistics.Controls.Add(this.btnVacationManagement, 0, 5);
            this.pnlStatistics.Controls.Add(this.lblHolidaysRemainingTitle, 0, 4);
            this.pnlStatistics.Controls.Add(this.lblOvertimeRemainingTitle, 0, 3);
            this.pnlStatistics.Controls.Add(this.lblWorkingTimeTitle, 0, 2);
            this.pnlStatistics.Controls.Add(this.lblHolidaysRemaining, 1, 4);
            this.pnlStatistics.Controls.Add(this.lblOvertimeRemaining, 1, 3);
            this.pnlStatistics.Controls.Add(this.lblWorkingTime, 1, 2);
            this.pnlStatistics.Controls.Add(this.lblHorizontalLine, 0, 1);
            this.pnlStatistics.Location = new System.Drawing.Point(3, 404);
            this.pnlStatistics.Name = "pnlStatistics";
            this.pnlStatistics.RowCount = 6;
            this.pnlStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.pnlStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.pnlStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.pnlStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.pnlStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pnlStatistics.Size = new System.Drawing.Size(327, 128);
            this.pnlStatistics.TabIndex = 6;
            // 
            // btnVacationManagement
            // 
            this.btnVacationManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatistics.SetColumnSpan(this.btnVacationManagement, 2);
            this.btnVacationManagement.Location = new System.Drawing.Point(3, 101);
            this.btnVacationManagement.Name = "btnVacationManagement";
            this.btnVacationManagement.Size = new System.Drawing.Size(321, 23);
            this.btnVacationManagement.TabIndex = 9;
            this.btnVacationManagement.Text = "Urlaubsverwaltung";
            this.btnVacationManagement.UseVisualStyleBackColor = true;
            this.btnVacationManagement.Click += new System.EventHandler(this.btnVacationManagement_Click);
            // 
            // lblHolidaysRemainingTitle
            // 
            this.lblHolidaysRemainingTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHolidaysRemainingTitle.AutoSize = true;
            this.lblHolidaysRemainingTitle.Location = new System.Drawing.Point(3, 78);
            this.lblHolidaysRemainingTitle.Name = "lblHolidaysRemainingTitle";
            this.lblHolidaysRemainingTitle.Size = new System.Drawing.Size(141, 15);
            this.lblHolidaysRemainingTitle.TabIndex = 4;
            this.lblHolidaysRemainingTitle.Text = "Verbleibende Urlaubstage";
            // 
            // lblOvertimeRemainingTitle
            // 
            this.lblOvertimeRemainingTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOvertimeRemainingTitle.AutoSize = true;
            this.lblOvertimeRemainingTitle.Location = new System.Drawing.Point(3, 55);
            this.lblOvertimeRemainingTitle.Name = "lblOvertimeRemainingTitle";
            this.lblOvertimeRemainingTitle.Size = new System.Drawing.Size(146, 15);
            this.lblOvertimeRemainingTitle.TabIndex = 5;
            this.lblOvertimeRemainingTitle.Text = "Verbleibende Überstunden";
            // 
            // lblWorkingTimeTitle
            // 
            this.lblWorkingTimeTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWorkingTimeTitle.AutoSize = true;
            this.lblWorkingTimeTitle.Location = new System.Drawing.Point(3, 30);
            this.lblWorkingTimeTitle.Name = "lblWorkingTimeTitle";
            this.lblWorkingTimeTitle.Size = new System.Drawing.Size(193, 15);
            this.lblWorkingTimeTitle.TabIndex = 3;
            this.lblWorkingTimeTitle.Text = "Arbeitsstunden im aktuellen Monat";
            // 
            // lblHolidaysRemaining
            // 
            this.lblHolidaysRemaining.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHolidaysRemaining.AutoSize = true;
            this.lblHolidaysRemaining.Location = new System.Drawing.Point(311, 78);
            this.lblHolidaysRemaining.Name = "lblHolidaysRemaining";
            this.lblHolidaysRemaining.Size = new System.Drawing.Size(13, 15);
            this.lblHolidaysRemaining.TabIndex = 8;
            this.lblHolidaysRemaining.Text = "0";
            // 
            // lblOvertimeRemaining
            // 
            this.lblOvertimeRemaining.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOvertimeRemaining.AutoSize = true;
            this.lblOvertimeRemaining.Location = new System.Drawing.Point(311, 55);
            this.lblOvertimeRemaining.Name = "lblOvertimeRemaining";
            this.lblOvertimeRemaining.Size = new System.Drawing.Size(13, 15);
            this.lblOvertimeRemaining.TabIndex = 7;
            this.lblOvertimeRemaining.Text = "0";
            // 
            // lblWorkingTime
            // 
            this.lblWorkingTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblWorkingTime.AutoSize = true;
            this.lblWorkingTime.Location = new System.Drawing.Point(311, 30);
            this.lblWorkingTime.Name = "lblWorkingTime";
            this.lblWorkingTime.Size = new System.Drawing.Size(13, 15);
            this.lblWorkingTime.TabIndex = 6;
            this.lblWorkingTime.Text = "0";
            // 
            // lblHorizontalLine
            // 
            this.lblHorizontalLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHorizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStatistics.SetColumnSpan(this.lblHorizontalLine, 2);
            this.lblHorizontalLine.Location = new System.Drawing.Point(3, 24);
            this.lblHorizontalLine.MinimumSize = new System.Drawing.Size(0, 1);
            this.lblHorizontalLine.Name = "lblHorizontalLine";
            this.lblHorizontalLine.Size = new System.Drawing.Size(321, 2);
            this.lblHorizontalLine.TabIndex = 11;
            // 
            // pnlCheckInMain
            // 
            this.pnlCheckInMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCheckInMain.AutoSize = true;
            this.pnlCheckInMain.Controls.Add(this.lblCheckInState);
            this.pnlCheckInMain.Controls.Add(this.lblWelcome);
            this.pnlCheckInMain.Controls.Add(this.btnCheckIn);
            this.pnlCheckInMain.Location = new System.Drawing.Point(434, 205);
            this.pnlCheckInMain.Name = "pnlCheckInMain";
            this.pnlCheckInMain.Size = new System.Drawing.Size(317, 118);
            this.pnlCheckInMain.TabIndex = 2;
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
            this.lblWelcome.Text = "Hallo LangerName!";
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
            this.loginPanel.Controls.Add(this.pnlSecureLogin);
            this.loginPanel.Controls.Add(this.pnlMainLogin);
            this.loginPanel.Controls.Add(this.pnlChangePassword);
            this.loginPanel.Location = new System.Drawing.Point(0, 47);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(1184, 535);
            this.loginPanel.TabIndex = 6;
            // 
            // pnlSecureLogin
            // 
            this.pnlSecureLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSecureLogin.Controls.Add(this.lblSecureLoginTitle);
            this.pnlSecureLogin.Controls.Add(this.txtPassword);
            this.pnlSecureLogin.Controls.Add(this.btnSecureLogin);
            this.pnlSecureLogin.Controls.Add(this.lblPasswordInputTitle);
            this.pnlSecureLogin.Controls.Add(this.lblWrongPassword);
            this.pnlSecureLogin.Location = new System.Drawing.Point(454, 166);
            this.pnlSecureLogin.Name = "pnlSecureLogin";
            this.pnlSecureLogin.Size = new System.Drawing.Size(320, 154);
            this.pnlSecureLogin.TabIndex = 14;
            // 
            // lblSecureLoginTitle
            // 
            this.lblSecureLoginTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSecureLoginTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSecureLoginTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSecureLoginTitle.Name = "lblSecureLoginTitle";
            this.lblSecureLoginTitle.Size = new System.Drawing.Size(320, 32);
            this.lblSecureLoginTitle.TabIndex = 5;
            this.lblSecureLoginTitle.Text = "Bitte Passwort angeben";
            this.lblSecureLoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(136, 52);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(181, 29);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
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
            // lblPasswordInputTitle
            // 
            this.lblPasswordInputTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPasswordInputTitle.AutoSize = true;
            this.lblPasswordInputTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordInputTitle.Location = new System.Drawing.Point(3, 55);
            this.lblPasswordInputTitle.Name = "lblPasswordInputTitle";
            this.lblPasswordInputTitle.Size = new System.Drawing.Size(75, 21);
            this.lblPasswordInputTitle.TabIndex = 1;
            this.lblPasswordInputTitle.Text = "Passwort:";
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
            // pnlMainLogin
            // 
            this.pnlMainLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMainLogin.Controls.Add(this.lblReception);
            this.pnlMainLogin.Controls.Add(this.txtEmployeeId);
            this.pnlMainLogin.Controls.Add(this.btnLogin);
            this.pnlMainLogin.Controls.Add(this.lblEmployeeIdTitle);
            this.pnlMainLogin.Location = new System.Drawing.Point(455, 157);
            this.pnlMainLogin.Name = "pnlMainLogin";
            this.pnlMainLogin.Size = new System.Drawing.Size(320, 131);
            this.pnlMainLogin.TabIndex = 13;
            // 
            // lblReception
            // 
            this.lblReception.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReception.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReception.Location = new System.Drawing.Point(0, 0);
            this.lblReception.Name = "lblReception";
            this.lblReception.Size = new System.Drawing.Size(320, 32);
            this.lblReception.TabIndex = 5;
            this.lblReception.Text = "Herzlich Willkommen!";
            this.lblReception.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmployeeId.Location = new System.Drawing.Point(136, 53);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(181, 29);
            this.txtEmployeeId.TabIndex = 1;
            this.txtEmployeeId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeId_KeyPress);
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
            // lblEmployeeIdTitle
            // 
            this.lblEmployeeIdTitle.AutoSize = true;
            this.lblEmployeeIdTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeIdTitle.Location = new System.Drawing.Point(3, 56);
            this.lblEmployeeIdTitle.Name = "lblEmployeeIdTitle";
            this.lblEmployeeIdTitle.Size = new System.Drawing.Size(109, 21);
            this.lblEmployeeIdTitle.TabIndex = 0;
            this.lblEmployeeIdTitle.Text = "Mitarbeiter ID:";
            // 
            // pnlChangePassword
            // 
            this.pnlChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlChangePassword.ColumnCount = 2;
            this.pnlChangePassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlChangePassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.pnlChangePassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlChangePassword.Controls.Add(this.lblRepeatPasswordTitle, 0, 2);
            this.pnlChangePassword.Controls.Add(this.lblNewPasswordTitle, 0, 1);
            this.pnlChangePassword.Controls.Add(this.btnChangePassword, 1, 3);
            this.pnlChangePassword.Controls.Add(this.txtNewPassword, 1, 1);
            this.pnlChangePassword.Controls.Add(this.txtNewPasswordRepeated, 1, 2);
            this.pnlChangePassword.Controls.Add(this.lblChangePasswordTitle, 0, 0);
            this.pnlChangePassword.Controls.Add(this.lblPasswordChangeFailed, 0, 3);
            this.pnlChangePassword.Location = new System.Drawing.Point(434, 192);
            this.pnlChangePassword.Name = "pnlChangePassword";
            this.pnlChangePassword.RowCount = 4;
            this.pnlChangePassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.pnlChangePassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pnlChangePassword.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlChangePassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pnlChangePassword.Size = new System.Drawing.Size(362, 158);
            this.pnlChangePassword.TabIndex = 14;
            this.pnlChangePassword.Visible = false;
            // 
            // lblRepeatPasswordTitle
            // 
            this.lblRepeatPasswordTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRepeatPasswordTitle.AutoSize = true;
            this.lblRepeatPasswordTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRepeatPasswordTitle.Location = new System.Drawing.Point(3, 74);
            this.lblRepeatPasswordTitle.Name = "lblRepeatPasswordTitle";
            this.lblRepeatPasswordTitle.Size = new System.Drawing.Size(165, 21);
            this.lblRepeatPasswordTitle.TabIndex = 1;
            this.lblRepeatPasswordTitle.Text = "Passwort wiederholen:";
            // 
            // lblNewPasswordTitle
            // 
            this.lblNewPasswordTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNewPasswordTitle.AutoSize = true;
            this.lblNewPasswordTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewPasswordTitle.Location = new System.Drawing.Point(3, 44);
            this.lblNewPasswordTitle.Name = "lblNewPasswordTitle";
            this.lblNewPasswordTitle.Size = new System.Drawing.Size(123, 21);
            this.lblNewPasswordTitle.TabIndex = 0;
            this.lblNewPasswordTitle.Text = "Neues Passwort:";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangePassword.Location = new System.Drawing.Point(266, 102);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(93, 26);
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
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPasswordRepeated
            // 
            this.txtNewPasswordRepeated.Location = new System.Drawing.Point(197, 73);
            this.txtNewPasswordRepeated.Name = "txtNewPasswordRepeated";
            this.txtNewPasswordRepeated.Size = new System.Drawing.Size(162, 23);
            this.txtNewPasswordRepeated.TabIndex = 4;
            this.txtNewPasswordRepeated.UseSystemPasswordChar = true;
            // 
            // lblChangePasswordTitle
            // 
            this.lblChangePasswordTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChangePasswordTitle.AutoSize = true;
            this.pnlChangePassword.SetColumnSpan(this.lblChangePasswordTitle, 2);
            this.lblChangePasswordTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChangePasswordTitle.Location = new System.Drawing.Point(3, 4);
            this.lblChangePasswordTitle.Name = "lblChangePasswordTitle";
            this.lblChangePasswordTitle.Size = new System.Drawing.Size(356, 32);
            this.lblChangePasswordTitle.TabIndex = 5;
            this.lblChangePasswordTitle.Text = "Änderung des Passworts";
            // 
            // lblPasswordChangeFailed
            // 
            this.lblPasswordChangeFailed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPasswordChangeFailed.AutoSize = true;
            this.lblPasswordChangeFailed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordChangeFailed.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordChangeFailed.Location = new System.Drawing.Point(3, 107);
            this.lblPasswordChangeFailed.Name = "lblPasswordChangeFailed";
            this.lblPasswordChangeFailed.Size = new System.Drawing.Size(184, 42);
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
            this.managementPanel.Location = new System.Drawing.Point(0, 47);
            this.managementPanel.Name = "managementPanel";
            this.managementPanel.Size = new System.Drawing.Size(1184, 535);
            this.managementPanel.TabIndex = 4;
            this.managementPanel.Visible = false;
            // 
            // lvEmployees
            // 
            this.lvEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEmployeeId,
            this.chSurname,
            this.chName,
            this.chSubordinates,
            this.chWeekTimeLimit,
            this.chVacationDays,
            this.chVacationDaysRemaining,
            this.chTotalWorktime,
            this.chOvertime});
            this.lvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEmployees.FullRowSelect = true;
            this.lvEmployees.Location = new System.Drawing.Point(0, 0);
            this.lvEmployees.MultiSelect = false;
            this.lvEmployees.Name = "lvEmployees";
            this.lvEmployees.Size = new System.Drawing.Size(1184, 535);
            this.lvEmployees.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvEmployees.TabIndex = 12;
            this.lvEmployees.UseCompatibleStateImageBehavior = false;
            this.lvEmployees.View = System.Windows.Forms.View.Details;
            this.lvEmployees.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvEmployees_ItemSelectionChanged);
            this.lvEmployees.DoubleClick += new System.EventHandler(this.lvEmployees_DoubleClick);
            // 
            // chEmployeeId
            // 
            this.chEmployeeId.Text = "ID";
            // 
            // chSurname
            // 
            this.chSurname.Text = "Nachname";
            this.chSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chSurname.Width = 120;
            // 
            // chName
            // 
            this.chName.Text = "Vorname";
            this.chName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chName.Width = 120;
            // 
            // chSubordinates
            // 
            this.chSubordinates.Text = "Untergebene";
            this.chSubordinates.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chSubordinates.Width = 200;
            // 
            // chWeekTimeLimit
            // 
            this.chWeekTimeLimit.Text = "Wochenstunden";
            this.chWeekTimeLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chWeekTimeLimit.Width = 100;
            // 
            // chVacationDays
            // 
            this.chVacationDays.Text = "Urlaubstage";
            this.chVacationDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chVacationDays.Width = 80;
            // 
            // chVacationDaysRemaining
            // 
            this.chVacationDaysRemaining.Text = "Verbleibende Urlaubstage";
            this.chVacationDaysRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chVacationDaysRemaining.Width = 180;
            // 
            // chTotalWorktime
            // 
            this.chTotalWorktime.Text = "Arbeitsstunden ";
            this.chTotalWorktime.Width = 155;
            // 
            // chOvertime
            // 
            this.chOvertime.Text = "Überstunden";
            this.chOvertime.Width = 80;
            // 
            // btnPanelCtrl
            // 
            this.btnPanelCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPanelCtrl.Location = new System.Drawing.Point(954, 593);
            this.btnPanelCtrl.Name = "btnPanelCtrl";
            this.btnPanelCtrl.Size = new System.Drawing.Size(137, 23);
            this.btnPanelCtrl.TabIndex = 98;
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
            // btnEditEmployee
            // 
            this.btnEditEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditEmployee.Enabled = false;
            this.btnEditEmployee.Location = new System.Drawing.Point(172, 593);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(140, 23);
            this.btnEditEmployee.TabIndex = 5;
            this.btnEditEmployee.Text = "Mitarbeiter Bearbeiten";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Visible = false;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // dtpManipulateTime
            // 
            this.dtpManipulateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpManipulateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpManipulateTime.Location = new System.Drawing.Point(1024, 24);
            this.dtpManipulateTime.Name = "dtpManipulateTime";
            this.dtpManipulateTime.Size = new System.Drawing.Size(83, 23);
            this.dtpManipulateTime.TabIndex = 7;
            this.dtpManipulateTime.Visible = false;
            this.dtpManipulateTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 621);
            this.Controls.Add(this.managementPanel);
            this.Controls.Add(this.checkInPanel);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.dtpManipulateTime);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPanelCtrl);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Mitarbeiter Verwaltung";
            this.Load += new System.EventHandler(this.onLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.checkInPanel.ResumeLayout(false);
            this.checkInPanel.PerformLayout();
            this.pnlStatistics.ResumeLayout(false);
            this.pnlStatistics.PerformLayout();
            this.pnlCheckInMain.ResumeLayout(false);
            this.pnlCheckInMain.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.pnlSecureLogin.ResumeLayout(false);
            this.pnlSecureLogin.PerformLayout();
            this.pnlMainLogin.ResumeLayout(false);
            this.pnlMainLogin.PerformLayout();
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
        private Label lblClock;
        private Panel checkInPanel;
        private Button btnPanelCtrl;
        private Button btnLogout;
        private Label lblWelcome;
        private Button btnCheckIn;
        private Panel panel1;
        private Panel managementPanel;
        private ListView lvEmployees;
        private ColumnHeader chEmployeeId;
        private ColumnHeader chSurname;
        private ColumnHeader chName;
        private ColumnHeader chWeekTimeLimit;
        private ColumnHeader chVacationDays;
        private Button btnAddEmployee;
        private Button btnEditEmployee;
        private ColumnHeader chSubordinates;
        private ColumnHeader chTotalWorktime;
        private ColumnHeader chOvertime;
        private Panel loginPanel;
        private Panel fullLoginPanel;
        private Label lblReception;
        private TextBox txtEmployeeId;
        private Button btnLogin;
        private Label lblEmployeeIdTitle;
        private Label lblCheckInState;
        private DateTimePicker dtpManipulateTime;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblHolidaysRemainingTitle;
        private Label lblOvertimeRemainingTitle;
        private Label lblWorkingTimeTitle;
        private Label lblWorkingTime;
        private Label lblHolidaysRemaining;
        private Label lblOvertimeRemaining;
        private Button btnVacationManagement;
        private TableLayoutPanel changePasswordPanel;
        private Label lblRepeatPasswordTitle;
        private Label lblNewPasswordTitle;
        private Button btnChangePassword;
        private TextBox txtNewPassword;
        private TextBox txtNewPasswordRepeated;
        private Label lblChangePasswordTitle;
        private Label lblPasswordChangeFailed;
        private Panel pnlSecureLogin;
        private Label lblWrongPassword;
        private Label lblSecureLoginTitle;
        private TextBox txtPassword;
        private Button btnSecureLogin;
        private Label lblPasswordInputTitle;
        private TableLayoutPanel pnlStatistics;
        private Panel pnlCheckInMain;
        private Panel pnlMainLogin;
        private TableLayoutPanel pnlChangePassword;
        private Label lblHorizontalLine;
        private ToolStripMenuItem hilfeToolStripMenuItem;
        private ColumnHeader chVacationDaysRemaining;
    }
}