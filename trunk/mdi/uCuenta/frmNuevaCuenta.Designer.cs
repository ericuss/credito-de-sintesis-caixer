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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tnAceptar = new System.Windows.Forms.Button();
            this.csBuscar = new customTextCs.txtBuscar();
            this.SuspendLayout();
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
            this.tnAceptar.Click += new System.EventHandler(this.tnAceptar_Click);
            // 
            // csBuscar
            // 
            this.csBuscar.Location = new System.Drawing.Point(22, 12);
            this.csBuscar.Name = "csBuscar";
            this.csBuscar.Size = new System.Drawing.Size(419, 35);
            this.csBuscar.TabIndex = 0;
            this.csBuscar.zzCampoDesc = "nombre,apellidos";
            this.csBuscar.zzCampoId = "dni";
            this.csBuscar.zzEtiqueta = "Cliente:";
            this.csBuscar.zzIdIsNumber = false;
            this.csBuscar.zzIdVisible = false;
            this.csBuscar.zzTabla = "cliente";
            this.csBuscar.zzTxtDesc = "";
            this.csBuscar.zzTxtId = "";
            this.csBuscar.zzWidthDesc = "160";
            this.csBuscar.zzWidthId = "100";
            // 
            // frmNuevaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 132);
            this.Controls.Add(this.tnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.csBuscar);
            this.Name = "frmNuevaCuenta";
            this.Text = "frmNuevaCuenta";
            this.ResumeLayout(false);

        }

        #endregion

        private customTextCs.txtBuscar csBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button tnAceptar;
    }
}