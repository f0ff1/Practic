using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChartSeries sinSerias = new ChartSeries("Sin(x)", ChartSeriesType.Spline);
            ChartSeries cosSerias = new ChartSeries("Cos(x)", ChartSeriesType.Spline);
            chartControl1.Series.Add(sinSerias);
            chartControl1.Series.Add(cosSerias);

        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            var Xmin = double.Parse(BoxXmin.Text);
            var Xmax = double.Parse(BoxXmax.Text);
            var Step = double.Parse(BoxStep.Text);

            int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;

            double[] x = new double[count];

            double[] y1 = new double[count];
            double[] y2 = new double[count];


            for (int i = 0; i < count; i++)
            {
                x[i] = Xmin + Step * i;

                y1[i] = Math.Sin(x[i]);
                y2[i] = Math.Cos(x[i]);

                
            }

        }
    }
}
