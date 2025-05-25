namespace SedapMakanSystemAdmin
{
    partial class adminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminHome));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnViewSales = new System.Windows.Forms.Button();
            this.btnEwalletMgmt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(302, 849);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(9, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnManageUsers);
            this.panel2.Controls.Add(this.btnViewSales);
            this.panel2.Controls.Add(this.btnEwalletMgmt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 500);
            this.panel2.TabIndex = 1;
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageUsers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnManageUsers.Location = new System.Drawing.Point(0, 92);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(296, 46);
            this.btnManageUsers.TabIndex = 0;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnViewSales
            // 
            this.btnViewSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewSales.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnViewSales.Location = new System.Drawing.Point(0, 46);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(296, 46);
            this.btnViewSales.TabIndex = 0;
            this.btnViewSales.Text = "View Sales";
            this.btnViewSales.UseVisualStyleBackColor = true;
            this.btnViewSales.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEwalletMgmt
            // 
            this.btnEwalletMgmt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEwalletMgmt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEwalletMgmt.Location = new System.Drawing.Point(0, 0);
            this.btnEwalletMgmt.Name = "btnEwalletMgmt";
            this.btnEwalletMgmt.Size = new System.Drawing.Size(296, 46);
            this.btnEwalletMgmt.TabIndex = 0;
            this.btnEwalletMgmt.Text = "E-Wallet Management";
            this.btnEwalletMgmt.UseVisualStyleBackColor = true;
            this.btnEwalletMgmt.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Location = new System.Drawing.Point(3, 615);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 77);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(9, 26);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(145, 77);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // adminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 849);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Menu";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.adminHome_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEwalletMgmt;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnViewSales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLogout;
    }
}

