﻿namespace Jared.UserControls {
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
            buttonSaveMark = new Button();
            buttonDrawMode = new Button();
            groupBox1 = new GroupBox();
            trackBarPen = new TrackBar();
            groupBox2 = new GroupBox();
            radioButtonGreen = new RadioButton();
            radioButtonBlue = new RadioButton();
            radioButtonRed = new RadioButton();
            buttonClear = new Button();
            panel1.SuspendLayout();
            PanelPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxMark).BeginInit();
            PanelMarkControllers.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarPen).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(PanelPictureBox);
            panel1.Controls.Add(PanelMarkControllers);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1646, 1099);
            panel1.TabIndex = 1;
            // 
            // PanelPictureBox
            // 
            PanelPictureBox.Controls.Add(PictureBoxMark);
            PanelPictureBox.Dock = DockStyle.Fill;
            PanelPictureBox.Location = new Point(0, 0);
            PanelPictureBox.Name = "PanelPictureBox";
            PanelPictureBox.Size = new Size(1646, 853);
            PanelPictureBox.TabIndex = 4;
            // 
            // PictureBoxMark
            // 
            PictureBoxMark.Dock = DockStyle.Fill;
            PictureBoxMark.Location = new Point(0, 0);
            PictureBoxMark.Name = "PictureBoxMark";
            PictureBoxMark.Size = new Size(1646, 853);
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
            PanelMarkControllers.Controls.Add(buttonClear);
            PanelMarkControllers.Controls.Add(buttonSaveMark);
            PanelMarkControllers.Controls.Add(buttonDrawMode);
            PanelMarkControllers.Controls.Add(groupBox1);
            PanelMarkControllers.Controls.Add(groupBox2);
            PanelMarkControllers.Dock = DockStyle.Bottom;
            PanelMarkControllers.Location = new Point(0, 853);
            PanelMarkControllers.Margin = new Padding(6);
            PanelMarkControllers.Name = "PanelMarkControllers";
            PanelMarkControllers.Size = new Size(1646, 246);
            PanelMarkControllers.TabIndex = 3;
            // 
            // buttonSaveMark
            // 
            buttonSaveMark.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSaveMark.Location = new Point(1408, 35);
            buttonSaveMark.Name = "buttonSaveMark";
            buttonSaveMark.Size = new Size(205, 46);
            buttonSaveMark.TabIndex = 7;
            buttonSaveMark.Text = "Save";
            buttonSaveMark.UseVisualStyleBackColor = true;
            // 
            // buttonDrawMode
            // 
            buttonDrawMode.Location = new Point(519, 35);
            buttonDrawMode.Name = "buttonDrawMode";
            buttonDrawMode.Size = new Size(232, 53);
            buttonDrawMode.TabIndex = 6;
            buttonDrawMode.Text = "Draw mode";
            buttonDrawMode.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(trackBarPen);
            groupBox1.Location = new Point(16, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 156);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Line width";
            // 
            // trackBarPen
            // 
            trackBarPen.Location = new Point(17, 47);
            trackBarPen.Name = "trackBarPen";
            trackBarPen.Size = new Size(208, 90);
            trackBarPen.TabIndex = 2;
            trackBarPen.Scroll += trackBarPen_Scroll;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonGreen);
            groupBox2.Controls.Add(radioButtonBlue);
            groupBox2.Controls.Add(radioButtonRed);
            groupBox2.Location = new Point(281, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(191, 208);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Color";
            // 
            // radioButtonGreen
            // 
            radioButtonGreen.AutoSize = true;
            radioButtonGreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonGreen.ForeColor = Color.Lime;
            radioButtonGreen.Location = new Point(30, 130);
            radioButtonGreen.Name = "radioButtonGreen";
            radioButtonGreen.Size = new Size(113, 36);
            radioButtonGreen.TabIndex = 2;
            radioButtonGreen.Text = "Green";
            radioButtonGreen.UseVisualStyleBackColor = true;
            radioButtonGreen.CheckedChanged += radioButtonGreen_CheckedChanged;
            // 
            // radioButtonBlue
            // 
            radioButtonBlue.AutoSize = true;
            radioButtonBlue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonBlue.ForeColor = Color.Blue;
            radioButtonBlue.Location = new Point(30, 88);
            radioButtonBlue.Name = "radioButtonBlue";
            radioButtonBlue.Size = new Size(95, 36);
            radioButtonBlue.TabIndex = 1;
            radioButtonBlue.Text = "Blue";
            radioButtonBlue.UseVisualStyleBackColor = true;
            radioButtonBlue.CheckedChanged += radioButtonBlue_CheckedChanged;
            // 
            // radioButtonRed
            // 
            radioButtonRed.AutoSize = true;
            radioButtonRed.Checked = true;
            radioButtonRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonRed.ForeColor = Color.Red;
            radioButtonRed.Location = new Point(30, 47);
            radioButtonRed.Name = "radioButtonRed";
            radioButtonRed.Size = new Size(88, 36);
            radioButtonRed.TabIndex = 0;
            radioButtonRed.TabStop = true;
            radioButtonRed.Text = "Red";
            radioButtonRed.UseVisualStyleBackColor = true;
            radioButtonRed.CheckedChanged += radioButtonRed_CheckedChanged;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClear.Location = new Point(1408, 109);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(205, 46);
            buttonClear.TabIndex = 8;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // MarkingUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "MarkingUserControl";
            Size = new Size(1646, 1099);
            panel1.ResumeLayout(false);
            PanelPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBoxMark).EndInit();
            PanelMarkControllers.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarPen).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel PanelMarkControllers;
        private Panel PanelPictureBox;
        private PictureBox PictureBoxMark;
        private TrackBar trackBarPen;
        private GroupBox groupBox2;
        private RadioButton radioButtonRed;
        private GroupBox groupBox1;
        private RadioButton radioButtonGreen;
        private RadioButton radioButtonBlue;
        private Button buttonDrawMode;
        private Button buttonSaveMark;
        private Button buttonClear;
    }
}
