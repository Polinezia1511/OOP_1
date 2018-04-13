using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAinT
{
    abstract class Figure
    {
        public abstract void Draw(PaintEventArgs e);
    }
}
