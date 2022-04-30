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
using MySql.Data.MySqlClient;

namespace Задание_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            TextBoxCost.GotFocus += TextBox_GotFocus;
            TextBoxName.GotFocus += TextBox_GotFocus;
            TextBoxSecondName.GotFocus += TextBox_GotFocus;
            
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var txt = (TextBox)sender;
            if (txt.Text.Contains("Enter"))
            {
                txt.Text = string.Empty;
            }
        }

        private void ButtonConnectDB_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var myCon = DataBaseService.CreateConnectino();
                myCon.Open();
                ListBoxWriter.Items.Add("DB CONNECTED");
                myCon.Close();
            }
            catch (Exception ex) 
            {
                ListBoxWriter.Items.Add(ex.Message);
            }
            
        }

        private void ButtonShowTours_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var myCon = DataBaseService.CreateConnectino();
                var tours = DataBaseService.GetTours(myCon);

                foreach (var tour in tours)
                {
                    ListBoxWriter.Items.Add(tour);
                }
            }
            catch (Exception ex)
            {
                ListBoxWriter.Items.Add(ex.Message);

            }
            
            
        }

        private void ButtonShowTourists_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var myCon = DataBaseService.CreateConnectino();
                var tourists = DataBaseService.GetTourists(myCon);

                foreach (var tourist in tourists)
                {
                    ListBoxWriter.Items.Add(tourist);
                }
            }
            catch (Exception ex)
            {
                ListBoxWriter.Items.Add(ex.Message);
            }           

        }

        private void ButtonDeleteTour_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var myCon = DataBaseService.CreateConnectino();
                var selectedTour = ListBoxWriter.SelectedItem.ToString().Split('|').ToList();

                DataBaseService.DeleteTour(myCon, selectedTour);
            }
            catch (NullReferenceException ex)
            {
                ListBoxWriter.Items.Add(ex.Message);
            }

            catch (Exception ex)
            {
                ListBoxWriter.Items.Add(ex.Message);
            }
            
            

            
        }

        private void ButtonAddTour_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var myCon = DataBaseService.CreateConnectino();
                var tourName = TextBoxName.Text;
                var tourCost = TextBoxCost.Text;

                DataBaseService.AddTour(myCon, tourName, tourCost);
            }
            catch (Exception ex)
            {
                ListBoxWriter.Items.Add(ex.Message);
            }
            
   
        }

        private void ButtonAddTourist_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var myCon = DataBaseService.CreateConnectino();
                var touristName = TextBoxName.Text;
                var touristSName = TextBoxCost.Text;

                DataBaseService.AddTourist(myCon, touristName, touristSName);
            }
            catch (Exception ex)
            {
                ListBoxWriter.Items.Add(ex.Message);                
            }
            

        }

        private void ButtonChangeTourist_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var myCon = DataBaseService.CreateConnectino();
                var touristNameChange = TextBoxName.Text;
                var touristSNameCnahge = TextBoxSecondName.Text;
                var selectedTourist = ListBoxWriter.SelectedItem.ToString().Split('|').ToList();

                DataBaseService.ChangeTourist(myCon, selectedTourist, touristNameChange, touristSNameCnahge);
            }
            catch (Exception ex)
            {
                ListBoxWriter.Items.Add(ex.Message);
            }
            

        }
    }
}
