using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAinT
{
    class MyEllipse : Figure
    {
        private int x, y, width, height;
        public MyEllipse(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen Mypen = new Pen(Color.DarkOliveGreen);
            e.Graphics.DrawEllipse(Mypen, x, y, width, height);
        }
    }
}
