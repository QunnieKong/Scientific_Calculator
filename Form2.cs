using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScienceCalculator
{
    public partial class Form2 : Form
    {
        int c;
        float a,b,re;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing()
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            c = 1;
            if (re != 0)
            {
                a = re;
            }
            else a = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            c = 2;
            if (re != 0)
            {
                a = re;
            }
            else a = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            c = 3;
            if (re != 0)
            {
                a = re;
            }
            else a = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            c = 4;
            if (re != 0)
            {
                a = re;
            }
            else a = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            b=Convert.ToInt32(textBox1.Text);
            switch(c){
                case 1:
                    re=a+b;
                    break;
                case 2:
                    re=a-b;
                    break;
                case 3:
                    re=a*b;
                    break;
                case 4:
                    re=a/b;
                    break;                    
            }
            textBox2.Text = Convert.ToString(re);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            c = 0;
            a = 0;
            b = 0;
            re = 0;
        }

    }
}
