using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string t1 = textBox1.Text;
                double num1 = Convert.ToDouble(t1);

                string t2 = textBox2.Text;
                double num2 = Convert.ToDouble(t2);
                string t3 = textBox3.Text;
                if (t3 == "+")
                {
                    this.Add(num1, num2);
                }
                if (t3 == "-")
                {
                    this.Sub(num1, num2);
                }
                if (t3 == "*")
                {
                    this.Mul(num1, num2);
                }
                if (t3 == "/")
                {
                    this.Div(num1, num2);
                }
                if (t3 == "%")
                {
                    this.Mod(num1, num2);
                }
                /*
                else
                {
                    string message = "invalid symbol";
                    string title = "error";
                    MessageBox.Show(message, title);
                }
                */
            }
            catch (DivideByZeroException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("invalid input");
                //throw;
            }
            
            
        }
        private void Add(double i, double j)
        {
            double output =  i + j;
            Conversion(output);
        }
        private void Sub(double i, double j)
        {
            double output = i - j;
            Conversion(output);
        }
        private void Mul(double i, double j)
        {
            double output = i * j;
            Conversion(output);
        }
        private void Div(double i, double j)
        {
            double output = i / j;
            Conversion(output);
        }
        private void Mod(double i, double j)
        {
            double output = i % j;
            Conversion(output);
        }

        private void Conversion(double output)
        {
            textBox4.Text = Convert.ToString(output);
           
        }
    }
}
