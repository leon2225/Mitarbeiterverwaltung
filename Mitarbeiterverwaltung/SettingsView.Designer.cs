namespace Mitarbeiterverwaltung
{
    partial class SettingsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsView));
            this.lblSetCompanyName = new System.Windows.Forms.Label();
            this.lblSetLogoPath = new System.Windows.Forms.Label();
            this.lblSetCsvFilePath = new System.Windows.Forms.Label();
            this.lblSetTimeRounding = new System.Windows.Forms.Label();
            this.openFileDialogCsv = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogPng = new System.Windows.Forms.OpenFileDialog();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtfilePathIcon = new System.Windows.Forms.TextBox();
            this.txtFilePathCsv = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewIconPath = new System.Windows.Forms.Button();
            this.btnNewCsvPath = new System.Windows.Forms.Button();
            this.nmbrRounding = new System.Windows.Forms.ComboBox();
            this.lblSetAutoLogout = new System.Windows.Forms.Label();
            this.lblRoundingUnit = new System.Windows.Forms.Label();
            this.lblLogoutTimeUnit = new System.Windows.Forms.Label();
            this.mtxtAutoLogoutTimeout = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblSetCompanyName
            // 
            this.lblSetCompanyName.AutoSize = true;
            this.lblSetCompanyName.Location = new System.Drawing.Point(12, 22);
            this.lblSetCompanyName.Name = "lblSetCompanyName";
            this.lblSetCompanyName.Size = new System.Drawing.Size(74, 15);
            this.lblSetCompanyName.TabIndex = 0;
            this.lblSetCompanyName.Text = "Firmenname";
            // 
            // lblSetLogoPath
            // 
            this.lblSetLogoPath.AutoSize = true;
            this.lblSetLogoPath.Location = new System.Drawing.Point(12, 52);
            this.lblSetLogoPath.Name = "lblSetLogoPath";
            this.lblSetLogoPath.Size = new System.Drawing.Size(61, 15);
            this.lblSetLogoPath.TabIndex = 1;
            this.lblSetLogoPath.Text = "Logo Pfad";
            // 
            // lblSetCsvFilePath
            // 
            this.lblSetCsvFilePath.AutoSize = true;
            this.lblSetCsvFilePath.Location = new System.Drawing.Point(12, 84);
            this.lblSetCsvFilePath.Name = "lblSetCsvFilePath";
            this.lblSetCsvFilePath.Size = new System.Drawing.Size(106, 15);
            this.lblSetCsvFilePath.TabIndex = 2;
            this.lblSetCsvFilePath.Text = "Pfad zur CSV-Datei";
            // 
            // lblSetTimeRounding
            // 
            this.lblSetTimeRounding.AutoSize = true;
            this.lblSetTimeRounding.Location = new System.Drawing.Point(12, 113);
            this.lblSetTimeRounding.Name = "lblSetTimeRounding";
            this.lblSetTimeRounding.Size = new System.Drawing.Size(73, 15);
            this.lblSetTimeRounding.TabIndex = 3;
            this.lblSetTimeRounding.Text = "Zeitrundung";
            // 
            // openFileDialogCsv
            // 
            this.openFileDialogCsv.FileName = "openFileDialogCsv";
            this.openFileDialogCsv.Filter = "CSV Datei (*.csv)|*.csv";
            // 
            // openFileDialogPng
            // 
            this.openFileDialogPng.FileName = "openFileDialogPng";
            this.openFileDialogPng.Filter = "PNG Bild|*.png";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyName.Location = new System.Drawing.Point(165, 18);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(410, 23);
            this.txtCompanyName.TabIndex = 1;
            // 
            // txtfilePathIcon
            // 
            this.txtfilePathIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfilePathIcon.Enabled = false;
            this.txtfilePathIcon.Location = new System.Drawing.Point(165, 48);
            this.txtfilePathIcon.Name = "txtfilePathIcon";
            this.txtfilePathIcon.Size = new System.Drawing.Size(370, 23);
            this.txtfilePathIcon.TabIndex = 90;
            // 
            // txtFilePathCsv
            // 
            this.txtFilePathCsv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePathCsv.Enabled = false;
            this.txtFilePathCsv.Location = new System.Drawing.Point(165, 80);
            this.txtFilePathCsv.Name = "txtFilePathCsv";
            this.txtFilePathCsv.Size = new System.Drawing.Size(370, 23);
            this.txtFilePathCsv.TabIndex = 91;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(413, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(500, 180);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNewIconPath
            // 
            this.btnNewIconPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewIconPath.Location = new System.Drawing.Point(541, 48);
            this.btnNewIconPath.Name = "btnNewIconPath";
            this.btnNewIconPath.Size = new System.Drawing.Size(34, 23);
            this.btnNewIconPath.TabIndex = 2;
            this.btnNewIconPath.Text = "...";
            this.btnNewIconPath.UseVisualStyleBackColor = true;
            this.btnNewIconPath.Click += new System.EventHandler(this.btnIcon_Click);
            // 
            // btnNewCsvPath
            // 
            this.btnNewCsvPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewCsvPath.Location = new System.Drawing.Point(541, 79);
            this.btnNewCsvPath.Name = "btnNewCsvPath";
            this.btnNewCsvPath.Size = new System.Drawing.Size(34, 23);
            this.btnNewCsvPath.TabIndex = 3;
            this.btnNewCsvPath.Text = "...";
            this.btnNewCsvPath.UseVisualStyleBackColor = true;
            this.btnNewCsvPath.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // nmbrRounding
            // 
            this.nmbrRounding.FormattingEnabled = true;
            this.nmbrRounding.Items.AddRange(new object[] {
            "1",
            "5",
            "15"});
            this.nmbrRounding.Location = new System.Drawing.Point(165, 108);
            this.nmbrRounding.Name = "nmbrRounding";
            this.nmbrRounding.Size = new System.Drawing.Size(140, 23);
            this.nmbrRounding.TabIndex = 4;
            // 
            // lblSetAutoLogout
            // 
            this.lblSetAutoLogout.AutoSize = true;
            this.lblSetAutoLogout.Location = new System.Drawing.Point(12, 140);
            this.lblSetAutoLogout.Name = "lblSetAutoLogout";
            this.lblSetAutoLogout.Size = new System.Drawing.Size(147, 15);
            this.lblSetAutoLogout.TabIndex = 14;
            this.lblSetAutoLogout.Text = "Automatische Abmeldung";
            // 
            // lblRoundingUnit
            // 
            this.lblRoundingUnit.AutoSize = true;
            this.lblRoundingUnit.Location = new System.Drawing.Point(311, 113);
            this.lblRoundingUnit.Name = "lblRoundingUnit";
            this.lblRoundingUnit.Size = new System.Drawing.Size(60, 15);
            this.lblRoundingUnit.TabIndex = 16;
            this.lblRoundingUnit.Text = "Minute(n)";
            // 
            // lblLogoutTimeUnit
            // 
            this.lblLogoutTimeUnit.AutoSize = true;
            this.lblLogoutTimeUnit.Location = new System.Drawing.Point(311, 140);
            this.lblLogoutTimeUnit.Name = "lblLogoutTimeUnit";
            this.lblLogoutTimeUnit.Size = new System.Drawing.Size(60, 15);
            this.lblLogoutTimeUnit.TabIndex = 17;
            this.lblLogoutTimeUnit.Text = "Minute(n)";
            // 
            // mtxtAutoLogoutTimeout
            // 
            this.mtxtAutoLogoutTimeout.BeepOnError = true;
            this.mtxtAutoLogoutTimeout.HidePromptOnLeave = true;
            this.mtxtAutoLogoutTimeout.Location = new System.Drawing.Point(165, 137);
            this.mtxtAutoLogoutTimeout.Mask = "000";
            this.mtxtAutoLogoutTimeout.Name = "mtxtAutoLogoutTimeout";
            this.mtxtAutoLogoutTimeout.Size = new System.Drawing.Size(140, 23);
            this.mtxtAutoLogoutTimeout.TabIndex = 5;
            this.mtxtAutoLogoutTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 215);
            this.Controls.Add(this.mtxtAutoLogoutTimeout);
            this.Controls.Add(this.lblLogoutTimeUnit);
            this.Controls.Add(this.lblRoundingUnit);
            this.Controls.Add(this.lblSetAutoLogout);
            this.Controls.Add(this.nmbrRounding);
            this.Controls.Add(this.btnNewCsvPath);
            this.Controls.Add(this.btnNewIconPath);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtFilePathCsv);
            this.Controls.Add(this.txtfilePathIcon);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblSetTimeRounding);
            this.Controls.Add(this.lblSetCsvFilePath);
            this.Controls.Add(this.lblSetLogoPath);
            this.Controls.Add(this.lblSetCompanyName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsView";
            this.Text = "Einstellungen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSetCompanyName;
        private Label lblSetLogoPath;
        private Label lblSetCsvFilePath;
        private Label lblSetTimeRounding;
        private OpenFileDialog openFileDialogCsv;
        private OpenFileDialog openFileDialogPng;
        private TextBox txtCompanyName;
        private TextBox txtfilePathIcon;
        private TextBox txtFilePathCsv;
        private Button btnCancel;
        private Button btnSave;
        private Button btnNewIconPath;
        private Button btnNewCsvPath;
        private ComboBox nmbrRounding;
        private Label lblSetAutoLogout;
        private Label lblRoundingUnit;
        private Label lblLogoutTimeUnit;
        private MaskedTextBox mtxtAutoLogoutTimeout;
    }
}