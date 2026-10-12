using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using wpfWindow.pages;

namespace wpfWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainFrame.Navigate(new MainPage());
        }

        private void ShowMain_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainPage());
        }

        private void ShowCatalog_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CatalogPage());
        }

        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoForward) 
                MainFrame.GoForward();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack) 
                MainFrame.GoBack();
        }
    }
}