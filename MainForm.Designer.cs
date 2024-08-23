namespace Jared {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnSearchPatient = new Button();
            btnCreateNewPatient = new Button();
            tabControlMain = new TabControl();
            tabPagePatients = new TabPage();
            PanelPatients = new Panel();
            tabPageCapture = new TabPage();
            pictureBoxCamera = new PictureBox();
            PanelPictureList = new Panel();
            tabPageCompare = new TabPage();
            tabPagemark = new TabPage();
            MainPanelMark = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            Settings = new TabPage();
            BtnCapture = new Button();
            panel1.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPagePatients.SuspendLayout();
            tabPageCapture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).BeginInit();
            tabPagemark.SuspendLayout();
            MainPanelMark.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearchPatient);
            panel1.Controls.Add(btnCreateNewPatient);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(6, 6);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 1091);
            panel1.TabIndex = 0;
            // 
            // btnSearchPatient
            // 
            btnSearchPatient.Location = new Point(6, 412);
            btnSearchPatient.Margin = new Padding(6);
            btnSearchPatient.Name = "btnSearchPatient";
            btnSearchPatient.Size = new Size(539, 102);
            btnSearchPatient.TabIndex = 2;
            btnSearchPatient.Text = "Search Patient";
            btnSearchPatient.UseVisualStyleBackColor = true;
            btnSearchPatient.Click += BtnSearchPatient_Click;
            // 
            // btnCreateNewPatient
            // 
            btnCreateNewPatient.Location = new Point(6, 297);
            btnCreateNewPatient.Margin = new Padding(6);
            btnCreateNewPatient.Name = "btnCreateNewPatient";
            btnCreateNewPatient.Size = new Size(539, 102);
            btnCreateNewPatient.TabIndex = 1;
            btnCreateNewPatient.Text = "Create New Patient";
            btnCreateNewPatient.UseVisualStyleBackColor = true;
            btnCreateNewPatient.Click += BtnCreateNewPatient_Click;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPagePatients);
            tabControlMain.Controls.Add(tabPageCapture);
            tabControlMain.Controls.Add(tabPageCompare);
            tabControlMain.Controls.Add(tabPagemark);
            tabControlMain.Controls.Add(Settings);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Margin = new Padding(6);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1630, 1157);
            tabControlMain.TabIndex = 1;
            tabControlMain.SelectedIndexChanged += TabControlMain_SelectedIndexChanged;
            // 
            // tabPagePatients
            // 
            tabPagePatients.Controls.Add(PanelPatients);
            tabPagePatients.Controls.Add(panel1);
            tabPagePatients.Location = new Point(8, 46);
            tabPagePatients.Margin = new Padding(6);
            tabPagePatients.Name = "tabPagePatients";
            tabPagePatients.Padding = new Padding(6);
            tabPagePatients.Size = new Size(1614, 1103);
            tabPagePatients.TabIndex = 0;
            tabPagePatients.Text = "Patients";
            tabPagePatients.UseVisualStyleBackColor = true;
            // 
            // PanelPatients
            // 
            PanelPatients.BackColor = Color.Gainsboro;
            PanelPatients.Dock = DockStyle.Fill;
            PanelPatients.Location = new Point(556, 6);
            PanelPatients.Margin = new Padding(6);
            PanelPatients.Name = "PanelPatients";
            PanelPatients.Size = new Size(1052, 1091);
            PanelPatients.TabIndex = 1;
            // 
            // tabPageCapture
            // 
            tabPageCapture.Controls.Add(BtnCapture);
            tabPageCapture.Controls.Add(pictureBoxCamera);
            tabPageCapture.Controls.Add(PanelPictureList);
            tabPageCapture.Location = new Point(8, 46);
            tabPageCapture.Margin = new Padding(6);
            tabPageCapture.Name = "tabPageCapture";
            tabPageCapture.Padding = new Padding(6);
            tabPageCapture.Size = new Size(1614, 1103);
            tabPageCapture.TabIndex = 1;
            tabPageCapture.Text = "Capture";
            tabPageCapture.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCamera
            // 
            pictureBoxCamera.Dock = DockStyle.Fill;
            pictureBoxCamera.Location = new Point(480, 6);
            pictureBoxCamera.Name = "pictureBoxCamera";
            pictureBoxCamera.Size = new Size(1128, 1091);
            pictureBoxCamera.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCamera.TabIndex = 0;
            pictureBoxCamera.TabStop = false;
            // 
            // PanelPictureList
            // 
            PanelPictureList.BackColor = Color.Gainsboro;
            PanelPictureList.Dock = DockStyle.Left;
            PanelPictureList.Location = new Point(6, 6);
            PanelPictureList.Margin = new Padding(6);
            PanelPictureList.Name = "PanelPictureList";
            PanelPictureList.Size = new Size(474, 1091);
            PanelPictureList.TabIndex = 1;
            // 
            // tabPageCompare
            // 
            tabPageCompare.Location = new Point(8, 46);
            tabPageCompare.Margin = new Padding(6);
            tabPageCompare.Name = "tabPageCompare";
            tabPageCompare.Size = new Size(1614, 1103);
            tabPageCompare.TabIndex = 2;
            tabPageCompare.Text = "Compare";
            tabPageCompare.UseVisualStyleBackColor = true;
            // 
            // tabPagemark
            // 
            tabPagemark.Controls.Add(MainPanelMark);
            tabPagemark.Controls.Add(panel2);
            tabPagemark.Location = new Point(8, 46);
            tabPagemark.Margin = new Padding(6);
            tabPagemark.Name = "tabPagemark";
            tabPagemark.Size = new Size(1614, 1103);
            tabPagemark.TabIndex = 3;
            tabPagemark.Text = "Mark";
            tabPagemark.UseVisualStyleBackColor = true;
            // 
            // MainPanelMark
            // 
            MainPanelMark.Controls.Add(panel4);
            MainPanelMark.Controls.Add(panel3);
            MainPanelMark.Dock = DockStyle.Fill;
            MainPanelMark.Location = new Point(410, 0);
            MainPanelMark.Margin = new Padding(6);
            MainPanelMark.Name = "MainPanelMark";
            MainPanelMark.Size = new Size(1204, 1103);
            MainPanelMark.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(6);
            panel4.Name = "panel4";
            panel4.Size = new Size(1204, 890);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 890);
            panel3.Margin = new Padding(6);
            panel3.Name = "panel3";
            panel3.Size = new Size(1204, 213);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(6);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 1103);
            panel2.TabIndex = 0;
            // 
            // Settings
            // 
            Settings.Location = new Point(8, 46);
            Settings.Margin = new Padding(6);
            Settings.Name = "Settings";
            Settings.Size = new Size(1614, 1103);
            Settings.TabIndex = 4;
            Settings.Text = "Settings";
            Settings.UseVisualStyleBackColor = true;
            // 
            // BtnCapture
            // 
            BtnCapture.Dock = DockStyle.Bottom;
            BtnCapture.Location = new Point(480, 1015);
            BtnCapture.Name = "BtnCapture";
            BtnCapture.Size = new Size(1128, 82);
            BtnCapture.TabIndex = 2;
            BtnCapture.Text = "Capture";
            BtnCapture.UseVisualStyleBackColor = true;
            BtnCapture.Click += BtnCapture_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1630, 1157);
            Controls.Add(tabControlMain);
            Margin = new Padding(6);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jared";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            panel1.ResumeLayout(false);
            tabControlMain.ResumeLayout(false);
            tabPagePatients.ResumeLayout(false);
            tabPageCapture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).EndInit();
            tabPagemark.ResumeLayout(false);
            MainPanelMark.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSearchPatient;
        private Button btnCreateNewPatient;
        private TabControl tabControlMain;
        private TabPage tabPagePatients;
        private TabPage tabPageCapture;
        private Panel PanelPatients;
        private TabPage tabPageCompare;
        private TabPage tabPagemark;
        private TabPage Settings;
        private Panel PanelPictureList;
        private Panel panel2;
        private Panel MainPanelMark;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBoxCamera;
        private Button BtnCapture;
    }
}
