using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mitarbeiterverwaltung.LL;

namespace Mitarbeiterverwaltung
{
    public partial class HolidayRequestView : Form
    {
        private HourlyRatedEmployee? employee;
        private HourlyRatedEmployee? supervisor;

        public HolidayRequestView(HourlyRatedEmployee? employee)
        {
            InitializeComponent();
            this.employee = employee;
            dtpHolidayStart.MinDate = DateTime.Today;
            dtpHolidayEnd.MinDate = DateTime.Today;
            btnSendRequest.Enabled = false;
            holidayRangeChanged(new object(), new EventArgs());
        }

        public void sendHolidayRequest()
        {
            DateTime startDate = dtpHolidayStart.Value;
            DateTime endDate = dtpHolidayEnd.Value;
            if (endDate > startDate)
            {
                employee.requestHoliday(startDate, endDate);
            }
            else
            {
                throw new Exception("Invalid Date selected");
            }

        }

        private void holidayRangeChanged(object sender, EventArgs e)
        {
            double holidaysCount = 0;
            double remainingHolidays = 0;
            DateTime startDate = dtpHolidayStart.Value.Date;
            DateTime endDate = dtpHolidayEnd.Value.Date;

            startDate += chkHalfDayBegin.Checked ? new TimeSpan(12, 0, 0) : new TimeSpan(0, 0, 0);
            endDate += chkHalfDayEnd.Checked ? new TimeSpan(12, 0, 0) : new TimeSpan(23, 59, 59);

            bool requestValid = true;

            if (endDate < startDate)
            {
                requestValid = false;
                //throw new Exception("Enddate is before Startdate");
            }
            else
            {
                holidaysCount = getBusinessDays(startDate, endDate);
                remainingHolidays = employee.holidays - holidaysCount;
                requestValid = remainingHolidays >= 0;
            }
            
            if (requestValid)
            {
                lblRemainingHolidaysPreview.Text = remainingHolidays.ToString();
                lblRemainingHolidaysPreview.Visible = true;
                lblRemainingHolidays.Visible = true;
                lblInvalid.Visible = false;
                btnSendRequest.Enabled = true;
            }
            else
            {
                lblInvalid.Visible = true;
                lblRemainingHolidaysPreview.Visible = false;
                lblRemainingHolidays.Visible = false;
                btnSendRequest.Enabled = false;
            }
        }

        private void btnCancelRequest_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private double getBusinessDays(DateTime startDay, DateTime endDay)
        {
            // Source: https://alecpojidaev.wordpress.com/2009/10/29/work-days-calculation-with-c/
            // {
            double businessDays =
                1 + ((endDay.Date - startDay.Date).TotalDays * 5 -
                (startDay.DayOfWeek - endDay.DayOfWeek) * 2) / 7;

            if (endDay.DayOfWeek == DayOfWeek.Saturday) businessDays--;
            if (startDay.DayOfWeek == DayOfWeek.Sunday) businessDays--;
            // }

            if (endDay.Hour <= 12) businessDays -= 0.5;
            if (startDay.Hour >= 12) businessDays -= 0.5;

            return Math.Round(businessDays,1);
        }
    }
}
