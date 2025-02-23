using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madentra.helpers {
    public class LogMonitor {
        private FileSystemWatcher fileWatcher;
        private static string workingDir = Directory.GetCurrentDirectory();
        private readonly string _logFilePath = $@"{workingDir}\App_Data\capture.log";
        public event Action OnLogUpdated; // Event to notify UI

        public LogMonitor() {
            Debug.WriteLine("Logger initialized.");
            InitializeFileWatcher();
        }

        private void InitializeFileWatcher() {
            if (!File.Exists(_logFilePath)) {
                throw new FileNotFoundException("Log file not found!", _logFilePath);
            }

            fileWatcher = new FileSystemWatcher {
                Path = Path.GetDirectoryName(_logFilePath),
                Filter = Path.GetFileName(_logFilePath),
                NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.Size
            };

            fileWatcher.Changed += OnLogFileChanged;
            fileWatcher.EnableRaisingEvents = true;
        }

        private void OnLogFileChanged(object sender, FileSystemEventArgs e) {
            try {
                string newContent = ReadNewLogEntries();
                if (!string.IsNullOrEmpty(newContent)) {
                    Debug.WriteLine("New log:" + newContent);
                    OnLogUpdated?.Invoke(); // Fire event to UI
                }
            }
            catch (Exception ex) {
                Console.WriteLine($"Error reading log file: {ex.Message}");
            }
        }

        private string ReadNewLogEntries() {
            using (var stream = new FileStream(_logFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var reader = new StreamReader(stream)) {
                return reader.ReadToEnd(); // Read new content only
            }
        }

        public void Dispose() {
            fileWatcher?.Dispose();
        }
    }
}
