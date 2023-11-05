using CommunityToolkit.Mvvm.ComponentModel;
using Konyvtari_nyilvantarto.Models;
using System.Collections.ObjectModel;


namespace Konyvtari_nyilvantarto.ViewModels
{
    public class AddNewBookVM : ObservableObject
    {
        private readonly MenuID _menuId;
        public ObservableCollection<MenuItemCommand> MenuItemCommands { get; } = new ObservableCollection<MenuItemCommand>();

        public AddNewBookVM()
        {
            _menuId = new MenuID("Add"); // Példaként "Add" azonosítót adtunk meg

            // MenuItemCommand inicializálása és hozzárendelése a MenuID-hoz
            MenuItemCommands.Add(new MenuItemCommand(OpenAddNewBookView, _menuId));
            // Egyéb menüparancsok inicializálása
            // ...
        }

        private void OpenAddNewBookView(string menuItemId)
        {
            // Az adott menüelemhez tartozó műveletek
            if (_menuId.Id == menuItemId)
            {
                // Ide add a kívánt műveleteket az adott menüelem esetén
            }
        }
    }

}
