using Hitomi_Viewer.Browser.Views;
using Hitomi_Viewer.Viewer.Views;
using System.Windows;

namespace Hitomi_Viewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // browser
        public static BrowserPage BrowserPage;
        public static ListBrowserUserControl ListBrowserUserControl;
        public static TileBrowserUserControl TileBrowserUserControl;

        // viewer
        public static Viewer.Views.ViewerWindow ViewerWindow;
		public static Viewer.Views.ScrollViewerUserControl ScrollViewerUserControl;
        public static Viewer.Views.PageViewerUserControl PageViewerUserControl;

        // preferences
        public static Preferences.Views.PreferencesPage PreferencesPage;

        // etc
		public static Services.JsonParser JsonParser;

        public App()
        {
            BrowserPage = new BrowserPage();
            ListBrowserUserControl = new ListBrowserUserControl();
            TileBrowserUserControl = new TileBrowserUserControl();

            ViewerWindow = new Viewer.Views.ViewerWindow();
            ScrollViewerUserControl = new ScrollViewerUserControl();
            PageViewerUserControl = new PageViewerUserControl();

            PreferencesPage = new Preferences.Views.PreferencesPage();
			JsonParser = new Services.JsonParser();
        }

		public static void Dispose()
		{
			ViewerWindow.Close();
		}
    }
}
