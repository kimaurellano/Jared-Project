using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jared.UserControls {
    public partial class MarkingUserControl : UserControl {

        // PictureBox Compare
        private Point startPoint;
        private Point currentPoint;
        private bool isDrawing = false;

        public MarkingUserControl() {
            InitializeComponent();

            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            Dock = DockStyle.Fill;

            // Initialize the PictureBox with a blank bitmap
            Bitmap bitmap = new(PictureBoxMark.Width, PictureBoxMark.Height);
            PictureBoxMark.Image = bitmap;

            // Wire up the mouse events
            PictureBoxMark.MouseDown += pictureBox_MouseDown;
            PictureBoxMark.MouseMove += pictureBox_MouseMove;
            PictureBoxMark.MouseUp += pictureBox_MouseUp;
            PictureBoxMark.Paint += pictureBox_Paint;
        }

        // Displays selected image from Image List to picture boxes in Compare Tab
        public void DisplaySelectedImage(Image image) {
            PictureBoxMark.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxMark.Image = image;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                isDrawing = true;
                startPoint = e.Location;
                currentPoint = e.Location;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e) {
            if (isDrawing) {
                currentPoint = e.Location;
                PictureBoxMark.Invalidate();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e) {
            if (isDrawing) {
                isDrawing = false;
                DrawCircle();
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e) {
            if (isDrawing) {
                Rectangle rect = GetCircleRectangle(startPoint, currentPoint);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawEllipse(Pens.Red, rect);
            }
        }

        private void DrawCircle() {
            using (Graphics g = Graphics.FromImage(PictureBoxMark.Image)) {
                Rectangle rect = GetCircleRectangle(startPoint, currentPoint);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawEllipse(Pens.Red, rect);
            }
            PictureBoxMark.Invalidate();
        }

        private Rectangle GetCircleRectangle(Point p1, Point p2) {
            // Calculate the radius
            int radius = (int)Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));

            // Create the rectangle that bounds the circle
            Rectangle rect = new Rectangle(
                p1.X - radius,
                p1.Y - radius,
                radius * 2,
                radius * 2
            );
            return rect;
        }
    }
}
