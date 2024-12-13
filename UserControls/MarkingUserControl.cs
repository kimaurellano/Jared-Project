namespace Jared.UserControls {
    public partial class MarkingUserControl : UserControl {

        // PictureBox Compare
        private bool isMoving = false;
        private Point mouseDownPosition = Point.Empty;
        private Point mouseMovePosition = Point.Empty;
        // Key: Start Point, Value: Tuple<End Point, Thickness>
        private Dictionary<Point, (Point EndPoint, float Thickness, Color Color)> circles = new();


        private float currentPenThickness = 2.0f; // Adjustable thickness for the current ellipse
        private Color currentColor = Color.Red; // Default red


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
            // Pen for the current ellipse
            Pen currentPen = new(currentColor, currentPenThickness);

            var g = e.Graphics;

            // Draw the currently moving ellipse with adjustable thickness
            if (isMoving) {
                g.DrawEllipse(
                    currentPen,
                    new Rectangle(
                        mouseDownPosition,
                        new Size(mouseMovePosition.X - mouseDownPosition.X, mouseMovePosition.Y - mouseDownPosition.Y)
                    )
                );
            }

            // Draw all stored ellipses with a fixed thickness
            foreach (var circle in circles) {
                using Pen pen = new(circle.Value.Color, circle.Value.Thickness);
                g.DrawEllipse(
                    pen,
                    new Rectangle(
                        circle.Key,
                        new Size(circle.Value.EndPoint.X - circle.Key.X, circle.Value.EndPoint.Y - circle.Key.Y)
                    )
                );
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
                circles.Add(mouseDownPosition, (mouseMovePosition, currentPenThickness, currentColor));
            }
            isMoving = false;
        }

        // Displays selected image from Image List to picture boxes in Compare Tab
        public void DisplaySelectedImage(Image image) {
            if (PictureBoxMark.Image != null) {
                MessageBox.Show("Markings will be removed upon selection change. Are you sure?");
                circles.Clear();
            }

            PictureBoxMark.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxMark.Image = image;
        }

        private void trackBarPen_Scroll(object sender, EventArgs e) {
            currentPenThickness = trackBarPen.Value;
            PictureBoxMark.Invalidate(); // Refresh the PictureBox to apply the new thickness
        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonRed.Checked) {
                currentColor = Color.Red;
            }
        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonBlue.Checked) {
                currentColor = Color.Blue;
            }
        }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonGreen.Checked) {
                currentColor = Color.Green;
            }
        }
    }
}
