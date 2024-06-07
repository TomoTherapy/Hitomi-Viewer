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

namespace Hitomi_Viewer.Cores.CustomControls
{
    /// <summary>
    /// Interaction logic for TileUserControl.xaml
    /// </summary>
    public partial class TileUserControl : UserControl
    {
        private PreviewWindow mPreviewWindow;

        public TileUserControl(BitmapSource image, string title, string author, string number, int pages)
        {
            InitializeComponent();

            Cover_Image.Source = image;
            Title_TextBlock.Text = title;
            Author_TextBlock.Text = author;
            Number_TextBlock.Text = number;
            Pages_TextBlock.Text = $"p{pages}";

            mPreviewWindow = new PreviewWindow();
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            mPreviewWindow.Visibility = Visibility.Visible;
            mPreviewWindow.DragMove();
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            mPreviewWindow.Visibility = Visibility.Visible;
        }
    }
}
