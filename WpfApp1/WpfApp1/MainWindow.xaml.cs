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

namespace WpfApp1
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

        private void A_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void B_Click(object sender, RoutedEventArgs e)
        {

        }

        private void C_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                Canvas.SetTop(DogeIcon, Canvas.GetTop(DogeIcon) + 10);
            }
            else if (e.Key == Key.Up)
            {
                Canvas.SetTop(DogeIcon, Canvas.GetTop(DogeIcon) - 10);
            }
            else if (e.Key == Key.Left)
            {
                Canvas.SetLeft(DogeIcon, Canvas.GetLeft(DogeIcon) - 10);
            }
            else if (e.Key == Key.Right)
            {
                Canvas.SetLeft(DogeIcon, Canvas.GetLeft(DogeIcon) + 10);
            }
        }

        private void RectangleMouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void MyCanvas_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            Canvas_KeyDown(sender, e);
        }
    }
}