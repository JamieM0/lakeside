﻿
namespace lakeside
{
    partial class frmHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ythToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPosdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPodBooking = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEditPod = new System.Windows.Forms.Button();
            this.btnAddPod = new System.Windows.Forms.Button();
            this.btnEditGuest = new System.Windows.Forms.Button();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExtraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editExtraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ythToolStripMenuItem,
            this.managePodsToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.extraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ythToolStripMenuItem
            // 
            this.ythToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGuestToolStripMenuItem,
            this.editGuestToolStripMenuItem});
            this.ythToolStripMenuItem.Name = "ythToolStripMenuItem";
            this.ythToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.ythToolStripMenuItem.Text = "Guests";
            this.ythToolStripMenuItem.Click += new System.EventHandler(this.ythToolStripMenuItem_Click);
            // 
            // addGuestToolStripMenuItem
            // 
            this.addGuestToolStripMenuItem.Name = "addGuestToolStripMenuItem";
            this.addGuestToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.addGuestToolStripMenuItem.Text = "Add Guest";
            this.addGuestToolStripMenuItem.Click += new System.EventHandler(this.addGuestToolStripMenuItem_Click);
            // 
            // editGuestToolStripMenuItem
            // 
            this.editGuestToolStripMenuItem.Name = "editGuestToolStripMenuItem";
            this.editGuestToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.editGuestToolStripMenuItem.Text = "Edit Guest";
            this.editGuestToolStripMenuItem.Click += new System.EventHandler(this.editGuestToolStripMenuItem_Click);
            // 
            // managePodsToolStripMenuItem
            // 
            this.managePodsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPodToolStripMenuItem,
            this.editPosdToolStripMenuItem});
            this.managePodsToolStripMenuItem.Name = "managePodsToolStripMenuItem";
            this.managePodsToolStripMenuItem.Size = new System.Drawing.Size(55, 25);
            this.managePodsToolStripMenuItem.Text = "Pods";
            // 
            // addPodToolStripMenuItem
            // 
            this.addPodToolStripMenuItem.Name = "addPodToolStripMenuItem";
            this.addPodToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.addPodToolStripMenuItem.Text = "Add Pod";
            // 
            // editPosdToolStripMenuItem
            // 
            this.editPosdToolStripMenuItem.Name = "editPosdToolStripMenuItem";
            this.editPosdToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.editPosdToolStripMenuItem.Text = "Edit Pod";
            this.editPosdToolStripMenuItem.Click += new System.EventHandler(this.editPosdToolStripMenuItem_Click);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.editCourseToolStripMenuItem});
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.coursesToolStripMenuItem.Text = "Courses";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // editCourseToolStripMenuItem
            // 
            this.editCourseToolStripMenuItem.Name = "editCourseToolStripMenuItem";
            this.editCourseToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.editCourseToolStripMenuItem.Text = "Edit Course";
            // 
            // btnPodBooking
            // 
            this.btnPodBooking.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPodBooking.Location = new System.Drawing.Point(406, 315);
            this.btnPodBooking.Name = "btnPodBooking";
            this.btnPodBooking.Size = new System.Drawing.Size(250, 183);
            this.btnPodBooking.TabIndex = 4;
            this.btnPodBooking.Text = "button3";
            this.btnPodBooking.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1019, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 31);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseMove);
            // 
            // btnEditPod
            // 
            this.btnEditPod.BackgroundImage = global::lakeside.Properties.Resources.EditPodButton;
            this.btnEditPod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditPod.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPod.Location = new System.Drawing.Point(695, 433);
            this.btnEditPod.Name = "btnEditPod";
            this.btnEditPod.Size = new System.Drawing.Size(250, 65);
            this.btnEditPod.TabIndex = 11;
            this.btnEditPod.UseVisualStyleBackColor = true;
            this.btnEditPod.Click += new System.EventHandler(this.btnEditPod_Click);
            // 
            // btnAddPod
            // 
            this.btnAddPod.BackgroundImage = global::lakeside.Properties.Resources.AddPodButton;
            this.btnAddPod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPod.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPod.Location = new System.Drawing.Point(695, 315);
            this.btnAddPod.Name = "btnAddPod";
            this.btnAddPod.Size = new System.Drawing.Size(250, 65);
            this.btnAddPod.TabIndex = 10;
            this.btnAddPod.UseVisualStyleBackColor = true;
            this.btnAddPod.Click += new System.EventHandler(this.btnAddPod_Click);
            // 
            // btnEditGuest
            // 
            this.btnEditGuest.BackgroundImage = global::lakeside.Properties.Resources.EditGuestButton;
            this.btnEditGuest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditGuest.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGuest.Location = new System.Drawing.Point(110, 433);
            this.btnEditGuest.Name = "btnEditGuest";
            this.btnEditGuest.Size = new System.Drawing.Size(250, 65);
            this.btnEditGuest.TabIndex = 6;
            this.btnEditGuest.UseVisualStyleBackColor = true;
            this.btnEditGuest.Click += new System.EventHandler(this.btnEditGuest_Click);
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.BackgroundImage = global::lakeside.Properties.Resources.AddGuestButton;
            this.btnAddGuest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddGuest.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGuest.Location = new System.Drawing.Point(110, 315);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(250, 65);
            this.btnAddGuest.TabIndex = 5;
            this.btnAddGuest.UseVisualStyleBackColor = true;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::lakeside.Properties.Resources.Full_Main_Logo__White_;
            this.pictureBox1.Location = new System.Drawing.Point(110, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(835, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addExtraToolStripMenuItem,
            this.editExtraToolStripMenuItem});
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            this.extraToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.extraToolStripMenuItem.Text = "Extra";
            // 
            // addExtraToolStripMenuItem
            // 
            this.addExtraToolStripMenuItem.Name = "addExtraToolStripMenuItem";
            this.addExtraToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.addExtraToolStripMenuItem.Text = "Add Extra";
            this.addExtraToolStripMenuItem.Click += new System.EventHandler(this.addExtraToolStripMenuItem_Click);
            // 
            // editExtraToolStripMenuItem
            // 
            this.editExtraToolStripMenuItem.Name = "editExtraToolStripMenuItem";
            this.editExtraToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.editExtraToolStripMenuItem.Text = "Edit Extra";
            this.editExtraToolStripMenuItem.Click += new System.EventHandler(this.editExtraToolStripMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1054, 563);
            this.ControlBox = false;
            this.Controls.Add(this.btnEditPod);
            this.Controls.Add(this.btnAddPod);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEditGuest);
            this.Controls.Add(this.btnAddGuest);
            this.Controls.Add(this.btnPodBooking);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnPodBooking;
        private System.Windows.Forms.Button btnEditGuest;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripMenuItem ythToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGuestToolStripMenuItem;
        private System.Windows.Forms.Button btnEditPod;
        private System.Windows.Forms.Button btnAddPod;
        private System.Windows.Forms.ToolStripMenuItem managePodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPosdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExtraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editExtraToolStripMenuItem;
    }
}

