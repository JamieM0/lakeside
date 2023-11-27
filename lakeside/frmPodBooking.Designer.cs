
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
            this.lbDayTitles = new System.Windows.Forms.Label();
            this.pnlCalOutside.SuspendLayout();
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
            this.pnlCalContainer.Location = new System.Drawing.Point(64, 49);
            this.pnlCalContainer.Name = "pnlCalContainer";
            this.pnlCalContainer.Size = new System.Drawing.Size(416, 307);
            this.pnlCalContainer.TabIndex = 7;
            // 
            // pnlCalOutside
            // 
            this.pnlCalOutside.Controls.Add(this.lbDayTitles);
            this.pnlCalOutside.Controls.Add(this.pnlCalContainer);
            this.pnlCalOutside.Location = new System.Drawing.Point(247, 42);
            this.pnlCalOutside.Name = "pnlCalOutside";
            this.pnlCalOutside.Size = new System.Drawing.Size(541, 387);
            this.pnlCalOutside.TabIndex = 8;
            // 
            // lbDayTitles
            // 
            this.lbDayTitles.AutoSize = true;
            this.lbDayTitles.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDayTitles.Location = new System.Drawing.Point(59, 4);
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
    }
}