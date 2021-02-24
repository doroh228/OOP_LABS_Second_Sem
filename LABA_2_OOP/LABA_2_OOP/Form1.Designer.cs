
namespace LABA_2_OOP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Save = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox_name_book = new System.Windows.Forms.TextBox();
            this.label_Name_Book = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label_Value_File = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_from_born = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox_Countre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.textBox_info_from_file = new System.Windows.Forms.TextBox();
            this.panel_RadionsButtons = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label_radioButton = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Id_Book = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel_RadionsButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(12, 563);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(161, 45);
            this.button_Save.TabIndex = 0;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Фантастика",
            "Романтика",
            "Боевик",
            "Креминал",
            "Дэтектив",
            "Комедия"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 324);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(131, 94);
            this.checkedListBox1.TabIndex = 2;
            // 
            // textBox_name_book
            // 
            this.textBox_name_book.Location = new System.Drawing.Point(12, 55);
            this.textBox_name_book.Multiline = true;
            this.textBox_name_book.Name = "textBox_name_book";
            this.textBox_name_book.Size = new System.Drawing.Size(161, 30);
            this.textBox_name_book.TabIndex = 3;
            // 
            // label_Name_Book
            // 
            this.label_Name_Book.AutoSize = true;
            this.label_Name_Book.Location = new System.Drawing.Point(12, 39);
            this.label_Name_Book.Name = "label_Name_Book";
            this.label_Name_Book.Size = new System.Drawing.Size(89, 13);
            this.label_Name_Book.TabIndex = 4;
            this.label_Name_Book.Text = "Название книги";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(12, 276);
            this.trackBar1.Maximum = 300;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.SmallChange = 20;
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label_Value_File
            // 
            this.label_Value_File.AutoSize = true;
            this.label_Value_File.Location = new System.Drawing.Point(17, 260);
            this.label_Value_File.Name = "label_Value_File";
            this.label_Value_File.Size = new System.Drawing.Size(84, 13);
            this.label_Value_File.TabIndex = 6;
            this.label_Value_File.Text = "Размер Файла";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Вывести информацию";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(482, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 45);
            this.button3.TabIndex = 9;
            this.button3.Text = "Вывести из файла";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название извадельства";
            // 
            // textBox_from_born
            // 
            this.textBox_from_born.Location = new System.Drawing.Point(12, 107);
            this.textBox_from_born.Multiline = true;
            this.textBox_from_born.Name = "textBox_from_born";
            this.textBox_from_born.Size = new System.Drawing.Size(161, 30);
            this.textBox_from_born.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Автор";
            // 
            // textBox_Author
            // 
            this.textBox_Author.Location = new System.Drawing.Point(12, 159);
            this.textBox_Author.Multiline = true;
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(161, 30);
            this.textBox_Author.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 218);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Дата выхода";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Жанр";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 497);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 42);
            this.button4.TabIndex = 17;
            this.button4.Text = "Заполнить инормацию о авторе";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox_Countre
            // 
            this.comboBox_Countre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Countre.FormattingEnabled = true;
            this.comboBox_Countre.Items.AddRange(new object[] {
            "Беларусь",
            "Россия",
            "Украина",
            "Литва",
            "Латвия"});
            this.comboBox_Countre.Location = new System.Drawing.Point(12, 452);
            this.comboBox_Countre.Name = "comboBox_Countre";
            this.comboBox_Countre.Size = new System.Drawing.Size(161, 21);
            this.comboBox_Countre.TabIndex = 18;
            this.comboBox_Countre.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Страна производителя";
            // 
            // textBox_info
            // 
            this.textBox_info.Location = new System.Drawing.Point(268, 327);
            this.textBox_info.Multiline = true;
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.Size = new System.Drawing.Size(208, 281);
            this.textBox_info.TabIndex = 20;
            // 
            // textBox_info_from_file
            // 
            this.textBox_info_from_file.Location = new System.Drawing.Point(482, 327);
            this.textBox_info_from_file.Multiline = true;
            this.textBox_info_from_file.Name = "textBox_info_from_file";
            this.textBox_info_from_file.Size = new System.Drawing.Size(208, 281);
            this.textBox_info_from_file.TabIndex = 21;
            // 
            // panel_RadionsButtons
            // 
            this.panel_RadionsButtons.Controls.Add(this.radioButton3);
            this.panel_RadionsButtons.Controls.Add(this.radioButton2);
            this.panel_RadionsButtons.Controls.Add(this.radioButton1);
            this.panel_RadionsButtons.Location = new System.Drawing.Point(268, 107);
            this.panel_RadionsButtons.Name = "panel_RadionsButtons";
            this.panel_RadionsButtons.Size = new System.Drawing.Size(119, 82);
            this.panel_RadionsButtons.TabIndex = 22;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 49);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(102, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Твёрдо-мягкий";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Мягкий";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Твёрдый";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label_radioButton
            // 
            this.label_radioButton.AutoSize = true;
            this.label_radioButton.Location = new System.Drawing.Point(268, 91);
            this.label_radioButton.Name = "label_radioButton";
            this.label_radioButton.Size = new System.Drawing.Size(56, 13);
            this.label_radioButton.TabIndex = 23;
            this.label_radioButton.Text = "Переплёт";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "ID_книги";
            // 
            // textBox_Id_Book
            // 
            this.textBox_Id_Book.Location = new System.Drawing.Point(268, 55);
            this.textBox_Id_Book.Multiline = true;
            this.textBox_Id_Book.Name = "textBox_Id_Book";
            this.textBox_Id_Book.Size = new System.Drawing.Size(161, 30);
            this.textBox_Id_Book.TabIndex = 24;
            this.textBox_Id_Book.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Id_Book_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 620);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Id_Book);
            this.Controls.Add(this.label_radioButton);
            this.Controls.Add(this.panel_RadionsButtons);
            this.Controls.Add(this.textBox_info_from_file);
            this.Controls.Add(this.textBox_info);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_Countre);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Author);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_from_born);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_Value_File);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label_Name_Book);
            this.Controls.Add(this.textBox_name_book);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button_Save);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel_RadionsButtons.ResumeLayout(false);
            this.panel_RadionsButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox_name_book;
        private System.Windows.Forms.Label label_Name_Book;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label_Value_File;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox_from_born;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox_Countre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_info;
        private System.Windows.Forms.TextBox textBox_info_from_file;
        private System.Windows.Forms.Panel panel_RadionsButtons;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label_radioButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Id_Book;
    }
}

