using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator_16 : Form
    {
        long a, b;
        string count;
        bool clickOperation = false;

        public Calculator_16()
        {
            InitializeComponent();
        }

        private void ClickNumber(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += ((Button)sender).Text;
        }

        private void ClickSimpleOperation(object sender, EventArgs e)
        {
            if (!clickOperation)
            {
                a = Convert.ToInt64(textBox1.Text, 16);
                textBox1.Clear();
                count = ((Button)sender).Text;
                label2.Text = Convert.ToString(a, 16) + ((Button)sender).Text;
                clickOperation = true;
                return;
            }
            MessageBox.Show("Дублювання знаків оперіцій");
        }
        private void ClickPlusMinus(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                long c = Convert.ToInt64(textBox1.Text, 16);
                textBox1.Text = Convert.ToString(c * (-1), 16);
            }
        }
        private void ClickInverseProportionality(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(textBox1.Text, 2);
            if (c != 0)
            {
                textBox1.Text = Convert.ToString(1 / c, 2);
            }
            else
            {
                MessageBox.Show("Ділення на нуль");
            }
        }
        private void ClickEquals(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                Calculate();
                clickOperation = false;
                return;
            }
            MessageBox.Show("Не заданий другий операнд");
        }

        private void ClickBeginning(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label2.Text = "0";
        }
        private void ClickErase(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text += text[i];
            }
        }

        private void Calculate()
        {
            switch (count)
            {
                case "+":
                    b = a + Convert.ToInt32(textBox1.Text, 16);
                    textBox1.Text = Convert.ToString(b, 16);
                    break;
                case "-":
                    b = a - Convert.ToInt32(textBox1.Text, 16);
                    textBox1.Text = Convert.ToString(b, 16);
                    break;
                case "*":
                    b = a * Convert.ToInt32(textBox1.Text, 16);
                    textBox1.Text = Convert.ToString(b, 16);
                    break;
                case "/":
                    if (Convert.ToInt32(textBox1.Text, 16) != 0)
                    {
                        b = a / Convert.ToInt32(textBox1.Text, 16);
                        textBox1.Text = Convert.ToString(b, 16);
                    }
                    else
                    {
                        MessageBox.Show("Ділення на нуль");
                        return;
                    }
                    break;

                default:
                    break;
            }
            label2.Text = "0";
        }
    }
}