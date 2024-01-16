using businessApplicationGUI.AdminForms;
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
    public partial class customerMenus : Form
    {
        public customerMenus()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SignUp up = new SignUp();
            this.Hide();
            up.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkList.Checked)
            {
                productList listProducts = new productList();
                this.Hide();
                listProducts.Show();
                checkList.Checked = false;
            }
            else if (checkMakeOrder.Checked)
            {
                makeOrder order = new makeOrder();
                this.Hide();
                order.Show();
                checkMakeOrder.Checked = false;
            }
            else if (checkViewCart.Checked)
            {
                viewCart cart = new viewCart();
                this.Hide();
                cart.Show();
                checkViewCart.Checked = false;
            }
            else if (checkGetBill.Checked)
            {
                getBill bill = new getBill();
                this.Hide();
                bill.Show();
                checkGetBill.Checked = false;
            }
            else if (checkFeedBack.Checked)
            {
                giveFeedback feedback = new giveFeedback();
                this.Hide();
                feedback.Show();
                checkFeedBack.Checked = false;
            }
        }

        private void customerMenus_Load(object sender, EventArgs e)
        {

        }
    }
}
