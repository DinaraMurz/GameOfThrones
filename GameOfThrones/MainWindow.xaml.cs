
using Gecko;
using System.Windows;
using System.Windows.Forms.Integration;

namespace GeckoWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Gecko.Xpcom.Initialize("Firefox");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WindowsFormsHost host = new WindowsFormsHost();
            GeckoWebBrowser browser = new GeckoWebBrowser();
            host.Child = browser;
            GridWeb.Children.Add(host);
            browser.Navigate("http://viewers-guide.hbo.com/game-of-thrones/season-6/episode-10/map/location/77/bay-of-dragons");
        }


    }
}