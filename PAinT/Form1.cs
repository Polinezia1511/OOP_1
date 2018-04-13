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
            MyPie myPie = new MyPie(240, 50, 340, 100, 30, 100);
            list.Add(myPie);
            MyEllipse myEllipse = new MyEllipse(250, 180, 360, 250);
            list.Add(myEllipse);
            Rectangle myRec = new Rectangle(100, 120, 180, 200);
            list.Add(myRec);
            MyCircle myCircle = new MyCircle(50, 95, 100);
            list.Add(myCircle);
            MyLine myLine = new MyLine(10, 10, 300, 200);
            list.Add(myLine);
            foreach (Figure figure in list)
            {
                figure.Draw(e);
            } 
        }
    }
}
