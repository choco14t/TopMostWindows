namespace TopMostWindows
{
    partial class frmStart
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.nicoMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmnuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // nicoMain
            // 
            this.nicoMain.ContextMenuStrip = this.cmnuMain;
            this.nicoMain.Icon = ((System.Drawing.Icon)(resources.GetObject("nicoMain.Icon")));
            this.nicoMain.Visible = true;
            // 
            // cmnuMain
            // 
            this.cmnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiExit});
            this.cmnuMain.Name = "cmnuMain";
            this.cmnuMain.Size = new System.Drawing.Size(114, 26);
            // 
            // mnuiExit
            // 
            this.mnuiExit.Name = "mnuiExit";
            this.mnuiExit.Size = new System.Drawing.Size(113, 22);
            this.mnuiExit.Text = "終了(&X)";
            this.mnuiExit.Click += new System.EventHandler(this.mnuiExit_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "frmStart";
            this.ShowInTaskbar = false;
            this.Text = "frmStart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStart_FormClosing);
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.cmnuMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon nicoMain;
        private System.Windows.Forms.ContextMenuStrip cmnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuiExit;
    }
}

