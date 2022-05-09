namespace Mitarbeiterverwaltung
{
    partial class SettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialogCsv = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogPng = new System.Windows.Forms.OpenFileDialog();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtfilePathIcon = new System.Windows.Forms.TextBox();
            this.txtFilePathCsv = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnIcon = new System.Windows.Forms.Button();
            this.btnCsv = new System.Windows.Forms.Button();
            this.nmbrRounding = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrRounding)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firmenname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logo Pfad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pfad zur CSV-Datei";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zeitrundung";
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
            this.txtCompanyName.Location = new System.Drawing.Point(149, 18);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(426, 23);
            this.txtCompanyName.TabIndex = 4;
            // 
            // txtfilePathIcon
            // 
            this.txtfilePathIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfilePathIcon.Enabled = false;
            this.txtfilePathIcon.Location = new System.Drawing.Point(149, 48);
            this.txtfilePathIcon.Name = "txtfilePathIcon";
            this.txtfilePathIcon.Size = new System.Drawing.Size(386, 23);
            this.txtfilePathIcon.TabIndex = 5;
            // 
            // txtFilePathCsv
            // 
            this.txtFilePathCsv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePathCsv.Enabled = false;
            this.txtFilePathCsv.Location = new System.Drawing.Point(149, 80);
            this.txtFilePathCsv.Name = "txtFilePathCsv";
            this.txtFilePathCsv.Size = new System.Drawing.Size(386, 23);
            this.txtFilePathCsv.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(413, 141);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(500, 141);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnIcon
            // 
            this.btnIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIcon.Location = new System.Drawing.Point(541, 48);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(34, 23);
            this.btnIcon.TabIndex = 10;
            this.btnIcon.Text = "...";
            this.btnIcon.UseVisualStyleBackColor = true;
            this.btnIcon.Click += new System.EventHandler(this.btnIcon_Click);
            // 
            // btnCsv
            // 
            this.btnCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCsv.Location = new System.Drawing.Point(541, 79);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(34, 23);
            this.btnCsv.TabIndex = 11;
            this.btnCsv.Text = "...";
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // nmbrRounding
            // 
            this.nmbrRounding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmbrRounding.Location = new System.Drawing.Point(149, 109);
            this.nmbrRounding.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmbrRounding.Name = "nmbrRounding";
            this.nmbrRounding.Size = new System.Drawing.Size(426, 23);
            this.nmbrRounding.TabIndex = 12;
            this.nmbrRounding.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmbrRounding.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 176);
            this.Controls.Add(this.nmbrRounding);
            this.Controls.Add(this.btnCsv);
            this.Controls.Add(this.btnIcon);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtFilePathCsv);
            this.Controls.Add(this.txtfilePathIcon);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsDialog";
            this.Text = "Einstellungen";
            ((System.ComponentModel.ISupportInitialize)(this.nmbrRounding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private OpenFileDialog openFileDialogCsv;
        private OpenFileDialog openFileDialogPng;
        private TextBox txtCompanyName;
        private TextBox txtfilePathIcon;
        private TextBox txtFilePathCsv;
        private Button btnCancel;
        private Button btnSave;
        private Button btnIcon;
        private Button btnCsv;
        private NumericUpDown nmbrRounding;
    }
}