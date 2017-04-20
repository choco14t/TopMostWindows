using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TopMostWindows
{

    /// <summary>
    /// this form is instanciated when application start.
    /// </summary>
    public partial class frmStart : Form
    {

        private Dictionary<TopMostWindow, string> _dicWindows;
        private ushort _hotKeyID;

        public frmStart()
        {
            InitializeComponent();
            this._dicWindows = new Dictionary<TopMostWindow, string>();
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
            HotKeyManager.Instance.Unregister(this.Handle, this._hotKeyID);

            foreach (KeyValuePair<TopMostWindow, string> item in this._dicWindows)
            {
                NativeMethods.SetWindowPos(item.Key.Hwnd, HwndInsertAfter.NoTopMost, 0, 0, 0, 0, SetWindowPosFlags.NOSIZE | SetWindowPosFlags.NOMOVE);
                MessageBox.Show(item.Value + " Unregistered.");
            }

        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            HotKeyManager.Instance.Register(this.Handle, out this._hotKeyID);
        }

        private void mnuiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void WndProc(ref Message m)
        {

            if (m.Msg == NativeMethods.WM_HOTKEY)
            {
                TopMostWindow tm = new TopMostWindow(NativeMethods.GetForegroundWindow());
                StringBuilder sb = new StringBuilder();

                sb.Capacity = NativeMethods.GetWindowTextLength(tm.Hwnd);
                NativeMethods.GetWindowText(tm.Hwnd, sb, sb.Capacity + 1);
                NativeMethods.SetWindowPos(tm.Hwnd, HwndInsertAfter.TopMost, 0, 0, 0, 0, SetWindowPosFlags.NOSIZE | SetWindowPosFlags.NOMOVE);
                if (!this._dicWindows.ContainsKey(tm))
                {
                    this._dicWindows.Add(tm, sb.ToString());
                    MessageBox.Show(sb.ToString() + " Registered.");
                }

            }

            base.WndProc(ref m);
        }

    }

}
