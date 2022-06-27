namespace Mitarbeiterverwaltung
{
    partial class EmployeeView
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
            "12:45",
            "13:15"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeView));
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblWorkingTimeWeekLimit = new System.Windows.Forms.Label();
            this.lblVacationDays = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.btnCancelEmployeeView = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.pnlPersonalData = new System.Windows.Forms.TableLayoutPanel();
            this.mtxtVacationDays = new System.Windows.Forms.MaskedTextBox();
            this.mtxtWeekTimeLimit = new System.Windows.Forms.MaskedTextBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.lblResetPasswort = new System.Windows.Forms.Label();
            this.tabCtrlEditEmployee = new System.Windows.Forms.TabControl();
            this.tabPersonalData = new System.Windows.Forms.TabPage();
            this.tabPause = new System.Windows.Forms.TabPage();
            this.btnRemovePause = new System.Windows.Forms.Button();
            this.lvPause = new System.Windows.Forms.ListView();
            this.chBeginnPauseTime = new System.Windows.Forms.ColumnHeader();
            this.chEndPauseTime = new System.Windows.Forms.ColumnHeader();
            this.btnAddPause = new System.Windows.Forms.Button();
            this.tabWorkingTimes = new System.Windows.Forms.TabPage();
            this.btnEditCheckInOutTime = new System.Windows.Forms.Button();
            this.lvCheckInOutTimes = new System.Windows.Forms.ListView();
            this.chStateCheckInOutTime = new System.Windows.Forms.ColumnHeader();
            this.chTime = new System.Windows.Forms.ColumnHeader();
            this.chDate = new System.Windows.Forms.ColumnHeader();
            this.tabSickDates = new System.Windows.Forms.TabPage();
            this.btnRemoveSickDays = new System.Windows.Forms.Button();
            this.lvSickDays = new System.Windows.Forms.ListView();
            this.chBeginSickDays = new System.Windows.Forms.ColumnHeader();
            this.chEndSickDays = new System.Windows.Forms.ColumnHeader();
            this.btnAddSickDays = new System.Windows.Forms.Button();
            this.tabVacations = new System.Windows.Forms.TabPage();
            this.btnDenyVacationRequest = new System.Windows.Forms.Button();
            this.btnAllowVacationRequest = new System.Windows.Forms.Button();
            this.lvVacations = new System.Windows.Forms.ListView();
            this.chBeginnVacationDays = new System.Windows.Forms.ColumnHeader();
            this.chEndVacationDays = new System.Windows.Forms.ColumnHeader();
            this.chStateVacationRequest = new System.Windows.Forms.ColumnHeader();
            this.pnlPersonalData.SuspendLayout();
            this.tabCtrlEditEmployee.SuspendLayout();
            this.tabPersonalData.SuspendLayout();
            this.tabPause.SuspendLayout();
            this.tabWorkingTimes.SuspendLayout();
            this.tabSickDates.SuspendLayout();
            this.tabVacations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Vorname";
            // 
            // lblSurname
            // 
            this.lblSurname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(3, 36);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 15);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Nachname";
            // 
            // lblWorkingTimeWeekLimit
            // 
            this.lblWorkingTimeWeekLimit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWorkingTimeWeekLimit.AutoSize = true;
            this.lblWorkingTimeWeekLimit.Location = new System.Drawing.Point(3, 123);
            this.lblWorkingTimeWeekLimit.Name = "lblWorkingTimeWeekLimit";
            this.lblWorkingTimeWeekLimit.Size = new System.Drawing.Size(148, 15);
            this.lblWorkingTimeWeekLimit.TabIndex = 3;
            this.lblWorkingTimeWeekLimit.Text = "Arbeitsstunden pro Woche";
            // 
            // lblVacationDays
            // 
            this.lblVacationDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVacationDays.AutoSize = true;
            this.lblVacationDays.Location = new System.Drawing.Point(204, 123);
            this.lblVacationDays.Name = "lblVacationDays";
            this.lblVacationDays.Size = new System.Drawing.Size(70, 15);
            this.lblVacationDays.TabIndex = 4;
            this.lblVacationDays.Text = "Urlaubstage";
            // 
            // lblAdress
            // 
            this.lblAdress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(3, 65);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(55, 15);
            this.lblAdress.TabIndex = 5;
            this.lblAdress.Text = "Anschrift";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(3, 94);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(91, 15);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Telefonnummer";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPersonalData.SetColumnSpan(this.txtName, 3);
            this.txtName.Location = new System.Drawing.Point(157, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(371, 23);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Max";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPersonalData.SetColumnSpan(this.txtSurname, 3);
            this.txtSurname.Location = new System.Drawing.Point(157, 32);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(371, 23);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.Text = "Mustermann";
            this.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPersonalData.SetColumnSpan(this.txtAddress, 3);
            this.txtAddress.Location = new System.Drawing.Point(157, 61);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(371, 23);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.Text = "Beispielstraße 123, SampleCity 12345";
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPersonalData.SetColumnSpan(this.txtPhone, 3);
            this.txtPhone.Location = new System.Drawing.Point(157, 90);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(371, 23);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.Text = "015234 / 55435642";
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveEmployee.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveEmployee.Location = new System.Drawing.Point(476, 290);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(75, 22);
            this.btnSaveEmployee.TabIndex = 9;
            this.btnSaveEmployee.Text = "Speichern";
            this.btnSaveEmployee.UseVisualStyleBackColor = true;
            // 
            // btnCancelEmployeeView
            // 
            this.btnCancelEmployeeView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelEmployeeView.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelEmployeeView.Location = new System.Drawing.Point(396, 290);
            this.btnCancelEmployeeView.Name = "btnCancelEmployeeView";
            this.btnCancelEmployeeView.Size = new System.Drawing.Size(75, 22);
            this.btnCancelEmployeeView.TabIndex = 11;
            this.btnCancelEmployeeView.Text = "Abbrechen";
            this.btnCancelEmployeeView.UseVisualStyleBackColor = true;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveEmployee.Location = new System.Drawing.Point(12, 290);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(140, 23);
            this.btnRemoveEmployee.TabIndex = 10;
            this.btnRemoveEmployee.Text = "Mitarbeiter Entfernen";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // pnlPersonalData
            // 
            this.pnlPersonalData.ColumnCount = 4;
            this.pnlPersonalData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlPersonalData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlPersonalData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlPersonalData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlPersonalData.Controls.Add(this.mtxtVacationDays, 3, 4);
            this.pnlPersonalData.Controls.Add(this.mtxtWeekTimeLimit, 1, 4);
            this.pnlPersonalData.Controls.Add(this.lblName, 0, 0);
            this.pnlPersonalData.Controls.Add(this.lblSurname, 0, 1);
            this.pnlPersonalData.Controls.Add(this.lblAdress, 0, 2);
            this.pnlPersonalData.Controls.Add(this.lblPhone, 0, 3);
            this.pnlPersonalData.Controls.Add(this.lblWorkingTimeWeekLimit, 0, 4);
            this.pnlPersonalData.Controls.Add(this.txtName, 1, 0);
            this.pnlPersonalData.Controls.Add(this.txtSurname, 1, 1);
            this.pnlPersonalData.Controls.Add(this.txtAddress, 1, 2);
            this.pnlPersonalData.Controls.Add(this.txtPhone, 1, 3);
            this.pnlPersonalData.Controls.Add(this.btnResetPassword, 1, 5);
            this.pnlPersonalData.Controls.Add(this.lblVacationDays, 2, 4);
            this.pnlPersonalData.Location = new System.Drawing.Point(0, 0);
            this.pnlPersonalData.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPersonalData.Name = "pnlPersonalData";
            this.pnlPersonalData.RowCount = 6;
            this.pnlPersonalData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlPersonalData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlPersonalData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlPersonalData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlPersonalData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlPersonalData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlPersonalData.Size = new System.Drawing.Size(531, 181);
            this.pnlPersonalData.TabIndex = 19;
            // 
            // mtxtVacationDays
            // 
            this.mtxtVacationDays.BeepOnError = true;
            this.mtxtVacationDays.HidePromptOnLeave = true;
            this.mtxtVacationDays.Location = new System.Drawing.Point(280, 119);
            this.mtxtVacationDays.Mask = "00";
            this.mtxtVacationDays.Name = "mtxtVacationDays";
            this.mtxtVacationDays.Size = new System.Drawing.Size(41, 23);
            this.mtxtVacationDays.TabIndex = 7;
            this.mtxtVacationDays.Text = "30";
            this.mtxtVacationDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtxtWeekTimeLimit
            // 
            this.mtxtWeekTimeLimit.BeepOnError = true;
            this.mtxtWeekTimeLimit.HidePromptOnLeave = true;
            this.mtxtWeekTimeLimit.Location = new System.Drawing.Point(157, 119);
            this.mtxtWeekTimeLimit.Mask = "00";
            this.mtxtWeekTimeLimit.Name = "mtxtWeekTimeLimit";
            this.mtxtWeekTimeLimit.Size = new System.Drawing.Size(41, 23);
            this.mtxtWeekTimeLimit.TabIndex = 6;
            this.mtxtWeekTimeLimit.Text = "40";
            this.mtxtWeekTimeLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlPersonalData.SetColumnSpan(this.btnResetPassword, 2);
            this.btnResetPassword.Enabled = false;
            this.btnResetPassword.Location = new System.Drawing.Point(157, 151);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(117, 23);
            this.btnResetPassword.TabIndex = 8;
            this.btnResetPassword.Text = "Zurücksetzen";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // lblResetPasswort
            // 
            this.lblResetPasswort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblResetPasswort.AutoSize = true;
            this.lblResetPasswort.Location = new System.Drawing.Point(3, 155);
            this.lblResetPasswort.Name = "lblResetPasswort";
            this.lblResetPasswort.Size = new System.Drawing.Size(54, 15);
            this.lblResetPasswort.TabIndex = 20;
            this.lblResetPasswort.Text = "Passwort";
            // 
            // tabCtrlEditEmployee
            // 
            this.tabCtrlEditEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrlEditEmployee.Controls.Add(this.tabPersonalData);
            this.tabCtrlEditEmployee.Controls.Add(this.tabPause);
            this.tabCtrlEditEmployee.Controls.Add(this.tabWorkingTimes);
            this.tabCtrlEditEmployee.Controls.Add(this.tabSickDates);
            this.tabCtrlEditEmployee.Controls.Add(this.tabVacations);
            this.tabCtrlEditEmployee.HotTrack = true;
            this.tabCtrlEditEmployee.Location = new System.Drawing.Point(12, 12);
            this.tabCtrlEditEmployee.Name = "tabCtrlEditEmployee";
            this.tabCtrlEditEmployee.SelectedIndex = 0;
            this.tabCtrlEditEmployee.Size = new System.Drawing.Size(539, 272);
            this.tabCtrlEditEmployee.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabCtrlEditEmployee.TabIndex = 20;
            this.tabCtrlEditEmployee.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabCtrlEditEmployee_Selected);
            // 
            // tabPersonalData
            // 
            this.tabPersonalData.BackColor = System.Drawing.SystemColors.Control;
            this.tabPersonalData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPersonalData.Controls.Add(this.pnlPersonalData);
            this.tabPersonalData.Location = new System.Drawing.Point(4, 24);
            this.tabPersonalData.Margin = new System.Windows.Forms.Padding(0);
            this.tabPersonalData.Name = "tabPersonalData";
            this.tabPersonalData.Size = new System.Drawing.Size(531, 244);
            this.tabPersonalData.TabIndex = 0;
            this.tabPersonalData.Text = "Persönliche Daten";
            // 
            // tabPause
            // 
            this.tabPause.BackColor = System.Drawing.SystemColors.Control;
            this.tabPause.Controls.Add(this.btnRemovePause);
            this.tabPause.Controls.Add(this.lvPause);
            this.tabPause.Controls.Add(this.btnAddPause);
            this.tabPause.Location = new System.Drawing.Point(4, 24);
            this.tabPause.Name = "tabPause";
            this.tabPause.Size = new System.Drawing.Size(531, 244);
            this.tabPause.TabIndex = 4;
            this.tabPause.Text = "Pausenzeiten";
            // 
            // btnRemovePause
            // 
            this.btnRemovePause.Enabled = false;
            this.btnRemovePause.Location = new System.Drawing.Point(349, 122);
            this.btnRemovePause.Name = "btnRemovePause";
            this.btnRemovePause.Size = new System.Drawing.Size(140, 23);
            this.btnRemovePause.TabIndex = 3;
            this.btnRemovePause.Text = "Pause entfernen";
            this.btnRemovePause.UseVisualStyleBackColor = true;
            this.btnRemovePause.Click += new System.EventHandler(this.btnRemovePause_click);
            // 
            // lvPause
            // 
            this.lvPause.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPause.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBeginnPauseTime,
            this.chEndPauseTime});
            this.lvPause.FullRowSelect = true;
            this.lvPause.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPause.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvPause.Location = new System.Drawing.Point(5, 4);
            this.lvPause.Name = "lvPause";
            this.lvPause.Size = new System.Drawing.Size(320, 240);
            this.lvPause.TabIndex = 1;
            this.lvPause.UseCompatibleStateImageBehavior = false;
            this.lvPause.View = System.Windows.Forms.View.Details;
            this.lvPause.SelectedIndexChanged += new System.EventHandler(this.lvPause_SelectedIndexChanged);
            // 
            // chBeginnPauseTime
            // 
            this.chBeginnPauseTime.Text = "Beginn";
            this.chBeginnPauseTime.Width = 160;
            // 
            // chEndPauseTime
            // 
            this.chEndPauseTime.Text = "Ende";
            this.chEndPauseTime.Width = 156;
            // 
            // btnAddPause
            // 
            this.btnAddPause.Location = new System.Drawing.Point(349, 93);
            this.btnAddPause.Name = "btnAddPause";
            this.btnAddPause.Size = new System.Drawing.Size(140, 23);
            this.btnAddPause.TabIndex = 2;
            this.btnAddPause.Text = "Pause hinzufügen";
            this.btnAddPause.UseVisualStyleBackColor = true;
            this.btnAddPause.Click += new System.EventHandler(this.btnAddPause_Click);
            // 
            // tabWorkingTimes
            // 
            this.tabWorkingTimes.BackColor = System.Drawing.SystemColors.Control;
            this.tabWorkingTimes.Controls.Add(this.btnEditCheckInOutTime);
            this.tabWorkingTimes.Controls.Add(this.lvCheckInOutTimes);
            this.tabWorkingTimes.Location = new System.Drawing.Point(4, 24);
            this.tabWorkingTimes.Name = "tabWorkingTimes";
            this.tabWorkingTimes.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorkingTimes.Size = new System.Drawing.Size(531, 244);
            this.tabWorkingTimes.TabIndex = 1;
            this.tabWorkingTimes.Text = "Stempelzeiten";
            // 
            // btnEditCheckInOutTime
            // 
            this.btnEditCheckInOutTime.Enabled = false;
            this.btnEditCheckInOutTime.Location = new System.Drawing.Point(349, 111);
            this.btnEditCheckInOutTime.Name = "btnEditCheckInOutTime";
            this.btnEditCheckInOutTime.Size = new System.Drawing.Size(140, 23);
            this.btnEditCheckInOutTime.TabIndex = 1;
            this.btnEditCheckInOutTime.Text = "Stempelzeit ändern";
            this.btnEditCheckInOutTime.UseVisualStyleBackColor = true;
            this.btnEditCheckInOutTime.Click += new System.EventHandler(this.btnEditCheckInOutTime_Click);
            // 
            // lvCheckInOutTimes
            // 
            this.lvCheckInOutTimes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chStateCheckInOutTime,
            this.chTime,
            this.chDate});
            this.lvCheckInOutTimes.FullRowSelect = true;
            this.lvCheckInOutTimes.Location = new System.Drawing.Point(5, 4);
            this.lvCheckInOutTimes.Name = "lvCheckInOutTimes";
            this.lvCheckInOutTimes.Size = new System.Drawing.Size(320, 240);
            this.lvCheckInOutTimes.TabIndex = 0;
            this.lvCheckInOutTimes.UseCompatibleStateImageBehavior = false;
            this.lvCheckInOutTimes.View = System.Windows.Forms.View.Details;
            this.lvCheckInOutTimes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvCheckInOutTimes_ItemSelectionChanged);
            // 
            // chStateCheckInOutTime
            // 
            this.chStateCheckInOutTime.Text = "Status";
            this.chStateCheckInOutTime.Width = 100;
            // 
            // chTime
            // 
            this.chTime.Text = "Uhrzeit";
            this.chTime.Width = 100;
            // 
            // chDate
            // 
            this.chDate.Text = "Datum";
            this.chDate.Width = 116;
            // 
            // tabSickDates
            // 
            this.tabSickDates.BackColor = System.Drawing.SystemColors.Control;
            this.tabSickDates.Controls.Add(this.btnRemoveSickDays);
            this.tabSickDates.Controls.Add(this.lvSickDays);
            this.tabSickDates.Controls.Add(this.btnAddSickDays);
            this.tabSickDates.Location = new System.Drawing.Point(4, 24);
            this.tabSickDates.Name = "tabSickDates";
            this.tabSickDates.Size = new System.Drawing.Size(531, 244);
            this.tabSickDates.TabIndex = 2;
            this.tabSickDates.Text = "Krankheit";
            // 
            // btnRemoveSickDays
            // 
            this.btnRemoveSickDays.Enabled = false;
            this.btnRemoveSickDays.Location = new System.Drawing.Point(349, 122);
            this.btnRemoveSickDays.Name = "btnRemoveSickDays";
            this.btnRemoveSickDays.Size = new System.Drawing.Size(140, 23);
            this.btnRemoveSickDays.TabIndex = 3;
            this.btnRemoveSickDays.Text = "Fehlzeit löschen";
            this.btnRemoveSickDays.UseVisualStyleBackColor = true;
            this.btnRemoveSickDays.Click += new System.EventHandler(this.btnRemoveSickdays_Click);
            // 
            // lvSickDays
            // 
            this.lvSickDays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSickDays.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBeginSickDays,
            this.chEndSickDays});
            this.lvSickDays.FullRowSelect = true;
            this.lvSickDays.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSickDays.Location = new System.Drawing.Point(5, 4);
            this.lvSickDays.Name = "lvSickDays";
            this.lvSickDays.Size = new System.Drawing.Size(320, 239);
            this.lvSickDays.TabIndex = 1;
            this.lvSickDays.UseCompatibleStateImageBehavior = false;
            this.lvSickDays.View = System.Windows.Forms.View.Details;
            this.lvSickDays.SelectedIndexChanged += new System.EventHandler(this.lvSickDays_SelectedIndexChanged);
            // 
            // chBeginSickDays
            // 
            this.chBeginSickDays.Text = "Beginn";
            this.chBeginSickDays.Width = 160;
            // 
            // chEndSickDays
            // 
            this.chEndSickDays.Text = "Ende";
            this.chEndSickDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chEndSickDays.Width = 156;
            // 
            // btnAddSickDays
            // 
            this.btnAddSickDays.Location = new System.Drawing.Point(349, 93);
            this.btnAddSickDays.Name = "btnAddSickDays";
            this.btnAddSickDays.Size = new System.Drawing.Size(140, 23);
            this.btnAddSickDays.TabIndex = 2;
            this.btnAddSickDays.Text = "Fehlzeit hinzufügen";
            this.btnAddSickDays.UseVisualStyleBackColor = true;
            this.btnAddSickDays.Click += new System.EventHandler(this.btnAddSickdays_Click);
            // 
            // tabVacations
            // 
            this.tabVacations.BackColor = System.Drawing.SystemColors.Control;
            this.tabVacations.Controls.Add(this.btnDenyVacationRequest);
            this.tabVacations.Controls.Add(this.btnAllowVacationRequest);
            this.tabVacations.Controls.Add(this.lvVacations);
            this.tabVacations.Location = new System.Drawing.Point(4, 24);
            this.tabVacations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabVacations.Name = "tabVacations";
            this.tabVacations.Size = new System.Drawing.Size(531, 244);
            this.tabVacations.TabIndex = 3;
            this.tabVacations.Text = "Urlaub";
            // 
            // btnDenyVacationRequest
            // 
            this.btnDenyVacationRequest.Enabled = false;
            this.btnDenyVacationRequest.Location = new System.Drawing.Point(349, 122);
            this.btnDenyVacationRequest.Name = "btnDenyVacationRequest";
            this.btnDenyVacationRequest.Size = new System.Drawing.Size(140, 23);
            this.btnDenyVacationRequest.TabIndex = 2;
            this.btnDenyVacationRequest.Text = "Verweigern";
            this.btnDenyVacationRequest.UseVisualStyleBackColor = true;
            this.btnDenyVacationRequest.Click += new System.EventHandler(this.btnDenyVacationRequest_Click);
            // 
            // btnAllowVacationRequest
            // 
            this.btnAllowVacationRequest.Enabled = false;
            this.btnAllowVacationRequest.Location = new System.Drawing.Point(349, 93);
            this.btnAllowVacationRequest.Name = "btnAllowVacationRequest";
            this.btnAllowVacationRequest.Size = new System.Drawing.Size(140, 23);
            this.btnAllowVacationRequest.TabIndex = 3;
            this.btnAllowVacationRequest.Text = "Genehmigen";
            this.btnAllowVacationRequest.UseVisualStyleBackColor = true;
            this.btnAllowVacationRequest.Click += new System.EventHandler(this.btnAllowVacationRequest_Click);
            // 
            // lvVacations
            // 
            this.lvVacations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvVacations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBeginnVacationDays,
            this.chEndVacationDays,
            this.chStateVacationRequest});
            this.lvVacations.FullRowSelect = true;
            this.lvVacations.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvVacations.Location = new System.Drawing.Point(5, 4);
            this.lvVacations.Name = "lvVacations";
            this.lvVacations.Size = new System.Drawing.Size(320, 240);
            this.lvVacations.TabIndex = 1;
            this.lvVacations.UseCompatibleStateImageBehavior = false;
            this.lvVacations.View = System.Windows.Forms.View.Details;
            this.lvVacations.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvVacations_ItemSelectionChanged);
            // 
            // chBeginnVacationDays
            // 
            this.chBeginnVacationDays.Text = "Beginn";
            this.chBeginnVacationDays.Width = 100;
            // 
            // chEndVacationDays
            // 
            this.chEndVacationDays.Text = "Ende";
            this.chEndVacationDays.Width = 100;
            // 
            // chStateVacationRequest
            // 
            this.chStateVacationRequest.Text = "Status";
            this.chStateVacationRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chStateVacationRequest.Width = 116;
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 317);
            this.Controls.Add(this.tabCtrlEditEmployee);
            this.Controls.Add(this.btnRemoveEmployee);
            this.Controls.Add(this.btnCancelEmployeeView);
            this.Controls.Add(this.btnSaveEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeView";
            this.ShowIcon = false;
            this.Text = "Mitarbeiter bearbeiten";
            this.pnlPersonalData.ResumeLayout(false);
            this.pnlPersonalData.PerformLayout();
            this.tabCtrlEditEmployee.ResumeLayout(false);
            this.tabPersonalData.ResumeLayout(false);
            this.tabPause.ResumeLayout(false);
            this.tabWorkingTimes.ResumeLayout(false);
            this.tabSickDates.ResumeLayout(false);
            this.tabVacations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblName;
        private Label lblSurname;
        private Label lblWorkingTimeWeekLimit;
        private Label lblVacationDays;
        private Label lblAdress;
        private Label lblPhone;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private Button btnSaveEmployee;
        private Button btnCancelEmployeeView;
        private Button btnRemoveEmployee;
        private Label lblResetPasswort;
        private Button btnResetPassword;
        private TabControl tabCtrlEditEmployee;
        private TabPage tabPersonalData;
        private TabPage tabWorkingTimes;
        private TabPage tabSickDates;
        private ListView lvCheckInOutTimes;
        private ListView lvSickDays;
        private ColumnHeader chBeginSickDays;
        private ColumnHeader chEndSickDays;
        private Button btnAddSickDays;
        private Button btnRemoveSickDays;
        private ColumnHeader chStateCheckInOutTime;
        private ColumnHeader chTime;
        private ColumnHeader chDate;
        private TabPage tabVacations;
        private Button btnDenyVacationRequest;
        private Button btnAllowVacationRequest;
        private ListView lvVacations;
        private ColumnHeader chBeginnVacationDays;
        private ColumnHeader chEndVacationDays;
        private ColumnHeader chStateVacationRequest;
        private TabPage tabPause;
        private Button btnRemovePause;
        private ListView lvPause;
        private ColumnHeader chBeginnPauseTime;
        private ColumnHeader chEndPauseTime;
        private Button btnAddPause;
        private MaskedTextBox mtxtWeekTimeLimit;
        private MaskedTextBox mtxtVacationDays;
        private Button btnEditCheckInOutTime;
        private TableLayoutPanel pnlPersonalData;
    }
}
