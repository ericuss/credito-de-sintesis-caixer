using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base;


namespace cliente
{
    public class frmMantCliente:Base.Base
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // gbResultado
            // 
            this.gbResultado.Size = new System.Drawing.Size(709, 348);
            // 
            // gbFiltro
            // 
            this.gbFiltro.Size = new System.Drawing.Size(682, 60);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(703, 22);
            // 
            // cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(733, 467);
            this.Name = "cliente";
            this.ResumeLayout(false);

        }
    }
}
