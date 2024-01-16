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

namespace businessApplicationGUI.AdminForms
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void clearDataFromForm()
        {
            txtCategory.Text = " ";
            txtName.Text = " ";
            txtPrice.Text = " ";
            txtQuantity.Text = " ";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Product product = new Product(txtCategory.Text, txtName.Text, int.Parse(txtQuantity.Text), int.Parse(txtPrice.Text));
            ProductDL.addToList(product);
            ProductDL.addToFile("product.txt", product);
            MessageBox.Show("Product Added Successfully!!!");
            clearDataFromForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            this.Hide();
            adminMenu.Show();
        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
