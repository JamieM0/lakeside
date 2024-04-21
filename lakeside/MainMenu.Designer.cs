
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
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
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExtraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editExtraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStaffMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStaffMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPodBooking = new System.Windows.Forms.Button();
            this.cbDebug = new System.Windows.Forms.CheckBox();
            this.pnlBlackBackground = new System.Windows.Forms.Panel();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.lbExit = new System.Windows.Forms.Label();
            this.btnEditPod = new System.Windows.Forms.Button();
            this.btnEditGuest = new System.Windows.Forms.Button();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lakesideDBDataSet = new lakeside.LakesideDBDataSet();
            this.lakesideDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlExtraSelected = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlCourseSelected = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlBlackBackground.SuspendLayout();
            this.pnlExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakesideDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakesideDBDataSetBindingSource)).BeginInit();
            this.pnlExtraSelected.SuspendLayout();
            this.pnlCourseSelected.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ythToolStripMenuItem,
            this.managePodsToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.extraToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.createBookingToolStripMenuItem,
            this.checkOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(152, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(386, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ythToolStripMenuItem
            // 
            this.ythToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGuestToolStripMenuItem,
            this.editGuestToolStripMenuItem});
            this.ythToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ythToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ythToolStripMenuItem.Image = global::lakeside.Properties.Resources.UserIconWhite;
            this.ythToolStripMenuItem.Name = "ythToolStripMenuItem";
            this.ythToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.ythToolStripMenuItem.Text = "Guests";
            this.ythToolStripMenuItem.Click += new System.EventHandler(this.ythToolStripMenuItem_Click);
            // 
            // addGuestToolStripMenuItem
            // 
            this.addGuestToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.addGuestToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addGuestToolStripMenuItem.Name = "addGuestToolStripMenuItem";
            this.addGuestToolStripMenuItem.Size = new System.Drawing.Size(177, 30);
            this.addGuestToolStripMenuItem.Text = "Add Guest";
            this.addGuestToolStripMenuItem.Click += new System.EventHandler(this.addGuestToolStripMenuItem_Click);
            // 
            // editGuestToolStripMenuItem
            // 
            this.editGuestToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.editGuestToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editGuestToolStripMenuItem.Name = "editGuestToolStripMenuItem";
            this.editGuestToolStripMenuItem.Size = new System.Drawing.Size(177, 30);
            this.editGuestToolStripMenuItem.Text = "Edit Guest";
            this.editGuestToolStripMenuItem.Click += new System.EventHandler(this.editGuestToolStripMenuItem_Click);
            // 
            // managePodsToolStripMenuItem
            // 
            this.managePodsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPodToolStripMenuItem,
            this.editPosdToolStripMenuItem});
            this.managePodsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managePodsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.managePodsToolStripMenuItem.Image = global::lakeside.Properties.Resources.PodIconWhite;
            this.managePodsToolStripMenuItem.Name = "managePodsToolStripMenuItem";
            this.managePodsToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.managePodsToolStripMenuItem.Text = "Pods";
            // 
            // addPodToolStripMenuItem
            // 
            this.addPodToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.addPodToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addPodToolStripMenuItem.Name = "addPodToolStripMenuItem";
            this.addPodToolStripMenuItem.Size = new System.Drawing.Size(161, 30);
            this.addPodToolStripMenuItem.Text = "Add Pod";
            this.addPodToolStripMenuItem.Click += new System.EventHandler(this.addPodToolStripMenuItem_Click);
            // 
            // editPosdToolStripMenuItem
            // 
            this.editPosdToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.editPosdToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editPosdToolStripMenuItem.Name = "editPosdToolStripMenuItem";
            this.editPosdToolStripMenuItem.Size = new System.Drawing.Size(161, 30);
            this.editPosdToolStripMenuItem.Text = "Edit Pod";
            this.editPosdToolStripMenuItem.Click += new System.EventHandler(this.editPosdToolStripMenuItem_Click);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.editCourseToolStripMenuItem});
            this.coursesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.coursesToolStripMenuItem.Image = global::lakeside.Properties.Resources.CourseIconSingle_White;
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.coursesToolStripMenuItem.Text = "Courses";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.addCourseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // editCourseToolStripMenuItem
            // 
            this.editCourseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.editCourseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editCourseToolStripMenuItem.Name = "editCourseToolStripMenuItem";
            this.editCourseToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.editCourseToolStripMenuItem.Text = "Edit Course";
            this.editCourseToolStripMenuItem.Click += new System.EventHandler(this.editCourseToolStripMenuItem_Click);
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addExtraToolStripMenuItem,
            this.editExtraToolStripMenuItem});
            this.extraToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.extraToolStripMenuItem.Image = global::lakeside.Properties.Resources.ExtraIcon_White;
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            this.extraToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.extraToolStripMenuItem.Text = "Extra";
            this.extraToolStripMenuItem.MouseEnter += new System.EventHandler(this.extraToolStripMenuItem_MouseEnter);
            // 
            // addExtraToolStripMenuItem
            // 
            this.addExtraToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.addExtraToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addExtraToolStripMenuItem.Name = "addExtraToolStripMenuItem";
            this.addExtraToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
            this.addExtraToolStripMenuItem.Text = "Add Extra";
            this.addExtraToolStripMenuItem.Click += new System.EventHandler(this.addExtraToolStripMenuItem_Click);
            // 
            // editExtraToolStripMenuItem
            // 
            this.editExtraToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.editExtraToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editExtraToolStripMenuItem.Name = "editExtraToolStripMenuItem";
            this.editExtraToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
            this.editExtraToolStripMenuItem.Text = "Edit Extra";
            this.editExtraToolStripMenuItem.Click += new System.EventHandler(this.editExtraToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStaffMemberToolStripMenuItem,
            this.editStaffMemberToolStripMenuItem});
            this.staffToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.staffToolStripMenuItem.Image = global::lakeside.Properties.Resources.UserIconWhite;
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.staffToolStripMenuItem.Text = "Staff";
            this.staffToolStripMenuItem.Visible = false;
            // 
            // addStaffMemberToolStripMenuItem
            // 
            this.addStaffMemberToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.addStaffMemberToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addStaffMemberToolStripMenuItem.Name = "addStaffMemberToolStripMenuItem";
            this.addStaffMemberToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.addStaffMemberToolStripMenuItem.Text = "Add Staff Member";
            this.addStaffMemberToolStripMenuItem.Click += new System.EventHandler(this.addStaffMemberToolStripMenuItem_Click);
            // 
            // editStaffMemberToolStripMenuItem
            // 
            this.editStaffMemberToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.editStaffMemberToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editStaffMemberToolStripMenuItem.Name = "editStaffMemberToolStripMenuItem";
            this.editStaffMemberToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.editStaffMemberToolStripMenuItem.Text = "Edit Staff Member";
            this.editStaffMemberToolStripMenuItem.Click += new System.EventHandler(this.editStaffMemberToolStripMenuItem_Click);
            // 
            // createBookingToolStripMenuItem
            // 
            this.createBookingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.createBookingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.createBookingToolStripMenuItem.Name = "createBookingToolStripMenuItem";
            this.createBookingToolStripMenuItem.Size = new System.Drawing.Size(162, 29);
            this.createBookingToolStripMenuItem.Text = "Create Booking";
            this.createBookingToolStripMenuItem.Visible = false;
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkOutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.checkOutToolStripMenuItem.Text = "Check Out";
            this.checkOutToolStripMenuItem.Visible = false;
            // 
            // btnPodBooking
            // 
            this.btnPodBooking.BackgroundImage = global::lakeside.Properties.Resources.CreateBookingButton;
            this.btnPodBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPodBooking.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPodBooking.Location = new System.Drawing.Point(368, 276);
            this.btnPodBooking.Name = "btnPodBooking";
            this.btnPodBooking.Size = new System.Drawing.Size(308, 112);
            this.btnPodBooking.TabIndex = 4;
            this.btnPodBooking.UseVisualStyleBackColor = true;
            this.btnPodBooking.Click += new System.EventHandler(this.btnPodBooking_Click);
            // 
            // cbDebug
            // 
            this.cbDebug.AutoSize = true;
            this.cbDebug.ForeColor = System.Drawing.Color.White;
            this.cbDebug.Location = new System.Drawing.Point(823, 12);
            this.cbDebug.Name = "cbDebug";
            this.cbDebug.Size = new System.Drawing.Size(151, 25);
            this.cbDebug.TabIndex = 12;
            this.cbDebug.Text = "Use Debug Tools?";
            this.cbDebug.UseVisualStyleBackColor = true;
            this.cbDebug.Visible = false;
            this.cbDebug.CheckedChanged += new System.EventHandler(this.cbDebug_CheckedChanged);
            // 
            // pnlBlackBackground
            // 
            this.pnlBlackBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.pnlBlackBackground.Controls.Add(this.pnlExit);
            this.pnlBlackBackground.Controls.Add(this.cbDebug);
            this.pnlBlackBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBlackBackground.Name = "pnlBlackBackground";
            this.pnlBlackBackground.Size = new System.Drawing.Size(1054, 50);
            this.pnlBlackBackground.TabIndex = 13;
            // 
            // pnlExit
            // 
            this.pnlExit.Controls.Add(this.lbExit);
            this.pnlExit.Location = new System.Drawing.Point(1005, 5);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(40, 40);
            this.pnlExit.TabIndex = 14;
            this.pnlExit.Click += new System.EventHandler(this.pnlExit_Click);
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.ForeColor = System.Drawing.Color.White;
            this.lbExit.Location = new System.Drawing.Point(-7, -5);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(56, 50);
            this.lbExit.TabIndex = 0;
            this.lbExit.Text = "🞨";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            this.lbExit.MouseEnter += new System.EventHandler(this.lbExit_MouseEnter);
            this.lbExit.MouseLeave += new System.EventHandler(this.lbExit_MouseLeave);
            // 
            // btnEditPod
            // 
            this.btnEditPod.BackgroundImage = global::lakeside.Properties.Resources.EditPodButton;
            this.btnEditPod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditPod.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPod.Location = new System.Drawing.Point(-250, 433);
            this.btnEditPod.Name = "btnEditPod";
            this.btnEditPod.Size = new System.Drawing.Size(250, 65);
            this.btnEditPod.TabIndex = 11;
            this.btnEditPod.UseVisualStyleBackColor = true;
            this.btnEditPod.Click += new System.EventHandler(this.btnEditPod_Click);
            // 
            // btnEditGuest
            // 
            this.btnEditGuest.BackgroundImage = global::lakeside.Properties.Resources.EditGuestButton;
            this.btnEditGuest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditGuest.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGuest.Location = new System.Drawing.Point(-250, 433);
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
            this.btnAddGuest.Location = new System.Drawing.Point(-250, 315);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(250, 65);
            this.btnAddGuest.TabIndex = 5;
            this.btnAddGuest.UseVisualStyleBackColor = true;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::lakeside.Properties.Resources.Full_Main_Logo__Transparent_3;
            this.pbLogo.Location = new System.Drawing.Point(110, 63);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(835, 170);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackgroundImage = global::lakeside.Properties.Resources.CheckOutButton;
            this.btnCheckOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCheckOut.Location = new System.Drawing.Point(397, 432);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(250, 65);
            this.btnCheckOut.TabIndex = 14;
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // lakesideDBDataSet
            // 
            this.lakesideDBDataSet.DataSetName = "LakesideDBDataSet";
            this.lakesideDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lakesideDBDataSetBindingSource
            // 
            this.lakesideDBDataSetBindingSource.DataSource = this.lakesideDBDataSet;
            this.lakesideDBDataSetBindingSource.Position = 0;
            // 
            // pnlExtraSelected
            // 
            this.pnlExtraSelected.Controls.Add(this.label9);
            this.pnlExtraSelected.Controls.Add(this.label10);
            this.pnlExtraSelected.Controls.Add(this.label11);
            this.pnlExtraSelected.Controls.Add(this.label12);
            this.pnlExtraSelected.Controls.Add(this.label13);
            this.pnlExtraSelected.Controls.Add(this.label14);
            this.pnlExtraSelected.Location = new System.Drawing.Point(501, 84);
            this.pnlExtraSelected.Name = "pnlExtraSelected";
            this.pnlExtraSelected.Size = new System.Drawing.Size(425, 131);
            this.pnlExtraSelected.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 21);
            this.label11.TabIndex = 16;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 21);
            this.label12.TabIndex = 15;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 21);
            this.label13.TabIndex = 14;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 21);
            this.label14.TabIndex = 13;
            this.label14.Text = "label14";
            // 
            // pnlCourseSelected
            // 
            this.pnlCourseSelected.Controls.Add(this.label7);
            this.pnlCourseSelected.Controls.Add(this.label6);
            this.pnlCourseSelected.Controls.Add(this.label4);
            this.pnlCourseSelected.Controls.Add(this.label3);
            this.pnlCourseSelected.Controls.Add(this.label2);
            this.pnlCourseSelected.Controls.Add(this.label1);
            this.pnlCourseSelected.Location = new System.Drawing.Point(140, 87);
            this.pnlCourseSelected.Name = "pnlCourseSelected";
            this.pnlCourseSelected.Size = new System.Drawing.Size(425, 131);
            this.pnlCourseSelected.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 563);
            this.ControlBox = false;
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnEditPod);
            this.Controls.Add(this.btnEditGuest);
            this.Controls.Add(this.btnAddGuest);
            this.Controls.Add(this.btnPodBooking);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlBlackBackground);
            this.Controls.Add(this.pnlCourseSelected);
            this.Controls.Add(this.pnlExtraSelected);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHome";
            this.Text = "Lakeside Escapes: Home Screen";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlBlackBackground.ResumeLayout(false);
            this.pnlBlackBackground.PerformLayout();
            this.pnlExit.ResumeLayout(false);
            this.pnlExit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakesideDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lakesideDBDataSetBindingSource)).EndInit();
            this.pnlExtraSelected.ResumeLayout(false);
            this.pnlExtraSelected.PerformLayout();
            this.pnlCourseSelected.ResumeLayout(false);
            this.pnlCourseSelected.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnPodBooking;
        private System.Windows.Forms.Button btnEditGuest;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.ToolStripMenuItem ythToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGuestToolStripMenuItem;
        private System.Windows.Forms.Button btnEditPod;
        private System.Windows.Forms.ToolStripMenuItem managePodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPosdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExtraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editExtraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStaffMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStaffMemberToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbDebug;
        private System.Windows.Forms.Panel pnlBlackBackground;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Button btnCheckOut;
        private LakesideDBDataSet lakesideDBDataSet;
        private System.Windows.Forms.BindingSource lakesideDBDataSetBindingSource;
        private System.Windows.Forms.Panel pnlExtraSelected;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnlCourseSelected;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem createBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
    }
}

