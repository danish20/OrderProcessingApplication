using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderProcessingApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void calculateTotal()
        {
            int silverPhoneQty = int.Parse(this.silverPhone.Text);
            int bluePhoneQty = int.Parse(this.bluePhone.Text);
            int total = silverPhoneQty + bluePhoneQty;
            this.totalPhone.Text = total+"";
            this.totalPrice.Text = (total * 100).ToString("C");

        }

        public void exitApp()
        {
            this.Close();
        }

        private void calcTotal_Click(object sender, EventArgs e)
        {
            this.calculateTotal();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.exitApp();
        }
    }
}
