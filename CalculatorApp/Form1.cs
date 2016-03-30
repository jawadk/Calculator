using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string label_value = "";
        string num1 = "";
        string num2 = "";
        string operation = "";

        private void btn_one_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(label1.Text);
            int one = 1;
            one = Convert.ToInt32(btn_one.Text);
            label1.Text = null;
            label_value += one.ToString();
            label1.Text = label_value;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            label_value = null;
            label1.Text = "0";
            //label1.Refresh();
            //MessageBox.Show(test);
        }       

        private void btn_two_Click(object sender, EventArgs e)
        {
            int two = 2;
            two = Convert.ToInt32(btn_two.Text);
            label1.Text = null;
            label_value += two;
            label1.Text = label_value;
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            int three = 3;
            three = Convert.ToInt32(btn_three.Text);
            label1.Text = null;
            label_value += three;
            label1.Text = label_value;
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            int four = 3;
            four = Convert.ToInt32(btn_four.Text);
            label1.Text = null;
            label_value += four;
            label1.Text = label_value;
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            int five = 3;
            five = Convert.ToInt32(btn_five.Text);
            label1.Text = null;
            label_value += five;
            label1.Text = label_value;
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            int six = 6;
            six = Convert.ToInt32(btn_six.Text);
            label1.Text = null;
            label_value += six;
            label1.Text = label_value;
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            int seven = 7;
            seven = Convert.ToInt32(btn_seven.Text);
            label1.Text = null;
            label_value += seven;
            label1.Text = label_value;
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            int eight = 8;
            eight = Convert.ToInt32(btn_eight.Text);
            label1.Text = null;
            label_value += eight;
            label1.Text = label_value;
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            int nine = 9;
            nine = Convert.ToInt32(btn_nine.Text);
            label1.Text = null;
            label_value += nine;
            label1.Text = label_value;
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            int zero = 0;
            zero = Convert.ToInt32(btn_zero.Text);
            label1.Text = null;
            label_value += zero;
            label1.Text = label_value;

        }

        private void btn_subtract_Click(object sender, EventArgs e)
        {
            num1 = label_value;
            operation = "-";
            label_value = null;
            label1.Text = "0";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            num1 = label_value;
            operation = "+";
            label_value = null;
            label1.Text = "0";
        }

        private void btn_multiple_Click(object sender, EventArgs e)
        {
            num1 = label_value;
            operation = "*";
            label_value = null;
            label1.Text = "0";
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            num1 = label_value;
            operation = "/";
            label_value = null;
            label1.Text = "0";
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            num2 = label_value;
            if (num1 != "" && num2 != "" && operation == "+")
            {
                int total = Convert.ToInt32(num1) + Convert.ToInt32(num2);
                label1.Text = total.ToString();

            }
            else if (num1 != "" && num2 != "" && operation == "-") {
                int total = Convert.ToInt32(num1) - Convert.ToInt32(num2);
                label1.Text = total.ToString();
            }
            else if (num1 != "" && num2 != "" && operation == "*") {
                int total = Convert.ToInt32(num1) * Convert.ToInt32(num2);
                label1.Text = total.ToString();
            }
            else if (num1 != "" && num2 != "" && operation == "/")
            {
                int total = Convert.ToInt32(num1) / Convert.ToInt32(num2);
                label1.Text = total.ToString();
            }

        }
    }
}

