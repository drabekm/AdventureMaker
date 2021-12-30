using AdventureCore.Commands;
using AdventureCore.Helpers;
using AdventurePlayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace AdventurePlayer.Commands
{
    internal class StartGameCommand : NavigateCommand
    {
        public StartGameCommand(NavigationHelper navigationHelper) : base(navigationHelper)
        {

        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            _navigationHelper.CurrentViewModel = new GameViewModel(_navigationHelper);
        }
    }
}

