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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectedPersonUserControl));
            LabelSelectedPatient = new Label();
            GroupBoxSelectedPatient = new GroupBox();
            LabelRemarks = new Label();
            LabelAddress = new Label();
            LabelPhoneNumber = new Label();
            LabelIDCard = new Label();
            LabelGender = new Label();
            PictureBoxProfile = new PictureBox();
            GroupBoxSelectedPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxProfile).BeginInit();
            SuspendLayout();
            // 
            // LabelSelectedPatient
            // 
            LabelSelectedPatient.AutoSize = true;
            LabelSelectedPatient.Location = new Point(62, 472);
            LabelSelectedPatient.Margin = new Padding(6, 0, 6, 0);
            LabelSelectedPatient.Name = "LabelSelectedPatient";
            LabelSelectedPatient.Size = new Size(158, 32);
            LabelSelectedPatient.TabIndex = 0;
            LabelSelectedPatient.Text = "Patient Name";
            // 
            // GroupBoxSelectedPatient
            // 
            GroupBoxSelectedPatient.Controls.Add(PictureBoxProfile);
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
            // LabelRemarks
            // 
            LabelRemarks.AutoSize = true;
            LabelRemarks.Location = new Point(63, 922);
            LabelRemarks.Margin = new Padding(6, 0, 6, 0);
            LabelRemarks.Name = "LabelRemarks";
            LabelRemarks.Size = new Size(103, 32);
            LabelRemarks.TabIndex = 5;
            LabelRemarks.Text = "Remarks";
            // 
            // LabelAddress
            // 
            LabelAddress.AutoSize = true;
            LabelAddress.Location = new Point(63, 830);
            LabelAddress.Margin = new Padding(6, 0, 6, 0);
            LabelAddress.Name = "LabelAddress";
            LabelAddress.Size = new Size(98, 32);
            LabelAddress.TabIndex = 4;
            LabelAddress.Text = "Address";
            // 
            // LabelPhoneNumber
            // 
            LabelPhoneNumber.AutoSize = true;
            LabelPhoneNumber.Location = new Point(62, 739);
            LabelPhoneNumber.Margin = new Padding(6, 0, 6, 0);
            LabelPhoneNumber.Name = "LabelPhoneNumber";
            LabelPhoneNumber.Size = new Size(170, 32);
            LabelPhoneNumber.TabIndex = 3;
            LabelPhoneNumber.Text = "PhoneNumber";
            // 
            // LabelIDCard
            // 
            LabelIDCard.AutoSize = true;
            LabelIDCard.Location = new Point(62, 653);
            LabelIDCard.Margin = new Padding(6, 0, 6, 0);
            LabelIDCard.Name = "LabelIDCard";
            LabelIDCard.Size = new Size(93, 32);
            LabelIDCard.TabIndex = 2;
            LabelIDCard.Text = "ID Card";
            // 
            // LabelGender
            // 
            LabelGender.AutoSize = true;
            LabelGender.Location = new Point(63, 565);
            LabelGender.Margin = new Padding(6, 0, 6, 0);
            LabelGender.Name = "LabelGender";
            LabelGender.Size = new Size(92, 32);
            LabelGender.TabIndex = 1;
            LabelGender.Text = "Gender";
            // 
            // PictureBoxProfile
            // 
            PictureBoxProfile.BackColor = Color.Gainsboro;
            PictureBoxProfile.Image = (Image)resources.GetObject("PictureBoxProfile.Image");
            PictureBoxProfile.InitialImage = (Image)resources.GetObject("PictureBoxProfile.InitialImage");
            PictureBoxProfile.Location = new Point(62, 86);
            PictureBoxProfile.Name = "PictureBoxProfile";
            PictureBoxProfile.Padding = new Padding(50);
            PictureBoxProfile.Size = new Size(296, 320);
            PictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxProfile.TabIndex = 13;
            PictureBoxProfile.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)PictureBoxProfile).EndInit();
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
        private PictureBox PictureBoxProfile;
    }
}
