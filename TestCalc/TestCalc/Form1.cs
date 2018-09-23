using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int oper;
        public string value;
        public void sum(string str)
        {
            oper = 1; // Операция сложения
            value = str;
            return;
        }
        public void subtraction(string str)
        {
            oper = 1; // Операция вычитания
            value = str;
            return;
        }
        public void multiplication(string str)
        {
            oper = 1; // Операция умножения
            value = str;
            return;
        }
        public void division(string str)
        {
            oper = 1; // Операция деления
            value = str;
            return;
        }
        public string equal(string str)
        {
            string totalvalue = "";
            if (oper == 1)
                totalvalue = Convert.ToString(Convert.ToInt32(str) + Convert.ToInt32(value));
            if (oper == 2)
                totalvalue = Convert.ToString(Convert.ToInt32(str) - Convert.ToInt32(value));
            if (oper == 3)
                totalvalue = Convert.ToString(Convert.ToInt32(str) * Convert.ToInt32(value));
            if (oper == 4)
                totalvalue = Convert.ToString(Convert.ToInt32(str) / Convert.ToInt32(value));
            return totalvalue;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sum(textBox1.Text);
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            subtraction(textBox1.Text);
            textBox1.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            multiplication(textBox1.Text);
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            division(textBox1.Text);
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = equal(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
