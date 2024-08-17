namespace Jared {
    partial class SearchPatientUserControl {
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
            TextBoxSearchPatientName = new TextBox();
            panel1 = new Panel();
            ButtonSelectedPatient = new Button();
            MainPanelSearchPatient = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).BeginInit();
            panel1.SuspendLayout();
            MainPanelSearchPatient.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPatients
            // 
            dataGridViewPatients.AllowUserToAddRows = false;
            dataGridViewPatients.AllowUserToResizeColumns = false;
            dataGridViewPatients.AllowUserToResizeRows = false;
            dataGridViewPatients.BackgroundColor = Color.White;
            dataGridViewPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPatients.Dock = DockStyle.Fill;
            dataGridViewPatients.GridColor = Color.WhiteSmoke;
            dataGridViewPatients.Location = new Point(0, 43);
            dataGridViewPatients.Name = "dataGridViewPatients";
            dataGridViewPatients.ReadOnly = true;
            dataGridViewPatients.RowHeadersVisible = false;
            dataGridViewPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPatients.Size = new Size(706, 495);
            dataGridViewPatients.TabIndex = 1;
            dataGridViewPatients.CellDoubleClick += dataGridViewPatients_CellDoubleClick;
            // 
            // TextBoxSearchPatientName
            // 
            TextBoxSearchPatientName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TextBoxSearchPatientName.Location = new Point(14, 10);
            TextBoxSearchPatientName.Name = "TextBoxSearchPatientName";
            TextBoxSearchPatientName.PlaceholderText = "Search Patient";
            TextBoxSearchPatientName.Size = new Size(100, 23);
            TextBoxSearchPatientName.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ButtonSelectedPatient);
            panel1.Controls.Add(TextBoxSearchPatientName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 43);
            panel1.TabIndex = 3;
            // 
            // ButtonSelectedPatient
            // 
            ButtonSelectedPatient.Location = new Point(507, 10);
            ButtonSelectedPatient.Name = "ButtonSelectedPatient";
            ButtonSelectedPatient.Size = new Size(184, 23);
            ButtonSelectedPatient.TabIndex = 3;
            ButtonSelectedPatient.Text = "Mark as Selected Patient";
            ButtonSelectedPatient.UseVisualStyleBackColor = true;
            ButtonSelectedPatient.Click += ButtonSelectedPatient_Click;
            // 
            // MainPanelSearchPatient
            // 
            MainPanelSearchPatient.BackColor = Color.Transparent;
            MainPanelSearchPatient.Controls.Add(dataGridViewPatients);
            MainPanelSearchPatient.Controls.Add(panel1);
            MainPanelSearchPatient.Dock = DockStyle.Fill;
            MainPanelSearchPatient.Location = new Point(0, 0);
            MainPanelSearchPatient.Name = "MainPanelSearchPatient";
            MainPanelSearchPatient.Size = new Size(706, 538);
            MainPanelSearchPatient.TabIndex = 4;
            // 
            // SearchPatientUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainPanelSearchPatient);
            Name = "SearchPatientUserControl";
            Size = new Size(706, 538);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            MainPanelSearchPatient.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewPatients;
        private TextBox TextBoxSearchPatientName;
        private Panel panel1;
        private Panel MainPanelSearchPatient;
        private Button ButtonSelectedPatient;
    }
}
