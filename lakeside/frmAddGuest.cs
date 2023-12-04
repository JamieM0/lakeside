using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using lakeside.DAL;
//using lakeside.Models;
using System.Xml.Linq;

namespace lakeside
{
    public partial class frmAddGuest : Form
    {
        bool newMode = true;
        string cachedSearch = "";
        int id = 0;
        bool[] allValid = new bool[8];
        bool staffMode = false;

        public frmAddGuest()
        {
            InitializeComponent();
        }

        public frmAddGuest(Guest edit, string search)
        {
            cachedSearch = search;
            InitializeComponent();
            txtFullName.Text = edit.Forename + " " + edit.Surname;
            txtEmail.Text = edit.Email;
            txtMobileNumber.Text = edit.Number;
            txtAdd1.Text = edit.Street;
            txtCityTown.Text = edit.CityTown;
            txtPostcode.Text = edit.Postcode;
            cmbCountry.Text = edit.Country;
            id = edit.GuestID;
            btnAddGuest.BackgroundImage = Properties.Resources.EditGuestButton;
            btnRandomiseData.Image = null;
            btnRandomiseData.Text = "";
            btnRandomiseData.BackgroundImage = Properties.Resources.RemoveGuestButton;
            lbTitle.Text = "Edit Guest";
            this.Text = "Lakeside Escapes: Edit Guest";
            btnReturn.Text = "Return to Search";
        }

        public frmAddGuest(int staff)
        {
            InitializeComponent();
            staffMode = true;
            lbTitle.Text = "Add a Staff Member";
            this.Text = "Lakeside Escapes: Add a Staff Member";
            btnAddGuest.BackgroundImage = null;
            btnAddGuest.Image = Properties.Resources.AddUser_Small;
            btnAddGuest.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddGuest.Text = "Add Staff Member";
            txtPosition.Visible = true;
            lbPosition.Visible = true;
            validPosition.Visible = true;
        }
        public frmAddGuest(Staff edit, string search)
        {
            staffMode = true;
            cachedSearch = search;
            InitializeComponent();
            txtFullName.Text = edit.Forename + " " + edit.Surname;
            txtEmail.Text = edit.Email;
            txtMobileNumber.Text = edit.Number;
            txtAdd1.Text = edit.Street;
            txtCityTown.Text = edit.CityTown;
            txtPostcode.Text = edit.Postcode;
            cmbCountry.Text = edit.Country;
            id = edit.StaffID;
            txtPosition.Text = edit.Position;
            btnAddGuest.BackgroundImage = null;
            btnAddGuest.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddGuest.Image = Properties.Resources.EditUser_Small;
            btnAddGuest.Text = "Edit Staff Member";
            btnRandomiseData.Image = null;
            btnRandomiseData.Text = "";
            btnRandomiseData.BackgroundImage = Properties.Resources.RemoveGuestButton;
            lbTitle.Text = "Edit Staff";
            this.Text = "Lakeside Escapes: Edit Staff";
            btnReturn.Text = "Return to Search";
            txtPosition.Visible = true;
            lbPosition.Visible = true;
            validPosition.Visible = true;
        }

        public static List<string> GetCountryList()
        {
            List<string> cultureList = new List<string>();

            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (CultureInfo culture in cultures)
            {
                RegionInfo region = new RegionInfo(culture.LCID);

                if (!(cultureList.Contains(region.EnglishName)))
                {
                    cultureList.Add(region.EnglishName);
                }
            }
            cultureList.Sort();
            return cultureList;
        }

