using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
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
            double sayi1, sayi2, toplam;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox3.Text);
            string ifade = textBox2.Text;

            if (ifade == "+")
            {
                toplam = sayi1 + sayi2;
                label6.Text = toplam.ToString();
            }
            else if (ifade == "-")
            {
                toplam = sayi1 - sayi2;
                label6.Text = toplam.ToString();
            }
            else if (ifade == "/")
            {
                toplam = sayi1 / sayi2;
                label6.Text = toplam.ToString();
            }
            else
                label6.Text = "NaN";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }
    }
}
