using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lakeside;
using lakeside.DAL;
using lakeside.Models;

namespace lakeside
{
    public partial class frmAddPod : Form
    {
        bool[] allValid = new bool[6];
        int podsStandard = 0;
        int podsLuxury = 0;
        bool newPod = true;
        int podID = 0;
        string cachedSearch = "";
        string editType = "";

        public frmAddPod()
        {
            InitializeComponent();
        }

        public frmAddPod(Pod edit, string search)
        {
            InitializeComponent();
            //lbTitle.Text = "Edit a Pod";
            //this.Text = "Lakeside Escapes: Edit a Pod";
            txtFriendlyName.Text = edit.FriendlyName;
            txtDescription.Text = edit.Description;
            cmbType.Text = edit.Type;
            editType = edit.Type;
            cmbPodLocation.Text = edit.Location;
            txtPricePPPN.Text = edit.Price.ToString();
            txtCapacity.Text = edit.Capacity.ToString();
            podID = edit.PodID;
            newPod = false;
            cachedSearch = search;
            btnAddPod.BackgroundImage = Properties.Resources.EditPodButton;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
            new frmHome().Show();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            Hide();
            new frmAddPod().Show();
        }

        private void GetPods()
        {
            
        }

        private void btnAddPod_Click(object sender, EventArgs e)
        {
            if(newPod && CheckValidation())
            {
                try
                {
                    Pod p = new Pod(txtFriendlyName.Text, txtDescription.Text, Double.Parse(txtPricePPPN.Text), Convert.ToInt32(txtCapacity.Text), cmbType.Text, cmbPodLocation.Text, 0);
                    PodDAL dal = new PodDAL();
                    if (dal.AddNewPod(p))
                    {
                        MessageBox.Show("Pod added successfully!");
                        Hide();
                        new frmAddPod().Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sorry, there was a problem adding the pod. Please try again later.\r\nMore Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (CheckValidation())
            {
                try
                {
                    Pod p = new Pod(txtFriendlyName.Text, txtDescription.Text, Double.Parse(txtPricePPPN.Text), Convert.ToInt32(txtCapacity.Text), cmbType.Text, cmbPodLocation.Text, podID);
                    PodDAL dal = new PodDAL();
                    if(dal.UpdatePod(p))
                    {
                        MessageBox.Show("Pod updated successfully!");
                        Hide();
                        new frmSearchGuests(p, cachedSearch).Show();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Sorry, there was a problem updating the pod. Please try again later.\r\nMore Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("There are errors in the form! Please correct them.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validTotal = true;
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
                    changeColour = txtFriendlyName;
                    errorDisplay = validFriendlyName;
                    msg = Validation.OtherText(changeColour.Text, "Name", 45);
                    break;
                case 1:
                    changeColour = txtDescription;
                    errorDisplay = validDescription;
                    msg = Validation.OtherText(changeColour.Text, "Desctiption", 50);
                    break;
                case 2:
                    changeColour = txtPricePPPN;
                    errorDisplay = validPricePPPN;
                    msg = Validation.Money(changeColour.Text);
                    break;
                case 3:
                    changeColour = cmbType;
                    errorDisplay = validType;
                    if (editType == "Standard" || editType == "standard")
                        podsStandard--;
                    else
                        podsLuxury--;
                    msg = Validation.PodType(changeColour.Text, podsStandard, podsLuxury);
                    break;
                case 4:
                    changeColour = txtCapacity;
                    errorDisplay = validCapacity;
                    msg = Validation.NumberRange(changeColour.Text, 0, 100, "Capacity");
                    break;
                case 5:
                    changeColour = cmbPodLocation;
                    errorDisplay = validPodLocation;
                    msg = Validation.OtherText(changeColour.Text, "Location", 45);
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

        private void frmAddPod_Load(object sender, EventArgs e)
        {
            //cmbType.Text = "Standard";
            CenterToScreen();
            validCapacity.Text = "";
            validDescription.Text = "";
            validFriendlyName.Text = "";
            validPodLocation.Text = "";
            validPricePPPN.Text = "";
            validType.Text = "";

            PodDAL dalP = new PodDAL();
            podsStandard = dalP.CountPods("Standard");
            podsLuxury = dalP.CountPods("Luxury");
        }

        private void txtFriendlyName_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(0);
        }

        private void txtFriendlyName_Leave(object sender, EventArgs e)
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

        private void cmbType_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(3);
            if (cmbType.Text == "Standard")
                txtCapacity.Text = "4";
            else if (cmbType.Text == "Luxury")
                txtCapacity.Text = "6";
        }

        private void cmbType_Leave(object sender, EventArgs e)
        {
            ValidSetter(3);
            if (cmbType.Text == "Standard")
                txtCapacity.Text = "4";
            else if (cmbType.Text == "Luxury")
                txtCapacity.Text = "6";
        }

        private void txtCapacity_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(4);
        }

        private void txtCapacity_Leave(object sender, EventArgs e)
        {
            ValidSetter(4);
        }

        private void cmbPodLocation_TextChanged(object sender, EventArgs e)
        {
            ValidSetter(5);
        }

        private void cmbPodLocation_Leave(object sender, EventArgs e)
        {
            ValidSetter(5);
        }

        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFriendlyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
