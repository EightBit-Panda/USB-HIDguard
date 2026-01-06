using System;
using System.Drawing;
using System.Windows.Forms;

namespace USB_HIDguard.Tray
{
    public class TrayContext : ApplicationContext
    {
        private NotifyIcon trayIcon;

        public TrayContext()
        {
            trayIcon = new NotifyIcon
            {
                Icon = SystemIcons.Shield,
                Text = "USB-HIDguard",
                Visible = true,
                ContextMenuStrip = new ContextMenuStrip()
            };
            trayIcon.ContextMenuStrip.Items.Add("Exit", null, Exit);
        }

        private void Exit(object? sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Application.Exit();
        }
    }
}
