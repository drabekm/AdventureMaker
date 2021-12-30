﻿using AdventureCore.Commands;
using AdventureCore.Helpers;
using AdventurePlayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace AdventurePlayer.Commands
{
    internal class NavigateToMainMenuCommand : NavigateCommand
    {
        public NavigateToMainMenuCommand(NavigationHelper navigationHelper) : base(navigationHelper)
        {

        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _navigationHelper.CurrentViewModel = new MainMenuViewModel(_navigationHelper);
        }
    }
}
