
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
            this.components = new System.ComponentModel.Container();
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
            this.pnlOverflow = new System.Windows.Forms.Panel();
            this.lbOverflowText = new System.Windows.Forms.Label();
            this.lbOverflow = new System.Windows.Forms.Label();
            this.btnDatePickerOpenerSelector = new System.Windows.Forms.Button();
            this.dgAvailablePods = new System.Windows.Forms.DataGridView();
            this.btnConfirmPod = new System.Windows.Forms.Button();
            this.lbLocationDisplay = new System.Windows.Forms.Label();
            this.pnlLocationDateDisplay = new System.Windows.Forms.Panel();
            this.llbChangeDates = new System.Windows.Forms.LinkLabel();
            this.lbDateDisplay = new System.Windows.Forms.Label();
            this.pnlGuests = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGuestPicker = new System.Windows.Forms.Panel();
            this.lbGuestsTitle = new System.Windows.Forms.Label();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.lbDebugInfo = new System.Windows.Forms.Label();
            this.pnlGuestDisplay = new System.Windows.Forms.Panel();
            this.lbGuestDisplay4 = new System.Windows.Forms.Label();
            this.lbGuestDisplay3 = new System.Windows.Forms.Label();
            this.lbGuestDisplay2 = new System.Windows.Forms.Label();
            this.llbChangeGuests = new System.Windows.Forms.LinkLabel();
            this.lbGuestDisplay = new System.Windows.Forms.Label();
            this.lbGuestsStayingDisplayTitle = new System.Windows.Forms.Label();
            this.pnlCourses = new System.Windows.Forms.Panel();
            this.btnContinueFromCourseSelection = new System.Windows.Forms.Button();
            this.btnSkipCourseSelection = new System.Windows.Forms.Button();
            this.dgCourses = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGuestCoursePickerTitle = new System.Windows.Forms.Label();
            this.btnBackToHomeOrMainMenu = new System.Windows.Forms.Button();
            this.btnContinueCourseSelection = new System.Windows.Forms.Button();
            this.lbGuestDisplay5 = new System.Windows.Forms.Label();
            this.lbGuestDisplay6 = new System.Windows.Forms.Label();
            this.btnAcceptGuests = new System.Windows.Forms.Button();
            this.btnSelectGuests = new System.Windows.Forms.Button();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.pnlGuestSelectionActionGroup = new System.Windows.Forms.Panel();
            this.pnlCalOutside.SuspendLayout();
            this.pnlDatePicker.SuspendLayout();
            this.pnlOverflow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAvailablePods)).BeginInit();
            this.pnlLocationDateDisplay.SuspendLayout();
            this.pnlGuests.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlGuestDisplay.SuspendLayout();
            this.pnlCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourses)).BeginInit();
            this.pnlGuestSelectionActionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1059, 498);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Check Availability";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.pnlDatePicker.Controls.Add(this.btnContinueFromCourseSelection);
            this.pnlDatePicker.Controls.Add(this.pnlOverflow);
            this.pnlDatePicker.Controls.Add(this.cmbDatePickerStayLength);
            this.pnlDatePicker.Controls.Add(this.btnSelectDates);
            this.pnlDatePicker.Controls.Add(this.pnlCalOutside);
            this.pnlDatePicker.Controls.Add(this.lbDateRange);
            this.pnlDatePicker.Controls.Add(this.lbDatePickerStayPeriod);
            this.pnlDatePicker.Location = new System.Drawing.Point(28, 42);
            this.pnlDatePicker.Name = "pnlDatePicker";
            this.pnlDatePicker.Size = new System.Drawing.Size(789, 444);
            this.pnlDatePicker.TabIndex = 9;
            this.pnlDatePicker.Visible = false;
            // 
            // pnlOverflow
            // 
            this.pnlOverflow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.pnlOverflow.Controls.Add(this.lbOverflowText);
            this.pnlOverflow.Controls.Add(this.lbOverflow);
            this.pnlOverflow.Location = new System.Drawing.Point(720, 217);
            this.pnlOverflow.Name = "pnlOverflow";
            this.pnlOverflow.Size = new System.Drawing.Size(48, 98);
            this.pnlOverflow.TabIndex = 14;
            this.pnlOverflow.Visible = false;
            // 
            // lbOverflowText
            // 
            this.lbOverflowText.AutoSize = true;
            this.lbOverflowText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOverflowText.ForeColor = System.Drawing.Color.White;
            this.lbOverflowText.Location = new System.Drawing.Point(1, 0);
            this.lbOverflowText.Name = "lbOverflowText";
            this.lbOverflowText.Size = new System.Drawing.Size(47, 40);
            this.lbOverflowText.TabIndex = 1;
            this.lbOverflowText.Text = "END\r\nDATE";
            this.lbOverflowText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbOverflow
            // 
            this.lbOverflow.AutoSize = true;
            this.lbOverflow.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOverflow.ForeColor = System.Drawing.Color.White;
            this.lbOverflow.Location = new System.Drawing.Point(6, 40);
            this.lbOverflow.Name = "lbOverflow";
            this.lbOverflow.Size = new System.Drawing.Size(37, 30);
            this.lbOverflow.TabIndex = 0;
            this.lbOverflow.Text = "12";
            this.lbOverflow.Visible = false;
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
            this.dgAvailablePods.Size = new System.Drawing.Size(639, 218);
            this.dgAvailablePods.TabIndex = 11;
            this.dgAvailablePods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAvailablePods_CellClick);
            this.dgAvailablePods.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAvailablePods_CellDoubleClick);
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
            this.pnlLocationDateDisplay.Controls.Add(this.llbChangeDates);
            this.pnlLocationDateDisplay.Controls.Add(this.lbDateDisplay);
            this.pnlLocationDateDisplay.Controls.Add(this.lbLocationDisplay);
            this.pnlLocationDateDisplay.Location = new System.Drawing.Point(15, 88);
            this.pnlLocationDateDisplay.Name = "pnlLocationDateDisplay";
            this.pnlLocationDateDisplay.Size = new System.Drawing.Size(209, 87);
            this.pnlLocationDateDisplay.TabIndex = 14;
            this.pnlLocationDateDisplay.Visible = false;
            // 
            // llbChangeDates
            // 
            this.llbChangeDates.AutoSize = true;
            this.llbChangeDates.Location = new System.Drawing.Point(15, 32);
            this.llbChangeDates.Name = "llbChangeDates";
            this.llbChangeDates.Size = new System.Drawing.Size(75, 13);
            this.llbChangeDates.TabIndex = 19;
            this.llbChangeDates.TabStop = true;
            this.llbChangeDates.Text = "Change Dates";
            this.llbChangeDates.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbChangeDates_LinkClicked);
            // 
            // lbDateDisplay
            // 
            this.lbDateDisplay.AutoSize = true;
            this.lbDateDisplay.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateDisplay.Location = new System.Drawing.Point(13, 50);
            this.lbDateDisplay.Name = "lbDateDisplay";
            this.lbDateDisplay.Size = new System.Drawing.Size(58, 25);
            this.lbDateDisplay.TabIndex = 18;
            this.lbDateDisplay.Text = "label1";
            // 
            // pnlGuests
            // 
            this.pnlGuests.Controls.Add(this.pnlGuestSelectionActionGroup);
            this.pnlGuests.Controls.Add(this.panel1);
            this.pnlGuests.Controls.Add(this.pnlGuestPicker);
            this.pnlGuests.Controls.Add(this.lbGuestsTitle);
            this.pnlGuests.Location = new System.Drawing.Point(356, 36);
            this.pnlGuests.Name = "pnlGuests";
            this.pnlGuests.Size = new System.Drawing.Size(583, 409);
            this.pnlGuests.TabIndex = 17;
            this.pnlGuests.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 40);
            this.panel1.TabIndex = 22;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(267, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Example Name";
            // 
            // pnlGuestPicker
            // 
            this.pnlGuestPicker.Location = new System.Drawing.Point(15, 32);
            this.pnlGuestPicker.Name = "pnlGuestPicker";
            this.pnlGuestPicker.Size = new System.Drawing.Size(308, 363);
            this.pnlGuestPicker.TabIndex = 21;
            // 
            // lbGuestsTitle
            // 
            this.lbGuestsTitle.AutoSize = true;
            this.lbGuestsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuestsTitle.Location = new System.Drawing.Point(66, 3);
            this.lbGuestsTitle.Name = "lbGuestsTitle";
            this.lbGuestsTitle.Size = new System.Drawing.Size(207, 25);
            this.lbGuestsTitle.TabIndex = 18;
            this.lbGuestsTitle.Text = "Add Guests to Booking";
            // 
            // tmrTick
            // 
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // lbDebugInfo
            // 
            this.lbDebugInfo.AutoSize = true;
            this.lbDebugInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDebugInfo.Location = new System.Drawing.Point(12, 472);
            this.lbDebugInfo.Name = "lbDebugInfo";
            this.lbDebugInfo.Size = new System.Drawing.Size(82, 17);
            this.lbDebugInfo.TabIndex = 18;
            this.lbDebugInfo.Text = "DEBUG INFO";
            this.lbDebugInfo.Visible = false;
            // 
            // pnlGuestDisplay
            // 
            this.pnlGuestDisplay.Controls.Add(this.lbGuestDisplay6);
            this.pnlGuestDisplay.Controls.Add(this.lbGuestDisplay5);
            this.pnlGuestDisplay.Controls.Add(this.lbGuestDisplay4);
            this.pnlGuestDisplay.Controls.Add(this.lbGuestDisplay3);
            this.pnlGuestDisplay.Controls.Add(this.lbGuestDisplay2);
            this.pnlGuestDisplay.Controls.Add(this.llbChangeGuests);
            this.pnlGuestDisplay.Controls.Add(this.lbGuestDisplay);
            this.pnlGuestDisplay.Controls.Add(this.lbGuestsStayingDisplayTitle);
            this.pnlGuestDisplay.Location = new System.Drawing.Point(15, 181);
            this.pnlGuestDisplay.Name = "pnlGuestDisplay";
            this.pnlGuestDisplay.Size = new System.Drawing.Size(209, 213);
            this.pnlGuestDisplay.TabIndex = 19;
            this.pnlGuestDisplay.Visible = false;
            // 
            // lbGuestDisplay4
            // 
            this.lbGuestDisplay4.AutoSize = true;
            this.lbGuestDisplay4.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuestDisplay4.Location = new System.Drawing.Point(13, 125);
            this.lbGuestDisplay4.Name = "lbGuestDisplay4";
            this.lbGuestDisplay4.Size = new System.Drawing.Size(58, 25);
            this.lbGuestDisplay4.TabIndex = 23;
            this.lbGuestDisplay4.Text = "label1";
            this.lbGuestDisplay4.Visible = false;
            this.lbGuestDisplay4.Click += new System.EventHandler(this.lbGuestDisplay4_Click);
            // 
            // lbGuestDisplay3
            // 
            this.lbGuestDisplay3.AutoSize = true;
            this.lbGuestDisplay3.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuestDisplay3.Location = new System.Drawing.Point(13, 100);
            this.lbGuestDisplay3.Name = "lbGuestDisplay3";
            this.lbGuestDisplay3.Size = new System.Drawing.Size(58, 25);
            this.lbGuestDisplay3.TabIndex = 22;
            this.lbGuestDisplay3.Text = "label1";
            this.lbGuestDisplay3.Visible = false;
            this.lbGuestDisplay3.Click += new System.EventHandler(this.lbGuestDisplay3_Click);
            // 
            // lbGuestDisplay2
            // 
            this.lbGuestDisplay2.AutoSize = true;
            this.lbGuestDisplay2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuestDisplay2.Location = new System.Drawing.Point(13, 75);
            this.lbGuestDisplay2.Name = "lbGuestDisplay2";
            this.lbGuestDisplay2.Size = new System.Drawing.Size(58, 25);
            this.lbGuestDisplay2.TabIndex = 21;
            this.lbGuestDisplay2.Text = "label1";
            this.lbGuestDisplay2.Visible = false;
            this.lbGuestDisplay2.Click += new System.EventHandler(this.lbGuestDisplay2_Click);
            // 
            // llbChangeGuests
            // 
            this.llbChangeGuests.AutoSize = true;
            this.llbChangeGuests.Location = new System.Drawing.Point(15, 32);
            this.llbChangeGuests.Name = "llbChangeGuests";
            this.llbChangeGuests.Size = new System.Drawing.Size(80, 13);
            this.llbChangeGuests.TabIndex = 20;
            this.llbChangeGuests.TabStop = true;
            this.llbChangeGuests.Text = "Change Guests";
            this.llbChangeGuests.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbChangeGuests_LinkClicked);
            // 
            // lbGuestDisplay
            // 
            this.lbGuestDisplay.AutoSize = true;
            this.lbGuestDisplay.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuestDisplay.Location = new System.Drawing.Point(13, 50);
            this.lbGuestDisplay.Name = "lbGuestDisplay";
            this.lbGuestDisplay.Size = new System.Drawing.Size(58, 25);
            this.lbGuestDisplay.TabIndex = 18;
            this.lbGuestDisplay.Text = "label1";
            this.lbGuestDisplay.Click += new System.EventHandler(this.lbGuestDisplay_Click);
            // 
            // lbGuestsStayingDisplayTitle
            // 
            this.lbGuestsStayingDisplayTitle.AutoSize = true;
            this.lbGuestsStayingDisplayTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuestsStayingDisplayTitle.Location = new System.Drawing.Point(13, 9);
            this.lbGuestsStayingDisplayTitle.Name = "lbGuestsStayingDisplayTitle";
            this.lbGuestsStayingDisplayTitle.Size = new System.Drawing.Size(137, 25);
            this.lbGuestsStayingDisplayTitle.TabIndex = 17;
            this.lbGuestsStayingDisplayTitle.Text = "Guests Staying";
            // 
            // pnlCourses
            // 
            this.pnlCourses.Controls.Add(this.btnContinueCourseSelection);
            this.pnlCourses.Controls.Add(this.btnSkipCourseSelection);
            this.pnlCourses.Controls.Add(this.dgCourses);
            this.pnlCourses.Controls.Add(this.label2);
            this.pnlCourses.Controls.Add(this.lbGuestCoursePickerTitle);
            this.pnlCourses.Location = new System.Drawing.Point(247, 86);
            this.pnlCourses.Name = "pnlCourses";
            this.pnlCourses.Size = new System.Drawing.Size(696, 338);
            this.pnlCourses.TabIndex = 20;
            this.pnlCourses.Visible = false;
            // 
            // btnContinueFromCourseSelection
            // 
            this.btnContinueFromCourseSelection.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueFromCourseSelection.Location = new System.Drawing.Point(-13, 358);
            this.btnContinueFromCourseSelection.Name = "btnContinueFromCourseSelection";
            this.btnContinueFromCourseSelection.Size = new System.Drawing.Size(209, 36);
            this.btnContinueFromCourseSelection.TabIndex = 4;
            this.btnContinueFromCourseSelection.Text = "Confirm all Courses";
            this.btnContinueFromCourseSelection.UseVisualStyleBackColor = true;
            // 
            // btnSkipCourseSelection
            // 
            this.btnSkipCourseSelection.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkipCourseSelection.Location = new System.Drawing.Point(362, 277);
            this.btnSkipCourseSelection.Name = "btnSkipCourseSelection";
            this.btnSkipCourseSelection.Size = new System.Drawing.Size(313, 45);
            this.btnSkipCourseSelection.TabIndex = 3;
            this.btnSkipCourseSelection.Text = "Skip Course Selection for {guest}";
            this.btnSkipCourseSelection.UseVisualStyleBackColor = true;
            this.btnSkipCourseSelection.Click += new System.EventHandler(this.btnSkipCourseSelection_Click);
            // 
            // dgCourses
            // 
            this.dgCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCourses.Location = new System.Drawing.Point(23, 73);
            this.dgCourses.Name = "dgCourses";
            this.dgCourses.Size = new System.Drawing.Size(653, 195);
            this.dgCourses.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click on a guest\'s name on the left to change the selected guest.";
            // 
            // lbGuestCoursePickerTitle
            // 
            this.lbGuestCoursePickerTitle.AutoSize = true;
            this.lbGuestCoursePickerTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuestCoursePickerTitle.Location = new System.Drawing.Point(18, 11);
            this.lbGuestCoursePickerTitle.Name = "lbGuestCoursePickerTitle";
            this.lbGuestCoursePickerTitle.Size = new System.Drawing.Size(317, 25);
            this.lbGuestCoursePickerTitle.TabIndex = 0;
            this.lbGuestCoursePickerTitle.Text = "Choose a course for {guest}, or skip.";
            // 
            // btnBackToHomeOrMainMenu
            // 
            this.btnBackToHomeOrMainMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToHomeOrMainMenu.Location = new System.Drawing.Point(895, 12);
            this.btnBackToHomeOrMainMenu.Name = "btnBackToHomeOrMainMenu";
            this.btnBackToHomeOrMainMenu.Size = new System.Drawing.Size(152, 47);
            this.btnBackToHomeOrMainMenu.TabIndex = 21;
            this.btnBackToHomeOrMainMenu.Text = "Cancel Booking";
            this.btnBackToHomeOrMainMenu.UseVisualStyleBackColor = true;
            this.btnBackToHomeOrMainMenu.Click += new System.EventHandler(this.btnBackToHomeOrMainMenu_Click);
            // 
            // btnContinueCourseSelection
            // 
            this.btnContinueCourseSelection.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueCourseSelection.Location = new System.Drawing.Point(22, 277);
            this.btnContinueCourseSelection.Name = "btnContinueCourseSelection";
            this.btnContinueCourseSelection.Size = new System.Drawing.Size(313, 45);
            this.btnContinueCourseSelection.TabIndex = 5;
            this.btnContinueCourseSelection.Text = "Continue";
            this.btnContinueCourseSelection.UseVisualStyleBackColor = true;
            this.btnContinueCourseSelection.Click += new System.EventHandler(this.btnContinueCourseSelection_Click);
            // 
            // lbGuestDisplay5
            // 
            this.lbGuestDisplay5.AutoSize = true;
            this.lbGuestDisplay5.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuestDisplay5.Location = new System.Drawing.Point(13, 150);
            this.lbGuestDisplay5.Name = "lbGuestDisplay5";
            this.lbGuestDisplay5.Size = new System.Drawing.Size(58, 25);
            this.lbGuestDisplay5.TabIndex = 24;
            this.lbGuestDisplay5.Text = "label1";
            this.lbGuestDisplay5.Visible = false;
            this.lbGuestDisplay5.Click += new System.EventHandler(this.lbGuestDisplay5_Click);
            // 
            // lbGuestDisplay6
            // 
            this.lbGuestDisplay6.AutoSize = true;
            this.lbGuestDisplay6.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuestDisplay6.Location = new System.Drawing.Point(13, 175);
            this.lbGuestDisplay6.Name = "lbGuestDisplay6";
            this.lbGuestDisplay6.Size = new System.Drawing.Size(58, 25);
            this.lbGuestDisplay6.TabIndex = 25;
            this.lbGuestDisplay6.Text = "label1";
            this.lbGuestDisplay6.Visible = false;
            this.lbGuestDisplay6.Click += new System.EventHandler(this.lbGuestDisplay6_Click);
            // 
            // btnAcceptGuests
            // 
            this.btnAcceptGuests.BackgroundImage = global::lakeside.Properties.Resources.AcceptGuestsButton;
            this.btnAcceptGuests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcceptGuests.Enabled = false;
            this.btnAcceptGuests.Location = new System.Drawing.Point(1, 227);
            this.btnAcceptGuests.Name = "btnAcceptGuests";
            this.btnAcceptGuests.Size = new System.Drawing.Size(250, 57);
            this.btnAcceptGuests.TabIndex = 21;
            this.btnAcceptGuests.UseVisualStyleBackColor = true;
            this.btnAcceptGuests.Click += new System.EventHandler(this.btnAcceptGuests_Click);
            // 
            // btnSelectGuests
            // 
            this.btnSelectGuests.BackgroundImage = global::lakeside.Properties.Resources.SelectGuestsButton;
            this.btnSelectGuests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelectGuests.Location = new System.Drawing.Point(0, 4);
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
            this.btnAddGuest.Location = new System.Drawing.Point(0, 68);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(250, 57);
            this.btnAddGuest.TabIndex = 20;
            this.btnAddGuest.UseVisualStyleBackColor = true;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // pnlGuestSelectionActionGroup
            // 
            this.pnlGuestSelectionActionGroup.Controls.Add(this.btnSelectGuests);
            this.pnlGuestSelectionActionGroup.Controls.Add(this.btnAcceptGuests);
            this.pnlGuestSelectionActionGroup.Controls.Add(this.btnAddGuest);
            this.pnlGuestSelectionActionGroup.Location = new System.Drawing.Point(39, 36);
            this.pnlGuestSelectionActionGroup.Name = "pnlGuestSelectionActionGroup";
            this.pnlGuestSelectionActionGroup.Size = new System.Drawing.Size(254, 285);
            this.pnlGuestSelectionActionGroup.TabIndex = 23;
            // 
            // frmPodBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 498);
            this.Controls.Add(this.pnlCourses);
            this.Controls.Add(this.btnBackToHomeOrMainMenu);
            this.Controls.Add(this.pnlGuests);
            this.Controls.Add(this.lbDebugInfo);
            this.Controls.Add(this.pnlGuestDisplay);
            this.Controls.Add(this.pnlLocationDateDisplay);
            this.Controls.Add(this.dgAvailablePods);
            this.Controls.Add(this.btnDatePickerOpenerSelector);
            this.Controls.Add(this.pnlSundays);
            this.Controls.Add(this.pnlSaturdays);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnConfirmPod);
            this.Controls.Add(this.pnlDatePicker);
            this.Name = "frmPodBooking";
            this.Text = "\\";
            this.Load += new System.EventHandler(this.frmPodBooking_Load);
            this.pnlCalOutside.ResumeLayout(false);
            this.pnlCalOutside.PerformLayout();
            this.pnlDatePicker.ResumeLayout(false);
            this.pnlDatePicker.PerformLayout();
            this.pnlOverflow.ResumeLayout(false);
            this.pnlOverflow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAvailablePods)).EndInit();
            this.pnlLocationDateDisplay.ResumeLayout(false);
            this.pnlLocationDateDisplay.PerformLayout();
            this.pnlGuests.ResumeLayout(false);
            this.pnlGuests.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlGuestDisplay.ResumeLayout(false);
            this.pnlGuestDisplay.PerformLayout();
            this.pnlCourses.ResumeLayout(false);
            this.pnlCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourses)).EndInit();
            this.pnlGuestSelectionActionGroup.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrTick;
        private System.Windows.Forms.Label lbDebugInfo;
        private System.Windows.Forms.Button btnAcceptGuests;
        private System.Windows.Forms.Panel pnlGuestDisplay;
        private System.Windows.Forms.Label lbGuestDisplay;
        private System.Windows.Forms.Label lbGuestsStayingDisplayTitle;
        private System.Windows.Forms.Panel pnlCourses;
        private System.Windows.Forms.Button btnBackToHomeOrMainMenu;
        private System.Windows.Forms.Panel pnlOverflow;
        private System.Windows.Forms.Label lbOverflow;
        private System.Windows.Forms.Label lbOverflowText;
        private System.Windows.Forms.LinkLabel llbChangeDates;
        private System.Windows.Forms.LinkLabel llbChangeGuests;
        private System.Windows.Forms.Label lbGuestDisplay4;
        private System.Windows.Forms.Label lbGuestDisplay3;
        private System.Windows.Forms.Label lbGuestDisplay2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbGuestCoursePickerTitle;
        private System.Windows.Forms.DataGridView dgCourses;
        private System.Windows.Forms.Button btnContinueFromCourseSelection;
        private System.Windows.Forms.Button btnSkipCourseSelection;
        private System.Windows.Forms.Button btnContinueCourseSelection;
        private System.Windows.Forms.Label lbGuestDisplay6;
        private System.Windows.Forms.Label lbGuestDisplay5;
        private System.Windows.Forms.Panel pnlGuestSelectionActionGroup;
    }
}