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
using businessApplicationGUI.AdminForms;

namespace businessApplicationGUI.CustomerForms
{
    public partial class orderingForm : Form
    {
        private Product previous;
        private List<Product> bought = new List<Product>();

        public orderingForm(Product p)
        {
            InitializeComponent();
            previous = p;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            makeOrder m = new makeOrder();
            this.Hide();
            m.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            previous.Quantity = int.Parse(txtQuantity.Text);
            bought.Add(previous);
            Customer c = new Customer(txtName.Text, previous);
            CustomerDL.addToList(c);
            CustomerDL.addToFile("order.txt", c);
            MessageBox.Show("Your order has been Placed!!");
            this.Hide();
            
        }

        private void linklblorder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            
        }

        private void orderingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
