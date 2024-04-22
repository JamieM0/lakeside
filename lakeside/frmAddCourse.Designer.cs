
namespace lakeside
{
    partial class frmAddCourse
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
            this.cmbCourseLevel = new System.Windows.Forms.ComboBox();
            this.validTutor = new System.Windows.Forms.Label();
            this.validCourseLevel = new System.Windows.Forms.Label();
            this.validCapacity = new System.Windows.Forms.Label();
            this.validPricePPPN = new System.Windows.Forms.Label();
            this.validDescription = new System.Windows.Forms.Label();
            this.validCourseName = new System.Windows.Forms.Label();
            this.lbTutor = new System.Windows.Forms.Label();
            this.lbCourseLevel = new System.Windows.Forms.Label();
            this.lbCapacity = new System.Windows.Forms.Label();
            this.lbPricePPPN = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbCourseName = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.validDuration = new System.Windows.Forms.Label();
            this.lbDuration = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnRandomiseData = new System.Windows.Forms.Button();
            this.txtDuration = new lakeside.ValidationTextBox();
            this.txtPricePPPN = new lakeside.ValidationTextBox();
            this.cmbTutor = new lakeside.ValidationComboBox();
            this.txtCapacity = new lakeside.ValidationTextBox();
            this.txtDescription = new lakeside.ValidationTextBox();
            this.txtCourseName = new lakeside.ValidationTextBox();
            this.SuspendLayout();
            // 
            // cmbCourseLevel
            // 
            this.cmbCourseLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourseLevel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourseLevel.FormattingEnabled = true;
            this.cmbCourseLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.cmbCourseLevel.Location = new System.Drawing.Point(644, 262);
            this.cmbCourseLevel.Name = "cmbCourseLevel";
            this.cmbCourseLevel.Size = new System.Drawing.Size(221, 33);
            this.cmbCourseLevel.TabIndex = 3;
            this.cmbCourseLevel.TextChanged += new System.EventHandler(this.cmbCourseLevel_TextChanged);
            this.cmbCourseLevel.Leave += new System.EventHandler(this.cmbCourseLevel_Leave);
            // 
            // validTutor
            // 
            this.validTutor.AutoSize = true;
            this.validTutor.BackColor = System.Drawing.Color.Transparent;
            this.validTutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validTutor.ForeColor = System.Drawing.Color.Red;
            this.validTutor.Location = new System.Drawing.Point(203, 299);
            this.validTutor.Name = "validTutor";
            this.validTutor.Size = new System.Drawing.Size(52, 21);
            this.validTutor.TabIndex = 69;
            this.validTutor.Text = "label6";
            // 
            // validCourseLevel
            // 
            this.validCourseLevel.AutoSize = true;
            this.validCourseLevel.BackColor = System.Drawing.Color.Transparent;
            this.validCourseLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validCourseLevel.ForeColor = System.Drawing.Color.Red;
            this.validCourseLevel.Location = new System.Drawing.Point(640, 305);
            this.validCourseLevel.Name = "validCourseLevel";
            this.validCourseLevel.Size = new System.Drawing.Size(52, 21);
            this.validCourseLevel.TabIndex = 68;
            this.validCourseLevel.Text = "label5";
            // 
            // validCapacity
            // 
            this.validCapacity.AutoSize = true;
            this.validCapacity.BackColor = System.Drawing.Color.Transparent;
            this.validCapacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validCapacity.ForeColor = System.Drawing.Color.Red;
            this.validCapacity.Location = new System.Drawing.Point(347, 391);
            this.validCapacity.Name = "validCapacity";
            this.validCapacity.Size = new System.Drawing.Size(52, 21);
            this.validCapacity.TabIndex = 67;
            this.validCapacity.Text = "label3";
            // 
            // validPricePPPN
            // 
            this.validPricePPPN.AutoSize = true;
            this.validPricePPPN.BackColor = System.Drawing.Color.Transparent;
            this.validPricePPPN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validPricePPPN.ForeColor = System.Drawing.Color.Red;
            this.validPricePPPN.Location = new System.Drawing.Point(58, 391);
            this.validPricePPPN.Name = "validPricePPPN";
            this.validPricePPPN.Size = new System.Drawing.Size(52, 21);
            this.validPricePPPN.TabIndex = 66;
            this.validPricePPPN.Text = "label2";
            // 
            // validDescription
            // 
            this.validDescription.AutoSize = true;
            this.validDescription.BackColor = System.Drawing.Color.Transparent;
            this.validDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validDescription.ForeColor = System.Drawing.Color.Red;
            this.validDescription.Location = new System.Drawing.Point(203, 218);
            this.validDescription.Name = "validDescription";
            this.validDescription.Size = new System.Drawing.Size(52, 21);
            this.validDescription.TabIndex = 65;
            this.validDescription.Text = "label1";
            // 
            // validCourseName
            // 
            this.validCourseName.AutoSize = true;
            this.validCourseName.BackColor = System.Drawing.Color.Transparent;
            this.validCourseName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validCourseName.ForeColor = System.Drawing.Color.Red;
            this.validCourseName.Location = new System.Drawing.Point(203, 143);
            this.validCourseName.Name = "validCourseName";
            this.validCourseName.Size = new System.Drawing.Size(52, 21);
            this.validCourseName.TabIndex = 63;
            this.validCourseName.Text = "label1";
            // 
            // lbTutor
            // 
            this.lbTutor.AutoSize = true;
            this.lbTutor.BackColor = System.Drawing.Color.Transparent;
            this.lbTutor.ForeColor = System.Drawing.Color.White;
            this.lbTutor.Location = new System.Drawing.Point(134, 261);
            this.lbTutor.Name = "lbTutor";
            this.lbTutor.Size = new System.Drawing.Size(67, 30);
            this.lbTutor.TabIndex = 61;
            this.lbTutor.Text = "Tutor:";
            this.lbTutor.Click += new System.EventHandler(this.lbTutor_Click);
            // 
            // lbCourseLevel
            // 
            this.lbCourseLevel.AutoSize = true;
            this.lbCourseLevel.BackColor = System.Drawing.Color.Transparent;
            this.lbCourseLevel.ForeColor = System.Drawing.Color.White;
            this.lbCourseLevel.Location = new System.Drawing.Point(503, 262);
            this.lbCourseLevel.Name = "lbCourseLevel";
            this.lbCourseLevel.Size = new System.Drawing.Size(135, 30);
            this.lbCourseLevel.TabIndex = 58;
            this.lbCourseLevel.Text = "Course Level:";
            // 
            // lbCapacity
            // 
            this.lbCapacity.AutoSize = true;
            this.lbCapacity.BackColor = System.Drawing.Color.Transparent;
            this.lbCapacity.ForeColor = System.Drawing.Color.White;
            this.lbCapacity.Location = new System.Drawing.Point(346, 352);
            this.lbCapacity.Name = "lbCapacity";
            this.lbCapacity.Size = new System.Drawing.Size(97, 30);
            this.lbCapacity.TabIndex = 57;
            this.lbCapacity.Text = "Capacity:";
            // 
            // lbPricePPPN
            // 
            this.lbPricePPPN.AutoSize = true;
            this.lbPricePPPN.BackColor = System.Drawing.Color.Transparent;
            this.lbPricePPPN.ForeColor = System.Drawing.Color.White;
            this.lbPricePPPN.Location = new System.Drawing.Point(57, 352);
            this.lbPricePPPN.Name = "lbPricePPPN";
            this.lbPricePPPN.Size = new System.Drawing.Size(150, 30);
            this.lbPricePPPN.TabIndex = 55;
            this.lbPricePPPN.Text = "Course Price: £";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbDescription.ForeColor = System.Drawing.Color.White;
            this.lbDescription.Location = new System.Drawing.Point(8, 185);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(193, 30);
            this.lbDescription.TabIndex = 53;
            this.lbDescription.Text = "Course Description:";
            // 
            // lbCourseName
            // 
            this.lbCourseName.AutoSize = true;
            this.lbCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lbCourseName.ForeColor = System.Drawing.Color.White;
            this.lbCourseName.Location = new System.Drawing.Point(57, 106);
            this.lbCourseName.Name = "lbCourseName";
            this.lbCourseName.Size = new System.Drawing.Size(144, 30);
            this.lbCourseName.TabIndex = 52;
            this.lbCourseName.Text = "Course Name:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(356, 23);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(176, 37);
            this.lbTitle.TabIndex = 49;
            this.lbTitle.Text = "Add a Course";
            // 
            // validDuration
            // 
            this.validDuration.AutoSize = true;
            this.validDuration.BackColor = System.Drawing.Color.Transparent;
            this.validDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validDuration.ForeColor = System.Drawing.Color.Red;
            this.validDuration.Location = new System.Drawing.Point(593, 391);
            this.validDuration.Name = "validDuration";
            this.validDuration.Size = new System.Drawing.Size(52, 21);
            this.validDuration.TabIndex = 74;
            this.validDuration.Text = "label3";
            // 
            // lbDuration
            // 
            this.lbDuration.AutoSize = true;
            this.lbDuration.BackColor = System.Drawing.Color.Transparent;
            this.lbDuration.ForeColor = System.Drawing.Color.White;
            this.lbDuration.Location = new System.Drawing.Point(592, 353);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(162, 30);
            this.lbDuration.TabIndex = 73;
            this.lbDuration.Text = "Duration (Mins):";
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearAll.Image = global::lakeside.Properties.Resources.clear_icon_small;
            this.btnClearAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearAll.Location = new System.Drawing.Point(609, 23);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(256, 65);
            this.btnClearAll.TabIndex = 9;
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
            this.btnReturn.Location = new System.Drawing.Point(19, 23);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(256, 65);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return to Home";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackgroundImage = global::lakeside.Properties.Resources.AddCourseButton;
            this.btnAddCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddCourse.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(641, 425);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(222, 60);
            this.btnAddCourse.TabIndex = 7;
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnRandomiseData
            // 
            this.btnRandomiseData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRandomiseData.Image = global::lakeside.Properties.Resources.dice2;
            this.btnRandomiseData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRandomiseData.Location = new System.Drawing.Point(19, 428);
            this.btnRandomiseData.Name = "btnRandomiseData";
            this.btnRandomiseData.Size = new System.Drawing.Size(222, 60);
            this.btnRandomiseData.TabIndex = 60;
            this.btnRandomiseData.Text = "Randomise Data";
            this.btnRandomiseData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRandomiseData.UseVisualStyleBackColor = true;
            this.btnRandomiseData.Visible = false;
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(760, 354);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(105, 33);
            this.txtDuration.TabIndex = 6;
            this.txtDuration.TextChanged += new System.EventHandler(this.txtDuration_TextChanged);
            this.txtDuration.Leave += new System.EventHandler(this.txtDuration_Leave);
            // 
            // txtPricePPPN
            // 
            this.txtPricePPPN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePPPN.Location = new System.Drawing.Point(207, 350);
            this.txtPricePPPN.Name = "txtPricePPPN";
            this.txtPricePPPN.Size = new System.Drawing.Size(105, 33);
            this.txtPricePPPN.TabIndex = 4;
            this.txtPricePPPN.TextChanged += new System.EventHandler(this.txtPricePPPN_TextChanged);
            this.txtPricePPPN.Leave += new System.EventHandler(this.txtPricePPPN_Leave);
            // 
            // cmbTutor
            // 
            this.cmbTutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTutor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTutor.FormattingEnabled = true;
            this.cmbTutor.Location = new System.Drawing.Point(207, 262);
            this.cmbTutor.Name = "cmbTutor";
            this.cmbTutor.Size = new System.Drawing.Size(221, 33);
            this.cmbTutor.TabIndex = 2;
            this.cmbTutor.SelectedIndexChanged += new System.EventHandler(this.cmbTutor_SelectedIndexChanged);
            this.cmbTutor.TextChanged += new System.EventHandler(this.cmbTutor_TextChanged);
            this.cmbTutor.Leave += new System.EventHandler(this.cmbTutor_Leave);
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(449, 353);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(105, 33);
            this.txtCapacity.TabIndex = 5;
            this.txtCapacity.TextChanged += new System.EventHandler(this.txtCapacity_TextChanged);
            this.txtCapacity.Leave += new System.EventHandler(this.txtCapacity_Leave);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(207, 182);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(658, 33);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(207, 107);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(658, 33);
            this.txtCourseName.TabIndex = 0;
            this.txtCourseName.TextChanged += new System.EventHandler(this.txtCourseName_TextChanged);
            this.txtCourseName.Leave += new System.EventHandler(this.txtCourseName_Leave);
            // 
            // frmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lakeside.Properties.Resources.Gradient_Course;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 520);
            this.Controls.Add(this.validDuration);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lbDuration);
            this.Controls.Add(this.cmbCourseLevel);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.validTutor);
            this.Controls.Add(this.validCourseLevel);
            this.Controls.Add(this.validCapacity);
            this.Controls.Add(this.validPricePPPN);
            this.Controls.Add(this.validDescription);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.validCourseName);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtPricePPPN);
            this.Controls.Add(this.cmbTutor);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.btnRandomiseData);
            this.Controls.Add(this.lbTutor);
            this.Controls.Add(this.lbCourseLevel);
            this.Controls.Add(this.lbCapacity);
            this.Controls.Add(this.lbPricePPPN);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbCourseName);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmAddCourse";
            this.Text = "Lakeside Escapes: Add a Course";
            this.Load += new System.EventHandler(this.frmAddCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCourseLevel;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label validTutor;
        private System.Windows.Forms.Label validCourseLevel;
        private System.Windows.Forms.Label validCapacity;
        private System.Windows.Forms.Label validPricePPPN;
        private System.Windows.Forms.Label validDescription;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label validCourseName;
        private System.Windows.Forms.Button btnAddCourse;
        private ValidationTextBox txtPricePPPN;
        private ValidationComboBox cmbTutor;
        private ValidationTextBox txtCapacity;
        private ValidationTextBox txtDescription;
        private ValidationTextBox txtCourseName;
        private System.Windows.Forms.Button btnRandomiseData;
        private System.Windows.Forms.Label lbTutor;
        private System.Windows.Forms.Label lbCourseLevel;
        private System.Windows.Forms.Label lbCapacity;
        private System.Windows.Forms.Label lbPricePPPN;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbCourseName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label validDuration;
        private ValidationTextBox txtDuration;
        private System.Windows.Forms.Label lbDuration;
    }
}