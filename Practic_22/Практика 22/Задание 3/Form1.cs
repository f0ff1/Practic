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
using static System.Convert;

namespace Задание_3
{
    public partial class Form1 : MaterialForm
    {
        private const string ConstValueX0 = "Введите х0";
        private const string ConstValueXk = "Введите хk";
        private const string ConstValueDx = "Введите dx";
        private const string ConstValueA = "Введите A";

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green800, Primary.LightGreen900, Accent.LightGreen200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BoxX0.Text = "Введите х0";
            BoxXk.Text = "Введите xk";
            BoxDx.Text = "Введите dx";
            BoxA.Text = "Введите A";

            BoxX0.GotFocus += Box_GotFocus;
            BoxXk.GotFocus += Box_GotFocus;
            BoxDx.GotFocus += Box_GotFocus;
            BoxA.GotFocus += Box_GotFocus;

            BoxX0.LostFocus += Box_LostFocus;
            BoxXk.LostFocus += Box_LostFocus;
            BoxDx.LostFocus += Box_LostFocus;
            BoxA.LostFocus += Box_LostFocus;

        }

        private void Box_LostFocus(object sender, EventArgs e)
        {

            var txt = (TextBox)sender;
            if (txt.Name.Contains("X0") && string.IsNullOrEmpty(txt.Text))
            {
                txt.Text = ConstValueX0;
            }
            else if (txt.Name.Contains("Xk") && string.IsNullOrEmpty(txt.Text))
            {
                txt.Text = ConstValueXk;
            }
            else if (txt.Name.Contains("Dx") && string.IsNullOrEmpty(txt.Text))
            {
                txt.Text = ConstValueDx;
            }
            else if (txt.Name.Contains("A") && string.IsNullOrEmpty(txt.Text))
            {
                txt.Text = ConstValueA;
            }

        }

        private void Box_GotFocus(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            if (txt.Text.Contains("Введите"))
            {
                txt.Text = string.Empty;
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            double x0 = double.Parse(BoxX0.Text);
            double xk = double.Parse(BoxXk.Text);
            double dx = double.Parse(BoxDx.Text);
            double a = double.Parse(BoxA.Text);

            double x = x0;
            while (x < xk)
            {
                double y = 0.0025 * a * Math.Pow(x, 3) + Math.Sqrt(x + Math.Pow(Math.E, 0.82));

                BoxWrite.Text += Environment.NewLine + "x= " + Convert.ToString(x) + "; y= " + Convert.ToString(y);
                x += dx;
            }
        }
    }
}
