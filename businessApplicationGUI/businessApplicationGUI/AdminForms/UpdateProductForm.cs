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

namespace businessApplicationGUI.AdminForms
{
    public partial class UpdateProductForm : Form
    {
        private Product previous;
        public UpdateProductForm(Product previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            txtName.Text = previous.Name;
            txtCategory.Text = previous.Category;
            txtPrice.Text = previous.Price.ToString();
            txtQuantity.Text = previous.Quantity.ToString();

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Product updated = new Product(txtCategory.Text, txtName.Text, int.Parse(txtQuantity.Text), int.Parse(txtPrice.Text));
            ProductDL.updateProduct(previous, updated);
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
