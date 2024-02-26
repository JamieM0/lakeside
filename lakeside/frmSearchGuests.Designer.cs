namespace lakeside
{
    partial class frmSearchGuests
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlGuestContainer = new System.Windows.Forms.Panel();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.btnEditElement = new System.Windows.Forms.Button();
            this.btnRemoveElement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(647, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(395, 37);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Lakeside Escapes: Search Guests";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(199, 92);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(677, 43);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // pnlGuestContainer
            // 
            this.pnlGuestContainer.Location = new System.Drawing.Point(108, 146);
            this.pnlGuestContainer.Name = "pnlGuestContainer";
            this.pnlGuestContainer.Size = new System.Drawing.Size(768, 321);
            this.pnlGuestContainer.TabIndex = 3;
            // 
            // pbSearch
            // 
            this.pbSearch.Image = global::lakeside.Properties.Resources.searchIcon;
            this.pbSearch.Location = new System.Drawing.Point(127, 85);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(66, 55);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 1;
            this.pbSearch.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Image = global::lakeside.Properties.Resources.returnIcon;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(12, 9);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(256, 65);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Return to Home";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgResults
            // 
            this.dgResults.AllowUserToAddRows = false;
            this.dgResults.AllowUserToDeleteRows = false;
            this.dgResults.AllowUserToResizeRows = false;
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Location = new System.Drawing.Point(127, 146);
            this.dgResults.MultiSelect = false;
            this.dgResults.Name = "dgResults";
            this.dgResults.ReadOnly = true;
            this.dgResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResults.Size = new System.Drawing.Size(749, 308);
            this.dgResults.TabIndex = 14;
            // 
            // btnEditElement
            // 
            this.btnEditElement.Location = new System.Drawing.Point(654, 489);
            this.btnEditElement.Name = "btnEditElement";
            this.btnEditElement.Size = new System.Drawing.Size(222, 60);
            this.btnEditElement.TabIndex = 15;
            this.btnEditElement.Text = "EDIT BUTTON";
            this.btnEditElement.UseVisualStyleBackColor = true;
            this.btnEditElement.Click += new System.EventHandler(this.btnEditElement_Click);
            // 
            // btnRemoveElement
            // 
            this.btnRemoveElement.Location = new System.Drawing.Point(127, 489);
            this.btnRemoveElement.Name = "btnRemoveElement";
            this.btnRemoveElement.Size = new System.Drawing.Size(222, 60);
            this.btnRemoveElement.TabIndex = 16;
            this.btnRemoveElement.Text = "DELETE BUTTON";
            this.btnRemoveElement.UseVisualStyleBackColor = true;
            // 
            // frmSearchGuests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 573);
            this.Controls.Add(this.btnRemoveElement);
            this.Controls.Add(this.btnEditElement);
            this.Controls.Add(this.dgResults);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pnlGuestContainer);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmSearchGuests";
            this.Text = "Lakeside Escapes: Search for a Guest";
            this.Load += new System.EventHandler(this.frmSearchGuests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlGuestContainer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.Button btnEditElement;
        private System.Windows.Forms.Button btnRemoveElement;
    }
}