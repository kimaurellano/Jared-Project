using System.Diagnostics;
using System.Management;

namespace Madentra.helpers {
    internal class DeviceIdFinder {

        private KeyValuePair<string, string> _deviceId;

        public KeyValuePair<string, string> FindDeviceIDOf(string DeviceName) {
            if (DeviceName == string.Empty) { 
                return new KeyValuePair<string, string>(string.Empty, string.Empty);
            }

            TraceLogger.TraceMessage("Searching for Camera Devices...");

            // Query WMI for Plug and Play devices
            using (ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(@"SELECT * FROM Win32_PnPEntity WHERE DeviceID LIKE 'USB%'")) {
                foreach (ManagementObject device in searcher.Get()) {
                    string deviceID = device["DeviceID"]?.ToString();
                    string name = device["Name"]?.ToString();

                    if (name == DeviceName && deviceID.Contains("VID_") && deviceID.Contains("PID_")) {
                        string vid = "0x" + ExtractVID(deviceID);
                        string pid = "0x" + ExtractPID(deviceID);

                        _deviceId = new KeyValuePair<string, string>(vid, pid);

                        TraceLogger.TraceMessage($"Camera: {name}");
                        TraceLogger.TraceMessage($"VID: {vid}");
                        TraceLogger.TraceMessage($"PID: {pid}\n");
                    }
                }
            }

            TraceLogger.TraceMessage("✅ Done.");

            return _deviceId;
        }

        static string ExtractVID(string deviceID) {
            int vidIndex = deviceID.IndexOf("VID_");
            return (vidIndex >= 0 && vidIndex + 8 <= deviceID.Length) ? deviceID.Substring(vidIndex + 4, 4) : "Unknown";
        }

        static string ExtractPID(string deviceID) {
            int pidIndex = deviceID.IndexOf("PID_");
            return (pidIndex >= 0 && pidIndex + 8 <= deviceID.Length) ? deviceID.Substring(pidIndex + 4, 4) : "Unknown";
        }
    }
}
