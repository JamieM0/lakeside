using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lakeside
{
    public partial class frmPodBooking : Form
    {
        DateTime current = DateTime.Now.Date;
        DayOfWeek firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).DayOfWeek;

        DateTime proposedStartDate = new DateTime();
        DateTime proposedEndDate = new DateTime();

        Panel pnlCalBase;
        Panel[] dayPanels;

        bool formLoaded = false;

        public frmPodBooking()
        {
            InitializeComponent();
            CenterToScreen();
            cmbDatePickerStayLength.SelectedIndex = 0;
            lbDateRange.Visible = false;
            InitialiseCalendar();
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

            if (Validation.BookingStartDate(proposedStartDate)==null)
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
    }
}
