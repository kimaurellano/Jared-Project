namespace Madentra {
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
            SearchPatientParentPanel = new Panel();
            SearchPatientSubPanel = new Panel();
            SearchPatientParentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SearchPatientParentPanel
            // 
            SearchPatientParentPanel.AutoSize = true;
            SearchPatientParentPanel.BackColor = Color.Transparent;
            SearchPatientParentPanel.Controls.Add(SearchPatientSubPanel);
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
            SearchPatientSubPanel.Location = new Point(0, 0);
            SearchPatientSubPanel.Name = "SearchPatientSubPanel";
            SearchPatientSubPanel.Size = new Size(1311, 1148);
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
            SearchPatientParentPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel SearchPatientParentPanel;
        private Panel SearchPatientSubPanel;
    }
}
