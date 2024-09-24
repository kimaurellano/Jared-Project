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
            LabelSelectedPatient = new Label();
            GroupBoxSelectedPatient = new GroupBox();
            LabelGender = new Label();
            LabelIDCard = new Label();
            LabelPhoneNumber = new Label();
            LabelAddress = new Label();
            LabelRemarks = new Label();
            GroupBoxSelectedPatient.SuspendLayout();
            SuspendLayout();
            // 
            // LabelSelectedPatient
            // 
            LabelSelectedPatient.AutoSize = true;
            LabelSelectedPatient.Location = new Point(70, 102);
            LabelSelectedPatient.Margin = new Padding(6, 0, 6, 0);
            LabelSelectedPatient.Name = "LabelSelectedPatient";
            LabelSelectedPatient.Size = new Size(158, 32);
            LabelSelectedPatient.TabIndex = 0;
            LabelSelectedPatient.Text = "Patient Name";
            // 
            // GroupBoxSelectedPatient
            // 
            GroupBoxSelectedPatient.Controls.Add(LabelRemarks);
            GroupBoxSelectedPatient.Controls.Add(LabelAddress);
            GroupBoxSelectedPatient.Controls.Add(LabelPhoneNumber);
            GroupBoxSelectedPatient.Controls.Add(LabelIDCard);
            GroupBoxSelectedPatient.Controls.Add(LabelGender);
            GroupBoxSelectedPatient.Controls.Add(LabelSelectedPatient);
            GroupBoxSelectedPatient.Dock = DockStyle.Fill;
            GroupBoxSelectedPatient.Location = new Point(20, 20);
            GroupBoxSelectedPatient.Name = "GroupBoxSelectedPatient";
            GroupBoxSelectedPatient.Padding = new Padding(4);
            GroupBoxSelectedPatient.Size = new Size(1347, 1182);
            GroupBoxSelectedPatient.TabIndex = 1;
            GroupBoxSelectedPatient.TabStop = false;
            GroupBoxSelectedPatient.Text = "Current Patient";
            // 
            // LabelGender
            // 
            LabelGender.AutoSize = true;
            LabelGender.Location = new Point(71, 195);
            LabelGender.Margin = new Padding(6, 0, 6, 0);
            LabelGender.Name = "LabelGender";
            LabelGender.Size = new Size(92, 32);
            LabelGender.TabIndex = 1;
            LabelGender.Text = "Gender";
            // 
            // LabelIDCard
            // 
            LabelIDCard.AutoSize = true;
            LabelIDCard.Location = new Point(70, 283);
            LabelIDCard.Margin = new Padding(6, 0, 6, 0);
            LabelIDCard.Name = "LabelIDCard";
            LabelIDCard.Size = new Size(93, 32);
            LabelIDCard.TabIndex = 2;
            LabelIDCard.Text = "ID Card";
            // 
            // LabelPhoneNumber
            // 
            LabelPhoneNumber.AutoSize = true;
            LabelPhoneNumber.Location = new Point(70, 369);
            LabelPhoneNumber.Margin = new Padding(6, 0, 6, 0);
            LabelPhoneNumber.Name = "LabelPhoneNumber";
            LabelPhoneNumber.Size = new Size(170, 32);
            LabelPhoneNumber.TabIndex = 3;
            LabelPhoneNumber.Text = "PhoneNumber";
            // 
            // LabelAddress
            // 
            LabelAddress.AutoSize = true;
            LabelAddress.Location = new Point(71, 460);
            LabelAddress.Margin = new Padding(6, 0, 6, 0);
            LabelAddress.Name = "LabelAddress";
            LabelAddress.Size = new Size(98, 32);
            LabelAddress.TabIndex = 4;
            LabelAddress.Text = "Address";
            // 
            // LabelRemarks
            // 
            LabelRemarks.AutoSize = true;
            LabelRemarks.Location = new Point(71, 552);
            LabelRemarks.Margin = new Padding(6, 0, 6, 0);
            LabelRemarks.Name = "LabelRemarks";
            LabelRemarks.Size = new Size(103, 32);
            LabelRemarks.TabIndex = 5;
            LabelRemarks.Text = "Remarks";
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

        private Label LabelSelectedPatient;
        private GroupBox GroupBoxSelectedPatient;
        private Label LabelGender;
        private Label LabelIDCard;
        private Label LabelRemarks;
        private Label LabelAddress;
        private Label LabelPhoneNumber;
    }
}
