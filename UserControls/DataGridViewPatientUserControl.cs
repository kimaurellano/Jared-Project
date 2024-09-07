using System.ComponentModel;
using Madentra.helpers;
using Madentra.Model;
using System.Diagnostics;

namespace Madentra.UserControls {
    public partial class DataGridViewPatientUserControl : UserControl, INotifyPropertyChanged {

        private DBHelpers dbHelpers = new();
        private string _selectedPatient = string.Empty;

        private DataGridViewPatientUserControl dataGridViewPatientUserControl;

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

            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            Dock = DockStyle.Fill;

            PopulatePatientDataGrid();
        }

        private void PopulatePatientDataGrid() {
            dataGridViewPatients.DataSource = dbHelpers.SelectPatients();
        }

        private void DataGridViewPatientUserControl_Paint(object sender, PaintEventArgs e) {
            PopulatePatientDataGrid();
        }

        private void DataGridViewPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) { // Ensures the click wasn't on the header row
                Patient patient = new();

                // Get the selected row and cell value
                var selectedRow = ((DataGridView)sender).Rows[e.RowIndex];
                patient.Id = (long)selectedRow.Cells["Id"].Value;

                // Need to refresh the Selected Patient table.
                var checkSelectedPatient = dbHelpers.GetSelectedPatient();
                if (checkSelectedPatient != null) {
                    dbHelpers.ClearSelectedPatient();
                }

                // Insert selected patient to SelectedPatient table.
                dbHelpers.InsertToSelectedPatientTable(patient);

                // Trigger the observer
                SelectedPatient = dbHelpers.GetSelectedPatient().FullName;
            }
        }
    }
}
