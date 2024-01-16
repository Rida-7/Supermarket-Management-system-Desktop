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
    public partial class productList : Form
    {
        public productList()
        {
            InitializeComponent();
        }

        private void gridList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            customerMenus menu = new customerMenus();
            this.Hide();
            menu.Show();
        }

        private void productList_Load(object sender, EventArgs e)
        {
            gridList.DataSource = ProductDL.getProduct();
        }
    }
}
