using LogicLibrary;
using LogicLibrary.DAL;
using MySql.Data;
using personal_project_app.Forms;

namespace personal_project_app
{
    public partial class LoginForm : Form
    {
        //LoginClass login = new LoginClass();
        UserClass LoggedInUser = new UserClass();
        public UserClass? Currentuser { get;}
        public LoginForm()
        {
            InitializeComponent();
            signupuc1.Hide();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            LogIn(Username.Text, Password.Text);
        }

        private void LogIn(string un, string pass)
        {
            bool result = Services.UserManager.Login(un, pass, out LoggedInUser);
            
            if (! result)
            {
                MessageBox.Show("No user found");
            }
            else if (LoggedInUser.HasAuthority == true)
            {
                AdminForm admin = new AdminForm(LoggedInUser);
                admin.Show();
            }
            else
            {
                MainForm openForm = new MainForm(LoggedInUser);
                openForm.Show();
            }
        }

        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signupuc1.Show();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signupuc1.Hide();
        }

    }
}