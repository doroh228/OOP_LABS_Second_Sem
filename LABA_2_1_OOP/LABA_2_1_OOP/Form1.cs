using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LABA_2_1_OOP
{
    public partial class Form1 : Form
    {
        #region Properties

        Form2 form2 = new Form2();

        Form_Search form_search = new Form_Search();

        Form_Sort form_sort = new Form_Sort();

        private ContenerAuthors collectionAuthors = new ContenerAuthors();

        private CollectionBooks collectionBooks = new CollectionBooks();

        private Book book;

        private CollectionBooks infoFromFile; // создаём экземпляр в TryDesserializ

        bool succesDesserializ = false;

        bool exepDesserializ = false;

        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        ToolStripLabel countLabel;
        Timer timer;

        #endregion

        public Form1()
        {
            Program.f1 = this;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            #region statusStrip

            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Текущие дата и время:";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();
            countLabel = new ToolStripLabel();

            statusStrip1.Items.Add(countLabel);
            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);

            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();

            #endregion
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            countLabel.Text = "Количетсов обьектов в файле = " + SerializateInfo.Deserialize<CollectionBooks>("books.xml").books.Count.ToString();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
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
        }//Regular KeyPress

        private void txtBox_UDK_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 58)
            {
                e.Handled = true;
            }
            if (txtBox_Count_pages.TextLength > 30)
                e.Handled = true;
        } //Regular KeyPress

        private void button_add_Author_Click(object sender, EventArgs e)
        {
            form2.Show();
            toolStripStatusLabel_Last_do.Text = "Последние действие: Добавление автора";
        } // show author_Form

        private void button_outInfo_Form_Click(object sender, EventArgs e)  
        {
            IFactory factory;
            string properti = string.Empty;
            if (DateTime.TryParse(dateTimePicker1.Text, out DateTime result))
            {
                
                if (result < DateTime.Parse("12-12-2010"))
                {
                    factory = new OldFactory();
                    properti = factory.setProperty().Property;
                }
                else
                {
                    factory = new NewFactory();
                    properti = factory.setProperty().Property;
                }
            }
            StringBuilder ountline = new StringBuilder();
            ountline.AppendLine($"Название: {txtBox_Name_book.Text}");
            ountline.AppendLine($"Формат: {comBox_format_file.Text}");
            ountline.AppendLine($"Размер файла: {trBar_size_file.Value.ToString()}Кб");
            ountline.AppendLine($"УДК: {txtBox_UDK.Text}");
            ountline.AppendLine($"Количество страниц: {txtBox_Count_pages.Text}");
            ountline.AppendLine($"Издательство: {comBox_publishing.Text}");
            ountline.AppendLine($"Дата загрузки: {dateTimePicker1.Text}");
            ountline.AppendLine($"Новая/Старая: {properti}");
            StringBuilder authors = new StringBuilder();
            foreach (var author in collectionAuthors.authors)
            {
                authors.Append($"{author.SN}({author.ID}); ");
            }
            ountline.AppendLine($"Список авторов: {authors}");
            txtBox_from_Form.Text = ountline.ToString();
            toolStripStatusLabel_Last_do.Text = "Последние действие: Вывод с формы";
        }//out info from form

        public void AddAuthor(Author author) 
        {
            this.collectionAuthors.authors.Add(author);
        }// Function - add author in collection

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBox_Name_book.Text) && !string.IsNullOrEmpty(comBox_format_file.Text) &&
                !string.IsNullOrEmpty(txtBox_UDK.Text) && !string.IsNullOrEmpty(txtBox_Count_pages.Text)
                && !string.IsNullOrEmpty(comBox_publishing.Text)
                && collectionAuthors.authors.Count >0 && trBar_size_file.Value>0) // проверка на заполнение полей
            {
                #region ChecksDesserialize

                if (succesDesserializ) // добавляем в дессир. коллекцию ещё один обьект
                {
                    
                    bool checkUDK = false;
                    foreach (var item in infoFromFile.books)
                    {
                        if (item.UDK.ToString() == txtBox_UDK.Text.ToString())
                        {
                            checkUDK = true;
                        }
                    }
                    if (!checkUDK) // проверка на UDK
                    {
                        #region CreateNewBook

                        book = new Book(txtBox_Name_book.Text, txtBox_UDK.Text, comBox_publishing.Text,
                                        trBar_size_file.Value, int.Parse(txtBox_Count_pages.Text),
                                        comBox_format_file.Text, dateTimePicker1.Text, collectionAuthors);
                        var copy = book.Clone();
                        #endregion
                        infoFromFile.books.Add(book); // добавляем книгу в коллекцию
                        SerializateInfo.Serialize<CollectionBooks>(infoFromFile, "books.xml"); // сериализуем коллекцию
                        collectionAuthors = new ContenerAuthors(); // clearing 
                        MessageBox.Show("Сохранено!");
                        toolStripStatusLabel_Last_do.Text = "Последние действие: Сохранение в файл";
                    }
                    else
                    {
                        MessageBox.Show("Такой UDK уже используется");
                    }
                }// Успешно дессириализовано
                else if (!succesDesserializ && !exepDesserializ)
                {
                    MessageBox.Show("Проведите Дессериализацию");
                }// Дессириализация не была проведена
                else if (!succesDesserializ && exepDesserializ) // 
                {
                    DialogResult dialogResult = MessageBox.Show("Будет создана новая коллекция в сериализуемом файле!\n" +
                                                                " Желаете продолжить?", "Exception Dessialiaze", MessageBoxButtons.YesNo);
                    if(dialogResult == DialogResult.Yes)
                    {
                            #region CreateNewBook

                            book = new Book(txtBox_Name_book.Text, txtBox_UDK.Text, comBox_publishing.Text,
                                            trBar_size_file.Value, int.Parse(txtBox_Count_pages.Text),
                                            comBox_format_file.Text, dateTimePicker1.Text, collectionAuthors);

                            #endregion
                            collectionBooks.books.Add(book); // добавляем книгу в коллекцию
                            SerializateInfo.Serialize<CollectionBooks>(collectionBooks, "books.xml"); // сериализуем коллекцию
                            MessageBox.Show("Сохранено!");
                        toolStripStatusLabel_Last_do.Text = "Последние действие: Сохранение в файл";
                    }
                    if(dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Закрыто!");
                    }
                }// Ошибка дессириализации

                #endregion
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        } // save in file

        private void button_outInfo_File_Click(object sender, EventArgs e)
        {
            try
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
                toolStripStatusLabel_Last_do.Text = "Последние действие: Вывод с файла";
            }
            catch(Exception x)
            {
                MessageBox.Show($"Ошибка: {x.Message}");
            }
        } // out int from file

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            #region BoolArgumentsForCheck

            bool needRefrashFormat = true;

            bool needRefrashPublishing = true;

            #endregion

            StringBuilder arrayNewFormats = new StringBuilder();

            if (succesDesserializ)
            {
                #region AlgorithmForRefrashComBox

                foreach (var item in infoFromFile.books)
                {
                    foreach (var formaters in comBox_format_file.Items)
                    {
                        if (item.Format.ToString() == formaters.ToString())
                        {
                            needRefrashFormat = false;
                        }
                    }
                    foreach (var formaters in comBox_publishing.Items)
                    {
                        if (item.Publishing.ToString() == formaters.ToString())
                        {
                            needRefrashPublishing = false;
                        }
                    }
                    if (needRefrashFormat)
                    {
                        comBox_format_file.Items.Add(item.Format.ToString());
                    }
                    if (needRefrashPublishing)
                    {
                        comBox_publishing.Items.Add(item.Publishing.ToString());
                    }
                    needRefrashFormat = true;
                    needRefrashPublishing = true;
                }
                #endregion//Проверка на обновления формата(горжусь этим алгоритмом, ахаха)
                MessageBox.Show("Обновлено!");
                toolStripStatusLabel_Last_do.Text = "Последние действие: Обновление ComBox'ов";
            }
            else if (!succesDesserializ && !exepDesserializ)
            {
                MessageBox.Show("Проведите Дессериализацию");
            }
            else if (!succesDesserializ && exepDesserializ)
            {
                MessageBox.Show("Ошибка Дессериализации"); 
            }

        } // refrashing comBox's

        private void button_Dessereliz_Click(object sender, EventArgs e)
        {
            #region TryDesserialize

            try
            {
                infoFromFile = SerializateInfo.Deserialize<CollectionBooks>("books.xml");
                MessageBox.Show("Успешно");
                succesDesserializ = true;
            }
            catch (Exception x)
            {
                MessageBox.Show($"Ошибка: {x.Message}");
                exepDesserializ = true;
            }

            #endregion
            toolStripStatusLabel_Last_do.Text = "Последние действие: Дисериализация";
        } // Deserialize file for refrash

        private void ToolStripMenuItem_AboutProgramm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prod.Dorohov SN \n Version 1.0");
            toolStripStatusLabel_Last_do.Text = "Последние действие: О программе";
        } // Window about Programm 

        private void ToolStripMenuItem_Search_in_file_Click(object sender, EventArgs e)
        {
            form_search.Show();
            toolStripStatusLabel_Last_do.Text = "Последние действие: Поиск";
        }

        private void ToolStripMenuItem_Save_Search_Sort_Click(object sender, EventArgs e)
        {
            if (form_search.result_Search.Count > 0 || form_sort.result_Sort.Count>0)
            {
                try
                {
                    SerializateInfo.Serialize<List<Book>>(form_search.result_Search, "result_Search.xml");
                    SerializateInfo.Serialize<List<Book>>(form_sort.result_Sort, "result_Sort.xml");
                    MessageBox.Show("Успешно сохранено!");
                    toolStripStatusLabel_Last_do.Text = "Последние действие: Сохранения поисков";
                }
                catch (Exception x)
                {
                    MessageBox.Show($"Ошибка: {x.Message}");
                }
            }
            
            
        }

        private void ToolStripMenuItem_Sort_in_file_Click(object sender, EventArgs e)
        {
            form_sort.Show();
            toolStripStatusLabel_Last_do.Text = "Последние действие: Сортировка";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            form_search.Show();
            toolStripStatusLabel_Last_do.Text = "Последние действие: Поиск";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            form_sort.Show();
            toolStripStatusLabel_Last_do.Text = "Последние действие: Сортировка";
        }

        private void look_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (look_ToolStripMenuItem.Text == "Показать панель")
            {
                toolStrip1.Visible = true;
                look_ToolStripMenuItem.Text = "Скрыть панель";
            }
            else if(look_ToolStripMenuItem.Text == "Скрыть панель")
            {
                toolStrip1.Visible = false;
                look_ToolStripMenuItem.Text = "Показать панель";
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            txtBox_Count_pages.Text = string.Empty;
            txtBox_fromFile.Text = string.Empty;
            txtBox_from_Form.Text = string.Empty;
            txtBox_UDK.Text = string.Empty;
            txtBox_Name_book.Text = string.Empty;
            comBox_format_file.Text = string.Empty;
            comBox_publishing.Text = string.Empty;
        }

        private void ToolStripMenuItem_Design_Click(object sender, EventArgs e)
        {
            Singleton.Design(this);
            Singleton singleton = Singleton.getInstance();
        }
    }
}
