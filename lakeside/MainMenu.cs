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

        public frmHome()
        {
            InitializeComponent();
            this.Text = "";
            CenterToScreen();
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
            btnClose.BackColor = Color.Red;
            btnClose.ForeColor = Color.White;
        }

        private void btnClose_MouseMove(object sender, MouseEventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
            btnClose.ForeColor = Color.Black;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
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
            Extra tmp = new Extra();
            Hide();
            new frmSearchGuests(tmp, null).Show();
        }
    }
}
