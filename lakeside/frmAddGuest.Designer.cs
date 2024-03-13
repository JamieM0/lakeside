
namespace lakeside
{
    partial class frmAddGuest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbMobileNumber = new System.Windows.Forms.Label();
            this.lbAdd1 = new System.Windows.Forms.Label();
            this.lbCityTown = new System.Windows.Forms.Label();
            this.lbPostcode = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.llbPostcodeFormat = new System.Windows.Forms.LinkLabel();
            this.validFullName = new System.Windows.Forms.Label();
            this.validEmail = new System.Windows.Forms.Label();
            this.validNumber = new System.Windows.Forms.Label();
            this.validAdd1 = new System.Windows.Forms.Label();
            this.validPostcode = new System.Windows.Forms.Label();
            this.validCityTown = new System.Windows.Forms.Label();
            this.validCountry = new System.Windows.Forms.Label();
            this.validPosition = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.txtFullName = new lakeside.ValidationTextBox();
            this.txtPosition = new lakeside.ValidationTextBox();
            this.cmbPhoneNumberPrefix = new lakeside.ValidationComboBox();
            this.txtMobileNumber = new lakeside.ValidationTextBox();
            this.cmbCountry = new lakeside.ValidationComboBox();
            this.txtPostcode = new lakeside.ValidationMaskedTextBox();
            this.txtCityTown = new lakeside.ValidationTextBox();
            this.txtAdd1 = new lakeside.ValidationTextBox();
            this.txtEmail = new lakeside.ValidationTextBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.btnRandomiseData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(437, 20);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(162, 37);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Add a Guest";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.BackColor = System.Drawing.Color.Transparent;
            this.lbFullName.Location = new System.Drawing.Point(26, 94);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(112, 30);
            this.lbFullName.TabIndex = 1;
            this.lbFullName.Text = "Full Name:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Location = new System.Drawing.Point(60, 169);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(68, 30);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email:";
            // 
            // lbMobileNumber
            // 
            this.lbMobileNumber.AutoSize = true;
            this.lbMobileNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbMobileNumber.Location = new System.Drawing.Point(528, 169);
            this.lbMobileNumber.Name = "lbMobileNumber";
            this.lbMobileNumber.Size = new System.Drawing.Size(164, 30);
            this.lbMobileNumber.TabIndex = 3;
            this.lbMobileNumber.Text = "Mobile Number:";
            // 
            // lbAdd1
            // 
            this.lbAdd1.AutoSize = true;
            this.lbAdd1.BackColor = System.Drawing.Color.Transparent;
            this.lbAdd1.Location = new System.Drawing.Point(26, 271);
            this.lbAdd1.Name = "lbAdd1";
            this.lbAdd1.Size = new System.Drawing.Size(242, 30);
            this.lbAdd1.TabIndex = 4;
            this.lbAdd1.Text = "Street Name (Address 1):";
            // 
            // lbCityTown
            // 
            this.lbCityTown.AutoSize = true;
            this.lbCityTown.BackColor = System.Drawing.Color.Transparent;
            this.lbCityTown.Location = new System.Drawing.Point(139, 341);
            this.lbCityTown.Name = "lbCityTown";
            this.lbCityTown.Size = new System.Drawing.Size(121, 30);
            this.lbCityTown.TabIndex = 5;
            this.lbCityTown.Text = "City / Town:";
            // 
            // lbPostcode
            // 
            this.lbPostcode.AutoSize = true;
            this.lbPostcode.BackColor = System.Drawing.Color.Transparent;
            this.lbPostcode.Location = new System.Drawing.Point(680, 270);
            this.lbPostcode.Name = "lbPostcode";
            this.lbPostcode.Size = new System.Drawing.Size(102, 30);
            this.lbPostcode.TabIndex = 6;
            this.lbPostcode.Text = "Postcode:";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.BackColor = System.Drawing.Color.Transparent;
            this.lbCountry.Location = new System.Drawing.Point(686, 345);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(91, 30);
            this.lbCountry.TabIndex = 7;
            this.lbCountry.Text = "Country:";
            // 
            // llbPostcodeFormat
            // 
            this.llbPostcodeFormat.AutoSize = true;
            this.llbPostcodeFormat.BackColor = System.Drawing.Color.Transparent;
            this.llbPostcodeFormat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbPostcodeFormat.Location = new System.Drawing.Point(897, 288);
            this.llbPostcodeFormat.Name = "llbPostcodeFormat";
            this.llbPostcodeFormat.Size = new System.Drawing.Size(155, 17);
            this.llbPostcodeFormat.TabIndex = 10;
            this.llbPostcodeFormat.TabStop = true;
            this.llbPostcodeFormat.Text = "Change Postcode Format";
            this.llbPostcodeFormat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbPostcodeFormat_LinkClicked);
            // 
            // validFullName
            // 
            this.validFullName.AutoSize = true;
            this.validFullName.BackColor = System.Drawing.Color.Transparent;
            this.validFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validFullName.ForeColor = System.Drawing.Color.Red;
            this.validFullName.Location = new System.Drawing.Point(140, 131);
            this.validFullName.Name = "validFullName";
            this.validFullName.Size = new System.Drawing.Size(52, 21);
            this.validFullName.TabIndex = 11;
            this.validFullName.Text = "label1";
            // 
            // validEmail
            // 
            this.validEmail.AutoSize = true;
            this.validEmail.BackColor = System.Drawing.Color.Transparent;
            this.validEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validEmail.ForeColor = System.Drawing.Color.Red;
            this.validEmail.Location = new System.Drawing.Point(140, 206);
            this.validEmail.Name = "validEmail";
            this.validEmail.Size = new System.Drawing.Size(52, 21);
            this.validEmail.TabIndex = 13;
            this.validEmail.Text = "label1";
            // 
            // validNumber
            // 
            this.validNumber.AutoSize = true;
            this.validNumber.BackColor = System.Drawing.Color.Transparent;
            this.validNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validNumber.ForeColor = System.Drawing.Color.Red;
            this.validNumber.Location = new System.Drawing.Point(787, 206);
            this.validNumber.Name = "validNumber";
            this.validNumber.Size = new System.Drawing.Size(52, 21);
            this.validNumber.TabIndex = 14;
            this.validNumber.Text = "label2";
            // 
            // validAdd1
            // 
            this.validAdd1.AutoSize = true;
            this.validAdd1.BackColor = System.Drawing.Color.Transparent;
            this.validAdd1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validAdd1.ForeColor = System.Drawing.Color.Red;
            this.validAdd1.Location = new System.Drawing.Point(270, 308);
            this.validAdd1.Name = "validAdd1";
            this.validAdd1.Size = new System.Drawing.Size(52, 21);
            this.validAdd1.TabIndex = 15;
            this.validAdd1.Text = "label3";
            // 
            // validPostcode
            // 
            this.validPostcode.AutoSize = true;
            this.validPostcode.BackColor = System.Drawing.Color.Transparent;
            this.validPostcode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validPostcode.ForeColor = System.Drawing.Color.Red;
            this.validPostcode.Location = new System.Drawing.Point(781, 307);
            this.validPostcode.Name = "validPostcode";
            this.validPostcode.Size = new System.Drawing.Size(52, 21);
            this.validPostcode.TabIndex = 16;
            this.validPostcode.Text = "label4";
            // 
            // validCityTown
            // 
            this.validCityTown.AutoSize = true;
            this.validCityTown.BackColor = System.Drawing.Color.Transparent;
            this.validCityTown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validCityTown.ForeColor = System.Drawing.Color.Red;
            this.validCityTown.Location = new System.Drawing.Point(270, 382);
            this.validCityTown.Name = "validCityTown";
            this.validCityTown.Size = new System.Drawing.Size(52, 21);
            this.validCityTown.TabIndex = 17;
            this.validCityTown.Text = "label5";
            // 
            // validCountry
            // 
            this.validCountry.AutoSize = true;
            this.validCountry.BackColor = System.Drawing.Color.Transparent;
            this.validCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validCountry.ForeColor = System.Drawing.Color.Red;
            this.validCountry.Location = new System.Drawing.Point(787, 382);
            this.validCountry.Name = "validCountry";
            this.validCountry.Size = new System.Drawing.Size(52, 21);
            this.validCountry.TabIndex = 18;
            this.validCountry.Text = "label6";
            // 
            // validPosition
            // 
            this.validPosition.AutoSize = true;
            this.validPosition.BackColor = System.Drawing.Color.Transparent;
            this.validPosition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validPosition.ForeColor = System.Drawing.Color.Red;
            this.validPosition.Location = new System.Drawing.Point(787, 135);
            this.validPosition.Name = "validPosition";
            this.validPosition.Size = new System.Drawing.Size(52, 21);
            this.validPosition.TabIndex = 22;
            this.validPosition.Text = "label5";
            this.validPosition.Visible = false;
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.BackColor = System.Drawing.Color.Transparent;
            this.lbPosition.Location = new System.Drawing.Point(693, 95);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(91, 30);
            this.lbPosition.TabIndex = 21;
            this.lbPosition.Text = "Position:";
            this.lbPosition.Visible = false;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(144, 95);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(316, 33);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            this.txtFullName.Leave += new System.EventHandler(this.txtFullName_Leave);
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(785, 95);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(221, 33);
            this.txtPosition.TabIndex = 20;
            this.txtPosition.Visible = false;
            this.txtPosition.TextChanged += new System.EventHandler(this.txtPosition_TextChanged);
            this.txtPosition.Leave += new System.EventHandler(this.txtPosition_Leave);
            // 
            // cmbPhoneNumberPrefix
            // 
            this.cmbPhoneNumberPrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhoneNumberPrefix.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPhoneNumberPrefix.FormattingEnabled = true;
            this.cmbPhoneNumberPrefix.Items.AddRange(new object[] {
            "+44"});
            this.cmbPhoneNumberPrefix.Location = new System.Drawing.Point(698, 170);
            this.cmbPhoneNumberPrefix.Name = "cmbPhoneNumberPrefix";
            this.cmbPhoneNumberPrefix.Size = new System.Drawing.Size(81, 33);
            this.cmbPhoneNumberPrefix.TabIndex = 8;
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNumber.Location = new System.Drawing.Point(785, 170);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(221, 33);
            this.txtMobileNumber.TabIndex = 2;
            this.txtMobileNumber.TextChanged += new System.EventHandler(this.txtMobileNumber_TextChanged);
            this.txtMobileNumber.Leave += new System.EventHandler(this.txtMobileNumber_Leave);
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(785, 342);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(221, 33);
            this.cmbCountry.TabIndex = 6;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.Location = new System.Drawing.Point(785, 271);
            this.txtPostcode.Mask = "LL00 0LL";
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(100, 33);
            this.txtPostcode.TabIndex = 5;
            this.txtPostcode.TextChanged += new System.EventHandler(this.txtPostcode_TextChanged);
            this.txtPostcode.Leave += new System.EventHandler(this.txtPostcode_Leave);
            // 
            // txtCityTown
            // 
            this.txtCityTown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCityTown.Location = new System.Drawing.Point(274, 342);
            this.txtCityTown.Name = "txtCityTown";
            this.txtCityTown.Size = new System.Drawing.Size(369, 33);
            this.txtCityTown.TabIndex = 4;
            this.txtCityTown.TextChanged += new System.EventHandler(this.txtCityTown_TextChanged);
            this.txtCityTown.Leave += new System.EventHandler(this.txtCityTown_Leave);
            // 
            // txtAdd1
            // 
            this.txtAdd1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd1.Location = new System.Drawing.Point(274, 272);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(369, 33);
            this.txtAdd1.TabIndex = 3;
            this.txtAdd1.TextChanged += new System.EventHandler(this.txtAdd1_TextChanged);
            this.txtAdd1.Leave += new System.EventHandler(this.txtAdd1_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(144, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(316, 33);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearAll.Image = global::lakeside.Properties.Resources.returnIcon;
            this.btnClearAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearAll.Location = new System.Drawing.Point(786, 9);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(256, 65);
            this.btnClearAll.TabIndex = 19;
            this.btnClearAll.Text = "Clear All Fields";
            this.btnClearAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReturn.Image = global::lakeside.Properties.Resources.returnIcon;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(12, 9);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(256, 65);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return to Home";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.BackgroundImage = global::lakeside.Properties.Resources.AddGuestButton;
            this.btnAddGuest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddGuest.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGuest.Location = new System.Drawing.Point(820, 415);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(222, 60);
            this.btnAddGuest.TabIndex = 9;
            this.btnAddGuest.UseVisualStyleBackColor = true;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // btnRandomiseData
            // 
            this.btnRandomiseData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRandomiseData.Image = global::lakeside.Properties.Resources.dice2;
            this.btnRandomiseData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRandomiseData.Location = new System.Drawing.Point(12, 415);
            this.btnRandomiseData.Name = "btnRandomiseData";
            this.btnRandomiseData.Size = new System.Drawing.Size(222, 60);
            this.btnRandomiseData.TabIndex = 7;
            this.btnRandomiseData.Text = "Randomise Data";
            this.btnRandomiseData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRandomiseData.UseVisualStyleBackColor = true;
            this.btnRandomiseData.Click += new System.EventHandler(this.btnRandomiseData_Click);
            // 
            // frmAddGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lakeside.Properties.Resources.Gradient_Guest2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 487);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.validPosition);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.validCountry);
            this.Controls.Add(this.validCityTown);
            this.Controls.Add(this.validPostcode);
            this.Controls.Add(this.validAdd1);
            this.Controls.Add(this.validNumber);
            this.Controls.Add(this.validEmail);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.validFullName);
            this.Controls.Add(this.llbPostcodeFormat);
            this.Controls.Add(this.btnAddGuest);
            this.Controls.Add(this.cmbPhoneNumberPrefix);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtCityTown);
            this.Controls.Add(this.txtAdd1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnRandomiseData);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbPostcode);
            this.Controls.Add(this.lbCityTown);
            this.Controls.Add(this.lbAdd1);
            this.Controls.Add(this.lbMobileNumber);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmAddGuest";
            this.Text = "Lakeside Escapes: Add a Guest";
            this.Load += new System.EventHandler(this.frmAddGuest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbMobileNumber;
        private System.Windows.Forms.Label lbAdd1;
        private System.Windows.Forms.Label lbCityTown;
        private System.Windows.Forms.Label lbPostcode;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Button btnRandomiseData;
        private lakeside.ValidationTextBox txtFullName;
        private lakeside.ValidationTextBox txtEmail;
        private lakeside.ValidationTextBox txtAdd1;
        private lakeside.ValidationTextBox txtCityTown;
        private lakeside.ValidationMaskedTextBox txtPostcode;
        private lakeside.ValidationComboBox cmbCountry;
        private lakeside.ValidationTextBox txtMobileNumber;
        private lakeside.ValidationComboBox cmbPhoneNumberPrefix;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.LinkLabel llbPostcodeFormat;
        private System.Windows.Forms.Label validFullName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label validEmail;
        private System.Windows.Forms.Label validNumber;
        private System.Windows.Forms.Label validAdd1;
        private System.Windows.Forms.Label validPostcode;
        private System.Windows.Forms.Label validCityTown;
        private System.Windows.Forms.Label validCountry;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label validPosition;
        private ValidationTextBox txtPosition;
        private System.Windows.Forms.Label lbPosition;
    }
}