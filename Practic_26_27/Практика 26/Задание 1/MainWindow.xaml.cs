using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Задание_1.Enums;
using Задание_1.Models;
using Задание_1.Services;

namespace Задание_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bouquet bouquet = new Bouquet();
        //List<Flower> myBouquet;
        int resultCost = 0;

        public MainWindow()
        {
            InitializeComponent();
            ComboBoxType.ItemsSource = Enum.GetValues(typeof(FlowerType));
            TextBoxCount.GotFocus += TextBoxCount_GotFocus;

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void TextBoxCount_GotFocus(object sender, RoutedEventArgs e)
        {
            var txt = (TextBox)sender;
            if (txt.Text.Contains("Enter"))
            {
                txt.Text = string.Empty;
            }
        }


        private void ButtonAddFlower_Click(object sender, RoutedEventArgs e)
        {
            var item = (FlowerType)Enum.Parse(typeof(FlowerType), ComboBoxType.SelectedItem.ToString());
            try
            {
                if ((bool)RadioTextBlock.IsChecked)
                {
                    TextBlockWriter.IsEnabled = true;
                    TextBlockWriter.Visibility = Visibility.Visible;

                    ListBoxWriter.IsEnabled = false;
                    ListBoxWriter.Visibility = Visibility.Hidden;
                }
                else if ((bool)RadioListBox.IsChecked)
                {
                    ListBoxWriter.IsEnabled = true;
                    ListBoxWriter.Visibility = Visibility.Visible;

                    TextBlockWriter.IsEnabled = false;
                    TextBlockWriter.Visibility = Visibility.Hidden;
                }

                if (ComboBoxType.Text != string.Empty)
                {

                    var count = Convert.ToInt32(TextBoxCount.Text);
                    if (TextBlockWriter.IsEnabled && TextBlockWriter.Visibility == Visibility.Visible)
                    {
                        TextBlockWriter.Text += $"\nВыбран тип цветка: {item} | Количество:  {count} \n";
                    }
                    else if (ListBoxWriter.IsEnabled && ListBoxWriter.Visibility == Visibility.Visible)
                    {
                        ListBoxWriter.Items.Add($"\nВыбран тип цветка: {item} | Количество:  {count} \n");
                    }

                    

                    for (int i = 0; i < count; i++)
                    {
                        var flower = FlowerMaker.Create(item);
                        bouquet.AddFlower(flower);
                    }


                }
                else
                {
                    throw new ArgumentNullException("\nНе выбран тип цветка\n");
                }

            }
            catch (ArgumentException ex)
            {
                TextBlockWriter.Text += ex.Message;
            }
            catch (FormatException ex)
            {
                TextBlockWriter.Text += ex.Message;
            }

        }

        private void ButtonShowFlowers_Click(object sender, RoutedEventArgs e)
        {
            try
            {                

                TextBlockWriter.Text += $"\n";
                if (bouquet != null)
                {
                    var bouquetSerivce = new BouquetService(bouquet);
                    var flowersWtihCount = bouquetSerivce.GetFlowersWithCount();
                    foreach (var flowers in flowersWtihCount)
                    {
                        if (TextBlockWriter.IsEnabled)
                        {
                            TextBlockWriter.Text += $"{flowers.Print}";
                        }
                        else if (ListBoxWriter.IsEnabled)
                        {
                            ListBoxWriter.Items.Add($"{flowers.Print}");
                        }
                        
                        

                    }

                    TextBlockWriter.Text += $"\nОбщая стоимость = {bouquetSerivce.GetTotalCost()}\n";
                }
                else
                {
                    throw new NullReferenceException("Букет пуст");
                }

            }
            catch (ArgumentException ex)
            {
                TextBlockWriter.Text += ex.Message;
            }
            catch (FormatException ex)
            {
                TextBlockWriter.Text += ex.Message;
            }
            catch (NullReferenceException ex)
            {
                TextBlockWriter.Text += ex.Message;
            }


        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            TextBlockWriter.Text = string.Empty;

        }

        private void RadioTextBlock_Checked(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
