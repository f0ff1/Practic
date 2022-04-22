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
        double[] myArrayZ = new double[15];
        double[] myArrayD = new double[15];
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink400, Primary.Pink800, Primary.Pink900, Accent.DeepPurple200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonZ_Click(object sender, EventArgs e)
        {
            ListZ.Items.Clear();            

            for (int i = 0; i < myArrayZ.Length; i++)
            {
                myArrayZ[i] = i % 2 == 0 ? Math.Pow(i, 2) + 1: 2*i-1;

                ListZ.Items.Add("ArrayZ[" + i.ToString() + "] = " + myArrayZ[i].ToString());

            }
        }

        private void ButtonD_Click(object sender, EventArgs e)
        {
            ListD.Items.Clear();

            for (int i = 0; i < myArrayZ.Length; i++)
            {
                myArrayD[i] = myArrayZ[i] < 2.5 ? 2.5 * myArrayZ[i] : myArrayZ[i] / 2.5;
                ListD.Items.Add("ArrayD[" + i.ToString() + "] = " + myArrayD[i].ToString());
            }
        }
    }
}
