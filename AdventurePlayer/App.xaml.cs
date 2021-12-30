using AdventureCore.Helpers;
using AdventurePlayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AdventurePlayer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationHelper navigationHelper = new NavigationHelper();
            navigationHelper.CurrentViewModel = new MainMenuViewModel(navigationHelper);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigationHelper),
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
