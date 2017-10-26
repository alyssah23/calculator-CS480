using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;

namespace TestProject1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
          
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            textBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            textBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            textBox1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            textBox1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            textBox1.Refresh();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            textBox1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            textBox1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            textBox1.Refresh();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            textBox1.Refresh();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            textBox1.Refresh();
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
            textBox1.Refresh();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            textBox1.Refresh();
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
            textBox1.Refresh();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
            textBox1.Refresh();
        }


        private void buttonDiv_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
            textBox1.Refresh();
        }

        private void buttonLeftP_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
            textBox1.Refresh();
        }

        private void buttonRightP_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
            textBox1.Refresh();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length -1, 1);
            textBox1.Refresh();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Refresh();
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            //Call processing methods
        }

        private void buttonExpo_Click(object sender, EventArgs e)
        {
            textBox1.Text += "^";
            textBox1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }      

    }
}
