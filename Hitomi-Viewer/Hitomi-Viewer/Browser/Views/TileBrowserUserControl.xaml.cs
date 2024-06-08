using Hitomi_Viewer.CommonModels;
using Hitomi_Viewer.Cores.CustomControls;
using ImageMagick;
using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace Hitomi_Viewer.Browser.Views
{
    /// <summary>
    /// Interaction logic for TileBrowserUserControl.xaml
    /// </summary>
    public partial class TileBrowserUserControl : UserControl
    {
        
        public TileBrowserUserControl()
        {
            InitializeComponent();

            TestCode();
        }

        private void TestCode()
        {
            using (MagickImage magickImage = new MagickImage(@"..\..\..\Resources\SampleImages\a01.webp"))
            {
                using (Bitmap bmp = magickImage.ToBitmap())
                {
                    BitmapSource source = Utilities.CovertBitmapToBitmapSource(bmp);

                    for (int i = 0; i < 11; i++)
                    {
                        TileWrapPanel.Children.Add(new TileUserControl(source, "aaa", "bbb", "1234566", 10));
                    }
                }
            }
        }
    }
}
