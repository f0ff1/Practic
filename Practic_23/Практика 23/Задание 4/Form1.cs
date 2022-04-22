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

namespace Задание_4
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber400, Primary.Amber800, Primary.Amber900, Accent.DeepOrange700, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            var letter = BoxLetter.Text;


            if (letter == "К")
            {
                MaterialRaisedButton raisedButton = new MaterialRaisedButton()
                {
                    Name = Faker.Name.First(),
                    Text = "Созданная кнопка",
                    Size = new Size(160, 27)
                };
                raisedButton.MouseEnter += RaisedButton_MouseEnter;

                if (!string.IsNullOrEmpty(BoxY.Text) && !string.IsNullOrEmpty(BoxY.Text))
                {
                    raisedButton.Location = new Point(int.Parse(BoxX.Text), int.Parse(BoxY.Text));
                }

                else
                {
                    raisedButton.Location = new Point(250, 400);
                }

                this.Controls.Add(raisedButton);
            }
            else if (letter == "П")
            {
                TextBox textBox = new TextBox()
                {
                    Name = Faker.Name.First(),
                    Text = "Созданное поле ввода",
                    Size = new Size(160, 27)
                };


                if (!string.IsNullOrEmpty(BoxY.Text) && !string.IsNullOrEmpty(BoxY.Text))
                {
                    textBox.Location = new Point(int.Parse(BoxX.Text), int.Parse(BoxY.Text));
                }
                else
                {
                    textBox.Location = new Point(400, 250);
                }

                this.Controls.Add(textBox);
            }
            else if (letter == "М")
            {
                Label label = new Label()
                {
                    Name = Faker.Name.First(),
                    Text = "Метка",
                    Size = new Size(160, 27)
                };

                if (!string.IsNullOrEmpty(BoxY.Text) && !string.IsNullOrEmpty(BoxY.Text))
                {
                    label.Location = new Point(int.Parse(BoxX.Text), int.Parse(BoxY.Text));
                }
                else
                {
                    label.Location = new Point(300, 500);
                }

                this.Controls.Add(label);
            }
        }

        private void RaisedButton_MouseEnter(object sender, EventArgs e)
        {
            var button = (MaterialRaisedButton)sender;
            this.Controls.Remove(button);
        }
    }
}
