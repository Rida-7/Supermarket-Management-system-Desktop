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

namespace businessApplicationGUI.AdminForms
{
    public partial class ListProducts : Form
    {
        public ListProducts()
        {
            InitializeComponent();
        }

        private void ListProducts_Load(object sender, EventArgs e)
        {
            gridProductList.DataSource = ProductDL.getProduct();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            this.Hide();
            adminMenu.Show();
        }

        private void gridProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
