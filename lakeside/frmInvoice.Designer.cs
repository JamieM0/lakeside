
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
            this.label5 = new System.Windows.Forms.Label();
            this.lbInfoCourseSelected = new System.Windows.Forms.Label();
            this.lbInfoExtraSelected = new System.Windows.Forms.Label();
            this.dgCourseSelected = new System.Windows.Forms.DataGridView();
            this.dgExtraSelected = new System.Windows.Forms.DataGridView();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourseSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExtraSelected)).BeginInit();
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
            this.lbLeadGuestName.AutoSize = true;
            this.lbLeadGuestName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeadGuestName.Location = new System.Drawing.Point(560, 72);
            this.lbLeadGuestName.Name = "lbLeadGuestName";
            this.lbLeadGuestName.Size = new System.Drawing.Size(228, 30);
            this.lbLeadGuestName.TabIndex = 4;
            this.lbLeadGuestName.Text = "Lead Guest Name Here";
            this.lbLeadGuestName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(367, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thank you for staying at Lakeside Escapes!";
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
            this.dgCourseSelected.Size = new System.Drawing.Size(484, 119);
            this.dgCourseSelected.TabIndex = 15;
            // 
            // dgExtraSelected
            // 
            this.dgExtraSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExtraSelected.Location = new System.Drawing.Point(17, 307);
            this.dgExtraSelected.Name = "dgExtraSelected";
            this.dgExtraSelected.Size = new System.Drawing.Size(372, 104);
            this.dgExtraSelected.TabIndex = 16;
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
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgExtraSelected);
            this.Controls.Add(this.dgCourseSelected);
            this.Controls.Add(this.lbInfoExtraSelected);
            this.Controls.Add(this.lbInfoCourseSelected);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbInfoLeadGuestName);
            this.Controls.Add(this.lbLeadGuestName);
            this.Controls.Add(this.lbInfoPodName);
            this.Controls.Add(this.lbPodName);
            this.Controls.Add(this.lbInfoDate);
            this.Controls.Add(this.lbDate);
            this.Name = "frmInvoice";
            this.Text = "Lakeside Escapes: Invoice";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCourseSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExtraSelected)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbInfoCourseSelected;
        private System.Windows.Forms.Label lbInfoExtraSelected;
        private System.Windows.Forms.DataGridView dgCourseSelected;
        private System.Windows.Forms.DataGridView dgExtraSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}