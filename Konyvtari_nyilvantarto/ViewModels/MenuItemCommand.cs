using Konyvtari_nyilvantarto.Models;
using System;
using System.Windows.Input;

namespace Konyvtari_nyilvantarto.ViewModels
{
    public class MenuItemCommand : ICommand
    {
        private readonly Action<string> _execute;
        private readonly MenuID _menuId;

        public MenuItemCommand(Action<string> execute, MenuID menuId)
        {
            _execute = execute;
            _menuId = menuId;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is string menuItemId)
            {
                _menuId.Id = menuItemId;
                _execute?.Invoke(menuItemId);
            }
        }
    }

}
