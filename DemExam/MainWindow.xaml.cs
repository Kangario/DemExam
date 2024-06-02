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

namespace DemExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LogIn _logIn = new();
        private Main _main = new();
        public MainWindow()
        {
            InitializeComponent();
            MainContent.Content = _logIn;
            _logIn.LogInButton.Click += LogIn;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LogIn(object sender, RoutedEventArgs e)
        {
            MainContent.Content = _main;
        }
    }
}