        string[] data = File.ReadAllLines("randomData.csv");
        private void btnRandomiseData_Click(object sender, EventArgs e)
        {
            string[] townData = File.ReadAllLines("uktownscities.txt");
            Random rnd = new Random();
            string[] subject = data[rnd.Next(1, data.Length)].Split(',');
            txtFullName.Text = subject[0] + " " + subject[1];
            txtAdd1.Text = subject[2];
            txtCityTown.Text = townData[rnd.Next(0,townData.Length)];
            txtPostcode.Text = "AB12 3CD";
            txtMobileNumber.Text = "7766884747"/*subject[5].Substring(1,subject[5].Length-1)*/;
            txtEmail.Text = subject[6];
            townData = null;
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            allValid[6] = true;
            DisableAllFields();
            if(newMode && !staffMode && CheckValidation())
            {
                string[] names = txtFullName.Text.Trim().Split(' ');
                string forename = "";
                string givenName = names[0];
                string surname = names[names.Length - 1];
                for (int i = 0; i < names.Length - 1; i++)
                {
                    forename += names[i] + " ";
                }
                forename = forename.Trim();
                surname = surname.Trim();
                givenName = givenName.Trim();
                Guest guest = new Guest(forename, surname, txtEmail.Text, txtMobileNumber.Text, txtAdd1.Text, txtCityTown.Text, txtPostcode.Text, cmbCountry.Text, -1);
                LakesideDAL dal = new LakesideDAL();
                dal.AddNewGuest(guest);
                MessageBox.Show("Guest added successfully!");
                //ClearAllFields();
                //EnableAllFields();
                Hide();
                new frmAddGuest().Show();
            }
            else if(!newMode && !staffMode && CheckValidation())
            {
                //Edit current guest
                string[] names = txtFullName.Text.Trim().Split(' ');
                string forename = "";
                string givenName = names[0];
                string surname = names[names.Length - 1];
                for (int i = 0; i < names.Length - 1; i++)
                {
                    forename += names[i] + " ";
                }
                forename = forename.Trim();
                surname = surname.Trim();
                givenName = givenName.Trim();
                Guest guest = new Guest(forename, surname, txtEmail.Text, txtMobileNumber.Text, txtAdd1.Text, txtCityTown.Text, txtPostcode.Text, cmbCountry.Text, id);
                LakesideDAL dal = new LakesideDAL();
                dal.UpdateGuest(guest);
                MessageBox.Show("Guest edited successfully!");
                Hide();
                new frmSearchGuests(cachedSearch).Show();
            }
            else if (newMode && CheckValidation())
            {
                string[] names = txtFullName.Text.Trim().Split(' ');
                string forename = "";
                string givenName = names[0];
                string surname = names[names.Length - 1];
                for (int i = 0; i < names.Length - 1; i++)
                {
                    forename += names[i] + " ";
                }
                forename = forename.Trim();
                surname = surname.Trim();
                givenName = givenName.Trim();
                Staff staff = new Staff(forename, surname, txtEmail.Text, txtMobileNumber.Text, txtAdd1.Text, txtCityTown.Text, txtPostcode.Text, cmbCountry.Text, -1, txtPosition.Text);
                StaffDAL dal = new StaffDAL();
                dal.AddNewStaff(staff);
                MessageBox.Show("Staff added successfully!");
                //ClearAllFields();
                //EnableAllFields();
                Hide();
                new frmAddGuest().Show();
            }
            else if(staffMode && CheckValidation())
            {
                //Edit current staff
                string[] names = txtFullName.Text.Trim().Split(' ');
                string forename = "";
                string givenName = names[0];
                string surname = names[names.Length - 1];
                for (int i = 0; i < names.Length - 1; i++)
                {
                    forename += names[i] + " ";
                }
                forename = forename.Trim();
                surname = surname.Trim();
                givenName = givenName.Trim();
                Staff staff = new Staff(forename, surname, txtEmail.Text, txtMobileNumber.Text, txtAdd1.Text, txtCityTown.Text, txtPostcode.Text, cmbCountry.Text, id, txtPosition.Text);
                StaffDAL dal = new StaffDAL();
                dal.UpdateStaff(staff);
                MessageBox.Show("Staff edited successfully!");
                Hide();
                new frmSearchGuests(staff,cachedSearch).Show();
            }
            else
            {
                //INVALID DATA
                MessageBox.Show("Sorry. You have invalid data in the form. Please correct this in order to do this!", "Invalid Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableAllFields();
                validTotal = true;
            }
            UseWaitCursor = false;
        }

        private void ClearAllFields()
        {
            txtFullName.Text = "";
            txtAdd1.Text = "";
            txtCityTown.Text = "";
            txtPostcode.Text = "";
            txtMobileNumber.Text = "";
            txtEmail.Text = "";
            txtPosition.Text = "";
        }
        private void DisableAllFields()
        {
            txtFullName.Enabled = false;
            txtEmail.Enabled = false;
            txtCityTown.Enabled = false;
            txtAdd1.Enabled = false;
            txtMobileNumber.Enabled = false;
            txtPostcode.Enabled = false;
            txtPosition.Enabled = false;
        }
        private void EnableAllFields()
        {
            txtFullName.Enabled = true;
            txtEmail.Enabled = true;
            txtCityTown.Enabled = true;
            txtAdd1.Enabled = true;
            txtMobileNumber.Enabled = true;
            txtPostcode.Enabled = true;
            txtPosition.Enabled = true;
        }

        private void ValidSetter(int elementID)
        {
            Control changeColour = null;
            Label errorDisplay = null;
            string msg = null;
            switch (elementID)
            {
                case 0:
                    changeColour = txtFullName;
                    errorDisplay = validFullName;
                    msg=Validation.Name(changeColour.Text);
                    break;
                case 1:
                    changeColour = txtEmail;
                    errorDisplay = validEmail;
                    msg=Validation.Email(changeColour.Text);
                    break;
                case 2:
                    changeColour = txtMobileNumber;
                    errorDisplay = validNumber;
                    msg=Validation.PhoneNumber(changeColour.Text);
                    break;
                case 3:
                    changeColour = txtAdd1;
                    errorDisplay = validAdd1;
                    msg=Validation.OtherText(changeColour.Text, "address", 45);
                    break;
                case 4:
                    changeColour = txtPostcode;
                    errorDisplay = validPostcode;
                    msg=Validation.UKPostcode(changeColour.Text);
                    break;
                case 5:
                    changeColour = txtCityTown;
                    errorDisplay = validCityTown;
                    if (changeColour.Text.Length > 0)
                        msg = Validation.UKCityTown(Char.ToUpper(changeColour.Text[0]) + changeColour.Text.Substring(1));
                    else
                        msg = Validation.UKCityTown(changeColour.Text);
                    break;
                case 6:
                    changeColour = cmbCountry;
                    errorDisplay = validCountry;
                    //msg=Validation.Country(changeColour.Text);
                    break;
                case 7:
                    changeColour = txtPosition;
                    errorDisplay = validPosition;
                    msg = Validation.OtherText(changeColour.Text, "Position", 45);
                    break;
            }
            if(msg==null)
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
            for(int i=0; i<allValid.Length-1; i++)
            {
                if (!allValid[i])
                    validTotal = false;
            }
            return validTotal;
        }

        private void frmAddGuest_Load(object sender, EventArgs e)
        {
            newMode = true;
            
            CenterToScreen();
            cmbCountry.DataSource = GetCountryList();
            cmbCountry.Text = "United Kingdom";
            cmbPhoneNumberPrefix.Text = "+44";
            validAdd1.Text = "";
            validCityTown.Text = "";
            validCountry.Text = "";
            validEmail.Text = "";
            validFullName.Text = "";
            validNumber.Text = "";
            validPostcode.Text = "";
            validPosition.Text = "";
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            try
            {
                string[] names = txtFullName.Text.Trim().Split(' ');
                string fullName = "";
                for (int i = 0; i < names.Length; i++)
                {
                    names[i] = names[i].Trim();
                    names[i] = Char.ToUpper(names[i][0]) + names[i].Substring(1);
                    fullName += names[i] + " ";
                }
                txtFullName.Text = fullName.Trim();
                ValidSetter(0);
            }
            catch
            {
                ValidSetter(0);
            }
        }

        private void llbPostcodeFormat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Ask user if they want to change the format
            if(MessageBox.Show("Although most do, some UK Postcodes don't fit this format.\r\nClick \"Yes\" to change the format.", "Change Postcode Format", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtPostcode.Mask = null;
                //llbPostcodeFormat.Text = "Change to UK Postcode Format";
                llbPostcodeFormat.Visible = false;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(1);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if(newMode)
            {
                Hide();
                new frmHome().Show();
            }
            else if(!staffMode)
            {
                Hide();
                new frmSearchGuests(cachedSearch).Show();
            }
            else
            {
                Staff tmp = new Staff();
                Hide();
                new frmSearchGuests(tmp, cachedSearch).Show();
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(0);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            ValidSetter(1);
        }

        private void txtMobileNumber_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(2);
        }

        private void txtMobileNumber_Leave(object sender, EventArgs e)
        {
            ValidSetter(2);
        }

        private void txtAdd1_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(3);
        }

        private void txtAdd1_Leave(object sender, EventArgs e)
        {
            ValidSetter(3);
        }

        private void txtPostcode_Leave(object sender, EventArgs e)
        {
            ValidSetter(4);
        }

        private void txtPostcode_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(4);
        }

        private void txtCityTown_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(5);
        }

        private void txtCityTown_Leave(object sender, EventArgs e)
        {
            txtCityTown.Text = txtCityTown.Text.Trim();
            if(txtCityTown.Text.Length>0)
                txtCityTown.Text = Char.ToUpper(txtCityTown.Text[0]) + txtCityTown.Text.Substring(1);
            ValidSetter(5);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            Hide();
            new frmAddGuest().Show();
        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(7);
        }

        private void txtPosition_Leave(object sender, EventArgs e)
        {
            ValidSetter(7);
        }
    }
}
