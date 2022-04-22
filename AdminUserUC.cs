using LogicLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personal_project_app.UserControls
{
    public partial class AdminUserUC : UserControl
    {
        public AdminUserUC()
        {
            InitializeComponent();
            GetUserManager();
            ShowAllUsers();
        }

        private UserManager GetUserManager()
        {
            return Services.UserManager;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewUser();
            ClearAllFeilds();
        }

        private void ClearAllFeilds()
        {
            tbxUsername.Clear();
            tbxPassword.Clear();
            cbIsAdmin.Checked = false;
        }

        private bool IsUsernameVaild(string newUserName, string newPassword)
        {
            newUserName = tbxUsername.Text;
            newPassword = tbxPassword.Text;
            if (newUserName.Length >= 3 && newPassword.Length >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void AddNewUser()
        {
            string newUserName = tbxUsername.Text;
            string newPassword = tbxPassword.Text;
            bool newHasAuthority = cbIsAdmin.Checked;
            if (IsUsernameVaild(newUserName, newPassword))
            {
                UserClass newUser = new UserClass(newUserName, newPassword, newHasAuthority);
                GetUserManager().CreateUser(newUser);

                string IsAdmin = "No";
                if (newHasAuthority == true)
                {
                    IsAdmin = "Yes";
                }
                listBoxUsers.Items.Add($"id :{newUser.Id}, Username: {newUserName}, Password{newPassword}, Admin? {IsAdmin}"); 
            }
            else
            {
                MessageBox.Show("That's not a vaild user name or passoword");
            }
            ShowAllUsers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSelectedUser();
            ClearAllFeilds();
            ShowAllUsers();
        }

        public void ReflectSelectUser()
        {
            UserClass selectedUser = new UserClass();
            int editUserID = listBoxUsers.SelectedIndex + 1;
            foreach (UserClass u in GetUserManager().ReturnAllUsers())
            {
                if (u.Id == editUserID)
                {
                    selectedUser = u;
                    tbxUsername.Text = $"{selectedUser.Username}";
                    tbxPassword.Text = $"{selectedUser.Password}";
                    cbIsAdmin.Checked = selectedUser.HasAuthority;
                }
            }
            if (selectedUser == null)
            {
                MessageBox.Show("No vailed user selected");
            }
        }

        public void EditSelectedUser()
        {
            UserClass selectedUser = new UserClass(); 
            string newUserName = tbxUsername.Text;
            string newPassword = tbxPassword.Text;
            bool newHasAuthority = cbIsAdmin.Checked;

            int editUserID = listBoxUsers.SelectedIndex + 1;
            foreach (UserClass u in GetUserManager().ReturnAllUsers())
            {
                if (u.Id == editUserID)
                {
                    selectedUser = u;
                }
            }
                if (IsUsernameVaild(newUserName, newPassword))
                {
                    GetUserManager().UpdateUser(selectedUser, newUserName, newPassword, newHasAuthority);

                    string IsAdmin = "No";
                    if (newHasAuthority == true)
                    {
                        IsAdmin = "Yes";
                    }
                    listBoxUsers.Items.Add($"id :{selectedUser .Id}, Username: {newUserName}, Password{newPassword}, Admin? {IsAdmin}");
                }
            else
            {
                MessageBox.Show("That's not a vaild user name or passoword");
            }
            ShowAllUsers();
        }

   
        private void ShowAllUsers()
        {
            listBoxUsers.Items.Clear();
            foreach (UserClass u in GetUserManager().ReturnAllUsers())
            {
                string IsAdmin = "No";
                if (u.HasAuthority == true)
                {
                    IsAdmin = "Yes";
                }
                listBoxUsers.Items.Add($"id :{u.Id}, Username: {u.Username}, Password{u.Password}, Admin? {IsAdmin}");
            }
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReflectSelectUser();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GetUserManager().DeleteUser(listBoxUsers.SelectedIndex + 1);
            ClearAllFeilds();
        }
    }
}
