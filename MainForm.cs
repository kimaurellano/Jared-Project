using AForge.Video.DirectShow;
using AForge.Video;
using Madentra.helpers;
using System.ComponentModel;
using Madentra.UserControls;
using System.Diagnostics;
using System.Windows.Forms;
using Jared.helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;

namespace Madentra {
    public partial class MainForm : Form {

        // PictureBox Compare
        private Point startPoint;
        private Point currentPoint;
        private bool isDrawing = false;

        // VideoFeeds
        private DBHelpers dbHelpers = new();
        private VideoFeedManager singleFeedManager;
        private VideoFeedManager quadFeedManager;

        // UserControls
        private DataGridViewPatientUserControl dataGridViewPatientUserControl;
        private SearchPatientUserControl searchPatientUserControl;
        private CreateNewPatientUserControl createNewPatientUserControl;

        // To remember selected image in the listview
        private int lastSelectedIndex = -1;

        public MainForm() {
            InitializeComponent();
            Debug.WriteLine($"{Name}");
            InitializeListView();
            InitializePages();

            LabelCurrentPatient.Text = $"Current Patient: {dbHelpers.GetSelectedPatient().FullName}";

            // Initialize the PictureBox with a blank bitmap
            Bitmap bitmap = new(PictureBoxMark.Width, PictureBoxMark.Height);
            PictureBoxMark.Image = bitmap;

            // Wire up the mouse events
            PictureBoxMark.MouseDown += pictureBox_MouseDown;
            PictureBoxMark.MouseMove += pictureBox_MouseMove;
            PictureBoxMark.MouseUp += pictureBox_MouseUp;
            PictureBoxMark.Paint += pictureBox_Paint;
        }

        #region MouseMarking
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
        #endregion

