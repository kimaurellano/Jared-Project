import subprocess
import re
import argparse

LOG_FILE = "interface.txt"

def list_usbpcap_interfaces():
    """ Returns a dictionary of available USBPcap interfaces. """
    try:
        print("🔹 Running 'tshark -D' to list interfaces...")
        output = subprocess.check_output(["tshark", "-D"], universal_newlines=True, timeout=5)
    except subprocess.TimeoutExpired:
        print("❌ Error: 'tshark -D' took too long to respond. Try running as Administrator.")
        return {}
    except subprocess.CalledProcessError:
        print("❌ Error: 'tshark' encountered an issue. Make sure it is installed correctly.")
        return {}

    usb_interfaces = {}
    letter = 'A'  # Assigns letters A, B, C for interfaces
    for line in output.splitlines():
        match = re.match(r"^(\d+)\.\s+\\\\\.\\(USBPcap\d+)", line.strip())
        if match:
            usb_interfaces[match.group(2)] = (match.group(1), letter)
            letter = chr(ord(letter) + 1)  # Increment letter (A -> B -> C)
    
    return usb_interfaces

def log_to_file(interface_name):
    """ Writes the detected interface name to a log file. """
    with open(LOG_FILE, "w") as file:
        file.write(interface_name + "\n")
    print(f"✅ Interface '{interface_name}' written to {LOG_FILE}.")

def find_device_interface(vid, pid, interfaces):
    """ Searches all USBPcap interfaces for a device with a matching VID & PID and logs results. """
    device_found = False
    for name, (number, letter) in interfaces.items():
        print(f"{letter}. Scanning {name} (Interface {number})...")
        command = ["tshark", "-i", number, "-c", "20", "-Y", "usb", "-T", "fields", 
                   "-e", "usb.device_address", "-e", "usb.idVendor", "-e", "usb.idProduct"]
        
        try:
            output = subprocess.check_output(command, universal_newlines=True, stderr=subprocess.DEVNULL, timeout=10)
            devices = [line.strip() for line in output.splitlines() if line.strip()]

            if devices:
                print(f"{letter}. Devices found on {name} (Interface {number}):")
                for device in devices:
                    parts = device.split()
                    if len(parts) >= 3:
                        device_id, found_vid, found_pid = parts[0], parts[1], parts[2]

                        # Ensure VID & PID have a single "0x" prefix
                        if not found_vid.startswith("0x"):
                            found_vid = f"0x{found_vid}"
                        if not found_pid.startswith("0x"):
                            found_pid = f"0x{found_pid}"

                        print(f"  {device_id}.{letter}  {found_vid}  {found_pid}")  # Debugging output

                        if found_vid.lower() == vid.lower() and found_pid.lower() == pid.lower():
                            print(f"✅ Device with VID_{vid} & PID_{pid} found on {name} (Interface {number})")
                            log_to_file(name)
                            device_found = True
            else:
                print(f"{letter}. No Device found on {name} (Interface {number}):\nNone.{letter}")

        except subprocess.TimeoutExpired:
            print(f"❌ Timeout: Scanning {name} took too long. Skipping...")
        except subprocess.CalledProcessError:
            print(f"⚠️ Failed to scan {name}.")

    if not device_found:
        print(f"\n❌ Device with VID_{vid} & PID_{pid} not found on any interface.")

def main():
    parser = argparse.ArgumentParser(description="Find the interface associated with a given VID and PID (0x format).")
    parser.add_argument("vid", type=str, help="Vendor ID in 0x format (e.g., 0x04F2)")
    parser.add_argument("pid", type=str, help="Product ID in 0x format (e.g., 0xB687)")

    args = parser.parse_args()

    # Validate that VID & PID are in the correct format
    if not re.match(r"^0x[0-9A-Fa-f]{4}$", args.vid) or not re.match(r"^0x[0-9A-Fa-f]{4}$", args.pid):
        print("❌ Error: VID and PID must be in '0xXXXX' hexadecimal format (e.g., 0x04F2).")
        return

    vid, pid = args.vid, args.pid

    print("\n🔍 **Listing all USBPcap interfaces and searching for device**...\n")
    interfaces = list_usbpcap_interfaces()

    if not interfaces:
        print("❌ No USBPcap interfaces found.")
        return

    find_device_interface(vid, pid, interfaces)

if __name__ == "__main__":
    main()
