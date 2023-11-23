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
                    msg = Validation.OtherText(changeColour.Text, "course name");
                    break;
                case 1:
                    changeColour = txtDescription;
                    errorDisplay = validDescription;
                    msg = Validation.OtherText(changeColour.Text, "course description");
                    break;
                case 2:
                    changeColour = cmbTutor;
                    errorDisplay = validTutor;
                    //msg = Validation.PhoneNumber(changeColour.Text);
                    break;
                case 3:
                    changeColour = cmbTutor;
                    errorDisplay = validTutor;
                    msg = Validation.OtherText(changeColour.Text, "address");
                    break;
                case 4:
                    changeColour = txtPricePPPN;
                    errorDisplay = validPricePPPN;
                    msg = Validation.UKPostcode(changeColour.Text);
                    break;
                case 5:
                    changeColour = txtCapacity;
                    errorDisplay = validCapacity;
                    msg = Validation.UKCityTown(changeColour.Text);
                    break;
                case 6:
                    changeColour = txtDuration;
                    errorDisplay = validDuration;
                    msg=Validation.Country(changeColour.Text);
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
        }
    }
}
