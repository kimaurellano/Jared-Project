using Madentra.Model;
using Microsoft.Data.Sqlite;
using System.Data;
using System.Drawing.Imaging;
using System.Reflection.Metadata;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Madentra.helpers {
    internal class DBHelpers {

        private static readonly SqliteConnection _connection = new($"Data Source=C:\\Users\\USER\\Documents\\Visual Studio 2022\\Project\\Jared\\jared.db");

        public void InsertPatient(string name) {
            using (var connection = _connection) {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = 
                    $"INSERT INTO Patient (Name,CreationDate) " +
                    $"VALUES ('{name}','{DateTime.Now}');";
                command.ExecuteNonQuery();
            }
        }

        public void InsertToSelectedPatientTable(Patient patient) {
            using (var connection = _connection) {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                    $"INSERT INTO SelectedPatient (PatientId,CreationDate) " +
                    $"VALUES ('{patient.Id}','{DateTime.Now}');";

                command.Parameters.AddWithValue("@PatientId", patient.Id);

                command.ExecuteNonQuery();
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

        public Patient SelectPatient(long patientId) {
            using (var connection = _connection) {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = $"SELECT * FROM Patient WHERE @Id=${patientId}";

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
                command.CommandText =
                    $"SELECT Patient.Id, Patient.name FROM Patient " +
                    $"LEFT JOIN SelectedPatient " +
                    $"ON Patient.Id = SelectedPatient.PatientId " +
                    $"WHERE SelectedPatient.PatientId NOT NULL";

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

        public void SaveImageToDatabase(Image image) {
            // Convert the image to a byte array
            ImageHelper imageHelper = new();
            byte[] imageBytes = imageHelper.ImageToByteArray(image);

            using (var connection = _connection) {
                // Get what is the current selected patient
                Patient patient = GetSelectedPatient();

                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = 
                    $"INSERT INTO PatientImage (PatientId,PatientImage) " +
                    $"VALUES (@PatientId,@ImageData)";
                command.Parameters.AddWithValue("@PatientId", patient.Id);
                // Use a parameter to insert the byte array into the BLOB column
                command.Parameters.AddWithValue("@ImageData", imageBytes);
                command.ExecuteNonQuery();
            }
        }

        public List<Image> GetAllImages() {
            ImageHelper imageHelper = new();
            List<Image> imageList = new();
            using (var connection = _connection) {
                _connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                    $"SELECT PatientImage FROM PatientImage";

                using (var reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        // Get the BLOB data from the reader
                        byte[] imageData = (byte[])reader["PatientImage"];

                        Image byteImage = imageHelper.ByteToImage(imageData);
                        
                        // Add the Image to the ImageList
                        imageList.Add(byteImage);
                    }
                }
            }

            return imageList;
        }

        public List<Image> GetImagesOfPatient(long patientId) {
            ImageHelper imageHelper = new();
            List<Image> imageList = new List<Image>();
            using (var connection = _connection) {
                _connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = 
                    $"SELECT PatientImage FROM PatientImage " +
                    $"WHERE PatientId = {patientId}";

                using (var reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        // Get the BLOB data from the reader
                        byte[] imageData = (byte[])reader["PatientImage"];

                        Image byteImage = imageHelper.ByteToImage(imageData);

                        imageList.Add(byteImage);
                    }
                }
            }

            return imageList;
        }

        public Image GetImage(long imageId) {
            Image image = null;
            ImageHelper imageHelper = new();
            using (var connection = _connection) {
                _connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                    $"SELECT PatientImage FROM PatientImage " +
                    $"WHERE Id = {imageId}";

                using (var reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        // Get the BLOB data from the reader
                        byte[] imageData = (byte[])reader["PatientImage"];

                        image = imageHelper.ByteToImage(imageData);
                    }
                }

                return image;
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
