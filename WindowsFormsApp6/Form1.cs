using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        float angle = 0, move = 2;
        int px = 340, py = 260, dst = 150;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawEllipse(Pens.White, 200, 130, 300, 300);
            g.FillEllipse(Brushes.Orange, 360, 250, 50, 50);
            g.DrawString("sun",  Font , new SolidBrush(Color.Yellow), 360, 230);
            int x = (int)(px + dst * Math.Sin(angle * Math.PI / 150));
            int y = (int)(py + dst * Math.Cos(angle * Math.PI / 150));

            g.FillEllipse(Brushes.SkyBlue, x, y, 20, 20);
            angle -= move;

            g.DrawEllipse(Pens.White, (int)x - 15, (int)y - 15, 50, 50);

            int x1 = (int)(x + 25 * Math.Sin(angle * Math.PI / 150));
            int y1 = (int)(y + 25 * Math.Cos(angle * Math.PI / 150));

            g.FillEllipse(Brushes.White, (int)x1, (int)y1, 8, 8);
            g.DrawString("earth and moon", Font, new SolidBrush(Color.Yellow), (int)(x - dst + 125), (int)(y - dst + 110));
        }
    }
}
