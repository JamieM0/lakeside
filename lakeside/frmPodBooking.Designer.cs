
namespace lakeside
{
    partial class frmPodBooking
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
            this.pnlSundays = new System.Windows.Forms.Panel();
            this.pnlSaturdays = new System.Windows.Forms.Panel();
            this.pnlCalContainer = new System.Windows.Forms.Panel();
            this.pnlCalOutside = new System.Windows.Forms.Panel();
            this.lbMonthName = new System.Windows.Forms.Label();
            this.cmbDatePickerStayLength = new System.Windows.Forms.ComboBox();
            this.lbDatePickerStayPeriod = new System.Windows.Forms.Label();
            this.btnPreviousMonth = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.lbDayTitles = new System.Windows.Forms.Label();
            this.pnlCalOutside.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(436, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(175, 30);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Check Availability";
            // 
            // pnlSundays
            // 
            this.pnlSundays.Location = new System.Drawing.Point(1135, 116);
            this.pnlSundays.Name = "pnlSundays";
            this.pnlSundays.Size = new System.Drawing.Size(53, 301);
            this.pnlSundays.TabIndex = 6;
            // 
            // pnlSaturdays
            // 
            this.pnlSaturdays.Location = new System.Drawing.Point(1076, 116);
            this.pnlSaturdays.Name = "pnlSaturdays";
            this.pnlSaturdays.Size = new System.Drawing.Size(53, 301);
            this.pnlSaturdays.TabIndex = 5;
            // 
            // pnlCalContainer
            // 
            this.pnlCalContainer.Location = new System.Drawing.Point(61, 120);
            this.pnlCalContainer.Name = "pnlCalContainer";
            this.pnlCalContainer.Size = new System.Drawing.Size(416, 231);
            this.pnlCalContainer.TabIndex = 7;
            // 
            // pnlCalOutside
            // 
            this.pnlCalOutside.Controls.Add(this.lbMonthName);
            this.pnlCalOutside.Controls.Add(this.cmbDatePickerStayLength);
            this.pnlCalOutside.Controls.Add(this.lbDatePickerStayPeriod);
            this.pnlCalOutside.Controls.Add(this.btnPreviousMonth);
            this.pnlCalOutside.Controls.Add(this.btnNextMonth);
            this.pnlCalOutside.Controls.Add(this.lbDayTitles);
            this.pnlCalOutside.Controls.Add(this.pnlCalContainer);
            this.pnlCalOutside.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCalOutside.Location = new System.Drawing.Point(247, 42);
            this.pnlCalOutside.Name = "pnlCalOutside";
            this.pnlCalOutside.Size = new System.Drawing.Size(541, 421);
            this.pnlCalOutside.TabIndex = 8;
            // 
            // lbMonthName
            // 
            this.lbMonthName.AutoSize = true;
            this.lbMonthName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonthName.Location = new System.Drawing.Point(215, 24);
            this.lbMonthName.Name = "lbMonthName";
            this.lbMonthName.Size = new System.Drawing.Size(103, 25);
            this.lbMonthName.TabIndex = 13;
            this.lbMonthName.Text = "November";
            // 
            // cmbDatePickerStayLength
            // 
            this.cmbDatePickerStayLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatePickerStayLength.DropDownWidth = 100;
            this.cmbDatePickerStayLength.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatePickerStayLength.FormattingEnabled = true;
            this.cmbDatePickerStayLength.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "13"});
            this.cmbDatePickerStayLength.Location = new System.Drawing.Point(175, 369);
            this.cmbDatePickerStayLength.Name = "cmbDatePickerStayLength";
            this.cmbDatePickerStayLength.Size = new System.Drawing.Size(45, 33);
            this.cmbDatePickerStayLength.TabIndex = 12;
            this.cmbDatePickerStayLength.SelectedIndexChanged += new System.EventHandler(this.cmbDatePickerStayLength_SelectedIndexChanged);
            // 
            // lbDatePickerStayPeriod
            // 
            this.lbDatePickerStayPeriod.AutoSize = true;
            this.lbDatePickerStayPeriod.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatePickerStayPeriod.Location = new System.Drawing.Point(56, 372);
            this.lbDatePickerStayPeriod.Name = "lbDatePickerStayPeriod";
            this.lbDatePickerStayPeriod.Size = new System.Drawing.Size(233, 25);
            this.lbDatePickerStayPeriod.TabIndex = 11;
            this.lbDatePickerStayPeriod.Text = "Stay Length:             Nights";
            // 
            // btnPreviousMonth
            // 
            this.btnPreviousMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousMonth.Location = new System.Drawing.Point(61, 17);
            this.btnPreviousMonth.Name = "btnPreviousMonth";
            this.btnPreviousMonth.Size = new System.Drawing.Size(130, 41);
            this.btnPreviousMonth.TabIndex = 10;
            this.btnPreviousMonth.Text = "Previous Month";
            this.btnPreviousMonth.UseVisualStyleBackColor = true;
            this.btnPreviousMonth.Click += new System.EventHandler(this.btnPreviousMonth_Click);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextMonth.Location = new System.Drawing.Point(347, 17);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(130, 41);
            this.btnNextMonth.TabIndex = 9;
            this.btnNextMonth.Text = "Next Month";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // lbDayTitles
            // 
            this.lbDayTitles.AutoSize = true;
            this.lbDayTitles.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDayTitles.Location = new System.Drawing.Point(61, 79);
            this.lbDayTitles.Name = "lbDayTitles";
            this.lbDayTitles.Size = new System.Drawing.Size(382, 30);
            this.lbDayTitles.TabIndex = 8;
            this.lbDayTitles.Text = "M        T       W       T        F        S        S";
            // 
            // frmPodBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 475);
            this.Controls.Add(this.pnlCalOutside);
            this.Controls.Add(this.pnlSundays);
            this.Controls.Add(this.pnlSaturdays);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmPodBooking";
            this.Text = "Lakeside Escapes: Pod Booking";
            this.Load += new System.EventHandler(this.frmPodBooking_Load);
            this.pnlCalOutside.ResumeLayout(false);
            this.pnlCalOutside.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnlSundays;
        private System.Windows.Forms.Panel pnlSaturdays;
        private System.Windows.Forms.Panel pnlCalContainer;
        private System.Windows.Forms.Panel pnlCalOutside;
        private System.Windows.Forms.Label lbDayTitles;
        private System.Windows.Forms.Button btnPreviousMonth;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.ComboBox cmbDatePickerStayLength;
        private System.Windows.Forms.Label lbDatePickerStayPeriod;
        private System.Windows.Forms.Label lbMonthName;
    }
}