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

namespace Задание_2
{
    public partial class Form1 : MaterialForm
    {
        private const string constValueX = "Введите Х: ";
        private const string constValueY = "Введите У: ";
        Func<double, double> func = null;
        double result = default;

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red400, Primary.Red800, Primary.Red900, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Начальные значения
            BoxX.Text = "Введите Х: ";
            BoxY.Text = "Введите У: ";

            
            BoxX.GotFocus += Box_GotFocus;
            BoxY.GotFocus += Box_GotFocus;
            BoxX.LostFocus += Box_LostFocus;
            BoxY.LostFocus += Box_LostFocus;

            RadioSinh.CheckedChanged += Radio_CheckedChanged;
            RadioEX.CheckedChanged += Radio_CheckedChanged;
            RadioXDegree.CheckedChanged += Radio_CheckedChanged;

        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                if (radioButton.Name.Contains("Sinh"))
                {
                    func = Functions.Snh;                  
                    BoxWrite.Text += Environment.NewLine + "SINH";
                    
                }
                if (radioButton.Name.Contains("XDegree"))
                {
                    func = (a) => a * a;                   
                    BoxWrite.Text += Environment.NewLine + "X^2";
                    
                }
                if (radioButton.Name.Contains("EX"))
                {                    
                    func = Math.Exp;                    
                    BoxWrite.Text += Environment.NewLine + "E^x";
                    
                }
            }
        }

        private void Box_LostFocus(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            if (txt.Name.Contains("X") && string.IsNullOrEmpty(txt.Text))
            {
                txt.Text = constValueX;
            }
            else if(txt.Name.Contains("Y") && string.IsNullOrEmpty(txt.Text))
            {
                txt.Text = constValueY;
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

        class NonFunctionSelectException : Exception 
        {
            public NonFunctionSelectException(string message)
                : base(message) { }
        }

       


        private void ButtonStart_Click(object sender, EventArgs e)
        {
            try
            { 
                var x = double.Parse(BoxX.Text);
                var y = double.Parse(BoxY.Text);
            
            
                if (RadioSinh.Checked || RadioXDegree.Checked || RadioEX.Checked)
                {
                    if (x > Math.Abs(y))
                    {
                        result = Functions.firstFunc(x, y, func);
                    }
                    else if (x > 3 && x < Math.Abs(y))
                    {
                        result = Functions.secFunc(x, y, func);
                    }
                    else
                    {
                        result = Functions.thirdFunc(x, y, func);
                    }

                    BoxWrite.Text += Environment.NewLine + "Result = " + result;
                }
                else
                {
                    throw new NonFunctionSelectException("Не выбрана функция!");
                }

            }
            catch (NonFunctionSelectException ex)
            {
                BoxWrite.Text += Environment.NewLine +  ex.Message;
            }

            catch (ArgumentException)
            {
                BoxWrite.Text += Environment.NewLine + "Неправильные значения!";
            }
            catch (FormatException ex)
            {
                BoxWrite.Text += Environment.NewLine + ex.Message;

            }
            
            
            
            
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            BoxWrite.Text = string.Empty;
            BoxX.Text = string.Empty;
            BoxY.Text = string.Empty;
        }
    }
}
