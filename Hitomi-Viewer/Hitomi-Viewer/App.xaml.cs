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
        public static Viewer.Views.ViewerWindow ViewerWindow;
        public static Services.JsonParser JsonParser;

        public App()
        {
            BrowserPage = new Browser.Views.BrowserPage();
            PreferencesPage = new Preferences.Views.PreferencesPage();
            ViewerWindow = new Viewer.Views.ViewerWindow();
            JsonParser = new Services.JsonParser();
        }
    }
}
