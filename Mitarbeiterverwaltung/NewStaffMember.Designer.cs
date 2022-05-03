namespace Mitarbeiterverwaltung
{
    partial class NewStaffMember
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_birthday = new System.Windows.Forms.Label();
            this.label_workingTimeWeek = new System.Windows.Forms.Label();
            this.label_holidays = new System.Windows.Forms.Label();
            this.label_adress = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.dateTimePicker_birthday = new System.Windows.Forms.DateTimePicker();
            this.textBox_workingTimeWeek = new System.Windows.Forms.TextBox();
            this.textBox_holidays = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 50);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(54, 15);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Vorname";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(12, 81);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(65, 15);
            this.label_surname.TabIndex = 1;
            this.label_surname.Text = "Nachname";
            // 
            // label_birthday
            // 
            this.label_birthday.AutoSize = true;
            this.label_birthday.Location = new System.Drawing.Point(12, 189);
            this.label_birthday.Name = "label_birthday";
            this.label_birthday.Size = new System.Drawing.Size(65, 15);
            this.label_birthday.TabIndex = 2;
            this.label_birthday.Text = "Geburtstag";
            // 
            // label_workingTimeWeek
            // 
            this.label_workingTimeWeek.AutoSize = true;
            this.label_workingTimeWeek.Location = new System.Drawing.Point(12, 223);
            this.label_workingTimeWeek.Name = "label_workingTimeWeek";
            this.label_workingTimeWeek.Size = new System.Drawing.Size(148, 15);
            this.label_workingTimeWeek.TabIndex = 3;
            this.label_workingTimeWeek.Text = "Arbeitsstunden pro Woche";
            // 
            // label_holidays
            // 
            this.label_holidays.AutoSize = true;
            this.label_holidays.Location = new System.Drawing.Point(239, 223);
            this.label_holidays.Name = "label_holidays";
            this.label_holidays.Size = new System.Drawing.Size(70, 15);
            this.label_holidays.TabIndex = 4;
            this.label_holidays.Text = "Urlaubstage";
            // 
            // label_adress
            // 
            this.label_adress.AutoSize = true;
            this.label_adress.Location = new System.Drawing.Point(12, 119);
            this.label_adress.Name = "label_adress";
            this.label_adress.Size = new System.Drawing.Size(55, 15);
            this.label_adress.TabIndex = 5;
            this.label_adress.Text = "Anschrift";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(12, 151);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(91, 15);
            this.label_phone.TabIndex = 6;
            this.label_phone.Text = "Telefonnummer";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(109, 47);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(168, 23);
            this.textBox_name.TabIndex = 7;
            this.textBox_name.Text = "Max";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(109, 81);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(168, 23);
            this.textBox_surname.TabIndex = 8;
            this.textBox_surname.Text = "Mustermann";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 23);
            this.textBox1.TabIndex = 9;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(109, 148);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(168, 23);
            this.textBox_phone.TabIndex = 10;
            // 
            // dateTimePicker_birthday
            // 
            this.dateTimePicker_birthday.Location = new System.Drawing.Point(109, 183);
            this.dateTimePicker_birthday.Name = "dateTimePicker_birthday";
            this.dateTimePicker_birthday.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_birthday.TabIndex = 11;
            this.dateTimePicker_birthday.Value = new System.DateTime(1970, 1, 1, 15, 27, 0, 0);
            // 
            // textBox_workingTimeWeek
            // 
            this.textBox_workingTimeWeek.Location = new System.Drawing.Point(166, 220);
            this.textBox_workingTimeWeek.Name = "textBox_workingTimeWeek";
            this.textBox_workingTimeWeek.Size = new System.Drawing.Size(41, 23);
            this.textBox_workingTimeWeek.TabIndex = 12;
            // 
            // textBox_holidays
            // 
            this.textBox_holidays.Location = new System.Drawing.Point(315, 220);
            this.textBox_holidays.Name = "textBox_holidays";
            this.textBox_holidays.Size = new System.Drawing.Size(44, 23);
            this.textBox_holidays.TabIndex = 13;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(369, 324);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 14;
            this.button_save.Text = "Speichern";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(288, 324);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 15;
            this.button_cancel.Text = "Abbrechen";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Location = new System.Drawing.Point(12, 9);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(386, 15);
            this.label_header.TabIndex = 16;
            this.label_header.Text = "Hier gibt es ein neues Fenster um einen neuen Mitarbeiter hinzuzufügen";
            // 
            // NewStaffMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 359);
            this.Controls.Add(this.label_header);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_holidays);
            this.Controls.Add(this.textBox_workingTimeWeek);
            this.Controls.Add(this.dateTimePicker_birthday);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_adress);
            this.Controls.Add(this.label_holidays);
            this.Controls.Add(this.label_workingTimeWeek);
            this.Controls.Add(this.label_birthday);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_name);
            this.Name = "NewStaffMember";
            this.Text = "Neuen Mitarbeiter hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_name;
        private Label label_surname;
        private Label label_birthday;
        private Label label_workingTimeWeek;
        private Label label_holidays;
        private Label label_adress;
        private Label label_phone;
        private TextBox textBox_name;
        private TextBox textBox_surname;
        private TextBox textBox1;
        private TextBox textBox_phone;
        private DateTimePicker dateTimePicker_birthday;
        private TextBox textBox_workingTimeWeek;
        private TextBox textBox_holidays;
        private Button button_saveStaffMember;
        private Button button_cancelNewStaffMember;
        private Label label_header;
        private Button button_save;
        private Button button_cancel;
    }
}