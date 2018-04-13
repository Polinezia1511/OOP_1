using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAinT
{
    public partial class Form1 : Form
    {
        List<Figure> list = new List<Figure>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            MyLine myLine = new MyLine(10, 10, 300, 200);
            list.Add(myLine);
            foreach (Figure figure in list)
            {
                figure.Draw(e);
            } 
        }
    }
}
