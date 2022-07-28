using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Project_Finansie
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {

            Views.HomePage view = new Views.HomePage();
            ViewModels.HomePageViewModel vm = new ViewModels.HomePageViewModel();
            view.DataContext = vm;
            view.Show();
        }
    }
}
