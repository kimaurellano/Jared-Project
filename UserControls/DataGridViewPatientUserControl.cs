using System.ComponentModel;
using Jared.helpers;
using Jared.Model;
using System.Diagnostics;

namespace Jared.UserControls {
    public partial class DataGridViewPatientUserControl : UserControl, INotifyPropertyChanged {

        private DBHelpers dbHelpers = new();
        private string _selectedPatient = string.Empty;

        public event PropertyChangedEventHandler PropertyChanged;

        public string SelectedPatient {
            get { return _selectedPatient; }
            set {
                if (_selectedPatient != value) {
                    Debug.WriteLine($"{_selectedPatient} property changed.");
                    _selectedPatient = value;
                    OnPropertyChanged(nameof(SelectedPatient));
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            Debug.WriteLine($"property changed invoked.");
        }

        public DataGridViewPatientUserControl() {
            InitializeComponent();
            Debug.WriteLine($"{Name}");

            PopulatePatientDataGrid();
        }

        private void PopulatePatientDataGrid() {
            dataGridViewPatients.DataSource = dbHelpers.SelectPatients();
        }

        private void DataGridViewPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Patient patient = new();
            foreach (DataGridViewRow row in dataGridViewPatients.SelectedRows) {
                // Access data in the selected row.
                var cellValue = row.Cells["Id"].Value;
                patient.Id = (long)cellValue;
            }

            // Need to refresh the Selected Patient table.
            var checkSelectedPatient = dbHelpers.GetSelectedPatient();
            if (checkSelectedPatient != null) {
                dbHelpers.ClearSelectedPatient();
            }

            // Insert selected patient to SelectedPatient table.
            dbHelpers.InsertToSelectedPatientTable(patient);

            // Trigger the observer
            SelectedPatient = dbHelpers.GetSelectedPatient().Name;
        }
    }
}
