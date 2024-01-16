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

namespace businessApplicationGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (TheUserDL.loadFromFile("userdata.txt"))
            {
                MessageBox.Show("Users Data Loaded Successfully!!");
            }
            if (ProductDL.readFromFile("product.txt"))
            {
                MessageBox.Show("Products Data Loaded Successfully!!");
            }
            if (CustomerDL.readFromFile("order.txt"))
            {
                MessageBox.Show("Orders Data Loaded Successfully!!");
            }
        }

        private void clearDataFromForm()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMainNext_Click(object sender, EventArgs e)
        {
          
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressBar1.Value = startpoint;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                SignUp up = new SignUp();
                this.Hide();
                up.Show();
            }
        }
    }
}
