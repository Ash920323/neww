namespace personal_project_app.Forms
{
    partial class AdminForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFilmMangement = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.lbWelcomeAdmin = new System.Windows.Forms.Label();
            this.adminFilmuc1 = new personal_project_app.UserControls.AdminFilmUC();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFilmMangement);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.lbWelcomeAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 448);
            this.panel1.TabIndex = 0;
            // 
            // btnFilmMangement
            // 
            this.btnFilmMangement.Location = new System.Drawing.Point(0, 254);
            this.btnFilmMangement.Name = "btnFilmMangement";
            this.btnFilmMangement.Size = new System.Drawing.Size(204, 88);
            this.btnFilmMangement.TabIndex = 2;
            this.btnFilmMangement.Text = "Film Management";
            this.btnFilmMangement.UseVisualStyleBackColor = true;
            this.btnFilmMangement.Click += new System.EventHandler(this.btnFilmMangement_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(0, 133);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(207, 84);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "User Management";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // lbWelcomeAdmin
            // 
            this.lbWelcomeAdmin.AutoSize = true;
            this.lbWelcomeAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbWelcomeAdmin.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWelcomeAdmin.Location = new System.Drawing.Point(3, 9);
            this.lbWelcomeAdmin.Name = "lbWelcomeAdmin";
            this.lbWelcomeAdmin.Size = new System.Drawing.Size(188, 46);
            this.lbWelcomeAdmin.TabIndex = 0;
            this.lbWelcomeAdmin.Text = "Welcome,\r\nto the Admin Form";
            this.lbWelcomeAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminFilmuc1
            // 
            this.adminFilmuc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminFilmuc1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminFilmuc1.Location = new System.Drawing.Point(210, 0);
            this.adminFilmuc1.Name = "adminFilmuc1";
            this.adminFilmuc1.Size = new System.Drawing.Size(940, 442);
            this.adminFilmuc1.TabIndex = 1;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1149, 448);
            this.Controls.Add(this.adminFilmuc1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnFilmMangement;
        private Button btnUser;
        private Label lbWelcomeAdmin;
        private UserControls.AdminFilmUC adminFilmuc1;
        private UserControls.AdminUserUC adminUseruc1;
    }
}