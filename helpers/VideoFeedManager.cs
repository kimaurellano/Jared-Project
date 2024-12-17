﻿using AForge.Video.DirectShow;
using AForge.Video;

namespace Jared.helpers {
    internal class VideoFeedManager {

        private VideoCaptureDevice videoSource;
        private List<PictureBox> pictureBoxes;

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

        public VideoFeedManager(FilterInfoCollection videoDevices, params PictureBox[] pictureBoxes) {
            if (videoDevices.Count <= 0) {
                MessageBox.Show("No camera device found.");
                return;
            }
            this.videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            this.pictureBoxes = pictureBoxes.ToList();
            this.videoSource.NewFrame += VideoSource_NewFrame;
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
                return;
            }

            if (!videoSource.IsRunning) {
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
