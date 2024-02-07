using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lakeside;
using lakeside.DAL;
using lakeside.Models;

namespace lakeside
{
    public partial class frmCheckOutExperience : Form
    {
        public frmCheckOutExperience()
        {
            InitializeComponent();
        }

        private void cmbDatePickerStayLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnContinue.Enabled = true;
            if(startDate.Year>1)
            {
                endDate = startDate.AddDays(Convert.ToInt32(cmbDatePickerStayLength.Text));
                dtpBookingEnd.Value = endDate;
                Cursor.Current = Cursors.WaitCursor;
                AddBookedPods();
                pnlPodChooser.Visible = true;
                Cursor.Current = Cursors.Default;
                continueStep = 1;
                dgPods.ClearSelection();
            }
        }

        DateTime startDate = new DateTime();
        DateTime endDate = new DateTime();
        int continueStep = 0;
        bool programmaticallyChanged = false;
        private void btnContinue_Click(object sender, EventArgs e)
        {
            if(continueStep==0)
            {
                programmaticallyChanged = true;
                btnContinue.Enabled = false;
                //pnlStayLength.Visible = false;
                //cmbDatePickerStayLength.Enabled = false;
                Lakeside.AnimatePanelSideways(pnlStayLength, new Point(20, 128));
                //pnlStayLength.Location = new Point(20, 128);
                startDate = DateTime.Now.Date.AddDays(-Convert.ToInt32(cmbDatePickerStayLength.Text));
                endDate = DateTime.Now.Date;
                lbDateRange.Visible = true;
                //lbDateRange.Text = ($"{startDate.ToString("ddd d MMM")} - {endDate.ToString("ddd d MMM")}");
                dtpBookingStart.Format = DateTimePickerFormat.Custom;
                // Display the date as "Mon 27 Feb 2012".  
                dtpBookingStart.CustomFormat = "dd MMM";
                dtpBookingStart.Visible = true;
                dtpBookingStart.Value = startDate;
                dtpBookingEnd.Format = DateTimePickerFormat.Custom;
                // Display the date as "Mon 27 Feb 2012".  
                dtpBookingEnd.CustomFormat = "dd MMM";
                dtpBookingEnd.Visible = true;
                dtpBookingEnd.Value = endDate;
                Cursor.Current = Cursors.WaitCursor;
                AddBookedPods();
                pnlPodChooser.Visible = true;
                Cursor.Current = Cursors.Default;
                continueStep = 1;
                dgPods.ClearSelection();
                programmaticallyChanged = false;
            }
            else if (continueStep == 1)
            {
                if (!programmaticallyChanged)
                {
                    startDate = dtpBookingStart.Value;
                    dtpBookingEnd.Value = startDate.AddDays(Convert.ToInt32(cmbDatePickerStayLength.Text));
                    endDate = dtpBookingEnd.Value;
                    Cursor.Current = Cursors.WaitCursor;
                    AddBookedPods();
                    Cursor.Current = Cursors.Default;
                    continueStep = 1;
                    dgPods.ClearSelection();
                }
            }
            else if (continueStep==2)
            {
                pnlPodChooser.Visible = false;
                lbPodName.Text = selectedPod.FriendlyName;
                lbPodName.Visible = true;
                dtpBookingStart.Enabled = false;
                cmbDatePickerStayLength.Enabled = false;
                lbPodName.Text+=TotalCostCalculator();
            }
        }

        private bool AddBookedPods()
        {
            BookingDAL dal = new BookingDAL();
            // Get all available pods and add to data grid view.
            DataTable results = dal.GetBookedPods(startDate, endDate);
            try
            {
                //foreach (DataRow row in results.Rows)
                //{
                //    object value = row["Name"];
                //    if (value == DBNull.Value)
                //        throw new Exception("Empty value!");
                //}
                if (results.Rows.Count == 0)
                    throw new Exception("Empty value!");
                //Set up data grid view
                dgPods.DataSource = results;
                dgPods.Columns["pod_id"].Visible = false;
                dgPods.MultiSelect = false;
                dgPods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgPods.ReadOnly = true;
                pnlPodChooser.Visible = true;
                return true;
            }
            catch(Exception ex)
            {
                //Notification
                MessageBox.Show("No pods have been booked on these dates. \r\nYou can change the selected dates on the left.", "No booked pods", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void frmCheckOutExperience_Load(object sender, EventArgs e)
        {
            
        }

        int podID;
        Pod selectedPod = new Pod();
        private void dgPods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnContinue.Enabled = true;
                continueStep = 2;
                btnContinue.Text = "Continue";

                // Get the first selected row
                DataGridViewRow selectedRow = dgPods.SelectedRows[0];

                // Assuming the pod_id is in the first column (index 0)
                podID = Convert.ToInt32(selectedRow.Cells[0].Value);
                PodDAL podDAL = new PodDAL();

                selectedPod = podDAL.PodLookup(podID);
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was an error selecting that pod! Try again!", "Error Selecting Pod", MessageBoxButtons.OK, MessageBoxIcon.Error);
                selectedPod = null;
            }
        }

        private void dtpBookingStart_ValueChanged(object sender, EventArgs e)
        {
            if (!programmaticallyChanged)
            {
                startDate = dtpBookingStart.Value;
                dtpBookingEnd.Value = startDate.AddDays(Convert.ToInt32(cmbDatePickerStayLength.Text));
                endDate = dtpBookingEnd.Value;
                continueStep = 1;
                dgPods.ClearSelection();
                btnContinue.Text = "Check Dates";
                btnContinue.Enabled = true;
            }
        }

        private void btnBackToHomeOrMainMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel the check out?\r\nNo changes will be saved.", "Confirm Cancellation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Hide();
                new frmHome().Show();
            }
        }

        private double TotalCostCalculator()
        {
            double price = 0.0;
            BookingDAL BookingDAL = new BookingDAL();
            LakesideDAL GuestDAL = new LakesideDAL();
            CourseDAL CourseDAL = new CourseDAL();
            ExtraDAL ExtraDAL = new ExtraDAL();

            //Get Booking
            Booking selectedBooking = BookingDAL.GetBooking(selectedPod, startDate, endDate);
            // Get cost of pod over the number of days, and taking into consideration the number of guests staying in the booking.
            int numberOfGuestsInBooking = BookingDAL.GetNumberOfGuestsInBooking(selectedBooking);
            price += selectedPod.Price * numberOfGuestsInBooking * Convert.ToInt32(cmbDatePickerStayLength.Text);

            // Get Guests from Booking
            List<Guest> selectedGuests = GuestDAL.GetGuestFromBooking(selectedBooking);

            // Add courses
            List<Course> selectedCourses = new List<Course>();
            int i = 0;
            foreach(Guest g in selectedGuests)
            {
                Course GuestCourse = new Course();
                GuestCourse = CourseDAL.GetCoursesFromGuest(selectedBooking, g);
                if(GuestCourse!= new Course())
                {
                    selectedCourses.Add(GuestCourse);
                    price += selectedCourses[i].Price;
                    i++;
                }
            }

            // Add Extras
            List<Extra> selectedExtras = ExtraDAL.GetExtraFromBooking(selectedBooking);
            foreach(Extra e in selectedExtras)
            {
                price += e.Price;
            }

            if(selectedBooking.DiscountPercent>0)
            {
                double percentDiscount = 1-(selectedBooking.DiscountPercent / 100);
                price = price * percentDiscount;
            }
            return price;
        }
    }
}
