namespace Jared.UserControls {
    partial class MarkingUserControl {
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
            panel1 = new Panel();
            PanelPictureBox = new Panel();
            PictureBoxMark = new PictureBox();
            PanelMarkControllers = new Panel();
            trackBarPen = new TrackBar();
            panel1.SuspendLayout();
            PanelPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxMark).BeginInit();
            PanelMarkControllers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarPen).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(PanelPictureBox);
            panel1.Controls.Add(PanelMarkControllers);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1632, 1065);
            panel1.TabIndex = 1;
            // 
            // PanelPictureBox
            // 
            PanelPictureBox.Controls.Add(PictureBoxMark);
            PanelPictureBox.Dock = DockStyle.Fill;
            PanelPictureBox.Location = new Point(0, 0);
            PanelPictureBox.Name = "PanelPictureBox";
            PanelPictureBox.Size = new Size(1632, 852);
            PanelPictureBox.TabIndex = 4;
            // 
            // PictureBoxMark
            // 
            PictureBoxMark.Dock = DockStyle.Fill;
            PictureBoxMark.Location = new Point(0, 0);
            PictureBoxMark.Name = "PictureBoxMark";
            PictureBoxMark.Size = new Size(1632, 852);
            PictureBoxMark.TabIndex = 1;
            PictureBoxMark.TabStop = false;
            PictureBoxMark.Paint += PictureBoxMark_Paint;
            PictureBoxMark.MouseDown += PictureBoxMark_MouseDown;
            PictureBoxMark.MouseMove += PictureBoxMark_MouseMove;
            PictureBoxMark.MouseUp += PictureBoxMark_MouseUp;
            // 
            // PanelMarkControllers
            // 
            PanelMarkControllers.BackColor = Color.WhiteSmoke;
            PanelMarkControllers.Controls.Add(trackBarPen);
            PanelMarkControllers.Dock = DockStyle.Bottom;
            PanelMarkControllers.Location = new Point(0, 852);
            PanelMarkControllers.Margin = new Padding(6);
            PanelMarkControllers.Name = "PanelMarkControllers";
            PanelMarkControllers.Size = new Size(1632, 213);
            PanelMarkControllers.TabIndex = 3;
            // 
            // trackBarPen
            // 
            trackBarPen.Location = new Point(53, 37);
            trackBarPen.Name = "trackBarPen";
            trackBarPen.Size = new Size(208, 90);
            trackBarPen.TabIndex = 2;
            trackBarPen.Scroll += trackBarPen_Scroll;
            // 
            // MarkingUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "MarkingUserControl";
            Size = new Size(1632, 1065);
            panel1.ResumeLayout(false);
            PanelPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBoxMark).EndInit();
            PanelMarkControllers.ResumeLayout(false);
            PanelMarkControllers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarPen).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel PanelMarkControllers;
        private Panel PanelPictureBox;
        private PictureBox PictureBoxMark;
        private TrackBar trackBarPen;
    }
}
