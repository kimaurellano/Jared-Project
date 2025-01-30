using System;
using System.Diagnostics;

public class DeviceInterruptFilter {

    public static async void RunPythonScriptAsync() {
        // Setup the process info
        var startInfo = new ProcessStartInfo {
            FileName = "python.exe",
            Arguments = @$"C:\Users\kimau\Documents\Visual Studio 2022\Project\App_Data\usbpcap_logger.py",          // or full path to python.exe if needed
            CreateNoWindow = true,            // no console window
            UseShellExecute = false,          // must be false to redirect output
            RedirectStandardOutput = true,
            RedirectStandardError = true
        };

        // Start the process
        using (var process = new Process { StartInfo = startInfo }) {
            process.Start();

            // Read standard output and error asynchronously
            string output = await process.StandardOutput.ReadToEndAsync();
            string error = await process.StandardError.ReadToEndAsync();
        }
    }
}