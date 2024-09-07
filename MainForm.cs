using AForge.Video.DirectShow;
using AForge.Video;
using Madentra.helpers;
using System.ComponentModel;
using Madentra.UserControls;
using System.Diagnostics;
using System.Windows.Forms;
using Jared.helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Madentra {
    public partial class MainForm : Form {

        private DBHelpers dbHelpers = new();
        private VideoFeedManager singleFeedManager;
        private VideoFeedManager quadFeedManager;

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
        }

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
