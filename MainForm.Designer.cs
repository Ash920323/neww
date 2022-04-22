namespace personal_project_app
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbUserPic = new System.Windows.Forms.PictureBox();
            this.tbSearchbar = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lbMyMovieWebsite = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.PicMovie1 = new System.Windows.Forms.PictureBox();
            this.PicMovie2 = new System.Windows.Forms.PictureBox();
            this.PicMovie3 = new System.Windows.Forms.PictureBox();
            this.lbMovie1 = new System.Windows.Forms.Label();
            this.lbMovie2 = new System.Windows.Forms.Label();
            this.lbMovie3 = new System.Windows.Forms.Label();
            this.selectedMovie1 = new personal_project_app.UserControls.SelectedMovie();
            this.gbShowMovies = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMovie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMovie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMovie3)).BeginInit();
            this.gbShowMovies.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbUserPic
            // 
            this.pbUserPic.Image = ((System.Drawing.Image)(resources.GetObject("pbUserPic.Image")));
            this.pbUserPic.Location = new System.Drawing.Point(985, 23);
            this.pbUserPic.Name = "pbUserPic";
            this.pbUserPic.Size = new System.Drawing.Size(98, 81);
            this.pbUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserPic.TabIndex = 2;
            this.pbUserPic.TabStop = false;
            // 
            // tbSearchbar
            // 
            this.tbSearchbar.Location = new System.Drawing.Point(325, 45);
            this.tbSearchbar.Name = "tbSearchbar";
            this.tbSearchbar.Size = new System.Drawing.Size(403, 27);
            this.tbSearchbar.TabIndex = 1;
            this.tbSearchbar.Text = "Search...";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(878, 68);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(38, 20);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "User";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.logo);
            this.panel2.Controls.Add(this.lbMyMovieWebsite);
            this.panel2.Controls.Add(this.btSearch);
            this.panel2.Controls.Add(this.lbUserName);
            this.panel2.Controls.Add(this.pbUserPic);
            this.panel2.Controls.Add(this.tbSearchbar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1104, 125);
            this.panel2.TabIndex = 7;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(39, 23);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(65, 65);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 13;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // lbMyMovieWebsite
            // 
            this.lbMyMovieWebsite.AutoSize = true;
            this.lbMyMovieWebsite.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMyMovieWebsite.Location = new System.Drawing.Point(110, 48);
            this.lbMyMovieWebsite.Name = "lbMyMovieWebsite";
            this.lbMyMovieWebsite.Size = new System.Drawing.Size(159, 25);
            this.lbMyMovieWebsite.TabIndex = 12;
            this.lbMyMovieWebsite.Text = "My Moive Website";
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btSearch.Location = new System.Drawing.Point(748, 43);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(94, 29);
            this.btSearch.TabIndex = 3;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // PicMovie1
            // 
            this.PicMovie1.Location = new System.Drawing.Point(172, 54);
            this.PicMovie1.Name = "PicMovie1";
            this.PicMovie1.Size = new System.Drawing.Size(220, 121);
            this.PicMovie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicMovie1.TabIndex = 6;
            this.PicMovie1.TabStop = false;
            this.PicMovie1.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // PicMovie2
            // 
            this.PicMovie2.Location = new System.Drawing.Point(419, 54);
            this.PicMovie2.Name = "PicMovie2";
            this.PicMovie2.Size = new System.Drawing.Size(220, 121);
            this.PicMovie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicMovie2.TabIndex = 8;
            this.PicMovie2.TabStop = false;
            this.PicMovie2.Click += new System.EventHandler(this.PicMovie2_Click);
            // 
            // PicMovie3
            // 
            this.PicMovie3.Location = new System.Drawing.Point(673, 54);
            this.PicMovie3.Name = "PicMovie3";
            this.PicMovie3.Size = new System.Drawing.Size(220, 121);
            this.PicMovie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicMovie3.TabIndex = 11;
            this.PicMovie3.TabStop = false;
            this.PicMovie3.Click += new System.EventHandler(this.PicMovie3_Click);
            // 
            // lbMovie1
            // 
            this.lbMovie1.AutoSize = true;
            this.lbMovie1.Location = new System.Drawing.Point(263, 197);
            this.lbMovie1.Name = "lbMovie1";
            this.lbMovie1.Size = new System.Drawing.Size(58, 20);
            this.lbMovie1.TabIndex = 12;
            this.lbMovie1.Text = "Movie1";
            // 
            // lbMovie2
            // 
            this.lbMovie2.AutoSize = true;
            this.lbMovie2.Location = new System.Drawing.Point(488, 188);
            this.lbMovie2.Name = "lbMovie2";
            this.lbMovie2.Size = new System.Drawing.Size(58, 20);
            this.lbMovie2.TabIndex = 13;
            this.lbMovie2.Text = "Movie2";
            // 
            // lbMovie3
            // 
            this.lbMovie3.AutoSize = true;
            this.lbMovie3.Location = new System.Drawing.Point(774, 197);
            this.lbMovie3.Name = "lbMovie3";
            this.lbMovie3.Size = new System.Drawing.Size(58, 20);
            this.lbMovie3.TabIndex = 14;
            this.lbMovie3.Text = "Movie3";
            // 
            // selectedMovie1
            // 
            this.selectedMovie1.CurrentFilm = null;
            this.selectedMovie1.CurrentUser = null;
            this.selectedMovie1.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectedMovie1.Location = new System.Drawing.Point(0, 1);
            this.selectedMovie1.Margin = new System.Windows.Forms.Padding(4);
            this.selectedMovie1.Name = "selectedMovie1";
            this.selectedMovie1.Size = new System.Drawing.Size(1046, 436);
            this.selectedMovie1.TabIndex = 16;
            // 
            // gbShowMovies
            // 
            this.gbShowMovies.Controls.Add(this.selectedMovie1);
            this.gbShowMovies.Controls.Add(this.lbMovie3);
            this.gbShowMovies.Controls.Add(this.lbMovie2);
            this.gbShowMovies.Controls.Add(this.lbMovie1);
            this.gbShowMovies.Controls.Add(this.PicMovie3);
            this.gbShowMovies.Controls.Add(this.PicMovie2);
            this.gbShowMovies.Controls.Add(this.PicMovie1);
            this.gbShowMovies.Location = new System.Drawing.Point(12, 131);
            this.gbShowMovies.Name = "gbShowMovies";
            this.gbShowMovies.Size = new System.Drawing.Size(1016, 416);
            this.gbShowMovies.TabIndex = 2;
            this.gbShowMovies.TabStop = false;
            this.gbShowMovies.Text = "ShowMovies";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1104, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbShowMovies);
            this.Name = "MainForm";
            this.Text = "S";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMovie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMovie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMovie3)).EndInit();
            this.gbShowMovies.ResumeLayout(false);
            this.gbShowMovies.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pbUserPic;
        private TextBox tbSearchbar;
        private Label lbUserName;
        private Panel panel2;
        private Button btSearch;
        private PictureBox logo;
        private Label lbMyMovieWebsite;
        private PictureBox PicMovie1;
        private PictureBox PicMovie2;
        private PictureBox PicMovie3;
        private Label lbMovie1;
        private Label lbMovie2;
        private Label lbMovie3;
        private UserControls.SelectedMovie selectedMovie1;
        private GroupBox gbShowMovies;
    }
}