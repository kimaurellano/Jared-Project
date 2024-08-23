using AForge.Video.DirectShow;
using AForge.Video;
using Microsoft.Data.Sqlite;
using System.Data;
using System.Windows.Forms;

namespace Jared {
    public partial class MainForm : Form {

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public MainForm() {
            InitializeComponent();
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
            pictureBoxCamera.Image = frame;
            pictureBoxCamera.SizeMode = PictureBoxSizeMode.CenterImage;
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
            if (pictureBoxCamera.Image != null) {
                // Save the image to a file
                string filePath = "captured_image.png"; // You can customize the file path and name
                pictureBoxCamera.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                
                MessageBox.Show("Image captured and saved to " + filePath);
            } else {
                MessageBox.Show("No image to capture.");
            }
        }
    }
}
