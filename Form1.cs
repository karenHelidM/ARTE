﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISENO_DE_CALCULADORA
{
    public partial class Form1 : Form
    {
        int value1;
        int value2;
        double result = 0;
        string sign;
        public Form1()
        {
            InitializeComponent();
        }

        private void PnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text + "2";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text + "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text + "4";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text + "3";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text + "5";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text + "6";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text + "7";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text + "8";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text + "9";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text + "0";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "+";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "-";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "*";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            sign = "/";
            label1.Text = textBox1.Text + sign;
            textBox1.Text = "";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            value2 = Convert.ToInt32(textBox1.Text);
            label2.Text = textBox1.Text;
            if(sign=="+")
            {
                result = value1 + value2;
                textBox1.Text = Convert.ToString(result);
            }
           else if (sign == "-")
            {
                result = value1 - value2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (sign == "*")
            {
                result = value1 * value2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (sign == "/")
            {
                result = value1 / value2;
                textBox1.Text = Convert.ToString(result);
            }
        }
    }
}
