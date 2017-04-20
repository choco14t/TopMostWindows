using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMostWindows
{
    public sealed class HotKeyManager
    {

        private static HotKeyManager _instance;
        public static HotKeyManager Instance
        {
            get { return (_instance == null ? _instance = new HotKeyManager() : _instance); }
        }

        public bool Register(IntPtr hWnd, out ushort hotkeyID)
        {
            try
            {
                hotkeyID = NativeMethods.GlobalAddAtom("MyHotKey");
                NativeMethods.RegisterHotKey(hWnd, hotkeyID, 0, VirtualKeys.VK_SCROLL);
            }
            catch (Exception)
            {
                hotkeyID = 0;
                return false;
            }

            return true;
        }

        public bool Unregister(IntPtr hWnd, ushort hotkeyID)
        {
            try
            {
                NativeMethods.UnregisterHotKey(hWnd, hotkeyID);
                NativeMethods.GlobalDeleteAtom(hotkeyID);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        private HotKeyManager() { }

    }
}
