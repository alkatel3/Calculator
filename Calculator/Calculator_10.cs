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
    public partial class Calculator_10 : Form
    {
        float a, b;
        string count;
        bool clickOperation = false;
        public Calculator_10()
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
        private void ClickComa(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text += '0';
            }
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == ',')
                {
                    MessageBox.Show("В числі можлива тільки одна кома");
                    return;
                }
            }
            textBox1.Text += ",";
        }

        private void ClickSimpleOperation(object sender, EventArgs e)
        {
            if (!clickOperation)
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = ((Button)sender).Text;
                label2.Text = a.ToString() + ((Button)sender).Text;
                clickOperation = true;
                return;
            }
            MessageBox.Show("Дублювання знаків оперіцій");
        }
        private void ClickPlusMinus(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                float c = Convert.ToSingle(textBox1.Text);
                textBox1.Text = Convert.ToString(c * (-1));
            }
        }
        private void ClickInverseProportionality(object sender, EventArgs e)
        {
            float c = Convert.ToSingle(textBox1.Text);
            if (c != 0)
            {
                textBox1.Text = Convert.ToString(1 / c);
            }
            else
            {
                MessageBox.Show("Ділення на нуль");
            }
        }
        private void ClickEquals(object sender, EventArgs e)
        {
            if (textBox1.Text.Length> 0)
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
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case "-":
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case "*":
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case "/":
                    if (float.Parse(textBox1.Text) != 0)
                    {
                        b = a / float.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
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
