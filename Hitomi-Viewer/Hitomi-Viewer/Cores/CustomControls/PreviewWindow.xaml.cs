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
using System.Windows.Shapes;

namespace Hitomi_Viewer.Cores.CustomControls
{
    /// <summary>
    /// Interaction logic for PreviewWindow.xaml
    /// </summary>
    public partial class PreviewWindow : Window
    {
        BitmapSource Preview1 { get; set; }
        BitmapSource Preview2 { get; set; }
        BitmapSource Preview3 { get; set; }
        BitmapSource Preview4 { get; set; }

        public PreviewWindow()
        {
            InitializeComponent();
            Visibility = Visibility.Hidden;


        }
    }
}
