using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAinT
{
    class MyPie : Figure
    {
        private int x1, y1, width, height, start, end;

        public MyPie(int x1, int y1, int width, int height, int start, int end)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.width = width;
            this.height = height;
            this.start = start;
            this.end = end;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Purple);
            e.Graphics.DrawPie(myPen, x1, y1, width, height, start, end);
        }
    }
}