        private void SelectedPatient_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == nameof(DataGridViewPatientUserControl.SelectedPatient)) {
                // Handle the property change
                LabelCurrentPatient.Text = $"Current Patient: {dbHelpers.GetSelectedPatient().FullName}";
            }
        }

        private void InitializePages() {
            searchPatientUserControl = new SearchPatientUserControl();
            createNewPatientUserControl = new CreateNewPatientUserControl();

            PanelPatients.Controls.Add(searchPatientUserControl);
            PanelPatients.Controls.Add(createNewPatientUserControl);

            // Default control to show on load.
            ShowContentInTabPatients(searchPatientUserControl);

            searchPatientUserControl.DataGridViewPatientUserControlInstance.PropertyChanged += DataGridViewPatientUserControlInstance_PropertyChanged;

            var videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            singleFeedManager = new VideoFeedManager(
                videoDevices,
                PictureBoxCamera);
            quadFeedManager = new VideoFeedManager(
                videoDevices,
                PictureBoxBottomLeft,
                PictureBoxBottomRight,
                PictureBoxTopLeft,
                PictureBoxTopRight);

            TabControlMain.SelectedIndexChanged += TabControlMain_SelectedIndexChanged;
        }

        private void DataGridViewPatientUserControlInstance_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            LabelCurrentPatient.Text = $"Current Patient: {dbHelpers.GetSelectedPatient().FullName}";
        }

        private void BtnCreateNewPatient_Click(object sender, EventArgs e) {
            ShowContentInTabPatients(createNewPatientUserControl);
        }

        private void BtnSearchPatient_Click(object sender, EventArgs e) {
            ShowContentInTabPatients(searchPatientUserControl);
            searchPatientUserControl.ShowDefaultPanel();
        }

        private void ShowContentInTabPatients(UserControl userControl) {
            Panel panel = PanelPatients;
            if (panel != null) {
                foreach (Control control in panel.Controls) {
                    // Check if usercontrol exists in the panel
                    if (userControl.Name == control.Name) {
                        ShowControl(userControl, panel);

                        return;
                    }
                }

                // Only add usercontrol if does not exists in the panel
                userControl.Dock = DockStyle.Fill;
                panel.Controls.Add(userControl);
                ShowControl(userControl, panel);
            }
        }

        private void ShowControl(Control controlToShow, Panel ofPanel) {
            // Loop through all controls in the panel
            foreach (Control control in ofPanel.Controls) {
                control.Visible = false; // Hide all controls
            }

            // Show the selected control
            controlToShow.Visible = true;
            controlToShow.BringToFront(); // Bring the control to the front if needed
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs) {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            // Display the same frame in the single feed PictureBox
            if (TabControlMain.SelectedIndex == 0) {
                PictureBoxCamera.Image?.Dispose();
                PictureBoxCamera.Image = (Bitmap)bitmap.Clone();
            }

            // Display the same frame in all four PictureBoxes
            if (TabControlMain.SelectedIndex == 1) {
                PictureBoxBottomLeft.Image?.Dispose();
                PictureBoxBottomRight.Image?.Dispose();
                PictureBoxTopLeft.Image?.Dispose();
                PictureBoxTopRight.Image?.Dispose();

                PictureBoxBottomLeft.Image = (Bitmap)bitmap.Clone();
                PictureBoxBottomRight.Image = (Bitmap)bitmap.Clone();
                PictureBoxTopLeft.Image = (Bitmap)bitmap.Clone();
                PictureBoxTopRight.Image = (Bitmap)bitmap.Clone();
            }

            // Dispose the original bitmap to free memory
            bitmap.Dispose();
        }

        private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e) {
            // We do not need feed on other tabs
            if (TabControlMain.SelectedIndex != 1 && TabControlMain.SelectedIndex != 2) {
                singleFeedManager.StopFeed();
                quadFeedManager.StopFeed();
            }

            if (TabControlMain.SelectedIndex == 1) {
                singleFeedManager.StartFeed();
                quadFeedManager.StopFeed();
            } else if (TabControlMain.SelectedIndex == 2) {
                quadFeedManager.StartFeed();
                singleFeedManager.StopFeed();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            singleFeedManager.StopFeed();
            quadFeedManager.StopFeed();
        }

        private void BtnCapture_Click(object sender, EventArgs e) {
            // Capture the image displayed in the PictureBox
            if (PictureBoxCamera.Image != null) {
                string patientName = dbHelpers.GetSelectedPatient().FullName;

                DateTime dateTime = DateTime.Now;
                DateTime epoch = new(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                var epochTime = (long)(dateTime.ToUniversalTime() - epoch).TotalSeconds;

                // Save the image to a file
                string filePath = $"{patientName}_{epochTime}.png"; // You can customize the file path and name
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                PictureBoxCamera.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

                MessageBox.Show("Image captured and saved to " + filePath);

                // Insert image into to database as blob.
                dbHelpers.SaveImageToDatabase(PictureBoxCamera.Image);

                // This should effectively restart the image list
                InitializeListView();
            } else {
                MessageBox.Show("No image to capture.");
            }
        }

        // Image List on the right panel
        private void InitializeListView() {
            // Clear first before populating
            ListViewImages.Items.Clear();
            ImageListMain.Images.Clear();

            ImageListMain.ImageSize = new Size(256, 156); // Set image size

            // Add images to the ImageList
            List<Image> temp = dbHelpers.GetAllImages();
            foreach (Image image in temp) {
                ImageListMain.Images.Add(image);
            }

            // Configure the ListView
            ListViewImages.View = View.LargeIcon;
            ListViewImages.LargeImageList = ImageListMain;

            // Add items to the ListView
            for (int i = 0; i < ImageListMain.Images.Count; i++) {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i; // Associate image with the item
                item.Text = $"Image {i + 1}"; // Optionally add a text label
                ListViewImages.Items.Add(item);
            }
        }

        private void ListViewImages_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            if (ListViewImages.SelectedItems.Count > 0) {
                // Get the selected item
                ListViewItem selectedItem = ListViewImages.SelectedItems[0];

                // Just remember the last selected item
                lastSelectedIndex = selectedItem.Index;

                DisplaySelectedImage(PictureBoxMark);
            }
        }

        private void PictureBoxTopRight_Click(object sender, EventArgs e) {
            quadFeedManager.StopFeed(PictureBoxTopRight);
            DisplaySelectedImage(PictureBoxTopRight);
        }

        private void PictureBoxTopLeft_Click(object sender, EventArgs e) {
            quadFeedManager.StopFeed(PictureBoxTopLeft);
            DisplaySelectedImage(PictureBoxTopLeft);
        }

        private void PictureBoxBottomLeft_Click(object sender, EventArgs e) {
            quadFeedManager.StopFeed(PictureBoxBottomLeft);
            DisplaySelectedImage(PictureBoxBottomLeft);
        }

        private void PictureBoxBottomRight_Click(object sender, EventArgs e) {
            quadFeedManager.StopFeed(PictureBoxBottomRight);
            DisplaySelectedImage(PictureBoxBottomRight);
        }

        // Displays selected image from Image List to picture boxes in Compare Tab
        private void DisplaySelectedImage(PictureBox pictureBox) {
            Image selectedImage = ImageListMain.Images[lastSelectedIndex];
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = selectedImage;
        }

        private void BtnSelectedPatient_Click(object sender, EventArgs e) {
            ShowContentInTabPatients(searchPatientUserControl);
            searchPatientUserControl.ShowSelectedPatientPanel();
        }
    }
}
