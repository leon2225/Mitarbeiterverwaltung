﻿namespace Mitarbeiterverwaltung
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
            this.tabPersonalData = new System.Windows.Forms.TabPage();
            this.tabWorkingTimes = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvTimestamps = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.tabSickDates = new System.Windows.Forms.TabPage();
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
            this.tabHolidays = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDenyRequest = new System.Windows.Forms.Button();
            this.btnAllowRequest = new System.Windows.Forms.Button();
            this.lvHolidays = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPersonalData.SuspendLayout();
            this.tabWorkingTimes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabSickDates.SuspendLayout();
            this.absenteeismListPanel.SuspendLayout();
            this.newAbsenteeismPanel.SuspendLayout();
            this.tabHolidays.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(3, 7);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(54, 15);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Vorname";
            // 
            // label_surname
            // 
            this.label_surname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(3, 36);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(65, 15);
            this.label_surname.TabIndex = 1;
            this.label_surname.Text = "Nachname";
            // 
            // label_workingTimeWeek
            // 
            this.label_workingTimeWeek.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_workingTimeWeek.AutoSize = true;
            this.label_workingTimeWeek.Location = new System.Drawing.Point(3, 123);
            this.label_workingTimeWeek.Name = "label_workingTimeWeek";
            this.label_workingTimeWeek.Size = new System.Drawing.Size(148, 15);
            this.label_workingTimeWeek.TabIndex = 3;
            this.label_workingTimeWeek.Text = "Arbeitsstunden pro Woche";
            // 
            // label_holidays
            // 
            this.label_holidays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_holidays.AutoSize = true;
            this.label_holidays.Location = new System.Drawing.Point(204, 123);
            this.label_holidays.Name = "label_holidays";
            this.label_holidays.Size = new System.Drawing.Size(70, 15);
            this.label_holidays.TabIndex = 4;
            this.label_holidays.Text = "Urlaubstage";
            // 
            // label_adress
            // 
            this.label_adress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_adress.AutoSize = true;
            this.label_adress.Location = new System.Drawing.Point(3, 65);
            this.label_adress.Name = "label_adress";
            this.label_adress.Size = new System.Drawing.Size(55, 15);
            this.label_adress.TabIndex = 5;
            this.label_adress.Text = "Anschrift";
            // 
            // label_phone
            // 
            this.label_phone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(3, 94);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(91, 15);
            this.label_phone.TabIndex = 6;
            this.label_phone.Text = "Telefonnummer";
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_name, 3);
            this.textBox_name.Location = new System.Drawing.Point(157, 3);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(355, 23);
            this.textBox_name.TabIndex = 7;
            this.textBox_name.Text = "Max";
            this.textBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_surname, 3);
            this.textBox_surname.Location = new System.Drawing.Point(157, 32);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(355, 23);
            this.textBox_surname.TabIndex = 8;
            this.textBox_surname.Text = "Mustermann";
            this.textBox_surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_adress
            // 
            this.textBox_adress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_adress, 3);
            this.textBox_adress.Location = new System.Drawing.Point(157, 61);
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(355, 23);
            this.textBox_adress.TabIndex = 9;
            this.textBox_adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_phone, 3);
            this.textBox_phone.Location = new System.Drawing.Point(157, 90);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(355, 23);
            this.textBox_phone.TabIndex = 10;
            this.textBox_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_weekTimeLimit
            // 
            this.textBox_weekTimeLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_weekTimeLimit.Location = new System.Drawing.Point(157, 119);
            this.textBox_weekTimeLimit.Name = "textBox_weekTimeLimit";
            this.textBox_weekTimeLimit.Size = new System.Drawing.Size(41, 23);
            this.textBox_weekTimeLimit.TabIndex = 12;
            // 
            // textBox_holidays
            // 
            this.textBox_holidays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_holidays.Location = new System.Drawing.Point(280, 119);
            this.textBox_holidays.Name = "textBox_holidays";
            this.textBox_holidays.Size = new System.Drawing.Size(44, 23);
            this.textBox_holidays.TabIndex = 13;
            // 
            // button_save
            // 
            this.button_save.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_save.Location = new System.Drawing.Point(463, 290);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 22);
            this.button_save.TabIndex = 14;
            this.button_save.Text = "Speichern";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_cancel.Location = new System.Drawing.Point(382, 290);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 22);
            this.button_cancel.TabIndex = 15;
            this.button_cancel.Text = "Abbrechen";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Location = new System.Drawing.Point(12, 290);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Entfernen";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 181);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Passwort";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.SetColumnSpan(this.btnResetPassword, 2);
            this.btnResetPassword.Enabled = false;
            this.btnResetPassword.Location = new System.Drawing.Point(157, 151);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(117, 23);
            this.btnResetPassword.TabIndex = 21;
            this.btnResetPassword.Text = "Zurücksetzen";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPersonalData);
            this.tabControl1.Controls.Add(this.tabWorkingTimes);
            this.tabControl1.Controls.Add(this.tabSickDates);
            this.tabControl1.Controls.Add(this.tabHolidays);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(526, 272);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 20;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl1_Selected);
            // 
            // tabPersonalData
            // 
            this.tabPersonalData.BackColor = System.Drawing.SystemColors.Control;
            this.tabPersonalData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPersonalData.Controls.Add(this.tableLayoutPanel1);
            this.tabPersonalData.Location = new System.Drawing.Point(4, 24);
            this.tabPersonalData.Margin = new System.Windows.Forms.Padding(0);
            this.tabPersonalData.Name = "tabPersonalData";
            this.tabPersonalData.Size = new System.Drawing.Size(518, 244);
            this.tabPersonalData.TabIndex = 0;
            this.tabPersonalData.Text = "Persöhnliche Daten";
            // 
            // tabWorkingTimes
            // 
            this.tabWorkingTimes.BackColor = System.Drawing.SystemColors.Control;
            this.tabWorkingTimes.Controls.Add(this.panel1);
            this.tabWorkingTimes.Location = new System.Drawing.Point(4, 24);
            this.tabWorkingTimes.Name = "tabWorkingTimes";
            this.tabWorkingTimes.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorkingTimes.Size = new System.Drawing.Size(518, 244);
            this.tabWorkingTimes.TabIndex = 1;
            this.tabWorkingTimes.Text = "Arbeitszeiten";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lvTimestamps);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 244);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lvTimestamps
            // 
            this.lvTimestamps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvTimestamps.Location = new System.Drawing.Point(3, 3);
            this.lvTimestamps.Name = "lvTimestamps";
            this.lvTimestamps.Size = new System.Drawing.Size(506, 232);
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
            // tabSickDates
            // 
            this.tabSickDates.BackColor = System.Drawing.SystemColors.Control;
            this.tabSickDates.Controls.Add(this.absenteeismListPanel);
            this.tabSickDates.Controls.Add(this.newAbsenteeismPanel);
            this.tabSickDates.Location = new System.Drawing.Point(4, 24);
            this.tabSickDates.Name = "tabSickDates";
            this.tabSickDates.Size = new System.Drawing.Size(518, 244);
            this.tabSickDates.TabIndex = 2;
            this.tabSickDates.Text = "Krankheit";
            // 
            // absenteeismListPanel
            // 
            this.absenteeismListPanel.Controls.Add(this.btnDeleteAbsenteeism);
            this.absenteeismListPanel.Controls.Add(this.lvSickDays);
            this.absenteeismListPanel.Controls.Add(this.btnAddAbsenteeism);
            this.absenteeismListPanel.Location = new System.Drawing.Point(0, 0);
            this.absenteeismListPanel.Name = "absenteeismListPanel";
            this.absenteeismListPanel.Size = new System.Drawing.Size(518, 244);
            this.absenteeismListPanel.TabIndex = 3;
            // 
            // btnDeleteAbsenteeism
            // 
            this.btnDeleteAbsenteeism.Location = new System.Drawing.Point(349, 122);
            this.btnDeleteAbsenteeism.Name = "btnDeleteAbsenteeism";
            this.btnDeleteAbsenteeism.Size = new System.Drawing.Size(140, 23);
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
            this.lvSickDays.Location = new System.Drawing.Point(3, 3);
            this.lvSickDays.Name = "lvSickDays";
            this.lvSickDays.Size = new System.Drawing.Size(320, 239);
            this.lvSickDays.TabIndex = 1;
            this.lvSickDays.UseCompatibleStateImageBehavior = false;
            this.lvSickDays.View = System.Windows.Forms.View.Details;
            // 
            // Beginn
            // 
            this.Beginn.Text = "Beginn";
            this.Beginn.Width = 160;
            // 
            // Ende
            // 
            this.Ende.Text = "Ende";
            this.Ende.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Ende.Width = 156;
            // 
            // btnAddAbsenteeism
            // 
            this.btnAddAbsenteeism.Location = new System.Drawing.Point(349, 93);
            this.btnAddAbsenteeism.Name = "btnAddAbsenteeism";
            this.btnAddAbsenteeism.Size = new System.Drawing.Size(140, 23);
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
            this.newAbsenteeismPanel.Name = "newAbsenteeismPanel";
            this.newAbsenteeismPanel.RowCount = 5;
            this.newAbsenteeismPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.68226F));
            this.newAbsenteeismPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.25226F));
            this.newAbsenteeismPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.80992F));
            this.newAbsenteeismPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.43801F));
            this.newAbsenteeismPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.newAbsenteeismPanel.Size = new System.Drawing.Size(518, 244);
            this.newAbsenteeismPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.newAbsenteeismPanel.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Neue krankheitsbedingte Fehlzeit eintragen";
            // 
            // dtpBeginnAbsenteeism
            // 
            this.dtpBeginnAbsenteeism.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBeginnAbsenteeism.Location = new System.Drawing.Point(128, 43);
            this.dtpBeginnAbsenteeism.Name = "dtpBeginnAbsenteeism";
            this.dtpBeginnAbsenteeism.Size = new System.Drawing.Size(95, 23);
            this.dtpBeginnAbsenteeism.TabIndex = 1;
            // 
            // dtpEndAbsenteeism
            // 
            this.dtpEndAbsenteeism.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndAbsenteeism.Location = new System.Drawing.Point(128, 75);
            this.dtpEndAbsenteeism.Name = "dtpEndAbsenteeism";
            this.dtpEndAbsenteeism.Size = new System.Drawing.Size(95, 23);
            this.dtpEndAbsenteeism.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Beginn der Fehlzeit";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ende der Fehlzeit";
            // 
            // btnSaveAbsenteeism
            // 
            this.btnSaveAbsenteeism.Location = new System.Drawing.Point(128, 106);
            this.btnSaveAbsenteeism.Name = "btnSaveAbsenteeism";
            this.btnSaveAbsenteeism.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAbsenteeism.TabIndex = 5;
            this.btnSaveAbsenteeism.Text = "Eintragen";
            this.btnSaveAbsenteeism.UseVisualStyleBackColor = true;
            this.btnSaveAbsenteeism.Click += new System.EventHandler(this.btnSaveAbsenteeism_Click);
            // 
            // btnCancelAddAbsenteeism
            // 
            this.btnCancelAddAbsenteeism.Location = new System.Drawing.Point(3, 106);
            this.btnCancelAddAbsenteeism.Name = "btnCancelAddAbsenteeism";
            this.btnCancelAddAbsenteeism.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddAbsenteeism.TabIndex = 6;
            this.btnCancelAddAbsenteeism.Text = "Abbrechen";
            this.btnCancelAddAbsenteeism.UseVisualStyleBackColor = true;
            this.btnCancelAddAbsenteeism.Click += new System.EventHandler(this.btnCancelAddAbsenteeism_Click);
            // 
            // tabHolidays
            // 
            this.tabHolidays.Controls.Add(this.panel2);
            this.tabHolidays.Location = new System.Drawing.Point(4, 24);
            this.tabHolidays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabHolidays.Name = "tabHolidays";
            this.tabHolidays.Size = new System.Drawing.Size(518, 244);
            this.tabHolidays.TabIndex = 3;
            this.tabHolidays.Text = "Urlaub";
            this.tabHolidays.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnDenyRequest);
            this.panel2.Controls.Add(this.btnAllowRequest);
            this.panel2.Controls.Add(this.lvHolidays);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 244);
            this.panel2.TabIndex = 4;
            // 
            // btnDenyRequest
            // 
            this.btnDenyRequest.Enabled = false;
            this.btnDenyRequest.Location = new System.Drawing.Point(349, 122);
            this.btnDenyRequest.Name = "btnDenyRequest";
            this.btnDenyRequest.Size = new System.Drawing.Size(140, 23);
            this.btnDenyRequest.TabIndex = 2;
            this.btnDenyRequest.Text = "Verweigern";
            this.btnDenyRequest.UseVisualStyleBackColor = true;
            // 
            // btnAllowRequest
            // 
            this.btnAllowRequest.Enabled = false;
            this.btnAllowRequest.Location = new System.Drawing.Point(349, 93);
            this.btnAllowRequest.Name = "btnAllowRequest";
            this.btnAllowRequest.Size = new System.Drawing.Size(140, 23);
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
            this.lvHolidays.Location = new System.Drawing.Point(3, 3);
            this.lvHolidays.Name = "lvHolidays";
            this.lvHolidays.Size = new System.Drawing.Size(320, 240);
            this.lvHolidays.TabIndex = 1;
            this.lvHolidays.UseCompatibleStateImageBehavior = false;
            this.lvHolidays.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Beginn";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ende";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Status";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 116;
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 317);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditEmployee";
            this.Text = "Mitarbeiter bearbeiten";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPersonalData.ResumeLayout(false);
            this.tabWorkingTimes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabSickDates.ResumeLayout(false);
            this.absenteeismListPanel.ResumeLayout(false);
            this.newAbsenteeismPanel.ResumeLayout(false);
            this.newAbsenteeismPanel.PerformLayout();
            this.tabHolidays.ResumeLayout(false);
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
        private TabPage tabPersonalData;
        private TabPage tabWorkingTimes;
        private TabPage tabSickDates;
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
        private TabPage tabHolidays;
        private Panel panel2;
        private Button btnDenyRequest;
        private Button btnAllowRequest;
        private ListView lvHolidays;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}