using AForge.Video.DirectShow;
using AForge.Video;
using Microsoft.Data.Sqlite;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using Jared.helpers;

namespace Jared {
    public partial class MainForm : Form {

        private DBHelpers dbHelpers = new();
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public MainForm() {
            InitializeComponent();
            InitializeListView();
        }

        private void BtnCreateNewPatient_Click(object sender, EventArgs e) {
            ShowContentInTabPatients(new CreateNewPatientUserControl());
        }

        private void BtnSearchPatient_Click(object sender, EventArgs e) {
            ShowContentInTabPatients(new SearchPatientUserControl());
        }

        private void ShowContentInTabPatients(UserControl userControl) {
            Panel patientsPanel = PanelPatients;
            patientsPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            patientsPanel.Controls.Add(userControl);
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
                DateTime dateTime = DateTime.Now;
                DateTime epoch = new(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                var epochTime = (long)(dateTime.ToUniversalTime() - epoch).TotalSeconds;

                // Save the image to a file
                string filePath = $"{epochTime}.png"; // You can customize the file path and name
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                PictureBoxCamera.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                
                MessageBox.Show("Image captured and saved to " + filePath);

                // Insert image into to database as blob.
                dbHelpers.SaveImageToDatabase(PictureBoxCamera.Image);
            } else {
                MessageBox.Show("No image to capture.");
            }
        }

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
