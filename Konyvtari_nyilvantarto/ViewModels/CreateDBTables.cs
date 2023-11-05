using Microsoft.Data.Sqlite;

namespace Konyvtari_nyilvantarto.ViewModels
{
    public class CreateDBTable
    {
        private const string DatabaseName = "Database";
        private const string ConnectionString = "Data Source=F:\\suli\\Projectmunka\\" + DatabaseName;

        public void InitializeDatabase()
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                var createTableCommand = connection.CreateCommand();
                createTableCommand.CommandText = "CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY, FirstName TEXT, LastName TEXT, DateOfBirth DATE)";
                createTableCommand.ExecuteNonQuery();
                createTableCommand.CommandText = "CREATE TABLE IF NOT EXISTS Books (Id INTEGER PRIMARY KEY, Name TEXT, Author TEXT, Category TEXT, Description TEXT)";
                createTableCommand.ExecuteNonQuery();
                createTableCommand.CommandText = "CREATE TABLE IF NOT EXISTS RentedBooks (Id INTEGER PRIMARY KEY, Book_id INTEGER, User_id INTEGER, LoanStartDate DATE, LoanEndDate DATE, FOREIGN KEY(Book_id) REFERENCES Books(Id))";
                createTableCommand.ExecuteNonQuery();
              


            }
        }
    }
}
