using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace businessApplicationGUI.AdminForms
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SignUp up = new SignUp();
            this.Hide();
            up.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkViewProduct.Checked)
            {
                ListProducts listProducts = new ListProducts();
                this.Hide();
                listProducts.Show();
                checkViewProduct.Checked = false;
            }
            else if (checkAddProduct.Checked)
            {
                AddProduct data = new AddProduct();
                this.Hide();
                data.Show();
                checkAddProduct.Checked = false;
            }
            else if (checkDeleteProduct.Checked)
            {
                DeleteProduct delete = new DeleteProduct();
                this.Hide();
                delete.Show();
                checkDeleteProduct.Checked = false;
            }
            else if (checkUpdateProduct.Checked)
            {
                UpdateProduct update = new UpdateProduct();
                this.Hide();
                update.Show();
                checkUpdateProduct.Checked = false;
            }
            else if (checkCalculateTax.Checked)
            {
                TaxCalculation taxCalculation = new TaxCalculation();
                this.Hide();
                taxCalculation.Show();
                checkCalculateTax.Checked = false;
            }
            else if (checkViewOrder.Checked)
            {
                ViewOrders orders = new ViewOrders();
                this.Hide();
                orders.Show();
                checkViewOrder.Checked = false;
            }
        }
    }
}
