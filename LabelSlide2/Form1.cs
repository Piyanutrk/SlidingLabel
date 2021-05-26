using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelSlide2
{
    public partial class Form1 : Form
    {
        int x;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = this.Width;
            label1.Text = "Please check again!";
            label1.Font = new Font(" ", 20, FontStyle.Bold);
            timer1.Interval = 1;
            //timer1.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.SetBounds(x, 1, label1.Width, label1.Height);
            x--;
            if (x < -label1.Text.Length)
            {
                x = this.Width;
            }
        }
    }
}
