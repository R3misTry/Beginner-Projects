using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yarışma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soru=0, doğru=0, yanlış=0;

        private void a_Click(object sender, EventArgs e)
        {
            a.Enabled = false;
            b.Enabled = false;
            c.Enabled = false;
            d.Enabled = false;
            sonraki.Enabled = true;
            if (a.Text == cevap)
            {
                doğru++;
                dogru.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                yanlis.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void c_Click(object sender, EventArgs e)
        {
            a.Enabled = false;
            b.Enabled = false;
            c.Enabled = false;
            d.Enabled = false;
            sonraki.Enabled = true;
            if (c.Text == cevap)
            {
                doğru++;
                dogru.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                yanlis.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void d_Click(object sender, EventArgs e)
        {
            a.Enabled = false;
            b.Enabled = false;
            c.Enabled = false;
            d.Enabled = false;
            sonraki.Enabled = true;
            if (d.Text == cevap)
            {
                doğru++;
                dogru.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                yanlis.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            a.Enabled = false;
            b.Enabled = false;
            c.Enabled = false;
            d.Enabled = false;
            sonraki.Enabled = true;
            if (b.Text == cevap)
            {
                doğru++;
                dogru.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                yanlis.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        string cevap;
        private void sonraki_Click(object sender, EventArgs e)
        {
            soru++;
            soruno.Text = soru.ToString();
            a.Enabled = true;
            b.Enabled = true;
            c.Enabled = true;
            d.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            sonraki.Enabled = false;

            if (soru == 1)
            {
                richTextBox1.Text = "Can you follow me and star any project on github ?";
                a.Text = "yes";
                b.Text = "no";
                c.Text = "why?";
                d.Text = "cry";
                sonraki.Text = "Next";
                cevap = "yes";
            }
            else if (soru == 2)
            {
                richTextBox1.Text = "Is this program good ?";
                a.Text = "no";
                b.Text = "yes";
                c.Text = "idk";
                d.Text = "good for beginner";
                cevap = "good for beginner";
            }
            else if (soru == 3)
            {
                richTextBox1.Text = "Is R3misTry a good developer ?";
                a.Text = "absolutely no";
                b.Text = "no";
                c.Text = "need more practice";
                d.Text = "he is perfect";
                cevap = "need more practice";
                sonraki.Text = "Results";
            }
            if (soru == 4)
            {
                soru -= 1;
                a.Enabled = false;
                b.Enabled = false;
                c.Enabled = false;
                d.Enabled = false;
                soruno.Text = "3";
                sonraki.Enabled = false;
                MessageBox.Show("Correct Question : " + doğru + "\n" + "False Question : " + yanlış);
            }
        }
    }
}
