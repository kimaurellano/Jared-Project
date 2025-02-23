import subprocess
import re
import argparse
import json
import sys

def list_usbpcap_interfaces():
    """ Returns a dictionary of available USBPcap interfaces. """
    try:
        output = subprocess.check_output(["tshark", "-D"], universal_newlines=True, timeout=5)
    except subprocess.TimeoutExpired:
        print(json.dumps({"error": "Timeout while listing interfaces"}))
        sys.exit(1)
    except subprocess.CalledProcessError:
        print(json.dumps({"error": "Failed to list interfaces. Make sure TShark is installed."}))
        sys.exit(1)

    usb_interfaces = {}
    for line in output.splitlines():
        match = re.match(r"^(\d+)\.\s+\\\\\.\\(USBPcap\d+)", line.strip())
        if match:
            usb_interfaces[match.group(2)] = match.group(1)
    
    return usb_interfaces

def find_device_interface(vid, pid, interfaces):
    """ Searches all USBPcap interfaces for a device with a matching VID & PID. """
    for name, number in interfaces.items():
        command = ["tshark", "-i", number, "-c", "20", "-Y", "usb", "-T", "fields", 
                   "-e", "usb.device_address", "-e", "usb.idVendor", "-e", "usb.idProduct"]
        
        try:
            output = subprocess.check_output(command, universal_newlines=True, stderr=subprocess.DEVNULL, timeout=10)
            for line in output.splitlines():
                parts = line.strip().split()
                if len(parts) >= 3:
                    found_vid, found_pid = parts[1], parts[2]

                    # Normalize VID & PID
                    if not found_vid.startswith("0x"):
                        found_vid = f"0x{found_vid}"
                    if not found_pid.startswith("0x"):
                        found_pid = f"0x{found_pid}"

                    if found_vid.lower() == vid.lower() and found_pid.lower() == pid.lower():
                        print(json.dumps({"interface": name}))
                        return
        except subprocess.TimeoutExpired:
            continue
        except subprocess.CalledProcessError:
            continue

    print(json.dumps({"error": "Device not found"}))
    sys.exit(1)

def main():
    parser = argparse.ArgumentParser(description="Find the interface associated with a given VID and PID (0x format).")
    parser.add_argument("vid", type=str, help="Vendor ID in 0x format (e.g., 0x04F2)")
    parser.add_argument("pid", type=str, help="Product ID in 0x format (e.g., 0xB687)")

    args = parser.parse_args()

    if not re.match(r"^0x[0-9A-Fa-f]{4}$", args.vid) or not re.match(r"^0x[0-9A-Fa-f]{4}$", args.pid):
        print(json.dumps({"error": "Invalid VID/PID format. Use '0xXXXX'."}))
        sys.exit(1)

    interfaces = list_usbpcap_interfaces()
    if not interfaces:
        print(json.dumps({"error": "No USBPcap interfaces found"}))
        sys.exit(1)

    find_device_interface(args.vid, args.pid, interfaces)

if __name__ == "__main__":
    main()
