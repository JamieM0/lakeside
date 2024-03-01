
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.lbInfoPodName.Location = new System.Drawing.Point(350, 51);
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
            this.lbPodName.Location = new System.Drawing.Point(324, 72);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(616, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "GuestAddressLine1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(629, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "GuestAddressCity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(585, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "GuestAddressPostcode";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(594, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "GuestAddressCountry";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(468, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thank you for staying at Lakeside Escapes!";
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbInfoLeadGuestName);
            this.Controls.Add(this.lbLeadGuestName);
            this.Controls.Add(this.lbInfoPodName);
            this.Controls.Add(this.lbPodName);
            this.Controls.Add(this.lbInfoDate);
            this.Controls.Add(this.lbDate);
            this.Name = "frmInvoice";
            this.Text = "Lakeside Escapes: Invoice";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}