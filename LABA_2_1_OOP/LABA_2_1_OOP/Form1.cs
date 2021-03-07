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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Arguments
        Form2 form2 = new Form2();
        #endregion
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbScrollBar.Text = trBar_size_file.Value.ToString() + "Кб";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
        }
    }
}
