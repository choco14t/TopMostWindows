using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMostWindows
{
    public class TopMostWindow
    {

        public IntPtr Hwnd { get; set; }
        public RECT Wrect { get; set; }

        public void SetProperty(IntPtr hWnd, RECT wRect)
        {
            this.Hwnd = hWnd;
            this.Wrect = wRect;
        }

        public void SetWndRect(RECT wRect)
        {
            this.Wrect = wRect;
        }

        public void Release()
        {
            this.Hwnd = IntPtr.Zero;
            this.Wrect.Initialize();
        }

    }
}
