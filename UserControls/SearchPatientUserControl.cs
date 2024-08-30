using Jared.UserControls;
using System.Diagnostics;

namespace Jared {
    public partial class SearchPatientUserControl : UserControl {

        private SelectedPersonUserControl selectedPersonUserControl;
        public DataGridViewPatientUserControl DataGridViewPatientUserControlInstance { get; private set; }

        public SearchPatientUserControl() {
            InitializeComponent();
            Debug.WriteLine($"{Name}");

            selectedPersonUserControl = new SelectedPersonUserControl();
            DataGridViewPatientUserControlInstance = new DataGridViewPatientUserControl();

            SearchPatientSubPanel.Controls.Add(DataGridViewPatientUserControlInstance);
            SearchPatientSubPanel.Controls.Add(selectedPersonUserControl);

            ShowContentInTabPatients(DataGridViewPatientUserControlInstance);
        }

        private void ShowContentInTabPatients(UserControl userControl) {
            Panel panel = SearchPatientSubPanel;
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
    }
}
