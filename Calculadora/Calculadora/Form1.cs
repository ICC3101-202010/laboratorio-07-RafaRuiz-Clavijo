using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double ans = 0;
        double n1 = 0;
        double n2 = 0;
        char operador = '+';

        public Form1()
        {
            InitializeComponent();
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (label_calculando.Text == "0")
            {
                label_calculando.Text = "7";
            }
            else
            {
                label_calculando.Text += "7";
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (label_calculando.Text == "0")
            {
                label_calculando.Text = "8";
            }
            else
            {
                label_calculando.Text += "8";
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (label_calculando.Text == "0")
            {
                label_calculando.Text = "9";
            }
            else
            {
                label_calculando.Text += "9";
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (label_calculando.Text == "0")
            {
                label_calculando.Text = "4";
            }
            else
            {
                label_calculando.Text += "4";
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (label_calculando.Text == "0")
            {
                label_calculando.Text = "5";
            }
            else
            {
                label_calculando.Text += "5";
            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (label_calculando.Text == "0")
            {
                label_calculando.Text = "6";
            }
            else
            {
                label_calculando.Text += "6";
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (label_calculando.Text == "0")
            {
                label_calculando.Text = "1";
            }
            else
            {
                label_calculando.Text += "1";
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (label_calculando.Text == "0")
            {
                label_calculando.Text = "2";
            }
            else
            {
                label_calculando.Text += "2";
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (label_calculando.Text == "0")
            {
                label_calculando.Text = "3";
            }
            else
            {
                label_calculando.Text += "3";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (label_calculando.Text == "0")
            {
                label_calculando.Text = "0";
            }
            else
            {
                label_calculando.Text += "0";
            }
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            label_calculando.Text += ".";
        }

        private void button_Ans_Click(object sender, EventArgs e)
        {
            if (label_calculando.Text == "0")
            {
                label_calculando.Text = Convert.ToString(ans);
            }
            else
            {
                label_calculando.Text += ans;
            }

        }

        private void button_del_Click(object sender, EventArgs e)
        {
            try
            {
                label_calculando.Text = label_calculando.Text.Remove(label_calculando.Text.Length - 1);
            }
            catch
            {

            }
            
        }

        private void button_AC_Click(object sender, EventArgs e)
        {
            label_calculando.Text = "";
            n2 = 0;
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            try
            {
                n2 = double.Parse(label_calculando.Text);
                if (operar() == 1)
                {
                    n2 = 0;
                    operador = '+';
                    if (label_resultado.Text == "0")
                    {
                        label_resultado.Text = Convert.ToString(label_calculando.Text) + operador;
                    }
                    else
                    {
                        label_resultado.Text += Convert.ToString(label_calculando.Text) + operador;
                    }
                    label_calculando.Text = "0";
                }
                else
                {
                    error(2);
                }
                n2 = 0;

            }
            catch
            {
                error(1);
            }
        }

        public void error(int caso)
        {
            n1 = 0;
            n2 = 0;
            operador = '+';
            if (caso == 1)
            {
                label_calculando.Text = "SYNTAX ERROR";
            }
            if (caso == 2)
            {
                label_calculando.Text = "MATH ERROR";
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            try
            {
                n2 = double.Parse(label_calculando.Text);
                if (operar() == 1)
                {
                    n2 = 0;
                    operador = '-';
                    if (label_resultado.Text == "0")
                    {
                        label_resultado.Text = Convert.ToString(label_calculando.Text) + operador;
                    }
                    else
                    {
                        label_resultado.Text += Convert.ToString(label_calculando.Text) + operador;
                    }
                    label_calculando.Text = "0";
                }
                else
                {
                    error(2);
                }
                n2 = 0;

            }
            catch
            {
                error(1);
            }
        }

        private void button_X_Click(object sender, EventArgs e)
        {
            try
            {
                n2 = double.Parse(label_calculando.Text);
                if (operar() == 1)
                {
                    n2 = 0;
                    operador = 'x';
                    if (label_resultado.Text == "0")
                    {
                        label_resultado.Text = Convert.ToString(label_calculando.Text) + operador;
                    }
                    else
                    {
                        label_resultado.Text += Convert.ToString(label_calculando.Text) + operador;
                    }
                    label_calculando.Text = "0";
                }
                else
                {
                    error(2);
                }
                n2 = 0;

            }
            catch
            {
                error(1);
            }
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            try
            {
                n2 = double.Parse(label_calculando.Text);
                if (operar() == 1)
                {
                    n2 = 0;
                    operador = '/';
                    if (label_resultado.Text == "0")
                    {
                        label_resultado.Text = Convert.ToString(label_calculando.Text) + operador;
                    }
                    else
                    {
                        label_resultado.Text += Convert.ToString(label_calculando.Text) + operador;
                    }
                    label_calculando.Text = "0";
                }
                else
                {
                    error(2);
                }
                n2 = 0;
            }
            catch
            {
                error(1);
            }
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            try
            {
                n2 = double.Parse(label_calculando.Text);
                if (operar() == 1)
                {
                    ans = n1;
                    label_calculando.Text = Convert.ToString(ans);
                    label_resultado.Text = "0";
                    n1 = 0;
                    n2 = 0;
                    operador = '+';
                }
                else
                {
                    error(2);
                }
            }
            catch
            {
                error(1);
            }
        }

        public int operar()
        {
            int verificador = 1;
            if (operador == '+')
            {
                n1 += n2;
            }
            if (operador == '-')
            {
                n1 -= n2;
            }
            if (operador == 'x')
            {
                n1 *= n2;
            }
            if (operador == '/')
            {
                if (n2 != 0)
                {
                    n1 /= n2;
                }
                else
                {
                    n1 = 0;
                    n2 = 0;
                    verificador = 0;
                }
            }
            return verificador;
        }
    }
}
