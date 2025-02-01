using System;
using System.Diagnostics;

public class DeviceInterruptFilter {

    private readonly string _logFilePath = $@"C:\Users\kimau\Documents\Visual Studio 2022\Project\App_Data\capture.log";
    private CancellationTokenSource? _cts;
    public event Action<string> LogUpdated; // Event to send log updates to the UI

    public static async void RunPythonScriptAsync() {
        // Setup the process info
        var startInfo = new ProcessStartInfo {
            FileName = "python.exe",
            Arguments = $"\"C:\\Users\\kimau\\Documents\\Visual Studio 2022\\Project\\App_Data\\usbpcap_logger.py\"",          // or full path to python.exe if needed
            CreateNoWindow = true,            // no console window
            UseShellExecute = false,          // must be false to redirect output
            RedirectStandardOutput = true,
            RedirectStandardError = true
        };

        // Start the process
        using (var process = new Process { StartInfo = startInfo }) {
            Debug.WriteLine(@$"Starting script {startInfo.FileName}...");

            process.Start();

            await process.WaitForExitAsync();
        }
    }

    public void StartReadLog() {
        if (_cts != null) return; // Avoid multiple starts

        _cts = new CancellationTokenSource();
        Task.Run(() => ReadLogFile(_cts.Token));
    }

    public void StopReadLog() {
        _cts?.Cancel();
        _cts = null;
    }

    private async Task ReadLogFile(CancellationToken cancellationToken) {
        if (!File.Exists(_logFilePath)) {
            while (!File.Exists(_logFilePath)) {
                await Task.Delay(1000, cancellationToken);
                if (cancellationToken.IsCancellationRequested) return;
            }
        }

        using var fs = new FileStream(_logFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        using var reader = new StreamReader(fs);
        fs.Seek(0, SeekOrigin.End); // Start reading from the end

        bool pressEvent = false;
        while (!cancellationToken.IsCancellationRequested) {
            string line = await reader.ReadLineAsync();
            if (line != null) {
                // if received first press(31), accept
                if (line.Contains("31") && !pressEvent) {
                    pressEvent = !pressEvent;
                    Debug.WriteLine("Pressed");
                } else if (pressEvent && line.Contains("31")) {
                    Debug.WriteLine("Trigger capture");
                    pressEvent = !pressEvent;
                    LogUpdated?.Invoke(line); // Fire event for UI
                }
            }
            else {
                await Task.Delay(500, cancellationToken);
            }
        }
    }
}