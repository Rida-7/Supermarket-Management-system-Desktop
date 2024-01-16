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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void clearDatafromForm()
        {
            txtUserName.Text = " ";
            txtPassword.Text = " ";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != null && txtPassword.Text != null)
            {
                TheUser user = new TheUser(txtUserName.Text, txtPassword.Text);
                TheUser validUser = TheUserDL.signIn(user);
                if (validUser != null)
                {
                    if (validUser.getRole() == "Admin" || validUser.getRole() == "admin")
                    {
                        AdminForms.AdminMenu s = new AdminForms.AdminMenu();
                        this.Hide();
                        s.Show();
                    }
                    else if (validUser.getRole() == "customer" || validUser.getRole() == "Customer")
                    {
                        CustomerForms.customerMenus s = new CustomerForms.customerMenus();
                        this.Hide();
                        s.Show();
                    }

                }
                else
                {
                    MessageBox.Show("INVALID USER");
                }
                clearDatafromForm();
            }
            else
            {
                MessageBox.Show("Enter Data....!!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SignUp up = new SignUp();
            this.Hide();
            up.Show();
        }
    }
}
