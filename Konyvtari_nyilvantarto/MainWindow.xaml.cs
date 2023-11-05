using Konyvtari_nyilvantarto.View;
using Konyvtari_nyilvantarto.ViewModels;
using System.Windows;

namespace Konyvtari_nyilvantarto
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateDBTable databaseManager = new CreateDBTable();
            databaseManager.InitializeDatabase();
       

            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AddNewBookView addNewBookView = new AddNewBookView();
            CC.Content = addNewBookView;
        }
    }

}
