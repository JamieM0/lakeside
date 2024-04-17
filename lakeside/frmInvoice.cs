using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lakeside.DAL;
using lakeside.Models;

namespace lakeside
{
    public partial class frmInvoice : Form
    {
        Invoice invoice = new Invoice();
        bool[] allValid = new bool[4];
        bool depositMode=false;
        public frmInvoice(Invoice Invoice)
        {
            invoice = Invoice;
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            InitializeComponent();
            CenterToScreen();
        }
        public frmInvoice(Invoice Invoice, bool DepositMode)
        {
            invoice = Invoice;
            depositMode = DepositMode;
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            InitializeComponent();
            CenterToScreen();
            lbTitle.Text = "Welcome to Lakeside Escapes";
            lbInfoPodName.Text = "Pod staying in";
        }

        public void CenterControlToFormHorizontally(Control control)
        { 
          // Check if the control and its parent form are not null
          
          if (control != null && control.Parent != null) 
          {
                // Get the width of the control and its parent form
                int controlWidth = control.Width; 
                int formWidth = control.Parent.Width;

                // Calculate the left position of the control to center it horizontally
                int left = (formWidth - controlWidth) / 2;

                // Set the left property of the control
                control.Left = left;
            }
        }

        private void lbInfoPodName_TextChanged(object sender, EventArgs e)
        {
            CenterControlToFormHorizontally(lbInfoPodName);
        }

        private void lbPodName_TextChanged(object sender, EventArgs e)
        {
            CenterControlToFormHorizontally(lbPodName);
        }

        private void PopulateDatagrids()
        {
            // Assuming you have a class called Course with a property called Type and a list of courses called coursesSelected
            // Create a dictionary to store the counts of each course type
            Dictionary<string, int> courseTypeCounts = new Dictionary<string, int>();

            // Loop through the list of courses
            foreach (Course course in invoice.coursesSelected)
            {
                // Get the course type
                string courseType = course.CourseName;

                // Check if the dictionary already contains the course type
                if (courseTypeCounts.ContainsKey(courseType))
                {
                    // Increment the count by one
                    courseTypeCounts[courseType]++;
                }
                else
                {
                    // Add the course type to the dictionary with a count of one
                    courseTypeCounts.Add(courseType, 1);
                }
            }

            // Print the results
            foreach (KeyValuePair<string, int> pair in courseTypeCounts)
            {
                //Console.WriteLine($"There are {pair.Value} courses of type {pair.Key}");
                Course currentCourse=new Course();
                foreach(Course course in invoice.coursesSelected)
                {
                    if(course.CourseName==pair.Key)
                    {
                        currentCourse = course;
                    }
                }
                if(pair.Key!="")
                {
                    dgCourseSelected.Rows.Add(pair.Value, pair.Key, currentCourse.Price, currentCourse.Price * pair.Value);
                }
            }

            //Populate Course Datagrid
            //for (int i=0; i<invoice.coursesSelected.Count;i++)
            //{
            //    dgCourseSelected.Rows.Add(invoice.coursesSelected[i].CourseName);
            //}
        }

        private void SetLabels()
        {
            lbDate.Text = invoice.booking.CheckInDate.ToString("ddd d MMM") + " - " + invoice.booking.CheckOutDate.ToString("ddd d MMM");
            lbPodName.Text = invoice.bookedPod.FriendlyName;
            lbLeadGuestName.Text = invoice.leadGuest.Forename + " " + invoice.leadGuest.Surname;
        }

