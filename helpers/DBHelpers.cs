using Microsoft.Data.Sqlite;
using System.Data;
using System.Xml.Linq;

namespace Jared.helpers {
    internal class DBHelpers {

        private static readonly SqliteConnection _connection = new($"Data Source=C:\\Users\\kimau\\Documents\\Visual Studio 2022\\Projects\\Jared\\jared.db");

        public void InsertPatient(string name) {
            using (var connection = _connection) {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO Patient (Name) VALUES (@Name);";

                command.Parameters.AddWithValue("@Name", name);

                command.ExecuteNonQuery();
            }
        }

        public DataTable SelectPatients() {
            using (var connection = _connection) {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Patient";

                DataTable dataTable = new DataTable();

                using (var reader = command.ExecuteReader()) {
                    dataTable.Load(reader);
                }

                return dataTable;
            }
        }
    }
}
