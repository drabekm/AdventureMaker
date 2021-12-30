using AdventureCore.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AdventureMaker.UserControls
{
    /// <summary>
    /// Interaction logic for NextRoomSelector.xaml
    /// </summary>
    public partial class NextRoomSelector : UserControl
    {
        public NextRoomSelector()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty SelectedRoomProperty =
        DependencyProperty.Register("SelectedRoom", typeof(Room), typeof(NextRoomSelector));

        public Room SelectedRoom
        {
            get { return (Room)GetValue(SelectedRoomProperty); }
            set { SetValue(SelectedRoomProperty, value); }
        }

        private void ClearComboBox_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = cmRoomSelect.SelectedItem != null;
        }

        private void ClearComboBox_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            cmRoomSelect.SelectedItem = null;
        }
    }
}
