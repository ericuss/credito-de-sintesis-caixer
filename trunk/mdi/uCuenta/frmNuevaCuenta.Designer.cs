namespace uCuenta
{
    partial class frmNuevaCuenta
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
            this.txtBuscar1 = new customTextCs.txtBuscar();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.Location = new System.Drawing.Point(22, 12);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(419, 35);
            this.txtBuscar1.TabIndex = 0;
            this.txtBuscar1.zzCampoDesc = null;
            this.txtBuscar1.zzCampoId = null;
            this.txtBuscar1.zzEtiqueta = "Cliente:";
            this.txtBuscar1.zzIdIsNumber = false;
            this.txtBuscar1.zzIdVisible = false;
            this.txtBuscar1.zzTabla = null;
            this.txtBuscar1.zzTxtDesc = "";
            this.txtBuscar1.zzTxtId = "";
            this.txtBuscar1.zzWidthDesc = "160";
            this.txtBuscar1.zzWidthId = "100";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(264, 82);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tnAceptar
            // 
            this.tnAceptar.Location = new System.Drawing.Point(109, 82);
            this.tnAceptar.Name = "tnAceptar";
            this.tnAceptar.Size = new System.Drawing.Size(75, 23);
            this.tnAceptar.TabIndex = 2;
            this.tnAceptar.Text = "Aceptar";
            this.tnAceptar.UseVisualStyleBackColor = true;
            // 
            // frmNuevaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 132);
            this.Controls.Add(this.tnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtBuscar1);
            this.Name = "frmNuevaCuenta";
            this.Text = "frmNuevaCuenta";
            this.ResumeLayout(false);

        }

        #endregion

        private customTextCs.txtBuscar txtBuscar1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button tnAceptar;
    }
}