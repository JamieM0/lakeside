
namespace lakeside
{
    partial class frmAddPod
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
            this.btnClearAll = new System.Windows.Forms.Button();
            this.validType = new System.Windows.Forms.Label();
            this.validPodLocation = new System.Windows.Forms.Label();
            this.validCapacity = new System.Windows.Forms.Label();
            this.validPricePPPN = new System.Windows.Forms.Label();
            this.validDescription = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.validFriendlyName = new System.Windows.Forms.Label();
            this.btnAddPod = new System.Windows.Forms.Button();
            this.txtPricePPPN = new lakeside.ValidationTextBox();
            this.cmbType = new lakeside.ValidationComboBox();
            this.txtCapacity = new lakeside.ValidationTextBox();
            this.txtDescription = new lakeside.ValidationTextBox();
            this.txtFriendlyName = new lakeside.ValidationTextBox();
            this.btnRandomiseData = new System.Windows.Forms.Button();
            this.lbType = new System.Windows.Forms.Label();
            this.lbPodLocation = new System.Windows.Forms.Label();
            this.lbCapacity = new System.Windows.Forms.Label();
            this.lbPricePPPN = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbFriendlyName = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.cmbPodLocation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearAll.Image = global::lakeside.Properties.Resources.returnIcon;
            this.btnClearAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearAll.Location = new System.Drawing.Point(597, 18);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(256, 65);
            this.btnClearAll.TabIndex = 47;
            this.btnClearAll.Text = "Clear All Fields";
            this.btnClearAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // validType
            // 
            this.validType.AutoSize = true;
            this.validType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validType.ForeColor = System.Drawing.Color.Red;
            this.validType.Location = new System.Drawing.Point(175, 294);
            this.validType.Name = "validType";
            this.validType.Size = new System.Drawing.Size(52, 21);
            this.validType.TabIndex = 46;
            this.validType.Text = "label6";
            // 
            // validPodLocation
            // 
            this.validPodLocation.AutoSize = true;
            this.validPodLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validPodLocation.ForeColor = System.Drawing.Color.Red;
            this.validPodLocation.Location = new System.Drawing.Point(175, 387);
            this.validPodLocation.Name = "validPodLocation";
            this.validPodLocation.Size = new System.Drawing.Size(52, 21);
            this.validPodLocation.TabIndex = 45;
            this.validPodLocation.Text = "label5";
            // 
            // validCapacity
            // 
            this.validCapacity.AutoSize = true;
            this.validCapacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validCapacity.ForeColor = System.Drawing.Color.Red;
            this.validCapacity.Location = new System.Drawing.Point(744, 294);
            this.validCapacity.Name = "validCapacity";
            this.validCapacity.Size = new System.Drawing.Size(52, 21);
            this.validCapacity.TabIndex = 43;
            this.validCapacity.Text = "label3";
            // 
            // validPricePPPN
            // 
            this.validPricePPPN.AutoSize = true;
            this.validPricePPPN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validPricePPPN.ForeColor = System.Drawing.Color.Red;
            this.validPricePPPN.Location = new System.Drawing.Point(744, 215);
            this.validPricePPPN.Name = "validPricePPPN";
            this.validPricePPPN.Size = new System.Drawing.Size(52, 21);
            this.validPricePPPN.TabIndex = 42;
            this.validPricePPPN.Text = "label2";
            // 
            // validDescription
            // 
            this.validDescription.AutoSize = true;
            this.validDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validDescription.ForeColor = System.Drawing.Color.Red;
            this.validDescription.Location = new System.Drawing.Point(175, 215);
            this.validDescription.Name = "validDescription";
            this.validDescription.Size = new System.Drawing.Size(52, 21);
            this.validDescription.TabIndex = 41;
            this.validDescription.Text = "label1";
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReturn.Image = global::lakeside.Properties.Resources.returnIcon;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(7, 18);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(256, 65);
            this.btnReturn.TabIndex = 40;
            this.btnReturn.Text = "Return to Home";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // validFriendlyName
            // 
            this.validFriendlyName.AutoSize = true;
            this.validFriendlyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validFriendlyName.ForeColor = System.Drawing.Color.Red;
            this.validFriendlyName.Location = new System.Drawing.Point(175, 140);
            this.validFriendlyName.Name = "validFriendlyName";
            this.validFriendlyName.Size = new System.Drawing.Size(52, 21);
            this.validFriendlyName.TabIndex = 39;
            this.validFriendlyName.Text = "label1";
            // 
            // btnAddPod
            // 
            this.btnAddPod.BackgroundImage = global::lakeside.Properties.Resources.AddGuestButton;
            this.btnAddPod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPod.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPod.Location = new System.Drawing.Point(295, 479);
            this.btnAddPod.Name = "btnAddPod";
            this.btnAddPod.Size = new System.Drawing.Size(558, 65);
            this.btnAddPod.TabIndex = 37;
            this.btnAddPod.UseVisualStyleBackColor = true;
            this.btnAddPod.Click += new System.EventHandler(this.btnAddPod_Click);
            // 
            // txtPricePPPN
            // 
            this.txtPricePPPN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePPPN.Location = new System.Drawing.Point(748, 179);
            this.txtPricePPPN.Name = "txtPricePPPN";
            this.txtPricePPPN.Size = new System.Drawing.Size(105, 33);
            this.txtPricePPPN.TabIndex = 25;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Standard",
            "Luxury"});
            this.cmbType.Location = new System.Drawing.Point(179, 258);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(221, 33);
            this.cmbType.TabIndex = 33;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(748, 258);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(105, 33);
            this.txtCapacity.TabIndex = 27;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(179, 179);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(316, 33);
            this.txtDescription.TabIndex = 22;
            // 
            // txtFriendlyName
            // 
            this.txtFriendlyName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFriendlyName.Location = new System.Drawing.Point(179, 104);
            this.txtFriendlyName.Name = "txtFriendlyName";
            this.txtFriendlyName.Size = new System.Drawing.Size(674, 33);
            this.txtFriendlyName.TabIndex = 21;
            // 
            // btnRandomiseData
            // 
            this.btnRandomiseData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRandomiseData.Image = global::lakeside.Properties.Resources.dice2;
            this.btnRandomiseData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRandomiseData.Location = new System.Drawing.Point(26, 479);
            this.btnRandomiseData.Name = "btnRandomiseData";
            this.btnRandomiseData.Size = new System.Drawing.Size(229, 65);
            this.btnRandomiseData.TabIndex = 34;
            this.btnRandomiseData.Text = "Randomise Data";
            this.btnRandomiseData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRandomiseData.UseVisualStyleBackColor = true;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(71, 257);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(102, 30);
            this.lbType.TabIndex = 35;
            this.lbType.Text = "Pod Type:";
            // 
            // lbPodLocation
            // 
            this.lbPodLocation.AutoSize = true;
            this.lbPodLocation.Location = new System.Drawing.Point(35, 346);
            this.lbPodLocation.Name = "lbPodLocation";
            this.lbPodLocation.Size = new System.Drawing.Size(138, 30);
            this.lbPodLocation.TabIndex = 30;
            this.lbPodLocation.Text = "Pod Location:";
            // 
            // lbCapacity
            // 
            this.lbCapacity.AutoSize = true;
            this.lbCapacity.Location = new System.Drawing.Point(604, 257);
            this.lbCapacity.Name = "lbCapacity";
            this.lbCapacity.Size = new System.Drawing.Size(138, 30);
            this.lbCapacity.TabIndex = 28;
            this.lbCapacity.Text = "Pod Capacity:";
            // 
            // lbPricePPPN
            // 
            this.lbPricePPPN.AutoSize = true;
            this.lbPricePPPN.Location = new System.Drawing.Point(630, 182);
            this.lbPricePPPN.Name = "lbPricePPPN";
            this.lbPricePPPN.Size = new System.Drawing.Size(121, 30);
            this.lbPricePPPN.TabIndex = 26;
            this.lbPricePPPN.Text = "Pod Price: £";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(9, 182);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(164, 30);
            this.lbDescription.TabIndex = 24;
            this.lbDescription.Text = "Pod Description:";
            // 
            // lbFriendlyName
            // 
            this.lbFriendlyName.AutoSize = true;
            this.lbFriendlyName.Location = new System.Drawing.Point(21, 103);
            this.lbFriendlyName.Name = "lbFriendlyName";
            this.lbFriendlyName.Size = new System.Drawing.Size(152, 30);
            this.lbFriendlyName.TabIndex = 23;
            this.lbFriendlyName.Text = "Friendly Name:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(383, 9);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(140, 37);
            this.lbTitle.TabIndex = 20;
            this.lbTitle.Text = "Add a Pod";
            // 
            // cmbPodLocation
            // 
            this.cmbPodLocation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPodLocation.FormattingEnabled = true;
            this.cmbPodLocation.Location = new System.Drawing.Point(179, 344);
            this.cmbPodLocation.Name = "cmbPodLocation";
            this.cmbPodLocation.Size = new System.Drawing.Size(369, 33);
            this.cmbPodLocation.TabIndex = 48;
            // 
            // frmAddPod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 563);
            this.Controls.Add(this.cmbPodLocation);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.validType);
            this.Controls.Add(this.validPodLocation);
            this.Controls.Add(this.validCapacity);
            this.Controls.Add(this.validPricePPPN);
            this.Controls.Add(this.validDescription);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.validFriendlyName);
            this.Controls.Add(this.btnAddPod);
            this.Controls.Add(this.txtPricePPPN);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtFriendlyName);
            this.Controls.Add(this.btnRandomiseData);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbPodLocation);
            this.Controls.Add(this.lbCapacity);
            this.Controls.Add(this.lbPricePPPN);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbFriendlyName);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmAddPod";
            this.Text = "Lakeside Escapes: Add a Pod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label validType;
        private System.Windows.Forms.Label validPodLocation;
        private System.Windows.Forms.Label validCapacity;
        private System.Windows.Forms.Label validPricePPPN;
        private System.Windows.Forms.Label validDescription;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label validFriendlyName;
        private System.Windows.Forms.Button btnAddPod;
        private ValidationTextBox txtPricePPPN;
        private ValidationComboBox cmbType;
        private ValidationTextBox txtCapacity;
        private ValidationTextBox txtDescription;
        private ValidationTextBox txtFriendlyName;
        private System.Windows.Forms.Button btnRandomiseData;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbPodLocation;
        private System.Windows.Forms.Label lbCapacity;
        private System.Windows.Forms.Label lbPricePPPN;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbFriendlyName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ComboBox cmbPodLocation;
    }
}