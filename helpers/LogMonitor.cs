using Madentra.helpers;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

public class LogMonitor {
    private static string workingDir = Directory.GetCurrentDirectory();
    private readonly string logFilePath = $@"{workingDir}\App_Data\capture.log";
    private long lastPosition = 0;
    private CancellationTokenSource cts;
    public event Action<string> OnLogUpdated;

    public LogMonitor() {
        cts = new CancellationTokenSource();
    }

    public async void Start() { 
        await StartWatchingAsync();
    }

    private async Task StartWatchingAsync() {
        TraceLogger.TraceMessage($"Watching {logFilePath}...");

        while (!cts.Token.IsCancellationRequested) {
            try {
                if (!File.Exists(logFilePath)) {
                    TraceLogger.TraceMessage("Log file not found. Waiting for it to be created...");
                    await Task.Delay(150, cts.Token);
                    continue;
                }

                using (var stream = new FileStream(logFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var reader = new StreamReader(stream)) {
                    // Reset if file has been truncated or restarted
                    if (stream.Length < lastPosition) {
                        lastPosition = 0;
                    }

                    stream.Seek(lastPosition, SeekOrigin.Begin);
                    string newContent = await reader.ReadToEndAsync();

                    if (!string.IsNullOrEmpty(newContent)) {
                        TraceLogger.TraceMessage(newContent);
                        lastPosition = stream.Position;
                        OnLogUpdated?.Invoke("Capture trigger");
                    }
                }
            }
            catch (Exception ex) {
                TraceLogger.TraceMessage($"Error: {ex.Message}");
            }

            await Task.Delay(1000, cts.Token); // Adjust delay if needed
        }
    }

    public void StopWatching() {
        TraceLogger.TraceMessage("Stopping log file watcher...");
        cts.Cancel();
    }
}
