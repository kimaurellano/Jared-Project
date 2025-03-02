using System;
using System.Diagnostics;
using System.IO;

namespace Madentra.helpers {
    internal class TraceLogger {

        private static string workingDir = Directory.GetCurrentDirectory();
        private static readonly string logFilePath = $@"{workingDir}\App_Data\trace.log";

        public static void InitTraceMessage() {
            if (!Trace.Listeners.OfType<TextWriterTraceListener>().Any(l => l.Writer is StreamWriter sw && sw.BaseStream is FileStream fs && fs.Name == logFilePath)) {
                // Create a text file listener
                TextWriterTraceListener fileListener = new TextWriterTraceListener(logFilePath);
                Trace.Listeners.Add(fileListener);

                // Enable auto-flushing
                Trace.AutoFlush = true;
            }
        }
    }
}
