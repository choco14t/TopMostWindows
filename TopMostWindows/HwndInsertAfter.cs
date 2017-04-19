using System;

namespace TopMostWindows
{
    /// <summary>
    /// Window handles (HWND) used for hWndInsertAfter
    /// </summary>
    public static class HwndInsertAfter
    {
        public static IntPtr
        NoTopMost = new IntPtr(-2),
        TopMost = new IntPtr(-1),
        Top = new IntPtr(0),
        Bottom = new IntPtr(1);
    }
}
