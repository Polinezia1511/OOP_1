using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAinT
{
    class MySquare : Figure
    {
        private int x1, y1, x2;
        public MySquare(int x1, int y1, int x2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2; 
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.LightYellow);
            e.Graphics.DrawRectangle(myPen, x1, y1, x2, x2);
        }
    }
}
