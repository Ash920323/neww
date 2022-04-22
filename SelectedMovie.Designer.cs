namespace personal_project_app.UserControls
{
    partial class SelectedMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectedMovie));
            this.label1 = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.listBoxReviews = new System.Windows.Forms.ListBox();
            this.btnSubmitReview = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbRateNum = new System.Windows.Forms.Label();
            this.tbxComment = new System.Windows.Forms.TextBox();
            this.lbRate = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.MoviePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Rating:";
            this.label1.Visible = false;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(24, 375);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(40, 20);
            this.lbInfo.TabIndex = 21;
            this.lbInfo.Text = "Info:";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(24, 326);
            this.lbYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(43, 20);
            this.lbYear.TabIndex = 20;
            this.lbYear.Text = "Year:";
            // 
            // listBoxReviews
            // 
            this.listBoxReviews.FormattingEnabled = true;
            this.listBoxReviews.ItemHeight = 20;
            this.listBoxReviews.Items.AddRange(new object[] {
            "Reviews:"});
            this.listBoxReviews.Location = new System.Drawing.Point(559, 162);
            this.listBoxReviews.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxReviews.Name = "listBoxReviews";
            this.listBoxReviews.Size = new System.Drawing.Size(396, 284);
            this.listBoxReviews.TabIndex = 19;
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.Location = new System.Drawing.Point(878, 69);
            this.btnSubmitReview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(126, 56);
            this.btnSubmitReview.TabIndex = 18;
            this.btnSubmitReview.Text = "submit review";
            this.btnSubmitReview.UseVisualStyleBackColor = true;
            this.btnSubmitReview.Click += new System.EventHandler(this.btnSubmitReview_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(679, 34);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(203, 27);
            this.numericUpDown1.TabIndex = 17;
            // 
            // lbRateNum
            // 
            this.lbRateNum.AutoSize = true;
            this.lbRateNum.Location = new System.Drawing.Point(422, 261);
            this.lbRateNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRateNum.Name = "lbRateNum";
            this.lbRateNum.Size = new System.Drawing.Size(17, 20);
            this.lbRateNum.TabIndex = 16;
            this.lbRateNum.Text = "0";
            this.lbRateNum.Visible = false;
            // 
            // tbxComment
            // 
            this.tbxComment.Location = new System.Drawing.Point(559, 98);
            this.tbxComment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxComment.Name = "tbxComment";
            this.tbxComment.PlaceholderText = "Comment...";
            this.tbxComment.Size = new System.Drawing.Size(293, 27);
            this.tbxComment.TabIndex = 15;
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Location = new System.Drawing.Point(559, 34);
            this.lbRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(57, 20);
            this.lbRate.TabIndex = 14;
            this.lbRate.Text = "Rating:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(24, 261);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(38, 20);
            this.lbTitle.TabIndex = 13;
            this.lbTitle.Text = "Title";
            // 
            // MoviePic
            // 
            this.MoviePic.Image = ((System.Drawing.Image)(resources.GetObject("MoviePic.Image")));
            this.MoviePic.Location = new System.Drawing.Point(24, 21);
            this.MoviePic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MoviePic.Name = "MoviePic";
            this.MoviePic.Size = new System.Drawing.Size(428, 214);
            this.MoviePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoviePic.TabIndex = 12;
            this.MoviePic.TabStop = false;
            // 
            // SelectedMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.listBoxReviews);
            this.Controls.Add(this.btnSubmitReview);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbRateNum);
            this.Controls.Add(this.tbxComment);
            this.Controls.Add(this.lbRate);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.MoviePic);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SelectedMovie";
            this.Size = new System.Drawing.Size(1022, 479);
            this.Load += new System.EventHandler(this.SelectedMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbInfo;
        private Label lbYear;
        private ListBox listBoxReviews;
        private Button btnSubmitReview;
        private NumericUpDown numericUpDown1;
        private Label lbRateNum;
        private TextBox tbxComment;
        private Label lbRate;
        private Label lbTitle;
        private PictureBox MoviePic;
    }
}
