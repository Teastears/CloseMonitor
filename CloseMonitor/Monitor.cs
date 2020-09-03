using System;
using System.Runtime.InteropServices;

namespace CloseMonitor
{
    public static class Monitor
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
        public static void TurnOn()
        {
            SendMessage(HWND_BROADCAST, WM_SYSCOMMAND, SC_MONITORPOWER, -1);
        }
        public static void TurnOff()
        {
            SendMessage(HWND_BROADCAST, WM_SYSCOMMAND, SC_MONITORPOWER, 2);
        }
        static readonly IntPtr HWND_BROADCAST = new IntPtr(0xffff);
        const uint WM_SYSCOMMAND = 0x0112;
        const int SC_MONITORPOWER = 0xf170;
    }
}
