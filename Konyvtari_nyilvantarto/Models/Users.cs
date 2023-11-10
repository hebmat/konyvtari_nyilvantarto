using CommunityToolkit.Mvvm.ComponentModel;

namespace Konyvtari_nyilvantarto.Models
{
    public class Users : ObservableObject
    {
        private string? firstName;
        private string? lastName ;
        private string? dateOfBirth ;

        public string? FirstName 
        {
            get => firstName; 
            set => SetProperty(ref firstName, value); 
        }

        public string? LastName
        {
            get => lastName; 
            set => SetProperty(ref lastName, value); 
        }
        public string? DateOfBirth
        {
            get => dateOfBirth; 
            set => SetProperty(ref dateOfBirth, value); 
        }

        public Users(string? firstName, string? lastName, string? dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
    }
}

