using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LABA_2_1_OOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #region Properties

        Point lastPoint;

        public string ID { get; set; }

        public string SN { get; set; }

        public string Countre { get; set; }

        public static string sId, sSn, sCountre;
        #endregion

        private void lb_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            #region Clearing_items
            txtBox_Id.Text = string.Empty;
            txtBox_SN.Text = string.Empty;
            comBox_countre.Text = string.Empty;
            ID = string.Empty;
            Countre = string.Empty;
            SN = string.Empty;
            #endregion
        }

        private void lb_Close_MouseEnter(object sender, EventArgs e)
        {
            lb_Close.BorderStyle = BorderStyle.Fixed3D;
        }

        private void lb_Close_MouseLeave(object sender, EventArgs e)
        {
            lb_Close.BorderStyle = BorderStyle.None;
        }

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

        private void txtBox_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (txtBox_Id.TextLength > 30)
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBox_Id.Text) && !string.IsNullOrEmpty(txtBox_SN.Text)
                                                        && !string.IsNullOrEmpty(comBox_countre.Text))
            {
                #region Clearing_items
                ID = txtBox_Id.Text;
                sId = txtBox_Id.Text;
                SN = txtBox_SN.Text;
                sSn = txtBox_SN.Text;
                Countre = comBox_countre.Text;
                sCountre = comBox_countre.Text;
                txtBox_Id.Text = string.Empty;
                txtBox_SN.Text = string.Empty;
                comBox_countre.Text = string.Empty;
                #endregion
                Author author = new Author(SN, Countre, ID);
                Program.f1.AddAuthor(author);
                MessageBox.Show("Save successful");
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        public class MakeAuthor
        {
            public Author Make(AuthorBuilder builder)
            {
                builder.CreateAuthor();
                builder.GetSn(sSn);
                builder.GetId(sId);
                builder.GetFromCountre(sCountre);
                return builder.author;
            }
        }
    }
    
}
