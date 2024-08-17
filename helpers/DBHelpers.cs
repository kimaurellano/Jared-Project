using Jared.Model;
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

        public void InsertToSelectedPatientTable(Patient patient) {
            using (var connection = _connection) {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO SelectedPatient (Name) VALUES (@Name);";

                command.Parameters.AddWithValue("@Name", patient.Name);

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

        public DataTable SelectPatient(string name) {
            using (var connection = _connection) {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = $"SELECT * FROM Patient WHERE @Name=${name}";

                DataTable dataTable = new DataTable();

                using (var reader = command.ExecuteReader()) {
                    dataTable.Load(reader);
                }

                return dataTable;
            }
        }

        public void ClearSelectedPatient() {
            using (var connection = _connection) {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = $"DELETE FROM SelectedPatient";

                command.ExecuteNonQuery();
            }
        }

        // Selected Patient table will only contain 1 row of data always.
        public Patient GetSelectedPatient() {
            using (var connection = _connection) {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = $"SELECT * FROM SelectedPatient";

                DataTable dataTable = new DataTable();

                using (var reader = command.ExecuteReader()) {
                    dataTable.Load(reader);
                }

                Patient patient = new();
                if (dataTable.Rows.Count > 0) {
                    patient = CastRowToPatient(dataTable.Rows[0]);
                }

                return patient;
            }
        }

        private Patient CastRowToPatient(DataRow row) {
            return new Patient {
                Name = row["Name"].ToString(), // Assuming "Name" is the name of the column
            };
        }

    }
}
