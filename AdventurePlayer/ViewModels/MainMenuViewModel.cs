﻿using AdventureCore.Helpers;
using AdventureCore.ViewModels.Models;
using AdventurePlayer.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace AdventurePlayer.ViewModels
{
    internal class MainMenuViewModel : BaseViewModel
    {
        public MainMenuViewModel(NavigationHelper navigationHelper)
        {
            StartGameCommand = new StartGameCommand(navigationHelper);
        }

        public ICommand StartGameCommand { get; }
    }
}
