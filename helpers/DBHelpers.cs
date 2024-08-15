using Microsoft.Data.Sqlite;

namespace Jared.helpers {
    internal class DBHelpers {

        private static readonly SqliteConnection _connection = new($"Data Source=C:\\Users\\kimau\\Documents\\Visual Studio 2022\\Projects\\Jared\\jared.db");

        public void InsertUser(string name) {
            using (var connection = _connection) {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO Patient (Name) VALUES (@Name);";

                command.Parameters.AddWithValue("@Name", name);

                command.ExecuteNonQuery();

                MessageBox.Show("Inserted.");
            }
        }
    }
}
