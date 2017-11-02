using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
        //When 0 is clicked, the text box adds a 0 to the end.
        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            textBox1.Refresh();
        }

        //When 1 is clicked, the text box adds a 1 to the end.
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            textBox1.Refresh();
        }
        //When 2 is clicked, the text box adds a 2 to the end.
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            textBox1.Refresh();
        }
        //When 3 is clicked, the text box adds a 3 to the end.
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            textBox1.Refresh();
        }
        //When 4 is clicked, the text box adds a 4 to the end.
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            textBox1.Refresh();
        }
        //When 5 is clicked, the text box adds a 5 to the end.
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            textBox1.Refresh();
        }
        //When 6 is clicked, the text box adds a 6 to the end.
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            textBox1.Refresh();
        }
        //When 7 is clicked, the text box adds a 7 to the end.
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            textBox1.Refresh();
        }
        //When 8 is clicked, the text box adds a 8 to the end.
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            textBox1.Refresh();
        }
        //When 9 is clicked, the text box adds a 9 to the end.
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            textBox1.Refresh();
        }
        //When + is clicked, the text box adds a + to the end.
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            textBox1.Refresh();
        }
        //When - is clicked, the text box adds a - to the end.
        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
            textBox1.Refresh();
        }
        //When * is clicked, the text box adds a * to the end.
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
            textBox1.Refresh();
        }

        //When / is clicked, the text box adds a / to the end.
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
            textBox1.Refresh();
        }
        //When ( is clicked, the text box adds a ( to the end.
        private void buttonLeftP_Click(object sender, EventArgs e)
        {
             textBox1.Text += "(";
            textBox1.Refresh();
        }
        //When ) is clicked, the text box adds a ) to the end.
        private void buttonRightP_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
            textBox1.Refresh();
        }
        //When CE is clicked, the text box deletes the last character added
        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                textBox1.Refresh();
            }
        }
        //When C is clicked, the text box is cleared completely
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Refresh();
        }
        //When = is clicked, the text box adds a = to the end.
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            textBox1.Text += "=";
            textBox1.Refresh();
        }
        //When ^ is clicked, the text box adds a ^ to the end.
        private void buttonExpo_Click(object sender, EventArgs e)
        {
            textBox1.Text += "^";
            textBox1.Refresh();
        }
        
        //Whenever a text box is changed it runs this code.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Checks if a character other than a number or "(" "+" "-" "=" "*" "/" "^" ")" is entered
            //If a non-allowed character is entered it is deleted from the textbox
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9^+^*^^^/^(^)^=^-]"))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                if (textBox1.Text.Length != 0)
                {
                        //This makes sure the cursor of the text box starts on the right side
                        textBox1.SelectionStart = textBox1.Text.Length;
                        textBox1.SelectionLength = 0;
                }
           }
           //If the textbox contains a equals sign, then it does the calculations by calling calculate()
           if (textBox1.Text.Contains('='))
           {
                calculate();    
           }
       
        }
        //A method to correctly evaluate the contents of the textbox
        public void calculate()
        {
            //Used to catch any incorrect inputs
            try
            {
                //Removes the equals sign before calculating
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);

                //initializes a datatable and length of the string in the textbox
                DataTable d = new DataTable();
                int length = textBox1.Text.Length;

                //checks if the textbox contains a exponent character
                if (textBox1.Text.Contains('^'))
                {
                    //creates a List for all the found indexes of ^
                    var foundIndexes = new List<int>();

                    //creates a string to hold the textboxContents
                    string textboxContents = textBox1.Text;

                    //goes through the text box, finds every index of ^ and adds it to the list
                    for (int b = textBox1.Text.IndexOf('^'); b > -1; b = textBox1.Text.IndexOf('^', b + 1))
                    {
                        foundIndexes.Add(b);
                    }

                    //loop that runs for every ^ found
                    for(int c = 0; c < foundIndexes.Count; c++)
                    {
                        //assigns the index in the list to i
                        int i = foundIndexes.ElementAt(c);

                        //assigns the value before i to the string s
                        String s = textBox1.Text.Substring((i - 1), 1);

                        //runs if the string is a ")"
                        if (s == ")")
                        {
                            //assigns string before to nothing and j to the index before i
                            string before = "";
                            int j = i - 1;

                            //loops until we find a ( before the ) next to the ^.
                            while (before != "(")
                            {
                                j--;
                                before = textBox1.Text.Substring(j,1);
                            }

                            //evaluates what is in the parathesis before the ^
                            var v = d.Compute(textBox1.Text.Substring(j, i), "");

                            //evaluates the exponent
                            double expoEval = Math.Pow(Double.Parse(v.ToString()), Double.Parse(textBox1.Text.Substring(i + 1, 1)));
                            
                            //finds what we just completely evaluated and replaces it with the evaluation
                            string replace = textBox1.Text.Substring(j, (i+2) - j);
                            textboxContents = textboxContents.Replace(replace, expoEval.ToString());

                        }
                        //checks if the value next to i is a int
                        if (int.TryParse(s, out var n))
                        {
                            //grab both values on either side of the ^
                            double x = Double.Parse(textBox1.Text.Substring(i + 1, 1));
                            double y = Double.Parse(textBox1.Text.Substring(i - 1, 1));
                            
                            //calculate the exponent
                            double expoEval = Math.Pow(y, x);

                            //finds what we just completely evaluated and replaces it with the evaluation
                            string replace = textBox1.Text.Substring(i - 1, 3);
                            textboxContents = textboxContents.Replace(replace, expoEval.ToString());
                        }
                        
                    }
                    //computes the rest of the textbox with the evaluated exponants included and outputs to the textbox
                    var w = d.Compute(textboxContents, "");
                    textBox1.Text = w.ToString();
                }
                //if no ^ exists, calculate the textbox and output it to the textbox
                else
                {
                    var v = d.Compute((textBox1.Text), "");
                    textBox1.Text = v.ToString();
                }
            }
            //Catches all incorrect inputs and outputs a error message
            catch (EvaluateException)
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
            }
            catch(OverflowException)
            {
                MessageBox.Show("This number is too large for this calculator to calculate.");
            }
        }
    }
}

