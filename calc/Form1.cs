using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string c;
        double a,z;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBox1.Text=="0")
            {
                textBox1.Clear();
            }
         
            textBox1.Text = textBox1.Text + btn.Text;

            if (textBox1.Text == "," && btn.Text == ",")
            {
                textBox1.Text = "0,";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBox1.Text != "" && label1.Text != "")
            {
                button12.PerformClick();
            }
            if (double.TryParse(label1.Text, out a))
            {
                c = btn.Text;
            }
            if (textBox1.Text == "0" || textBox1.Text == "" || double.TryParse(textBox1.Text, out a) == false)
            {
                MessageBox.Show("enter the number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                a = double.Parse(textBox1.Text);               
                c = btn.Text;
                label1.Text = textBox1.Text + " " + c;
                textBox1.Clear();  
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (c)
            {
                case "+":
                    if (textBox1.Text!="")
                    {
                        z = double.Parse(textBox1.Text);
                       textBox1.Text = (a + z).ToString();
                       label1.Text = "";
                    }
                    else
                    {
                        textBox1.Text = a.ToString();
                        label1.Text = "";
                    }
                    break;  

                  
                case "-":
                    if (textBox1.Text!="")
                    {
                        z = double.Parse(textBox1.Text);
                       textBox1.Text = (a - z).ToString();
                       label1.Text = "";
                    }
                    else
                    {
                        textBox1.Text = a.ToString();
                        label1.Text = "";
                    }
                    break;  
                case "*":
                    if (textBox1.Text!="")
                    {
                        z = double.Parse(textBox1.Text);
                       textBox1.Text = (a * z).ToString();
                       label1.Text = "";
                    }
                    else
                    {
                        textBox1.Text = a.ToString();
                        label1.Text = "";
                    }
                    break;  
                case "/":
                    if (textBox1.Text!="")
                    {
                        z = double.Parse(textBox1.Text);
                       textBox1.Text = (a / z).ToString();
                       label1.Text = "";
                    }
                    else
                    {
                        textBox1.Text = a.ToString();
                        label1.Text = "";
                    }
                    break;  
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
            label1.Text = "";
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            switch (e.KeyChar)
            {
                case (char)Keys.Enter:
                    button12.PerformClick();
                    break;
                
                case '+':
                    e.Handled = true;
                    button13.PerformClick();
                    break;
                case '*':
                    e.Handled = true;
                    button14.PerformClick();
                    break;
                case '-':
                    e.Handled = true;
                    button15.PerformClick();
                    break;
                case '/':
                    e.Handled = true;
                    button16.PerformClick();
                    break;
                case (char)Keys.Back:
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    MessageBox.Show("numbers only", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}