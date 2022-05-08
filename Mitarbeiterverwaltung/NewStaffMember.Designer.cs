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
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(10, 16);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(54, 15);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Vorname";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(10, 50);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(65, 15);
            this.label_surname.TabIndex = 1;
            this.label_surname.Text = "Nachname";
            // 
            // label_workingTimeWeek
            // 
            this.label_workingTimeWeek.AutoSize = true;
            this.label_workingTimeWeek.Location = new System.Drawing.Point(10, 184);
            this.label_workingTimeWeek.Name = "label_workingTimeWeek";
            this.label_workingTimeWeek.Size = new System.Drawing.Size(148, 15);
            this.label_workingTimeWeek.TabIndex = 3;
            this.label_workingTimeWeek.Text = "Arbeitsstunden pro Woche";
            // 
            // label_holidays
            // 
            this.label_holidays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_holidays.AutoSize = true;
            this.label_holidays.Location = new System.Drawing.Point(334, 184);
            this.label_holidays.Name = "label_holidays";
            this.label_holidays.Size = new System.Drawing.Size(70, 15);
            this.label_holidays.TabIndex = 4;
            this.label_holidays.Text = "Urlaubstage";
            // 
            // label_adress
            // 
            this.label_adress.AutoSize = true;
            this.label_adress.Location = new System.Drawing.Point(10, 117);
            this.label_adress.Name = "label_adress";
            this.label_adress.Size = new System.Drawing.Size(55, 15);
            this.label_adress.TabIndex = 5;
            this.label_adress.Text = "Anschrift";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(10, 151);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(91, 15);
            this.label_phone.TabIndex = 6;
            this.label_phone.Text = "Telefonnummer";
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_name.Location = new System.Drawing.Point(106, 12);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(344, 23);
            this.textBox_name.TabIndex = 7;
            this.textBox_name.Text = "Max";
            this.textBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_surname.Location = new System.Drawing.Point(106, 46);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(344, 23);
            this.textBox_surname.TabIndex = 8;
            this.textBox_surname.Text = "Mustermann";
            this.textBox_surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_adress
            // 
            this.textBox_adress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_adress.Location = new System.Drawing.Point(106, 113);
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(344, 23);
            this.textBox_adress.TabIndex = 9;
            this.textBox_adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_phone.Location = new System.Drawing.Point(106, 147);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(344, 23);
            this.textBox_phone.TabIndex = 10;
            this.textBox_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_weekTimeLimit
            // 
            this.textBox_weekTimeLimit.Location = new System.Drawing.Point(164, 180);
            this.textBox_weekTimeLimit.Name = "textBox_weekTimeLimit";
            this.textBox_weekTimeLimit.Size = new System.Drawing.Size(41, 23);
            this.textBox_weekTimeLimit.TabIndex = 12;
            // 
            // textBox_holidays
            // 
            this.textBox_holidays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_holidays.Location = new System.Drawing.Point(406, 180);
            this.textBox_holidays.Name = "textBox_holidays";
            this.textBox_holidays.Size = new System.Drawing.Size(44, 23);
            this.textBox_holidays.TabIndex = 13;
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Location = new System.Drawing.Point(375, 217);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 14;
            this.button_save.Text = "Speichern";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.Location = new System.Drawing.Point(294, 217);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 15;
            this.button_cancel.Text = "Abbrechen";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // txtPassword
            // 
            this.textBox_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_password.Location = new System.Drawing.Point(106, 79);
            this.textBox_password.Name = "txtPassword";
            this.textBox_password.Size = new System.Drawing.Size(344, 23);
            this.textBox_password.TabIndex = 17;
            this.textBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Passwort";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Location = new System.Drawing.Point(10, 217);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Entfernen";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewStaffMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 252);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_holidays);
            this.Controls.Add(this.textBox_weekTimeLimit);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_adress);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_adress);
            this.Controls.Add(this.label_holidays);
            this.Controls.Add(this.label_workingTimeWeek);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_name);
            this.MaximizeBox = false;
            this.Name = "NewStaffMember";
            this.Text = "Neuen Mitarbeiter hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox textBox_password;
        private Label label1;
        private Button btnRemove;
    }
}