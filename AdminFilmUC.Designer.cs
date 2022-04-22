namespace personal_project_app.UserControls
{
    partial class AdminFilmUC
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.tbxInfo = new System.Windows.Forms.TextBox();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.rbnMovie = new System.Windows.Forms.RadioButton();
            this.rbnAnime = new System.Windows.Forms.RadioButton();
            this.rbnTV_Show = new System.Windows.Forms.RadioButton();
            this.lbLanguages = new System.Windows.Forms.Label();
            this.cbxEnglish = new System.Windows.Forms.CheckBox();
            this.cbxGerman = new System.Windows.Forms.CheckBox();
            this.cbxDutch = new System.Windows.Forms.CheckBox();
            this.cbxJapanese = new System.Windows.Forms.CheckBox();
            this.cbxMandrin = new System.Windows.Forms.CheckBox();
            this.listBoxFilms = new System.Windows.Forms.ListBox();
            this.lb = new System.Windows.Forms.Label();
            this.tbxLenghtOrEdp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(446, 376);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(596, 376);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(741, 376);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbxID
            // 
            this.tbxID.Enabled = false;
            this.tbxID.Location = new System.Drawing.Point(596, 12);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(125, 27);
            this.tbxID.TabIndex = 4;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(446, 15);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(25, 20);
            this.lbID.TabIndex = 5;
            this.lbID.Text = "Id:\r\n";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(446, 61);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(41, 20);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 7;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(447, 98);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(38, 20);
            this.lbInfo.TabIndex = 8;
            this.lbInfo.Text = "Info:";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(447, 177);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(40, 20);
            this.lbYear.TabIndex = 9;
            this.lbYear.Text = "Year:";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(596, 54);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(125, 27);
            this.tbxTitle.TabIndex = 11;
            // 
            // tbxInfo
            // 
            this.tbxInfo.Location = new System.Drawing.Point(596, 98);
            this.tbxInfo.Multiline = true;
            this.tbxInfo.Name = "tbxInfo";
            this.tbxInfo.Size = new System.Drawing.Size(459, 70);
            this.tbxInfo.TabIndex = 12;
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(596, 174);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(125, 27);
            this.tbxYear.TabIndex = 13;
            // 
            // rbnMovie
            // 
            this.rbnMovie.AutoSize = true;
            this.rbnMovie.Location = new System.Drawing.Point(460, 323);
            this.rbnMovie.Name = "rbnMovie";
            this.rbnMovie.Size = new System.Drawing.Size(71, 24);
            this.rbnMovie.TabIndex = 14;
            this.rbnMovie.TabStop = true;
            this.rbnMovie.Text = "Movie";
            this.rbnMovie.UseVisualStyleBackColor = true;
            // 
            // rbnAnime
            // 
            this.rbnAnime.AutoSize = true;
            this.rbnAnime.Location = new System.Drawing.Point(613, 325);
            this.rbnAnime.Name = "rbnAnime";
            this.rbnAnime.Size = new System.Drawing.Size(73, 24);
            this.rbnAnime.TabIndex = 15;
            this.rbnAnime.TabStop = true;
            this.rbnAnime.Text = "Anime";
            this.rbnAnime.UseVisualStyleBackColor = true;
            // 
            // rbnTV_Show
            // 
            this.rbnTV_Show.AutoSize = true;
            this.rbnTV_Show.Location = new System.Drawing.Point(741, 327);
            this.rbnTV_Show.Name = "rbnTV_Show";
            this.rbnTV_Show.Size = new System.Drawing.Size(87, 24);
            this.rbnTV_Show.TabIndex = 16;
            this.rbnTV_Show.TabStop = true;
            this.rbnTV_Show.Text = "TV Show";
            this.rbnTV_Show.UseVisualStyleBackColor = true;
            // 
            // lbLanguages
            // 
            this.lbLanguages.AutoSize = true;
            this.lbLanguages.Location = new System.Drawing.Point(377, 275);
            this.lbLanguages.Name = "lbLanguages";
            this.lbLanguages.Size = new System.Drawing.Size(77, 20);
            this.lbLanguages.TabIndex = 17;
            this.lbLanguages.Text = "languages";
            // 
            // cbxEnglish
            // 
            this.cbxEnglish.AutoSize = true;
            this.cbxEnglish.Location = new System.Drawing.Point(460, 275);
            this.cbxEnglish.Name = "cbxEnglish";
            this.cbxEnglish.Size = new System.Drawing.Size(78, 24);
            this.cbxEnglish.TabIndex = 18;
            this.cbxEnglish.Text = "English";
            this.cbxEnglish.UseVisualStyleBackColor = true;
            // 
            // cbxGerman
            // 
            this.cbxGerman.AutoSize = true;
            this.cbxGerman.Location = new System.Drawing.Point(544, 275);
            this.cbxGerman.Name = "cbxGerman";
            this.cbxGerman.Size = new System.Drawing.Size(83, 24);
            this.cbxGerman.TabIndex = 19;
            this.cbxGerman.Text = "German";
            this.cbxGerman.UseVisualStyleBackColor = true;
            // 
            // cbxDutch
            // 
            this.cbxDutch.AutoSize = true;
            this.cbxDutch.Location = new System.Drawing.Point(642, 275);
            this.cbxDutch.Name = "cbxDutch";
            this.cbxDutch.Size = new System.Drawing.Size(70, 24);
            this.cbxDutch.TabIndex = 20;
            this.cbxDutch.Text = "Dutch";
            this.cbxDutch.UseVisualStyleBackColor = true;
            // 
            // cbxJapanese
            // 
            this.cbxJapanese.AutoSize = true;
            this.cbxJapanese.Location = new System.Drawing.Point(718, 274);
            this.cbxJapanese.Name = "cbxJapanese";
            this.cbxJapanese.Size = new System.Drawing.Size(99, 24);
            this.cbxJapanese.TabIndex = 21;
            this.cbxJapanese.Text = "Janpanese";
            this.cbxJapanese.UseVisualStyleBackColor = true;
            // 
            // cbxMandrin
            // 
            this.cbxMandrin.AutoSize = true;
            this.cbxMandrin.Location = new System.Drawing.Point(823, 275);
            this.cbxMandrin.Name = "cbxMandrin";
            this.cbxMandrin.Size = new System.Drawing.Size(86, 24);
            this.cbxMandrin.TabIndex = 22;
            this.cbxMandrin.Text = "Mandrin";
            this.cbxMandrin.UseVisualStyleBackColor = true;
            // 
            // listBoxFilms
            // 
            this.listBoxFilms.FormattingEnabled = true;
            this.listBoxFilms.ItemHeight = 20;
            this.listBoxFilms.Items.AddRange(new object[] {
            "List of Films:"});
            this.listBoxFilms.Location = new System.Drawing.Point(15, 14);
            this.listBoxFilms.Name = "listBoxFilms";
            this.listBoxFilms.Size = new System.Drawing.Size(356, 404);
            this.listBoxFilms.TabIndex = 23;
            this.listBoxFilms.SelectedIndexChanged += new System.EventHandler(this.listBoxFilms_SelectedIndexChanged);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(373, 235);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(229, 20);
            this.lb.TabIndex = 24;
            this.lb.Text = "Lenght in mins or Number or Edp";
            // 
            // tbxLenghtOrEdp
            // 
            this.tbxLenghtOrEdp.Location = new System.Drawing.Point(630, 232);
            this.tbxLenghtOrEdp.Name = "tbxLenghtOrEdp";
            this.tbxLenghtOrEdp.Size = new System.Drawing.Size(125, 27);
            this.tbxLenghtOrEdp.TabIndex = 25;
            // 
            // AdminFilmUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbxLenghtOrEdp);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.listBoxFilms);
            this.Controls.Add(this.cbxMandrin);
            this.Controls.Add(this.cbxJapanese);
            this.Controls.Add(this.cbxDutch);
            this.Controls.Add(this.cbxGerman);
            this.Controls.Add(this.cbxEnglish);
            this.Controls.Add(this.lbLanguages);
            this.Controls.Add(this.rbnTV_Show);
            this.Controls.Add(this.rbnAnime);
            this.Controls.Add(this.rbnMovie);
            this.Controls.Add(this.tbxYear);
            this.Controls.Add(this.tbxInfo);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "AdminFilmUC";
            this.Size = new System.Drawing.Size(1069, 427);
            this.Load += new System.EventHandler(this.AdminFilmUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox tbxID;
        private Label lbID;
        private Label lbTitle;
        private Label label3;
        private Label lbInfo;
        private Label lbYear;
        private TextBox tbxTitle;
        private TextBox tbxInfo;
        private TextBox tbxYear;
        private RadioButton rbnMovie;
        private RadioButton rbnAnime;
        private RadioButton rbnTV_Show;
        private Label lbLanguages;
        private CheckBox cbxEnglish;
        private CheckBox cbxGerman;
        private CheckBox cbxDutch;
        private CheckBox cbxJapanese;
        private CheckBox cbxMandrin;
        private ListBox listBoxFilms;
        private Label lb;
        private TextBox tbxLenghtOrEdp;
    }
}
