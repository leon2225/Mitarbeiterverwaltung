namespace Mitarbeiterverwaltung
{
    partial class EditTimeSpanView
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
            this.lblEnd2 = new System.Windows.Forms.Label();
            this.lblBeginn = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnd2
            // 
            this.lblEnd2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEnd2.AutoSize = true;
            this.lblEnd2.Location = new System.Drawing.Point(3, 39);
            this.lblEnd2.Name = "lblEnd2";
            this.lblEnd2.Size = new System.Drawing.Size(33, 15);
            this.lblEnd2.TabIndex = 1;
            this.lblEnd2.Text = "Ende";
            // 
            // lblBeginn
            // 
            this.lblBeginn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBeginn.AutoSize = true;
            this.lblBeginn.Location = new System.Drawing.Point(3, 8);
            this.lblBeginn.Name = "lblBeginn";
            this.lblBeginn.Size = new System.Drawing.Size(46, 15);
            this.lblBeginn.TabIndex = 2;
            this.lblBeginn.Text = "Anfang";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(114, 35);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(102, 23);
            this.dtpEnd.TabIndex = 3;
            // 
            // dtpBegin
            // 
            this.dtpBegin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBegin.Location = new System.Drawing.Point(114, 4);
            this.dtpBegin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(102, 23);
            this.dtpBegin.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblEnd2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBeginn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpBegin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpEnd, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnOk, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(219, 94);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(3, 70);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 22);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(134, 70);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(82, 22);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Hinzufügen";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // EditTimeSpanView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 106);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "EditTimeSpanView";
            this.ShowIcon = false;
            this.Text = "Krankheitstage hinzufügen";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblEnd2;
        private Label lblBeginn;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpBegin;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnCancel;
        private Button btnOk;
    }
}