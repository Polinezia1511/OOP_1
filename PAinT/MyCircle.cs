using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAinT
{

    class MyCircle : Figure
    {
        private int x, y, rad;
        public MyCircle(int x, int y, int rad)
            {
            this.x = x;
            this.y = y;
            this.rad = rad;
            } 
        public override void Draw(PaintEventArgs e)
        {
            Pen Mypen = new Pen(Color.Black);
            e.Graphics.DrawEllipse(Mypen, x, y, rad, rad);
        }
    }
}
