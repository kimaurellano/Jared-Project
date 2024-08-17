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
            dataGridView1 = new DataGridView();
            TextBoxSearchPatientName = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.WhiteSmoke;
            dataGridView1.Location = new Point(0, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(706, 495);
            dataGridView1.TabIndex = 1;
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
            panel1.Controls.Add(TextBoxSearchPatientName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 43);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(706, 538);
            panel2.TabIndex = 4;
            // 
            // SearchPatientUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "SearchPatientUserControl";
            Size = new Size(706, 538);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox TextBoxSearchPatientName;
        private Panel panel1;
        private Panel panel2;
    }
}
