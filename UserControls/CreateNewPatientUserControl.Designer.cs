namespace Madentra {
    partial class CreateNewPatientUserControl {
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
            TextBoxName = new TextBox();
            BtnCreatePatient = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 53);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(143, 47);
            TextBoxName.Margin = new Padding(6, 6, 6, 6);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(182, 39);
            TextBoxName.TabIndex = 1;
            // 
            // BtnCreatePatient
            // 
            BtnCreatePatient.Location = new Point(724, 708);
            BtnCreatePatient.Margin = new Padding(6, 6, 6, 6);
            BtnCreatePatient.Name = "BtnCreatePatient";
            BtnCreatePatient.Size = new Size(139, 49);
            BtnCreatePatient.TabIndex = 2;
            BtnCreatePatient.Text = "Create";
            BtnCreatePatient.UseVisualStyleBackColor = true;
            BtnCreatePatient.Click += BtnCreatePatient_Click;
            // 
            // CreateNewPatientUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(BtnCreatePatient);
            Controls.Add(TextBoxName);
            Controls.Add(label1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "CreateNewPatientUserControl";
            Size = new Size(921, 796);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBoxName;
        private Button BtnCreatePatient;
    }
}
