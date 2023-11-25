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
using lakeside.Models;

namespace lakeside
{
    public partial class frmSearchGuests : Form
    {
        string searchType="";
        public frmSearchGuests()
        {
            InitializeComponent();
            txtSearch_SetText("Search for Name, Email, or Guest ID...");
            searchType = "guest";
        }
        public frmSearchGuests(string search)
        {
            InitializeComponent();
            CenterToScreen();
            txtSearch.Text = (search);
            searchType = "guest";
        }

        public frmSearchGuests(object type, string search)
        {
            InitializeComponent();
            //Is type a Pod
            if (type.GetType() == typeof(Pod))
            {
                CenterToScreen();
                txtSearch_SetText("Search for Pod Name, Location, or Pod ID...");
                searchType = "pod";
                lbTitle.Text = "Lakeside Escapes: Search Pods";
            }
            else if (type.GetType() == typeof(Extra))
            {
                CenterToScreen();
                txtSearch_SetText("Search for Extra Name, Description, or Extra ID...");
                searchType = "extra";
                lbTitle.Text = "Lakeside Escapes: Search Extras";
            }
            else if (type.GetType() == typeof(Staff))
            {
                CenterToScreen();
                txtSearch_SetText("Search for Staff Name, Email, or Staff ID...");
                searchType = "staff";
                lbTitle.Text = "Lakeside Escapes: Search Staff";
            }
            else if (type.GetType() == typeof(Course))
            {
                CenterToScreen();
                txtSearch_SetText("Search for Course Name, Tutor, or Course ID...");
                searchType = "course";
                lbTitle.Text = "Lakeside Escapes: Search Course";
            }

            if (search != null)
                txtSearch.Text = search;
        }

        protected void txtSearch_SetText(string text)
        {
            txtSearch.Text = text;
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
                txtSearch_SetText("Search for Name, Email, or Guest ID...");
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
            else if(searchType=="guest")
            {
                LakesideDAL dal = new LakesideDAL();
                Guest[] searchResults = dal.SearchGuests(searchCase);
                PopulateGuestResults(searchResults);
            }
            else if (searchType == "pod")
            {
                PodDAL dal = new PodDAL();
                Pod[] searchResults = dal.SearchPods(searchCase);
                PopulateGuestResults(searchResults);
            }
            else if (searchType=="extra")
            {
                ExtraDAL dal = new ExtraDAL();
                Extra[] searchResults = dal.SearchExtras(searchCase);
                PopulateGuestResults(searchResults);
            }
            else if(searchType=="staff")
            {
                StaffDAL dal = new StaffDAL();
                Staff[] searchResults = dal.SearchStaff(searchCase);
                PopulateGuestResults(searchResults);
            }
            else if (searchType == "course")
            {
                CourseDAL dal = new CourseDAL();
                Course[] searchResults = dal.SearchCourses(searchCase);
                PopulateGuestResults(searchResults);
            }
        }

