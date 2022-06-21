namespace Mitarbeiterverwaltung
{
    partial class VacationRequestView
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
            this.lblVacationBegin = new System.Windows.Forms.Label();
            this.lblVacationEnd = new System.Windows.Forms.Label();
            this.dtpVacationStart = new System.Windows.Forms.DateTimePicker();
            this.chkHalfDayBegin = new System.Windows.Forms.CheckBox();
            this.chkHalfDayEnd = new System.Windows.Forms.CheckBox();
            this.btnCancelRequest = new System.Windows.Forms.Button();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.dtpVacationEnd = new System.Windows.Forms.DateTimePicker();
            this.lblRemainingHolidays = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRemainingHolidaysPreview = new System.Windows.Forms.Label();
            this.lblRemainingOvertimePreview = new System.Windows.Forms.Label();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.chkUseOvertime = new System.Windows.Forms.CheckBox();
            this.tabControlHolidayRequest = new System.Windows.Forms.TabControl();
            this.tabNewRequest = new System.Windows.Forms.TabPage();
            this.tabViewRequests = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvVacationRequests = new System.Windows.Forms.ListView();
            this.chVacationBegin = new System.Windows.Forms.ColumnHeader();
            this.chVacationEnd = new System.Windows.Forms.ColumnHeader();
            this.chVacationState = new System.Windows.Forms.ColumnHeader();
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
            this.pnlNewHolidayRequest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.pnlNewHolidayRequest.Controls.Add(this.lblVacationBegin, 0, 0);
            this.pnlNewHolidayRequest.Controls.Add(this.lblVacationEnd, 0, 1);
            this.pnlNewHolidayRequest.Controls.Add(this.dtpVacationStart, 1, 0);
            this.pnlNewHolidayRequest.Controls.Add(this.chkHalfDayBegin, 2, 0);
            this.pnlNewHolidayRequest.Controls.Add(this.chkHalfDayEnd, 2, 1);
            this.pnlNewHolidayRequest.Controls.Add(this.btnCancelRequest, 0, 4);
            this.pnlNewHolidayRequest.Controls.Add(this.btnSendRequest, 2, 4);
            this.pnlNewHolidayRequest.Controls.Add(this.dtpVacationEnd, 1, 1);
            this.pnlNewHolidayRequest.Controls.Add(this.lblRemainingHolidays, 0, 3);
            this.pnlNewHolidayRequest.Controls.Add(this.label3, 0, 2);
            this.pnlNewHolidayRequest.Controls.Add(this.lblRemainingHolidaysPreview, 1, 3);
            this.pnlNewHolidayRequest.Controls.Add(this.lblRemainingOvertimePreview, 1, 2);
            this.pnlNewHolidayRequest.Controls.Add(this.lblInvalid, 2, 3);
            this.pnlNewHolidayRequest.Controls.Add(this.chkUseOvertime, 2, 2);
            this.pnlNewHolidayRequest.Location = new System.Drawing.Point(0, 0);
            this.pnlNewHolidayRequest.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNewHolidayRequest.Name = "pnlNewHolidayRequest";
            this.pnlNewHolidayRequest.RowCount = 5;
            this.pnlNewHolidayRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.09273F));
            this.pnlNewHolidayRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.58474F));
            this.pnlNewHolidayRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.2317F));
            this.pnlNewHolidayRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.09083F));
            this.pnlNewHolidayRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.pnlNewHolidayRequest.Size = new System.Drawing.Size(385, 200);
            this.pnlNewHolidayRequest.TabIndex = 0;
            // 
            // lblVacationBegin
            // 
            this.lblVacationBegin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVacationBegin.AutoSize = true;
            this.lblVacationBegin.Location = new System.Drawing.Point(3, 7);
            this.lblVacationBegin.Name = "lblVacationBegin";
            this.lblVacationBegin.Size = new System.Drawing.Size(108, 15);
            this.lblVacationBegin.TabIndex = 0;
            this.lblVacationBegin.Text = "Beginn des Urlaubs";
            // 
            // lblVacationEnd
            // 
            this.lblVacationEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVacationEnd.AutoSize = true;
            this.lblVacationEnd.Location = new System.Drawing.Point(3, 36);
            this.lblVacationEnd.Name = "lblVacationEnd";
            this.lblVacationEnd.Size = new System.Drawing.Size(97, 15);
            this.lblVacationEnd.TabIndex = 1;
            this.lblVacationEnd.Text = "Ende des Urlaubs";
            // 
            // dtpVacationStart
            // 
            this.dtpVacationStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpVacationStart.CustomFormat = "MMMM dd, yyyy - dddd";
            this.dtpVacationStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVacationStart.Location = new System.Drawing.Point(184, 3);
            this.dtpVacationStart.Name = "dtpVacationStart";
            this.dtpVacationStart.Size = new System.Drawing.Size(92, 23);
            this.dtpVacationStart.TabIndex = 5;
            this.dtpVacationStart.ValueChanged += new System.EventHandler(this.vacationRangeChanged);
            // 
            // chkHalfDayBegin
            // 
            this.chkHalfDayBegin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkHalfDayBegin.AutoSize = true;
            this.chkHalfDayBegin.Location = new System.Drawing.Point(302, 5);
            this.chkHalfDayBegin.Name = "chkHalfDayBegin";
            this.chkHalfDayBegin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkHalfDayBegin.Size = new System.Drawing.Size(80, 19);
            this.chkHalfDayBegin.TabIndex = 8;
            this.chkHalfDayBegin.Text = "halber Tag";
            this.chkHalfDayBegin.UseVisualStyleBackColor = true;
            this.chkHalfDayBegin.CheckedChanged += new System.EventHandler(this.vacationRangeChanged);
            // 
            // chkHalfDayEnd
            // 
            this.chkHalfDayEnd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkHalfDayEnd.AutoSize = true;
            this.chkHalfDayEnd.Location = new System.Drawing.Point(302, 34);
            this.chkHalfDayEnd.Name = "chkHalfDayEnd";
            this.chkHalfDayEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkHalfDayEnd.Size = new System.Drawing.Size(80, 19);
            this.chkHalfDayEnd.TabIndex = 9;
            this.chkHalfDayEnd.Text = "halber Tag";
            this.chkHalfDayEnd.UseVisualStyleBackColor = true;
            this.chkHalfDayEnd.CheckedChanged += new System.EventHandler(this.vacationRangeChanged);
            // 
            // btnCancelRequest
            // 
            this.btnCancelRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelRequest.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelRequest.Location = new System.Drawing.Point(3, 174);
            this.btnCancelRequest.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.btnCancelRequest.Name = "btnCancelRequest";
            this.btnCancelRequest.Size = new System.Drawing.Size(75, 20);
            this.btnCancelRequest.TabIndex = 3;
            this.btnCancelRequest.Text = "Abbrechen";
            this.btnCancelRequest.UseVisualStyleBackColor = true;
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendRequest.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSendRequest.Location = new System.Drawing.Point(307, 174);
            this.btnSendRequest.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(75, 20);
            this.btnSendRequest.TabIndex = 4;
            this.btnSendRequest.Text = "Absenden";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            // 
            // dtpVacationEnd
            // 
            this.dtpVacationEnd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpVacationEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVacationEnd.Location = new System.Drawing.Point(184, 32);
            this.dtpVacationEnd.Name = "dtpVacationEnd";
            this.dtpVacationEnd.Size = new System.Drawing.Size(92, 23);
            this.dtpVacationEnd.TabIndex = 6;
            this.dtpVacationEnd.ValueChanged += new System.EventHandler(this.vacationRangeChanged);
            // 
            // lblRemainingHolidays
            // 
            this.lblRemainingHolidays.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRemainingHolidays.AutoSize = true;
            this.lblRemainingHolidays.Location = new System.Drawing.Point(3, 93);
            this.lblRemainingHolidays.Name = "lblRemainingHolidays";
            this.lblRemainingHolidays.Size = new System.Drawing.Size(141, 15);
            this.lblRemainingHolidays.TabIndex = 2;
            this.lblRemainingHolidays.Text = "Verbleibende Urlaubstage";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Verbleibende Überstunden";
            // 
            // lblRemainingHolidaysPreview
            // 
            this.lblRemainingHolidaysPreview.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRemainingHolidaysPreview.AutoSize = true;
            this.lblRemainingHolidaysPreview.Location = new System.Drawing.Point(173, 93);
            this.lblRemainingHolidaysPreview.Name = "lblRemainingHolidaysPreview";
            this.lblRemainingHolidaysPreview.Size = new System.Drawing.Size(13, 15);
            this.lblRemainingHolidaysPreview.TabIndex = 7;
            this.lblRemainingHolidaysPreview.Text = "0";
            // 
            // lblRemainingOvertimePreview
            // 
            this.lblRemainingOvertimePreview.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRemainingOvertimePreview.AutoSize = true;
            this.lblRemainingOvertimePreview.Location = new System.Drawing.Point(173, 64);
            this.lblRemainingOvertimePreview.Name = "lblRemainingOvertimePreview";
            this.lblRemainingOvertimePreview.Size = new System.Drawing.Size(13, 15);
            this.lblRemainingOvertimePreview.TabIndex = 12;
            this.lblRemainingOvertimePreview.Text = "0";
            // 
            // lblInvalid
            // 
            this.lblInvalid.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblInvalid.Location = new System.Drawing.Point(329, 93);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(53, 15);
            this.lblInvalid.TabIndex = 10;
            this.lblInvalid.Text = "Ungültig";
            this.lblInvalid.Visible = false;
            // 
            // chkUseOvertime
            // 
            this.chkUseOvertime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkUseOvertime.AutoSize = true;
            this.chkUseOvertime.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkUseOvertime.Location = new System.Drawing.Point(282, 62);
            this.chkUseOvertime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkUseOvertime.Name = "chkUseOvertime";
            this.chkUseOvertime.Size = new System.Drawing.Size(100, 19);
            this.chkUseOvertime.TabIndex = 13;
            this.chkUseOvertime.Text = "Verwenden";
            this.chkUseOvertime.UseVisualStyleBackColor = true;
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
            this.panel1.Controls.Add(this.lvVacationRequests);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 201);
            this.panel1.TabIndex = 1;
            // 
            // lvVacationRequests
            // 
            this.lvVacationRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chVacationBegin,
            this.chVacationEnd,
            this.chVacationState});
            this.lvVacationRequests.Location = new System.Drawing.Point(6, 6);
            this.lvVacationRequests.Name = "lvVacationRequests";
            this.lvVacationRequests.Size = new System.Drawing.Size(353, 168);
            this.lvVacationRequests.TabIndex = 0;
            this.lvVacationRequests.UseCompatibleStateImageBehavior = false;
            this.lvVacationRequests.View = System.Windows.Forms.View.Details;
            // 
            // chVacationBegin
            // 
            this.chVacationBegin.Text = "Beginn";
            this.chVacationBegin.Width = 100;
            // 
            // chVacationEnd
            // 
            this.chVacationEnd.Text = "Ende";
            this.chVacationEnd.Width = 100;
            // 
            // chVacationState
            // 
            this.chVacationState.Text = "Status";
            this.chVacationState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chVacationState.Width = 145;
            // 
            // VacationRequestView
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
            this.Name = "VacationRequestView";
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
        private Label lblVacationBegin;
        private Label lblVacationEnd;
        private Label lblRemainingHolidays;
        private Button btnCancelRequest;
        private Button btnSendRequest;
        private DateTimePicker dtpVacationStart;
        private DateTimePicker dtpVacationEnd;
        private Label lblRemainingHolidaysPreview;
        private CheckBox chkHalfDayBegin;
        private CheckBox chkHalfDayEnd;
        private Label lblInvalid;
        private TabControl tabControlHolidayRequest;
        private TabPage tabNewRequest;
        private TabPage tabViewRequests;
        private ListView lvVacationRequests;
        private ColumnHeader chVacationBegin;
        private ColumnHeader chVacationEnd;
        private ColumnHeader chVacationState;
        private Panel panel1;
        private Label label3;
        private Label lblRemainingOvertimePreview;
        private CheckBox chkUseOvertime;
    }
}