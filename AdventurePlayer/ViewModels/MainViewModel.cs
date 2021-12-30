using AdventureCore.Helpers;
using AdventureCore.ViewModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventurePlayer.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private readonly NavigationHelper _navigationHelper;

        public BaseViewModel CurrentViewModel => _navigationHelper.CurrentViewModel;

        public MainViewModel(NavigationHelper navigationHelper)
        {
            _navigationHelper = navigationHelper;

            _navigationHelper.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
