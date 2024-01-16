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
    public partial class getBill : Form
    {
        public getBill()
        {
            InitializeComponent();
        }

        private void getBill_Load(object sender, EventArgs e)
        {
            
            
        }

        private void lblBill_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            customerMenus menu = new customerMenus();
            this.Hide();
            menu.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int bill = CustomerDL.getBill(txtName.Text);
            lblBill.Text = "Your Bill is : " + bill.ToString();
           
        }
    }
}
