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
    public partial class AdminFilmUC : UserControl
    {
        public FilmManager GetManager()
        {
            return Services.FilmManager;
        }
        public AdminFilmUC()
        {
            InitializeComponent();

        }
        /*public void RefreshGridView()
        
        {
            DataTable dt = GetManager().GetAllFilms();
            dataGridView1.DataSource = dt;
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
        }*/

        private void ClearAllFeilds()
        {
            cbxDutch.Checked = false;
            cbxEnglish.Checked = false;
            cbxGerman.Checked = false;
            cbxJapanese.Checked = false;
            cbxMandrin.Checked = false;
            rbnMovie.Checked = false;
            rbnAnime.Checked = false;
            rbnTV_Show.Checked = false;
            tbxLenghtOrEdp.Clear();
            tbxID.Clear();
            tbxTitle.Clear();
            tbxInfo.Clear();
            tbxYear.Clear();
        }

        private bool AreAllFeildsFilled()
        {
            if (tbxTitle.Text == "")
            {
                if (rbnMovie.Checked && rbnAnime.Checked && rbnTV_Show.Checked == false)
                {
                    return false;
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ShowfilmList()
        {
            foreach (Film f in GetManager().GetAllFilms())
            {
                listBoxFilms.Items.Add($"ID : {f.ID}, Title :{f.Title}, Info: {f.Info}, Year : {f.Year}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewFilm();
            ClearAllFeilds();
            ShowfilmList();
        }

        private void AddNewFilm()
        {
            //int id = Convert.ToInt32(tbxID.Text);
            string title = tbxTitle.Text;
            string info = tbxInfo.Text;
            int year = Convert.ToInt32(tbxYear.Text);
            int lenghtOrNumOfEdp = Convert.ToInt32(tbxLenghtOrEdp.Text);
            List<LANGUAGE> languages = new List<LANGUAGE>();
            WhatLanguagesAreChecked(languages);
            Film newfilm;
            if (rbnTV_Show.Checked == true)
            {
                newfilm = new TV_Show(title, year, languages,info, lenghtOrNumOfEdp);
            }
            else if (rbnAnime.Checked)
            {
                newfilm = new Anime(title, year, languages, info, lenghtOrNumOfEdp);
            }
            else
            {
                newfilm = new Movie(title, year, languages, info, lenghtOrNumOfEdp);
            }

            if (AreAllFeildsFilled())
            {
                if (GetManager().AddFlim(newfilm))
                {

                    MessageBox.Show("You added one film");
                }
                else
                {
                    MessageBox.Show("Something went wrong with adding it");
                }
            }
            else
            {
                MessageBox.Show("Please input a vaild info of the film");
            }
        }

        private void WhatLanguagesAreChecked(List<LANGUAGE> languages)
        {
            if (cbxEnglish.Checked)
            {
                languages.Add(LANGUAGE.ENGLISH);
            }
            if (cbxGerman.Checked)
            {
                languages.Add(LANGUAGE.GERMAN);
            }
            if (cbxDutch.Checked)
            {
                languages.Add(LANGUAGE.DUTCH);
            }
            if (cbxJapanese.Checked)
            {
                languages.Add(LANGUAGE.JANPANESE);
            }
            if (cbxMandrin.Checked)
            {
                languages.Add(LANGUAGE.MANDRAIN);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditFilm();
            ClearAllFeilds();
            ShowfilmList();
        }

        private void EditFilm()
        {
            try
            {
                int newYear = Convert.ToInt32(tbxYear.Text);
                if (listBoxFilms.SelectedIndex >= 0)
                {
                    int editFilmID = listBoxFilms.SelectedIndex;
                    string newTitle = tbxTitle.Text;
                    string newInfo = tbxInfo.Text;

                    //int year = Convert.ToInt32(tbxYear.Text);
                    int lenghtOrNumOfEdp = Convert.ToInt32(tbxLenghtOrEdp.Text);
                    List<LANGUAGE> languages = new List<LANGUAGE>();
                    foreach (Film f in GetManager().GetAllFilms())
                    {
                        if (f.ID == editFilmID)
                        {
                            GetManager().UpdateFilm(f, newTitle, newYear, newInfo);
                            f.Title = newTitle;
                            f.Info = newInfo;
                        }
                        else
                        {
                            MessageBox.Show("Please selecte a vaild film");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please put a vaild year");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxFilms.SelectedIndex >= 0)
            {
                GetManager().DeleteMovies(listBoxFilms.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please selecte a vaild film");
            }
            ClearAllFeilds();
            ShowfilmList();
        }
        public void ReflectSelectFilm()
        {
            Film editFilm;
            int editFilmID = listBoxFilms.SelectedIndex;
            foreach (Film f in GetManager().GetAllFilms())
            {
                if (f.ID == editFilmID)
                {
                    editFilm = f;
                    tbxID.Text = $"{editFilm.ID}";
                    tbxTitle.Text = $"{editFilm.Title}";
                    tbxInfo.Text = $"{editFilm.Info}";
                    tbxYear.Text = $"{editFilm.Year}";
                }
            }
            if (editFilmID < 0)
            {
                MessageBox.Show("No vailed film selected");
            }
           
        }
        private void listBoxFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReflectSelectFilm();
        }

        private void AdminFilmUC_Load(object sender, EventArgs e)
        {
            ShowfilmList();
        }
    }
}
