
namespace LABA_2_1_OOP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_SN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comBox_countre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_Close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.lb_Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 48);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторы";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО";
            // 
            // txtBox_SN
            // 
            this.txtBox_SN.Location = new System.Drawing.Point(90, 79);
            this.txtBox_SN.Multiline = true;
            this.txtBox_SN.Name = "txtBox_SN";
            this.txtBox_SN.Size = new System.Drawing.Size(268, 29);
            this.txtBox_SN.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Страна";
            // 
            // comBox_countre
            // 
            this.comBox_countre.FormattingEnabled = true;
            this.comBox_countre.Location = new System.Drawing.Point(90, 143);
            this.comBox_countre.Name = "comBox_countre";
            this.comBox_countre.Size = new System.Drawing.Size(268, 21);
            this.comBox_countre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(13, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID";
            // 
            // txtBox_Id
            // 
            this.txtBox_Id.Location = new System.Drawing.Point(90, 198);
            this.txtBox_Id.Multiline = true;
            this.txtBox_Id.Name = "txtBox_Id";
            this.txtBox_Id.Size = new System.Drawing.Size(268, 29);
            this.txtBox_Id.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.SkyBlue;
            this.button1.Location = new System.Drawing.Point(16, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(342, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lb_Close
            // 
            this.lb_Close.AutoSize = true;
            this.lb_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Close.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_Close.Location = new System.Drawing.Point(342, 9);
            this.lb_Close.Name = "lb_Close";
            this.lb_Close.Size = new System.Drawing.Size(17, 16);
            this.lb_Close.TabIndex = 9;
            this.lb_Close.Text = "X";
            this.lb_Close.Click += new System.EventHandler(this.lb_Close_Click);
            this.lb_Close.MouseEnter += new System.EventHandler(this.lb_Close_MouseEnter);
            this.lb_Close.MouseLeave += new System.EventHandler(this.lb_Close_MouseLeave);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(370, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox_Id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comBox_countre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_SN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_SN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBox_countre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_Id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_Close;
    }
}