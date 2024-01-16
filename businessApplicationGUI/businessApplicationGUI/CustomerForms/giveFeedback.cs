using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace businessApplicationGUI.CustomerForms
{
    public partial class giveFeedback : Form
    {
        public giveFeedback()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You For Your FeedBack :]");
            customerMenus menu = new customerMenus();
            this.Hide();
            menu.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            customerMenus menu = new customerMenus();
            this.Hide();
            menu.Show();
        }

        private void giveFeedback_Load(object sender, EventArgs e)
        {

        }
    }
}
