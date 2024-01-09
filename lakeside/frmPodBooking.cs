using lakeside.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lakeside.Models;

namespace lakeside
{
    public partial class frmPodBooking : Form
    {
        DateTime current = DateTime.Now.Date;
        DayOfWeek firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).DayOfWeek;

        DateTime proposedStartDate = new DateTime();
        DateTime proposedEndDate = new DateTime();
        DateTime StartDate = new DateTime();
        DateTime EndDate = new DateTime();

        Panel pnlCalBase;
        Panel[] dayPanels;

        bool formLoaded = false;
        int guestsStaying = 1;
        int staffID = 1;
        int selectedPodID=0;
        int podID = 0;
        PodDAL pDAL = new PodDAL();
        Pod selectedPod = new Pod();

        List<Guest> selectedGuests = new List<Guest>();
        Guest currentlySelectedGuest = new Guest();
        int currentIterationThroughGuests = 0;

        public frmPodBooking()
        {
            InitializeComponent();
            CenterToScreen();
            cmbDatePickerStayLength.SelectedIndex = 0;
            lbDateRange.Visible = false;
            InitialiseCalendar();
            pnlDatePicker.Visible = true;
            pnlDatePicker.BringToFront();
            this.Text = "Lakeside Escapes: Make a Booking";
        }

        private void InitialiseCalendar()
        {
            pnlCalBase = new Panel { Size = new Size(416, 307) };
            pnlCalContainer.Controls.Add(pnlCalBase);

            dayPanels = new Panel[7];
            for (int i = 6; i >= 0; i--)
            {
                dayPanels[i] = new Panel { Location = new Point(0 + i * pnlCalBase.Width / 7, 0), Width = pnlCalBase.Width / 7, Height = pnlCalBase.Height };
                pnlCalBase.Controls.Add(dayPanels[i]);
            }

            DisplayCurrentMonth(DateTime.Now);
        }

        private void DisplayCurrentMonth(DateTime currentDate)
        {
            //DateTime currentDate = DateTime.Now;
            current = currentDate;
            foreach (Panel day in dayPanels)
            {
                day.Controls.Clear();
            }

            //Place lbMonthName in the middle of pnlCalOutside
            lbMonthName.Text = currentDate.ToString("MMMM yyyy");
            lbMonthName.Location = new Point((pnlCalOutside.Width - lbMonthName.Width) / 2, lbMonthName.Location.Y);
            lbMonthName.TextAlign = ContentAlignment.MiddleCenter;

            int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            int firstDayOfWeek = ((int)firstDayOfMonth.DayOfWeek + 6) % 7; // Monday = 0, Sunday = 6

            // Add empty labels for the days before the first day of the month
            for (int i = 0; i < firstDayOfWeek; i++)
            {
                Label emptyLabel = new Label
                {
                    AutoSize = true,
                    Location = new Point(3, dayPanels[i].Controls.Count * 40),
                    Font = new Font("Segoe UI", 16, FontStyle.Bold),
                    Margin = new Padding(0, 0, 0, 15) // Add a bottom margin
                };
                emptyLabel.Click += new EventHandler(DateDisplay_Click);

                dayPanels[i].Controls.Add(emptyLabel);
            }

            for (int day = 1; day <= daysInMonth; day++)
            {
                DateTime currentDay = new DateTime(currentDate.Year, currentDate.Month, day);
                int dayOfWeek = ((int)currentDay.DayOfWeek + 6) % 7; // Monday = 0, Sunday = 6

                Label dayLabel = new Label
                {
                    Text = day.ToString(),
                    AutoSize = true,
                    Location = new Point(3, dayPanels[dayOfWeek].Controls.Count * 40),
                    Font = new Font("Segoe UI", 16, FontStyle.Bold),
                    Name = "day_" + day.ToString(),
                    Margin = new Padding(0, 0, 0, 15) // Add a bottom margin
                };
                dayLabel.Click += new EventHandler(DateDisplay_Click);

                dayPanels[dayOfWeek].Controls.Add(dayLabel);
            }

            formLoaded = true;
        }

        bool newDate = true;
        private void DateDisplay_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            newDate = true;
            Label dateDisplay = (Label)sender;
            proposedStartDate = new DateTime(current.Year, current.Month, Convert.ToInt32(dateDisplay.Text));
            proposedEndDate = proposedStartDate.AddDays(Convert.ToInt32(cmbDatePickerStayLength.SelectedItem.ToString()));

