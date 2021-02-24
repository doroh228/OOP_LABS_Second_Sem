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
    public partial class Form1 : Form
    {
        string ginere = string.Empty;
        string selectedRb = string.Empty;
        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label_Value_File.Text = $"Размер Файла: {trackBar1.Value}";
        }

        private void textBox_Id_Book_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (textBox_Id_Book.TextLength > 30)
                textBox_Id_Book.ReadOnly = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                selectedRb = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                selectedRb = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                selectedRb = radioButton3.Text;
            }
            StringBuilder outputLine = new StringBuilder();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                ginere += item +",";
            }
            outputLine.AppendLine($"Название книги: {textBox_name_book.Text}");
            outputLine.AppendLine($"ID книги: {textBox_Id_Book.Text}");
            outputLine.AppendLine($"Название издательства: {textBox_from_born.Text}");
            outputLine.AppendLine($"Страна производства: {comboBox_Countre.Text}");
            outputLine.AppendLine($"Жанр: {ginere}");
            outputLine.AppendLine($"Дата выхода книги: {dateTimePicker1.Value.Year.ToString()}");
            outputLine.AppendLine($"ФИО автора: {form2.SN}");
            outputLine.AppendLine($"Переплёт: {selectedRb}");
            textBox_info.Text = outputLine.ToString();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_name_book.Text) || string.IsNullOrEmpty(textBox_Id_Book.Text) || string.IsNullOrEmpty(textBox_from_born.Text)
                || string.IsNullOrEmpty(comboBox_Countre.Text) || checkedListBox1.CheckedItems.Count <= 0 || string.IsNullOrEmpty(selectedRb))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                Author author = new Author
                {
                    SN = form2.SN
                };
                Book book = new Book(textBox_name_book.Text, textBox_Id_Book.Text, textBox_from_born.Text,
                                     comboBox_Countre.Text, ginere, dateTimePicker1.Value.Year.ToString(),selectedRb, author);
                SerializateInfo.Serialize(book, "book.xml");
                MessageBox.Show("Сохранено!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var desInfo = SerializateInfo.Deserialize<Book>("book.xml");
                StringBuilder outputLine = new StringBuilder();
                outputLine.AppendLine($"Название книги: {desInfo.Name}");
                outputLine.AppendLine($"ID книги: {desInfo.Id}");
                outputLine.AppendLine($"ФИО автора: {desInfo.author.SN}");
                outputLine.AppendLine($"Название издательства: {desInfo.From}");
                outputLine.AppendLine($"Страна производства: {desInfo.Countre}");
                outputLine.AppendLine($"Жанр: {desInfo.Genre}");
                outputLine.AppendLine($"Дата выхода книги: {desInfo.ReleaseDate}");
                outputLine.AppendLine($"Переплёт: {desInfo.Binding}");
                textBox_info_from_file.Text = outputLine.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
