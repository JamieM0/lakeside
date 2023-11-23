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
    public partial class frmAddCourse : Form
    {
        bool newCourse = true;
        bool[] allValid = new bool[7];
        public frmAddCourse()
        {
            InitializeComponent();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            Hide();
            new frmAddCourse().Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if(newCourse)
            {
                Hide();
                new frmHome().Show();
            }
        }

        private void ValidSetter(int elementID)
        {
            Control changeColour = null;
            Label errorDisplay = null;
            string msg = null;
            switch (elementID)
            {
                case 0:
                    changeColour = txtCourseName;
                    errorDisplay = validCourseName;
                    msg = Validation.OtherText(changeColour.Text, "Course name");
                    break;
                case 1:
                    changeColour = txtDescription;
                    errorDisplay = validDescription;
                    msg = Validation.OtherText(changeColour.Text, "Course description");
                    break;
                case 2:
                    changeColour = cmbTutor;
                    errorDisplay = validTutor;
                    msg = Validation.OtherText(changeColour.Text, "Tutor");
                    break;
                case 3:
                    changeColour = cmbCourseLevel;
                    errorDisplay = validCourseLevel;
                    //msg = Validation.OtherText(changeColour.Text, "address");
                    break;
                case 4:
                    changeColour = txtPricePPPN;
                    errorDisplay = validPricePPPN;
                    msg = Validation.Money(changeColour.Text);
                    break;
                case 5:
                    changeColour = txtCapacity;
                    errorDisplay = validCapacity;
                    msg = Validation.NumberRange(changeColour.Text, 1, 50, "Capacity");
                    break;
                case 6:
                    changeColour = txtDuration;
                    errorDisplay = validDuration;
                    msg = Validation.NumberRange(changeColour.Text, 15, 120, "Duration");
                    break;
            }
            if (msg == null)
                Validator(elementID, changeColour, errorDisplay, msg);
            else
                Invalidator(elementID, changeColour, errorDisplay, msg);
        }
        private void Invalidator(int elementID, Control changeColour, Label errorDisplay, string msg)
        {
            //elementID: 0-Name, 1-Email, 2-PhoneNumber, 3-Street, 4-Postcode, 5-Town, 6-Country
            //Lakeside.Notifier()
            changeColour.BackColor = Color.LightCoral;
            errorDisplay.Text = msg;
            allValid[elementID] = false;
        }
        private void Validator(int elementID, Control changeColour, Label errorDisplay, string msg)
        {
            changeColour.BackColor = Color.White;
            errorDisplay.Text = "";
            allValid[elementID] = true;
        }
        bool validTotal = true;
        private bool CheckValidation()
        {
            foreach (bool validTest in allValid)
            {
                if (!validTest)
                    validTotal = false;
            }
            return validTotal;
        }

        private void frmAddCourse_Load(object sender, EventArgs e)
        {
            validCapacity.Text = "";
            validCourseLevel.Text = "";
            validCourseName.Text = "";
            validDescription.Text = "";
            validDuration.Text = "";
            validPricePPPN.Text = "";
            validTutor.Text = "";

            cmbCourseLevel.Text = "Beginner";
        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(0);
        }

        private void txtCourseName_Leave(object sender, EventArgs e)
        {
            ValidSetter(0);
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(1);
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            ValidSetter(1);
        }

        private void cmbTutor_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(2);
        }

        private void cmbTutor_Leave(object sender, EventArgs e)
        {
            ValidSetter(2);
        }

        private void cmbCourseLevel_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(3);
        }

        private void cmbCourseLevel_Leave(object sender, EventArgs e)
        {
            ValidSetter(3);
        }

        private void txtPricePPPN_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(4);
        }

        private void txtPricePPPN_Leave(object sender, EventArgs e)
        {
            ValidSetter(4);
        }

        private void txtCapacity_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(5);
        }

        private void txtCapacity_Leave(object sender, EventArgs e)
        {
            ValidSetter(5);
        }

        private void txtDuration_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(6);
        }

        private void txtDuration_Leave(object sender, EventArgs e)
        {
            ValidSetter(6);
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            int level = 0;
            if (cmbCourseLevel.Text == "Intermediate")
                level = 1;
            else
                level = 2;

            if (newCourse && CheckValidation())
            {
                try
                {
                    int tutorID = 0;
                    //int tutorID = TutorDAL.GetTutorID(cmbTutor.Text);
                    Course course = new Course(0, tutorID, txtCourseName.Text, txtDescription.Text, int.Parse(txtDuration.Text), int.Parse(txtCapacity.Text), double.Parse(txtPricePPPN.Text), level);
                    CourseDAL dal = new CourseDAL();
                    if (dal.AddNewCourse(course))
                    {
                        MessageBox.Show("Course added successfully");
                        Hide();
                        new frmAddCourse().Show();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error adding course.\r\nMore Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validTotal = true;
                }
            }
            else
            {
                MessageBox.Show("There are errors in the form! Please correct them.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validTotal = true;
            }
        }
    }
}
