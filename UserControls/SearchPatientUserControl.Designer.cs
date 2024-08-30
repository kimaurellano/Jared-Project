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
            TextBoxSearchPatientName = new TextBox();
            panel1 = new Panel();
            SearchPatientParentPanel = new Panel();
            SearchPatientSubPanel = new Panel();
            panel1.SuspendLayout();
            SearchPatientParentPanel.SuspendLayout();
            SuspendLayout();
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
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(TextBoxSearchPatientName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1311, 92);
            panel1.TabIndex = 3;
            // 
            // SearchPatientParentPanel
            // 
            SearchPatientParentPanel.BackColor = Color.Transparent;
            SearchPatientParentPanel.Controls.Add(SearchPatientSubPanel);
            SearchPatientParentPanel.Controls.Add(panel1);
            SearchPatientParentPanel.Dock = DockStyle.Fill;
            SearchPatientParentPanel.Location = new Point(0, 0);
            SearchPatientParentPanel.Margin = new Padding(6);
            SearchPatientParentPanel.Name = "SearchPatientParentPanel";
            SearchPatientParentPanel.Size = new Size(1311, 1148);
            SearchPatientParentPanel.TabIndex = 4;
            // 
            // SearchPatientSubPanel
            // 
            SearchPatientSubPanel.BackgroundImageLayout = ImageLayout.None;
            SearchPatientSubPanel.Dock = DockStyle.Fill;
            SearchPatientSubPanel.Location = new Point(0, 92);
            SearchPatientSubPanel.Name = "SearchPatientSubPanel";
            SearchPatientSubPanel.Size = new Size(1311, 1056);
            SearchPatientSubPanel.TabIndex = 4;
            // 
            // SearchPatientUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SearchPatientParentPanel);
            Margin = new Padding(6);
            Name = "SearchPatientUserControl";
            Size = new Size(1311, 1148);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            SearchPatientParentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox TextBoxSearchPatientName;
        private Panel panel1;
        private Panel SearchPatientParentPanel;
        private Panel SearchPatientSubPanel;
    }
}
