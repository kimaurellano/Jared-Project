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
        private void InitializeComponent() {
            panel1 = new Panel();
            btnSearchPatient = new Button();
            btnCreateNewPatient = new Button();
            tabControlMain = new TabControl();
            tabPagePatients = new TabPage();
            PanelPatients = new Panel();
            tabPageCapture = new TabPage();
            PanelCameraView = new Panel();
            PanelPictureList = new Panel();
            tabPageCompare = new TabPage();
            tabPagemark = new TabPage();
            Settings = new TabPage();
            panel1.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPagePatients.SuspendLayout();
            tabPageCapture.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearchPatient);
            panel1.Controls.Add(btnCreateNewPatient);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 647);
            panel1.TabIndex = 0;
            // 
            // btnSearchPatient
            // 
            btnSearchPatient.Location = new Point(3, 193);
            btnSearchPatient.Name = "btnSearchPatient";
            btnSearchPatient.Size = new Size(290, 48);
            btnSearchPatient.TabIndex = 2;
            btnSearchPatient.Text = "Search Patient";
            btnSearchPatient.UseVisualStyleBackColor = true;
            btnSearchPatient.Click += BtnSearchPatient_Click_1;
            // 
            // btnCreateNewPatient
            // 
            btnCreateNewPatient.Location = new Point(3, 139);
            btnCreateNewPatient.Name = "btnCreateNewPatient";
            btnCreateNewPatient.Size = new Size(290, 48);
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
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1264, 681);
            tabControlMain.TabIndex = 1;
            // 
            // tabPagePatients
            // 
            tabPagePatients.Controls.Add(PanelPatients);
            tabPagePatients.Controls.Add(panel1);
            tabPagePatients.Location = new Point(4, 24);
            tabPagePatients.Name = "tabPagePatients";
            tabPagePatients.Padding = new Padding(3);
            tabPagePatients.Size = new Size(1256, 653);
            tabPagePatients.TabIndex = 0;
            tabPagePatients.Text = "Patients";
            tabPagePatients.UseVisualStyleBackColor = true;
            // 
            // PanelPatients
            // 
            PanelPatients.BackColor = Color.Gainsboro;
            PanelPatients.Dock = DockStyle.Fill;
            PanelPatients.Location = new Point(299, 3);
            PanelPatients.Name = "PanelPatients";
            PanelPatients.Size = new Size(954, 647);
            PanelPatients.TabIndex = 1;
            // 
            // tabPageCapture
            // 
            tabPageCapture.Controls.Add(PanelCameraView);
            tabPageCapture.Controls.Add(PanelPictureList);
            tabPageCapture.Location = new Point(4, 24);
            tabPageCapture.Name = "tabPageCapture";
            tabPageCapture.Padding = new Padding(3);
            tabPageCapture.Size = new Size(1256, 653);
            tabPageCapture.TabIndex = 1;
            tabPageCapture.Text = "Capture";
            tabPageCapture.UseVisualStyleBackColor = true;
            // 
            // PanelCameraView
            // 
            PanelCameraView.BackColor = Color.LightGray;
            PanelCameraView.Dock = DockStyle.Fill;
            PanelCameraView.Location = new Point(258, 3);
            PanelCameraView.Name = "PanelCameraView";
            PanelCameraView.Size = new Size(995, 647);
            PanelCameraView.TabIndex = 2;
            // 
            // PanelPictureList
            // 
            PanelPictureList.BackColor = Color.Gainsboro;
            PanelPictureList.Dock = DockStyle.Left;
            PanelPictureList.Location = new Point(3, 3);
            PanelPictureList.Name = "PanelPictureList";
            PanelPictureList.Size = new Size(255, 647);
            PanelPictureList.TabIndex = 1;
            // 
            // tabPageCompare
            // 
            tabPageCompare.Location = new Point(4, 24);
            tabPageCompare.Name = "tabPageCompare";
            tabPageCompare.Size = new Size(1256, 653);
            tabPageCompare.TabIndex = 2;
            tabPageCompare.Text = "Compare";
            tabPageCompare.UseVisualStyleBackColor = true;
            // 
            // tabPagemark
            // 
            tabPagemark.Location = new Point(4, 24);
            tabPagemark.Name = "tabPagemark";
            tabPagemark.Size = new Size(1256, 653);
            tabPagemark.TabIndex = 3;
            tabPagemark.Text = "Mark";
            tabPagemark.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            Settings.Location = new Point(4, 24);
            Settings.Name = "Settings";
            Settings.Size = new Size(1256, 653);
            Settings.TabIndex = 4;
            Settings.Text = "Settings";
            Settings.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(tabControlMain);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jared";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            tabControlMain.ResumeLayout(false);
            tabPagePatients.ResumeLayout(false);
            tabPageCapture.ResumeLayout(false);
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
        private Panel PanelCameraView;
    }
}
