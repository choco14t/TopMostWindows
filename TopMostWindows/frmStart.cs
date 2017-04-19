using System;
using System.Windows.Forms;

namespace TopMostWindows
{

    /// <summary>
    /// this form is instanciated when application start.
    /// </summary>
    public partial class frmStart : Form
    {

        private TopMostWindow _tmWindow;
        private ushort _hotKeyID;
        private RECT _wRect;

        public frmStart()
        {
            InitializeComponent();
            this._tmWindow = new TopMostWindow();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= NativeMethods.WS_EX_LAYERED | NativeMethods.WS_EX_TRANSPARENT;
                return cp;
            }
        }

        private void frmStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            NativeMethods.UnregisterHotKey(this.Handle, this._hotKeyID);
            NativeMethods.GlobalDeleteAtom(this._hotKeyID);

            if (this._tmWindow.Hwnd != IntPtr.Zero)
            {
                // TODO:解放時は現在の座標を取得する。
                NativeMethods.SetWindowPos(this._tmWindow.Hwnd, HwndInsertAfter.NoTopMost, this._tmWindow.Wrect.Left, this._tmWindow.Wrect.Top, this._tmWindow.Wrect.Width, this._tmWindow.Wrect.Height, SetWindowPosFlags.NOSIZE | SetWindowPosFlags.NOMOVE);
                MessageBox.Show("Unregistered.");
            }
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            this._hotKeyID = NativeMethods.GlobalAddAtom("MyHotKey");
            NativeMethods.RegisterHotKey(this.Handle, this._hotKeyID, 0, VirtualKeys.VK_SCROLL);
        }

        private void mnuiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void WndProc(ref Message m)
        {

            if (m.Msg == NativeMethods.WM_HOTKEY)
            {
                if (this._tmWindow.Hwnd == IntPtr.Zero)
                {
                    this._tmWindow.Hwnd = NativeMethods.GetForegroundWindow();
                    NativeMethods.GetWindowRect(this._tmWindow.Hwnd, out this._wRect);
                    this._tmWindow.SetWndRect(this._wRect);
                    NativeMethods.SetWindowPos(this._tmWindow.Hwnd, HwndInsertAfter.TopMost, this._wRect.Left, this._wRect.Top, this._wRect.Width, this._wRect.Height, SetWindowPosFlags.NOSIZE | SetWindowPosFlags.NOMOVE);
                    MessageBox.Show("Registered.");
                }                
            }

            base.WndProc(ref m);

        }

    }

}
