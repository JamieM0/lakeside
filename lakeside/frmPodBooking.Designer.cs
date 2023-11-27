
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
            this.pnlCalContainer = new System.Windows.Forms.Panel();
            this.pnlCalBase2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMondays = new System.Windows.Forms.Panel();
            this.pnlTuesdays = new System.Windows.Forms.Panel();
            this.pnlWednesdays = new System.Windows.Forms.Panel();
            this.pnlThursdays = new System.Windows.Forms.Panel();
            this.pnlFridays = new System.Windows.Forms.Panel();
            this.pnlSaturdays = new System.Windows.Forms.Panel();
            this.pnlSundays = new System.Windows.Forms.Panel();
            this.pnlCalContainer.SuspendLayout();
            this.pnlCalBase2.SuspendLayout();
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
            // pnlCalContainer
            // 
            this.pnlCalContainer.Controls.Add(this.label1);
            this.pnlCalContainer.Controls.Add(this.pnlCalBase2);
            this.pnlCalContainer.Location = new System.Drawing.Point(264, 53);
            this.pnlCalContainer.Name = "pnlCalContainer";
            this.pnlCalContainer.Size = new System.Drawing.Size(487, 386);
            this.pnlCalContainer.TabIndex = 3;
            this.pnlCalContainer.Visible = false;
            // 
            // pnlCalBase2
            // 
            this.pnlCalBase2.Controls.Add(this.pnlSundays);
            this.pnlCalBase2.Controls.Add(this.pnlSaturdays);
            this.pnlCalBase2.Controls.Add(this.pnlFridays);
            this.pnlCalBase2.Controls.Add(this.pnlThursdays);
            this.pnlCalBase2.Controls.Add(this.pnlWednesdays);
            this.pnlCalBase2.Controls.Add(this.pnlTuesdays);
            this.pnlCalBase2.Controls.Add(this.pnlMondays);
            this.pnlCalBase2.Location = new System.Drawing.Point(23, 24);
            this.pnlCalBase2.Name = "pnlCalBase2";
            this.pnlCalBase2.Size = new System.Drawing.Size(416, 307);
            this.pnlCalBase2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "10";
            // 
            // pnlMondays
            // 
            this.pnlMondays.Location = new System.Drawing.Point(3, 3);
            this.pnlMondays.Name = "pnlMondays";
            this.pnlMondays.Size = new System.Drawing.Size(53, 301);
            this.pnlMondays.TabIndex = 0;
            // 
            // pnlTuesdays
            // 
            this.pnlTuesdays.Location = new System.Drawing.Point(62, 3);
            this.pnlTuesdays.Name = "pnlTuesdays";
            this.pnlTuesdays.Size = new System.Drawing.Size(53, 301);
            this.pnlTuesdays.TabIndex = 1;
            // 
            // pnlWednesdays
            // 
            this.pnlWednesdays.Location = new System.Drawing.Point(121, 3);
            this.pnlWednesdays.Name = "pnlWednesdays";
            this.pnlWednesdays.Size = new System.Drawing.Size(53, 301);
            this.pnlWednesdays.TabIndex = 2;
            // 
            // pnlThursdays
            // 
            this.pnlThursdays.Location = new System.Drawing.Point(180, 3);
            this.pnlThursdays.Name = "pnlThursdays";
            this.pnlThursdays.Size = new System.Drawing.Size(53, 301);
            this.pnlThursdays.TabIndex = 3;
            // 
            // pnlFridays
            // 
            this.pnlFridays.Location = new System.Drawing.Point(239, 3);
            this.pnlFridays.Name = "pnlFridays";
            this.pnlFridays.Size = new System.Drawing.Size(53, 301);
            this.pnlFridays.TabIndex = 4;
            // 
            // pnlSaturdays
            // 
            this.pnlSaturdays.Location = new System.Drawing.Point(298, 3);
            this.pnlSaturdays.Name = "pnlSaturdays";
            this.pnlSaturdays.Size = new System.Drawing.Size(53, 301);
            this.pnlSaturdays.TabIndex = 5;
            // 
            // pnlSundays
            // 
            this.pnlSundays.Location = new System.Drawing.Point(357, 3);
            this.pnlSundays.Name = "pnlSundays";
            this.pnlSundays.Size = new System.Drawing.Size(53, 301);
            this.pnlSundays.TabIndex = 6;
            // 
            // frmPodBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 475);
            this.Controls.Add(this.pnlCalContainer);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmPodBooking";
            this.Text = "Lakeside Escapes: Pod Booking";
            this.pnlCalContainer.ResumeLayout(false);
            this.pnlCalContainer.PerformLayout();
            this.pnlCalBase2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnlCalContainer;
        private System.Windows.Forms.Panel pnlCalBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSundays;
        private System.Windows.Forms.Panel pnlSaturdays;
        private System.Windows.Forms.Panel pnlFridays;
        private System.Windows.Forms.Panel pnlThursdays;
        private System.Windows.Forms.Panel pnlWednesdays;
        private System.Windows.Forms.Panel pnlTuesdays;
        private System.Windows.Forms.Panel pnlMondays;
    }
}