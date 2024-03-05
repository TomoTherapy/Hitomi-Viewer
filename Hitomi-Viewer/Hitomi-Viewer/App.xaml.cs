using System.Windows;

namespace Hitomi_Viewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Browser.Views.BrowserPage BrowserPage;
        public static Preferences.Views.PreferencesPage PreferencesPage;
        public static Viewer.Views.PageViewerWindow PageViewerWindow;
		public static Viewer.Views.ScrollViewerWindow ScrollViewerWindow;
		public static Services.JsonParser JsonParser;

        public App()
        {
            BrowserPage = new Browser.Views.BrowserPage();
            PreferencesPage = new Preferences.Views.PreferencesPage();
			PageViewerWindow = new Viewer.Views.PageViewerWindow();
			ScrollViewerWindow = new Viewer.Views.ScrollViewerWindow();
			JsonParser = new Services.JsonParser();
        }

		public static void Dispose()
		{
			PageViewerWindow.Close();
			ScrollViewerWindow.Close();
		}
    }
}
