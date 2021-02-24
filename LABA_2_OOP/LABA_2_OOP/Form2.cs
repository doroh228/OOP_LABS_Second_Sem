using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA_2_OOP
{
    public partial class Form2 : Form
    {
        public string SN { get; private set; } = string.Empty;
        public string wasBornIn { get; private set; } = string.Empty;
        public string authorID { get; private set; } = string.Empty;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
            if (textBox_SN.TextLength > 30)
                textBox_SN.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_SN.Text) || string.IsNullOrEmpty(comboBox_author_from.Text) || string.IsNullOrEmpty(textBox_Id_author.Text))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                SN = textBox_SN.Text;
                wasBornIn = comboBox_author_from.Text;
                authorID = textBox_Id_author.Text;

                MessageBox.Show("Сохранено");
                this.Hide();
                textBox_SN.Text = string.Empty;
                comboBox_author_from.Text =string.Empty;
                textBox_Id_author.Text = string.Empty;
            }
        }

        private void textBox_Id_author_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (textBox_SN.TextLength > 30)
                textBox_SN.ReadOnly = true;
        }

        private void textBox_SN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
