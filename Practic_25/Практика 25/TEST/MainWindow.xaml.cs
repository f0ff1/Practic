using LiveCharts;
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
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace TEST
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            textBoxEnterH.GotFocus += TextBoxEnter_GotFocus;
            textBoxEnterX0.GotFocus += TextBoxEnter_GotFocus;
            textBoxEnterXn.GotFocus += TextBoxEnter_GotFocus;

            LineSeries = new LineSeries();
            SeriesCollection = new SeriesCollection
            {
                
                new LineSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(3),
                        new ObservableValue(4),
                        new ObservableValue(6),
                        new ObservableValue(8),
                        new ObservableValue(7),
                        new ObservableValue(5)
                    },
                    PointGeometrySize = 0,
                    StrokeThickness = 4,
                    Fill = Brushes.Transparent
                }
            };

          
            DataContext = this;
        }

        private void TextBoxEnter_GotFocus(object sender, RoutedEventArgs e)
        {
            var txt = (TextBox)sender;
            if (txt.Text.Contains("Укажите"))
            {
                txt.Text = string.Empty;
            }
        }

        public LineSeries LineSeries { get; set; }
        public SeriesCollection SeriesCollection { get; set; }

        private void UpdateAllOnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var x0 = double.Parse(textBoxEnterX0.Text);
                var xn = double.Parse(textBoxEnterXn.Text);
                var h = double.Parse(textBoxEnterH.Text);

                var r = new Random();

                foreach (var series in SeriesCollection)
                {
                    var i = x0;

                    foreach (var observable in series.Values.Cast<ObservableValue>())
                    {
                        if (i >= xn)
                        {
                            break;
                        }

                        observable.Value = Math.Pow(i, 2);
                        i += h;
                        

                    }
                }
            }
            catch (FormatException)
            {

                
            }
           

           
        }
    }
    
}
