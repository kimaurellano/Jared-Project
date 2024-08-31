using AForge.Video.DirectShow;
using AForge.Video;
using Madentra.helpers;
using System.ComponentModel;
using Madentra.UserControls;
using System.Diagnostics;

namespace Madentra {
    public partial class MainForm : Form {

        private DBHelpers dbHelpers = new();
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        private DataGridViewPatientUserControl dataGridViewPatientUserControl;
        private SearchPatientUserControl searchPatientUserControl;
        private CreateNewPatientUserControl createNewPatientUserControl;

        public MainForm() {
            InitializeComponent();
            Debug.WriteLine($"{Name}");
            InitializeListView();
            InitializePages();
        }

        private void SelectedPatient_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == nameof(DataGridViewPatientUserControl.SelectedPatient)) {
                // Handle the property change
                LabelCurrentPatient.Text = $"Current Patient: {dbHelpers.GetSelectedPatient().Name}";
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
        }

        private void DataGridViewPatientUserControlInstance_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            LabelCurrentPatient.Text = $"Current Patient: {dbHelpers.GetSelectedPatient().Name}";
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

        private void InitializeCamera() {
            // Get the available video devices
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0) {
                MessageBox.Show("No video sources found");
                return;
            }

            // Choose the first available video device
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);

            // Set NewFrame event handler to capture frames from the video source
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);

            // Start the video source
            videoSource.Start();
        }

        private void CloseCamera() {
            // Stop the video source when closing the form
            if (videoSource != null && videoSource.IsRunning) {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs) {
            // Get the frame from the camera
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

            // Display the frame in the PictureBox
            PictureBoxCamera.Image = frame;
            PictureBoxCamera.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControlMain != null) {
                if (tabControlMain.SelectedIndex == 1) {
                    InitializeCamera();
                } else {
                    CloseCamera();
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            CloseCamera();
        }

        private void BtnCapture_Click(object sender, EventArgs e) {
            // Capture the image displayed in the PictureBox
            if (PictureBoxCamera.Image != null) {
                string patientName = dbHelpers.GetSelectedPatient().Name;

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
    }
}
