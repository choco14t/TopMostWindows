using System.Runtime.InteropServices;

namespace TopMostWindows
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        /// <summary>
        /// X position (upper left corner).
        /// </summary>
        public int Left;

        /// <summary>
        /// Y position (upper left corner).
        /// </summary>
        public int Top;

        /// <summary>
        /// X positin (lower right corner).
        /// </summary>
        public int Right;

        /// <summary>
        /// Y position (lower right corner).
        /// </summary>
        public int Bottom;

        /// <summary>
        /// get horizontal length of RECT.
        /// </summary>
        public int Width { get { return this.Right - this.Left + 1; } }

        /// <summary>
        /// get verical length of RECT.
        /// </summary>
        public int Height { get { return this.Bottom - this.Top + 1; } }

        public void Initialize()
        {
            this.Left = 0;
            this.Top = 0;
            this.Right = 0;
            this.Bottom = 0;
        }

    }
}
