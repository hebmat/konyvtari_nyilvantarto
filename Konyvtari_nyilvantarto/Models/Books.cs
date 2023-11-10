using CommunityToolkit.Mvvm.ComponentModel;

namespace Konyvtari_nyilvantarto.Models
{
    class Books : ObservableObject
    {
        private string? title;
        private string? author;
        private string? category;
        private string? description;

        public string? Title 
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        public string? Author 
        { 
            get => author;
            set => SetProperty(ref author, value);
        }
        
        public string? Category 
        { 
            get => category;
            set => SetProperty(ref category, value);
        }
        public string? Description
        { 
            get => description;
            set => SetProperty(ref description, value);
        }

        public Books(string? title, string? author, string? category, string? description)
        {
            Title = title;
            Author = author;
            Category = category;
            Description = description;
        }

    }
}
