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
        public byte Opacity { get; set; }

        public TopMostWindow(IntPtr hWnd)
        {
            this.Hwnd = hWnd;
        }
    }
}
