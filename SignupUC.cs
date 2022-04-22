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
    public partial class SignupUC : UserControl
    {
        UserManager userManager;
        public SignupUC()
        {
            InitializeComponent();
            userManager = Services.UserManager;
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            SignUp();
        }

        private void SignUp()
        {
            string username = tbUserName.Text.ToString();
            string password = tbPassword.Text.ToString();
            bool isAdmin = false;

            if (cbAdmin.Checked)
            {
                isAdmin = true;
            }
            if (password.Length < 4)
            {
                lbSignUpInfo.Text = "*password requires at least 3 charaters*";
                lbSignUpInfo.ForeColor = Color.Red;
                tbPassword.Clear();
                MessageBox.Show("password requires at least 3 charaters");
            }
            UserClass newUser = new UserClass(username, password, isAdmin);
            userManager.CreateUser(newUser);
            tbUserName.Clear();
            tbPassword.Clear();
        }
    }
}
