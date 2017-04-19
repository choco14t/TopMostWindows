using System;
using System.Text;
using System.Runtime.InteropServices;

namespace TopMostWindows
{

    /// <summary>
    /// this class is provided "NativeMethods".
    /// </summary>
    public sealed class NativeMethods
    {

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        private NativeMethods() { }

    }

}
