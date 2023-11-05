using CommunityToolkit.Mvvm.ComponentModel;

namespace Konyvtari_nyilvantarto.Models
{
    public class MenuID : ObservableObject
    {
        private string? _id;
        public string? Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        public MenuID(string id)
        {
            Id = id;
        }
    }
}

