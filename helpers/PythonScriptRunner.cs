using DirectShowLib;
using DirectShowLib.DMO;
using Madentra.helpers;
using Microsoft.Data.Sqlite;
using System;
using System.Diagnostics;
using System.Text.Json;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class PythonScriptRunner {

    private static string workingDir = Directory.GetCurrentDirectory();
    private CancellationTokenSource? _cts;
    public event Action<string> LogUpdated; // Event to send log updates to the UI

    public async void GetInterface(KeyValuePair<string, string> device) {
        string? interfaceName = await GetAssocInterface(device);
        if (interfaceName != null) {
            TraceLogger.TraceMessage($"Found interface: {interfaceName}");
            USBPcapLoggerInit(interfaceName);
        } else {
            TraceLogger.TraceMessage("Device not found.");
        }
    }

    public async Task<string?> GetAssocInterface(KeyValuePair<string, string> vid_pid) {
        // Setup the process info
        string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", "get_device_by_interface.py");
        if (!File.Exists(scriptPath)) {
            TraceLogger.TraceMessage($"Error: Python script not found at {scriptPath}");
            return null;
        }

        var startInfo = new ProcessStartInfo {
            FileName = "python.exe",
            Arguments = $"\"{scriptPath}\" {vid_pid.Key} {vid_pid.Value}",          // or full path to python.exe if needed
            CreateNoWindow = true,            // no Debug window
            UseShellExecute = false,          // must be false to redirect output
            RedirectStandardOutput = true,
            RedirectStandardError = true
        };

        // Start the process
        using (var process = new Process { StartInfo = startInfo }) {
            TraceLogger.TraceMessage(@$"Starting script {startInfo.Arguments}...");

            process.Start();

            string output = await process.StandardOutput.ReadToEndAsync();
            string error = await process.StandardError.ReadToEndAsync();

            await process.WaitForExitAsync();

            if (!string.IsNullOrEmpty(error)) {
                TraceLogger.TraceMessage($"Error: {error}");
                return null;
            }

            try {
                var jsonResult = JsonSerializer.Deserialize<JsonElement>(output);
                if (jsonResult.TryGetProperty("interface", out var interfaceName)) {
                    return interfaceName.GetString();
                }
                else if (jsonResult.TryGetProperty("error", out var errorMsg)) {
                    TraceLogger.TraceMessage($"Error: {errorMsg.GetString()}");
                    return null;
                }
            }
            catch (JsonException) {
                TraceLogger.TraceMessage("Failed to parse script output.");
            }

            return null;
        }
    }

    private async void USBPcapLoggerInit(string interfaceName) {
        // Setup the process info
        var startInfo = new ProcessStartInfo {
            FileName = "python.exe",
            Arguments = $"\"{workingDir}\\App_Data\\usbpcap_logger.py\" {interfaceName}",          // or full path to python.exe if needed
            CreateNoWindow = true,            // no Debug window
            UseShellExecute = false,          // must be false to redirect output
            RedirectStandardOutput = true,
            RedirectStandardError = true
        };

        // Start the process
        using (var process = new Process { StartInfo = startInfo }) {
            TraceLogger.TraceMessage(@$"Starting script {startInfo.Arguments}...");
            LogUpdated.Invoke("usbpcap_logger has started");

            process.Start();

            await process.WaitForExitAsync();
        }
    }
}