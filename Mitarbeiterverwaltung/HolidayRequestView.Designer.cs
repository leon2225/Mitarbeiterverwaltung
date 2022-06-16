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
            this.pnlNewHolidayRequest = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRemainingHolidays = new System.Windows.Forms.Label();
            this.dtpHolidayStart = new System.Windows.Forms.DateTimePicker();
            this.chkHalfDayBegin = new System.Windows.Forms.CheckBox();
            this.chkHalfDayEnd = new System.Windows.Forms.CheckBox();
            this.lblRemainingHolidaysPreview = new System.Windows.Forms.Label();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.btnCancelRequest = new System.Windows.Forms.Button();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRemainingOvertimePreview = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dtpHolidayEnd = new System.Windows.Forms.DateTimePicker();
            this.tabControlHolidayRequest = new System.Windows.Forms.TabControl();
            this.tabNewRequest = new System.Windows.Forms.TabPage();
            this.tabViewRequests = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvHolidayRequests = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.pnlNewHolidayRequest.SuspendLayout();
            this.tabControlHolidayRequest.SuspendLayout();
            this.tabNewRequest.SuspendLayout();
            this.tabViewRequests.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNewHolidayRequest
            // 
            this.pnlNewHolidayRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNewHolidayRequest.BackColor = System.Drawing.SystemColors.Control;
            this.pnlNewHolidayRequest.ColumnCount = 3;
            this.pnlNewHolidayRequest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.04869F));
            this.pnlNewHolidayRequest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.95131F));
            this.pnlNewHolidayRequest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.pnlNewHolidayRequest.Controls.Add(this.label1, 0, 0);
            this.pnlNewHolidayRequest.Controls.Add(this.label2, 0, 1);
            this.pnlNewHolidayRequest.Controls.Add(this.dtpHolidayStart, 1, 0);
            this.pnlNewHolidayRequest.Controls.Add(this.chkHalfDayBegin, 2, 0);
            this.pnlNewHolidayRequest.Controls.Add(this.chkHalfDayEnd, 2, 1);
            this.pnlNewHolidayRequest.Controls.Add(this.btnCancelRequest, 0, 4);
            this.pnlNewHolidayRequest.Controls.Add(this.btnSendRequest, 2, 4);
            this.pnlNewHolidayRequest.Controls.Add(this.dtpHolidayEnd, 1, 1);
            this.pnlNewHolidayRequest.Controls.Add(this.lblRemainingHolidays, 0, 3);
            this.pnlNewHolidayRequest.Controls.Add(this.label3, 0, 2);
            this.pnlNewHolidayRequest.Controls.Add(this.lblRemainingHolidaysPreview, 1, 3);
            this.pnlNewHolidayRequest.Controls.Add(this.lblRemainingOvertimePreview, 1, 2);
            this.pnlNewHolidayRequest.Controls.Add(this.lblInvalid, 2, 3);
            this.pnlNewHolidayRequest.Controls.Add(this.checkBox1, 2, 2);
            this.pnlNewHolidayRequest.Location = new System.Drawing.Point(0, 0);
            this.pnlNewHolidayRequest.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNewHolidayRequest.Name = "pnlNewHolidayRequest";
            this.pnlNewHolidayRequest.RowCount = 5;
            this.pnlNewHolidayRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.09273F));
            this.pnlNewHolidayRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.58474F));
            this.pnlNewHolidayRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.2317F));
            this.pnlNewHolidayRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.09083F));
            this.pnlNewHolidayRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.pnlNewHolidayRequest.Size = new System.Drawing.Size(385, 200);
            this.pnlNewHolidayRequest.TabIndex = 0;
            this.pnlNewHolidayRequest.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNewHolidayRequest_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beginn des Urlaubs";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ende des Urlaubs";
            // 
            // lblRemainingHolidays
            // 
            this.lblRemainingHolidays.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRemainingHolidays.AutoSize = true;
            this.lblRemainingHolidays.Location = new System.Drawing.Point(3, 113);
            this.lblRemainingHolidays.Name = "lblRemainingHolidays";
            this.lblRemainingHolidays.Size = new System.Drawing.Size(141, 15);
            this.lblRemainingHolidays.TabIndex = 2;
            this.lblRemainingHolidays.Text = "Verbleibende Urlaubstage";
            // 
            // dtpHolidayStart
            // 
            this.dtpHolidayStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpHolidayStart.CustomFormat = "MMMM dd, yyyy - dddd";
            this.dtpHolidayStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHolidayStart.Location = new System.Drawing.Point(186, 6);
            this.dtpHolidayStart.Name = "dtpHolidayStart";
            this.dtpHolidayStart.Size = new System.Drawing.Size(92, 23);
            this.dtpHolidayStart.TabIndex = 5;
            this.dtpHolidayStart.ValueChanged += new System.EventHandler(this.holidayRangeChanged);
            // 
            // chkHalfDayBegin
            // 
            this.chkHalfDayBegin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkHalfDayBegin.AutoSize = true;
            this.chkHalfDayBegin.Location = new System.Drawing.Point(302, 8);
            this.chkHalfDayBegin.Name = "chkHalfDayBegin";
            this.chkHalfDayBegin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkHalfDayBegin.Size = new System.Drawing.Size(80, 19);
            this.chkHalfDayBegin.TabIndex = 8;
            this.chkHalfDayBegin.Text = "halber Tag";
            this.chkHalfDayBegin.UseVisualStyleBackColor = true;
            this.chkHalfDayBegin.CheckedChanged += new System.EventHandler(this.holidayRangeChanged);
            // 
            // chkHalfDayEnd
            // 
            this.chkHalfDayEnd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkHalfDayEnd.AutoSize = true;
            this.chkHalfDayEnd.Location = new System.Drawing.Point(302, 43);
            this.chkHalfDayEnd.Name = "chkHalfDayEnd";
            this.chkHalfDayEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkHalfDayEnd.Size = new System.Drawing.Size(80, 19);
            this.chkHalfDayEnd.TabIndex = 9;
            this.chkHalfDayEnd.Text = "halber Tag";
            this.chkHalfDayEnd.UseVisualStyleBackColor = true;
            this.chkHalfDayEnd.CheckedChanged += new System.EventHandler(this.holidayRangeChanged);
            // 
            // lblRemainingHolidaysPreview
            // 
            this.lblRemainingHolidaysPreview.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRemainingHolidaysPreview.AutoSize = true;
            this.lblRemainingHolidaysPreview.Location = new System.Drawing.Point(175, 113);
            this.lblRemainingHolidaysPreview.Name = "lblRemainingHolidaysPreview";
            this.lblRemainingHolidaysPreview.Size = new System.Drawing.Size(13, 15);
            this.lblRemainingHolidaysPreview.TabIndex = 7;
            this.lblRemainingHolidaysPreview.Text = "0";
            // 
            // lblInvalid
            // 
            this.lblInvalid.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblInvalid.Location = new System.Drawing.Point(329, 113);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(53, 15);
            this.lblInvalid.TabIndex = 10;
            this.lblInvalid.Text = "Ungültig";
            this.lblInvalid.Visible = false;
            // 
            // btnCancelRequest
            // 
            this.btnCancelRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelRequest.Location = new System.Drawing.Point(3, 174);
            this.btnCancelRequest.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.btnCancelRequest.Name = "btnCancelRequest";
            this.btnCancelRequest.Size = new System.Drawing.Size(75, 20);
            this.btnCancelRequest.TabIndex = 3;
            this.btnCancelRequest.Text = "Abbrechen";
            this.btnCancelRequest.UseVisualStyleBackColor = true;
            this.btnCancelRequest.Click += new System.EventHandler(this.btnCancelRequest_Click);
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendRequest.Location = new System.Drawing.Point(307, 174);
            this.btnSendRequest.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(75, 20);
            this.btnSendRequest.TabIndex = 4;
            this.btnSendRequest.Text = "Absenden";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Verbleibende Überstunden";
            // 
            // lblRemainingOvertimePreview
            // 
            this.lblRemainingOvertimePreview.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRemainingOvertimePreview.AutoSize = true;
            this.lblRemainingOvertimePreview.Location = new System.Drawing.Point(175, 79);
            this.lblRemainingOvertimePreview.Name = "lblRemainingOvertimePreview";
            this.lblRemainingOvertimePreview.Size = new System.Drawing.Size(13, 15);
            this.lblRemainingOvertimePreview.TabIndex = 12;
            this.lblRemainingOvertimePreview.Text = "0";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(284, 77);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 19);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Verwenden";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dtpHolidayEnd
            // 
            this.dtpHolidayEnd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpHolidayEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHolidayEnd.Location = new System.Drawing.Point(186, 41);
            this.dtpHolidayEnd.Name = "dtpHolidayEnd";
            this.dtpHolidayEnd.Size = new System.Drawing.Size(92, 23);
            this.dtpHolidayEnd.TabIndex = 6;
            this.dtpHolidayEnd.ValueChanged += new System.EventHandler(this.holidayRangeChanged);
            // 
            // tabControlHolidayRequest
            // 
            this.tabControlHolidayRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlHolidayRequest.Controls.Add(this.tabNewRequest);
            this.tabControlHolidayRequest.Controls.Add(this.tabViewRequests);
            this.tabControlHolidayRequest.Location = new System.Drawing.Point(12, 12);
            this.tabControlHolidayRequest.Name = "tabControlHolidayRequest";
            this.tabControlHolidayRequest.SelectedIndex = 0;
            this.tabControlHolidayRequest.Size = new System.Drawing.Size(393, 225);
            this.tabControlHolidayRequest.TabIndex = 1;
            this.tabControlHolidayRequest.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlHolidayRequest_Selected);
            // 
            // tabNewRequest
            // 
            this.tabNewRequest.Controls.Add(this.pnlNewHolidayRequest);
            this.tabNewRequest.Location = new System.Drawing.Point(4, 24);
            this.tabNewRequest.Name = "tabNewRequest";
            this.tabNewRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewRequest.Size = new System.Drawing.Size(385, 197);
            this.tabNewRequest.TabIndex = 0;
            this.tabNewRequest.Text = "Neuen Antrag stellen";
            this.tabNewRequest.UseVisualStyleBackColor = true;
            // 
            // tabViewRequests
            // 
            this.tabViewRequests.Controls.Add(this.panel1);
            this.tabViewRequests.Location = new System.Drawing.Point(4, 24);
            this.tabViewRequests.Name = "tabViewRequests";
            this.tabViewRequests.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewRequests.Size = new System.Drawing.Size(385, 197);
            this.tabViewRequests.TabIndex = 1;
            this.tabViewRequests.Text = "Anträge einsehen";
            this.tabViewRequests.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lvHolidayRequests);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 201);
            this.panel1.TabIndex = 1;
            // 
            // lvHolidayRequests
            // 
            this.lvHolidayRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvHolidayRequests.Location = new System.Drawing.Point(6, 6);
            this.lvHolidayRequests.Name = "lvHolidayRequests";
            this.lvHolidayRequests.Size = new System.Drawing.Size(353, 168);
            this.lvHolidayRequests.TabIndex = 0;
            this.lvHolidayRequests.UseCompatibleStateImageBehavior = false;
            this.lvHolidayRequests.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Beginn";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ende";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 145;
            // 
            // HolidayRequestView
            // 
            this.AcceptButton = this.btnSendRequest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelRequest;
            this.ClientSize = new System.Drawing.Size(417, 248);
            this.Controls.Add(this.tabControlHolidayRequest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HolidayRequestView";
            this.Text = "Urlaubsverwaltung";
            this.pnlNewHolidayRequest.ResumeLayout(false);
            this.pnlNewHolidayRequest.PerformLayout();
            this.tabControlHolidayRequest.ResumeLayout(false);
            this.tabNewRequest.ResumeLayout(false);
            this.tabViewRequests.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel pnlNewHolidayRequest;
        private Label label1;
        private Label label2;
        private Label lblRemainingHolidays;
        private Button btnCancelRequest;
        private Button btnSendRequest;
        private DateTimePicker dtpHolidayStart;
        private DateTimePicker dtpHolidayEnd;
        private Label lblRemainingHolidaysPreview;
        private CheckBox chkHalfDayBegin;
        private CheckBox chkHalfDayEnd;
        private Label lblInvalid;
        private TabControl tabControlHolidayRequest;
        private TabPage tabNewRequest;
        private TabPage tabViewRequests;
        private ListView lvHolidayRequests;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Panel panel1;
        private Label label3;
        private Label lblRemainingOvertimePreview;
        private CheckBox checkBox1;
    }
}