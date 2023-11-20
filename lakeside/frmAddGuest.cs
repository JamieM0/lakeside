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
using System.Xml.Linq;

namespace lakeside
{
    public partial class frmAddGuest : Form
    {
        bool newMode = true;
        string cachedSearch = "";
        int id = 0;
        bool[] allValid = new bool[7];

        public frmAddGuest()
        {
            newMode = true;
            InitializeComponent();
            CenterToScreen();
            cmbCountry.DataSource = GetCountryList();
            cmbCountry.Text = "United Kingdom";
            cmbPhoneNumberPrefix.Text = "+44";
        }

        public frmAddGuest(Guest edit, string search)
        {
            cachedSearch = search;
            newMode = false;
            InitializeComponent();
            CenterToScreen();
            cmbCountry.DataSource = GetCountryList();
            cmbCountry.Text = "United Kingdom";
            cmbPhoneNumberPrefix.Text = "+44";
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
            Random rnd = new Random();
            string[] subject = data[rnd.Next(1, data.Length)].Split(',');
            txtFullName.Text = subject[0] + " " + subject[1];
            txtAdd1.Text = subject[2];
            txtCityTown.Text = subject[3];
            txtPostcode.Text = subject[4];
            txtMobileNumber.Text = subject[5].Substring(1,subject[5].Length-1);
            txtEmail.Text = subject[6];
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            DisableAllFields();
            if(newMode)
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
                ClearAllFields();
                EnableAllFields();
            }
            else
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
        }

        private void ClearAllFields()
        {
            txtFullName.Text = "";
            txtAdd1.Text = "";
            txtCityTown.Text = "";
            txtPostcode.Text = "";
            txtMobileNumber.Text = "";
            txtEmail.Text = "";
        }
        private void DisableAllFields()
        {
            txtFullName.Enabled = false;
            txtEmail.Enabled = false;
            txtCityTown.Enabled = false;
            txtAdd1.Enabled = false;
            txtMobileNumber.Enabled = false;
            txtPostcode.Enabled = false;
        }
        private void EnableAllFields()
        {
            txtFullName.Enabled = true;
            txtEmail.Enabled = true;
            txtCityTown.Enabled = true;
            txtAdd1.Enabled = true;
            txtMobileNumber.Enabled = true;
            txtPostcode.Enabled = true;
        }

        private void Invalidator(int elementID, Control changeColour, Label errorDisplay, string msg)
        {
            //elementID: 0-Name, 1-Email, 2-PhoneNumber, 3-Street, 4-Postcode, 5-Town, 6-Country
            //Lakeside.Notifier()
            changeColour.BackColor = Color.LightCoral;
            errorDisplay.Text = msg;
            allValid[id] = false;
        }
        private void Validator(int elementID, Control changeColour, Label errorDisplay, string msg)
        {
            changeColour.BackColor = Color.White;
            errorDisplay.Text = "";
            allValid[id] = true;
        }

        private void frmAddGuest_Load(object sender, EventArgs e)
        {
            validAdd1.Text = "";
            validCityTown.Text = "";
            validCountry.Text = "";
            validEmail.Text = "";
            validFullName.Text = "";
            validNumber.Text = "";
            validPostcode.Text = "";
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validation.Name(Char.ToString(e.KeyChar))==null && !Char.IsControl(e.KeyChar))
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
                string errMsg = Validation.Name(txtFullName.Text);
                if (errMsg == null)
                    Validator(0, txtFullName, validFullName, errMsg);
                else
                    Invalidator(0,txtFullName,validFullName,errMsg);
            }
            catch
            {
                
            }
        }

        private void llbPostcodeFormat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Ask user if they want to change the format
            if(MessageBox.Show("Although most do, some UK Postcodes don't fit this format.\r\nClick \"Yes\" to change the format.", "Change Postcode Format", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtPostcode.Mask = null;
                llbPostcodeFormat.Text = "Change to UK Postcode Format";
            }
            
            //if(llbPostcodeFormat.Text== "Change to UK Postcode Format")
            //{
            //    txtPostcode.Mask = "LL00 0LL";
            //    llbPostcodeFormat.Text = "Change Postcode Format";
            //}
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string errMsg = Validation.Email(txtEmail.Text);
            if (errMsg == null)
                Validator(1, txtEmail, validEmail, errMsg);
            else
                Invalidator(1, txtEmail, validEmail, errMsg);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if(newMode)
            {
                Hide();
                new frmHome().Show();
            }
            else
            {
                Hide();
                new frmSearchGuests(cachedSearch).Show();
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            string errMsg = Validation.Name(txtFullName.Text.Trim());
            if (errMsg == null)
                Validator(0, txtFullName, validFullName, errMsg);
            else
                Invalidator(0, txtFullName, validFullName, errMsg);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string errMsg = Validation.Email(txtEmail.Text);
            if (errMsg == null)
                Validator(1, txtEmail, validEmail, errMsg);
            else
                Invalidator(1, txtEmail, validEmail, errMsg);
        }
    }
}
