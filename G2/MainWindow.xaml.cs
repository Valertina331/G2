using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace G2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void numberValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void generateClick(object sender, RoutedEventArgs e)
        {
            ellipsesCanvas.Children.Clear();
            if(int.TryParse(numberInput.Text, out int ellipsesNum))
            {
                for (int i = 0; i < ellipsesNum; i++)
                {
                    var ellipse = new Ellipse
                    {
                        Fill = Brushes.LightBlue,
                        Width = 100,
                        Height = 50,
                        Stroke = Brushes.Black
                    };
                    Canvas.SetLeft(ellipse, 10 + i * 110);
                    Canvas.SetTop(ellipse, 10);
                    ellipsesCanvas.Children.Add(ellipse);
                }
            }
        }
    }
}