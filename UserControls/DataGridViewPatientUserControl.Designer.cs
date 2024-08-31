namespace Jared.UserControls {
    partial class DataGridViewPatientUserControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            dataGridViewPatients = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPatients
            // 
            dataGridViewPatients.AllowUserToAddRows = false;
            dataGridViewPatients.AllowUserToDeleteRows = false;
            dataGridViewPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPatients.Dock = DockStyle.Fill;
            dataGridViewPatients.Location = new Point(0, 0);
            dataGridViewPatients.Name = "dataGridViewPatients";
            dataGridViewPatients.ReadOnly = true;
            dataGridViewPatients.RowHeadersWidth = 82;
            dataGridViewPatients.Size = new Size(1086, 926);
            dataGridViewPatients.TabIndex = 0;
            // 
            // DataGridViewPatientUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewPatients);
            Name = "DataGridViewPatientUserControl";
            Size = new Size(1086, 926);
            Paint += DataGridViewPatientUserControl_Paint;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPatients;
    }
}
