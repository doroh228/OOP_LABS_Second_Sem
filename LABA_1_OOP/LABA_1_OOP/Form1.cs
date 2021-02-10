using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA_1_OOP
{
    public partial class Form1 : Form
    {
        int count = 0;
        bool operetor = false;
        bool canUseOperator = false;
        bool canPressNumber = true;
        int firtsValue = -1;
        int secondValue = -1;
        int intermediateValue = 0;
        
        Calculator calculator = new Calculator();

        TextBox textInBox = new TextBox();
        string result = string.Empty; 

        public Form1()
        {
            InitializeComponent();        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (canPressNumber)
            {
                textBox_main.Text = textBox_main.Text + 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (canPressNumber)
            {
                textBox_main.Text = textBox_main.Text + 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (canPressNumber)
            {
                textBox_main.Text = textBox_main.Text + 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (canPressNumber)
            {
                textBox_main.Text = textBox_main.Text + 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (canPressNumber)
            {
                textBox_main.Text = textBox_main.Text + 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (canPressNumber)
            {
                textBox_main.Text = textBox_main.Text + 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (canPressNumber)
            {
                textBox_main.Text = textBox_main.Text + 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (canPressNumber)
            {
                textBox_main.Text = textBox_main.Text + 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (canPressNumber)
            {
                textBox_main.Text = textBox_main.Text + 9;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (canPressNumber)
            {
                textBox_main.Text = textBox_main.Text + 0;
            }
        }

        private void BackSpace_Click(object sender, EventArgs e)
        {
            if (textBox_main.TextLength > 0)
            {
                for (int i = 0; i < textBox_main.TextLength-1; i++)
                {
                    textInBox.Text += textBox_main.Text[i];
                }
                textBox_main.Text = textInBox.Text;
                textInBox.Text = string.Empty;
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_main.Text = string.Empty;
            result = "0";
            firtsValue = -1;
            secondValue = -1;
            label1.Text = string.Empty;
            operetor = false;
            canPressNumber = true;
        }

        private void button_not_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(textBox_main.Text))
            {
                canUseOperator = true;
            }
            if (canUseOperator && !operetor)
            {
                label1.Text = "NOT";
                operetor = true;
                canUseOperator  = false;
                firtsValue = int.Parse(textBox_main.Text);
                textBox_main.Text = calculator.NOT(firtsValue).ToString();
            }
        }

        private void button_and_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_main.Text))
            {
                canUseOperator = true;
            }
            if (canUseOperator && !operetor)
            {
                count = 1;
                label1.Text = "AND";
                operetor = true;
                canUseOperator = false;
                firtsValue = int.Parse(textBox_main.Text);
                textBox_main.Text = string.Empty;
            }
        }

        private void button_or_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox_main.Text))
            {
                canUseOperator = true;
            }
            if (canUseOperator && !operetor)
            {
                count = 2;
                label1.Text = "OR";
                operetor = true;
                canUseOperator = false;
                firtsValue = int.Parse(textBox_main.Text);
                textBox_main.Text = string.Empty;
            }
        }

        private void button_xor_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox_main.Text))
            {
                canUseOperator = true;
            }
            if (canUseOperator && !operetor)
            {
                count = 3;
                label1.Text = "XOR";
                operetor = true;
                canUseOperator = false;
                firtsValue = int.Parse(textBox_main.Text);
                textBox_main.Text = string.Empty;
            }
        }

        private void button_binary_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_main.Text))
            {
                intermediateValue = int.Parse(textBox_main.Text);
                textBox_main.Text = Convert.ToString(intermediateValue, 2);
                intermediateValue = 0;
                operetor = true;
            }

        }

        private void button_octopus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_main.Text))
            {
                intermediateValue = int.Parse(textBox_main.Text);
                textBox_main.Text = Convert.ToString(intermediateValue, 8);
                intermediateValue = 0;
                operetor = true;
            }
        }

        private void button_decimal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_main.Text))
            {
                intermediateValue = int.Parse(textBox_main.Text);
                textBox_main.Text = Convert.ToString(intermediateValue, 10);
                intermediateValue = 0;
                operetor = true;
            }
        }

        private void button_hexadecimal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_main.Text))
            {
                intermediateValue = int.Parse(textBox_main.Text);
                textBox_main.Text = Convert.ToString(intermediateValue, 16);
                intermediateValue = 0;
                operetor = true;
            }
        }

        private void button_pari_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_main.Text) && operetor)
            {
                secondValue = int.Parse(textBox_main.Text);
                canPressNumber = false;
            }
            if(firtsValue != -1 && secondValue != -1)
            {
                switch (count)
                {
                    case 1: 
                        textBox_main.Text = calculator.AND(firtsValue, secondValue).ToString();
                        break;
                    case 2:
                        textBox_main.Text = calculator.OR(firtsValue, secondValue).ToString();
                        break;
                    case 3:
                        textBox_main.Text = calculator.XOR(firtsValue, secondValue).ToString();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
