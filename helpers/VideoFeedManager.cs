using AForge.Video.DirectShow;
using AForge.Video;
using System.Management;

namespace Jared.helpers {
    internal class VideoFeedManager {

        private VideoCaptureDevice videoSource;
        private List<PictureBox> pictureBoxes;

        public bool IsCameraRunning { get; private set; }

        // This is static since we just want to see all the available capture devices
        public static List<string> ListAvailableCameras() {
            FilterInfoCollection videoDevices;

            // Get the collection of video devices (cameras)
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // Check if there are any cameras connected
            if (videoDevices.Count == 0) {
                MessageBox.Show("No cameras found.", "Camera List", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return [];
            }

            List<string> videoCaptureDevices = [];
            // Add camera names to a ListBox or ComboBox
            foreach (FilterInfo device in videoDevices) {
                videoCaptureDevices.Add(device.Name);
            }

            return videoCaptureDevices;
        }

        public void SetPictureBoxes(params PictureBox[] pictureBoxes) {
            this.pictureBoxes = pictureBoxes.ToList();
        }

        public void SetVideoSource(string videoSourceName) {
            var videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count <= 0) {
                MessageBox.Show("No camera device found.");
                return;
            } else if (videoSourceName == string.Empty) {
                MessageBox.Show("No camera device selected.");
                return;
            }

            for (int i = 0; i < videoDevices.Count; i++) {
                if (videoDevices[i].Name == videoSourceName) {
                    this.videoSource = new VideoCaptureDevice(videoDevices[i].MonikerString);
                    this.pictureBoxes = pictureBoxes.ToList();
                    this.videoSource.NewFrame += VideoSource_NewFrame;
                }
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs) {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            foreach (var pictureBox in pictureBoxes) {
                pictureBox.Image?.Dispose();
                pictureBox.Image = (Bitmap)frame.Clone();
            }
            frame.Dispose();
        }

        public void StartFeed() {
            if (videoSource == null) {
                MessageBox.Show(
                    "No camera device found or no camera device selected.", 
                    "No device", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                IsCameraRunning = false;
                return;
            }

            if (!videoSource.IsRunning) {
                IsCameraRunning = true;
                videoSource.Start();
            }
        }

        public void StopFeed() {
            if (videoSource == null) {
                return;
            }

            if (videoSource.IsRunning) {
                videoSource.SignalToStop();
                foreach (var pictureBox in pictureBoxes) {
                    pictureBox.Image = null;
                }
            }
        }

        public void StopFeed(PictureBox pictureBox) {
            pictureBoxes.Remove(pictureBox);
        }
    }
}
