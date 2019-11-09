using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4Cshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            double Celsius;
            double Fahrenheit;
            double celsiusResult;
            double fahrenheitResult;
            if (radioButton1.Checked&& temp != null)
            {
                try
                {
                    Celsius = double.Parse(temp);
                    fahrenheitResult = (Celsius * 1.8) + 32;
                    //txtresult.Text = fahrenheitResult.ToString();
                    txtresult.Text = String.Format("{0:0.00} degrees Celsius converts to {1:0.00} degrees Fahrenheit.", Celsius, fahrenheitResult);
                }
                catch
                {
                    txtresult.Text = "Celsius ERROR: Please enter a numeric temperature to convert.";
                }

            }
            else if (radioButton2.Checked && temp != null)
            {
               
                try
                {
                    Fahrenheit = double.Parse(temp);
                    celsiusResult = (Fahrenheit - 32) / 1.8;
                    //txtresult.Text = celsiusResult.ToString();
                    txtresult.Text = String.Format("{0:0.00} degrees Fahrenheit converts to {1:0.00} degrees Celsius.", Fahrenheit, celsiusResult);
                }
                catch
                {
                    txtresult.Text = "Fahrenheit ERROR: Please enter a numeric temperature to convert.";
                }
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtresult_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtresult_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
