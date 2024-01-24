
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDatePickerStayLength = new System.Windows.Forms.ComboBox();
            this.lbNights = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.pnlStayLength = new System.Windows.Forms.Panel();
            this.lbDateRange = new System.Windows.Forms.Label();
            this.pnlPodChooser = new System.Windows.Forms.Panel();
            this.lbInstructionsForThePodPickerOrPodChooserOrPodSelector = new System.Windows.Forms.Label();
            this.dgPods = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlStayLength.SuspendLayout();
            this.pnlPodChooser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPods)).BeginInit();
            this.SuspendLayout();
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
            this.btnContinue.Location = new System.Drawing.Point(1, 138);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(244, 40);
            this.btnContinue.TabIndex = 15;
            this.btnContinue.Text = "Continue -->";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // pnlStayLength
            // 
            this.pnlStayLength.Controls.Add(this.btnContinue);
            this.pnlStayLength.Controls.Add(this.lbDateRange);
            this.pnlStayLength.Controls.Add(this.label1);
            this.pnlStayLength.Controls.Add(this.cmbDatePickerStayLength);
            this.pnlStayLength.Controls.Add(this.lbNights);
            this.pnlStayLength.Location = new System.Drawing.Point(222, 128);
            this.pnlStayLength.Name = "pnlStayLength";
            this.pnlStayLength.Size = new System.Drawing.Size(246, 181);
            this.pnlStayLength.TabIndex = 16;
            // 
            // lbDateRange
            // 
            this.lbDateRange.AutoSize = true;
            this.lbDateRange.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateRange.Location = new System.Drawing.Point(28, 91);
            this.lbDateRange.Name = "lbDateRange";
            this.lbDateRange.Size = new System.Drawing.Size(184, 21);
            this.lbDateRange.TabIndex = 17;
            this.lbDateRange.Text = "01/01/0000 - 01/01/0000";
            this.lbDateRange.Visible = false;
            // 
            // pnlPodChooser
            // 
            this.pnlPodChooser.Controls.Add(this.dgPods);
            this.pnlPodChooser.Controls.Add(this.lbInstructionsForThePodPickerOrPodChooserOrPodSelector);
            this.pnlPodChooser.Location = new System.Drawing.Point(121, 115);
            this.pnlPodChooser.Name = "pnlPodChooser";
            this.pnlPodChooser.Size = new System.Drawing.Size(568, 230);
            this.pnlPodChooser.TabIndex = 17;
            this.pnlPodChooser.Visible = false;
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
            // dgPods
            // 
            this.dgPods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPods.Location = new System.Drawing.Point(8, 36);
            this.dgPods.Name = "dgPods";
            this.dgPods.Size = new System.Drawing.Size(557, 187);
            this.dgPods.TabIndex = 1;
            // 
            // frmCheckOutExperience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 350);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlPodChooser);
            this.Controls.Add(this.pnlStayLength);
            this.Name = "frmCheckOutExperience";
            this.Text = "Lakeside Escapes: Check Out Experience";
            this.Load += new System.EventHandler(this.frmCheckOutExperience_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlStayLength.ResumeLayout(false);
            this.pnlStayLength.PerformLayout();
            this.pnlPodChooser.ResumeLayout(false);
            this.pnlPodChooser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPods)).EndInit();
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
    }
}