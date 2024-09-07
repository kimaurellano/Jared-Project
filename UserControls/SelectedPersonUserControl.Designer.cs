namespace Madentra {
    partial class SelectedPersonUserControl {
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
            label1 = new Label();
            GroupBoxSelectedPatient = new GroupBox();
            GroupBoxSelectedPatient.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 123);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 32);
            label1.TabIndex = 0;
            label1.Text = "selectedPatient";
            // 
            // GroupBoxSelectedPatient
            // 
            GroupBoxSelectedPatient.Controls.Add(label1);
            GroupBoxSelectedPatient.Dock = DockStyle.Fill;
            GroupBoxSelectedPatient.Location = new Point(20, 20);
            GroupBoxSelectedPatient.Name = "GroupBoxSelectedPatient";
            GroupBoxSelectedPatient.Padding = new Padding(4);
            GroupBoxSelectedPatient.Size = new Size(1347, 1182);
            GroupBoxSelectedPatient.TabIndex = 1;
            GroupBoxSelectedPatient.TabStop = false;
            GroupBoxSelectedPatient.Text = "Current Patient";
            // 
            // SelectedPersonUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GroupBoxSelectedPatient);
            Margin = new Padding(6);
            Name = "SelectedPersonUserControl";
            Padding = new Padding(20);
            Size = new Size(1387, 1222);
            Load += SelectedPersonUserControl_Load;
            Paint += SelectedPersonUserControl_Paint;
            GroupBoxSelectedPatient.ResumeLayout(false);
            GroupBoxSelectedPatient.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox GroupBoxSelectedPatient;
    }
}
