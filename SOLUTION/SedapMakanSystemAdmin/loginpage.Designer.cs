namespace SedapMakanSystemAdmin
{
    partial class loginpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginpage));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblHello = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblVersionControl = new System.Windows.Forms.Label();
            this.lblRequiredUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblRequiredPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPassword.Location = new System.Drawing.Point(58, 259);
            this.txtPassword.MaximumSize = new System.Drawing.Size(231, 20);
            this.txtPassword.MinimumSize = new System.Drawing.Size(231, 20);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(231, 20);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.LostFocus += new System.EventHandler(this.txtPassword_LostFocus);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(58, 211);
            this.txtUsername.MaximumSize = new System.Drawing.Size(231, 20);
            this.txtUsername.MinimumSize = new System.Drawing.Size(231, 20);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(231, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.LostFocus += new System.EventHandler(this.txtUsername_LostFocus);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.BackColor = System.Drawing.Color.Transparent;
            this.lblHello.Font = new System.Drawing.Font("Gontserrat", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHello.Location = new System.Drawing.Point(40, 48);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(234, 107);
            this.lblHello.TabIndex = 1;
            this.lblHello.Text = "Hello!";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblInformation.Font = new System.Drawing.Font("Gontserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInformation.Location = new System.Drawing.Point(51, 136);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(442, 40);
            this.lblInformation.TabIndex = 1;
            this.lblInformation.Text = "Please login using your credentials.";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Gontserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsername.Location = new System.Drawing.Point(54, 187);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 21);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Gontserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassword.Location = new System.Drawing.Point(54, 235);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 21);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblVersionControl
            // 
            this.lblVersionControl.AutoSize = true;
            this.lblVersionControl.BackColor = System.Drawing.Color.Transparent;
            this.lblVersionControl.Font = new System.Drawing.Font("Gontserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersionControl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVersionControl.Location = new System.Drawing.Point(709, 423);
            this.lblVersionControl.Name = "lblVersionControl";
            this.lblVersionControl.Size = new System.Drawing.Size(79, 18);
            this.lblVersionControl.TabIndex = 1;
            this.lblVersionControl.Text = "V0.0.1 (Alpha)";
            // 
            // lblRequiredUsername
            // 
            this.lblRequiredUsername.AutoSize = true;
            this.lblRequiredUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblRequiredUsername.Font = new System.Drawing.Font("Gontserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredUsername.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredUsername.Location = new System.Drawing.Point(295, 211);
            this.lblRequiredUsername.Name = "lblRequiredUsername";
            this.lblRequiredUsername.Size = new System.Drawing.Size(133, 18);
            this.lblRequiredUsername.TabIndex = 1;
            this.lblRequiredUsername.Text = "⚠︎ Username Required!";
            this.lblRequiredUsername.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(214, 303);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblRequiredPassword
            // 
            this.lblRequiredPassword.AutoSize = true;
            this.lblRequiredPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblRequiredPassword.Font = new System.Drawing.Font("Gontserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredPassword.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredPassword.Location = new System.Drawing.Point(295, 259);
            this.lblRequiredPassword.Name = "lblRequiredPassword";
            this.lblRequiredPassword.Size = new System.Drawing.Size(131, 18);
            this.lblRequiredPassword.TabIndex = 1;
            this.lblRequiredPassword.Text = "⚠︎ Password Required!";
            this.lblRequiredPassword.Visible = false;
            // 
            // loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SedapMakanSystemAdmin.Properties.Resources.loginpage1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblRequiredPassword);
            this.Controls.Add(this.lblRequiredUsername);
            this.Controls.Add(this.lblVersionControl);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "loginpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sedap Makan";
            this.Load += new System.EventHandler(this.loginpage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblVersionControl;
        private System.Windows.Forms.Label lblRequiredUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblRequiredPassword;
    }
}