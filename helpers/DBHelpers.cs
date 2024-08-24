using Jared.Model;
using Microsoft.Data.Sqlite;
using System.Data;
using System.Drawing.Imaging;
using System.Xml.Linq;

namespace Jared.helpers {
    internal class DBHelpers {

        private static readonly SqliteConnection _connection = new($"Data Source=C:\\Users\\USER\\Documents\\Visual Studio 2022\\Project\\Jared\\jared.db");

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

        public void SaveImageToDatabase(Image image) {
            // Convert the image to a byte array
            byte[] imageBytes = ImageToByteArray(image);

            using (var connection = _connection) {
                Patient patient = GetSelectedPatient();

                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO PatientImage (PatientId,PatientImage) VALUES (@PatientId,@ImageData)";
                command.Parameters.AddWithValue("@PatientId", patient.Id);
                // Use a parameter to insert the byte array into the BLOB column
                command.Parameters.AddWithValue("@ImageData", imageBytes);
                command.ExecuteNonQuery();
            }
        }

        private byte[] ImageToByteArray(Image image) {
            using (MemoryStream memoryStream = new()) {
                image.Save(memoryStream, ImageFormat.Png); // Save image as PNG format in the stream
                return memoryStream.ToArray(); // Convert stream to byte array
            }
        }

        public DataTable SelectPatients() {
            using (var connection = _connection) {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Patient";

                DataTable dataTable = new();

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

                DataTable dataTable = new();

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

        /// <summary>
        /// Selected Patient table will only contain 1 row of data always.
        /// </summary>
        public Patient GetSelectedPatient() {
            using (var connection = _connection) {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = $"SELECT * FROM SelectedPatient";

                DataTable dataTable = new();

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
                Id = (long) row["Id"],
                Name = row["Name"].ToString() // Assuming "Name" is the name of the column
            };
        }

    }
}
