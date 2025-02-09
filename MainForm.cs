using AForge.Video;
using Madentra.helpers;
using System.ComponentModel;
using Madentra.UserControls;
using System.Diagnostics;
using Jared.helpers;
using Jared.UserControls;
using System.Reflection.Metadata;

namespace Madentra {
    public partial class MainForm : Form {

        // VideoFeeds
        private DBHelpers dbHelpers = new();
        private VideoFeedManager singleFeedManager;
        private VideoFeedManager quadFeedManager;
        private string selectedDeviceCamera;

        // UserControls
        private DataGridViewPatientUserControl dataGridViewPatientUserControl;
        private SearchPatientUserControl searchPatientUserControl;
        private CreateNewPatientUserControl createNewPatientUserControl;
        private MarkingUserControl markingUserControl;

        // To remember selected image in the listview
        private int lastSelectedIndex = -1;
        private Image? lastSelectedImage = null;

        private DeviceInterruptFilter filter;
        private DeviceIdFinder deviceIdFinder;

        public MainForm() {
            InitializeComponent();
            Debug.WriteLine($"{Name}");
            InitializeListView();
            InitializePages();
            LoadAvailableCaptureDevices();

            LabelCurrentPatient.Text = $"Current Patient: {dbHelpers.GetSelectedPatient().FullName}";
        }

        private void InitializePages() {
            //RunPython();
            
            deviceIdFinder = new DeviceIdFinder();
            searchPatientUserControl = new SearchPatientUserControl();
            createNewPatientUserControl = new CreateNewPatientUserControl();
            markingUserControl = new MarkingUserControl();

            PanelPatients.Controls.Add(searchPatientUserControl);
            PanelPatients.Controls.Add(createNewPatientUserControl);
            PanelMark.Controls.Add(markingUserControl);

            selectedDeviceCamera = comboBoxCameraList.Text;

            singleFeedManager = new VideoFeedManager();
            singleFeedManager.SetPictureBoxes(PictureBoxCamera);

            quadFeedManager = new VideoFeedManager();
            quadFeedManager.SetPictureBoxes(
                    PictureBoxBottomLeft,
                    PictureBoxBottomRight,
                    PictureBoxTopLeft,
                    PictureBoxTopRight);

            // Default control to show on load.
            ShowContentInTabPatients(searchPatientUserControl);

            searchPatientUserControl.DataGridViewPatientUserControlInstance.PropertyChanged += DataGridViewPatientUserControlInstance_PropertyChanged;
            createNewPatientUserControl.PropertyChanged += CreateNewPatientUserControlInstance_PropertyChanged;
            markingUserControl.ImageInsertedProperty += MarkingUserControlInstance_PropertyChanged;
        }

        private void RunPython() {
            try {
                // Run script in the background (no console window)
                DeviceInterruptFilter.RunPythonScriptAsync();

                filter = new DeviceInterruptFilter();
                filter.StartReadLog();
                // Log updates means button event was triggered from USBPcap interface
                filter.LogUpdated += OnLogUpdated;
            }
            catch (Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void OnLogUpdated(string logLine) {
            ImageCapture();
        }

        private void MarkingUserControlInstance_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            InitializeListView();
        }

        private void DataGridViewPatientUserControlInstance_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            LabelCurrentPatient.Text = $"Current Patient: {dbHelpers.GetSelectedPatient().FullName}";
        }

        private void CreateNewPatientUserControlInstance_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            ShowContentInTabPatients(searchPatientUserControl);
            searchPatientUserControl.ShowDefaultPanel();
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
                deviceIdFinder.FindDeviceIDOf(selectedDeviceCamera);
                // Force user to redirect to camera setup
                if (!singleFeedManager.IsCameraRunning) {
                    TabControlMain.SelectedIndex = 4;
                }
                quadFeedManager.StopFeed();
            }
            else if (TabControlMain.SelectedIndex == 2) {
                quadFeedManager.StartFeed();
                // Force user to redirect to camera setup
                if (!singleFeedManager.IsCameraRunning) {
                    TabControlMain.SelectedIndex = 4;
                }
                singleFeedManager.StopFeed();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            singleFeedManager.StopFeed();
            quadFeedManager.StopFeed();
            
            filter.StopReadLog();
        }

        private void BtnCapture_Click(object sender, EventArgs e) {
            Debug.WriteLine("Capturing picturebox");
            ImageCapture();
        }

