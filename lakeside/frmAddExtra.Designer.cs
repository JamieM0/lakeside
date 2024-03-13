namespace lakeside
{
    partial class frmAddExtra
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
            this.validPricePPPN = new System.Windows.Forms.Label();
            this.validDescription = new System.Windows.Forms.Label();
            this.validExtraName = new System.Windows.Forms.Label();
            this.lbPricePPPN = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbExtraName = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnRandomiseData = new System.Windows.Forms.Button();
            this.txtPricePPPN = new lakeside.ValidationTextBox();
            this.txtDescription = new lakeside.ValidationTextBox();
            this.txtExtraName = new lakeside.ValidationTextBox();
            this.SuspendLayout();
            // 
            // validPricePPPN
            // 
            this.validPricePPPN.AutoSize = true;
            this.validPricePPPN.BackColor = System.Drawing.Color.Transparent;
            this.validPricePPPN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validPricePPPN.ForeColor = System.Drawing.Color.Red;
            this.validPricePPPN.Location = new System.Drawing.Point(629, 231);
            this.validPricePPPN.Name = "validPricePPPN";
            this.validPricePPPN.Size = new System.Drawing.Size(52, 21);
            this.validPricePPPN.TabIndex = 92;
            this.validPricePPPN.Text = "label2";
            // 
            // validDescription
            // 
            this.validDescription.AutoSize = true;
            this.validDescription.BackColor = System.Drawing.Color.Transparent;
            this.validDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validDescription.ForeColor = System.Drawing.Color.Red;
            this.validDescription.Location = new System.Drawing.Point(209, 231);
            this.validDescription.Name = "validDescription";
            this.validDescription.Size = new System.Drawing.Size(52, 21);
            this.validDescription.TabIndex = 91;
            this.validDescription.Text = "label1";
            // 
            // validExtraName
            // 
            this.validExtraName.AutoSize = true;
            this.validExtraName.BackColor = System.Drawing.Color.Transparent;
            this.validExtraName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validExtraName.ForeColor = System.Drawing.Color.Red;
            this.validExtraName.Location = new System.Drawing.Point(209, 151);
            this.validExtraName.Name = "validExtraName";
            this.validExtraName.Size = new System.Drawing.Size(52, 21);
            this.validExtraName.TabIndex = 89;
            this.validExtraName.Text = "label1";
            // 
            // lbPricePPPN
            // 
            this.lbPricePPPN.AutoSize = true;
            this.lbPricePPPN.BackColor = System.Drawing.Color.Transparent;
            this.lbPricePPPN.ForeColor = System.Drawing.Color.White;
            this.lbPricePPPN.Location = new System.Drawing.Point(628, 190);
            this.lbPricePPPN.Name = "lbPricePPPN";
            this.lbPricePPPN.Size = new System.Drawing.Size(132, 30);
            this.lbPricePPPN.TabIndex = 81;
            this.lbPricePPPN.Text = "Extra Price: £";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbDescription.ForeColor = System.Drawing.Color.White;
            this.lbDescription.Location = new System.Drawing.Point(32, 189);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(175, 30);
            this.lbDescription.TabIndex = 79;
            this.lbDescription.Text = "Extra Description:";
            // 
            // lbExtraName
            // 
            this.lbExtraName.AutoSize = true;
            this.lbExtraName.BackColor = System.Drawing.Color.Transparent;
            this.lbExtraName.ForeColor = System.Drawing.Color.White;
            this.lbExtraName.Location = new System.Drawing.Point(81, 118);
            this.lbExtraName.Name = "lbExtraName";
            this.lbExtraName.Size = new System.Drawing.Size(126, 30);
            this.lbExtraName.TabIndex = 78;
            this.lbExtraName.Text = "Extra Name:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(364, 31);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(167, 37);
            this.lbTitle.TabIndex = 75;
            this.lbTitle.Text = "Add an Extra";
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearAll.Image = global::lakeside.Properties.Resources.returnIcon;
            this.btnClearAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearAll.Location = new System.Drawing.Point(615, 31);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(256, 65);
            this.btnClearAll.TabIndex = 5;
            this.btnClearAll.Text = "Clear All Fields";
            this.btnClearAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReturn.Image = global::lakeside.Properties.Resources.returnIcon;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(12, 31);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(256, 65);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return to Home";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackgroundImage = global::lakeside.Properties.Resources.AddExtraButton;
            this.btnAddCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddCourse.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(649, 277);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(222, 60);
            this.btnAddCourse.TabIndex = 3;
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnRandomiseData
            // 
            this.btnRandomiseData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRandomiseData.Image = global::lakeside.Properties.Resources.dice2;
            this.btnRandomiseData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRandomiseData.Location = new System.Drawing.Point(12, 277);
            this.btnRandomiseData.Name = "btnRandomiseData";
            this.btnRandomiseData.Size = new System.Drawing.Size(222, 60);
            this.btnRandomiseData.TabIndex = 86;
            this.btnRandomiseData.Text = "Randomise Data";
            this.btnRandomiseData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRandomiseData.UseVisualStyleBackColor = true;
            this.btnRandomiseData.Visible = false;
            // 
            // txtPricePPPN
            // 
            this.txtPricePPPN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePPPN.Location = new System.Drawing.Point(766, 190);
            this.txtPricePPPN.Name = "txtPricePPPN";
            this.txtPricePPPN.Size = new System.Drawing.Size(105, 33);
            this.txtPricePPPN.TabIndex = 2;
            this.txtPricePPPN.TextChanged += new System.EventHandler(this.txtPricePPPN_TextChanged);
            this.txtPricePPPN.Leave += new System.EventHandler(this.txtPricePPPN_Leave);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(213, 190);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(373, 33);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // txtExtraName
            // 
            this.txtExtraName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraName.Location = new System.Drawing.Point(213, 115);
            this.txtExtraName.Name = "txtExtraName";
            this.txtExtraName.Size = new System.Drawing.Size(658, 33);
            this.txtExtraName.TabIndex = 0;
            this.txtExtraName.TextChanged += new System.EventHandler(this.txtExtraName_TextChanged);
            this.txtExtraName.Leave += new System.EventHandler(this.txtExtraName_Leave);
            // 
            // frmAddExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lakeside.Properties.Resources.Gradient_Extra;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 349);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.validPricePPPN);
            this.Controls.Add(this.validDescription);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.validExtraName);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtPricePPPN);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtExtraName);
            this.Controls.Add(this.btnRandomiseData);
            this.Controls.Add(this.lbPricePPPN);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbExtraName);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmAddExtra";
            this.Text = "Lakeside Escapes: Add an Extra";
            this.Load += new System.EventHandler(this.frmAddExtra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label validPricePPPN;
        private System.Windows.Forms.Label validDescription;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label validExtraName;
        private System.Windows.Forms.Button btnAddCourse;
        private ValidationTextBox txtPricePPPN;
        private ValidationTextBox txtDescription;
        private ValidationTextBox txtExtraName;
        private System.Windows.Forms.Button btnRandomiseData;
        private System.Windows.Forms.Label lbPricePPPN;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbExtraName;
        private System.Windows.Forms.Label lbTitle;
    }
}