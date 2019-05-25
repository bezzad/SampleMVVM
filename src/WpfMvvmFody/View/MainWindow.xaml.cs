using System.Windows;
using System.Windows.Controls;

namespace WpfMvvmFody.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListViewEmployeeDetails_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
