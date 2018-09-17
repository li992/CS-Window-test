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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (UserName.Text.Length == 0)
            {
                MessageBox.Show("Please enter your username!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Password.Text.Length == 0)
                {
                    MessageBox.Show("Please enter your password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (PasswordR.Text.Length == 0)
                {
                    MessageBox.Show("Please re-enter your password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!String.Equals(Password.Text, PasswordR.Text))
                {
                    MessageBox.Show("The password is different from the re-entered ones!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (RBMale.Checked || RBFemale.Checked)
                    {
                        if (Major.SelectedIndex != -1)
                        {
                            UserInfo.userName = UserName.Text;
                            UserInfo.userPassword = Password.Text;
                            UserInfo.major = Major.Text;

                            if (RBMale.Checked)
                            {
                                UserInfo.gender = "male";
                            }
                            else
                            {
                                UserInfo.gender = "female";
                            }

                            MessageBox.Show("Register Successful! \n" +
                                "Username: " + UserInfo.userName + "\n" +
                                "Password: " + UserInfo.userPassword + "\n" +
                                "Gender: " + UserInfo.gender + "\n" +
                                "Major: " + UserInfo.major + "\n" , "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Please select your major!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select your gender!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            UserName.Text = "";
            Password.Text = "";
            PasswordR.Text = "";
            RBMale.Checked = false;
            RBFemale.Checked = false;
            Major.SelectedIndex = -1;

            UserInfo.userName = "";
            UserInfo.userPassword = "";
            UserInfo.gender = "";
            UserInfo.major = "";

            MessageBox.Show("All fields has been cleared!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.MdiParent = this.MdiParent;
            loginForm.Show();
            this.Hide();
        }
    }
}
