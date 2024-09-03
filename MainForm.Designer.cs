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
            TabControlMain = new TabControl();
            tabPagePatients = new TabPage();
            PanelPatients = new Panel();
            tabPageCapture = new TabPage();
            BtnCapture = new Button();
            PictureBoxCamera = new PictureBox();
            TabPageCompare = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            PictureBoxTopLeft = new PictureBox();
            PictureBoxBottomRight = new PictureBox();
            PictureBoxTopRight = new PictureBox();
            PictureBoxBottomLeft = new PictureBox();
            tabPagemark = new TabPage();
            MainPanelMark = new Panel();
            PanelMark = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            Settings = new TabPage();
            PanelPictureList = new Panel();
            ListViewImages = new ListView();
            ImageListMain = new ImageList(components);
            MainPanel = new Panel();
            BottomPanel = new Panel();
            LabelCurrentPatient = new Label();
            panel1.SuspendLayout();
            TabControlMain.SuspendLayout();
            tabPagePatients.SuspendLayout();
            tabPageCapture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxCamera).BeginInit();
            TabPageCompare.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxTopLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxBottomRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxTopRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxBottomLeft).BeginInit();
            tabPagemark.SuspendLayout();
            MainPanelMark.SuspendLayout();
            PanelMark.SuspendLayout();
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
            panel1.Size = new Size(550, 1050);
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
            // TabControlMain
            // 
            TabControlMain.Controls.Add(tabPagePatients);
            TabControlMain.Controls.Add(tabPageCapture);
            TabControlMain.Controls.Add(TabPageCompare);
            TabControlMain.Controls.Add(tabPagemark);
            TabControlMain.Controls.Add(Settings);
            TabControlMain.Dock = DockStyle.Fill;
            TabControlMain.Location = new Point(0, 0);
            TabControlMain.Margin = new Padding(6);
            TabControlMain.Name = "TabControlMain";
            TabControlMain.SelectedIndex = 0;
            TabControlMain.Size = new Size(1424, 1116);
            TabControlMain.TabIndex = 1;
            TabControlMain.SelectedIndexChanged += TabControlMain_SelectedIndexChanged;
            // 
            // tabPagePatients
            // 
            tabPagePatients.Controls.Add(PanelPatients);
            tabPagePatients.Controls.Add(panel1);
            tabPagePatients.Location = new Point(8, 46);
            tabPagePatients.Margin = new Padding(6);
            tabPagePatients.Name = "tabPagePatients";
            tabPagePatients.Padding = new Padding(6);
            tabPagePatients.Size = new Size(1408, 1062);
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
            PanelPatients.Size = new Size(846, 1050);
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
            tabPageCapture.Size = new Size(1408, 1062);
            tabPageCapture.TabIndex = 1;
            tabPageCapture.Text = "Capture";
            tabPageCapture.UseVisualStyleBackColor = true;
            // 
            // BtnCapture
            // 
            BtnCapture.Dock = DockStyle.Bottom;
            BtnCapture.Location = new Point(6, 974);
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
            PictureBoxCamera.Size = new Size(1396, 1050);
            PictureBoxCamera.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBoxCamera.TabIndex = 0;
            PictureBoxCamera.TabStop = false;
            // 
            // TabPageCompare
            // 
            TabPageCompare.Controls.Add(tableLayoutPanel1);
            TabPageCompare.Location = new Point(8, 46);
            TabPageCompare.Margin = new Padding(6);
            TabPageCompare.Name = "TabPageCompare";
            TabPageCompare.Size = new Size(1408, 1062);
            TabPageCompare.TabIndex = 2;
            TabPageCompare.Text = "Compare";
            TabPageCompare.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(PictureBoxTopLeft, 0, 0);
            tableLayoutPanel1.Controls.Add(PictureBoxBottomRight, 1, 1);
            tableLayoutPanel1.Controls.Add(PictureBoxTopRight, 1, 0);
            tableLayoutPanel1.Controls.Add(PictureBoxBottomLeft, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1408, 1062);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // PictureBoxTopLeft
            // 
            PictureBoxTopLeft.BackColor = Color.WhiteSmoke;
            PictureBoxTopLeft.Dock = DockStyle.Fill;
            PictureBoxTopLeft.Location = new Point(3, 3);
            PictureBoxTopLeft.Name = "PictureBoxTopLeft";
            PictureBoxTopLeft.Size = new Size(698, 525);
            PictureBoxTopLeft.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBoxTopLeft.TabIndex = 0;
            PictureBoxTopLeft.TabStop = false;
            PictureBoxTopLeft.Click += PictureBoxTopLeft_Click;
            // 
            // PictureBoxBottomRight
            // 
            PictureBoxBottomRight.BackColor = Color.WhiteSmoke;
            PictureBoxBottomRight.Dock = DockStyle.Fill;
            PictureBoxBottomRight.Location = new Point(707, 534);
            PictureBoxBottomRight.Name = "PictureBoxBottomRight";
            PictureBoxBottomRight.Size = new Size(698, 525);
            PictureBoxBottomRight.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBoxBottomRight.TabIndex = 3;
            PictureBoxBottomRight.TabStop = false;
            PictureBoxBottomRight.Click += PictureBoxBottomRight_Click;
            // 
            // PictureBoxTopRight
            // 
            PictureBoxTopRight.BackColor = Color.WhiteSmoke;
            PictureBoxTopRight.Dock = DockStyle.Fill;
            PictureBoxTopRight.Location = new Point(707, 3);
            PictureBoxTopRight.Name = "PictureBoxTopRight";
            PictureBoxTopRight.Size = new Size(698, 525);
            PictureBoxTopRight.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBoxTopRight.TabIndex = 1;
            PictureBoxTopRight.TabStop = false;
            PictureBoxTopRight.Click += PictureBoxTopRight_Click;
            // 
            // PictureBoxBottomLeft
            // 
            PictureBoxBottomLeft.BackColor = Color.WhiteSmoke;
            PictureBoxBottomLeft.Dock = DockStyle.Fill;
            PictureBoxBottomLeft.Location = new Point(3, 534);
            PictureBoxBottomLeft.Name = "PictureBoxBottomLeft";
            PictureBoxBottomLeft.Size = new Size(698, 525);
            PictureBoxBottomLeft.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBoxBottomLeft.TabIndex = 2;
            PictureBoxBottomLeft.TabStop = false;
            PictureBoxBottomLeft.Click += PictureBoxBottomLeft_Click;
            // 
            // tabPagemark
            // 
            tabPagemark.Controls.Add(MainPanelMark);
            tabPagemark.Location = new Point(8, 46);
            tabPagemark.Margin = new Padding(6);
            tabPagemark.Name = "tabPagemark";
            tabPagemark.Size = new Size(1408, 1062);
            tabPagemark.TabIndex = 3;
            tabPagemark.Text = "Mark";
            tabPagemark.UseVisualStyleBackColor = true;
            // 
            // MainPanelMark
            // 
            MainPanelMark.Controls.Add(PanelMark);
            MainPanelMark.Dock = DockStyle.Fill;
            MainPanelMark.Location = new Point(0, 0);
            MainPanelMark.Margin = new Padding(6);
            MainPanelMark.Name = "MainPanelMark";
            MainPanelMark.Size = new Size(1408, 1062);
            MainPanelMark.TabIndex = 1;
            // 
            // PanelMark
            // 
            PanelMark.Controls.Add(panel4);
            PanelMark.Controls.Add(panel3);
            PanelMark.Dock = DockStyle.Fill;
            PanelMark.Location = new Point(0, 0);
            PanelMark.Name = "PanelMark";
            PanelMark.Size = new Size(1408, 1062);
            PanelMark.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(6);
            panel4.Name = "panel4";
            panel4.Size = new Size(1408, 849);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 849);
            panel3.Margin = new Padding(6);
            panel3.Name = "panel3";
            panel3.Size = new Size(1408, 213);
            panel3.TabIndex = 2;
            // 
            // Settings
            // 
            Settings.Location = new Point(8, 46);
            Settings.Margin = new Padding(6);
            Settings.Name = "Settings";
            Settings.Size = new Size(1408, 1062);
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
            PanelPictureList.Size = new Size(474, 1116);
            PanelPictureList.TabIndex = 1;
            // 
            // ListViewImages
            // 
            ListViewImages.Dock = DockStyle.Fill;
            ListViewImages.Location = new Point(0, 0);
            ListViewImages.Name = "ListViewImages";
            ListViewImages.Size = new Size(474, 1116);
            ListViewImages.TabIndex = 3;
            ListViewImages.UseCompatibleStateImageBehavior = false;
            ListViewImages.ItemSelectionChanged += ListViewImages_ItemSelectionChanged;
            // 
            // ImageListMain
            // 
            ImageListMain.ColorDepth = ColorDepth.Depth32Bit;
            ImageListMain.ImageSize = new Size(16, 16);
            ImageListMain.TransparentColor = Color.Transparent;
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainPanel.Controls.Add(TabControlMain);
            MainPanel.Controls.Add(PanelPictureList);
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1898, 1116);
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
            // LabelCurrentPatient
            // 
            LabelCurrentPatient.AutoSize = true;
            LabelCurrentPatient.Location = new Point(14, 17);
            LabelCurrentPatient.Name = "LabelCurrentPatient";
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
            TabControlMain.ResumeLayout(false);
            tabPagePatients.ResumeLayout(false);
            tabPageCapture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBoxCamera).EndInit();
            TabPageCompare.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBoxTopLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxBottomRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxTopRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxBottomLeft).EndInit();
            tabPagemark.ResumeLayout(false);
            MainPanelMark.ResumeLayout(false);
            PanelMark.ResumeLayout(false);
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
        private TabControl TabControlMain;
        private TabPage tabPagePatients;
        private TabPage tabPageCapture;
        private Panel PanelPatients;
        private TabPage TabPageCompare;
        private TabPage tabPagemark;
        private TabPage Settings;
        private Panel MainPanelMark;
        private PictureBox PictureBoxCamera;
        private Button BtnCapture;
        private Panel PanelPictureList;
        private ListView ListViewImages;
        private ImageList ImageListMain;
        private Panel MainPanel;
        private Panel BottomPanel;
        private Label LabelCurrentPatient;
        private PictureBox PictureBoxBottomLeft;
        private PictureBox PictureBoxTopRight;
        private PictureBox PictureBoxTopLeft;
        private PictureBox PictureBoxBottomRight;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel PanelMark;
        private Panel panel4;
        private Panel panel3;
    }
}
