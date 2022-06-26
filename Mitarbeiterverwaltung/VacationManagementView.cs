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
    public partial class VacationManagementView : Form
    {
        private HourlyRatedEmployee? employee;
        private HourlyRatedEmployee? supervisor;
        private TimeHandler timeHandler;

        public VacationManagementView(HourlyRatedEmployee? employee, TimeHandler timeHandler)
        {
            InitializeComponent();
            this.employee = employee;
            this.timeHandler = timeHandler;
            dtpVacationStart.MinDate = DateTime.Today;
            dtpVacationEnd.MinDate = DateTime.Today;

            //only allow vac. request when there are no pending requests
            bool vacReqAllowed = employee.vacations.FindAll(d => (d.state == RequestState.pending)).Count == 0;
            if(!vacReqAllowed)
            {
                tabControlHolidayRequest.Controls.Remove(tabNewRequest);
            }
            else
            {
                //no pending request -> show all tabs
            }

            updateLvVacationRequests();
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

            //Datetime values are valid due to automatic range adjustments
            employee.requestVacation(startDate, endDate, chkUseOvertime.Checked);
        }

        /// <summary>
        /// Check if input data are valid and calculate remaining vacation days depending on the state of the checkboxes.
        /// </summary>
        private void vacationRangeChanged(object sender, EventArgs e)
        {
            //update ranges of DateTimePickers
            dtpVacationStart.MaxDate = dtpVacationEnd.Value;
            dtpVacationEnd.MinDate = dtpVacationStart.Value;


            double holidaysCount = 0;
            double remainingHolidays = 0;
            DateTime startDate = dtpVacationStart.Value.Date;
            DateTime endDate = dtpVacationEnd.Value.Date;

            startDate += chkHalfDayBegin.Checked ? new TimeSpan(12, 0, 0) : new TimeSpan(0, 0, 0);
            endDate += chkHalfDayEnd.Checked ? new TimeSpan(12, 0, 0) : new TimeSpan(23, 59, 59);

            bool requestValid = true;

            //check if request is valid
            VacationRequest testRequest = new VacationRequest(
                startDate, 
                endDate, 
                RequestState.pending, 
                chkUseOvertime.Checked);
            TimeSpan overTimeLeft = employee.getOvertime(timeHandler);
            Double vacationHalfDaysLeft = employee.vacationHalfDaysLeft;

            requestValid = employee.calculateVacationRequest(testRequest, ref overTimeLeft, ref vacationHalfDaysLeft);

            lblRemainingHolidaysPreview.Text = (vacationHalfDaysLeft / 2).ToString();
            lblRemainingOvertimePreview.Text = (int)overTimeLeft.TotalHours + overTimeLeft.ToString(@"\:mm");

            if (requestValid)
            {
                
                lblInvalid.Visible = false;
                btnSendRequest.Enabled = true;
            }
            else
            {
                lblInvalid.Visible = true;
                btnSendRequest.Enabled = false;
            }
        }

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
