using lakeside.Models;
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
using lakeside;

namespace lakeside
{
    public partial class frmHome : Form
    {
        bool draggingWindow=false;
        Point dragCursorPoint;
        Point dragFormPoint;
        //26, 30, 36 <- Colour for black bar at the top of the screen.
        public frmHome()
        {
            InitializeComponent();
            this.Text = "";
            CenterToScreen();
            //menuStrip1.AutoSize = false;
            //menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Anchor = AnchorStyles.None;
            menuStrip1.Left = this.ClientSize.Width / 2 - menuStrip1.Width / 2;
            pnlBlackBackground.SendToBack();
            //LakesideDAL a = new LakesideDAL();
            //MessageBox.Show($"{a.CountGuests()}");
            menuStrip1.Renderer = new MyRenderer();

            BookingDAL bookingDAL = new BookingDAL();
            bookingDAL.RemoveBookings();
        }

        private void MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            draggingWindow = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void MainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggingWindow)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void MainMenu_MouseUp(object sender, MouseEventArgs e)
        {
            draggingWindow = false;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            //btnClose.BackColor = Color.Red;
            //btnClose.ForeColor = Color.White;
        }

        private void btnClose_MouseMove(object sender, MouseEventArgs e)
        {
            //btnClose.BackColor = Color.Transparent;
            //btnClose.ForeColor = Color.Black;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void ythToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            Hide();
            new frmAddGuest().Show();
        }

        private void addGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmAddGuest().Show();
        }

        private void btnEditGuest_Click(object sender, EventArgs e)
        {
            Hide();
            new frmSearchGuests().Show();
        }

        private void editGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmSearchGuests().Show();
        }

        private void btnAddPod_Click(object sender, EventArgs e)
        {
            Hide();
            new frmAddPod().Show();
        }

        private void btnEditPod_Click(object sender, EventArgs e)
        {
            Pod tmp = new Pod();
            Hide();
            new frmSearchGuests(tmp, null).Show();
        }

        private void editPosdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pod tmp = new Pod();
            Hide();
            new frmSearchGuests(tmp, null).Show();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmAddCourse().Show();
        }

        private void addExtraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmAddExtra().Show();
        }

        private void editExtraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Extra tmp = new Extra();
            //Hide();
            //new frmSearchGuests(tmp, null).Show();
            Hide();
            new frmEditExtra().Show();
        }

        private void addStaffMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff tmp = new Staff();
            Hide();
            new frmAddGuest(1).Show();
        }

        private void editStaffMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff tmp = new Staff();
            Hide();
            new frmSearchGuests(tmp, null).Show();
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Course tmp = new Course();
            Hide();
            new frmSearchGuests(tmp, null).Show();
        }

        private void btnPodBooking_Click(object sender, EventArgs e)
        {
            Hide();
            new frmPodBooking().Show();
        }

        private void cbDebug_CheckedChanged(object sender, EventArgs e)
        {
            if(cbDebug.Checked)
            {
                if(MessageBox.Show("Enabling the debug mode will remove certain validation to enable testing.\r\nAre you sure you want to do this?","Enable Debug Mode?",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    cbDebug.Checked = true;
                    Lakeside.debug = cbDebug.Checked;
                }
                else
                {
                    cbDebug.Checked = false;
                    Lakeside.debug = cbDebug.Checked;
                }
            }
        }

        private void addPodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmAddPod().Show();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void pnlExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void lbExit_MouseEnter(object sender, EventArgs e)
        {
            lbExit.ForeColor = Color.Red;
        }

        private void lbExit_MouseLeave(object sender, EventArgs e)
        {
            lbExit.ForeColor = Color.White;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Hide();
            new frmCheckOutExperience().Show();
        }

        private void extraToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            //extraToolStripMenuItem.BackColor = Color.DarkBlue;
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.DarkBlue; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.DarkBlue; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.DarkCyan; }
            }
            public override Color MenuItemBorder
            {
                get { return Color.DarkBlue; }
            }
            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.DarkBlue; }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.DarkCyan; }
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            Hide();
            new frmInvoice(new Invoice()).Show();
        }
    }
}
