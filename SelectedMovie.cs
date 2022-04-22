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
    public partial class SelectedMovie : UserControl
    {
        public FilmManager FilmManager;
        public UserManager userManager;
        public UserClass CurrentUser { get; set; }
        private Film currentFilm;
        public Film CurrentFilm { get { return currentFilm; } set { currentFilm = value; } }

        public SelectedMovie()
        {
            InitializeComponent();
            FilmManager = Services.FilmManager;
            userManager = Services.UserManager;
            
        }

        private void ShowInfo()
        {
            lbTitle.Text = $"{CurrentFilm.Title}";
            lbYear.Text = $"Year : {CurrentFilm.Year}";
            lbInfo.Text = $"Info : {CurrentFilm.Info}";
            //lbRateNum.Text = Convert.ToString(CurrentFilm.Rate);

            foreach (Rate r in FilmManager.GetAllReviews())
            {
                if (r.Film == CurrentFilm)
                {
                    listBoxReviews.Items.Add( $"{CurrentFilm.Title} is rated {r.Rating} by {r.User.Username} and they think {r.Comment}");
                }
            }
        }

        private void UpdateReview()
        {
            string comment = tbxComment.Text;
            int rating = (int)numericUpDown1.Value;
            Rate rate = new Rate(rating, CurrentUser, CurrentFilm, comment);
            FilmManager.UpdateReview(rate);
            if (comment != "")
            {
                listBoxReviews.Items.Add($"{CurrentFilm.Title} is rated {rating} by {CurrentUser.Username} and they think {comment}");
            }
            listBoxReviews.Items.Add($"{CurrentFilm.Title} is rated {rating} by {CurrentUser.Username}");
        }

        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            UpdateReview();
        }

        private void SelectedMovie_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }
    }
}
