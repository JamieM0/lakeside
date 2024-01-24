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
        }

        DateTime startDate = new DateTime();
        DateTime endDate = new DateTime();
        private void btnContinue_Click(object sender, EventArgs e)
        {
            btnContinue.Enabled = false;
            //pnlStayLength.Visible = false;
            cmbDatePickerStayLength.Enabled = false;
            Lakeside.AnimatePanelSideways(pnlStayLength, new Point(20, 128));
            //pnlStayLength.Location = new Point(20, 128);
            Cursor.Current = Cursors.WaitCursor;
            startDate = DateTime.Now.Date.AddDays(-Convert.ToInt32(cmbDatePickerStayLength.Text));
            endDate = DateTime.Now.Date;
            lbDateRange.Visible = true;
            lbDateRange.Text = ($"{startDate.ToString("ddd d MMM")} - {endDate.ToString("ddd d MMM")}");
            AddBookedPods();
            pnlPodChooser.Visible = true;
            Cursor.Current = Cursors.Default;

        }

        private bool AddBookedPods()
        {
            BookingDAL dal = new BookingDAL();
            // Get all available pods and add to data grid view.
            DataTable results = dal.GetAvailablePods(startDate, endDate);
            if (results != null)
            {
                //Set up data grid view
                dgPods.DataSource = results;
                dgPods.Columns["pod_id"].Visible = false;
                dgPods.MultiSelect = false;
                dgPods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgPods.ReadOnly = true;
                return true;
            }
            else
            {
                //Notification
                MessageBox.Show("No pods have been booked on these dates. \r\nYou can change the selected dates on the left.", "No booked pods", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void frmCheckOutExperience_Load(object sender, EventArgs e)
        {
            
        }
    }
}
