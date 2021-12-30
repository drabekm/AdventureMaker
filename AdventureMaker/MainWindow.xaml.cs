using AdventureCore.Models;
using AdventureMaker.Helpers;
using AdventureMaker.ViewModels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdventureMaker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public RoomEditorViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new RoomEditorViewModel();
            this.DataContext = viewModel;
        }

        private void AddItemCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            int newID = 1;
            if (viewModel.Items != null && viewModel.Items.Any())
            {
                newID = viewModel.Items.LastOrDefault().ItemID + 1;
            }
            var newItem = new Item() { ItemDescription = "New description", ItemID = newID, ItemName = $"New item {newID}" };
            viewModel.Items.Add(newItem);
            viewModel.CurrentItem = newItem;
        }

        private void AddItemCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void RemoveItemCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (lbItems != null)
            {
                e.CanExecute = lbItems.SelectedItem != null;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void RemoveItemCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var selectedItem = lbItems.SelectedItem;
            if (selectedItem != null && selectedItem is Item)
            {
                viewModel.Items 
                    
                     .Remove(selectedItem as Item);
            }
        }

        private void lbRooms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            viewModel.CurrentRoom = (Room)lbRooms.SelectedItem;
        }

    }
}
