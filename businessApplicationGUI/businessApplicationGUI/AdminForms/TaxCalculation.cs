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
    public partial class TaxCalculation : Form
    {
        public TaxCalculation()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TaxCalculation_Load(object sender, EventArgs e)
        {
            gridTax.DataSource = ProductDL.getProduct();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            this.Hide();
            adminMenu.Show();
        }

        private void btnTax_Click(object sender, EventArgs e)
        {
            Product p = (Product)gridTax.CurrentRow.DataBoundItem;
            float tax = p.calculateTax();
            gridTax.CurrentRow.SetValues(tax.ToString());

        }
    }
}
