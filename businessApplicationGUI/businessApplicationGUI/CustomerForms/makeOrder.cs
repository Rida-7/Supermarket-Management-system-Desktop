using projectBusiness_.BL;
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
    public partial class makeOrder : Form
    {
        public makeOrder()
        {
            InitializeComponent();
        }

        private void makeOrder_Load(object sender, EventArgs e)
        {
            gridMakeOrder.DataSource = ProductDL.getProduct();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            customerMenus menu = new customerMenus();
            this.Hide();
            menu.Show();
        }

        private void btncart_Click(object sender, EventArgs e)
        {
            Product p = (Product)gridMakeOrder.CurrentRow.DataBoundItem;
            orderingForm f = new orderingForm(p);
            f.ShowDialog();
            
            
        }
    }
}
