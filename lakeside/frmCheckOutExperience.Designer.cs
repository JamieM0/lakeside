
namespace lakeside
{
    partial class frmCheckOutExperience
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDatePickerStayLength = new System.Windows.Forms.ComboBox();
            this.lbNights = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.pnlStayLength = new System.Windows.Forms.Panel();
            this.pnlPodNamePanel = new System.Windows.Forms.Panel();
            this.lbPodName = new System.Windows.Forms.Label();
            this.dtpBookingEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpBookingStart = new System.Windows.Forms.DateTimePicker();
            this.lbDateRange = new System.Windows.Forms.Label();
            this.pnlPodChooser = new System.Windows.Forms.Panel();
            this.dgPods = new System.Windows.Forms.DataGridView();
            this.lbInstructionsForThePodPickerOrPodChooserOrPodSelector = new System.Windows.Forms.Label();
            this.btnBackToHomeOrMainMenu = new System.Windows.Forms.Button();
            this.pnlBookingOverview = new System.Windows.Forms.Panel();
            this.lbBookingOverview = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.pnlProceedToInvoiceIcon = new System.Windows.Forms.Panel();
            this.pnlReturnIcon = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbPodInfo = new System.Windows.Forms.Label();
            this.lbDatesInfo = new System.Windows.Forms.Label();
            this.lbGuestsInfo = new System.Windows.Forms.Label();
            this.lbPodBookedOverview = new System.Windows.Forms.Label();
            this.lbDatesBookedOverview = new System.Windows.Forms.Label();
            this.lbGuestsStayingOverview = new System.Windows.Forms.Label();
            this.pnlStayLength.SuspendLayout();
            this.pnlPodNamePanel.SuspendLayout();
            this.pnlPodChooser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPods)).BeginInit();
            this.pnlBookingOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "How long was your stay for?";
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
            this.cmbDatePickerStayLength.Location = new System.Drawing.Point(67, 43);
            this.cmbDatePickerStayLength.Name = "cmbDatePickerStayLength";
            this.cmbDatePickerStayLength.Size = new System.Drawing.Size(45, 33);
            this.cmbDatePickerStayLength.TabIndex = 13;
            this.cmbDatePickerStayLength.SelectedIndexChanged += new System.EventHandler(this.cmbDatePickerStayLength_SelectedIndexChanged);
            // 
            // lbNights
            // 
            this.lbNights.AutoSize = true;
            this.lbNights.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNights.Location = new System.Drawing.Point(118, 46);
            this.lbNights.Name = "lbNights";
            this.lbNights.Size = new System.Drawing.Size(67, 25);
            this.lbNights.TabIndex = 14;
            this.lbNights.Text = "Nights";
            // 
            // btnContinue
            // 
            this.btnContinue.Enabled = false;
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(0, 155);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(244, 40);
            this.btnContinue.TabIndex = 15;
            this.btnContinue.Text = "Continue -->";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // pnlStayLength
            // 
            this.pnlStayLength.Controls.Add(this.pnlPodNamePanel);
            this.pnlStayLength.Controls.Add(this.dtpBookingEnd);
            this.pnlStayLength.Controls.Add(this.dtpBookingStart);
            this.pnlStayLength.Controls.Add(this.btnContinue);
            this.pnlStayLength.Controls.Add(this.lbDateRange);
            this.pnlStayLength.Controls.Add(this.label1);
            this.pnlStayLength.Controls.Add(this.cmbDatePickerStayLength);
            this.pnlStayLength.Controls.Add(this.lbNights);
            this.pnlStayLength.Location = new System.Drawing.Point(222, 128);
            this.pnlStayLength.Name = "pnlStayLength";
            this.pnlStayLength.Size = new System.Drawing.Size(246, 198);
            this.pnlStayLength.TabIndex = 16;
            // 
            // pnlPodNamePanel
            // 
            this.pnlPodNamePanel.Controls.Add(this.lbPodName);
            this.pnlPodNamePanel.Location = new System.Drawing.Point(3, 120);
            this.pnlPodNamePanel.Name = "pnlPodNamePanel";
            this.pnlPodNamePanel.Size = new System.Drawing.Size(240, 21);
            this.pnlPodNamePanel.TabIndex = 23;
            // 
            // lbPodName
            // 
            this.lbPodName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPodName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPodName.Location = new System.Drawing.Point(0, 0);
            this.lbPodName.Name = "lbPodName";
            this.lbPodName.Size = new System.Drawing.Size(240, 21);
            this.lbPodName.TabIndex = 18;
            this.lbPodName.Text = "PodNameGoesHereThanks";
            this.lbPodName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPodName.Visible = false;
            // 
            // dtpBookingEnd
            // 
            this.dtpBookingEnd.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingEnd.Enabled = false;
            this.dtpBookingEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookingEnd.Location = new System.Drawing.Point(152, 84);
            this.dtpBookingEnd.Name = "dtpBookingEnd";
            this.dtpBookingEnd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpBookingEnd.Size = new System.Drawing.Size(75, 29);
            this.dtpBookingEnd.TabIndex = 20;
            this.dtpBookingEnd.Visible = false;
            // 
            // dtpBookingStart
            // 
            this.dtpBookingStart.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookingStart.Location = new System.Drawing.Point(19, 85);
            this.dtpBookingStart.Name = "dtpBookingStart";
            this.dtpBookingStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpBookingStart.Size = new System.Drawing.Size(75, 29);
            this.dtpBookingStart.TabIndex = 19;
            this.dtpBookingStart.Visible = false;
            this.dtpBookingStart.ValueChanged += new System.EventHandler(this.dtpBookingStart_ValueChanged);
            // 
            // lbDateRange
            // 
            this.lbDateRange.AutoSize = true;
            this.lbDateRange.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateRange.Location = new System.Drawing.Point(100, 83);
            this.lbDateRange.Name = "lbDateRange";
            this.lbDateRange.Size = new System.Drawing.Size(50, 30);
            this.lbDateRange.TabIndex = 17;
            this.lbDateRange.Text = " -->";
            this.lbDateRange.Visible = false;
            // 
            // pnlPodChooser
            // 
            this.pnlPodChooser.Controls.Add(this.dgPods);
            this.pnlPodChooser.Controls.Add(this.lbInstructionsForThePodPickerOrPodChooserOrPodSelector);
            this.pnlPodChooser.Location = new System.Drawing.Point(273, 115);
            this.pnlPodChooser.Name = "pnlPodChooser";
            this.pnlPodChooser.Size = new System.Drawing.Size(293, 230);
            this.pnlPodChooser.TabIndex = 17;
            this.pnlPodChooser.Visible = false;
            // 
            // dgPods
            // 
            this.dgPods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPods.Location = new System.Drawing.Point(8, 36);
            this.dgPods.MultiSelect = false;
            this.dgPods.Name = "dgPods";
            this.dgPods.ReadOnly = true;
            this.dgPods.Size = new System.Drawing.Size(274, 187);
            this.dgPods.TabIndex = 1;
            this.dgPods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPods_CellClick);
            // 
            // lbInstructionsForThePodPickerOrPodChooserOrPodSelector
            // 
            this.lbInstructionsForThePodPickerOrPodChooserOrPodSelector.AutoSize = true;
            this.lbInstructionsForThePodPickerOrPodChooserOrPodSelector.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstructionsForThePodPickerOrPodChooserOrPodSelector.Location = new System.Drawing.Point(3, 8);
            this.lbInstructionsForThePodPickerOrPodChooserOrPodSelector.Name = "lbInstructionsForThePodPickerOrPodChooserOrPodSelector";
            this.lbInstructionsForThePodPickerOrPodChooserOrPodSelector.Size = new System.Drawing.Size(173, 25);
            this.lbInstructionsForThePodPickerOrPodChooserOrPodSelector.TabIndex = 0;
            this.lbInstructionsForThePodPickerOrPodChooserOrPodSelector.Text = "Please Select a Pod";
            // 
            // btnBackToHomeOrMainMenu
            // 
            this.btnBackToHomeOrMainMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToHomeOrMainMenu.Location = new System.Drawing.Point(561, 2);
            this.btnBackToHomeOrMainMenu.Name = "btnBackToHomeOrMainMenu";
            this.btnBackToHomeOrMainMenu.Size = new System.Drawing.Size(137, 55);
            this.btnBackToHomeOrMainMenu.TabIndex = 22;
            this.btnBackToHomeOrMainMenu.Text = "Cancel \r\nCheck Out";
            this.btnBackToHomeOrMainMenu.UseVisualStyleBackColor = true;
            this.btnBackToHomeOrMainMenu.Click += new System.EventHandler(this.btnBackToHomeOrMainMenu_Click);
            // 
            // pnlBookingOverview
            // 
            this.pnlBookingOverview.Controls.Add(this.lbGuestsStayingOverview);
            this.pnlBookingOverview.Controls.Add(this.lbDatesBookedOverview);
            this.pnlBookingOverview.Controls.Add(this.lbPodBookedOverview);
            this.pnlBookingOverview.Controls.Add(this.lbGuestsInfo);
            this.pnlBookingOverview.Controls.Add(this.lbDatesInfo);
            this.pnlBookingOverview.Controls.Add(this.lbPodInfo);
            this.pnlBookingOverview.Controls.Add(this.pnlProceedToInvoiceIcon);
            this.pnlBookingOverview.Controls.Add(this.btnProceed);
            this.pnlBookingOverview.Controls.Add(this.pnlReturnIcon);
            this.pnlBookingOverview.Controls.Add(this.btnGoBack);
            this.pnlBookingOverview.Controls.Add(this.lbBookingOverview);
            this.pnlBookingOverview.Location = new System.Drawing.Point(275, 102);
            this.pnlBookingOverview.Name = "pnlBookingOverview";
            this.pnlBookingOverview.Size = new System.Drawing.Size(425, 230);
            this.pnlBookingOverview.TabIndex = 23;
            this.pnlBookingOverview.Visible = false;
            // 
            // lbBookingOverview
            // 
            this.lbBookingOverview.AutoSize = true;
            this.lbBookingOverview.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookingOverview.Location = new System.Drawing.Point(141, 8);
            this.lbBookingOverview.Name = "lbBookingOverview";
            this.lbBookingOverview.Size = new System.Drawing.Size(167, 30);
            this.lbBookingOverview.TabIndex = 0;
            this.lbBookingOverview.Text = "Booking Located";
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnGoBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Location = new System.Drawing.Point(12, 180);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(147, 43);
            this.btnGoBack.TabIndex = 1;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.SystemColors.Control;
            this.btnProceed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.Location = new System.Drawing.Point(165, 180);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(251, 43);
            this.btnProceed.TabIndex = 25;
            this.btnProceed.Text = "Proceed to Invoice";
            this.btnProceed.UseVisualStyleBackColor = false;
            // 
            // pnlProceedToInvoiceIcon
            // 
            this.pnlProceedToInvoiceIcon.BackColor = System.Drawing.SystemColors.Control;
            this.pnlProceedToInvoiceIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlProceedToInvoiceIcon.Location = new System.Drawing.Point(375, 13);
            this.pnlProceedToInvoiceIcon.Name = "pnlProceedToInvoiceIcon";
            this.pnlProceedToInvoiceIcon.Size = new System.Drawing.Size(41, 29);
            this.pnlProceedToInvoiceIcon.TabIndex = 26;
            // 
            // pnlReturnIcon
            // 
            this.pnlReturnIcon.BackColor = System.Drawing.SystemColors.Control;
            this.pnlReturnIcon.BackgroundImage = global::lakeside.Properties.Resources.returnIcon;
            this.pnlReturnIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlReturnIcon.Location = new System.Drawing.Point(16, 187);
            this.pnlReturnIcon.Name = "pnlReturnIcon";
            this.pnlReturnIcon.Size = new System.Drawing.Size(39, 29);
            this.pnlReturnIcon.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::lakeside.Properties.Resources.Full_Main_Logo__White_;
            this.pictureBox1.Location = new System.Drawing.Point(121, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbPodInfo
            // 
            this.lbPodInfo.AutoSize = true;
            this.lbPodInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPodInfo.Location = new System.Drawing.Point(43, 57);
            this.lbPodInfo.Name = "lbPodInfo";
            this.lbPodInfo.Size = new System.Drawing.Size(116, 25);
            this.lbPodInfo.TabIndex = 27;
            this.lbPodInfo.Text = "Pod Booked:";
            // 
            // lbDatesInfo
            // 
            this.lbDatesInfo.AutoSize = true;
            this.lbDatesInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatesInfo.Location = new System.Drawing.Point(28, 93);
            this.lbDatesInfo.Name = "lbDatesInfo";
            this.lbDatesInfo.Size = new System.Drawing.Size(131, 25);
            this.lbDatesInfo.TabIndex = 28;
            this.lbDatesInfo.Text = "Dates Booked:";
            // 
            // lbGuestsInfo
            // 
            this.lbGuestsInfo.AutoSize = true;
            this.lbGuestsInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuestsInfo.Location = new System.Drawing.Point(21, 130);
            this.lbGuestsInfo.Name = "lbGuestsInfo";
            this.lbGuestsInfo.Size = new System.Drawing.Size(138, 25);
            this.lbGuestsInfo.TabIndex = 29;
            this.lbGuestsInfo.Text = "Guests Staying:";
            // 
            // lbPodBookedOverview
            // 
            this.lbPodBookedOverview.AutoSize = true;
            this.lbPodBookedOverview.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPodBookedOverview.Location = new System.Drawing.Point(160, 57);
            this.lbPodBookedOverview.Name = "lbPodBookedOverview";
            this.lbPodBookedOverview.Size = new System.Drawing.Size(115, 25);
            this.lbPodBookedOverview.TabIndex = 30;
            this.lbPodBookedOverview.Text = "Pod Booked:";
            // 
            // lbDatesBookedOverview
            // 
            this.lbDatesBookedOverview.AutoSize = true;
            this.lbDatesBookedOverview.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatesBookedOverview.Location = new System.Drawing.Point(160, 93);
            this.lbDatesBookedOverview.Name = "lbDatesBookedOverview";
            this.lbDatesBookedOverview.Size = new System.Drawing.Size(115, 25);
            this.lbDatesBookedOverview.TabIndex = 31;
            this.lbDatesBookedOverview.Text = "Pod Booked:";
            // 
            // lbGuestsStayingOverview
            // 
            this.lbGuestsStayingOverview.AutoSize = true;
            this.lbGuestsStayingOverview.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuestsStayingOverview.Location = new System.Drawing.Point(160, 130);
            this.lbGuestsStayingOverview.Name = "lbGuestsStayingOverview";
            this.lbGuestsStayingOverview.Size = new System.Drawing.Size(115, 25);
            this.lbGuestsStayingOverview.TabIndex = 32;
            this.lbGuestsStayingOverview.Text = "Pod Booked:";
            // 
            // frmCheckOutExperience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 350);
            this.Controls.Add(this.pnlBookingOverview);
            this.Controls.Add(this.btnBackToHomeOrMainMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlStayLength);
            this.Controls.Add(this.pnlPodChooser);
            this.Name = "frmCheckOutExperience";
            this.Text = "Lakeside Escapes: Check Out Experience";
            this.Load += new System.EventHandler(this.frmCheckOutExperience_Load);
            this.pnlStayLength.ResumeLayout(false);
            this.pnlStayLength.PerformLayout();
            this.pnlPodNamePanel.ResumeLayout(false);
            this.pnlPodChooser.ResumeLayout(false);
            this.pnlPodChooser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPods)).EndInit();
            this.pnlBookingOverview.ResumeLayout(false);
            this.pnlBookingOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDatePickerStayLength;
        private System.Windows.Forms.Label lbNights;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Panel pnlStayLength;
        private System.Windows.Forms.Label lbDateRange;
        private System.Windows.Forms.Panel pnlPodChooser;
        private System.Windows.Forms.Label lbInstructionsForThePodPickerOrPodChooserOrPodSelector;
        private System.Windows.Forms.DataGridView dgPods;
        private System.Windows.Forms.Label lbPodName;
        private System.Windows.Forms.DateTimePicker dtpBookingEnd;
        private System.Windows.Forms.DateTimePicker dtpBookingStart;
        private System.Windows.Forms.Button btnBackToHomeOrMainMenu;
        private System.Windows.Forms.Panel pnlPodNamePanel;
        private System.Windows.Forms.Panel pnlBookingOverview;
        private System.Windows.Forms.Panel pnlReturnIcon;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lbBookingOverview;
        private System.Windows.Forms.Panel pnlProceedToInvoiceIcon;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Label lbGuestsInfo;
        private System.Windows.Forms.Label lbDatesInfo;
        private System.Windows.Forms.Label lbPodInfo;
        private System.Windows.Forms.Label lbGuestsStayingOverview;
        private System.Windows.Forms.Label lbDatesBookedOverview;
        private System.Windows.Forms.Label lbPodBookedOverview;
    }
}