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
            groupBox1 = new GroupBox();
            RadioButtonFemale = new RadioButton();
            PictureBoxProfile = new PictureBox();
            TextBoxIDCard = new TextBox();
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
            BtnCreatePatient.Location = new Point(880, 494);
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
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClear.DialogResult = DialogResult.Yes;
            buttonClear.Location = new Point(481, 494);
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
            Controls.Add(TextBoxIDCard);
            Controls.Add(PictureBoxProfile);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(BtnCreatePatient);
            Controls.Add(TextBoxName);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "CreateNewPatientUserControl";
            Size = new Size(1309, 598);
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
        private GroupBox groupBox1;
        private RadioButton RadioButtonFemale;
        private PictureBox PictureBoxProfile;
        private TextBox TextBoxIDCard;
        private Button buttonClear;
    }
}
