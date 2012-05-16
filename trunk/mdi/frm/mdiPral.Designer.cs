namespace uMdi
{   ///<summary>
    ///MDI Principal.
    /// </summary>
    partial class mdiPral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiPral));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.naviBar2 = new Guifreaks.Navisuite.NaviBar(this.components);
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // tvMenu
            // 
            this.tvMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.tvMenu.Location = new System.Drawing.Point(231, -3);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Size = new System.Drawing.Size(121, 431);
            this.tvMenu.TabIndex = 4;
            // 
            // naviBar2
            // 
            this.naviBar2.ActiveBand = null;
            this.naviBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.naviBar2.Location = new System.Drawing.Point(0, 0);
            this.naviBar2.Name = "naviBar2";
            this.naviBar2.Size = new System.Drawing.Size(168, 431);
            this.naviBar2.TabIndex = 6;
            this.naviBar2.Text = "naviBar2";
            this.naviBar2.VisibleLargeButtons = 10;
            this.naviBar2.LayoutChanged += new System.EventHandler(this.naviBar2_LayoutChanged);
            this.naviBar2.Click += new System.EventHandler(this.naviBar2_Click);
            // 
            // mdiPral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.naviBar2);
            this.Controls.Add(this.tvMenu);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "mdiPral";
            this.Text = "LanreSuit";
            this.Load += new System.EventHandler(this.mdiPral_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TreeView tvMenu;
        private Guifreaks.Navisuite.NaviBar naviBar1;
        private Guifreaks.Navisuite.NaviBand naviBand1;
        private Guifreaks.Navisuite.NaviBar naviBar2;
    }
}



