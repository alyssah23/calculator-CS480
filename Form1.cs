using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


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
            textBox1.Text += "1";
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
             textBox1.Text += "(";
            textBox1.Refresh();
        }

        private void buttonRightP_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
            textBox1.Refresh();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                textBox1.Refresh();
            }
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Refresh();
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            textBox1.Text += "=";
            textBox1.Refresh();
        }

        private void buttonExpo_Click(object sender, EventArgs e)
        {
            textBox1.Text += "^";
            textBox1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9^+^*^^^/^(^)^=^-]"))
           {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                if (textBox1.Text.Length != 0)
                {
                        textBox1.SelectionStart = textBox1.Text.Length;
                        textBox1.SelectionLength = 0;
                }
           }
           if (textBox1.Text.Contains('='))
           {
                calculate();    
           }
       
        }
        public void calculate()
        {
            try
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                DataTable d = new DataTable();
                int length = textBox1.Text.Length;
                if (textBox1.Text.Contains('^'))
                {
                    var foundIndexes = new List<int>();
                    string textboxContents = textBox1.Text;
                    for (int b = textBox1.Text.IndexOf('^'); b > -1; b = textBox1.Text.IndexOf('^', b + 1))
                    {
                        foundIndexes.Add(b);
                    }
                    for(int c = 0; c < foundIndexes.Count; c++)
                    {
                        int i = foundIndexes.ElementAt(c);
                        String s = textBox1.Text.Substring((i - 1), 1);
                        if (s == ")")
                        {
                            string before = "";
                            int j = i - 1;
                            while (before != "(")
                            {
                                j--;
                                before = textBox1.Text.Substring(j,1);
                            }
                            var v = d.Compute(textBox1.Text.Substring(j, i), "");
                            double expoEval = Math.Pow(Double.Parse(v.ToString()), Double.Parse(textBox1.Text.Substring(i + 1, 1)));
                            string replace = textBox1.Text.Substring(j, (i+2) - j);
                            textboxContents = textboxContents.Replace(replace, expoEval.ToString());

                        }
                        if (int.TryParse(s, out var n))
                        {
                            double x = Double.Parse(textBox1.Text.Substring(i + 1, 1));
                            double y = Double.Parse(textBox1.Text.Substring(i - 1, 1));
                            double expoEval = Math.Pow(y, x);
                            string replace = textBox1.Text.Substring(i - 1, 3);
                            textboxContents = textboxContents.Replace(replace, expoEval.ToString());
                        }
                        
                    }
                    var w = d.Compute(textboxContents, "");
                    textBox1.Text = w.ToString();
                }
                else
                {
                    var v = d.Compute((textBox1.Text), "");
                    textBox1.Text = v.ToString();
                }
            }
            /*catch (EvaluateException)
            {
                MessageBox.Show("This is not a vaid input, please try again.");

            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("This is not a vaid input, please try again.");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("This is not a vaid input, please try again.");
            }*/
            catch (ArrayTypeMismatchException)
            {

            }
        }
    }
}

