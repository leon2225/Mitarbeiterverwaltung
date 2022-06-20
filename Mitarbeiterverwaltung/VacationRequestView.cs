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
    /// <summary>
    /// Dialog to display previous vacation requests and add a new request with possibility to use overtime as vacationDays.
    /// </summary>
    public partial class VacationRequestView : Form
    {
        private HourlyRatedEmployee? employee;
        private HourlyRatedEmployee? supervisor;

        public VacationRequestView(HourlyRatedEmployee? employee)
        {
            InitializeComponent();
            this.employee = employee;
            dtpVacationStart.MinDate = DateTime.Today;
            dtpVacationEnd.MinDate = DateTime.Today;
            btnSendRequest.Enabled = false;
            vacationRangeChanged(new object(), new EventArgs());
        }

        /// <summary>
        /// Register the selected timespan as vacation request.
        /// </summary>
        /// <exception cref="ErrorException"></exception>
        public void sendVacationRequest()
        {
            DateTime startDate = dtpVacationStart.Value;
            DateTime endDate = dtpVacationEnd.Value;
            if (endDate > startDate)
            {
                employee.requestVacation(startDate, endDate);
            }
            else
            {
                throw new ErrorException("Das gewählte Datum ist ungültig");
                 //TODO unnecessary because of previous check
            }
        }

        /// <summary>
        /// Check if input data are valid and calculate remaining vacation days depending on the state of the checkboxes.
        /// </summary>
        private void vacationRangeChanged(object sender, EventArgs e)
        {
            double holidaysCount = 0;
            double remainingHolidays = 0;
            DateTime startDate = dtpVacationStart.Value.Date;
            DateTime endDate = dtpVacationEnd.Value.Date;

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
                remainingHolidays = employee.vacationDays - holidaysCount;
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

        /// <summary>
        /// Remove all weekends from timespan between start and end day to get working days count.
        /// </summary>
        /// <returns>number of working day between start and end date</returns>
        private double getBusinessDays(DateTime startDay, DateTime endDay) //todo verschieben nach timespan?
        {
            // Source: https://alecpojidaev.wordpress.com/2009/10/29/work-days-calculation-with-c/
            // {
            double businessDays =
                1 + ((endDay.Date - startDay.Date).TotalDays * 5 -
                (startDay.DayOfWeek - endDay.DayOfWeek) * 2) / 7;

            businessDays -= (endDay.DayOfWeek == DayOfWeek.Saturday) ? 1 : 0;
            businessDays -= (startDay.DayOfWeek == DayOfWeek.Sunday) ? 1 : 0;
            // }

            businessDays -= (endDay.Hour <= 12) ? 0.5 : 0;
            businessDays -= (startDay.Hour >= 12) ? 0.5 : 0;

            return Math.Round(businessDays,1);
        }

        //Todo evtl noch rename wegen editEmployee
        /// <summary>
        /// Convert the entries of a <c>VacationRequest</c> to a <c>ListViewItem</c> to display in a ListView.
        /// </summary>
        /// <param name="vacationRequest">VacationRequest containing start Date, end Date and a state.</param>
        /// <returns>ListViewItem to Display in a ListView</returns>
        private ListViewItem vacationRequestToItem(VacationRequest vacationRequest)
        {
            ListViewItem newItem = new ListViewItem(new string[] {
                vacationRequest.startDate.ToString("dd.MM.yyyy"),
                vacationRequest.endDate.ToString("dd.MM.yyyy"),
                vacationRequest.state.ToString()
            });
            return newItem;
        }

        /// <summary>
        /// Clear the ListView for Vacations and add all vacation requests of employee to ListView
        /// </summary>
        private void updateLvVacationRequests()
        {
            lvVacationRequests.Items.Clear();
            for (int i = 0; i < employee.vacations.Count; i++)
            {
                ListViewItem newItem = vacationRequestToItem(employee.vacations[i]);
                newItem.Tag = i;
                lvVacationRequests.Items.Add(newItem);
            }
        }

        /// <summary>
        /// Update the ListViews of the previous vacation requests on every selection.
        /// </summary>
        private void tabControlHolidayRequest_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabViewRequests)
            {
                updateLvVacationRequests();
            }
            else
            {
                //do nothing
            }

        }
    }
}
