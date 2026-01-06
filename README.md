# USB-HIDGuard

USB-HIDGuard is a Windows application designed to protect users against malicious USB HID devices 
(such as Rubber Ducky–style attacks, pyDucky etc.) by detecting newly connected HID devices and requiring explicit 
user approval before input is allowed.

The application focuses on practical, user-mode protection for private users, providing an additional 
layer of defense against common BadUSB and keystroke injection attacks.

## Key Features
- Detects newly connected USB HID devices
- Displays device friendly name and VID/PID
- Prevents automatic trust of new HID input until user confirmation
- Designed to run in the background at system startup
- Lightweight and user-focused security approach

## Threat Model
USB-HIDGuard is designed to mitigate common HID-based USB attacks that rely on automated keystroke 
injection. While it does not prevent driver loading at kernel level, it effectively blocks malicious 
input until the user explicitly approves the device.

## License
This project is intentionally published without an open-source license.

All rights are reserved.  
The source code is provided for educational and portfolio demonstration purposes only.

