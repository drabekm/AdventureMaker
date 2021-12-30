using AdventureCore.Helpers;
using AdventureCore.ViewModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace AdventureCore.Commands
{
    public class NavigateCommand : BaseCommand
    {
        protected readonly NavigationHelper _navigationHelper;
        public NavigateCommand(NavigationHelper navigationHelper)
        {
            _navigationHelper = navigationHelper;
        }

        public override bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public override void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
