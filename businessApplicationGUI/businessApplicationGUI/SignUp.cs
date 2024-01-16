using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projectBusiness_.BL;
using projectBusiness_.DL;

namespace businessApplicationGUI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void clearDataFromForm()
        {
            txtUserName.Text = " ";
            txtPassword.Text = " ";
            txtRole.Text = " ";
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
        }

        private void btnSignUpNext_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != null && txtPassword.Text != null && txtRole.Text != null)
            {
                TheUser user = new TheUser(txtUserName.Text, txtPassword.Text, txtRole.Text);
                TheUserDL.addTolist(user);
                TheUserDL.addToFile("userdata.txt", user);
                MessageBox.Show("User Added Successfully!!");
                SignIn inn = new SignIn();
                this.Hide();
                inn.Show();
                clearDataFromForm();
            }
            else
            {
                MessageBox.Show("Enter Data....!!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ThankYou For Using This Application :)");
            this.Close();
        }

        private void linkLabelSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn inn = new SignIn();
            this.Hide();
            inn.Show();
        }
    }
}
