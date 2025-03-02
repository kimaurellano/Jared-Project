using Madentra.helpers;
using Madentra.Model;
using System.ComponentModel;
using System.Diagnostics;

namespace Madentra {
    public partial class SelectedPersonUserControl : UserControl {

        private DBHelpers dbHelpers = new();

        public event PropertyChangedEventHandler PropertyChanged;

        public SelectedPersonUserControl() {
            InitializeComponent();
            TraceLogger.TraceMessage($"{Name}");

            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            Dock = DockStyle.Fill;
        }

        private void SelectedPersonUserControl_Load(object sender, EventArgs e) {
            //label1.Text = dbHelpers.GetSelectedPatient().Name;
        }

        private void SelectedPersonUserControl_Paint(object sender, PaintEventArgs e) {
            Patient patient = dbHelpers.GetSelectedPatient() as Patient;
            LabelSelectedPatient.Text = patient.FullName;
            LabelGender.Text = patient.Sex;
            LabelIDCard.Text = patient.IdCard;
            LabelPhoneNumber.Text = patient.PhoneNumber.ToString();
            LabelAddress.Text = patient.Address;
            LabelRemarks.Text = patient.Remarks;
        }
    }
}
