using System.Configuration;
using System.Data;
using System.Windows;

namespace topMedic.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //StartupUri="/Views/Login.xaml"

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e); // initialise l'application

            Window window = new MainWindow();
            window.Show();
   
        }

     

    }

}
