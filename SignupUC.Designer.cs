namespace personal_project_app.UserControls
{
    partial class SignupUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSignUp = new System.Windows.Forms.Label();
            this.lbSignUpInfo = new System.Windows.Forms.Label();
            this.btSignUp = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbSignUp
            // 
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSignUp.Location = new System.Drawing.Point(41, 51);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(199, 62);
            this.lbSignUp.TabIndex = 0;
            this.lbSignUp.Text = "Sign Up";
            // 
            // lbSignUpInfo
            // 
            this.lbSignUpInfo.AutoSize = true;
            this.lbSignUpInfo.Location = new System.Drawing.Point(53, 126);
            this.lbSignUpInfo.Name = "lbSignUpInfo";
            this.lbSignUpInfo.Size = new System.Drawing.Size(232, 20);
            this.lbSignUpInfo.TabIndex = 1;
            this.lbSignUpInfo.Text = "input the username and password";
            // 
            // btSignUp
            // 
            this.btSignUp.Location = new System.Drawing.Point(68, 378);
            this.btSignUp.Name = "btSignUp";
            this.btSignUp.Size = new System.Drawing.Size(94, 29);
            this.btSignUp.TabIndex = 2;
            this.btSignUp.Text = "Sign Up";
            this.btSignUp.UseVisualStyleBackColor = true;
            this.btSignUp.Click += new System.EventHandler(this.btSignUp_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(191, 193);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(125, 27);
            this.tbUserName.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(191, 263);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(134, 27);
            this.tbPassword.TabIndex = 4;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(53, 270);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 13;
            this.lbPassword.Text = "Password";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(53, 200);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(82, 20);
            this.lbUserName.TabIndex = 12;
            this.lbUserName.Text = "User Name";
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(66, 326);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(178, 24);
            this.cbAdmin.TabIndex = 14;
            this.cbAdmin.Text = "I want to be an Admin";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // SignupUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.btSignUp);
            this.Controls.Add(this.lbSignUpInfo);
            this.Controls.Add(this.lbSignUp);
            this.Name = "SignupUC";
            this.Size = new System.Drawing.Size(460, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbSignUp;
        private Label lbSignUpInfo;
        private Button btSignUp;
        private TextBox tbUserName;
        private TextBox tbPassword;
        private Label lbPassword;
        private Label lbUserName;
        private CheckBox cbAdmin;
    }
}
