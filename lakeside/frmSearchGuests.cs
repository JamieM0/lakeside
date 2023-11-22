using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using lakeside.DAL;
//using lakeside.Models;

namespace lakeside
{
    public partial class frmSearchGuests : Form
    {
        public frmSearchGuests()
        {
            InitializeComponent();
            CenterToScreen();
            txtSearch_SetText();
        }
        public frmSearchGuests(string search)
        {
            InitializeComponent();
            CenterToScreen();
            txtSearch.Text = (search);
        }

        protected void txtSearch_SetText()
        {
            txtSearch.Text = "Search for Name, Email, or Guest ID...";
            txtSearch.ForeColor = Color.Gray;
        }
        
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.ForeColor == Color.Black)
                return;
            txtSearch.Text = "";
            txtSearch.ForeColor = Color.Black;
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
                txtSearch_SetText();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Hide();
            new frmHome().Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchCase = txtSearch.Text;
            foreach(Control c in pnlGuestContainer.Controls)
            {
                pnlGuestContainer.Controls.Remove(c);
            }
            
            if (searchCase == "Search for Name, Email, or Guest ID..." || searchCase=="")
            {
                //dgvGuests.DataSource = Guest.GetGuests();
                foreach (Control c in pnlGuestContainer.Controls)
                {
                    pnlGuestContainer.Controls.Remove(c);
                }
            }
            else
            {
                LakesideDAL dal = new LakesideDAL();
                Guest[] searchResults = dal.SearchGuests(searchCase);
                PopulateGuestResults(searchResults);
            }
        }

        private void PopulateGuestResults(Guest[] results)
        {
            foreach (Control c in pnlGuestContainer.Controls)
            {
                pnlGuestContainer.Controls.Remove(c);
            }
            try
            {
                int i = 0;
                foreach (Guest g in results)
                {
                    Panel pnl = new Panel();
                    pnl.Name = "pnlGuest" + i;
                    pnl.Size = new Size(762, 55);
                    pnl.Location = new Point(3, 3 + (i * 61));
                    pnl.BorderStyle = BorderStyle.FixedSingle;
                    pnlGuestContainer.Controls.Add(pnl);

                    Label lbName = new Label();
                    lbName.Font = new Font("Segoe UI", 16);
                    lbName.Name = "lbName" + i;
                    lbName.Text = g.Forename/*.Split(' ')[0]*/ + " " + g.Surname;
                    lbName.Location = new Point(3, 12);
                    int nameWidth = TextRenderer.MeasureText(lbName.Text, lbName.Font).Width;
                    lbName.Anchor = AnchorStyles.Left;
                    lbName.AutoSize = true;
                    pnl.Controls.Add(lbName);

                    Label lbEmail = new Label();
                    lbEmail.Font = new Font("Segoe UI", 16);
                    lbEmail.Name = "lbEmail" + i;
                    lbEmail.Text = g.Email;
                    lbEmail.Location = new Point(3 + nameWidth + 27, 12);
                    lbEmail.Anchor = AnchorStyles.Left;
                    lbEmail.AutoSize = true;
                    pnl.Controls.Add(lbEmail);

                    System.Windows.Forms.Button btnEdit = new System.Windows.Forms.Button();
                    btnEdit.Name = "btnEdit_" + g.GuestID;
                    btnEdit.BackgroundImage = Properties.Resources.EditGuestButton;
                    btnEdit.BackgroundImageLayout = ImageLayout.Zoom;
                    btnEdit.Location = new Point(604, 3);
                    btnEdit.Size = new Size(155, 49);
                    btnEdit.Click += new EventHandler(btnEdit_Click);
                    pnl.Controls.Add(btnEdit);

                    i++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry! There was an error displaying the search results! Please try again later!\r\nMore Details: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (Control c in pnlGuestContainer.Controls)
                {
                    pnlGuestContainer.Controls.Remove(c);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                LakesideDAL dal = new LakesideDAL();
                System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
                string btnName = btn.Name;
                int guestID = int.Parse(btnName.Split('_')[1]);
                Guest g = dal.GuestLookup(guestID);
                Hide();
                new frmAddGuest(g, txtSearch.Text).Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Sorry the requested record couldn't be located! \r\nMore details: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
            new frmHome().Show();
        }
    }
}
