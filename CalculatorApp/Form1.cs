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

        private void btn_one_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(label1.Text);
            int one = 1;
            one = Convert.ToInt32(btn_one.Text);
            label1.Text = null;
            label_value += one.ToString();
            label1.Text = label_value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int two = 2;
            two = Convert.ToInt32(button2.Text);
            label1.Text = null;
            label_value += two;
            label1.Text = label_value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int three = 3;
            three = Convert.ToInt32(button3.Text);
            label1.Text = null;
            label1.Text += three;
        }        
    }
}
