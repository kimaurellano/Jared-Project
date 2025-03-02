using System.ComponentModel;
using Madentra.helpers;
using Madentra.Model;
using System.Diagnostics;

namespace Madentra.UserControls {
    public partial class DataGridViewPatientUserControl : UserControl, INotifyPropertyChanged {

        private DBHelpers dbHelpers = new();
        private string _selectedPatient = string.Empty;
        private long _patientId;

        private DataGridViewPatientUserControl dataGridViewPatientUserControl;

        public event PropertyChangedEventHandler PropertyChanged;

        public string SelectedPatient {
            get { return _selectedPatient; }
            set {
                if (_selectedPatient != value) {
                    TraceLogger.TraceMessage($"{_selectedPatient} property changed.");
                    _selectedPatient = value;
                    // Propagates change event to SelectedPatient
                    OnPropertyChanged(nameof(SelectedPatient));
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            TraceLogger.TraceMessage($"property changed invoked.");
        }

        public DataGridViewPatientUserControl() {
            InitializeComponent();
            TraceLogger.TraceMessage($"{Name}");

            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            Dock = DockStyle.Fill;

            PopulatePatientDataGrid();
        }

        public void PopulatePatientDataGrid() {
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
                    dbHelpers.DeleteSelectedPatient();
                }

                // Insert selected patient to SelectedPatient table.
                dbHelpers.InsertToSelectedPatientTable(patient);

                // Trigger the observer
                SelectedPatient = dbHelpers.GetSelectedPatient().FullName;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show(
                "You are permanently deleting this Patient's record. Are you sure?",
                "Record Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes) {
                dbHelpers.DeletePatient(_patientId);
                PopulatePatientDataGrid();
            }
        }

        private void dataGridViewPatients_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) { // Ensures the click wasn't on the header row
                Patient patient = new();

                // Get the selected row and cell value
                var selectedRow = ((DataGridView)sender).Rows[e.RowIndex];
                _patientId = (long)selectedRow.Cells["Id"].Value;
            }
        }

        private void TextBoxSearchPatientName_TextChanged(object sender, EventArgs e) {
            string patientName = TextBoxSearchPatientName.Text;
            dataGridViewPatients.DataSource = dbHelpers.SelectPatient(patientName);
        }
    }
}
