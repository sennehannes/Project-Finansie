using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Project_Finansie.HulpClassen
{
    public static class ViewModelHelper
    {
        private static void Close()
        {
            var w = Application.Current.Windows[0];
            w.Close();
        }

        public static void ShowVieuw(object parameter)
        {
            switch (parameter)
            {
                case "Betalingen": ShowBetalingenView(); break;
                case "Geschiedenis": ShowGeschiednisView(); break;
                case "HomePage": ShowHomePageView(); break;
                case "Ontvangste": ShowOntvangsteView(); break;
                default:
                    break;
            }
        }


        public static void ShowGeschiednisView()
        {
            Views.Geschiedenis bindingNaarCollectionWindow = new Views.Geschiedenis();
            ViewModels.GeschiedenisViewModel vm = new ViewModels.GeschiedenisViewModel();
            bindingNaarCollectionWindow.DataContext = vm;
            bindingNaarCollectionWindow.Show();
            Close();
        }

        public static void ShowBetalingenView()
        {
            Views.Betalingen bindingNaarCollectionWindow = new Views.Betalingen();
            ViewModels.BetalingenViewModel vm = new ViewModels.BetalingenViewModel();
            bindingNaarCollectionWindow.DataContext = vm;
            bindingNaarCollectionWindow.Show();
            Close();
        }

        public static void ShowHomePageView()
        {
            Views.HomePage bindingNaarCollectionWindow = new Views.HomePage();
            ViewModels.HomePageViewModel vm = new ViewModels.HomePageViewModel();
            bindingNaarCollectionWindow.DataContext = vm;
            bindingNaarCollectionWindow.Show();
            Close();
        }

        public static void ShowOntvangsteView()
        {
            Views.Ontvangste bindingNaarCollectionWindow = new Views.Ontvangste();
            ViewModels.OntvangsteViewModel vm = new ViewModels.OntvangsteViewModel();
            bindingNaarCollectionWindow.DataContext = vm;
            bindingNaarCollectionWindow.Show();
            Close();
        }
    }
}
