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

namespace lakeside
{
    public partial class frmSearchGuests : Form
    {
        public frmSearchGuests()
        {
            InitializeComponent();
            txtSearch_SetText();
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
            if (searchCase == "Search for Name, Email, or Guest ID..." || searchCase=="")
            {
                //dgvGuests.DataSource = Guest.GetGuests();
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
            try
            {
                int i = 0;
                foreach (Guest g in results)
                {
                    Panel pnl = new Panel();
                    pnl.Name = "pnlGuest" + i;
                    pnl.Size = new Size(762, 55);
                    pnl.Location = new Point(3, 3 + (i * 61));
                    pnlGuestContainer.Controls.Add(pnl);

                    Label lbName = new Label();
                    lbName.Font = new Font("Segoe UI", 16);
                    lbName.Name = "lbName" + i;
                    lbName.Text = g.Forename.Split(' ')[0] + " " + g.Surname;
                    lbName.Location = new Point(3, 12);
                    pnl.Controls.Add(lbName);

                    Label lbEmail = new Label();
                    lbEmail.Font = new Font("Segoe UI", 16);
                    lbEmail.Name = "lbEmail" + i;
                    lbEmail.Text = g.Email;
                    lbEmail.Location = new Point(3, 12);
                    pnl.Controls.Add(lbEmail);

                    System.Windows.Forms.Button btnEdit = new System.Windows.Forms.Button();
                    btnEdit.Name = "btnEdit" + i;
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
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            //string btnName = btn.Name;
            //int guestID = int.Parse(btnName.Substring(6));
            //Guest g = Guest.GetGuest(guestID);
            //Hide();
            //new frmEditGuest(g).Show();
        }
    }
}
