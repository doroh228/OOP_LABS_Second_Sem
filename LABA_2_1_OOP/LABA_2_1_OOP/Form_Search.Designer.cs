
namespace LABA_2_1_OOP
{
    partial class Form_Search
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
            this.panel_TitleSearch = new System.Windows.Forms.Panel();
            this.lb_Close_Form = new System.Windows.Forms.Label();
            this.lb_Search = new System.Windows.Forms.Label();
            this.lb_Search_by = new System.Windows.Forms.Label();
            this.combBox_Search_by = new System.Windows.Forms.ComboBox();
            this.lb_Publiching = new System.Windows.Forms.Label();
            this.lb_dateRealize = new System.Windows.Forms.Label();
            this.lb_rangePages = new System.Windows.Forms.Label();
            this.lb_rengeFrom = new System.Windows.Forms.Label();
            this.lb_rengeTo = new System.Windows.Forms.Label();
            this.txtBox_rangeFrom = new System.Windows.Forms.TextBox();
            this.txtBox_rangeTo = new System.Windows.Forms.TextBox();
            this.dateTimePicker_realeze = new System.Windows.Forms.DateTimePicker();
            this.txtBox_Publishing = new System.Windows.Forms.TextBox();
            this.panel_Publiching = new System.Windows.Forms.Panel();
            this.panel_dateRealize = new System.Windows.Forms.Panel();
            this.panel_rangePages = new System.Windows.Forms.Panel();
            this.txtBox_Result = new System.Windows.Forms.TextBox();
            this.lb_Result = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.pictBox_Search = new System.Windows.Forms.PictureBox();
            this.panel_TitleSearch.SuspendLayout();
            this.panel_Publiching.SuspendLayout();
            this.panel_dateRealize.SuspendLayout();
            this.panel_rangePages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_TitleSearch
            // 
            this.panel_TitleSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_TitleSearch.Controls.Add(this.lb_Close_Form);
            this.panel_TitleSearch.Controls.Add(this.pictBox_Search);
            this.panel_TitleSearch.Controls.Add(this.lb_Search);
            this.panel_TitleSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TitleSearch.Location = new System.Drawing.Point(0, 0);
            this.panel_TitleSearch.Name = "panel_TitleSearch";
            this.panel_TitleSearch.Size = new System.Drawing.Size(513, 49);
            this.panel_TitleSearch.TabIndex = 0;
            this.panel_TitleSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel_TitleSearch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lb_Close_Form
            // 
            this.lb_Close_Form.AutoSize = true;
            this.lb_Close_Form.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Close_Form.Location = new System.Drawing.Point(490, 5);
            this.lb_Close_Form.Name = "lb_Close_Form";
            this.lb_Close_Form.Size = new System.Drawing.Size(18, 19);
            this.lb_Close_Form.TabIndex = 2;
            this.lb_Close_Form.Text = "X";
            this.lb_Close_Form.Click += new System.EventHandler(this.lb_Close_Form_Click);
            this.lb_Close_Form.MouseEnter += new System.EventHandler(this.lb_Close_Form_MouseEnter);
            this.lb_Close_Form.MouseLeave += new System.EventHandler(this.lb_Close_Form_MouseLeave);
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Search.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lb_Search.Location = new System.Drawing.Point(214, 12);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(83, 28);
            this.lb_Search.TabIndex = 0;
            this.lb_Search.Text = "Search";
            // 
            // lb_Search_by
            // 
            this.lb_Search_by.AutoSize = true;
            this.lb_Search_by.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Search_by.Location = new System.Drawing.Point(12, 73);
            this.lb_Search_by.Name = "lb_Search_by";
            this.lb_Search_by.Size = new System.Drawing.Size(79, 19);
            this.lb_Search_by.TabIndex = 1;
            this.lb_Search_by.Text = "Поиск по:";
            // 
            // combBox_Search_by
            // 
            this.combBox_Search_by.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.combBox_Search_by.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combBox_Search_by.FormattingEnabled = true;
            this.combBox_Search_by.Items.AddRange(new object[] {
            "Издательству",
            "Году издания",
            "Диапазону страниц"});
            this.combBox_Search_by.Location = new System.Drawing.Point(109, 73);
            this.combBox_Search_by.Name = "combBox_Search_by";
            this.combBox_Search_by.Size = new System.Drawing.Size(143, 21);
            this.combBox_Search_by.TabIndex = 2;
            this.combBox_Search_by.SelectedIndexChanged += new System.EventHandler(this.combBox_Search_by_SelectedIndexChanged);
            // 
            // lb_Publiching
            // 
            this.lb_Publiching.AutoSize = true;
            this.lb_Publiching.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Publiching.Location = new System.Drawing.Point(3, 15);
            this.lb_Publiching.Name = "lb_Publiching";
            this.lb_Publiching.Size = new System.Drawing.Size(85, 16);
            this.lb_Publiching.TabIndex = 3;
            this.lb_Publiching.Text = "Издательство:";
            // 
            // lb_dateRealize
            // 
            this.lb_dateRealize.AutoSize = true;
            this.lb_dateRealize.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_dateRealize.Location = new System.Drawing.Point(3, 12);
            this.lb_dateRealize.Name = "lb_dateRealize";
            this.lb_dateRealize.Size = new System.Drawing.Size(110, 16);
            this.lb_dateRealize.TabIndex = 4;
            this.lb_dateRealize.Text = "Дата издательства:";
            // 
            // lb_rangePages
            // 
            this.lb_rangePages.AutoSize = true;
            this.lb_rangePages.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_rangePages.Location = new System.Drawing.Point(3, 12);
            this.lb_rangePages.Name = "lb_rangePages";
            this.lb_rangePages.Size = new System.Drawing.Size(112, 16);
            this.lb_rangePages.TabIndex = 5;
            this.lb_rangePages.Text = "Диапазон страниц:";
            // 
            // lb_rengeFrom
            // 
            this.lb_rengeFrom.AutoSize = true;
            this.lb_rengeFrom.Location = new System.Drawing.Point(115, 14);
            this.lb_rengeFrom.Name = "lb_rengeFrom";
            this.lb_rengeFrom.Size = new System.Drawing.Size(23, 13);
            this.lb_rengeFrom.TabIndex = 6;
            this.lb_rengeFrom.Text = "От:";
            // 
            // lb_rengeTo
            // 
            this.lb_rengeTo.AutoSize = true;
            this.lb_rengeTo.Location = new System.Drawing.Point(115, 42);
            this.lb_rengeTo.Name = "lb_rengeTo";
            this.lb_rengeTo.Size = new System.Drawing.Size(25, 13);
            this.lb_rengeTo.TabIndex = 7;
            this.lb_rengeTo.Text = "До:";
            // 
            // txtBox_rangeFrom
            // 
            this.txtBox_rangeFrom.Location = new System.Drawing.Point(139, 11);
            this.txtBox_rangeFrom.Multiline = true;
            this.txtBox_rangeFrom.Name = "txtBox_rangeFrom";
            this.txtBox_rangeFrom.Size = new System.Drawing.Size(51, 19);
            this.txtBox_rangeFrom.TabIndex = 8;
            this.txtBox_rangeFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_rangeFrom_KeyPress);
            // 
            // txtBox_rangeTo
            // 
            this.txtBox_rangeTo.Location = new System.Drawing.Point(139, 39);
            this.txtBox_rangeTo.Multiline = true;
            this.txtBox_rangeTo.Name = "txtBox_rangeTo";
            this.txtBox_rangeTo.Size = new System.Drawing.Size(51, 19);
            this.txtBox_rangeTo.TabIndex = 9;
            this.txtBox_rangeTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_rangeTo_KeyPress);
            // 
            // dateTimePicker_realeze
            // 
            this.dateTimePicker_realeze.Location = new System.Drawing.Point(114, 10);
            this.dateTimePicker_realeze.Name = "dateTimePicker_realeze";
            this.dateTimePicker_realeze.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker_realeze.TabIndex = 10;
            // 
            // txtBox_Publishing
            // 
            this.txtBox_Publishing.Location = new System.Drawing.Point(91, 12);
            this.txtBox_Publishing.Multiline = true;
            this.txtBox_Publishing.Name = "txtBox_Publishing";
            this.txtBox_Publishing.Size = new System.Drawing.Size(139, 20);
            this.txtBox_Publishing.TabIndex = 11;
            // 
            // panel_Publiching
            // 
            this.panel_Publiching.Controls.Add(this.lb_Publiching);
            this.panel_Publiching.Controls.Add(this.txtBox_Publishing);
            this.panel_Publiching.Location = new System.Drawing.Point(16, 137);
            this.panel_Publiching.Name = "panel_Publiching";
            this.panel_Publiching.Size = new System.Drawing.Size(236, 93);
            this.panel_Publiching.TabIndex = 12;
            // 
            // panel_dateRealize
            // 
            this.panel_dateRealize.Controls.Add(this.lb_dateRealize);
            this.panel_dateRealize.Controls.Add(this.dateTimePicker_realeze);
            this.panel_dateRealize.Location = new System.Drawing.Point(16, 236);
            this.panel_dateRealize.Name = "panel_dateRealize";
            this.panel_dateRealize.Size = new System.Drawing.Size(236, 93);
            this.panel_dateRealize.TabIndex = 13;
            // 
            // panel_rangePages
            // 
            this.panel_rangePages.Controls.Add(this.lb_rangePages);
            this.panel_rangePages.Controls.Add(this.lb_rengeFrom);
            this.panel_rangePages.Controls.Add(this.lb_rengeTo);
            this.panel_rangePages.Controls.Add(this.txtBox_rangeTo);
            this.panel_rangePages.Controls.Add(this.txtBox_rangeFrom);
            this.panel_rangePages.Location = new System.Drawing.Point(16, 335);
            this.panel_rangePages.Name = "panel_rangePages";
            this.panel_rangePages.Size = new System.Drawing.Size(236, 93);
            this.panel_rangePages.TabIndex = 14;
            // 
            // txtBox_Result
            // 
            this.txtBox_Result.Location = new System.Drawing.Point(281, 137);
            this.txtBox_Result.Multiline = true;
            this.txtBox_Result.Name = "txtBox_Result";
            this.txtBox_Result.ReadOnly = true;
            this.txtBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_Result.Size = new System.Drawing.Size(220, 291);
            this.txtBox_Result.TabIndex = 15;
            // 
            // lb_Result
            // 
            this.lb_Result.AutoSize = true;
            this.lb_Result.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Result.Location = new System.Drawing.Point(353, 115);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(76, 19);
            this.lb_Result.TabIndex = 16;
            this.lb_Result.Text = "Результат";
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.SeaShell;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Search.Location = new System.Drawing.Point(327, 68);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(127, 31);
            this.button_Search.TabIndex = 17;
            this.button_Search.Text = "Искать";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // pictBox_Search
            // 
            this.pictBox_Search.Image = global::LABA_2_1_OOP.Properties.Resources.search__v2;
            this.pictBox_Search.Location = new System.Drawing.Point(294, 12);
            this.pictBox_Search.Name = "pictBox_Search";
            this.pictBox_Search.Size = new System.Drawing.Size(34, 28);
            this.pictBox_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBox_Search.TabIndex = 1;
            this.pictBox_Search.TabStop = false;
            // 
            // Form_Search
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(513, 437);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.txtBox_Result);
            this.Controls.Add(this.panel_rangePages);
            this.Controls.Add(this.panel_dateRealize);
            this.Controls.Add(this.panel_Publiching);
            this.Controls.Add(this.combBox_Search_by);
            this.Controls.Add(this.lb_Search_by);
            this.Controls.Add(this.panel_TitleSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Search";
            this.Load += new System.EventHandler(this.Form_Search_Load);
            this.panel_TitleSearch.ResumeLayout(false);
            this.panel_TitleSearch.PerformLayout();
            this.panel_Publiching.ResumeLayout(false);
            this.panel_Publiching.PerformLayout();
            this.panel_dateRealize.ResumeLayout(false);
            this.panel_dateRealize.PerformLayout();
            this.panel_rangePages.ResumeLayout(false);
            this.panel_rangePages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_TitleSearch;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.PictureBox pictBox_Search;
        private System.Windows.Forms.Label lb_Close_Form;
        private System.Windows.Forms.Label lb_Search_by;
        private System.Windows.Forms.ComboBox combBox_Search_by;
        private System.Windows.Forms.Label lb_Publiching;
        private System.Windows.Forms.Label lb_dateRealize;
        private System.Windows.Forms.Label lb_rangePages;
        private System.Windows.Forms.Label lb_rengeFrom;
        private System.Windows.Forms.Label lb_rengeTo;
        private System.Windows.Forms.TextBox txtBox_rangeFrom;
        private System.Windows.Forms.TextBox txtBox_rangeTo;
        private System.Windows.Forms.DateTimePicker dateTimePicker_realeze;
        private System.Windows.Forms.TextBox txtBox_Publishing;
        private System.Windows.Forms.Panel panel_Publiching;
        private System.Windows.Forms.Panel panel_dateRealize;
        private System.Windows.Forms.Panel panel_rangePages;
        private System.Windows.Forms.TextBox txtBox_Result;
        private System.Windows.Forms.Label lb_Result;
        private System.Windows.Forms.Button button_Search;
    }
}