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
    public partial class Form1 : Form
    {
        int c,k,q;
        string s,t,r;
        double a,b,re;

        public Form1()
        {
            InitializeComponent();
            Form Form2=new Form();
        }

        /*===========================数字部分开始==============================*/
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

        /*======================数字部分结束============================*/


        private void button15_Click(object sender, EventArgs e)//小数点
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            k = 4;
            s = textBox1.Text;
            q = s.Length;
            textBox1.Text = s + "÷";
            if (s == "e")
            {
                a = Math.E;
            }
            else if (s == "π")
            {
                a = Math.PI;
            }
            else a = Convert.ToDouble(s);
        }//除法

        private void button19_Click(object sender, EventArgs e)
        {
            k = 3;
            s = textBox1.Text;
            q = s.Length;
            textBox1.Text = s + "×";
            if (s == "e")
            {
                a = Math.E;
            }
            else if (s == "π")
            {
                a = Math.PI;
            }
            else a = Convert.ToDouble(s);
        }//乘法

        private void button12_Click(object sender, EventArgs e)
        {
            k = 2;
            s = textBox1.Text;
            q = s.Length;
            textBox1.Text = s + "-";
            if (s == "e")
            {
                a = Math.E;
            }
            else if (s == "π")
            {
                a = Math.PI;
            }
            else a = Convert.ToDouble(s); 
        }//减法

        private void button11_Click(object sender, EventArgs e)
        {
            k = 1;
            s = textBox1.Text;
            q = s.Length;
            textBox1.Text = s + "+";
            if (s == "e")
            {
                a = Math.E;
            }
            else if (s == "π")
            {
                a = Math.PI;
            }
            else a = Convert.ToDouble(s); 
           
        }//加法

        private void button26_Click(object sender, EventArgs e)//幂运算
        {
            k = 14;
            s = textBox1.Text;
            q = s.Length;
            textBox1.Text = s + "^";
            if (s == "e")
            {
                a = Math.E;
            }
            else if (s == "π")
            {
                a = Math.PI;
            }
            else a = Convert.ToDouble(s);
        }

        private void button39_Click(object sender, EventArgs e)//π
        {
            k = 6;
            textBox1.Text = textBox1.Text + "π";
        }

        private void button24_Click(object sender, EventArgs e)//e
        {
            k = 5;
            textBox1.Text = textBox1.Text + "e";
        }

        private void button25_Click(object sender, EventArgs e)//阶乘
        {
            k = 7;
            s = textBox1.Text;
            q = s.Length;
            textBox1.Text = s + "!";
            if (s == "e")
            {
                a = Math.E;
            }
            else if (s == "π")
            {
                a = Math.PI;
            }
            else a = Convert.ToDouble(s);
        }

        private void button35_Click(object sender, EventArgs e)//10的x次幂
        {
            k = 8;
            s = textBox1.Text;
            q = s.Length;
            textBox1.Text = "10^" + s ;
            if (s == "e")
            {
                a = Math.E;
            }
            else if (s == "π")
            {
                a = Math.PI;
            }
            else a = Convert.ToDouble(s);
        }

        private void button32_Click(object sender, EventArgs e)//平方
        {
            k = 9;
            s = textBox1.Text;
            textBox1.Text = s + "²";
            if (s == "e")
            {
                a = Math.E;
            }
            else if (s == "π")
            {
                a = Math.PI;
            }
            else a = Convert.ToDouble(s);
        }

        private void button36_Click(object sender, EventArgs e)//三次方
        {
            k = 10;
            s = textBox1.Text;
            textBox1.Text = s + "³";
            if (s == "e")
            {
                a = Math.E;
            }
            else if (s == "π")
            {
                a = Math.PI;
            }
            else a = Convert.ToDouble(s);
        }

        private void button33_Click(object sender, EventArgs e)//平方根
        {
            k = 11;
            s = textBox1.Text;
            textBox1.Text = s + "½";
            if (s == "e")
            {
                a = Math.E;
            }
            else if (s == "π")
            {
                a = Math.PI;
            }
            else a = Convert.ToDouble(s);
        }

        private void button37_Click(object sender, EventArgs e)//倒数
        {
            k = 12;
            s = textBox1.Text;
            textBox1.Text = s + "^(-1)";
            if (s == "e")
            {
                a = Math.E;
            }
            else if (s == "π")
            {
                a = Math.PI;
            }
            else a = Convert.ToDouble(s);
        }

        private void button28_Click(object sender, EventArgs e)//以e为底对数
        {
            k = 13;
            s = textBox1.Text;
            textBox1.Text = "ln" + textBox1.Text;
            if (s == "e")
            {
                a = 1;
            }
            else if (s == "π")
            {
                b = Math.PI;
                a = Math.Log(b, Math.E);
            }
            else
            {
                b = Convert.ToDouble(s);
                a = Math.Log(b, Math.E);
            }
        }

        private void button38_Click(object sender, EventArgs e)//cos
        {
            k = 15;
            s = textBox1.Text;
            textBox1.Text = "cos" + s ;
            if (s == "e")
            {
                a = Math.E;
            }
            else if (s == "π")
            {
                a = Math.PI;
            }
            else a = Convert.ToDouble(s);
        }

        private void button34_Click(object sender, EventArgs e)//sin
        {
            k = 16;
            s = textBox1.Text;
            textBox1.Text ="sin" + s;
            if (s == "e")
            {
                a = Math.E;
            }
            else if (s == "π")
            {
                a = Math.PI;
            }
            else a = Convert.ToDouble(s);
        }

        private void button30_Click(object sender, EventArgs e)//tan
        {
            k = 17;
            s = textBox1.Text;
            textBox1.Text = "tan" + s;
            if (s == "e")
            {
                a = Math.E;
            }
            else if (s == "π")
            {
                a = Math.PI;
            }
            else a = Convert.ToDouble(s);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            k = 18;
            s = textBox1.Text;
            textBox1.Text = "log10^" + s;
            if (s == "e")
            {
                a = Math.E;
            }
            else if (s == "π")
            {
                a = Math.PI;
            }
            else a = Convert.ToDouble(s);

        }//以10为底对数

        private void button23_Click(object sender, EventArgs e)//变为精简模式
        {
            this.Close();
            new Form2().Show();
        }

        private void button20_Click(object sender, EventArgs e)//退格
        {
            t=textBox1.Text;
            int c=textBox1.Text.Length;
            if (c != 0)
            {
                textBox1.Text = t.Substring(0, c - 1);
            }
            else textBox1.Text = "";
        }

        private void button21_Click(object sender, EventArgs e)//清空数据
        {
            textBox1.Text = "";
            textBox2.Text = "";
            k = 0;
            q = 0;
            re = 0;
            s = "";
            r = "";
        }

        private void button13_Click(object sender, EventArgs e)//等号
        {
            switch (k)
            {
                case 1:
                    r = textBox1.Text.Substring(q+1);
                    if (r == "e")
                    {
                        b = Math.E;
                    }
                    else if (r == "π")
                    {
                        b = Math.PI;
                    }
                    else  b = Convert.ToDouble(r); 
                   
                    re = a + b;
                    break;

                case 2:
                    r = textBox1.Text.Substring(q + 1);
                    if (r == "e")
                    {
                        b = Math.E;
                    }
                    else if (r == "π")
                    {
                        b = Math.PI;
                    }
                    else b = Convert.ToDouble(r);
                    re = a - b;
                    break;

                case 3:
                    r = textBox1.Text.Substring(q+1);
                    if (r == "e")
                    {
                        b = Math.E;
                    }
                    else if (r == "π")
                    {
                        b = Math.PI;
                    }
                    else b = Convert.ToDouble(r);
                    re = a * b;
                    break;

                case 4:
                    r = textBox1.Text.Substring(q+1);
                    if (r == "e")
                    {
                        b = Math.E;
                    }
                    else if (r == "π")
                    {
                        b = Math.PI;
                    }
                    else b = Convert.ToDouble(r);
                    re = a / b;
                    break;

                case 5:
                    re = Math.E;
                    break;

                case 6:
                    re = b = Math.PI;;
                    break;

                case 7:
                    if (a == 0 || a == 1)
                    {
                        re = 1;
                    }
                    else
                    {
                        b = 1;
                        for (c = 1; c <= a; c++)
                        {
                            b = b * c;
                        }
                        re = b;
                    }
                    break;

                case 8:
                    re = Math.Pow(10, a);
                    break;

                case 9:
                    re = a * a;
                    break;

                case 10:
                    re = a * a * a;
                    break;

                case 11:
                    re = Math.Sqrt(a);
                    break;

                case 12:
                    re = 1 / a;
                    break;

                case 13:
                    re = a;
                    break;

                case 14:
                    r = textBox1.Text.Substring(q+1);
                    if (r == "e")
                    {
                        b = Math.E;
                    }
                    else if (r == "π")
                    {
                        b = Math.PI;
                    }
                    else b = Convert.ToDouble(r);
                    re = Math.Pow(b, a);
                    break;

                case 15:
                    re = Math.Cos(a);
                    break;

                case 16:
                    re = Math.Sin(a);
                    break;

                case 17:
                    re = Math.Tan(a);
                    break;
                    
                case 18:
                    re = Math.Log10(a);
                    break;
            }
            textBox2.Text = Convert.ToString(re);
        }



    }
}
