using Hitomi_Viewer.Browser.Views;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Hitomi_Viewer.Services
{
	/// <summary>
	/// Interaction logic for TileViewUserControl.xaml
	/// </summary>
	public partial class TileViewUserControl : UserControl
	{
		public static readonly DependencyProperty ItemsProperty
			= DependencyProperty.Register("Items", typeof(ObservableCollection<Datum>), typeof(TileViewUserControl), new PropertyMetadata(new ObservableCollection<Datum>()));

		public ObservableCollection<Datum> Items
		{
			get { return (ObservableCollection<Datum>)GetValue(ItemsProperty); }
			set { SetValue(ItemsProperty, value); }
		}

		public TileViewUserControl()
		{
			InitializeComponent();
			TileView.ItemsSource = Items;
		}

		private void TileView_PreviewMouseMove(object sender, MouseEventArgs e)
		{
			if (e.LeftButton == MouseButtonState.Pressed)
			{
				var listBoxItem = FindAncestor<ListBoxItem>((DependencyObject)e.OriginalSource);
				if (listBoxItem != null)
				{
					DragDrop.DoDragDrop(listBoxItem, listBoxItem.DataContext, DragDropEffects.Move);
				}
			}
		}

		private void TileView_Drop(object sender, DragEventArgs e)
		{
			Datum droppedData = (Datum)e.Data.GetData(typeof(Datum));
			Datum target = (Datum)((ListBoxItem)(sender as ListBox).ItemContainerGenerator.ContainerFromItem((DependencyObject)e.OriginalSource)).DataContext;

			int removedIdx = Items.IndexOf(droppedData);
			int targetIdx = Items.IndexOf(target);

			if (removedIdx < targetIdx)
			{
				Items.Insert(targetIdx + 1, droppedData);
				Items.RemoveAt(removedIdx);
			}
			else
			{
				int removeIdx = removedIdx + 1;
				if (Items.Count + 1 > removeIdx)
				{
					Items.Insert(targetIdx, droppedData);
					Items.RemoveAt(removeIdx);
				}
			}
		}

		private void TileView_DragOver(object sender, DragEventArgs e)
		{
			e.Effects = DragDropEffects.Move;
		}

		private static T FindAncestor<T>(DependencyObject current) where T : DependencyObject
		{
			do
			{
				if (current is T)
				{
					return (T)current;
				}
				current = VisualTreeHelper.GetParent(current);
			}
			while (current != null);
			return null;
		}
	}
}
