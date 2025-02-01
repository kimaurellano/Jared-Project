import subprocess
import re
import os

def sniff_usbpcap1_and_log_interrupt_in():
    try:
        # 1. List TShark interfaces
        output = subprocess.check_output(["tshark", "-D"], universal_newlines=True)

        # 2. Find interface number for "\\.\\USBPcap1"
        interface_number = None
        for line in output.splitlines():
            # e.g. "13. \\.\USBPcap1 (USBPcap1)"
            if r'\\.\USBPcap1' in line:
                match = re.match(r'^(\d+)\.\s+', line.strip())
                if match:
                    interface_number = match.group(1)
                    break

        if not interface_number:
            print("Could not find '\\.\\USBPcap1' in the interface list.")
            return

        print(f"Found interface number: {interface_number}")

        # 3. TShark command (line-buffered output)
        command = ["tshark", "-i", interface_number, "-l"]
        print(f"Starting TShark with: {command}")

        # 4. Prepare log file (capture.log)
        script_dir = os.path.dirname(os.path.abspath(__file__))
        log_filename = "capture.log"
        log_path = os.path.join(script_dir, log_filename)

        print(f"Logging ONLY lines with 'URB_INTERRUPT in' to: {log_path}")
        print("Press Ctrl+C to stop...\n")

        with open(log_path, "w", encoding="utf-8") as lf:
            process = subprocess.Popen(command, stdout=subprocess.PIPE, stderr=subprocess.STDOUT, text=True)

            try:
                while True:
                    line = process.stdout.readline()
                    if not line:
                        break  # TShark has exited or no more output

                    # Check if line contains the substring "URB_INTERRUPT in"
                    if "31 URB_INTERRUPT in" in line:
                        # Write the filtered line to the log file
                        lf.write(line)
                        lf.flush()

                        # Print to console too
                        print(line, end="")

            except KeyboardInterrupt:
                print("\nCapture interrupted by user.")
                process.kill()

            # Wait for TShark to exit
            process.wait()

        print("\nTShark capture finished.")

    except subprocess.CalledProcessError as e:
        print(f"Error: {e}")
    except Exception as e:
        print(f"Unexpected error: {e}")

if __name__ == "__main__":
    sniff_usbpcap1_and_log_interrupt_in()
