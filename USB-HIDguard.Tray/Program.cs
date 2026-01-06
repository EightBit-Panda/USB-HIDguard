using System;
using System.Windows.Forms;

// Initialiser Windows Forms-konfigurasjon
ApplicationConfiguration.Initialize();

// Start tray-appen med TrayContext
Application.Run(new USB_HIDguard.Tray.TrayContext());
