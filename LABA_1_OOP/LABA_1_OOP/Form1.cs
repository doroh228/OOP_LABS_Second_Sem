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
        bool optor = false;

        Calculator calculator = new Calculator();

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!optor && !string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text + " AND ";
                optor = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!optor && !string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text + " OR ";
                optor = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!optor && !string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text + " NOT ";
                optor = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!optor && !string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text + " XOR ";
                optor = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            optor = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
    }
}
