using Hitomi_Viewer.Browser.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for BrowserPage.xaml
    /// </summary>
    public partial class BrowserPage : Page
    {
		BrowserViewModel mBrowserViewModel;
		public ObservableCollection<Datum> mData;

        public BrowserPage()
        {
            InitializeComponent();

			mBrowserViewModel = new BrowserViewModel();
			DataContext = mBrowserViewModel;

			Poo();
        }

		private void Poo()
		{
			mData = new ObservableCollection<Datum>();

			for (int i = 0; i < 20; i++)
			{
				mData.Add(new Datum());
			}

			//TileView.Items = mData;
		}
    }

	public class Datum
	{
		public string Thumbnail {  get; set; }
		public string Title { get; set; }

		public Datum()
		{
			Thumbnail = @"C:\Users\jkhong\Pictures\parasoul.jpg";
			Title = "Title";
		}
	}
}
