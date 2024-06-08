using Hitomi_Viewer.Browser.Views;
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

namespace Hitomi_Viewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainVIewModel mViewModel;

        public MainWindow()
        {
            InitializeComponent();

            mViewModel = new MainVIewModel();
            DataContext = mViewModel;

            //MainFrame.Navigate(App.BrowserPage);
            BrowserGrid.Children.Add(App.TileBrowserUserControl);

        }

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			App.Dispose();
		}

        private void TileViewButton_Click(object sender, RoutedEventArgs e)
        {
            //MainFrame.Navigate(App.BrowserPage);

            SwapUserControl(App.TileBrowserUserControl);
        }

        private void ListViewButton_Click(object sender, RoutedEventArgs e)
        {
            //MainFrame.Navigate(App.BrowserPage);

            SwapUserControl(App.ListBrowserUserControl);
        }

        private void PreferencesButton_Click(object sender, RoutedEventArgs e)
        {
            //MainFrame.Navigate(App.PreferencesPage);
        }

        private void SwapUserControl(UserControl control)
        {
            BrowserGrid.Children.Clear();
            BrowserGrid.Children.Add(control);
        }
    }
}
