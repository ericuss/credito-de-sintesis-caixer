namespace uFrmCsHijos
{
    partial class frmCsCliente
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtApellidos = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtTelefono = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtDireccion = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtPoblacion = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtMail = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtDNI = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(681, 423);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(673, 35);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Location = new System.Drawing.Point(8, 64);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(553, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Poblacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(89, 20);
            this.txtNombre.TabIndex = 25;
            this.txtNombre.Tag = "filtro";
            this.txtNombre.ValidValue = "";
            this.txtNombre.zzCampoBd = "nombre";
            this.txtNombre.zzValidateIsNumeric = false;
            this.txtNombre.zzValidateLength = false;
            this.txtNombre.zzValidMaxLength = ((short)(0));
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(78, 37);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(89, 20);
            this.txtApellidos.TabIndex = 26;
            this.txtApellidos.Tag = "filtro";
            this.txtApellidos.ValidValue = "";
            this.txtApellidos.zzCampoBd = "apellidos";
            this.txtApellidos.zzValidateIsNumeric = false;
            this.txtApellidos.zzValidateLength = false;
            this.txtApellidos.zzValidMaxLength = ((short)(0));
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(249, 6);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 27;
            this.txtTelefono.Tag = "filtro";
            this.txtTelefono.ValidValue = "";
            this.txtTelefono.zzCampoBd = "telefono";
            this.txtTelefono.zzValidateIsNumeric = false;
            this.txtTelefono.zzValidateLength = false;
            this.txtTelefono.zzValidMaxLength = ((short)(0));
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(249, 37);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 28;
            this.txtDireccion.Tag = "filtro";
            this.txtDireccion.ValidValue = "";
            this.txtDireccion.zzCampoBd = "direccion";
            this.txtDireccion.zzValidateIsNumeric = false;
            this.txtDireccion.zzValidateLength = false;
            this.txtDireccion.zzValidMaxLength = ((short)(0));
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Location = new System.Drawing.Point(437, 6);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(100, 20);
            this.txtPoblacion.TabIndex = 29;
            this.txtPoblacion.Tag = "filtro";
            this.txtPoblacion.ValidValue = "";
            this.txtPoblacion.zzCampoBd = "poblacion";
            this.txtPoblacion.zzValidateIsNumeric = false;
            this.txtPoblacion.zzValidateLength = false;
            this.txtPoblacion.zzValidMaxLength = ((short)(0));
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(437, 37);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 30;
            this.txtMail.Tag = "filtro";
            this.txtMail.ValidValue = "";
            this.txtMail.zzCampoBd = "mail";
            this.txtMail.zzValidateIsNumeric = false;
            this.txtMail.zzValidateLength = false;
            this.txtMail.zzValidMaxLength = ((short)(0));
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(595, 6);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 31;
            this.txtDNI.Tag = "filtro";
            this.txtDNI.ValidValue = "";
            this.txtDNI.zzCampoBd = "dni";
            this.txtDNI.zzValidateIsNumeric = false;
            this.txtDNI.zzValidateLength = false;
            this.txtDNI.zzValidMaxLength = ((short)(0));
            // 
            // frmCsCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 451);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtPoblacion);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "frmCsCliente";
            this.Text = "Selecciona un cliente";
            this.Controls.SetChildIndex(this.gbDatos, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.Controls.SetChildIndex(this.txtApellidos, 0);
            this.Controls.SetChildIndex(this.txtDireccion, 0);
            this.Controls.SetChildIndex(this.txtMail, 0);
            this.Controls.SetChildIndex(this.txtPoblacion, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.txtDNI, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomValidatorTextBox.CustomValidatorTextBox txtDNI;
        private CustomValidatorTextBox.CustomValidatorTextBox txtMail;
        private CustomValidatorTextBox.CustomValidatorTextBox txtPoblacion;
        private CustomValidatorTextBox.CustomValidatorTextBox txtDireccion;
        private CustomValidatorTextBox.CustomValidatorTextBox txtTelefono;
        private CustomValidatorTextBox.CustomValidatorTextBox txtApellidos;
        private CustomValidatorTextBox.CustomValidatorTextBox txtNombre;

    }
}