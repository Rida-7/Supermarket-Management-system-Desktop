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
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void gridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataBind()
        {
            gridProduct.DataSource = null;
            gridProduct.DataSource = ProductDL.getProduct();
            gridProduct.Refresh();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            gridProduct.DataSource = ProductDL.getProduct();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            this.Hide();
            adminMenu.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Product p = (Product)gridProduct.CurrentRow.DataBoundItem;
            UpdateProductForm form = new UpdateProductForm(p);
            form.ShowDialog();
            dataBind();
        }
    }
}
