using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 4);

            g.Clear(Color.White);

            SolidBrush orange = new SolidBrush(Color.OrangeRed);
            SolidBrush black = new SolidBrush(Color.Black);
            SolidBrush white = new SolidBrush(Color.White);

            g.DrawEllipse(pen, 100, 100, 400, 200);
            g.FillEllipse(orange, 100, 100, 400, 200);
            g.DrawEllipse(pen, 100, 150, 100, 100);
            g.FillEllipse(black, 100, 150, 100, 100);
            g.DrawEllipse(pen, 120, 155, 60, 60);
            g.FillEllipse(white, 120, 155, 60, 60);


            var plavnik = new Point[] { new Point(250, 160), new Point(350, 120), new Point(350, 270), new Point(250, 220) };
            var hvost = new Point[] { new Point(485, 160), new Point(600, 120), new Point(600, 270), new Point(493, 220) };


            g.DrawLines(pen, plavnik);

            g.DrawLines(pen, hvost);
            g.FillPolygon(orange, hvost);

        }

    }
}
