using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLibrary;



namespace personal_project_app.UserControls
{
    public partial class ViewMovieUC : UserControl
    {
        public FilmManager FilmManager;
        public UserManager userManager;
        public UserClass CurrentUser { get; set; }
        public Film CurrentFilm { get { return CurrentFilm; } set {; } }
        public ViewMovieUC()
        {
            InitializeComponent();
            FilmManager = Services.FilmManager;
            userManager = Services.UserManager;
            ShowInfo();
        }

        private void ShowInfo()
        {
            lbTitle.Text = CurrentFilm.Title.ToString();
            lbYear.Text = $"Year : {CurrentFilm.Year}";
            lbInfo.Text = $"Info : {CurrentFilm.Info}";
            lbRateNum.Text = Convert.ToString(CurrentFilm.Rate);
            
            foreach (Rate r in FilmManager.GetAllReviews())
            {
                if (r.Film == CurrentFilm)
                {
                    listBoxReviews.Text += $"{CurrentFilm.Title} is rated {r.Rating} by {r.User.Username} and they think {r.Comment}";
                }
            }
        }

        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            UpdateReview();
        }

        private void UpdateReview()
        {
            string comment = tbxComment.Text;
            int rating = (int)numericUpDown1.Value;
            Rate rate = new Rate(rating, CurrentUser, CurrentFilm, comment);
            FilmManager.UpdateReview(rate);
            if (comment != "")
            {
                listBoxReviews.Text += $"{CurrentFilm.Title} is rated {rating} by {CurrentUser.Username} and they think {comment}";
            }
            listBoxReviews.Text += $"{CurrentFilm.Title} is rated {rating} by {CurrentUser.Username}";
        }
    }
}
