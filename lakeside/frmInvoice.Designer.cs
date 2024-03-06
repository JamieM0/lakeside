﻿
namespace lakeside
{
    partial class frmInvoice
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
            this.lbDate = new System.Windows.Forms.Label();
            this.lbInfoDate = new System.Windows.Forms.Label();
            this.lbInfoPodName = new System.Windows.Forms.Label();
            this.lbPodName = new System.Windows.Forms.Label();
            this.lbInfoLeadGuestName = new System.Windows.Forms.Label();
            this.lbLeadGuestName = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbInfoCourseSelected = new System.Windows.Forms.Label();
            this.lbInfoExtraSelected = new System.Windows.Forms.Label();
            this.dgCourseSelected = new System.Windows.Forms.DataGridView();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgExtraSelected = new System.Windows.Forms.DataGridView();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.lbPodCalculationsPodName = new System.Windows.Forms.Label();
            this.lbPodCalculationsGuestCount = new System.Windows.Forms.Label();
            this.lbPodCalculationsNightStayingCount = new System.Windows.Forms.Label();
            this.lbPodCalculationsPrice = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.pnlPaymentWindow = new System.Windows.Forms.Panel();
            this.lbCardNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbNameOnCard = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lbCVV = new System.Windows.Forms.Label();
            this.lbCardDate = new System.Windows.Forms.Label();
            this.dtpCardDate = new System.Windows.Forms.DateTimePicker();
            this.btnPayNow = new System.Windows.Forms.Button();
            this.lbCardNumberError = new System.Windows.Forms.Label();
            this.lbNameOnCardError = new System.Windows.Forms.Label();
            this.lbCVVError = new System.Windows.Forms.Label();
            this.lbCardDateError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourseSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExtraSelected)).BeginInit();
            this.pnlPaymentWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(12, 72);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(207, 30);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "01 March - 05 March";
            // 
            // lbInfoDate
            // 
            this.lbInfoDate.AutoSize = true;
            this.lbInfoDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoDate.Location = new System.Drawing.Point(12, 51);
            this.lbInfoDate.Name = "lbInfoDate";
            this.lbInfoDate.Size = new System.Drawing.Size(93, 21);
            this.lbInfoDate.TabIndex = 1;
            this.lbInfoDate.Text = "Date of Stay";
            // 
            // lbInfoPodName
            // 
            this.lbInfoPodName.AutoSize = true;
            this.lbInfoPodName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoPodName.Location = new System.Drawing.Point(353, 51);
            this.lbInfoPodName.Name = "lbInfoPodName";
            this.lbInfoPodName.Size = new System.Drawing.Size(102, 21);
            this.lbInfoPodName.TabIndex = 3;
            this.lbInfoPodName.Text = "Pod stayed in";
            this.lbInfoPodName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbInfoPodName.TextChanged += new System.EventHandler(this.lbInfoPodName_TextChanged);
            // 
            // lbPodName
            // 
            this.lbPodName.AutoSize = true;
            this.lbPodName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPodName.Location = new System.Drawing.Point(327, 72);
            this.lbPodName.Name = "lbPodName";
            this.lbPodName.Size = new System.Drawing.Size(160, 30);
            this.lbPodName.TabIndex = 2;
            this.lbPodName.Text = "Pod Name Here";
            this.lbPodName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbPodName.TextChanged += new System.EventHandler(this.lbPodName_TextChanged);
            // 
            // lbInfoLeadGuestName
            // 
            this.lbInfoLeadGuestName.AutoSize = true;
            this.lbInfoLeadGuestName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoLeadGuestName.Location = new System.Drawing.Point(645, 51);
            this.lbInfoLeadGuestName.Name = "lbInfoLeadGuestName";
            this.lbInfoLeadGuestName.Size = new System.Drawing.Size(143, 21);
            this.lbInfoLeadGuestName.TabIndex = 5;
            this.lbInfoLeadGuestName.Text = "Lead/Billable Guest";
            this.lbInfoLeadGuestName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbLeadGuestName
            // 
            this.lbLeadGuestName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeadGuestName.Location = new System.Drawing.Point(560, 72);
            this.lbLeadGuestName.Name = "lbLeadGuestName";
            this.lbLeadGuestName.Size = new System.Drawing.Size(228, 30);
            this.lbLeadGuestName.TabIndex = 4;
            this.lbLeadGuestName.Text = "Lead Guest Name Here";
            this.lbLeadGuestName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(239, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(304, 21);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "Thank you for staying at Lakeside Escapes!";
            // 
            // lbInfoCourseSelected
            // 
            this.lbInfoCourseSelected.AutoSize = true;
            this.lbInfoCourseSelected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoCourseSelected.Location = new System.Drawing.Point(12, 113);
            this.lbInfoCourseSelected.Name = "lbInfoCourseSelected";
            this.lbInfoCourseSelected.Size = new System.Drawing.Size(121, 21);
            this.lbInfoCourseSelected.TabIndex = 12;
            this.lbInfoCourseSelected.Text = "Course Selected";
            // 
            // lbInfoExtraSelected
            // 
            this.lbInfoExtraSelected.AutoSize = true;
            this.lbInfoExtraSelected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoExtraSelected.Location = new System.Drawing.Point(13, 283);
            this.lbInfoExtraSelected.Name = "lbInfoExtraSelected";
            this.lbInfoExtraSelected.Size = new System.Drawing.Size(106, 21);
            this.lbInfoExtraSelected.TabIndex = 14;
            this.lbInfoExtraSelected.Text = "Extra Selected";
            // 
            // dgCourseSelected
            // 
            this.dgCourseSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCourseSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantity,
            this.CouseName,
            this.PricePN,
            this.TotalPrice});
            this.dgCourseSelected.Location = new System.Drawing.Point(16, 137);
            this.dgCourseSelected.Name = "dgCourseSelected";
            this.dgCourseSelected.Size = new System.Drawing.Size(449, 143);
            this.dgCourseSelected.TabIndex = 15;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Number of Guests";
            this.Quantity.Name = "Quantity";
            // 
            // CouseName
            // 
            this.CouseName.HeaderText = "Course Name";
            this.CouseName.Name = "CouseName";
            // 
            // PricePN
            // 
            this.PricePN.HeaderText = "Price / Guest";
            this.PricePN.Name = "PricePN";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // dgExtraSelected
            // 
            this.dgExtraSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExtraSelected.Location = new System.Drawing.Point(17, 307);
            this.dgExtraSelected.Name = "dgExtraSelected";
            this.dgExtraSelected.Size = new System.Drawing.Size(448, 131);
            this.dgExtraSelected.TabIndex = 16;
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakePayment.Location = new System.Drawing.Point(608, 393);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(180, 45);
            this.btnMakePayment.TabIndex = 18;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // lbPodCalculationsPodName
            // 
            this.lbPodCalculationsPodName.AutoSize = true;
            this.lbPodCalculationsPodName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPodCalculationsPodName.Location = new System.Drawing.Point(499, 137);
            this.lbPodCalculationsPodName.Name = "lbPodCalculationsPodName";
            this.lbPodCalculationsPodName.Size = new System.Drawing.Size(255, 60);
            this.lbPodCalculationsPodName.TabIndex = 19;
            this.lbPodCalculationsPodName.Text = "Pod Name Here \r\n@ £20 per guest per night";
            this.lbPodCalculationsPodName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPodCalculationsGuestCount
            // 
            this.lbPodCalculationsGuestCount.AutoSize = true;
            this.lbPodCalculationsGuestCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPodCalculationsGuestCount.Location = new System.Drawing.Point(526, 197);
            this.lbPodCalculationsGuestCount.Name = "lbPodCalculationsGuestCount";
            this.lbPodCalculationsGuestCount.Size = new System.Drawing.Size(95, 25);
            this.lbPodCalculationsGuestCount.TabIndex = 20;
            this.lbPodCalculationsGuestCount.Text = "x 6 guests";
            this.lbPodCalculationsGuestCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPodCalculationsNightStayingCount
            // 
            this.lbPodCalculationsNightStayingCount.AutoSize = true;
            this.lbPodCalculationsNightStayingCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPodCalculationsNightStayingCount.Location = new System.Drawing.Point(526, 222);
            this.lbPodCalculationsNightStayingCount.Name = "lbPodCalculationsNightStayingCount";
            this.lbPodCalculationsNightStayingCount.Size = new System.Drawing.Size(95, 25);
            this.lbPodCalculationsNightStayingCount.TabIndex = 21;
            this.lbPodCalculationsNightStayingCount.Text = "x 6 guests";
            this.lbPodCalculationsNightStayingCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPodCalculationsPrice
            // 
            this.lbPodCalculationsPrice.AutoSize = true;
            this.lbPodCalculationsPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPodCalculationsPrice.Location = new System.Drawing.Point(499, 250);
            this.lbPodCalculationsPrice.Name = "lbPodCalculationsPrice";
            this.lbPodCalculationsPrice.Size = new System.Drawing.Size(69, 30);
            this.lbPodCalculationsPrice.TabIndex = 22;
            this.lbPodCalculationsPrice.Text = "£Price";
            this.lbPodCalculationsPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(504, 331);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(284, 37);
            this.lbTotalPrice.TabIndex = 23;
            this.lbTotalPrice.Text = "£Price";
            this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlPaymentWindow
            // 
            this.pnlPaymentWindow.Controls.Add(this.lbCardDateError);
            this.pnlPaymentWindow.Controls.Add(this.lbCVVError);
            this.pnlPaymentWindow.Controls.Add(this.lbNameOnCardError);
            this.pnlPaymentWindow.Controls.Add(this.lbCardNumberError);
            this.pnlPaymentWindow.Controls.Add(this.btnPayNow);
            this.pnlPaymentWindow.Controls.Add(this.dtpCardDate);
            this.pnlPaymentWindow.Controls.Add(this.lbCardDate);
            this.pnlPaymentWindow.Controls.Add(this.txtCVV);
            this.pnlPaymentWindow.Controls.Add(this.lbCVV);
            this.pnlPaymentWindow.Controls.Add(this.textBox1);
            this.pnlPaymentWindow.Controls.Add(this.lbNameOnCard);
            this.pnlPaymentWindow.Controls.Add(this.txtCardNumber);
            this.pnlPaymentWindow.Controls.Add(this.lbCardNumber);
            this.pnlPaymentWindow.Location = new System.Drawing.Point(7, 113);
            this.pnlPaymentWindow.Name = "pnlPaymentWindow";
            this.pnlPaymentWindow.Size = new System.Drawing.Size(486, 335);
            this.pnlPaymentWindow.TabIndex = 24;
            this.pnlPaymentWindow.Visible = false;
            // 
            // lbCardNumber
            // 
            this.lbCardNumber.AutoSize = true;
            this.lbCardNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCardNumber.Location = new System.Drawing.Point(52, 21);
            this.lbCardNumber.Name = "lbCardNumber";
            this.lbCardNumber.Size = new System.Drawing.Size(108, 21);
            this.lbCardNumber.TabIndex = 0;
            this.lbCardNumber.Text = "Card Number:";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(166, 18);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(276, 29);
            this.txtCardNumber.TabIndex = 1;
            this.txtCardNumber.TextChanged += new System.EventHandler(this.txtCardNumber_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(166, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 29);
            this.textBox1.TabIndex = 3;
            // 
            // lbNameOnCard
            // 
            this.lbNameOnCard.AutoSize = true;
            this.lbNameOnCard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameOnCard.Location = new System.Drawing.Point(43, 84);
            this.lbNameOnCard.Name = "lbNameOnCard";
            this.lbNameOnCard.Size = new System.Drawing.Size(117, 21);
            this.lbNameOnCard.TabIndex = 2;
            this.lbNameOnCard.Text = "Name On Card:";
            // 
            // txtCVV
            // 
            this.txtCVV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVV.Location = new System.Drawing.Point(165, 141);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.PasswordChar = '*';
            this.txtCVV.Size = new System.Drawing.Size(146, 29);
            this.txtCVV.TabIndex = 5;
            // 
            // lbCVV
            // 
            this.lbCVV.AutoSize = true;
            this.lbCVV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCVV.Location = new System.Drawing.Point(6, 144);
            this.lbCVV.Name = "lbCVV";
            this.lbCVV.Size = new System.Drawing.Size(153, 21);
            this.lbCVV.TabIndex = 4;
            this.lbCVV.Text = "CVV / Security Code:";
            // 
            // lbCardDate
            // 
            this.lbCardDate.AutoSize = true;
            this.lbCardDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCardDate.Location = new System.Drawing.Point(47, 204);
            this.lbCardDate.Name = "lbCardDate";
            this.lbCardDate.Size = new System.Drawing.Size(112, 21);
            this.lbCardDate.TabIndex = 6;
            this.lbCardDate.Text = "Card End Date:";
            // 
            // dtpCardDate
            // 
            this.dtpCardDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCardDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCardDate.Location = new System.Drawing.Point(165, 201);
            this.dtpCardDate.Name = "dtpCardDate";
            this.dtpCardDate.Size = new System.Drawing.Size(133, 29);
            this.dtpCardDate.TabIndex = 7;
            // 
            // btnPayNow
            // 
            this.btnPayNow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayNow.Location = new System.Drawing.Point(300, 266);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(180, 45);
            this.btnPayNow.TabIndex = 25;
            this.btnPayNow.Text = "Pay Now";
            this.btnPayNow.UseVisualStyleBackColor = true;
            this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
            // 
            // lbCardNumberError
            // 
            this.lbCardNumberError.AutoSize = true;
            this.lbCardNumberError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCardNumberError.ForeColor = System.Drawing.Color.Red;
            this.lbCardNumberError.Location = new System.Drawing.Point(163, 49);
            this.lbCardNumberError.Name = "lbCardNumberError";
            this.lbCardNumberError.Size = new System.Drawing.Size(125, 17);
            this.lbCardNumberError.TabIndex = 26;
            this.lbCardNumberError.Text = "Card Number: Error";
            this.lbCardNumberError.Visible = false;
            // 
            // lbNameOnCardError
            // 
            this.lbNameOnCardError.AutoSize = true;
            this.lbNameOnCardError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameOnCardError.ForeColor = System.Drawing.Color.Red;
            this.lbNameOnCardError.Location = new System.Drawing.Point(163, 113);
            this.lbNameOnCardError.Name = "lbNameOnCardError";
            this.lbNameOnCardError.Size = new System.Drawing.Size(125, 17);
            this.lbNameOnCardError.TabIndex = 27;
            this.lbNameOnCardError.Text = "Card Number: Error";
            this.lbNameOnCardError.Visible = false;
            // 
            // lbCVVError
            // 
            this.lbCVVError.AutoSize = true;
            this.lbCVVError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCVVError.ForeColor = System.Drawing.Color.Red;
            this.lbCVVError.Location = new System.Drawing.Point(163, 174);
            this.lbCVVError.Name = "lbCVVError";
            this.lbCVVError.Size = new System.Drawing.Size(125, 17);
            this.lbCVVError.TabIndex = 28;
            this.lbCVVError.Text = "Card Number: Error";
            this.lbCVVError.Visible = false;
            // 
            // lbCardDateError
            // 
            this.lbCardDateError.AutoSize = true;
            this.lbCardDateError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCardDateError.ForeColor = System.Drawing.Color.Red;
            this.lbCardDateError.Location = new System.Drawing.Point(163, 234);
            this.lbCardDateError.Name = "lbCardDateError";
            this.lbCardDateError.Size = new System.Drawing.Size(125, 17);
            this.lbCardDateError.TabIndex = 29;
            this.lbCardDateError.Text = "Card Number: Error";
            this.lbCardDateError.Visible = false;
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPaymentWindow);
            this.Controls.Add(this.lbPodCalculationsPrice);
            this.Controls.Add(this.lbPodCalculationsNightStayingCount);
            this.Controls.Add(this.lbPodCalculationsGuestCount);
            this.Controls.Add(this.lbPodCalculationsPodName);
            this.Controls.Add(this.btnMakePayment);
            this.Controls.Add(this.dgExtraSelected);
            this.Controls.Add(this.dgCourseSelected);
            this.Controls.Add(this.lbInfoExtraSelected);
            this.Controls.Add(this.lbInfoCourseSelected);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbInfoLeadGuestName);
            this.Controls.Add(this.lbLeadGuestName);
            this.Controls.Add(this.lbInfoPodName);
            this.Controls.Add(this.lbPodName);
            this.Controls.Add(this.lbInfoDate);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbTotalPrice);
            this.Name = "frmInvoice";
            this.Text = "Lakeside Escapes: Invoice";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCourseSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExtraSelected)).EndInit();
            this.pnlPaymentWindow.ResumeLayout(false);
            this.pnlPaymentWindow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbInfoDate;
        private System.Windows.Forms.Label lbInfoPodName;
        private System.Windows.Forms.Label lbPodName;
        private System.Windows.Forms.Label lbInfoLeadGuestName;
        private System.Windows.Forms.Label lbLeadGuestName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbInfoCourseSelected;
        private System.Windows.Forms.Label lbInfoExtraSelected;
        private System.Windows.Forms.DataGridView dgCourseSelected;
        private System.Windows.Forms.DataGridView dgExtraSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Label lbPodCalculationsPodName;
        private System.Windows.Forms.Label lbPodCalculationsGuestCount;
        private System.Windows.Forms.Label lbPodCalculationsNightStayingCount;
        private System.Windows.Forms.Label lbPodCalculationsPrice;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Panel pnlPaymentWindow;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbNameOnCard;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lbCardNumber;
        private System.Windows.Forms.DateTimePicker dtpCardDate;
        private System.Windows.Forms.Label lbCardDate;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label lbCVV;
        private System.Windows.Forms.Button btnPayNow;
        private System.Windows.Forms.Label lbCardDateError;
        private System.Windows.Forms.Label lbCVVError;
        private System.Windows.Forms.Label lbNameOnCardError;
        private System.Windows.Forms.Label lbCardNumberError;
    }
}