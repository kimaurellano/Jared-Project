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
    public partial class SearchPatientUserControl : UserControl {

        private DBHelpers dbHelpers = new();

        public SearchPatientUserControl() {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            PopulatePatientDataGrid();
        }

        private void PopulatePatientDataGrid() {
            dataGridView1.DataSource = dbHelpers.SelectPatients();
        }
    }
}
