using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Window_test
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Login validation
        private void Login_Click(object sender, EventArgs e)
        {
            String userName = UserName.Text;
            String userPassword = UserPassword.Text;

            if (userName.Length == 0)
            {
                MessageBox.Show("Please enter your username!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (userPassword.Length == 0)
                {
                    MessageBox.Show("Please enter your password!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (String.Equals(userName, UserInfo.userName) && String.Equals(userPassword, UserInfo.userPassword))
                    {
                        MessageBox.Show("Welcome! " + UserInfo.userName, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (String.Equals(userName, UserInfo.userName) && !String.Equals(userPassword, UserInfo.userPassword))
                    {
                        MessageBox.Show("Wrong Password!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("User does not exist! \nDo you want to create a new account?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            RegisterForm registerForm = new RegisterForm();
                            registerForm.MdiParent = this.MdiParent;
                            registerForm.Show();
                            this.Hide();
                        }
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.MdiParent = this.MdiParent;
            registerForm.Show();
            this.Hide();
        }


    }
    //Default user information
    static class UserInfo
    {
        public static String userName = "YourUserName";
        public static String userPassword = "12345678";
        public static String gender = "Male";
        public static String major = "Computer Science";
    }
}
