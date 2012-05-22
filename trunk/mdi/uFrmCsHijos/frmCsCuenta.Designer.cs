namespace uFrmCsHijos
{
    partial class frmCsCuenta
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
            this.txtEntidad = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar1 = new customTextCs.txtBuscar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOficina = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtControl = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtCuenta = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(650, 36);
            // 
            // gbDatos
            // 
            this.gbDatos.Location = new System.Drawing.Point(3, 65);
            this.gbDatos.Size = new System.Drawing.Size(748, 418);
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(107, 38);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(71, 20);
            this.txtEntidad.TabIndex = 4;
            this.txtEntidad.Tag = "filtro";
            this.txtEntidad.ValidValue = "";
            this.txtEntidad.zzCampoBd = "cuenta.codigoEntidad";
            this.txtEntidad.zzValidateIsNumeric = true;
            this.txtEntidad.zzValidateLength = true;
            this.txtEntidad.zzValidMaxLength = ((short)(4));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Entidad:";
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.Location = new System.Drawing.Point(38, 3);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(426, 35);
            this.txtBuscar1.TabIndex = 6;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Oficina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Control:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cuenta:";
            // 
            // txtOficina
            // 
            this.txtOficina.Location = new System.Drawing.Point(254, 38);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.Size = new System.Drawing.Size(71, 20);
            this.txtOficina.TabIndex = 10;
            this.txtOficina.Tag = "filtro";
            this.txtOficina.ValidValue = "";
            this.txtOficina.zzCampoBd = "cuenta.codigoOficina";
            this.txtOficina.zzValidateIsNumeric = true;
            this.txtOficina.zzValidateLength = true;
            this.txtOficina.zzValidMaxLength = ((short)(4));
            // 
            // txtControl
            // 
            this.txtControl.Location = new System.Drawing.Point(386, 38);
            this.txtControl.Name = "txtControl";
            this.txtControl.Size = new System.Drawing.Size(40, 20);
            this.txtControl.TabIndex = 11;
            this.txtControl.Tag = "filtro";
            this.txtControl.ValidValue = "";
            this.txtControl.zzCampoBd = "cuenta.codigoControl";
            this.txtControl.zzValidateIsNumeric = true;
            this.txtControl.zzValidateLength = true;
            this.txtControl.zzValidMaxLength = ((short)(2));
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(504, 38);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(116, 20);
            this.txtCuenta.TabIndex = 12;
            this.txtCuenta.Tag = "filtro";
            this.txtCuenta.ValidValue = "";
            this.txtCuenta.zzCampoBd = "cuenta.codigoCuenta";
            this.txtCuenta.zzValidateIsNumeric = true;
            this.txtCuenta.zzValidateLength = true;
            this.txtCuenta.zzValidMaxLength = ((short)(8));
            // 
            // frmCsCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 514);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.txtControl);
            this.Controls.Add(this.txtOficina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEntidad);
            this.Controls.Add(this.txtBuscar1);
            this.Controls.Add(this.label1);
            this.Name = "frmCsCuenta";
            this.Text = "frmCsCuenta";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtBuscar1, 0);
            this.Controls.SetChildIndex(this.txtEntidad, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.gbDatos, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtOficina, 0);
            this.Controls.SetChildIndex(this.txtControl, 0);
            this.Controls.SetChildIndex(this.txtCuenta, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomValidatorTextBox.CustomValidatorTextBox txtEntidad;
        private System.Windows.Forms.Label label1;
        private customTextCs.txtBuscar txtBuscar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomValidatorTextBox.CustomValidatorTextBox txtOficina;
        private CustomValidatorTextBox.CustomValidatorTextBox txtControl;
        private CustomValidatorTextBox.CustomValidatorTextBox txtCuenta;
    }
}