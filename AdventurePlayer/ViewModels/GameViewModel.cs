using AdventureCore.Helpers;
using AdventureCore.ViewModels.Models;
using AdventurePlayer.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace AdventurePlayer.ViewModels
{
    internal class GameViewModel : BaseViewModel
    {
        public GameViewModel(NavigationHelper navigationHelper)
        {
            NavigateToMainMenuCommand = new NavigateToMainMenuCommand(navigationHelper);
        }

        public ICommand NavigateToMainMenuCommand { get; }

    }
}