        double totalDue = 0.0;
        private void frmInvoice_Load(object sender, EventArgs e)
        {
            dgCourseSelected.Font = new Font("Segoe UI", 12);
            dgExtraSelected.Font = new Font("Segoe UI", 12);
            int allCourseCount = 0;
            int allExtraCount = 0;
            foreach(Course course in invoice.coursesSelected)
            {
                if (course.CourseName != new Course().CourseName)
                    allCourseCount++;
            }
            foreach(Extra extra in invoice.extrasSelected)
            {
                if (extra.ExtraName != new Extra().ExtraName)
                    allExtraCount++;
            }
            
            switch(allCourseCount)
            {
                case 0: lbInfoCourseSelected.Text = "No courses selected.";
                    dgCourseSelected.Visible = false;
                    lbInfoExtraSelected.Location = new Point(12, 137);
                    dgExtraSelected.Location = new Point(16, 161);
                    break;
                case 1: lbInfoCourseSelected.Text = "Course Selected";
                    dgCourseSelected.Visible = true;
                    break;
                default: lbInfoCourseSelected.Text = "Courses Selected";
                    dgCourseSelected.Visible = true;
                    break;
            }
            switch (allExtraCount)
            {
                case 0:
                    lbInfoExtraSelected.Text = "No extras selected.";
                    dgExtraSelected.Visible = false;
                    break;
                case 1:
                    lbInfoExtraSelected.Text = "Extra Selected";
                    dgExtraSelected.Visible = true;
                    break;
                default:
                    lbInfoExtraSelected.Text = "Extras Selected";
                    dgExtraSelected.Visible = true;
                    break;
            }

            BookingDAL BookingDAL = new BookingDAL();
            int numberOfGuestsInBooking = BookingDAL.GetNumberOfGuestsInBooking(invoice.booking);
            lbPodCalculationsPodName.Text = $"{invoice.bookedPod.FriendlyName} \r\n@ £{invoice.bookedPod.Price} per guest per night";
            lbPodCalculationsGuestCount.Text = $"x {numberOfGuestsInBooking} Guests";
            lbPodCalculationsNightStayingCount.Text = $"x {(invoice.booking.CheckOutDate - invoice.booking.CheckInDate).TotalDays} Nights";
            double podPrice = invoice.bookedPod.Price * numberOfGuestsInBooking * (invoice.booking.CheckOutDate - invoice.booking.CheckInDate).TotalDays;
            lbPodCalculationsPrice.Text = $"£{podPrice} for {invoice.bookedPod.FriendlyName}";

            CenterControlToFormHorizontally(lbTitle);
            CenterControlToFormHorizontally(lbPodName);
            CenterControlToFormHorizontally(lbInfoPodName);
            CenterControlToFormHorizontally(pnlPodNames);

            PopulateDatagrids();
            SetLabels();

            double totalPrice = podPrice + TotalCoursePrice() + TotalExtraPrice();
            lbSubtotal.Text = "£" + totalPrice;

            int discount = CalculateDiscount();
            double discountApplied = 100 - discount;
            double discountApplied2 = discountApplied / 100;
            double totalPriceWithDiscounts = Math.Round(totalPrice * discountApplied2,2);
            if(depositMode!=true)
                lbTotalPrice.Text = "Total Price: £" + (totalPriceWithDiscounts / 2).ToString("N2");
            else
                lbTotalPrice.Text = "Deposit Due: £" + (totalPriceWithDiscounts / 2).ToString("N2");
            totalDue = totalPriceWithDiscounts / 2;
            txtNameOnCard.Text = invoice.leadGuest.Forename + " " + invoice.leadGuest.Surname;
            dtpCardDate.Value = DateTime.Now.AddDays(1);
        }

        private int CalculateDiscount()
        {
            int discount = 0;
            if (invoice.booking.PreviousGuests)
            {
                discount += 2;
                cbReturningGuest.Checked = true;
                lbInfoReturningGuest.Visible = true;
            }
            int monthsBookedDifference = Convert.ToInt32((invoice.booking.CheckInDate - invoice.booking.DateBooked).TotalDays);
            if (monthsBookedDifference <= 6)
            {
                discount += 3;
                cbBookedEarly.Checked = true;
                lbInfoBookedEarly.Visible = true;
            }
            return discount;
        }

