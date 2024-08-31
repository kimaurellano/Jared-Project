using Madentra.helpers;
using System.ComponentModel;
using System.Diagnostics;

namespace Madentra {
    public partial class SelectedPersonUserControl : UserControl {

        private DBHelpers dbHelpers = new();

        public event PropertyChangedEventHandler PropertyChanged;

        public SelectedPersonUserControl() {
            InitializeComponent();
            Debug.WriteLine($"{Name}");
        }

        private void SelectedPersonUserControl_Load(object sender, EventArgs e) {
            //label1.Text = dbHelpers.GetSelectedPatient().Name;
        }

        private void SelectedPersonUserControl_Paint(object sender, PaintEventArgs e) {
            label1.Text = dbHelpers.GetSelectedPatient().Name;
        }
    }
}
