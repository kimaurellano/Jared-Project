using Jared.helpers;
using Jared.Model;
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
    public partial class SelectedPersonUserControl : UserControl {

        private DBHelpers dbHelpers = new();

        public SelectedPersonUserControl() {
            InitializeComponent();

            // Select query the SelectedPatient table
            Patient patient = dbHelpers.GetSelectedPatient();

            label1.Text = patient.Name;
        }
    }
}
