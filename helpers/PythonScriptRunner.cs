using DirectShowLib;
using DirectShowLib.DMO;
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
            Debug.WriteLine($"Found interface: {interfaceName}");
            USBPcapLoggerInit(interfaceName);
        } else {
            Debug.WriteLine("Device not found.");
        }
    }

    public async Task<string?> GetAssocInterface(KeyValuePair<string, string> vid_pid) {
        // Setup the process info
        string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", "get_device_by_interface.py");
        if (!File.Exists(scriptPath)) {
            Debug.WriteLine($"Error: Python script not found at {scriptPath}");
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
            Debug.WriteLine(@$"Starting script {startInfo.Arguments}...");

            process.Start();

            string output = await process.StandardOutput.ReadToEndAsync();
            string error = await process.StandardError.ReadToEndAsync();

            await process.WaitForExitAsync();

            if (!string.IsNullOrEmpty(error)) {
                Debug.WriteLine($"Error: {error}");
                return null;
            }

            try {
                var jsonResult = JsonSerializer.Deserialize<JsonElement>(output);
                if (jsonResult.TryGetProperty("interface", out var interfaceName)) {
                    return interfaceName.GetString();
                }
                else if (jsonResult.TryGetProperty("error", out var errorMsg)) {
                    Debug.WriteLine($"Error: {errorMsg.GetString()}");
                    return null;
                }
            }
            catch (JsonException) {
                Debug.WriteLine("Failed to parse script output.");
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
            Debug.WriteLine(@$"Starting script {startInfo.Arguments}...");

            process.Start();

            string output = await process.StandardOutput.ReadToEndAsync();
            string error = await process.StandardError.ReadToEndAsync();

            await process.WaitForExitAsync();

            if (!string.IsNullOrEmpty(error)) {
                Debug.WriteLine($"Error: {error}");
            }

            try {
                var jsonResult = JsonSerializer.Deserialize<JsonElement>(output);
                if (jsonResult.TryGetProperty("init", out var started)) {
                    Debug.WriteLine($"{started.ToString()}");
                }
                else if (jsonResult.TryGetProperty("error", out var errorMsg)) {
                    Debug.WriteLine($"Error: {errorMsg.GetString()}");
                }
            }
            catch (JsonException) {
                Debug.WriteLine("Failed to parse script output.");
            }
        }
    }
}