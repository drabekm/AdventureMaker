using AdventureCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventurePlayer.Commands
{
    internal class CloseProgramCommand : BaseCommand
    {
        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
