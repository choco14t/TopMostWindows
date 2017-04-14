using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopMostWindows
{
    /// <summary>
    /// this form is instanciated when application start.
    /// </summary>
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                
                CreateParams cp = base.CreateParams;
                return base.CreateParams;

            }
        }
    }
}
