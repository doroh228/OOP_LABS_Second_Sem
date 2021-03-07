using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA_2_1_OOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        #region Arguments
        Point lastPoint;
        #endregion
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            txtBox_Id.Text = string.Empty;
            txtBox_SN.Text = string.Empty;
            comBox_countre.Text = string.Empty;
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
    }
}