            if (Validation.BookingStartDate(proposedStartDate) == null)
            {
                SelectDate(dateDisplay);
                
                HighlightStayPeriod();
            }
            else
            {
                //Invalid Start Date
                MessageBox.Show(Validation.BookingStartDate(proposedStartDate), "Invalid Start Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                proposedStartDate = new DateTime();
                proposedEndDate = new DateTime();
            }
        }

        private void HighlightStayPeriod()
        {
            lbDateRange.Visible = true;
            lbDateRange.Text = proposedStartDate.ToString("dd MMM") + " - " + proposedEndDate.ToString("dd MMM");

            foreach (Panel day in dayPanels)
            {
                foreach (Control c in day.Controls)
                {
                    if (c is PictureBox)
                    {
                        day.Controls.Remove(c);
                    }
                    if (c is Label)
                    {
                        Label lb = (Label)c;
                        lb.Image = null;
                        lb.ForeColor = Color.Black;
                    }
                }
            }

            if (proposedEndDate.Month == proposedStartDate.Month)
            {
                Label endDateDisplay = pnlCalBase.Controls.Find("day_" + proposedEndDate.Day, true).FirstOrDefault() as Label;
                pnlOverflow.Visible = false;
                lbOverflow.Visible = false;

                newDate = false;
                SelectDate(endDateDisplay);

                //Get all dates between start and end
                for (int i = proposedStartDate.Day; i < proposedEndDate.Day+1; i++)
                {
                    SelectDate(pnlCalBase.Controls.Find("day_" + i, true).FirstOrDefault() as Label);
                }
            }
            else
            {
                // Selected period goes over 2 months.

                //Step 1: Select all dates in beginning month
                int endOfMonth = (DateTime.DaysInMonth(proposedStartDate.Year, proposedStartDate.Month));
                Label endDateDisplay = pnlCalBase.Controls.Find("day_" + endOfMonth, true).FirstOrDefault() as Label;
                newDate = false;
                SelectDate(endDateDisplay);

                //Get all dates between start and end
                for(int i = proposedStartDate.Day; i<endOfMonth; i++)
                {
                    SelectDate(pnlCalBase.Controls.Find("day_" + i, true).FirstOrDefault() as Label);
                }


                //Step 2: Display an arrow coming from the end date in the beginning month, going off to the right side of the calendar,
                //to another selected date "display", this will have on it, the end date of the entire booking.
                //Graphics g = pnlCalContainer.CreateGraphics();
                //Pen linePen = new Pen(Color.FromArgb(139, 201, 187), 3);
                //Point p1 = new Point(endDateDisplay.Location.X/* + TextRenderer.MeasureText(endDateDisplay.Text, endDateDisplay.Font).Width*/, endDateDisplay.Location.Y/* + TextRenderer.MeasureText(endDateDisplay.Text, endDateDisplay.Font).Height / 2*/);
                //Point p2 = new Point(415, 202);
                //linePen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                //g.DrawLine(linePen, p1, p2);
                pnlOverflow.Visible = true;
                lbOverflow.Visible = true;
                lbOverflow.Text = proposedEndDate.ToString("dd") + "\n" + proposedEndDate.ToString("MM");

                //Step 3: When the next month button is clicked, the date select should continue to the end date, and the previous screen should be retained
                //when the previous month button is clicked.
            }
        }

