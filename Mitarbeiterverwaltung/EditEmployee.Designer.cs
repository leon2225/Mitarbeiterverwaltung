namespace Mitarbeiterverwaltung
{
    partial class EditEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployee));
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_workingTimeWeek = new System.Windows.Forms.Label();
            this.label_holidays = new System.Windows.Forms.Label();
            this.label_adress = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_adress = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_weekTimeLimit = new System.Windows.Forms.TextBox();
            this.textBox_holidays = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.personalData = new System.Windows.Forms.TabPage();
            this.workingTimes = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvTimestamps = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.sickDates = new System.Windows.Forms.TabPage();
            this.absenteeismListPanel = new System.Windows.Forms.Panel();
            this.btnDeleteAbsenteeism = new System.Windows.Forms.Button();
            this.lvSickDays = new System.Windows.Forms.ListView();
            this.Beginn = new System.Windows.Forms.ColumnHeader();
            this.Ende = new System.Windows.Forms.ColumnHeader();
            this.btnAddAbsenteeism = new System.Windows.Forms.Button();
            this.newAbsenteeismPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBeginnAbsenteeism = new System.Windows.Forms.DateTimePicker();
            this.dtpEndAbsenteeism = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveAbsenteeism = new System.Windows.Forms.Button();
            this.btnCancelAddAbsenteeism = new System.Windows.Forms.Button();
            this.holiday = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAllowRequest = new System.Windows.Forms.Button();
            this.lvHolidays = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.btnDenyRequest = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.personalData.SuspendLayout();
            this.workingTimes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.sickDates.SuspendLayout();
            this.absenteeismListPanel.SuspendLayout();
            this.newAbsenteeismPanel.SuspendLayout();
            this.holiday.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(3, 7);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(68, 20);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Vorname";
            // 
            // label_surname
            // 
            this.label_surname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(3, 42);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(80, 20);
            this.label_surname.TabIndex = 1;
            this.label_surname.Text = "Nachname";
            // 
            // label_workingTimeWeek
            // 
            this.label_workingTimeWeek.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_workingTimeWeek.AutoSize = true;
            this.label_workingTimeWeek.Location = new System.Drawing.Point(3, 147);
            this.label_workingTimeWeek.Name = "label_workingTimeWeek";
            this.label_workingTimeWeek.Size = new System.Drawing.Size(184, 20);
            this.label_workingTimeWeek.TabIndex = 3;
            this.label_workingTimeWeek.Text = "Arbeitsstunden pro Woche";
            // 
            // label_holidays
            // 
            this.label_holidays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_holidays.AutoSize = true;
            this.label_holidays.Location = new System.Drawing.Point(245, 147);
            this.label_holidays.Name = "label_holidays";
            this.label_holidays.Size = new System.Drawing.Size(89, 20);
            this.label_holidays.TabIndex = 4;
            this.label_holidays.Text = "Urlaubstage";
            // 
            // label_adress
            // 
            this.label_adress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_adress.AutoSize = true;
            this.label_adress.Location = new System.Drawing.Point(3, 77);
            this.label_adress.Name = "label_adress";
            this.label_adress.Size = new System.Drawing.Size(67, 20);
            this.label_adress.TabIndex = 5;
            this.label_adress.Text = "Anschrift";
            // 
            // label_phone
            // 
            this.label_phone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(3, 112);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(113, 20);
            this.label_phone.TabIndex = 6;
            this.label_phone.Text = "Telefonnummer";
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_name, 3);
            this.textBox_name.Location = new System.Drawing.Point(193, 4);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(405, 27);
            this.textBox_name.TabIndex = 7;
            this.textBox_name.Text = "Max";
            this.textBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_surname, 3);
            this.textBox_surname.Location = new System.Drawing.Point(193, 39);
            this.textBox_surname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(405, 27);
            this.textBox_surname.TabIndex = 8;
            this.textBox_surname.Text = "Mustermann";
            this.textBox_surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_adress
            // 
            this.textBox_adress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_adress, 3);
            this.textBox_adress.Location = new System.Drawing.Point(193, 74);
            this.textBox_adress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(405, 27);
            this.textBox_adress.TabIndex = 9;
            this.textBox_adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_phone, 3);
            this.textBox_phone.Location = new System.Drawing.Point(193, 109);
            this.textBox_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(405, 27);
            this.textBox_phone.TabIndex = 10;
            this.textBox_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_weekTimeLimit
            // 
            this.textBox_weekTimeLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_weekTimeLimit.Location = new System.Drawing.Point(193, 144);
            this.textBox_weekTimeLimit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_weekTimeLimit.Name = "textBox_weekTimeLimit";
            this.textBox_weekTimeLimit.Size = new System.Drawing.Size(46, 27);
            this.textBox_weekTimeLimit.TabIndex = 12;
            // 
            // textBox_holidays
            // 
            this.textBox_holidays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_holidays.Location = new System.Drawing.Point(340, 144);
            this.textBox_holidays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_holidays.Name = "textBox_holidays";
            this.textBox_holidays.Size = new System.Drawing.Size(50, 27);
            this.textBox_holidays.TabIndex = 13;
            // 
            // button_save
            // 
            this.button_save.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_save.Location = new System.Drawing.Point(529, 387);
            this.button_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(86, 29);
            this.button_save.TabIndex = 14;
            this.button_save.Text = "Speichern";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_cancel.Location = new System.Drawing.Point(437, 387);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(86, 29);
            this.button_cancel.TabIndex = 15;
            this.button_cancel.Text = "Abbrechen";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Location = new System.Drawing.Point(14, 387);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 31);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Entfernen";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_surname, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_adress, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_phone, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_workingTimeWeek, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_weekTimeLimit, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_surname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_adress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_phone, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_holidays, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnResetPassword, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label_holidays, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(589, 241);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Passwort";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnResetPassword, 2);
            this.btnResetPassword.Enabled = false;
            this.btnResetPassword.Location = new System.Drawing.Point(200, 206);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(134, 31);
            this.btnResetPassword.TabIndex = 21;
            this.btnResetPassword.Text = "Zurücksetzen";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.personalData);
            this.tabControl1.Controls.Add(this.workingTimes);
            this.tabControl1.Controls.Add(this.sickDates);
            this.tabControl1.Controls.Add(this.holiday);
            this.tabControl1.Location = new System.Drawing.Point(14, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 363);
            this.tabControl1.TabIndex = 20;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl1_Selected);
            // 
            // personalData
            // 
            this.personalData.BackColor = System.Drawing.SystemColors.Control;
            this.personalData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.personalData.Controls.Add(this.tableLayoutPanel1);
            this.personalData.Location = new System.Drawing.Point(4, 29);
            this.personalData.Margin = new System.Windows.Forms.Padding(0);
            this.personalData.Name = "personalData";
            this.personalData.Size = new System.Drawing.Size(593, 330);
            this.personalData.TabIndex = 0;
            this.personalData.Text = "Persöhnliche Daten";
            // 
            // workingTimes
            // 
            this.workingTimes.BackColor = System.Drawing.SystemColors.Control;
            this.workingTimes.Controls.Add(this.panel1);
            this.workingTimes.Location = new System.Drawing.Point(4, 29);
            this.workingTimes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.workingTimes.Name = "workingTimes";
            this.workingTimes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.workingTimes.Size = new System.Drawing.Size(593, 284);
            this.workingTimes.TabIndex = 1;
            this.workingTimes.Text = "Arbeitszeiten";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lvTimestamps);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 325);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lvTimestamps
            // 
            this.lvTimestamps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvTimestamps.Location = new System.Drawing.Point(7, 8);
            this.lvTimestamps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvTimestamps.Name = "lvTimestamps";
            this.lvTimestamps.Size = new System.Drawing.Size(578, 308);
            this.lvTimestamps.TabIndex = 0;
            this.lvTimestamps.UseCompatibleStateImageBehavior = false;
            this.lvTimestamps.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Status";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Uhrzeit";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Datum";
            this.columnHeader3.Width = 120;
            // 
            // sickDates
            // 
            this.sickDates.BackColor = System.Drawing.SystemColors.Control;
            this.sickDates.Controls.Add(this.absenteeismListPanel);
            this.sickDates.Controls.Add(this.newAbsenteeismPanel);
            this.sickDates.Location = new System.Drawing.Point(4, 29);
            this.sickDates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sickDates.Name = "sickDates";
            this.sickDates.Size = new System.Drawing.Size(593, 330);
            this.sickDates.TabIndex = 2;
            this.sickDates.Text = "Krankheit";
            // 
            // absenteeismListPanel
            // 
            this.absenteeismListPanel.Controls.Add(this.btnDeleteAbsenteeism);
            this.absenteeismListPanel.Controls.Add(this.lvSickDays);
            this.absenteeismListPanel.Controls.Add(this.btnAddAbsenteeism);
            this.absenteeismListPanel.Location = new System.Drawing.Point(0, 0);
            this.absenteeismListPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.absenteeismListPanel.Name = "absenteeismListPanel";
            this.absenteeismListPanel.Size = new System.Drawing.Size(592, 325);
            this.absenteeismListPanel.TabIndex = 3;
            // 
            // btnDeleteAbsenteeism
            // 
            this.btnDeleteAbsenteeism.Location = new System.Drawing.Point(352, 168);
            this.btnDeleteAbsenteeism.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteAbsenteeism.Name = "btnDeleteAbsenteeism";
            this.btnDeleteAbsenteeism.Size = new System.Drawing.Size(211, 31);
            this.btnDeleteAbsenteeism.TabIndex = 3;
            this.btnDeleteAbsenteeism.Text = "Fehlzeit löschen";
            this.btnDeleteAbsenteeism.UseVisualStyleBackColor = true;
            this.btnDeleteAbsenteeism.Click += new System.EventHandler(this.btnDeleteAbsenteeism_Click);
            // 
            // lvSickDays
            // 
            this.lvSickDays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSickDays.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Beginn,
            this.Ende});
            this.lvSickDays.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSickDays.Location = new System.Drawing.Point(3, 4);
            this.lvSickDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvSickDays.Name = "lvSickDays";
            this.lvSickDays.Size = new System.Drawing.Size(307, 317);
            this.lvSickDays.TabIndex = 1;
            this.lvSickDays.UseCompatibleStateImageBehavior = false;
            this.lvSickDays.View = System.Windows.Forms.View.Details;
            // 
            // Beginn
            // 
            this.Beginn.Text = "Beginn";
            this.Beginn.Width = 150;
            // 
            // Ende
            // 
            this.Ende.Text = "Ende";
            this.Ende.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Ende.Width = 150;
            // 
            // btnAddAbsenteeism
            // 
            this.btnAddAbsenteeism.Location = new System.Drawing.Point(352, 129);
            this.btnAddAbsenteeism.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddAbsenteeism.Name = "btnAddAbsenteeism";
            this.btnAddAbsenteeism.Size = new System.Drawing.Size(211, 31);
            this.btnAddAbsenteeism.TabIndex = 2;
            this.btnAddAbsenteeism.Text = "Fehlzeit hinzufügen";
            this.btnAddAbsenteeism.UseVisualStyleBackColor = true;
            this.btnAddAbsenteeism.Click += new System.EventHandler(this.btnAddAbsenteeism_Click);
            // 
            // newAbsenteeismPanel
            // 
            this.newAbsenteeismPanel.BackColor = System.Drawing.SystemColors.Control;
            this.newAbsenteeismPanel.ColumnCount = 2;
            this.newAbsenteeismPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.26615F));
            this.newAbsenteeismPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.73385F));
            this.newAbsenteeismPanel.Controls.Add(this.label2, 0, 0);
            this.newAbsenteeismPanel.Controls.Add(this.dtpBeginnAbsenteeism, 1, 1);
            this.newAbsenteeismPanel.Controls.Add(this.dtpEndAbsenteeism, 1, 2);
            this.newAbsenteeismPanel.Controls.Add(this.label3, 0, 1);
            this.newAbsenteeismPanel.Controls.Add(this.label4, 0, 2);
            this.newAbsenteeismPanel.Controls.Add(this.btnSaveAbsenteeism, 1, 3);
            this.newAbsenteeismPanel.Controls.Add(this.btnCancelAddAbsenteeism, 0, 3);
            this.newAbsenteeismPanel.Location = new System.Drawing.Point(0, 0);
            this.newAbsenteeismPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newAbsenteeismPanel.Name = "newAbsenteeismPanel";
            this.newAbsenteeismPanel.RowCount = 5;
            this.newAbsenteeismPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.68226F));
            this.newAbsenteeismPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.25226F));
            this.newAbsenteeismPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.80992F));
            this.newAbsenteeismPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.43801F));
            this.newAbsenteeismPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.newAbsenteeismPanel.Size = new System.Drawing.Size(592, 325);
            this.newAbsenteeismPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.newAbsenteeismPanel.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(586, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Neue krankheitsbedingte Fehlzeit eintragen";
            // 
            // dtpBeginnAbsenteeism
            // 
            this.dtpBeginnAbsenteeism.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBeginnAbsenteeism.Location = new System.Drawing.Point(146, 58);
            this.dtpBeginnAbsenteeism.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpBeginnAbsenteeism.Name = "dtpBeginnAbsenteeism";
            this.dtpBeginnAbsenteeism.Size = new System.Drawing.Size(108, 27);
            this.dtpBeginnAbsenteeism.TabIndex = 1;
            // 
            // dtpEndAbsenteeism
            // 
            this.dtpEndAbsenteeism.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndAbsenteeism.Location = new System.Drawing.Point(146, 100);
            this.dtpEndAbsenteeism.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEndAbsenteeism.Name = "dtpEndAbsenteeism";
            this.dtpEndAbsenteeism.Size = new System.Drawing.Size(108, 27);
            this.dtpEndAbsenteeism.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Beginn der Fehlzeit";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ende der Fehlzeit";
            // 
            // btnSaveAbsenteeism
            // 
            this.btnSaveAbsenteeism.Location = new System.Drawing.Point(146, 141);
            this.btnSaveAbsenteeism.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveAbsenteeism.Name = "btnSaveAbsenteeism";
            this.btnSaveAbsenteeism.Size = new System.Drawing.Size(86, 31);
            this.btnSaveAbsenteeism.TabIndex = 5;
            this.btnSaveAbsenteeism.Text = "Eintragen";
            this.btnSaveAbsenteeism.UseVisualStyleBackColor = true;
            this.btnSaveAbsenteeism.Click += new System.EventHandler(this.btnSaveAbsenteeism_Click);
            // 
            // btnCancelAddAbsenteeism
            // 
            this.btnCancelAddAbsenteeism.Location = new System.Drawing.Point(3, 141);
            this.btnCancelAddAbsenteeism.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelAddAbsenteeism.Name = "btnCancelAddAbsenteeism";
            this.btnCancelAddAbsenteeism.Size = new System.Drawing.Size(86, 31);
            this.btnCancelAddAbsenteeism.TabIndex = 6;
            this.btnCancelAddAbsenteeism.Text = "Abbrechen";
            this.btnCancelAddAbsenteeism.UseVisualStyleBackColor = true;
            this.btnCancelAddAbsenteeism.Click += new System.EventHandler(this.btnCancelAddAbsenteeism_Click);
            // 
            // holiday
            // 
            this.holiday.Controls.Add(this.panel2);
            this.holiday.Location = new System.Drawing.Point(4, 29);
            this.holiday.Name = "holiday";
            this.holiday.Size = new System.Drawing.Size(593, 330);
            this.holiday.TabIndex = 3;
            this.holiday.Text = "Urlaub";
            this.holiday.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnDenyRequest);
            this.panel2.Controls.Add(this.btnAllowRequest);
            this.panel2.Controls.Add(this.lvHolidays);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 325);
            this.panel2.TabIndex = 4;
            // 
            // btnAllowRequest
            // 
            this.btnAllowRequest.Enabled = false;
            this.btnAllowRequest.Location = new System.Drawing.Point(399, 124);
            this.btnAllowRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAllowRequest.Name = "btnAllowRequest";
            this.btnAllowRequest.Size = new System.Drawing.Size(160, 31);
            this.btnAllowRequest.TabIndex = 3;
            this.btnAllowRequest.Text = "Genehmigen";
            this.btnAllowRequest.UseVisualStyleBackColor = true;
            // 
            // lvHolidays
            // 
            this.lvHolidays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvHolidays.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvHolidays.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvHolidays.Location = new System.Drawing.Point(3, 4);
            this.lvHolidays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvHolidays.Name = "lvHolidays";
            this.lvHolidays.Size = new System.Drawing.Size(366, 317);
            this.lvHolidays.TabIndex = 1;
            this.lvHolidays.UseCompatibleStateImageBehavior = false;
            this.lvHolidays.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Beginn";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ende";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Status";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 120;
            // 
            // btnDenyRequest
            // 
            this.btnDenyRequest.Enabled = false;
            this.btnDenyRequest.Location = new System.Drawing.Point(399, 163);
            this.btnDenyRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDenyRequest.Name = "btnDenyRequest";
            this.btnDenyRequest.Size = new System.Drawing.Size(160, 31);
            this.btnDenyRequest.TabIndex = 2;
            this.btnDenyRequest.Text = "Verweigern";
            this.btnDenyRequest.UseVisualStyleBackColor = true;
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 423);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "EditEmployee";
            this.Text = "Mitarbeiter bearbeiten";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.personalData.ResumeLayout(false);
            this.workingTimes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.sickDates.ResumeLayout(false);
            this.absenteeismListPanel.ResumeLayout(false);
            this.newAbsenteeismPanel.ResumeLayout(false);
            this.newAbsenteeismPanel.PerformLayout();
            this.holiday.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label_name;
        private Label label_surname;
        private Label label_workingTimeWeek;
        private Label label_holidays;
        private Label label_adress;
        private Label label_phone;
        private TextBox textBox_name;
        private TextBox textBox_surname;
        private TextBox textBox_adress;
        private TextBox textBox_phone;
        private TextBox textBox_weekTimeLimit;
        private TextBox textBox_holidays;
        private Button button_saveStaffMember;
        private Button button_cancelNewStaffMember;
        private Button button_save;
        private Button button_cancel;
        private Button btnRemove;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button btnResetPassword;
        private TabControl tabControl1;
        private TabPage personalData;
        private TabPage workingTimes;
        private TabPage sickDates;
        private ListView lvTimestamps;
        private ListView lvSickDays;
        private ColumnHeader Beginn;
        private ColumnHeader Ende;
        private Button btnAddAbsenteeism;
        private Panel absenteeismListPanel;
        private TableLayoutPanel newAbsenteeismPanel;
        private Label label2;
        private DateTimePicker dtpBeginnAbsenteeism;
        private DateTimePicker dtpEndAbsenteeism;
        private Label label3;
        private Label label4;
        private Button btnSaveAbsenteeism;
        private Button btnCancelAddAbsenteeism;
        private Panel panel1;
        private Button btnDeleteAbsenteeism;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TabPage holiday;
        private Panel panel2;
        private Button btnDenyRequest;
        private Button btnAllowRequest;
        private ListView lvHolidays;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}