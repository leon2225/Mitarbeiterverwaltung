namespace Mitarbeiterverwaltung
{
    partial class HolidayRequestView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelRequest = new System.Windows.Forms.Button();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.dtpHolidayStart = new System.Windows.Forms.DateTimePicker();
            this.dtpHolidayEnd = new System.Windows.Forms.DateTimePicker();
            this.lblRemainingHolidaysPreview = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.11765F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.88235F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelRequest, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSendRequest, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpHolidayStart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpHolidayEnd, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRemainingHolidaysPreview, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.49754F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.15435F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.34811F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(354, 147);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beginn des Urlaubs";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ende des Urlaubs";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Verbleibende Urlaubstage";
            // 
            // btnCancelRequest
            // 
            this.btnCancelRequest.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelRequest.Location = new System.Drawing.Point(3, 123);
            this.btnCancelRequest.Name = "btnCancelRequest";
            this.btnCancelRequest.Size = new System.Drawing.Size(75, 20);
            this.btnCancelRequest.TabIndex = 3;
            this.btnCancelRequest.Text = "Abbrechen";
            this.btnCancelRequest.UseVisualStyleBackColor = true;
            this.btnCancelRequest.Click += new System.EventHandler(this.btnCancelRequest_Click);
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSendRequest.Location = new System.Drawing.Point(276, 123);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(75, 20);
            this.btnSendRequest.TabIndex = 4;
            this.btnSendRequest.Text = "Absenden";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // dtpHolidayStart
            // 
            this.dtpHolidayStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpHolidayStart.CustomFormat = "MMMM dd, yyyy - dddd";
            this.dtpHolidayStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHolidayStart.Location = new System.Drawing.Point(194, 8);
            this.dtpHolidayStart.Name = "dtpHolidayStart";
            this.dtpHolidayStart.Size = new System.Drawing.Size(157, 23);
            this.dtpHolidayStart.TabIndex = 5;
            // 
            // dtpHolidayEnd
            // 
            this.dtpHolidayEnd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpHolidayEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHolidayEnd.Location = new System.Drawing.Point(194, 49);
            this.dtpHolidayEnd.Name = "dtpHolidayEnd";
            this.dtpHolidayEnd.Size = new System.Drawing.Size(157, 23);
            this.dtpHolidayEnd.TabIndex = 6;
            this.dtpHolidayEnd.ValueChanged += new System.EventHandler(this.dtpHolidayEnd_ValueChanged);
            // 
            // lblRemainingHolidaysPreview
            // 
            this.lblRemainingHolidaysPreview.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRemainingHolidaysPreview.AutoSize = true;
            this.lblRemainingHolidaysPreview.Location = new System.Drawing.Point(338, 93);
            this.lblRemainingHolidaysPreview.Name = "lblRemainingHolidaysPreview";
            this.lblRemainingHolidaysPreview.Size = new System.Drawing.Size(13, 15);
            this.lblRemainingHolidaysPreview.TabIndex = 7;
            this.lblRemainingHolidaysPreview.Text = "0";
            // 
            // HolidayRequestView
            // 
            this.AcceptButton = this.btnSendRequest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelRequest;
            this.ClientSize = new System.Drawing.Size(376, 162);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HolidayRequestView";
            this.Text = "Urlaubsantrag stellen";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCancelRequest;
        private Button btnSendRequest;
        private DateTimePicker dtpHolidayStart;
        private DateTimePicker dtpHolidayEnd;
        private Label lblRemainingHolidaysPreview;
    }
}