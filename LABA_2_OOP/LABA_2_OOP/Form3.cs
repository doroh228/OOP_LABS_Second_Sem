using System;
using System.Drawing;
using System.Windows.Forms;

namespace LABA_2_OOP
{
    public partial class Form3 : Form
    {
        Form1 form1 = new Form1();
        Timer tmr = new Timer() { Interval = 3000 };
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = BackColor;
            tmr.Tick += tmr_Tick;
            this.Opacity = .7;
            tmr.Start();
        }
        void tmr_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
    }
}
