namespace personal_project_app
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox backgroundPic;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lbLogin = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.linkSignup = new System.Windows.Forms.LinkLabel();
            this.lbMyMovieWebsite = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.signupuc1 = new personal_project_app.UserControls.SignupUC();
            backgroundPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(backgroundPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPic
            // 
            backgroundPic.Image = ((System.Drawing.Image)(resources.GetObject("backgroundPic.Image")));
            backgroundPic.Location = new System.Drawing.Point(543, 1);
            backgroundPic.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            backgroundPic.Name = "backgroundPic";
            backgroundPic.Size = new System.Drawing.Size(701, 685);
            backgroundPic.TabIndex = 1;
            backgroundPic.TabStop = false;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLogin.Location = new System.Drawing.Point(64, 131);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(150, 62);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Login";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(127, 516);
            this.btLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(106, 33);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(141, 375);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(140, 30);
            this.Password.TabIndex = 3;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(141, 246);
            this.Username.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(140, 30);
            this.Username.TabIndex = 4;
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLogin.Location = new System.Drawing.Point(344, 29);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(61, 28);
            this.linkLogin.TabIndex = 5;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Login";
            this.linkLogin.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // linkSignup
            // 
            this.linkSignup.AutoSize = true;
            this.linkSignup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkSignup.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkSignup.Location = new System.Drawing.Point(448, 29);
            this.linkSignup.Name = "linkSignup";
            this.linkSignup.Size = new System.Drawing.Size(77, 28);
            this.linkSignup.TabIndex = 6;
            this.linkSignup.TabStop = true;
            this.linkSignup.Text = "SignUp";
            this.linkSignup.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignup_LinkClicked);
            // 
            // lbMyMovieWebsite
            // 
            this.lbMyMovieWebsite.AutoSize = true;
            this.lbMyMovieWebsite.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMyMovieWebsite.Location = new System.Drawing.Point(93, 41);
            this.lbMyMovieWebsite.Name = "lbMyMovieWebsite";
            this.lbMyMovieWebsite.Size = new System.Drawing.Size(181, 28);
            this.lbMyMovieWebsite.TabIndex = 7;
            this.lbMyMovieWebsite.Text = "My Moive Website";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb.Location = new System.Drawing.Point(411, 29);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(17, 28);
            this.lb.TabIndex = 8;
            this.lb.Text = "|";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(14, 14);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(73, 75);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 9;
            this.logo.TabStop = false;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(44, 248);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(95, 23);
            this.lbUserName.TabIndex = 10;
            this.lbUserName.Text = "User Name";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(44, 373);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(80, 23);
            this.lbPassword.TabIndex = 11;
            this.lbPassword.Text = "Password";
            // 
            // signupuc1
            // 
            this.signupuc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.signupuc1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupuc1.Location = new System.Drawing.Point(-4, 115);
            this.signupuc1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.signupuc1.Name = "signupuc1";
            this.signupuc1.Size = new System.Drawing.Size(541, 492);
            this.signupuc1.TabIndex = 12;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1227, 682);
            this.Controls.Add(this.signupuc1);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lbMyMovieWebsite);
            this.Controls.Add(this.linkSignup);
            this.Controls.Add(this.linkLogin);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(backgroundPic);
            this.Controls.Add(this.lbLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "LoginForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(backgroundPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbLogin;
        private Button btLogin;
        private TextBox Password;
        private TextBox Username;
        private LinkLabel linkLogin;
        private LinkLabel linkSignup;
        private Label lbMyMovieWebsite;
        private Label lb;
        private PictureBox logo;
        private Label lbUserName;
        private Label lbPassword;
        private UserControls.SignupUC signupuc1;
    }
}