using projectBusiness_.DL;
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
    public partial class viewCart : Form
    {
        public viewCart()
        {
            InitializeComponent();
        }

        private void viewCart_Load(object sender, EventArgs e)
        {
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            gridOrder.DataSource = CustomerDL.viewCart(txtName.Text);
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            customerMenus menu = new customerMenus();
            this.Hide();
            menu.Show();
        }
    }
}
