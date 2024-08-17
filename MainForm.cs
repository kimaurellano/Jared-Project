using Microsoft.Data.Sqlite;
using System.Data;
using System.Windows.Forms;

namespace Jared {
    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
        }

        private void BtnCreateNewPatient_Click(object sender, EventArgs e) {
            ShowContentInTabPatients(new CreateNewPatientUserControl());
        }

        private void BtnSearchPatient_Click_1(object sender, EventArgs e) {
            ShowContentInTabPatients(new SearchPatientUserControl());
        }

        private void ShowContentInTabPatients(UserControl userControl) {
            Panel patientsPanel = PanelPatients;
            patientsPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            patientsPanel.Controls.Add(userControl);
        }
    }
}
