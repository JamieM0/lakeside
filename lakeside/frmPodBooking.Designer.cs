
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
            this.btnPreviousMonth = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.lbDayTitles = new System.Windows.Forms.Label();
            this.lbDateRange = new System.Windows.Forms.Label();
            this.cmbDatePickerStayLength = new System.Windows.Forms.ComboBox();
            this.lbDatePickerStayPeriod = new System.Windows.Forms.Label();
            this.btnSelectDates = new System.Windows.Forms.Button();
            this.pnlDatePicker = new System.Windows.Forms.Panel();
            this.btnDatePickerOpenerSelector = new System.Windows.Forms.Button();
            this.dgAvailablePods = new System.Windows.Forms.DataGridView();
            this.btnConfirmPod = new System.Windows.Forms.Button();
            this.lbLocationDisplay = new System.Windows.Forms.Label();
            this.pnlLocationDateDisplay = new System.Windows.Forms.Panel();
            this.lbDateDisplay = new System.Windows.Forms.Label();
            this.pnlGuests = new System.Windows.Forms.Panel();
            this.lbGuestsTitle = new System.Windows.Forms.Label();
            this.btnSelectGuests = new System.Windows.Forms.Button();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.pnlGuestPicker = new System.Windows.Forms.Panel();
            this.pnlCalOutside.SuspendLayout();
            this.pnlDatePicker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAvailablePods)).BeginInit();
            this.pnlLocationDateDisplay.SuspendLayout();
            this.pnlGuests.SuspendLayout();
            this.pnlGuestPicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(442, 9);
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
            this.pnlCalContainer.Location = new System.Drawing.Point(32, 115);
            this.pnlCalContainer.Name = "pnlCalContainer";
            this.pnlCalContainer.Size = new System.Drawing.Size(416, 234);
            this.pnlCalContainer.TabIndex = 7;
            // 
            // pnlCalOutside
            // 
            this.pnlCalOutside.Controls.Add(this.lbMonthName);
            this.pnlCalOutside.Controls.Add(this.btnPreviousMonth);
            this.pnlCalOutside.Controls.Add(this.btnNextMonth);
            this.pnlCalOutside.Controls.Add(this.lbDayTitles);
            this.pnlCalOutside.Controls.Add(this.pnlCalContainer);
            this.pnlCalOutside.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCalOutside.Location = new System.Drawing.Point(266, 3);
            this.pnlCalOutside.Name = "pnlCalOutside";
            this.pnlCalOutside.Size = new System.Drawing.Size(480, 363);
            this.pnlCalOutside.TabIndex = 8;
            // 
            // lbMonthName
            // 
            this.lbMonthName.AutoSize = true;
            this.lbMonthName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonthName.Location = new System.Drawing.Point(186, 19);
            this.lbMonthName.Name = "lbMonthName";
            this.lbMonthName.Size = new System.Drawing.Size(103, 25);
            this.lbMonthName.TabIndex = 13;
            this.lbMonthName.Text = "November";
            // 
            // btnPreviousMonth
            // 
            this.btnPreviousMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousMonth.Location = new System.Drawing.Point(32, 12);
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
            this.btnNextMonth.Location = new System.Drawing.Point(318, 12);
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
            this.lbDayTitles.Location = new System.Drawing.Point(32, 74);
            this.lbDayTitles.Name = "lbDayTitles";
            this.lbDayTitles.Size = new System.Drawing.Size(382, 30);
            this.lbDayTitles.TabIndex = 8;
            this.lbDayTitles.Text = "M        T       W       T        F        S        S";
            // 
            // lbDateRange
            // 
            this.lbDateRange.AutoSize = true;
            this.lbDateRange.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateRange.Location = new System.Drawing.Point(55, 45);
            this.lbDateRange.Name = "lbDateRange";
            this.lbDateRange.Size = new System.Drawing.Size(139, 25);
            this.lbDateRange.TabIndex = 14;
            this.lbDateRange.Text = "29 Nov - 1 Dec";
            this.lbDateRange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.cmbDatePickerStayLength.Location = new System.Drawing.Point(129, 78);
            this.cmbDatePickerStayLength.Name = "cmbDatePickerStayLength";
            this.cmbDatePickerStayLength.Size = new System.Drawing.Size(45, 33);
            this.cmbDatePickerStayLength.TabIndex = 12;
            this.cmbDatePickerStayLength.SelectedIndexChanged += new System.EventHandler(this.cmbDatePickerStayLength_SelectedIndexChanged);
            // 
            // lbDatePickerStayPeriod
            // 
            this.lbDatePickerStayPeriod.AutoSize = true;
            this.lbDatePickerStayPeriod.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatePickerStayPeriod.Location = new System.Drawing.Point(12, 81);
            this.lbDatePickerStayPeriod.Name = "lbDatePickerStayPeriod";
            this.lbDatePickerStayPeriod.Size = new System.Drawing.Size(233, 25);
            this.lbDatePickerStayPeriod.TabIndex = 11;
            this.lbDatePickerStayPeriod.Text = "Stay Length:             Nights";
            // 
            // btnSelectDates
            // 
            this.btnSelectDates.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectDates.Location = new System.Drawing.Point(17, 267);
            this.btnSelectDates.Name = "btnSelectDates";
            this.btnSelectDates.Size = new System.Drawing.Size(228, 48);
            this.btnSelectDates.TabIndex = 15;
            this.btnSelectDates.Text = "Select Dates";
            this.btnSelectDates.UseVisualStyleBackColor = true;
            this.btnSelectDates.Click += new System.EventHandler(this.btnSelectDates_Click);
            // 
            // pnlDatePicker
            // 
            this.pnlDatePicker.Controls.Add(this.cmbDatePickerStayLength);
            this.pnlDatePicker.Controls.Add(this.btnSelectDates);
            this.pnlDatePicker.Controls.Add(this.pnlCalOutside);
            this.pnlDatePicker.Controls.Add(this.lbDateRange);
            this.pnlDatePicker.Controls.Add(this.lbDatePickerStayPeriod);
            this.pnlDatePicker.Location = new System.Drawing.Point(28, 42);
            this.pnlDatePicker.Name = "pnlDatePicker";
            this.pnlDatePicker.Size = new System.Drawing.Size(1009, 444);
            this.pnlDatePicker.TabIndex = 9;
            this.pnlDatePicker.Visible = false;
            // 
            // btnDatePickerOpenerSelector
            // 
            this.btnDatePickerOpenerSelector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatePickerOpenerSelector.Location = new System.Drawing.Point(28, 51);
            this.btnDatePickerOpenerSelector.Name = "btnDatePickerOpenerSelector";
            this.btnDatePickerOpenerSelector.Size = new System.Drawing.Size(142, 52);
            this.btnDatePickerOpenerSelector.TabIndex = 10;
            this.btnDatePickerOpenerSelector.Text = "Select Dates";
            this.btnDatePickerOpenerSelector.UseVisualStyleBackColor = true;
            this.btnDatePickerOpenerSelector.Click += new System.EventHandler(this.btnDatePickerOpenerSelector_Click);
            // 
            // dgAvailablePods
            // 
            this.dgAvailablePods.AllowUserToAddRows = false;
            this.dgAvailablePods.AllowUserToDeleteRows = false;
            this.dgAvailablePods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAvailablePods.Location = new System.Drawing.Point(28, 151);
            this.dgAvailablePods.Name = "dgAvailablePods";
            this.dgAvailablePods.ReadOnly = true;
            this.dgAvailablePods.Size = new System.Drawing.Size(571, 218);
            this.dgAvailablePods.TabIndex = 11;
            this.dgAvailablePods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAvailablePods_CellClick);
            // 
            // btnConfirmPod
            // 
            this.btnConfirmPod.Enabled = false;
            this.btnConfirmPod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPod.Location = new System.Drawing.Point(28, 411);
            this.btnConfirmPod.Name = "btnConfirmPod";
            this.btnConfirmPod.Size = new System.Drawing.Size(228, 48);
            this.btnConfirmPod.TabIndex = 16;
            this.btnConfirmPod.Text = "Confirm Pod";
            this.btnConfirmPod.UseVisualStyleBackColor = true;
            this.btnConfirmPod.Click += new System.EventHandler(this.btnConfirmPod_Click);
            // 
            // lbLocationDisplay
            // 
            this.lbLocationDisplay.AutoSize = true;
            this.lbLocationDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocationDisplay.Location = new System.Drawing.Point(13, 9);
            this.lbLocationDisplay.Name = "lbLocationDisplay";
            this.lbLocationDisplay.Size = new System.Drawing.Size(61, 25);
            this.lbLocationDisplay.TabIndex = 17;
            this.lbLocationDisplay.Text = "label1";
            // 
            // pnlLocationDateDisplay
            // 
            this.pnlLocationDateDisplay.Controls.Add(this.lbDateDisplay);
            this.pnlLocationDateDisplay.Controls.Add(this.lbLocationDisplay);
            this.pnlLocationDateDisplay.Location = new System.Drawing.Point(20, 51);
            this.pnlLocationDateDisplay.Name = "pnlLocationDateDisplay";
            this.pnlLocationDateDisplay.Size = new System.Drawing.Size(209, 85);
            this.pnlLocationDateDisplay.TabIndex = 14;
            this.pnlLocationDateDisplay.Visible = false;
            // 
            // lbDateDisplay
            // 
            this.lbDateDisplay.AutoSize = true;
            this.lbDateDisplay.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateDisplay.Location = new System.Drawing.Point(13, 44);
            this.lbDateDisplay.Name = "lbDateDisplay";
            this.lbDateDisplay.Size = new System.Drawing.Size(58, 25);
            this.lbDateDisplay.TabIndex = 18;
            this.lbDateDisplay.Text = "label1";
            // 
            // pnlGuests
            // 
            this.pnlGuests.Controls.Add(this.pnlGuestPicker);
            this.pnlGuests.Controls.Add(this.lbGuestsTitle);
            this.pnlGuests.Location = new System.Drawing.Point(20, 173);
            this.pnlGuests.Name = "pnlGuests";
            this.pnlGuests.Size = new System.Drawing.Size(279, 184);
            this.pnlGuests.TabIndex = 17;
            // 
            // lbGuestsTitle
            // 
            this.lbGuestsTitle.AutoSize = true;
            this.lbGuestsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuestsTitle.Location = new System.Drawing.Point(13, 12);
            this.lbGuestsTitle.Name = "lbGuestsTitle";
            this.lbGuestsTitle.Size = new System.Drawing.Size(69, 25);
            this.lbGuestsTitle.TabIndex = 18;
            this.lbGuestsTitle.Text = "Guests";
            // 
            // btnSelectGuests
            // 
            this.btnSelectGuests.BackgroundImage = global::lakeside.Properties.Resources.SelectGuestsButton;
            this.btnSelectGuests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelectGuests.Location = new System.Drawing.Point(3, 3);
            this.btnSelectGuests.Name = "btnSelectGuests";
            this.btnSelectGuests.Size = new System.Drawing.Size(250, 57);
            this.btnSelectGuests.TabIndex = 19;
            this.btnSelectGuests.UseVisualStyleBackColor = true;
            this.btnSelectGuests.Click += new System.EventHandler(this.btnSelectGuests_Click);
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.BackgroundImage = global::lakeside.Properties.Resources.AddGuestButton;
            this.btnAddGuest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddGuest.Location = new System.Drawing.Point(3, 66);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(250, 57);
            this.btnAddGuest.TabIndex = 20;
            this.btnAddGuest.UseVisualStyleBackColor = true;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // pnlGuestPicker
            // 
            this.pnlGuestPicker.Controls.Add(this.btnSelectGuests);
            this.pnlGuestPicker.Controls.Add(this.btnAddGuest);
            this.pnlGuestPicker.Location = new System.Drawing.Point(12, 50);
            this.pnlGuestPicker.Name = "pnlGuestPicker";
            this.pnlGuestPicker.Size = new System.Drawing.Size(256, 124);
            this.pnlGuestPicker.TabIndex = 21;
            // 
            // frmPodBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 498);
            this.Controls.Add(this.pnlGuests);
            this.Controls.Add(this.pnlLocationDateDisplay);
            this.Controls.Add(this.dgAvailablePods);
            this.Controls.Add(this.btnDatePickerOpenerSelector);
            this.Controls.Add(this.pnlSundays);
            this.Controls.Add(this.pnlSaturdays);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnConfirmPod);
            this.Controls.Add(this.pnlDatePicker);
            this.Name = "frmPodBooking";
            this.Text = "Lakeside Escapes: Pod Booking";
            this.Load += new System.EventHandler(this.frmPodBooking_Load);
            this.pnlCalOutside.ResumeLayout(false);
            this.pnlCalOutside.PerformLayout();
            this.pnlDatePicker.ResumeLayout(false);
            this.pnlDatePicker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAvailablePods)).EndInit();
            this.pnlLocationDateDisplay.ResumeLayout(false);
            this.pnlLocationDateDisplay.PerformLayout();
            this.pnlGuests.ResumeLayout(false);
            this.pnlGuests.PerformLayout();
            this.pnlGuestPicker.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbDateRange;
        private System.Windows.Forms.Button btnSelectDates;
        private System.Windows.Forms.Panel pnlDatePicker;
        private System.Windows.Forms.Button btnDatePickerOpenerSelector;
        private System.Windows.Forms.DataGridView dgAvailablePods;
        private System.Windows.Forms.Button btnConfirmPod;
        private System.Windows.Forms.Label lbLocationDisplay;
        private System.Windows.Forms.Panel pnlLocationDateDisplay;
        private System.Windows.Forms.Label lbDateDisplay;
        private System.Windows.Forms.Panel pnlGuests;
        private System.Windows.Forms.Label lbGuestsTitle;
        private System.Windows.Forms.Button btnSelectGuests;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.Panel pnlGuestPicker;
    }
}