        private void SelectDate(Label dateDisplay)
        {
            //Go through all panels in dayPanels and remove all PictureBoxes
            if(newDate)
            {
                foreach (Panel day in dayPanels)
                {
                    foreach (Control c in day.Controls)
                    {
                        if (c is PictureBox)
                        {
                            day.Controls.Remove(c);
                        }
                        if (c is Label)
                        {
                            Label lb = (Label)c;
                            lb.Image = null;
                            lb.ForeColor = Color.Black;
                        }
                    }
                }
            }
            
            dateDisplay.ForeColor = Color.White;
            dateDisplay.BringToFront();

            Panel containerPanel = (Panel)dateDisplay.Parent;
            containerPanel.BringToFront();

            dateDisplay.Image = Properties.Resources.dateSelector;

            PictureBox pbSelector = new PictureBox();
            pbSelector.Size = new Size(47, 47);
            pbSelector.BackColor = Color.Transparent;
            pbSelector.Image = Properties.Resources.dateSelector;
            pbSelector.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSelector.Location = new Point(dateDisplay.Location.X - 4, dateDisplay.Location.Y - 9);
            containerPanel.Controls.Add(pbSelector);
            //pbSelector.BringToFront();
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            if(proposedStartDate!=new DateTime())
            {
                if (MessageBox.Show("Moving to the next month will clear your selection.\nAre you sure you want to do this?", "Next Month", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HighlightStayPeriod();
                    DisplayCurrentMonth(current.AddMonths(1));
                    proposedStartDate = new DateTime();
                    proposedEndDate = new DateTime();
                    lbDateRange.Visible = false;
                    pnlOverflow.Visible = false;
                }
            }
            else
            {
                HighlightStayPeriod();
                DisplayCurrentMonth(current.AddMonths(1));
                proposedStartDate = new DateTime();
                proposedEndDate = new DateTime();
                lbDateRange.Visible = false;
                pnlOverflow.Visible = false;
            }
        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            if(proposedStartDate!=new DateTime())
            {
                if (MessageBox.Show("Moving to the previous month will clear your selection.\nAre you sure you want to do this?", "Previous Month", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //HighlightStayPeriod();
                    DisplayCurrentMonth(current.AddMonths(-1));
                    proposedStartDate = new DateTime();
                    proposedEndDate = new DateTime();
                    lbDateRange.Visible = false;
                    pnlOverflow.Visible = false;
                }
            }
            else
            {
                //HighlightStayPeriod();
                DisplayCurrentMonth(current.AddMonths(-1));
                proposedStartDate = new DateTime();
                proposedEndDate = new DateTime();
                lbDateRange.Visible = false;
                pnlOverflow.Visible = false;
            }
        }

        private void frmPodBooking_Load(object sender, EventArgs e)
        {
            lbDebugInfo.Visible = Lakeside.debug;
            if(Lakeside.debug)
            {
                foreach (Control c in this.Controls)
                {
                    c.MouseEnter += new EventHandler(Control_DebugUpdate);
                }
            }
        }
        private void Control_DebugUpdate(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null)
            {
                // Update your label here
                lbDebugInfo.Text = "Debug Info (Hovering Over): " + control.Name;
            }
        }

        private void cmbDatePickerStayLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formLoaded&&proposedStartDate!=new DateTime())
            {
                proposedEndDate = proposedStartDate.AddDays(Convert.ToInt32(cmbDatePickerStayLength.SelectedItem.ToString()));
                HighlightStayPeriod();
                HighlightStayPeriod();
            }
        }

        private bool AddAvailablePods()
        {
            BookingDAL dal = new BookingDAL();
            // Get all available pods and add to data grid view.
            DataTable results = dal.GetAvailablePods(proposedStartDate, proposedEndDate);
            if(results!=null)
            {
                //Set up data grid view
                dgAvailablePods.DataSource = results;
                dgAvailablePods.Columns["pod_id"].Visible = false;
                dgAvailablePods.MultiSelect = false;
                dgAvailablePods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgAvailablePods.ReadOnly = true;
                return true;
            }
            else
            {
                //Notification
                MessageBox.Show("No available pods for the selected dates", "No available pods", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void btnSelectDates_Click(object sender, EventArgs e)
        {
            pnlLocationDateDisplay.Visible = false;
            pnlGuestDisplay.Visible = false;
            pnlGuests.Visible = false;
            //Change cursor to loading cursor
            Cursor.Current = Cursors.WaitCursor;
            if(AddAvailablePods())
            {
                pnlDatePicker.Visible = false;
                Cursor.Current = Cursors.Default;
                dgAvailablePods.Visible = true;
                lbTitle.Text = "Select a Pod";
                btnConfirmPod.Visible = true;
            }
            else
            {
                Cursor.Current = Cursors.Default;
                //MessageBox.Show("There are no pods available on the dates selected!");
                lbTitle.Text = "Check Availability";
            }
            
        }
        //private void ChangeTitleText(string newText)
        //{
        //    lbTitle.Text = newText;
        //}
        private void btnDatePickerOpenerSelector_Click(object sender, EventArgs e)
        {
            pnlDatePicker.Visible = true;
            pnlDatePicker.BringToFront();
        }

        private void btnConfirmPod_Click(object sender, EventArgs e)
        {
            ConfirmPod();
        }
        private void ConfirmPod()
        {
            StartDate = proposedStartDate;
            EndDate = proposedEndDate;
            //Booking booking = new Booking("Provisional", StartDate, EndDate, DateTime.Now, guestsStaying, 0.0M, DateTime.Now, staffID, podID);
            //BookingDAL dal = new BookingDAL();
            //if (dal.AddNewBooking(booking))
            //{
            //MessageBox.Show("Booking added successfully!","Booking Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            selectedPod = pDAL.PodLookup(podID);
            dgAvailablePods.Visible = false;
            btnConfirmPod.Visible = false;
            btnDatePickerOpenerSelector.Visible = false;
            pnlLocationDateDisplay.Visible = true;
            lbDateDisplay.Text = $"{StartDate.ToString("dd MMM")} -> {EndDate.ToString("dd MMM")}";
            lbLocationDisplay.Text = selectedPod.FriendlyName/* + " (Capacity: " + selectedPod.Capacity + ")"*/;
            //}

            pnlGuests.Visible = true;
            lbTitle.Text = "Select Guests Staying";
        }

        private void dgAvailablePods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnConfirmPod.Enabled = true;
            btnConfirmPod.Visible = true;
            btnConfirmPod.BringToFront();
            // Get the first selected row
            DataGridViewRow selectedRow = dgAvailablePods.SelectedRows[0];

            // Assuming the pod_id is in the first column (index 0)
            podID = Convert.ToInt32(selectedRow.Cells[0].Value);
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            btnRandomiseData.Enabled = false;
            tmrTick.Start();
            new frmAddGuest(true).Show();
        }
        public void AddNewGuest()
        {
            if (!selectedGuests.Contains(Lakeside.currentlySelectedGuest))
            {
                selectedGuests.Add(Lakeside.currentlySelectedGuest);
                btnAcceptGuests.Enabled = true;
                if (selectedGuests.Count >= selectedPod.Capacity)
                {
                    btnAddGuest.Enabled = false;
                    btnSelectGuests.Enabled = false;
                }
                addGuests();
            }
            else
            {
                //Notify
                MessageBox.Show("This guest is already selected!","Guest already selected!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnSelectGuests_Click(object sender, EventArgs e)
        {
            btnRandomiseData.Enabled = false;
            tmrTick.Start();
            new frmSearchGuests(true).Show();
        }

        private void addGuests()
        {
            pnlGuestSelectionActionGroup.Location = new Point(329, 31);
            int i = 0;
            pnlGuestPicker.Location = new Point(12, 50);
            foreach(Control c in pnlGuests.Controls)
            {
                if(c.GetType() == typeof(Panel) && c.Name[4]=='A')
                {
                    pnlGuests.Controls.Remove(c);
                }
            }

            foreach(Guest g in selectedGuests)
            {
                pnlGuestPicker.Location = new Point(pnlGuestPicker.Location.X, pnlGuestPicker.Location.Y + 45);
                Panel pnl = new Panel();
                pnl.Size = new Size(308, 40);
                pnl.Location = new Point(12, 45*(i+1));
                //pnl.BackColor = Color.LightBlue;
                pnl.Name = $"pnlGA_" + i;
                pnlGuests.Controls.Add(pnl);

                Label lb = new Label();
                lb.Font = new Font("Segoe UI", 14);
                lb.Text = g.Forename + " " + g.Surname;
                lb.Location = new Point(3, 8);
                lb.AutoSize = true;
                pnl.Controls.Add(lb);

                Button btn = new Button();
                btn.Font = new Font("Segoe UI", 14);
                btn.Text = "X";
                btn.Location = new Point(267, 5);
                btn.Size = new Size(35, 35);
                btn.Click += new EventHandler(removeGuestFromBooking);
                btn.Name = "btnGuest_" + g.GuestID;
                pnl.Controls.Add(btn);
                i++;
            }

            if (Lakeside.debug)
            {
                foreach (Control c in pnlGuests.Controls)
                {
                    c.MouseEnter += new EventHandler(Control_DebugUpdate);
                }
            }
        }

        private void removeGuestFromBooking(object sender, EventArgs e)
        {
            Button removeButton = (Button)sender;
            int removeID = Convert.ToInt32(removeButton.Name.Split('_')[1]);
            LakesideDAL guestDAL = new LakesideDAL();
            Guest toRemove = guestDAL.GuestLookup(removeID);
            selectedGuests.Remove(toRemove);
            if (selectedGuests.Count < selectedPod.Capacity)
            {
                btnAddGuest.Enabled = true;
                btnSelectGuests.Enabled = true;
            }
            addGuests();
        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            if(Lakeside.currentlySelectedGuest.Forename!="")
            {
                tmrTick.Stop();
                AddNewGuest();
                Lakeside.currentlySelectedGuest = new Guest();
            }
        }

        bool[] validCourses;
        int[] selectedCourseID;
        private void btnAcceptGuests_Click(object sender, EventArgs e)
        {
            if(selectedGuests.Count==0)
            {
                //Notfy
                MessageBox.Show("Please select at least one guest", "No guests selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(selectedGuests.Count<=selectedPod.Capacity)
            {
                pnlGuests.Visible = false;
                pnlGuestDisplay.Visible = true;
                //string guestDisplay = "";
                lbGuestDisplay.ForeColor = Color.Black;
                lbGuestDisplay2.ForeColor = Color.Black;
                lbGuestDisplay3.ForeColor = Color.Black;
                lbGuestDisplay4.ForeColor = Color.Black;
                //lbGuestDisplay.Visible = false;
                lbGuestDisplay2.Visible = false;
                lbGuestDisplay3.Visible = false;
                lbGuestDisplay4.Visible = false;
                lbGuestDisplay.Text = selectedGuests[0].Forename + " " + selectedGuests[0].Surname;
                //btnContinueFromCourseSelection.Location = new Point(12, lbGuestDisplay2.Location.Y);
                if (selectedGuests.Count>1)
                {
                    lbGuestDisplay2.Visible = true;
                    lbGuestDisplay2.Text = selectedGuests[1].Forename + " " + selectedGuests[1].Surname;
                    //btnContinueFromCourseSelection.Location = new Point(12, lbGuestDisplay3.Location.Y);
                }
                if (selectedGuests.Count > 2)
                {
                    lbGuestDisplay3.Visible = true;
                    lbGuestDisplay3.Text = selectedGuests[2].Forename + " " + selectedGuests[2].Surname;
                    //btnContinueFromCourseSelection.Location = new Point(12, lbGuestDisplay4.Location.Y);
                }
                if (selectedGuests.Count > 3)
                {
                    lbGuestDisplay4.Visible = true;
                    lbGuestDisplay4.Text = selectedGuests[3].Forename + " " + selectedGuests[3].Surname;
                    //btnContinueFromCourseSelection.Location = new Point(12, lbGuestDisplay5.Location.Y);
                }
                if (selectedGuests.Count > 4)
                {
                    lbGuestDisplay5.Visible = true;
                    lbGuestDisplay5.Text = selectedGuests[4].Forename + " " + selectedGuests[4].Surname;
                    //btnContinueFromCourseSelection.Location = new Point(12, lbGuestDisplay6.Location.Y);
                }
                if (selectedGuests.Count > 5)
                {
                    lbGuestDisplay6.Visible = true;
                    lbGuestDisplay6.Text = selectedGuests[5].Forename + " " + selectedGuests[5].Surname;
                }
                //for (int i = 1; i < selectedGuests.Count; i++)
                //{
                //    Label guestDisplay = pnlGuestDisplay.Controls.Find("lbGuestDisplay" + i, true).FirstOrDefault() as Label;
                //    guestDisplay.Text = selectedGuests[i].Forename + " " + selectedGuests[i].Surname + "\r\n";
                //}
                //lbGuestDisplay.Text = guestDisplay;
                lbTitle.Text = "Choose Courses if Applicable";
                pnlCourses.Visible = true;
                lbGuestDisplay.ForeColor = Color.MediumBlue;
                lbGuestCoursePickerTitle.Text = $"Choose a course for {selectedGuests[0].Forename}, or skip.";
                btnSkipCourseSelection.Text = $"Skip Course Selection for {selectedGuests[0].Forename}";
                AddAvailableCourses();
                validCourses = new bool[selectedGuests.Count];
                selectedCourseID = new int[selectedGuests.Count];
            }
            else
            {
                //Notify
                MessageBox.Show("Too many guests selected! " + selectedPod.FriendlyName + " onlt supports a maximum of " + selectedPod.Capacity + " people!");
            }
        }

        private bool AddAvailableCourses()
        {
            CourseDAL dal = new CourseDAL();
            // Get all available courses and add to data grid view.
            DataTable results = dal.GetAvailableCourses(proposedStartDate, proposedEndDate);
            if (results != null)
            {
                //Set up data grid view
                dgCourses.DataSource = results;
                dgCourses.Columns["course_id"].Visible = false;
                dgCourses.MultiSelect = false;
                dgCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgCourses.ReadOnly = true;
                return true;
            }
            else
            {
                //Notification
                MessageBox.Show("No available courses for the selected dates", "No available courses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void dgAvailablePods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnConfirmPod.Enabled = true;
            btnConfirmPod.Visible = true;
            // Get the first selected row
            DataGridViewRow selectedRow = dgAvailablePods.SelectedRows[0];

            // Assuming the pod_id is in the first column (index 0)
            podID = Convert.ToInt32(selectedRow.Cells[0].Value);
            ConfirmPod();
        }

        private void btnBackToHomeOrMainMenu_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to cancel the booking?\r\nNo changes will be saved.","Confirm Cancellation",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Hide();
                new frmHome().Show();
            }
        }

        private void llbChangeDates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Changing the dates will clear the guests, pod, and courses you've selected!\r\nAre you sure you want to do this?", "Change Guests?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pnlDatePicker.Visible = true;
                pnlCourses.Visible = false;
                pnlGuestDisplay.Visible = false;
                pnlLocationDateDisplay.Visible = false;
            }
        }

        private void llbChangeGuests_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(MessageBox.Show("Changing the guests will clear the courses you've selected!\r\nAre you sure you want to do this?","Change Guests?",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pnlGuests.Visible = true;
                pnlCourses.Visible = false;
                pnlGuestDisplay.Visible = false;
            }
        }

        private void changeSelectedGuest(Guest selected, Label display)
        {
            lbCoursePickerInstructions.Font = new Font(lbCoursePickerInstructions.Font, FontStyle.Regular);
            dgCourses.ClearSelection();
            //dgCourses.SelectedRows.Clear();
            foreach (DataGridViewRow row in dgCourses.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value)==selected.cachedCourseChoiceID)
                    row.Selected = true;
            }
            foreach (Label lb in pnlGuestDisplay.Controls)
                lb.ForeColor = Color.Black;
            display.ForeColor = Color.MediumBlue;
            lbGuestCoursePickerTitle.Text = $"Choose a course for {selected.Forename}, or skip.";
            btnSkipCourseSelection.Text = $"Skip Course Selection for {selected.Forename}";
            currentlySelectedGuest = selected;
        }

        private void lbGuestDisplay_Click(object sender, EventArgs e)
        {
            changeSelectedGuest(selectedGuests[0], lbGuestDisplay);
            currentIterationThroughGuests = 1;
        }

        private void lbGuestDisplay2_Click(object sender, EventArgs e)
        {
            changeSelectedGuest(selectedGuests[1], lbGuestDisplay2);
            currentIterationThroughGuests = 1;
        }

        private void lbGuestDisplay3_Click(object sender, EventArgs e)
        {
            changeSelectedGuest(selectedGuests[2], lbGuestDisplay3);
            currentIterationThroughGuests = 2;
        }

        private void lbGuestDisplay4_Click(object sender, EventArgs e)
        {
            changeSelectedGuest(selectedGuests[3], lbGuestDisplay4);
            currentIterationThroughGuests = 3;
        }

        private void btnContinueCourseSelection_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSkipCourseSelection_Click(object sender, EventArgs e)
        {
            //currentlySelectedGuest
        }

        private void lbGuestDisplay5_Click(object sender, EventArgs e)
        {
            changeSelectedGuest(selectedGuests[4], lbGuestDisplay5);
            currentIterationThroughGuests = 4;
        }

        private void lbGuestDisplay6_Click(object sender, EventArgs e)
        {
            changeSelectedGuest(selectedGuests[5], lbGuestDisplay6);
            currentIterationThroughGuests = 5;
        }

        private void dgCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Set the selected course to valid
            validCourses[currentIterationThroughGuests] = true;

            // Get the first selected row
            DataGridViewRow selectedRow = dgCourses.SelectedRows[0];

            // Assuming the course_id is in the first column (index 0)
            currentlySelectedGuest.cachedCourseChoiceID = Convert.ToInt32(selectedRow.Cells[0].Value);

            //Make label green
            //Label control = pnlGuestDisplay.Controls.OfType<Label>().FirstOrDefault(c => c.Name == "lbGuestDisplay"+currentIterationThroughGuests++);
            //control.ForeColor = Color.Green;

            if(currentIterationThroughGuests==0)
                lbCoursePickerInstructions.Font = new Font(lbCoursePickerInstructions.Font, FontStyle.Bold);
        }

        Random rnd = new Random();
        private void btnRandomiseData_Click(object sender, EventArgs e)
        {
            btnRandomiseData.Enabled = false;
            //Select 6 random guests
            Guest[] randomGuests = new Guest[6];
            LakesideDAL guestDAL = new LakesideDAL();
            int guestCount = guestDAL.CountGuests();
            int[] selectedID = new int[6];
            for (int i=0; i<6; i++)
            {
                randomGuests[i] = guestDAL.GuestLookup(rnd.Next(1, guestCount--));
                while(randomGuests[i].GuestID==0 || selectedID.Contains(randomGuests[i].GuestID))
                {
                    randomGuests[i] = guestDAL.GuestLookup(rnd.Next(1, guestCount--));
                }
                selectedID[i] = randomGuests[i].GuestID;
            }

            //Add these 6 random guests to the booking
            for(int i = 0; i<6; i++)
            {
                Lakeside.currentlySelectedGuest = randomGuests[i];
                AddNewGuest();
            }
        }

        private void btnContinueFromCourseSelection_Click(object sender, EventArgs e)
        {
            bool allValidCourses = true;
            //for(int i=0; i<validCourses.Length;i++)
            //{
            //    if (validCourses[i] == false)
            //        allValidCourses = false;
            //}
            if (allValidCourses)
            {
                //Give User Feedback
                btnContinueFromCourseSelection.Enabled = false;
                
                //Create new booking
                Booking b = new Booking("provisional", proposedStartDate, proposedEndDate, DateTime.Now.Date, selectedGuests.Count, 0.00, DateTime.Now.Date, 0, selectedPod.PodID);
                BookingDAL BookingDAL = new BookingDAL();
                BookingDAL.AddNewBooking(b);
                
                LakesideDAL GuestDAL = new LakesideDAL();
                CourseDAL CourseDAL = new CourseDAL();
                foreach(Guest g in selectedGuests)
                {
                    if(g.cachedCourseChoiceID!=null)
                    {
                        GuestDAL.RegisterForCourse(g,CourseDAL.CourseLookup(g.cachedCourseChoiceID),b);
                    }
                }

                MessageBox.Show("Booking added successfully!");
                Hide();
                new frmHome().Show();
            }
            else
            {
                //Notify
                //MessageBox.Show("You did't complete all the course options! Please use the skip button")
            }
        }

        //private void pnlDatePicker_Paint(object sender, PaintEventArgs e)
        //{
        //    int endOfMonth = (DateTime.DaysInMonth(proposedStartDate.Year, proposedStartDate.Month));
        //    Label endDateDisplay = pnlCalBase.Controls.Find("day_" + endOfMonth, true).FirstOrDefault() as Label;
        //    Pen linePen = new Pen(Color.FromArgb(139, 201, 187), 3);
        //    Point p1 = new Point(endDateDisplay.Location.X + TextRenderer.MeasureText(endDateDisplay.Text, endDateDisplay.Font).Width, endDateDisplay.Location.Y + TextRenderer.MeasureText(endDateDisplay.Text, endDateDisplay.Font).Height / 2);
        //    Point p2 = new Point(0, 0);
        //    e.Graphics.DrawLine(linePen, p1, p2);
        //}
    }
}
