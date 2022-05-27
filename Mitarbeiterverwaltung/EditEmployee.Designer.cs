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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.label_holidays.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.textBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_name, 3);
            this.textBox_name.Location = new System.Drawing.Point(157, 3);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(344, 23);
            this.textBox_name.TabIndex = 7;
            this.textBox_name.Text = "Max";
            this.textBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_surname, 3);
            this.textBox_surname.Location = new System.Drawing.Point(157, 32);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(344, 23);
            this.textBox_surname.TabIndex = 8;
            this.textBox_surname.Text = "Mustermann";
            this.textBox_surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_adress
            // 
            this.textBox_adress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_adress, 3);
            this.textBox_adress.Location = new System.Drawing.Point(157, 61);
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(344, 23);
            this.textBox_adress.TabIndex = 9;
            this.textBox_adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_phone, 3);
            this.textBox_phone.Location = new System.Drawing.Point(157, 90);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(344, 23);
            this.textBox_phone.TabIndex = 10;
            this.textBox_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_weekTimeLimit
            // 
            this.textBox_weekTimeLimit.Location = new System.Drawing.Point(157, 119);
            this.textBox_weekTimeLimit.Name = "textBox_weekTimeLimit";
            this.textBox_weekTimeLimit.Size = new System.Drawing.Size(41, 23);
            this.textBox_weekTimeLimit.TabIndex = 12;
            // 
            // textBox_holidays
            // 
            this.textBox_holidays.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_holidays.Location = new System.Drawing.Point(280, 119);
            this.textBox_holidays.Name = "textBox_holidays";
            this.textBox_holidays.Size = new System.Drawing.Size(44, 23);
            this.textBox_holidays.TabIndex = 13;
            // 
            // button_save
            // 
            this.button_save.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_save.Location = new System.Drawing.Point(143, 3);
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
            this.button_cancel.Location = new System.Drawing.Point(32, 3);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 22);
            this.button_cancel.TabIndex = 15;
            this.button_cancel.Text = "Abbrechen";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRemove.Location = new System.Drawing.Point(3, 179);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Entfernen";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
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
            this.tableLayoutPanel1.Controls.Add(this.label_holidays, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnResetPassword, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 205);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button_save, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_cancel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(280, 177);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(221, 28);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Passwort";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnResetPassword, 2);
            this.btnResetPassword.Enabled = false;
            this.btnResetPassword.Location = new System.Drawing.Point(157, 148);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(117, 23);
            this.btnResetPassword.TabIndex = 21;
            this.btnResetPassword.Text = "Zurücksetzen";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 227);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditEmployee";
            this.Text = "Neuen Mitarbeiter hinzufügen";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Button btnResetPassword;
    }
}