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
            //Populate Course Datagrid
            for(int i=0; i<invoice.coursesSelected.Count;i++)
            {
                dgCourseSelected.Rows.Add(invoice.coursesSelected[i].CourseName);
            }
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
                    dgCourseSelected.Visible = false;
                    break;
                default: lbInfoCourseSelected.Text = "Courses Selected";
                    dgCourseSelected.Visible = false;
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
        }
    }
}
