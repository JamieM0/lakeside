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
    public partial class frmAddExtra : Form
    {
        bool[] allValid = new bool[3];
        bool newMode = true;
        string cachedSearch = "";
        
        public frmAddExtra()
        {
            InitializeComponent();
        }
        public frmAddExtra(Extra ex, string cache)
        {
            InitializeComponent();
            cachedSearch = cache;
            newMode = false;
            txtExtraName.Text = ex.ExtraName;
            txtPricePPPN.Text = ex.Price.ToString();
            txtDescription.Text = ex.Description;

        }

        private void frmAddExtra_Load(object sender, EventArgs e)
        {
            validDescription.Text = "";
            validExtraName.Text = "";
            validPricePPPN.Text = "";
        }

        private void ValidSetter(int elementID)
        {
            Control changeColour = null;
            Label errorDisplay = null;
            string msg = null;
            switch (elementID)
            {
                case 0:
                    changeColour = txtExtraName;
                    errorDisplay = validExtraName;
                    msg = Validation.OtherText(changeColour.Text, "Extra name", 45);
                    break;
                case 1:
                    changeColour = txtDescription;
                    errorDisplay = validDescription;
                    msg = Validation.OtherText(changeColour.Text, "Extra description", 50);
                    break;
                case 2:
                    changeColour = txtPricePPPN;
                    errorDisplay = validPricePPPN;
                    msg = Validation.Money(changeColour.Text);
                    break;
            }
            if (msg == null)
                Validator(elementID, changeColour, errorDisplay, msg);
            else
                Invalidator(elementID, changeColour, errorDisplay, msg);
        }
        private void Invalidator(int elementID, Control changeColour, Label errorDisplay, string msg)
        {
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

        private void txtExtraName_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(0);
        }

        private void txtExtraName_Leave(object sender, EventArgs e)
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

        private void txtPricePPPN_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(2);
        }

        private void txtPricePPPN_Leave(object sender, EventArgs e)
        {
            ValidSetter(2);
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (newMode && CheckValidation())
                {
                    Extra newExtra = new Extra(0, txtExtraName.Text, txtDescription.Text, Convert.ToDouble(txtPricePPPN.Text));

                    ExtraDAL dal = new ExtraDAL();

                    if (dal.AddNewExtra(newExtra))
                    {
                        MessageBox.Show("Extra added successfully");
                        Hide();
                        new frmAddExtra().Show();
                    }
                }
                else if (!newMode && CheckValidation())
                {
                    Extra newExtra = new Extra(0, txtExtraName.Text, txtDescription.Text, Convert.ToDouble(txtPricePPPN.Text));

                    ExtraDAL dal = new ExtraDAL();

                    if (dal.UpdateExtra(newExtra))
                    {
                        MessageBox.Show("Extra updated successfully");
                        Hide();
                        new frmAddExtra().Show();
                    }
                }
                else
                {
                    MessageBox.Show("There are errors in the form! Please correct them.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validTotal = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was an error adding the extra!\r\nMore Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
            new frmHome().Show();
        }
    }
}
