using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ARTYOMiNIKITIKUS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string FirstValueText = textBox1.Text;
            double FirstValue = Convert.ToDouble(FirstValueText);
            string SecondValueText = textBox2.Text;
            double SecondValue = Convert.ToDouble(SecondValueText);
            double result = FirstValue - SecondValue;
            label1.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FirstValueText = textBox1.Text;
            double FirstValue = Convert.ToDouble(FirstValueText);
            string SecondValueText = textBox2.Text;
            double SecondValue = Convert.ToDouble(SecondValueText);
            double result = FirstValue + SecondValue;
            label1.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string FirstValueText = textBox1.Text;
            double FirstValue = Convert.ToDouble(FirstValueText);
            string SecondValueText = textBox2.Text;
            double SecondValue = Convert.ToDouble(SecondValueText);
            double result = FirstValue * SecondValue;
            label1.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string FirstValueText = textBox1.Text;
            double FirstValue = Convert.ToDouble(FirstValueText);
            string SecondValueText = textBox2.Text;
            double SecondValue = Convert.ToDouble(SecondValueText);
            double result = FirstValue / SecondValue;
            label1.Text = result.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            string FirstValueText = textBox1.Text;
            double FirstValue = Convert.ToDouble(FirstValueText);
            string SecondValueText = textBox2.Text;
            double SecondValue = Convert.ToDouble(SecondValueText);
            double result;
            switch (((Button)sender).Name)
            {
                case "Plus":
                    result = FirstValue + SecondValue;
                    break;
                case "Minus":
                    result = FirstValue - SecondValue;
                    break;
                case "Multiplication":
                    result = FirstValue * SecondValue;
                    break;
                case "Division":
                    result = FirstValue / SecondValue;
                    break;
                default:
                    throw new Exception ("error");
            }

            label1.Text = Convert.ToString(result);
        }
    }
}
