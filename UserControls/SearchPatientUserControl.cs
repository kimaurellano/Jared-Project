using Madentra.helpers;
using Madentra.UserControls;
using System.ComponentModel;
using System.Diagnostics;

namespace Madentra {
    public partial class SearchPatientUserControl : UserControl {

        private SelectedPersonUserControl selectedPersonUserControl;
        public DataGridViewPatientUserControl DataGridViewPatientUserControlInstance { get; private set; }

        public SearchPatientUserControl() {
            InitializeComponent();
            Debug.WriteLine($"{Name}");

            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            Dock = DockStyle.Fill;

            selectedPersonUserControl = new SelectedPersonUserControl();
            DataGridViewPatientUserControlInstance = new DataGridViewPatientUserControl();

            SearchPatientParentPanel.Controls.Add(DataGridViewPatientUserControlInstance);
            SearchPatientParentPanel.Controls.Add(selectedPersonUserControl);

            ShowContentInTabPatients(DataGridViewPatientUserControlInstance);

            DataGridViewPatientUserControlInstance.PropertyChanged += SelectedPatient_PropertyChanged;
        }

        private void SelectedPatient_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == nameof(DataGridViewPatientUserControl.SelectedPatient)) {
                ShowContentInTabPatients(selectedPersonUserControl);
            }
        }

        private void ShowContentInTabPatients(UserControl userControl) {
            Panel panel = SearchPatientParentPanel;
            if (panel != null) {
                foreach (Control control in panel.Controls) {
                    // Check if usercontrol exists in the panel
                    if (userControl.Name == control.Name) {
                        ShowControl(userControl, panel);

                        return;
                    }
                }

                // Only add usercontrol if does not exists in the panel
                panel.Controls.Add(userControl);
            }
        }

        private void ShowControl(Control controlToShow, Panel ofPanel) {
            // Loop through all controls in the panel
            foreach (Control control in ofPanel.Controls) {
                control.Visible = false; // Hide all controls
            }

            // Show the selected control
            controlToShow.Visible = true;
            controlToShow.BringToFront(); // Bring the control to the front if needed
        }

        public void ShowDefaultPanel() {
            ShowContentInTabPatients(DataGridViewPatientUserControlInstance);
        }

        public void ShowSelectedPatientPanel() {
            ShowContentInTabPatients(selectedPersonUserControl);
        }
    }
}
