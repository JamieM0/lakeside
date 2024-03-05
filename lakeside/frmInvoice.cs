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
        public frmInvoice(Invoice Invoice)
        {
            invoice = Invoice;
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            InitializeComponent();
            CenterToScreen();
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
                dgCourseSelected.Rows.Add(pair.Value, pair.Key, currentCourse.Price, currentCourse.Price * pair.Value);
            }

            //Populate Course Datagrid
            //for (int i=0; i<invoice.coursesSelected.Count;i++)
            //{
            //    dgCourseSelected.Rows.Add(invoice.coursesSelected[i].CourseName);
            //}
        }

        private void SetLabels()
        {
            lbDate.Text = invoice.booking.CheckInDate.ToString("ddd d MMM") + " - " + DateTime.Now.Date.ToString("ddd d MMM");
            lbPodName.Text = invoice.bookedPod.FriendlyName;
            lbLeadGuestName.Text = invoice.leadGuest.Forename + " " + invoice.leadGuest.Surname;
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            dgCourseSelected.Font = new Font("Segoe UI", 12);
            dgExtraSelected.Font = new Font("Segoe UI", 12);
            switch(invoice.coursesSelected.Count)
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
            switch (invoice.extrasSelected.Count)
            {
                case 0:
                    lbInfoCourseSelected.Text = "No extras selected.";
                    dgExtraSelected.Visible = false;
                    break;
                case 1:
                    lbInfoCourseSelected.Text = "Extra Selected";
                    dgExtraSelected.Visible = true;
                    break;
                default:
                    lbInfoCourseSelected.Text = "Extras Selected";
                    dgExtraSelected.Visible = true;
                    break;
            }

            PopulateDatagrids();
            SetLabels();
        }
    }
}
