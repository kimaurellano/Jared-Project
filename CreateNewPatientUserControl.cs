using Jared.helpers;
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
    public partial class CreateNewPatientUserControl : UserControl {

        DBHelpers dBHelpers = new();

        public CreateNewPatientUserControl() {
            InitializeComponent();
        }

        private void BtnCreatePatient_Click(object sender, EventArgs e) {
            string name = TextBoxName.Text;
            dBHelpers.InsertPatient(name);

            MessageBox.Show("Patient created.");
        }
    }
}
