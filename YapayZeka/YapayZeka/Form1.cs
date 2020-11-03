using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YapayZeka
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

        private void button1_Click(object sender, EventArgs e)
        {
            Double X_1 = Convert.ToDouble(this.textBox1.Text);
            Double X_2 = Convert.ToDouble(this.textBox2.Text);
            Double X_3 = Convert.ToDouble(this.textBox3.Text);
            
            Double W_1 = Convert.ToDouble(this.textBox4.Text);
            Double W_2 = Convert.ToDouble(this.textBox5.Text);
            Double W_3 = Convert.ToDouble(this.textBox6.Text);

            Double B_1 = Convert.ToDouble(this.textBox7.Text);
            Double net = (X_1 * W_1 + X_2 * W_2 + X_3 * W_3)+(B_1);
            NetBox.Text = net.ToString();

            Double Sigmoid = (1 / (1 + Math.Pow(2.718,(1/net))             ));
            textBox9.Text = Sigmoid.ToString();
            textBox10.Text = net.ToString();

            Double Heparbolik = (Math.Pow(2.178, net) - Math.Pow(2.178, (1 / net)))/ (Math.Pow(2.178, net) - Math.Pow(2.178, (1 / net)));
            textBox11.Text = Heparbolik.ToString();
            int b = 1;
            int c = 0;
            if (net >0)
            {
                textBox12.Text =b.ToString();
            }
            else
            {
                textBox12.Text = c.ToString();
            }


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
