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

namespace LABA_2_1_OOP
{
    public partial class Form1 : Form
    {
        #region Arguments

        Form2 form2 = new Form2();

        private ContenerAuthors collectionAuthors = new ContenerAuthors();

        private CollectionBooks collectionBooks = new CollectionBooks();

        private Book book;

        private CollectionBooks infoFromFile = SerializateInfo.Deserialize<CollectionBooks>("books.xml");
        #endregion

        public Form1()
        {
            Program.f1 = this;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbScrollBar.Text = trBar_size_file.Value.ToString() + "Кб";
        }
        private void txtBox_Count_pages_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (txtBox_Count_pages.TextLength > 30)
                e.Handled = true;
        }

        private void txtBox_UDK_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 58)
            {
                e.Handled = true;
            }
            if (txtBox_Count_pages.TextLength > 30)
                e.Handled = true;
        }

        private void button_add_Author_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void button_outInfo_Form_Click(object sender, EventArgs e)
        {
            StringBuilder ountline = new StringBuilder();
            ountline.AppendLine($"Название: {txtBox_Name_book.Text}");
            ountline.AppendLine($"Формат: {comBox_format_file.Text}");
            ountline.AppendLine($"Размер файла: {trBar_size_file.Value.ToString()}Кб");
            ountline.AppendLine($"УДК: {txtBox_UDK.Text}");
            ountline.AppendLine($"Количество страниц: {txtBox_Count_pages.Text}");
            ountline.AppendLine($"Издательство: {comBox_publishing.Text}");
            ountline.AppendLine($"Дата загрузки: {dateTimePicker1.Text}");
            ountline.AppendLine($"Список авторов: {txtBox_Name_book.Text}");
            txtBox_from_Form.Text = ountline.ToString();
        }

        public void AddAuthor(Author author)
        {
            this.collectionAuthors.authors.Add(author);
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBox_Name_book.Text) && !string.IsNullOrEmpty(comBox_format_file.Text) &&
                !string.IsNullOrEmpty(txtBox_UDK.Text) && !string.IsNullOrEmpty(txtBox_Count_pages.Text)
                && !string.IsNullOrEmpty(comBox_publishing.Text) && collectionAuthors.authors.Count >0 && trBar_size_file.Value>0)
            {
                book = new Book(txtBox_Name_book.Text, txtBox_UDK.Text, comBox_publishing.Text,
                                trBar_size_file.Value, int.Parse(txtBox_Count_pages.Text),
                                comBox_format_file.Text, dateTimePicker1.Text, collectionAuthors);
                collectionBooks.books.Add(book);
                SerializateInfo.Serialize<CollectionBooks>(collectionBooks, "books.xml");
                MessageBox.Show("Сохранено!");
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void button_outInfo_File_Click(object sender, EventArgs e)
        {
            var fileBooks = SerializateInfo.Deserialize<CollectionBooks>("books.xml");
            StringBuilder ountline = new StringBuilder();
            foreach (var item in fileBooks.books)
            {
                ountline.AppendLine($"Название: {item.Name}");
                ountline.AppendLine($"Формат: {item.Format}");
                ountline.AppendLine($"Размер файла: {item.SizeFile}Кб");
                ountline.AppendLine($"УДК: {item.UDK}");
                ountline.AppendLine($"Количество страниц: {item.CountPages}");
                ountline.AppendLine($"Издательство: {item.Publishing}");
                ountline.AppendLine($"Дата загрузки: {item.ReleaseDate}");
                StringBuilder authors = new StringBuilder();
                foreach (var author in item.Authors.authors)
                {
                    authors.Append($"{author.SN}({author.ID}); ");
                }
                ountline.AppendLine($"Список авторов: {authors}");
                ountline.AppendLine($"-----------------------------------------------------------------------------------------");
            }
            txtBox_fromFile.Text = ountline.ToString();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            bool needRefrash = true;
            StringBuilder arrayNewFormats = new StringBuilder();
            foreach (var item in infoFromFile.books)
            {
                foreach (var formaters in comBox_format_file.Items)
                {
                    if (item.Format.ToString() == formaters.ToString())
                    {
                        needRefrash = false;
                    }
                }
                if (needRefrash)
                {
                    comBox_format_file.Items.Add(item.Format.ToString());
                }
                needRefrash = true;
            } //Проверка на обновления формата(горжусь этим алгоритмом, ахаха)

        }
    }
}
