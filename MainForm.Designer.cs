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
            PanelPictureList = new Panel();
            LabelEmpty = new Label();
            ListViewImages = new ListView();
            ImageListMain = new ImageList(components);
            MainPanel = new Panel();
            TabControlMain = new TabControl();
            tabPagePatients = new TabPage();
            PanelPatients = new Panel();
            panel1 = new Panel();
            BtnSelectedPatient = new Button();
            btnSearchPatient = new Button();
            btnCreateNewPatient = new Button();
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
            PanelMarkContainer = new Panel();
            PanelMark = new Panel();
            Settings = new TabPage();
            BottomPanel = new Panel();
            LabelCurrentPatient = new Label();
            comboBoxCameraList = new ComboBox();
            label1 = new Label();
            PanelPictureList.SuspendLayout();
            MainPanel.SuspendLayout();
            TabControlMain.SuspendLayout();
            tabPagePatients.SuspendLayout();
            panel1.SuspendLayout();
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
            PanelMarkContainer.SuspendLayout();
            Settings.SuspendLayout();
            BottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PanelPictureList
            // 
            PanelPictureList.BackColor = Color.Transparent;
            PanelPictureList.Controls.Add(LabelEmpty);
            PanelPictureList.Controls.Add(ListViewImages);
            PanelPictureList.Dock = DockStyle.Right;
            PanelPictureList.Location = new Point(1424, 0);
            PanelPictureList.Margin = new Padding(6);
            PanelPictureList.Name = "PanelPictureList";
            PanelPictureList.Padding = new Padding(0, 45, 0, 0);
            PanelPictureList.Size = new Size(474, 996);
            PanelPictureList.TabIndex = 1;
            // 
            // LabelEmpty
            // 
            LabelEmpty.AutoSize = true;
            LabelEmpty.BackColor = SystemColors.Window;
            LabelEmpty.ForeColor = SystemColors.ControlText;
            LabelEmpty.Location = new Point(181, 436);
            LabelEmpty.Name = "LabelEmpty";
            LabelEmpty.Size = new Size(123, 32);
            LabelEmpty.TabIndex = 4;
            LabelEmpty.Text = "Empty List";
            // 
            // ListViewImages
            // 
            ListViewImages.Dock = DockStyle.Fill;
            ListViewImages.Location = new Point(0, 45);
            ListViewImages.Margin = new Padding(4, 2, 4, 2);
            ListViewImages.Name = "ListViewImages";
            ListViewImages.Size = new Size(474, 951);
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
            MainPanel.Margin = new Padding(4, 2, 4, 2);
            MainPanel.Name = "MainPanel";
            MainPanel.Padding = new Padding(0, 0, 0, 120);
            MainPanel.Size = new Size(1898, 1116);
            MainPanel.TabIndex = 2;
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
            TabControlMain.Size = new Size(1424, 996);
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
            tabPagePatients.Size = new Size(1408, 942);
            tabPagePatients.TabIndex = 0;
            tabPagePatients.Text = "Patients";
            tabPagePatients.UseVisualStyleBackColor = true;
            // 
            // PanelPatients
            // 
            PanelPatients.BackColor = Color.Transparent;
            PanelPatients.Dock = DockStyle.Fill;
            PanelPatients.Location = new Point(556, 6);
            PanelPatients.Margin = new Padding(6);
            PanelPatients.Name = "PanelPatients";
            PanelPatients.Size = new Size(846, 930);
            PanelPatients.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnSelectedPatient);
            panel1.Controls.Add(btnSearchPatient);
            panel1.Controls.Add(btnCreateNewPatient);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(6, 6);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 930);
            panel1.TabIndex = 0;
            // 
            // BtnSelectedPatient
            // 
            BtnSelectedPatient.Location = new Point(6, 183);
            BtnSelectedPatient.Margin = new Padding(6);
            BtnSelectedPatient.Name = "BtnSelectedPatient";
            BtnSelectedPatient.Size = new Size(539, 102);
            BtnSelectedPatient.TabIndex = 3;
            BtnSelectedPatient.Text = "Selected Patient";
            BtnSelectedPatient.UseVisualStyleBackColor = true;
            BtnSelectedPatient.Click += BtnSelectedPatient_Click;
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
            // tabPageCapture
            // 
            tabPageCapture.Controls.Add(BtnCapture);
            tabPageCapture.Controls.Add(PictureBoxCamera);
            tabPageCapture.Location = new Point(8, 46);
            tabPageCapture.Margin = new Padding(6);
            tabPageCapture.Name = "tabPageCapture";
            tabPageCapture.Padding = new Padding(6);
            tabPageCapture.Size = new Size(1408, 942);
            tabPageCapture.TabIndex = 1;
            tabPageCapture.Text = "Capture";
            tabPageCapture.UseVisualStyleBackColor = true;
            // 
            // BtnCapture
            // 
            BtnCapture.Dock = DockStyle.Bottom;
            BtnCapture.Location = new Point(6, 855);
            BtnCapture.Margin = new Padding(4, 2, 4, 2);
            BtnCapture.Name = "BtnCapture";
            BtnCapture.Size = new Size(1396, 81);
            BtnCapture.TabIndex = 2;
            BtnCapture.Text = "Capture";
            BtnCapture.UseVisualStyleBackColor = true;
            BtnCapture.Click += BtnCapture_Click;
            // 
            // PictureBoxCamera
            // 
            PictureBoxCamera.Dock = DockStyle.Fill;
            PictureBoxCamera.Location = new Point(6, 6);
            PictureBoxCamera.Margin = new Padding(4, 2, 4, 2);
            PictureBoxCamera.Name = "PictureBoxCamera";
            PictureBoxCamera.Size = new Size(1396, 930);
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
            TabPageCompare.Size = new Size(1408, 942);
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
            tableLayoutPanel1.Margin = new Padding(4, 2, 4, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1408, 942);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // PictureBoxTopLeft
            // 
            PictureBoxTopLeft.BackColor = Color.WhiteSmoke;
            PictureBoxTopLeft.Dock = DockStyle.Fill;
            PictureBoxTopLeft.Location = new Point(4, 2);
            PictureBoxTopLeft.Margin = new Padding(4, 2, 4, 2);
            PictureBoxTopLeft.Name = "PictureBoxTopLeft";
            PictureBoxTopLeft.Size = new Size(696, 467);
            PictureBoxTopLeft.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBoxTopLeft.TabIndex = 0;
            PictureBoxTopLeft.TabStop = false;
            PictureBoxTopLeft.Click += PictureBoxTopLeft_Click;
            // 
            // PictureBoxBottomRight
            // 
            PictureBoxBottomRight.BackColor = Color.WhiteSmoke;
            PictureBoxBottomRight.Dock = DockStyle.Fill;
            PictureBoxBottomRight.Location = new Point(708, 473);
            PictureBoxBottomRight.Margin = new Padding(4, 2, 4, 2);
            PictureBoxBottomRight.Name = "PictureBoxBottomRight";
            PictureBoxBottomRight.Size = new Size(696, 467);
            PictureBoxBottomRight.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBoxBottomRight.TabIndex = 3;
            PictureBoxBottomRight.TabStop = false;
            PictureBoxBottomRight.Click += PictureBoxBottomRight_Click;
            // 
            // PictureBoxTopRight
            // 
            PictureBoxTopRight.BackColor = Color.WhiteSmoke;
            PictureBoxTopRight.Dock = DockStyle.Fill;
            PictureBoxTopRight.Location = new Point(708, 2);
            PictureBoxTopRight.Margin = new Padding(4, 2, 4, 2);
            PictureBoxTopRight.Name = "PictureBoxTopRight";
            PictureBoxTopRight.Size = new Size(696, 467);
            PictureBoxTopRight.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBoxTopRight.TabIndex = 1;
            PictureBoxTopRight.TabStop = false;
            PictureBoxTopRight.Click += PictureBoxTopRight_Click;
            // 
            // PictureBoxBottomLeft
            // 
            PictureBoxBottomLeft.BackColor = Color.WhiteSmoke;
            PictureBoxBottomLeft.Dock = DockStyle.Fill;
            PictureBoxBottomLeft.Location = new Point(4, 473);
            PictureBoxBottomLeft.Margin = new Padding(4, 2, 4, 2);
            PictureBoxBottomLeft.Name = "PictureBoxBottomLeft";
            PictureBoxBottomLeft.Size = new Size(696, 467);
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
            tabPagemark.Size = new Size(1408, 942);
            tabPagemark.TabIndex = 3;
            tabPagemark.Text = "Mark";
            tabPagemark.UseVisualStyleBackColor = true;
            // 
            // MainPanelMark
            // 
            MainPanelMark.Controls.Add(PanelMarkContainer);
            MainPanelMark.Dock = DockStyle.Fill;
            MainPanelMark.Location = new Point(0, 0);
            MainPanelMark.Margin = new Padding(6);
            MainPanelMark.Name = "MainPanelMark";
            MainPanelMark.Size = new Size(1408, 942);
            MainPanelMark.TabIndex = 1;
            // 
            // PanelMarkContainer
            // 
            PanelMarkContainer.Controls.Add(PanelMark);
            PanelMarkContainer.Dock = DockStyle.Fill;
            PanelMarkContainer.Location = new Point(0, 0);
            PanelMarkContainer.Margin = new Padding(4, 2, 4, 2);
            PanelMarkContainer.Name = "PanelMarkContainer";
            PanelMarkContainer.Size = new Size(1408, 942);
            PanelMarkContainer.TabIndex = 0;
            // 
            // PanelMark
            // 
            PanelMark.BackColor = Color.Gainsboro;
            PanelMark.Dock = DockStyle.Fill;
            PanelMark.Location = new Point(0, 0);
            PanelMark.Margin = new Padding(6);
            PanelMark.Name = "PanelMark";
            PanelMark.Size = new Size(1408, 942);
            PanelMark.TabIndex = 3;
            // 
            // Settings
            // 
            Settings.Controls.Add(label1);
            Settings.Controls.Add(comboBoxCameraList);
            Settings.Location = new Point(8, 46);
            Settings.Margin = new Padding(6);
            Settings.Name = "Settings";
            Settings.Size = new Size(1408, 942);
            Settings.TabIndex = 4;
            Settings.Text = "Settings";
            Settings.UseVisualStyleBackColor = true;
            // 
            // BottomPanel
            // 
            BottomPanel.BackColor = Color.Transparent;
            BottomPanel.BorderStyle = BorderStyle.FixedSingle;
            BottomPanel.Controls.Add(LabelCurrentPatient);
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(0, 996);
            BottomPanel.Margin = new Padding(4, 2, 4, 2);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(1898, 64);
            BottomPanel.TabIndex = 3;
            // 
            // LabelCurrentPatient
            // 
            LabelCurrentPatient.AutoSize = true;
            LabelCurrentPatient.Location = new Point(15, 17);
            LabelCurrentPatient.Margin = new Padding(4, 0, 4, 0);
            LabelCurrentPatient.Name = "LabelCurrentPatient";
            LabelCurrentPatient.Size = new Size(245, 32);
            LabelCurrentPatient.TabIndex = 0;
            LabelCurrentPatient.Text = "Current Patient: None";
            // 
            // comboBoxCameraList
            // 
            comboBoxCameraList.FormattingEnabled = true;
            comboBoxCameraList.Location = new Point(151, 71);
            comboBoxCameraList.Name = "comboBoxCameraList";
            comboBoxCameraList.Size = new Size(280, 40);
            comboBoxCameraList.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 74);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 1;
            label1.Text = "Device";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1060);
            Controls.Add(BottomPanel);
            Controls.Add(MainPanel);
            Margin = new Padding(6);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jared";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            PanelPictureList.ResumeLayout(false);
            PanelPictureList.PerformLayout();
            MainPanel.ResumeLayout(false);
            TabControlMain.ResumeLayout(false);
            tabPagePatients.ResumeLayout(false);
            panel1.ResumeLayout(false);
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
            PanelMarkContainer.ResumeLayout(false);
            Settings.ResumeLayout(false);
            Settings.PerformLayout();
            BottomPanel.ResumeLayout(false);
            BottomPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelPictureList;
        private ImageList ImageListMain;
        private Panel MainPanel;
        private Panel BottomPanel;
        private Label LabelCurrentPatient;
        private ListView ListViewImages;
        private TabControl TabControlMain;
        private TabPage tabPagePatients;
        private Panel PanelPatients;
        private Panel panel1;
        private Button BtnSelectedPatient;
        private Button btnSearchPatient;
        private Button btnCreateNewPatient;
        private TabPage tabPageCapture;
        private Button BtnCapture;
        private PictureBox PictureBoxCamera;
        private TabPage TabPageCompare;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox PictureBoxTopLeft;
        private PictureBox PictureBoxBottomRight;
        private PictureBox PictureBoxTopRight;
        private PictureBox PictureBoxBottomLeft;
        private TabPage tabPagemark;
        private Panel MainPanelMark;
        private Panel PanelMarkContainer;
        private Panel PanelMark;
        private TabPage Settings;
        private Label LabelEmpty;
        private Label label1;
        private ComboBox comboBoxCameraList;
    }
}