        private void PopulateGuestResults(object[] results)
        {
            int idElement = 0;
            Image btnImg = null;
            string element1 = "";
            string element2 = "";
            string element3 = "";
            string element4 = "";            

            foreach (Control c in pnlGuestContainer.Controls)
            {
                pnlGuestContainer.Controls.Remove(c);
            }
            try
            {
                int i = 0;
                foreach (Object g in results)
                {
                    if (searchType == "guest")
                    {
                        //Convert g to Guest
                        Guest guest = (Guest)g;
                        element1 = guest.Forename;
                        element2 = guest.Surname;
                        element3 = guest.Email;
                        idElement = guest.GuestID;
                        btnImg = Properties.Resources.EditGuestButton;
                    }
                    else if(searchType=="pod")
                    {
                        //Convert g to Pod
                        Pod pod = (Pod)g;
                        element1 = pod.FriendlyName;
                        element2 = "("+pod.Location+")";
                        element3 = pod.Description;
                        idElement = pod.PodID;
                        btnImg = Properties.Resources.EditPodButton;
                    }
                    else if(searchType=="extra")
                    {
                        //Convert g to Extra
                        Extra extra = (Extra)g;
                        element1 = extra.ExtraName;
                        element2 = "";
                        element3 = extra.Description;
                        idElement = extra.ExtraID;
                        btnImg = Properties.Resources.dice2;
                    }
                    else if (searchType == "staff")
                    {
                        //Convert g to Staff
                        Staff staff = (Staff)g;
                        element1 = staff.Forename;
                        element2 = staff.Surname;
                        element3 = staff.Position;
                        idElement = staff.StaffID;
                        btnImg = Properties.Resources.EditGuestButton;
                    }
                    else if (searchType == "course")
                    {
                        //Convert g to Course
                        Course course = (Course)g;
                        element1 = course.CourseName;
                        element2 = "";
                        element3 = "Tutor ID: " + course.TutorID.ToString();
                        idElement = course.CourseID;
                        btnImg = Properties.Resources.EditCourseButton;
                    }

                    Panel pnl = new Panel();
                    pnl.Name = "pnlGuest" + i;
                    pnl.Size = new Size(762, 55);
                    pnl.Location = new Point(3, 3 + (i * 61));
                    pnl.BorderStyle = BorderStyle.FixedSingle;
                    pnlGuestContainer.Controls.Add(pnl);

                    Label lbName = new Label();
                    lbName.Font = new Font("Segoe UI", 16);
                    lbName.Name = "lbName" + i;
                    lbName.Text = element1 + " " + element2;
                    lbName.Location = new Point(3, 12);
                    int nameWidth = TextRenderer.MeasureText(lbName.Text, lbName.Font).Width;
                    lbName.Anchor = AnchorStyles.Left;
                    lbName.AutoSize = true;
                    pnl.Controls.Add(lbName);

                    Label lbEmail = new Label();
                    lbEmail.Font = new Font("Segoe UI", 16);
                    lbEmail.Name = "lbEmail" + i;
                    lbEmail.Text = element3;
                    lbEmail.Location = new Point(3 + nameWidth + 27, 12);
                    lbEmail.Anchor = AnchorStyles.Left;
                    lbEmail.AutoSize = true;
                    pnl.Controls.Add(lbEmail);

                    System.Windows.Forms.Button btnEdit = new System.Windows.Forms.Button();
                    btnEdit.Name = "btnEdit_" + idElement;
                    btnEdit.BackgroundImage = btnImg;
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
            if(searchType=="guest")
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
                catch (Exception ex)
                {
                    MessageBox.Show($"Sorry the requested record couldn't be located! \r\nMore details: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(searchType=="pod")
            {
                try
                {
                    PodDAL dal = new PodDAL();
                    System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
                    string btnName = btn.Name;
                    int podID = int.Parse(btnName.Split('_')[1]);
                    Pod p = dal.PodLookup(podID);
                    Hide();
                    new frmAddPod(p, txtSearch.Text).Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Sorry the requested record couldn't be located! \r\nMore details: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (searchType == "extra")
            {
                try
                {
                    ExtraDAL dal = new ExtraDAL();
                    System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
                    string btnName = btn.Name;
                    int extraID = int.Parse(btnName.Split('_')[1]);
                    Extra ex = dal.ExtraLookup(extraID);
                    Hide();
                    new frmAddExtra(ex, txtSearch.Text).Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Sorry the requested record couldn't be located! \r\nMore details: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (searchType=="staff")
            {
                try
                {
                    StaffDAL dal = new StaffDAL();
                    System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
                    string btnName = btn.Name;
                    int staffID = int.Parse(btnName.Split('_')[1]);
                    Staff s = dal.StaffLookup(staffID);
                    Hide();
                    new frmAddGuest(s, txtSearch.Text).Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Sorry the requested record couldn't be located! \r\nMore details: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(searchType=="course")
            {
                try
                {
                    CourseDAL dal = new CourseDAL();
                    System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
                    string btnName = btn.Name;
                    int courseID = int.Parse(btnName.Split('_')[1]);
                    Course c = dal.CourseLookup(courseID);
                    Hide();
                    new frmAddCourse(c, txtSearch.Text).Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Sorry the requested record couldn't be located! \r\nMore details: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
            new frmHome().Show();
        }

        private void frmSearchGuests_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