        private double TotalCoursePrice()
        {
            double price = 0.0;
            foreach (DataGridViewRow row in dgCourseSelected.Rows)
            {
                if (row.Cells[3].Value!=null)
                {
                    price += Double.Parse(row.Cells[3].Value.ToString());
                }
            }
            return price;
        }
        private double TotalExtraPrice()
        {
            double price = 0.0;
            foreach(DataGridViewRow row in dgExtraSelected.Rows)
            {
                if(row.Cells[3].Value!=null)
                {
                    price += Double.Parse(row.Cells[3].Value.ToString());
                }
            }
            return price;
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            btnMakePayment.Enabled = false;
            pnlPaymentWindow.Visible = true;
        }

        private void ValidSetter(int elementID)
        {
            Control changeColour = null;
            Label errorDisplay = null;
            string msg = null;
            switch (elementID)
            {
                case 0:
                    changeColour = txtCardNumber;
                    errorDisplay = lbCardNumberError;
                    msg = Validation.RequiredLength(txtCardNumber.Text, 16, "Card Number");
                    break;
                case 1:
                    changeColour = txtNameOnCard;
                    errorDisplay = lbNameOnCardError;
                    msg = Validation.Name(txtNameOnCard.Text);
                    break;
                case 2:
                    changeColour = txtCVV;
                    errorDisplay = lbCVVError;
                    msg = Validation.RequiredLength(txtCVV.Text, 3, "CVV");
                    break;
                case 3:
                    changeColour = dtpCardDate;
                    errorDisplay = lbCardDateError;
                    msg = Validation.DateCheckOverCurrent(dtpCardDate.Value, "Card Expiry Date");
                    break;
            }
            if (msg == null)
                Validator(elementID, changeColour, errorDisplay, msg);
            else
                Invalidator(elementID, changeColour, errorDisplay, msg);
        }
        private void Invalidator(int elementID, Control changeColour, Label errorDisplay, string msg)
        {
            changeColour.BackColor = Color.LightCoral;
            errorDisplay.Text = msg;
            allValid[elementID] = false;
        }
        private void Validator(int elementID, Control changeColour, Label errorDisplay, string msg)
        {
            changeColour.BackColor = Color.White;
            errorDisplay.Text = "";
            allValid[elementID] = true;
        }
        bool validTotal = true;
        private bool CheckValidation()
        {
            foreach (bool validTest in allValid)
            {
                if (!validTest)
                    validTotal = false;
            }
            return validTotal;
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckValidation())
                {
                    Payment payment = new Payment(invoice.booking.BookingID,totalDue,"Payment Card",DateTime.Now.Date);

                    PaymentDAL dal = new PaymentDAL();

                    if (dal.MakePayment(payment))
                    {
                        MessageBox.Show("Payment made successfully!");
                        if (depositMode == true)
                        {
                            BookingDAL bookingDAL = new BookingDAL();
                            bookingDAL.ConvertToFullBooking(invoice.booking);
                        }

                        Hide();
                        new frmHome().Show();
                    }
                }
                else
                {
                    MessageBox.Show("There are errors in the form! Please correct them.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validTotal = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error making the payment!\r\nMore Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(0);
        }

        private void txtNameOnCard_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(1);
        }

        private void txtCVV_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(2);
        }

        private void dtpCardDate_ValueChanged(object sender, EventArgs e)
        {
            ValidSetter(3);
        }

        private void txtCardNumber_Leave(object sender, EventArgs e)
        {
            ValidSetter(0);
        }

        private void txtNameOnCard_Leave(object sender, EventArgs e)
        {
            ValidSetter(1);
        }

        private void txtCVV_Leave(object sender, EventArgs e)
        {
            ValidSetter(2);
        }

        private void dtpCardDate_Leave(object sender, EventArgs e)
        {
            ValidSetter(3);
        }
    }
}
