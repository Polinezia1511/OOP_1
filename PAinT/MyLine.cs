﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAinT
{
    class MyLine : Figure
    {
        private int x1, y1, x2, y2;
        public MyLine(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen Mypen = new Pen(Color.Red);
            e.Graphics.DrawLine(Mypen, x1, y1, x2, y2);
        }
        public MyLine()
        {

        }
    }
}
