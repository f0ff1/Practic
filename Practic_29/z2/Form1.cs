using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z2
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap baner;
        Rectangle ret;
        string basePath = AppDomain.CurrentDomain.BaseDirectory;
        string bannerPath;
        public Form1()
        {
            InitializeComponent();
            
            bannerPath=Path.Combine(basePath, "baner.png");
            try
            {
                baner = new Bitmap(bannerPath);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка загрузки файла баннера\n " + e.ToString(), "Banner");
                this.Close();
                return;
            }
            ret = new Rectangle();
            ret.X = 0;
            ret.Y = 0;
            
            ret.Width = baner.Width;
            ret.Height = baner.Height;
            button1.Click += Button1_Click;
            this.Paint += Form1_Paint;
           
            

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawImage(baner, rect: ret);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Enabled = true;
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            ret.X -= 3;
            if (Math.Abs(ret.X) > ret.Width && ret.X<0)
            {
                ret.X = this.ClientSize.Width-30;
            }

            //for (int i = 0; i <= Convert.ToInt16(this.ClientSize.Width / ret.Width) + 1; i++)
            //{

            //    var x = ret.X + i * ret.Width;
            //    var y = ret.Y;
                
            //    g.DrawImage(baner,x, y);               
            //}
            var x = ret.X + ret.Width;
            var y = ret.Y;
            //g.DrawImage(baner, ret);
            //Invalidate();
            Refresh();

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Y < ret.Y + ret.Height) && (e.Y > ret.Y))
            {
                if (timer1.Enabled != false)
                 timer1.Enabled = false;    
            }
            else
            {
                if (timer1.Enabled != true)
                {
                    timer1.Enabled = true;
                }
            }
        }
    }
}
