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
        }

        public void sendHolidayRequest()
        {
            DateTime startTime = dtpHolidayStart.Value;
            DateTime endTime = dtpHolidayEnd.Value;
            if (endTime > startTime)
            {
                employee.requestHoliday(startTime, endTime);
            }
            else
            {
                throw new Exception("Invalid Date selected");
            }

        }

        private void dtpHolidayEnd_ValueChanged(object sender, EventArgs e)
        {
            int holidaysCount;
            int remainingHolidays;
            DateTime startTime = dtpHolidayStart.Value;
            DateTime endTime = dtpHolidayEnd.Value;

            if (endTime < startTime)
            {
                throw new Exception("Enddate is before Startdate");
            }
            holidaysCount = getBusinessDays(startTime, endTime);
            remainingHolidays = employee.holidays - holidaysCount;
            if (remainingHolidays < 0)
            {
                throw new Exception("Timespan exceeds remaining Holidays");
            }
            lblRemainingHolidaysPreview.Text = remainingHolidays.ToString();
            btnSendRequest.Enabled = true;
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

        private int getBusinessDays(DateTime startDay, DateTime endDay)
        {
            double businessDays =
                1 + ((endDay - startDay).TotalDays * 5 -
                (startDay.DayOfWeek - endDay.DayOfWeek) * 2) / 7;

            if (endDay.DayOfWeek == DayOfWeek.Saturday) businessDays--;
            if (startDay.DayOfWeek == DayOfWeek.Sunday) businessDays--;

            return (int)Math.Ceiling(businessDays);
        }
    }
}
