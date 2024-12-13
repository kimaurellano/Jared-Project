using Madentra.helpers;
using Madentra.Model;
using Madentra.UserControls;
using System.ComponentModel;
using System.Diagnostics;

namespace Madentra {
    public partial class CreateNewPatientUserControl : UserControl {

        private DBHelpers dBHelpers = new();
        private RadioButton radioButtonFemale => RadioButtonFemale;
        private RadioButton radioButtonMale => RadioButtonMale;
        private string fullName => TextBoxName.Text;
        private string phoneNumber => TextBoxPhoneNumber.Text;
        private string patientId => TextBoxIDCard.Text;

        private string sex;
        private string address => RichTextBoxAddress.Text;
        private string remarks => RichTextBoxRemarks.Text;

        private bool _patientCreated = false;

        private CreateNewPatientUserControl createNewPatientUserControl;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool PatientCreated {
            get { return _patientCreated; }
            set {
                if (_patientCreated != value) {
                    Debug.WriteLine($"{_patientCreated} property changed.");
                    _patientCreated = value;
                    OnPropertyChanged(nameof(PatientCreated));
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            Debug.WriteLine($"property changed invoked.");
        }

        public CreateNewPatientUserControl() {
            InitializeComponent();

            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            Dock = DockStyle.Fill;

            radioButtonFemale.CheckedChanged += RadioButton_CheckChanged;
            radioButtonMale.CheckedChanged += RadioButton_CheckChanged;

            Debug.WriteLine($"{Name}");
        }

        private void BtnCreatePatient_Click(object sender, EventArgs e) {
            Patient patient = new Patient {
                FullName = fullName,
                IdCard = patientId,
                PhoneNumber = Convert.ToInt64(phoneNumber),
                Sex = sex,
                Address = address,
                Remarks = remarks,
                CreationDate = DateTime.Now
            };
            dBHelpers.InsertPatient(patient);

            MessageBox.Show("Patient created.");

            ClearAllTextBoxes();

            PatientCreated = !PatientCreated;
        }

        private void RadioButton_CheckChanged(object sender, EventArgs e) {
            // Cast sender back to a RadioButton
            RadioButton rb = sender as RadioButton;

            // Check if the RadioButton is selected
            if (rb != null && rb.Checked) {
                sex = rb.Text;
            }
        }

        public void ClearAllTextBoxes() {
            // Recursively clear all textboxes in the UserControl
            ClearTextBoxesRecursive(this);
        }

        private void ClearTextBoxesRecursive(Control parent) {
            foreach (Control control in parent.Controls) {
                if (control is TextBox textBox) {
                    textBox.Text = ""; // Clear the text in the TextBox
                } else if (control.HasChildren) {
                    // Recursively call for child controls
                    ClearTextBoxesRecursive(control);
                }

                if (control is RadioButton radioButton) {
                    radioButton.Checked = false;
                }

                if (control is RichTextBox richTextBox) {
                    richTextBox.Text = "";
                }
            }
        }

        private void TextBoxIDCard_KeyPress(object sender, KeyPressEventArgs e) {
            // Allow only digits, control keys (e.g., backspace), and optionally a decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void TextBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e) {
            // Allow only digits, control keys (e.g., backspace), and optionally a decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void buttonClear_Click(object sender, EventArgs e) {
            ClearAllTextBoxes();
        }
    }
}
