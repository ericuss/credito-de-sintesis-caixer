namespace cliente
{
    partial class frmNuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoUsuario));
            this.txtBuscar1 = new customTextCs.txtBuscar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPass = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtUser = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.SuspendLayout();
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.Location = new System.Drawing.Point(37, 12);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(426, 35);
            this.txtBuscar1.TabIndex = 0;
            this.txtBuscar1.zzCampoDesc = "nombre, apellidos";
            this.txtBuscar1.zzCampoId = "dni";
            this.txtBuscar1.zzEtiqueta = "Cliente:";
            this.txtBuscar1.zzIdIsNumber = false;
            this.txtBuscar1.zzIdVisible = false;
            this.txtBuscar1.zzTabla = "cliente";
            this.txtBuscar1.zzTxtDesc = "";
            this.txtBuscar1.zzTxtId = "";
            this.txtBuscar1.zzWidthDesc = "160";
            this.txtBuscar1.zzWidthId = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(106, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(296, 133);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(106, 71);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(101, 20);
            this.txtPass.TabIndex = 4;
            this.txtPass.ValidValue = "";
            this.txtPass.zzValidateLength = false;
            this.txtPass.zzValidMaxLength = ((short)(0));
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(106, 47);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(101, 20);
            this.txtUser.TabIndex = 3;
            this.txtUser.ValidValue = "";
            this.txtUser.zzValidateLength = false;
            this.txtUser.zzValidMaxLength = ((short)(0));
            // 
            // frmNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 176);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevoUsuario";
            this.Text = "Nuevo Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private customTextCs.txtBuscar txtBuscar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomValidatorTextBox.CustomValidatorTextBox txtUser;
        private CustomValidatorTextBox.CustomValidatorTextBox txtPass;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}