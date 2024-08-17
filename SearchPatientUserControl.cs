using Jared.helpers;
using Jared.Model;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jared {
    public partial class SearchPatientUserControl : UserControl {

        private Patient patient = new();
        private DBHelpers dbHelpers = new();

        public SearchPatientUserControl() {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            PopulatePatientDataGrid();
        }

        private void PopulatePatientDataGrid() {
            dataGridViewPatients.DataSource = dbHelpers.SelectPatients();
        }

        private void DataGridViewPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            foreach (DataGridViewRow row in dataGridViewPatients.SelectedRows) {
                // Access data in the selected row.
                var cellValue = row.Cells["Name"].Value;
                patient.Name = (string)cellValue;
            }

            // Need to refresh the Selected Patient table.
            var checkSelectedPatient = dbHelpers.GetSelectedPatient();
            if (checkSelectedPatient != null) {
                dbHelpers.ClearSelectedPatient();
            }

            // Insert selected patient to SelectedPatient table.
            dbHelpers.InsertToSelectedPatientTable(patient);

            ShowContentInTabPatients(new SelectedPersonUserControl());
        }

        private void ShowContentInTabPatients(UserControl userControl) {
            Panel panel = MainPanelSearchPatient;
            panel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel.Controls.Add(userControl);
        }
    }
}
