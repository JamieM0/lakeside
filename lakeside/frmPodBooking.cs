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

            if (proposedEndDate.Month == proposedStartDate.Month)
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

                Label endDateDisplay = pnlCalBase.Controls.Find("day_" + proposedEndDate.Day, true).FirstOrDefault() as Label;

                newDate = false;
                SelectDate(endDateDisplay);

                //Get all dates between start and end
                for (int i = proposedStartDate.Day; i < proposedEndDate.Day+1; i++)
                {
                    SelectDate(pnlCalBase.Controls.Find("day_" + i, true).FirstOrDefault() as Label);
                }
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
            HighlightStayPeriod();
            DisplayCurrentMonth(current.AddMonths(1));
        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            HighlightStayPeriod();
            DisplayCurrentMonth(current.AddMonths(-1));
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
            if (formLoaded)
            {
                proposedEndDate = proposedStartDate.AddDays(Convert.ToInt32(cmbDatePickerStayLength.SelectedItem.ToString()));
                HighlightStayPeriod();
                HighlightStayPeriod();
            }
        }

        private void AddAvailablePods()
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
            }
            else
            {
                //Notification
                MessageBox.Show("No available pods for the selected dates", "No available pods", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSelectDates_Click(object sender, EventArgs e)
        {
            //Change cursor to loading cursor
            Cursor.Current = Cursors.WaitCursor;
            AddAvailablePods();
            pnlDatePicker.Visible = false;
            Cursor.Current = Cursors.Default;
            dgAvailablePods.Visible = true;
        }

        private void btnDatePickerOpenerSelector_Click(object sender, EventArgs e)
        {
            pnlDatePicker.Visible = true;
            pnlDatePicker.BringToFront();
        }

        private void btnConfirmPod_Click(object sender, EventArgs e)
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
        }

        private void dgAvailablePods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnConfirmPod.Enabled = true;
            // Get the first selected row
            DataGridViewRow selectedRow = dgAvailablePods.SelectedRows[0];

            // Assuming the pod_id is in the first column (index 0)
            podID = Convert.ToInt32(selectedRow.Cells[0].Value);
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            tmrTick.Start();
            new frmAddGuest(true).Show();
        }
        public void AddNewGuest()
        {
            selectedGuests.Add(Lakeside.currentlySelectedGuest);
            btnAcceptGuests.Enabled = true;
            if(selectedGuests.Count>=selectedPod.Capacity)
            {
                btnAddGuest.Enabled = false;
                btnSelectGuests.Enabled = false;
            }
            addGuests();
        }

        private void btnSelectGuests_Click(object sender, EventArgs e)
        {
            tmrTick.Start();
            new frmSearchGuests(true).Show();
        }

        private void addGuests()
        {
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
                string guestDisplay = "";
                for (int i = 0; i < selectedGuests.Count; i++)
                {
                    guestDisplay += selectedGuests[i].Forename + " " + selectedGuests[i].Surname + "\r\n";
                }
                lbGuestDisplay.Text = guestDisplay;
            }
            else
            {
                //Notify
                //MessaegeBox.Show("")
            }
        }
    }
}