        private void ImageCapture() {
            if (PictureBoxCamera.Image != null) {
                try {
                    // Clone the image to prevent cross-thread issues
                    using (Image capturedImage = (Image)PictureBoxCamera.Image.Clone()) {
                        string patientName = dbHelpers.GetSelectedPatient().FullName;

                        DateTime dateTime = DateTime.Now;
                        DateTime epoch = new(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                        var epochTime = (long)(dateTime.ToUniversalTime() - epoch).TotalSeconds;

                        // Define file path
                        string filePath = $"{patientName}_{epochTime}.png";
                        string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        string fullFilePath = Path.Combine(documentsPath, filePath);

                        // Save the cloned image
                        capturedImage.Save(fullFilePath, System.Drawing.Imaging.ImageFormat.Png);
                        Debug.WriteLine("Image captured and saved to " + fullFilePath);

                        // Insert image into database as blob
                        dbHelpers.SaveImageToDatabase(capturedImage);

                        if (ListViewImages.InvokeRequired) {
                            ListViewImages.Invoke(new Action(InitializeListView));
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Error capturing image: " + ex.Message);
                }
            }
            else {
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
            List<KeyValuePair<long, Image>> temp = dbHelpers.GetAllImages();
            foreach (var image in temp) {
                ImageListMain.Images.Add(image.Value);
            }

            if (temp.Count > 0) {
                LabelEmpty.Visible = false;
            }

            // Configure the ListView
            ListViewImages.View = View.LargeIcon;
            ListViewImages.LargeImageList = ImageListMain;

            // Add items to the ListView
            for (int i = 0; i < ImageListMain.Images.Count; i++) {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i; // Associate image with the item
                item.Text = temp[i].Key.ToString(); // Optionally add a text label
                ListViewImages.Items.Add(item);
            }
        }

        private void ListViewImages_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            if (ListViewImages.SelectedItems.Count > 0) {
                // Get the selected item
                ListViewItem selectedItem = ListViewImages.SelectedItems[0];

                // Get blob ID from the database and remember.
                lastSelectedImage = dbHelpers.GetImage(Convert.ToInt64(selectedItem.Text));

                markingUserControl.DisplaySelectedImage(lastSelectedImage);
            }
        }

        private void PictureBoxTopRight_Click(object sender, EventArgs e) {
            quadFeedManager.StopFeed(PictureBoxTopRight);
            DisplaySelectedImage(PictureBoxTopRight, lastSelectedImage);
        }

        private void PictureBoxTopLeft_Click(object sender, EventArgs e) {
            quadFeedManager.StopFeed(PictureBoxTopLeft);
            DisplaySelectedImage(PictureBoxTopLeft, lastSelectedImage);
        }

        private void PictureBoxBottomLeft_Click(object sender, EventArgs e) {
            quadFeedManager.StopFeed(PictureBoxBottomLeft);
            DisplaySelectedImage(PictureBoxBottomLeft, lastSelectedImage);
        }

        private void PictureBoxBottomRight_Click(object sender, EventArgs e) {
            quadFeedManager.StopFeed(PictureBoxBottomRight);
            DisplaySelectedImage(PictureBoxBottomRight, lastSelectedImage);
        }

        // Displays selected image from Image List to picture boxes in Compare Tab
        private void DisplaySelectedImage(PictureBox pictureBox, Image image) {
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = image;
        }

        private void BtnSelectedPatient_Click(object sender, EventArgs e) {
            if (dbHelpers.GetSelectedPatient().FullName == null) {
                MessageBox.Show("No patient selected.");
                LabelCurrentPatient.Text = string.Empty;
                return;
            }

            ShowContentInTabPatients(searchPatientUserControl);
            searchPatientUserControl.ShowSelectedPatientPanel();
        }

        private void LoadAvailableCaptureDevices() {
            foreach (var item in VideoFeedManager.ListAvailableCameras()) {
                comboBoxCameraList.Items.Add(item);
            }
        }

        private void comboBoxCameraList_SelectedIndexChanged(object sender, EventArgs e) {
            selectedDeviceCamera = comboBoxCameraList.Text;
            singleFeedManager.SetVideoSource(selectedDeviceCamera);
            quadFeedManager.SetVideoSource(selectedDeviceCamera);
        }
    }
}
