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
using personal_project_app.UserControls;

namespace personal_project_app
{
    public partial class MainForm : Form
    {
        
        FilmManager filmManager;
        public UserClass User { get; set; }
        public List<Film> filmsOptions;
        public MainForm(UserClass user)
        {

            filmManager = Services.FilmManager;
            User = user;
            PassingInfo(user);
            InitializeComponent();
            
        }

        private void PassingInfo(UserClass user)
        {
            
            lbUserName.Text = user.Username;
            
            selectedMovie1.Hide();
            selectedMovie1.CurrentUser = user;
            List<string> movies = filmManager.GetFilmNames();
            lbMovie1.Text = movies[0];
            lbMovie2.Text = movies[1];
            lbMovie3.Text = movies[2];
            ShowAllOptions();
        }

        private void ShowAllOptions()
        {
            lbMovie1.Visible = true;
            lbMovie2.Visible = true;
            lbMovie3.Visible = true;
            PicMovie1.Show();
            PicMovie3.Show();
            PicMovie2.Show();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchWord = tbSearchbar.Text.ToString();
            if (searchWord == "")
            {
                MessageBox.Show("You didn't put any key words");
            }
            else
            foreach (string title in filmManager.GetFilmNames())
            {
                if (title.Contains(searchWord))
                {
                    MessageBox.Show($"Are you finding {title}");
                }
                
            } 
            
            int index = filmManager.GetFilmNames().FindIndex(a => a.Contains(searchWord));
            if (index >= 0)
            {
                lbMovie1.Visible = false;
                lbMovie2.Visible = false;
                lbMovie3.Visible = false;
                PicMovie1.Hide();
                PicMovie2.Hide();
                PicMovie3.Hide();
                if (filmManager.GetFilmNames()[index] == lbMovie1.Text.ToString())
                {
                    PicMovie1.Show();
                    lbMovie1.Visible = true;
                }
                if (filmManager.GetFilmNames()[index] == lbMovie2.Text.ToString())
                {
                    PicMovie2.Show();
                    lbMovie2.Visible = true;
                }
                if (filmManager.GetFilmNames()[index] == lbMovie3.Text.ToString())
                {
                    PicMovie3.Show();
                    lbMovie3.Visible = true;
                }
            }
            else
                MessageBox.Show("No films found");
                ShowAllOptions();
        }

        private void ShowCertainPictureBox(PictureBox pb)
        {
            PicMovie1.Hide();
            PicMovie2.Hide();
            PicMovie3.Hide();
            pb.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            selectedMovie1.CurrentFilm = filmsOptions[0];
            selectedMovie1.Show();
        }

        private void PicMovie2_Click(object sender, EventArgs e)
        {
            //selectedMovie1.CurrentFilm = filmManager.GetAllFilms()[1];
            selectedMovie1.Show();
        }

        private void PicMovie3_Click(object sender, EventArgs e)
        {
            //selectedMovie1.CurrentFilm = filmManager.GetAllFilms()[2];
            selectedMovie1.Show();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            selectedMovie1.Hide();
            PassingInfo(User);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            filmsOptions = filmManager.GetAllFilms();
            selectedMovie1.CurrentFilm = filmsOptions[0];
        }
    }
}
