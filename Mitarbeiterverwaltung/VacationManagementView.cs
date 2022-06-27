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

            btnRemoveVacation.Enabled = false;

            updateView();
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

            int requestState = 0;

            //check if request is valid
            VacationRequest testRequest = new VacationRequest(
                startDate, 
                endDate, 
                RequestState.pending, 
                chkUseOvertime.Checked);
            TimeSpan overTimeLeft = employee.getOvertime(timeHandler);
            Double vacationHalfDaysLeft = employee.vacationHalfDaysLeft;

            requestState = employee.calculateVacationRequest(testRequest, ref overTimeLeft, ref vacationHalfDaysLeft);

            lblRemainingHolidaysPreview.Text = (vacationHalfDaysLeft / 2).ToString();
            lblRemainingOvertimePreview.Text = (int)overTimeLeft.TotalHours + overTimeLeft.ToString(@"\:mm");

            if (requestState == 0)
            {
                
                lblInvalid.Visible = false;
                btnSendRequest.Enabled = true;
            }
            else
            {
                lblInvalid.Visible = true;
                switch (requestState)
                {
                    case 1:
                        lblInvalid.Text = "Nicht genügend Urlaubstage/ Überstunden";
                        break;
                   case 2:
                        lblInvalid.Text = "Überschneidung mit Krankheitstag";
                        break;
                    default:
                        lblInvalid.Text = "Anderer Fehler";
                        break;
                }  
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
                vacationRequest.state.GetName(),
            });
            return newItem;
        }

        /// <summary>
        /// Clear the ListView for Vacations and add all vacation requests of employee to ListView
        /// It also updates the rest of the View
        /// </summary>
        private void updateView()
        {
            lvVacationRequests.Items.Clear();
            for (int i = 0; i < employee.vacations.Count; i++)
            {
                ListViewItem newItem = vacationRequestToItem(employee.vacations[i]);
                newItem.Tag = i;
                lvVacationRequests.Items.Add(newItem);
            }

            //only allow vac. request when there are no pending requests
            bool vacReqAllowed = employee.vacations.FindAll(d => (d.state == RequestState.pending)).Count == 0;
            ((Control)tabNewRequest).Enabled = vacReqAllowed;
        }

        /// <summary>
        /// Update the ListViews of the previous vacation requests on every selection.
        /// </summary>
        private void tabControlHolidayRequest_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabViewRequests)
            {
                updateView();
            }
            else
            {
                //do nothing
            }

        }

        private void lvVacationRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enableState = lvVacationRequests.SelectedItems.Count > 0;
            if(enableState)
            {
                //Only pending vacations-requests may be removed
                btnRemoveVacation.Enabled = employee.vacations[lvVacationRequests.SelectedIndices[0]].state == RequestState.pending;
            }
            else
            {
                //Change event was fired, but no item selected -> do nothing
            }
        }

        private void btnRemoveVacation_Click(object sender, EventArgs e)
        {
            int selectedIndex = lvVacationRequests.SelectedIndices[0];
            employee.vacations.RemoveAt(selectedIndex);
            updateView();
        }
    }
}
