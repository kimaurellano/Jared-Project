import subprocess
import re

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
    for line in output.splitlines():
        match = re.match(r"^(\d+)\.\s+\\\\\.\\(USBPcap\d+)", line.strip())
        if match:
            usb_interfaces[match.group(2)] = match.group(1)  # Map name to interface number
    
    return usb_interfaces

def list_devices_on_interface(interface_name, interface_number):
    """ Lists all USB devices connected to a given USBPcap interface. """
    command = ["tshark", "-i", interface_number, "-c", "10", "-Y", "usb", "-T", "fields", "-e", "usb.device_address", "-e", "usb.idVendor", "-e", "usb.idProduct"]
    
    try:
        print(f"🔹 Scanning {interface_name} (Interface {interface_number})...")
        output = subprocess.check_output(command, universal_newlines=True, stderr=subprocess.DEVNULL, timeout=10)
        devices = [line.strip() for line in output.splitlines() if line.strip()]

        print(f"\n🔹 Devices found on {interface_name} (Interface {interface_number}):")
        if devices:
            for device in devices:
                if "x" in device:
                    print(f"  📌 {device}")
                    write_to_file(interface_name)
                    
        else:
            print("  ❌ No devices detected.")
    
    except subprocess.TimeoutExpired:
        print(f"❌ Timeout: Scanning {interface_name} took too long. Skipping...")
    except subprocess.CalledProcessError:
        print(f"  ⚠️ Failed to scan {interface_name}.")
    
def write_to_file(interface):
    with open("interface.txt", "w") as file:
        file.writelines(interface + "\n")

    print("✅ Data written successfully!")

def main():
    print("\n🔍 **Listing all USBPcap interfaces and connected devices**...\n")
    interfaces = list_usbpcap_interfaces()

    if not interfaces:
        print("❌ No USBPcap interfaces found.")
        return

    for name, number in interfaces.items():
        list_devices_on_interface(name, number)

    print("\n✅ **Listing complete.**")

if __name__ == "__main__":
    main()
