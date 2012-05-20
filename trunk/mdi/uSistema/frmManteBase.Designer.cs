namespace uSistema
{
    partial class frmManteBase
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
            this.grdRes = new System.Windows.Forms.DataGridView();
            this.gbRes = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdRes)).BeginInit();
            this.gbRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdRes
            // 
            this.grdRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRes.Location = new System.Drawing.Point(3, 16);
            this.grdRes.Name = "grdRes";
            this.grdRes.Size = new System.Drawing.Size(365, 201);
            this.grdRes.TabIndex = 0;
            // 
            // gbRes
            // 
            this.gbRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRes.Controls.Add(this.grdRes);
            this.gbRes.Location = new System.Drawing.Point(12, 125);
            this.gbRes.Name = "gbRes";
            this.gbRes.Size = new System.Drawing.Size(371, 220);
            this.gbRes.TabIndex = 1;
            this.gbRes.TabStop = false;
            this.gbRes.Text = "Resultado";
            // 
            // frmManteBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 356);
            this.Controls.Add(this.gbRes);
            this.Name = "frmManteBase";
            this.Text = "frmManteBase";
            ((System.ComponentModel.ISupportInitialize)(this.grdRes)).EndInit();
            this.gbRes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView grdRes;
        public System.Windows.Forms.GroupBox gbRes;

    }
}