using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace WpfIconButtonDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var colors = typeof(Colors).GetProperties().Select(x => x.Name);
            BackgroundColorPicker.ItemsSource = colors;
            ForegroundColorPicker.ItemsSource = colors;
        }
    }
}
