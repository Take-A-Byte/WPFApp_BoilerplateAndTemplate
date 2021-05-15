namespace WpfApp1
{
    using System.Windows;
    using WpfApp1.ViewModels;
    using WpfApp1.Views;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Protected Methods

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainViewModel mainVM = new MainViewModel();
            MainWindow = new MainWindow() { DataContext = mainVM };
            MainWindow.Show();
        }

        #endregion Protected Methods
    }
}