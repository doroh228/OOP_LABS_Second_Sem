
namespace LABA_2_OOP
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_SN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_author_from = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Id_author = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_SN
            // 
            this.textBox_SN.Location = new System.Drawing.Point(12, 26);
            this.textBox_SN.Multiline = true;
            this.textBox_SN.Name = "textBox_SN";
            this.textBox_SN.Size = new System.Drawing.Size(206, 26);
            this.textBox_SN.TabIndex = 1;
            this.textBox_SN.TextChanged += new System.EventHandler(this.textBox_SN_TextChanged);
            this.textBox_SN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО";
            // 
            // comboBox_author_from
            // 
            this.comboBox_author_from.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.comboBox_author_from.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_author_from.FormattingEnabled = true;
            this.comboBox_author_from.Items.AddRange(new object[] {
            "Беларусь",
            "Росссия",
            "Украина",
            "Литва"});
            this.comboBox_author_from.Location = new System.Drawing.Point(12, 81);
            this.comboBox_author_from.Name = "comboBox_author_from";
            this.comboBox_author_from.Size = new System.Drawing.Size(206, 21);
            this.comboBox_author_from.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Страна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            // 
            // textBox_Id_author
            // 
            this.textBox_Id_author.Location = new System.Drawing.Point(12, 132);
            this.textBox_Id_author.Multiline = true;
            this.textBox_Id_author.Name = "textBox_Id_author";
            this.textBox_Id_author.Size = new System.Drawing.Size(206, 26);
            this.textBox_Id_author.TabIndex = 5;
            this.textBox_Id_author.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Id_author_KeyPress);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 240);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Id_author);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_author_from);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_SN);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_SN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_author_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Id_author;
    }
}