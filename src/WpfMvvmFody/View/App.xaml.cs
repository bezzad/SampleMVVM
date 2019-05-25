using System.Windows;
using WpfMvvmFody.ViewModel;

namespace WpfMvvmFody.View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow window = new MainWindow();
            ProductViewModel VM = new ProductViewModel();
            window.DataContext = VM;
            window.Show();
        }
    }
}
