using System;
using System.Windows.Input;

namespace TestApp.ViewModal.Commands
{
public class NavigationCommands:ICommand
{


        public HomeVM HomeViewModal { get; set; }

        public NavigationCommands(HomeVM homeVM)
        {
            HomeViewModal = homeVM;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            HomeViewModal.Navigate();
        }
    }
}
