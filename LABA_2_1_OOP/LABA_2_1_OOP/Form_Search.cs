using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LABA_2_1_OOP
{
    public partial class Form_Search : Form
    {
        public Form_Search()
        {
            InitializeComponent(); 
        }

        #region Properties

        Point lastPoint;

        public List<Book> result_Search = new List<Book>(); // result_Search

        #endregion

        private void lb_Close_Form_Click(object sender, EventArgs e)
        {
            this.Hide();
        } // Hide Window

        private void lb_Close_Form_MouseEnter(object sender, EventArgs e)
        {
            lb_Close_Form.ForeColor = Color.Red;
            lb_Close_Form.BorderStyle = BorderStyle.Fixed3D;
        } // Color.red && Border.3D

        private void lb_Close_Form_MouseLeave(object sender, EventArgs e)
        {
            lb_Close_Form.ForeColor = Color.Black;
            lb_Close_Form.BorderStyle = BorderStyle.None;
        }//Color.Black && Border.None

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void txtBox_rangeFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (txtBox_rangeFrom.TextLength > 30)
                e.Handled = true;
        }

        private void txtBox_rangeTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (txtBox_rangeTo.TextLength > 30)
                e.Handled = true;
        }

        private void Form_Search_Load(object sender, EventArgs e)
        {
            panel_Publiching.Enabled = false;
            panel_dateRealize.Enabled = false;
            panel_rangePages.Enabled = false;
        }

        private void combBox_Search_by_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combBox_Search_by.Text == string.Empty)
            {
                panel_Publiching.Enabled = false;
                panel_dateRealize.Enabled = false;
                panel_rangePages.Enabled = false;
            }
            else if(combBox_Search_by.Text == "Издательству")
            {
                panel_Publiching.Enabled = true;
                panel_dateRealize.Enabled = false;
                panel_rangePages.Enabled = false;
            }
            else if (combBox_Search_by.Text == "Году издания")
            {
                panel_Publiching.Enabled = false;
                panel_dateRealize.Enabled = true;
                panel_rangePages.Enabled = false;
            }
            else if (combBox_Search_by.Text == "Диапазону страниц")
            {
                panel_Publiching.Enabled = false;
                panel_dateRealize.Enabled = false;
                panel_rangePages.Enabled = true;
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            CollectionBooks books;
            try
            {
                books = SerializateInfo.Deserialize<CollectionBooks>("books.xml");
                if (combBox_Search_by.Text == string.Empty)
                {
                    MessageBox.Show("Выберите способ поиска и введите данные");
                }
                else if (combBox_Search_by.Text == "Издательству") // Search by Publiching
                {
                    if (txtBox_Publishing.Text == string.Empty)
                    {
                        MessageBox.Show("Заполните данные");
                        txtBox_Result.Text = string.Empty;
                    }
                    else
                    {
                        StringBuilder ountline = new StringBuilder();
                        foreach (var item in books.books)
                        {
                            if(txtBox_Publishing.Text.ToLower() == item.Publishing.ToString().ToLower() ||
                                item.Publishing.ToString().ToLower().StartsWith(txtBox_Publishing.Text.ToLower()))
                            {
                                result_Search.Add(item);
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
                                txtBox_Result.Text = ountline.ToString();
                            } // == or StartsWith

                        }//checking conditions
                        if(txtBox_Result.Text == string.Empty)
                        {
                            MessageBox.Show("Не найдено");
                        }
                    }
                }
                else if (combBox_Search_by.Text == "Году издания") // Search by Relize Date
                {
                    if (dateTimePicker_realeze.Text == string.Empty)
                    {
                        MessageBox.Show("Заполните данные");
                        txtBox_Result.Text = string.Empty;
                    }
                    else
                    {
                        foreach (var item in books.books)
                        {
                            StringBuilder ountline = new StringBuilder();
                            if (dateTimePicker_realeze.Text.ToLower() == item.ReleaseDate.ToString().ToLower())
                            {
                                result_Search.Add(item);
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
                                txtBox_Result.Text = ountline.ToString();
                            }
                        }//checking conditions
                        if (txtBox_Result.Text == string.Empty)
                        {
                            MessageBox.Show("Не найдено");
                        }
                    }
                }
                else if (combBox_Search_by.Text == "Диапазону страниц") // Search by Range Pages
                {
                    if (txtBox_rangeFrom.Text == string.Empty || txtBox_rangeTo.Text == string.Empty)
                    {
                        MessageBox.Show("Заполните данные");
                        txtBox_Result.Text = string.Empty;
                    }
                    else
                    {
                        StringBuilder ountline = new StringBuilder();
                        foreach (var item in books.books)
                        {
                            if (item.CountPages >= int.Parse(txtBox_rangeFrom.Text) && item.CountPages <= int.Parse(txtBox_rangeTo.Text))
                            {
                                result_Search.Add(item);
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
                                txtBox_Result.Text = ountline.ToString();
                            }
                        }//checking conditions
                        if (txtBox_Result.Text == string.Empty)
                        {
                            MessageBox.Show("Не найдено");
                        }
                    }
                }

            }
            catch (Exception x)
            {
                MessageBox.Show($"Ошибка: {x.Message}");
            }

        }
    }
}
