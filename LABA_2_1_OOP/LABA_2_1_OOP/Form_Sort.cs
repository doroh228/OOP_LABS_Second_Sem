using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LABA_2_1_OOP
{
    public partial class Form_Sort : Form
    {
        public Form_Sort()
        {
            InitializeComponent();
        }

        #region Properties

        public List<Book> result_Sort = new List<Book>(); // result_Search

        #endregion

        private void lb_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lb_Close_MouseEnter(object sender, EventArgs e)
        {
            lb_Close.ForeColor = Color.Red;
            lb_Close.BorderStyle = BorderStyle.Fixed3D;
        }

        private void lb_Close_MouseLeave(object sender, EventArgs e)
        {
            lb_Close.ForeColor = Color.Black;
            lb_Close.BorderStyle = BorderStyle.None;
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if(combBox_Sort_by.Text == string.Empty)
            {
                MessageBox.Show("Выбирете сбособ сортировки");
            }
            else if (combBox_Sort_by.Text == "Названию")
            {
                try
                {
                    result_Sort = new List<Book>();
                    StringBuilder ountline = new StringBuilder();
                    var infoFromFile = SerializateInfo.Deserialize<CollectionBooks>("books.xml");
                    var result_sort = infoFromFile.books.OrderBy(i=>i.Name);
                    foreach (var item in result_sort)
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
                        ountline.AppendLine($"----------------------------------------------------------------");
                        result_Sort.Add(item);
                    }
                    txtBox_Result.Text = ountline.ToString();
                }
                catch(Exception x)
                {
                    MessageBox.Show($"Ошибка: {x.Message}");
                }
            }
            else if (combBox_Sort_by.Text == "Дате загрузки")
            {
                try
                {
                    result_Sort = new List<Book>();
                    StringBuilder ountline = new StringBuilder();
                    var infoFromFile = SerializateInfo.Deserialize<CollectionBooks>("books.xml");
                    var result_sort = infoFromFile.books.OrderBy(i => i.ReleaseDate.Substring(i.ReleaseDate.Length - 5));
                    foreach (var item in result_sort)
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
                        ountline.AppendLine($"----------------------------------------------------------------");
                        result_Sort.Add(item);
                    }
                    txtBox_Result.Text = ountline.ToString();
                }
                catch (Exception x)
                {
                    MessageBox.Show($"Ошибка: {x.Message}");
                }
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
