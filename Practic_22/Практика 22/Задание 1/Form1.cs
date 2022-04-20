using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Задание_1
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue800, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Начальные значения
            BoxX.Text = $"{1.825 * Math.Pow(10,2)}";
            BoxY.Text = $"{18.225}";
            BoxZ.Text = $"{-3.298 * Math.Pow(10, -2)}";
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            var x = double.Parse(BoxX.Text);
            BoxWrite.Text +=  "X = " + x.ToString();

            var y = double.Parse(BoxY.Text);
            BoxWrite.Text += Environment.NewLine + "Y = " + y.ToString();
             
            var z = double.Parse(BoxZ.Text);
            BoxWrite.Text += Environment.NewLine + "Z = " + z.ToString();

            var a = Math.Abs(Math.Pow(x, y / x) - Math.Pow(y / x, 1 / 3));
            var b = y - x;
            var c = Math.Cos(y) - z / b;
            var d = 1 + Math.Pow(b, 2);
            var answer = a + b * (c / d);

            BoxWrite.Text += Environment.NewLine + "Answer = " + answer.ToString();
        }
    }
}
