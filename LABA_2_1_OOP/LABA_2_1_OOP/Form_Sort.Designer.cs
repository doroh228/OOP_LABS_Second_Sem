
namespace LABA_2_1_OOP
{
    partial class Form_Sort
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
            this.pictBox_Search = new System.Windows.Forms.PictureBox();
            this.lb_Search = new System.Windows.Forms.Label();
            this.combBox_Sort_by = new System.Windows.Forms.ComboBox();
            this.lb_Search_by = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.txtBox_Result = new System.Windows.Forms.TextBox();
            this.lb_Close = new System.Windows.Forms.Label();
            this.panel_TitleSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_TitleSearch
            // 
            this.panel_TitleSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_TitleSearch.Controls.Add(this.lb_Close);
            this.panel_TitleSearch.Controls.Add(this.lb_Close_Form);
            this.panel_TitleSearch.Controls.Add(this.pictBox_Search);
            this.panel_TitleSearch.Controls.Add(this.lb_Search);
            this.panel_TitleSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TitleSearch.Location = new System.Drawing.Point(0, 0);
            this.panel_TitleSearch.Name = "panel_TitleSearch";
            this.panel_TitleSearch.Size = new System.Drawing.Size(434, 46);
            this.panel_TitleSearch.TabIndex = 1;
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
            // 
            // pictBox_Search
            // 
            this.pictBox_Search.Image = global::LABA_2_1_OOP.Properties.Resources.search__v2;
            this.pictBox_Search.Location = new System.Drawing.Point(236, 9);
            this.pictBox_Search.Name = "pictBox_Search";
            this.pictBox_Search.Size = new System.Drawing.Size(34, 28);
            this.pictBox_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBox_Search.TabIndex = 1;
            this.pictBox_Search.TabStop = false;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Search.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lb_Search.Location = new System.Drawing.Point(183, 9);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(57, 28);
            this.lb_Search.TabIndex = 0;
            this.lb_Search.Text = "Sort";
            // 
            // combBox_Sort_by
            // 
            this.combBox_Sort_by.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.combBox_Sort_by.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combBox_Sort_by.FormattingEnabled = true;
            this.combBox_Sort_by.Items.AddRange(new object[] {
            "Названию",
            "Дате загрузки"});
            this.combBox_Sort_by.Location = new System.Drawing.Point(12, 98);
            this.combBox_Sort_by.Name = "combBox_Sort_by";
            this.combBox_Sort_by.Size = new System.Drawing.Size(143, 21);
            this.combBox_Sort_by.TabIndex = 4;
            // 
            // lb_Search_by
            // 
            this.lb_Search_by.AutoSize = true;
            this.lb_Search_by.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Search_by.Location = new System.Drawing.Point(43, 73);
            this.lb_Search_by.Name = "lb_Search_by";
            this.lb_Search_by.Size = new System.Drawing.Size(79, 19);
            this.lb_Search_by.TabIndex = 3;
            this.lb_Search_by.Text = "Поиск по:";
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.SeaShell;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Search.Location = new System.Drawing.Point(282, 61);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(127, 31);
            this.button_Search.TabIndex = 18;
            this.button_Search.Text = "Искать";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // txtBox_Result
            // 
            this.txtBox_Result.Location = new System.Drawing.Point(189, 98);
            this.txtBox_Result.Multiline = true;
            this.txtBox_Result.Name = "txtBox_Result";
            this.txtBox_Result.ReadOnly = true;
            this.txtBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_Result.Size = new System.Drawing.Size(220, 291);
            this.txtBox_Result.TabIndex = 19;
            // 
            // lb_Close
            // 
            this.lb_Close.AutoSize = true;
            this.lb_Close.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Close.Location = new System.Drawing.Point(413, 3);
            this.lb_Close.Name = "lb_Close";
            this.lb_Close.Size = new System.Drawing.Size(18, 19);
            this.lb_Close.TabIndex = 20;
            this.lb_Close.Text = "X";
            this.lb_Close.Click += new System.EventHandler(this.lb_Close_Click);
            this.lb_Close.MouseEnter += new System.EventHandler(this.lb_Close_MouseEnter);
            this.lb_Close.MouseLeave += new System.EventHandler(this.lb_Close_MouseLeave);
            // 
            // Form_Sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(434, 401);
            this.Controls.Add(this.txtBox_Result);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.combBox_Sort_by);
            this.Controls.Add(this.lb_Search_by);
            this.Controls.Add(this.panel_TitleSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Sort";
            this.Text = "Form_Sort";
            this.panel_TitleSearch.ResumeLayout(false);
            this.panel_TitleSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_TitleSearch;
        private System.Windows.Forms.Label lb_Close_Form;
        private System.Windows.Forms.PictureBox pictBox_Search;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.ComboBox combBox_Sort_by;
        private System.Windows.Forms.Label lb_Search_by;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox txtBox_Result;
        private System.Windows.Forms.Label lb_Close;
    }
}