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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewPatientUserControl));
            label1 = new Label();
            TextBoxName = new TextBox();
            BtnCreatePatient = new Button();
            RadioButtonMale = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            RadioButtonFemale = new RadioButton();
            PictureBoxProfile = new PictureBox();
            TextBoxIDCard = new TextBox();
            TextBoxPhoneNumber = new TextBox();
            RichTextBoxAddress = new RichTextBox();
            RichTextBoxRemarks = new RichTextBox();
            buttonClear = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxProfile).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 53);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // TextBoxName
            // 
            TextBoxName.CharacterCasing = CharacterCasing.Upper;
            TextBoxName.Location = new Point(130, 53);
            TextBoxName.Margin = new Padding(6);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(393, 39);
            TextBoxName.TabIndex = 1;
            // 
            // BtnCreatePatient
            // 
            BtnCreatePatient.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCreatePatient.DialogResult = DialogResult.Yes;
            BtnCreatePatient.Location = new Point(880, 948);
            BtnCreatePatient.Margin = new Padding(6);
            BtnCreatePatient.Name = "BtnCreatePatient";
            BtnCreatePatient.Size = new Size(387, 69);
            BtnCreatePatient.TabIndex = 2;
            BtnCreatePatient.Text = "Create";
            BtnCreatePatient.UseVisualStyleBackColor = true;
            BtnCreatePatient.Click += BtnCreatePatient_Click;
            // 
            // RadioButtonMale
            // 
            RadioButtonMale.AutoSize = true;
            RadioButtonMale.Location = new Point(70, 55);
            RadioButtonMale.Name = "RadioButtonMale";
            RadioButtonMale.Size = new Size(98, 36);
            RadioButtonMale.TabIndex = 5;
            RadioButtonMale.TabStop = true;
            RadioButtonMale.Text = "Male";
            RadioButtonMale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Location = new Point(40, 330);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 32);
            label4.TabIndex = 7;
            label4.Text = "ID Card";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Location = new Point(40, 418);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(177, 32);
            label5.TabIndex = 8;
            label5.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Location = new Point(40, 522);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 32);
            label6.TabIndex = 9;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Location = new Point(33, 702);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(103, 32);
            label7.TabIndex = 10;
            label7.Text = "Remarks";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RadioButtonFemale);
            groupBox1.Controls.Add(RadioButtonMale);
            groupBox1.Location = new Point(40, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 119);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sex";
            // 
            // RadioButtonFemale
            // 
            RadioButtonFemale.AutoSize = true;
            RadioButtonFemale.Location = new Point(248, 55);
            RadioButtonFemale.Name = "RadioButtonFemale";
            RadioButtonFemale.Size = new Size(122, 36);
            RadioButtonFemale.TabIndex = 6;
            RadioButtonFemale.TabStop = true;
            RadioButtonFemale.Text = "Female";
            RadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // PictureBoxProfile
            // 
            PictureBoxProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PictureBoxProfile.BackColor = Color.Gainsboro;
            PictureBoxProfile.Image = (Image)resources.GetObject("PictureBoxProfile.Image");
            PictureBoxProfile.InitialImage = (Image)resources.GetObject("PictureBoxProfile.InitialImage");
            PictureBoxProfile.Location = new Point(982, 25);
            PictureBoxProfile.Name = "PictureBoxProfile";
            PictureBoxProfile.Padding = new Padding(50);
            PictureBoxProfile.Size = new Size(296, 320);
            PictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxProfile.TabIndex = 12;
            PictureBoxProfile.TabStop = false;
            // 
            // TextBoxIDCard
            // 
            TextBoxIDCard.Location = new Point(145, 327);
            TextBoxIDCard.Margin = new Padding(6);
            TextBoxIDCard.Name = "TextBoxIDCard";
            TextBoxIDCard.Size = new Size(378, 39);
            TextBoxIDCard.TabIndex = 13;
            TextBoxIDCard.KeyPress += TextBoxIDCard_KeyPress;
            // 
            // TextBoxPhoneNumber
            // 
            TextBoxPhoneNumber.Location = new Point(229, 418);
            TextBoxPhoneNumber.Margin = new Padding(6);
            TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            TextBoxPhoneNumber.Size = new Size(294, 39);
            TextBoxPhoneNumber.TabIndex = 14;
            TextBoxPhoneNumber.KeyPress += TextBoxPhoneNumber_KeyPress;
            // 
            // RichTextBoxAddress
            // 
            RichTextBoxAddress.Location = new Point(147, 522);
            RichTextBoxAddress.Name = "RichTextBoxAddress";
            RichTextBoxAddress.Size = new Size(655, 128);
            RichTextBoxAddress.TabIndex = 15;
            RichTextBoxAddress.Text = "";
            // 
            // RichTextBoxRemarks
            // 
            RichTextBoxRemarks.Location = new Point(145, 702);
            RichTextBoxRemarks.Name = "RichTextBoxRemarks";
            RichTextBoxRemarks.Size = new Size(672, 196);
            RichTextBoxRemarks.TabIndex = 16;
            RichTextBoxRemarks.Text = "";
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClear.DialogResult = DialogResult.Yes;
            buttonClear.Location = new Point(481, 948);
            buttonClear.Margin = new Padding(6);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(387, 69);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // CreateNewPatientUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(buttonClear);
            Controls.Add(RichTextBoxRemarks);
            Controls.Add(RichTextBoxAddress);
            Controls.Add(TextBoxPhoneNumber);
            Controls.Add(TextBoxIDCard);
            Controls.Add(PictureBoxProfile);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(BtnCreatePatient);
            Controls.Add(TextBoxName);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "CreateNewPatientUserControl";
            Size = new Size(1309, 1052);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBoxName;
        private Button BtnCreatePatient;
        private RadioButton RadioButtonMale;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private RadioButton RadioButtonFemale;
        private PictureBox PictureBoxProfile;
        private TextBox TextBoxIDCard;
        private TextBox TextBoxPhoneNumber;
        private RichTextBox RichTextBoxAddress;
        private RichTextBox RichTextBoxRemarks;
        private Button buttonClear;
    }
}
