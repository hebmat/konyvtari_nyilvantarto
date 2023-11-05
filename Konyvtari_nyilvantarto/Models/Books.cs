using CommunityToolkit.Mvvm.ComponentModel;

namespace Konyvtari_nyilvantarto.Models
{
    class Books : ObservableObject
    {
        public string? title;
        public string? author;
        public string? category;
        public string? description;
    }
}
