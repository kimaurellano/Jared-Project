namespace Madentra {
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnSearchPatient = new Button();
            btnCreateNewPatient = new Button();
            tabControlMain = new TabControl();
            tabPagePatients = new TabPage();
            PanelPatients = new Panel();
            tabPageCapture = new TabPage();
            BtnCapture = new Button();
            PictureBoxCamera = new PictureBox();
            tabPageCompare = new TabPage();
            tabPagemark = new TabPage();
            MainPanelMark = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            Settings = new TabPage();
            PanelPictureList = new Panel();
            ListViewImages = new ListView();
            ImageListMain = new ImageList(components);
            MainPanel = new Panel();
            BottomPanel = new Panel();
            LabelCurrentPatient = new Label();
            panel1.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPagePatients.SuspendLayout();
            tabPageCapture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxCamera).BeginInit();
            tabPagemark.SuspendLayout();
            MainPanelMark.SuspendLayout();
            PanelPictureList.SuspendLayout();
            MainPanel.SuspendLayout();
            BottomPanel.SuspendLayout();
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
            panel1.Size = new Size(550, 1114);
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
            tabControlMain.Size = new Size(1424, 1180);
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
            tabPagePatients.Size = new Size(1408, 1126);
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
            PanelPatients.Size = new Size(846, 1114);
            PanelPatients.TabIndex = 1;
            // 
            // tabPageCapture
            // 
            tabPageCapture.Controls.Add(BtnCapture);
            tabPageCapture.Controls.Add(PictureBoxCamera);
            tabPageCapture.Location = new Point(8, 46);
            tabPageCapture.Margin = new Padding(6);
            tabPageCapture.Name = "tabPageCapture";
            tabPageCapture.Padding = new Padding(6);
            tabPageCapture.Size = new Size(1408, 1126);
            tabPageCapture.TabIndex = 1;
            tabPageCapture.Text = "Capture";
            tabPageCapture.UseVisualStyleBackColor = true;
            // 
            // BtnCapture
            // 
            BtnCapture.Dock = DockStyle.Bottom;
            BtnCapture.Location = new Point(6, 1038);
            BtnCapture.Name = "BtnCapture";
            BtnCapture.Size = new Size(1396, 82);
            BtnCapture.TabIndex = 2;
            BtnCapture.Text = "Capture";
            BtnCapture.UseVisualStyleBackColor = true;
            BtnCapture.Click += BtnCapture_Click;
            // 
            // PictureBoxCamera
            // 
            PictureBoxCamera.Dock = DockStyle.Fill;
            PictureBoxCamera.Location = new Point(6, 6);
            PictureBoxCamera.Name = "PictureBoxCamera";
            PictureBoxCamera.Size = new Size(1396, 1114);
            PictureBoxCamera.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxCamera.TabIndex = 0;
            PictureBoxCamera.TabStop = false;
            // 
            // tabPageCompare
            // 
            tabPageCompare.Location = new Point(8, 46);
            tabPageCompare.Margin = new Padding(6);
            tabPageCompare.Name = "tabPageCompare";
            tabPageCompare.Size = new Size(1408, 1126);
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
            tabPagemark.Size = new Size(1408, 1126);
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
            MainPanelMark.Size = new Size(998, 1126);
            MainPanelMark.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(6);
            panel4.Name = "panel4";
            panel4.Size = new Size(998, 913);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 913);
            panel3.Margin = new Padding(6);
            panel3.Name = "panel3";
            panel3.Size = new Size(998, 213);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(6);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 1126);
            panel2.TabIndex = 0;
            // 
            // Settings
            // 
            Settings.Location = new Point(8, 46);
            Settings.Margin = new Padding(6);
            Settings.Name = "Settings";
            Settings.Size = new Size(1408, 1126);
            Settings.TabIndex = 4;
            Settings.Text = "Settings";
            Settings.UseVisualStyleBackColor = true;
            // 
            // PanelPictureList
            // 
            PanelPictureList.BackColor = Color.RosyBrown;
            PanelPictureList.Controls.Add(ListViewImages);
            PanelPictureList.Dock = DockStyle.Right;
            PanelPictureList.Location = new Point(1424, 0);
            PanelPictureList.Margin = new Padding(6);
            PanelPictureList.Name = "PanelPictureList";
            PanelPictureList.Size = new Size(474, 1180);
            PanelPictureList.TabIndex = 1;
            // 
            // ListViewImages
            // 
            ListViewImages.Dock = DockStyle.Fill;
            ListViewImages.Location = new Point(0, 0);
            ListViewImages.Name = "ListViewImages";
            ListViewImages.Size = new Size(474, 1180);
            ListViewImages.TabIndex = 3;
            ListViewImages.UseCompatibleStateImageBehavior = false;
            // 
            // ImageListMain
            // 
            ImageListMain.ColorDepth = ColorDepth.Depth32Bit;
            ImageListMain.ImageSize = new Size(16, 16);
            ImageListMain.TransparentColor = Color.Transparent;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(tabControlMain);
            MainPanel.Controls.Add(PanelPictureList);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1898, 1180);
            MainPanel.TabIndex = 2;
            // 
            // BottomPanel
            // 
            BottomPanel.BackColor = Color.Transparent;
            BottomPanel.BorderStyle = BorderStyle.FixedSingle;
            BottomPanel.Controls.Add(LabelCurrentPatient);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(0, 1117);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(1898, 63);
            BottomPanel.TabIndex = 3;
            // 
            // LabelCurrentpatient
            // 
            LabelCurrentPatient.AutoSize = true;
            LabelCurrentPatient.Location = new Point(14, 17);
            LabelCurrentPatient.Name = "LabelCurrentpatient";
            LabelCurrentPatient.Size = new Size(256, 32);
            LabelCurrentPatient.TabIndex = 0;
            LabelCurrentPatient.Text = "Current Patient: Admin";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1180);
            Controls.Add(BottomPanel);
            Controls.Add(MainPanel);
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
            ((System.ComponentModel.ISupportInitialize)PictureBoxCamera).EndInit();
            tabPagemark.ResumeLayout(false);
            MainPanelMark.ResumeLayout(false);
            PanelPictureList.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            BottomPanel.ResumeLayout(false);
            BottomPanel.PerformLayout();
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
        private Panel panel2;
        private Panel MainPanelMark;
        private Panel panel4;
        private Panel panel3;
        private PictureBox PictureBoxCamera;
        private Button BtnCapture;
        private Panel PanelPictureList;
        private ListView ListViewImages;
        private ImageList ImageListMain;
        private Panel MainPanel;
        private Panel BottomPanel;
        private Label LabelCurrentPatient;
    }
}
