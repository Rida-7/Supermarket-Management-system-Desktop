using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projectBusiness_.DL;
using projectBusiness_.BL;

namespace businessApplicationGUI.AdminForms
{
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void dataBind()
        {
            gridProduct.DataSource = null;
            gridProduct.DataSource = ProductDL.getProduct();
            gridProduct.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Product p = (Product)gridProduct.CurrentRow.DataBoundItem;
            ProductDL.deleteProduct(p);
            MessageBox.Show("Product Deleted Successfully");
            

            dataBind();
        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            gridProduct.DataSource = ProductDL.getProduct();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            this.Hide();
            adminMenu.Show();
        }
    }
}
