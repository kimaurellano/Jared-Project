namespace Madentra.UserControls {
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
            SearchBoxPanel = new Panel();
            buttonDelete = new Button();
            TextBoxSearchPatientName = new TextBox();
            dataGridViewPatients = new DataGridView();
            SearchBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).BeginInit();
            SuspendLayout();
            // 
            // SearchBoxPanel
            // 
            SearchBoxPanel.BackColor = Color.White;
            SearchBoxPanel.Controls.Add(buttonDelete);
            SearchBoxPanel.Controls.Add(TextBoxSearchPatientName);
            SearchBoxPanel.Dock = DockStyle.Top;
            SearchBoxPanel.Location = new Point(0, 0);
            SearchBoxPanel.Margin = new Padding(6);
            SearchBoxPanel.Name = "SearchBoxPanel";
            SearchBoxPanel.Size = new Size(1782, 92);
            SearchBoxPanel.TabIndex = 4;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(1408, 21);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(350, 46);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete Patient Record";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // TextBoxSearchPatientName
            // 
            TextBoxSearchPatientName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TextBoxSearchPatientName.Location = new Point(26, 21);
            TextBoxSearchPatientName.Margin = new Padding(6);
            TextBoxSearchPatientName.Name = "TextBoxSearchPatientName";
            TextBoxSearchPatientName.PlaceholderText = "Search Patient";
            TextBoxSearchPatientName.Size = new Size(275, 39);
            TextBoxSearchPatientName.TabIndex = 2;
            TextBoxSearchPatientName.TextChanged += TextBoxSearchPatientName_TextChanged;
            // 
            // dataGridViewPatients
            // 
            dataGridViewPatients.AllowUserToAddRows = false;
            dataGridViewPatients.AllowUserToDeleteRows = false;
            dataGridViewPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPatients.BackgroundColor = Color.White;
            dataGridViewPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPatients.Dock = DockStyle.Fill;
            dataGridViewPatients.Location = new Point(0, 92);
            dataGridViewPatients.Name = "dataGridViewPatients";
            dataGridViewPatients.ReadOnly = true;
            dataGridViewPatients.RowHeadersWidth = 82;
            dataGridViewPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPatients.Size = new Size(1782, 1178);
            dataGridViewPatients.TabIndex = 0;
            dataGridViewPatients.CellClick += dataGridViewPatients_CellClick;
            dataGridViewPatients.CellDoubleClick += DataGridViewPatients_CellDoubleClick;
            // 
            // DataGridViewPatientUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewPatients);
            Controls.Add(SearchBoxPanel);
            Name = "DataGridViewPatientUserControl";
            Size = new Size(1782, 1270);
            Paint += DataGridViewPatientUserControl_Paint;
            SearchBoxPanel.ResumeLayout(false);
            SearchBoxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel SearchBoxPanel;
        private TextBox TextBoxSearchPatientName;
        private DataGridView dataGridViewPatients;
        private Button buttonDelete;
    }
}
