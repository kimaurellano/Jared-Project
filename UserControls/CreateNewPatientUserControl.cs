using Madentra.helpers;
using Madentra.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void RadioButton_CheckChanged(object sender, EventArgs e) {
            // Cast sender back to a RadioButton
            RadioButton rb = sender as RadioButton;

            // Check if the RadioButton is selected
            if (rb != null && rb.Checked) {
                sex = rb.Text;
            }
        }
    }
}
