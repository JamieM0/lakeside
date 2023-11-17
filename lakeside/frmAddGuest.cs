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

namespace lakeside
{
    public partial class frmAddGuest : Form
    {
        public frmAddGuest()
        {
            InitializeComponent();
            CenterToScreen();
            cmbCountry.DataSource = GetCountryList();
            cmbCountry.Text = "United Kingdom";
            cmbPhoneNumberPrefix.Text = "+44";
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
            string[] names = txtFullName.Text.Trim().Split(' ');
            string forename = "";
            string givenName = names[0];
            string surname = names[names.Length - 1];
            for (int i = 0; i < names.Length - 1; i++)
            {
                forename += names[i] + " ";
            }
            forename.Trim();
            surname.Trim();
            givenName.Trim();
            Guest guest = new Guest(forename, surname, txtEmail.Text, txtMobileNumber.Text, txtAdd1.Text, txtCityTown.Text, txtPostcode.Text, cmbCountry.Text);
            LakesideDAL dal = new LakesideDAL();
            dal.AddNewGuest(guest);
            MessageBox.Show("Guest added successfully!");
            ClearAllFields();
            EnableAllFields();
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

        private void frmAddGuest_Load(object sender, EventArgs e)
        {

        }
    }
}
