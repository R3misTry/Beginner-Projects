using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BüfeSatışPaneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            double poğaça, simit, çay, hamburger, icetea, su, toplam;
            poğaça = Convert.ToDouble(textBox1.Text);
            simit = Convert.ToDouble(textBox2.Text);
            çay = Convert.ToDouble(textBox3.Text);
            hamburger = Convert.ToDouble(textBox4.Text);
            icetea = Convert.ToDouble(textBox5.Text);
            su = Convert.ToDouble(textBox6.Text);
            toplam = poğaça * 4.50 + simit *2.50 + çay * 2 + hamburger * 10 + icetea * 3 + su * 1;
            toplamlab.Text = toplam.ToString("0.00") + " TL";

            kasatutar += toplam;
            kasalab.Text = kasatutar.ToString("0.00"+" TL");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox1.Focus();
            toplamlab.Text = "";
        }
    }
}
