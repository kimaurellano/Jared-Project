using System.Diagnostics;

namespace Jared.UserControls {
    public partial class MarkingUserControl : UserControl {

        // PictureBox Compare
        private bool isMoving = false;
        private Point mouseDownPosition = Point.Empty;
        private Point mouseMovePosition = Point.Empty;
        private Dictionary<Point, Point> circles = new();

        public MarkingUserControl() {
            InitializeComponent();

            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            Dock = DockStyle.Fill;

            // Wire up the mouse events
            PictureBoxMark.TabIndex = 0;
            PictureBoxMark.TabStop = false;
            PictureBoxMark.Paint += new PaintEventHandler(PictureBoxMark_Paint);
            PictureBoxMark.MouseDown += new MouseEventHandler(PictureBoxMark_MouseDown);
            PictureBoxMark.MouseMove += new MouseEventHandler(PictureBoxMark_MouseMove);
            PictureBoxMark.MouseUp += new MouseEventHandler(PictureBoxMark_MouseUp);

            // Initialize the PictureBox with a blank bitmap
            Bitmap bitmap = new(PictureBoxMark.Width, PictureBoxMark.Height);
            PictureBoxMark.Image = bitmap;   
        }

        private void PictureBoxMark_Paint(object sender, PaintEventArgs e) {
            Pen p = new(Color.Red);
            var g = e.Graphics;
            if (isMoving) {
                g.DrawEllipse(p, new Rectangle(mouseDownPosition, new Size(mouseMovePosition.X - mouseDownPosition.X, mouseMovePosition.Y - mouseDownPosition.Y)));
                foreach (var circle in circles) {
                    g.DrawEllipse(p, new Rectangle(circle.Key, new Size(circle.Value.X - circle.Key.X, circle.Value.Y - circle.Key.Y)));
                }
            }
        }

        private void PictureBoxMark_MouseDown(object sender, MouseEventArgs e) {
            PictureBoxMark.Cursor = Cursors.Cross;
            isMoving = true;
            mouseDownPosition = e.Location;
        }

        private void PictureBoxMark_MouseMove(object sender, MouseEventArgs e) {
            if (isMoving) {
                mouseMovePosition = e.Location;
                PictureBoxMark.Invalidate();
            }
        }

        private void PictureBoxMark_MouseUp(object sender, MouseEventArgs e) {
            PictureBoxMark.Cursor = Cursors.Default;
            if (isMoving) {
                circles.Add(mouseDownPosition, mouseMovePosition);
            }
            isMoving = false;
        }

        // Displays selected image from Image List to picture boxes in Compare Tab
        public void DisplaySelectedImage(Image image) {
            PictureBoxMark.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxMark.Image = image;
        }
    }
}
