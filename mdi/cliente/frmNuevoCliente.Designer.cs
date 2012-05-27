namespace cliente
{
    partial class frmNuevoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoCliente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkReactivar = new System.Windows.Forms.CheckBox();
            this.lblUsr = new System.Windows.Forms.Label();
            this.txtUsuario = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtFechaNacimiento = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtDNI = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtMail = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtPoblacion = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtDireccion = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtTelfono = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtApellido = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtNombre = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.chkCrearUser = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtError = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.chkReactivar);
            this.groupBox1.Controls.Add(this.lblUsr);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.txtFechaNacimiento);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtPoblacion);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtTelfono);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.chkCrearUser);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // chkReactivar
            // 
            this.chkReactivar.AutoSize = true;
            this.chkReactivar.Location = new System.Drawing.Point(237, 295);
            this.chkReactivar.Name = "chkReactivar";
            this.chkReactivar.Size = new System.Drawing.Size(72, 17);
            this.chkReactivar.TabIndex = 30;
            this.chkReactivar.Text = "Reactivar";
            this.chkReactivar.UseVisualStyleBackColor = true;
            // 
            // lblUsr
            // 
            this.lblUsr.AutoSize = true;
            this.lblUsr.Location = new System.Drawing.Point(36, 296);
            this.lblUsr.Name = "lblUsr";
            this.lblUsr.Size = new System.Drawing.Size(43, 13);
            this.lblUsr.TabIndex = 29;
            this.lblUsr.Text = "Usuario";
            this.lblUsr.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(98, 293);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(117, 20);
            this.txtUsuario.TabIndex = 28;
            this.txtUsuario.ValidValue = "";
            this.txtUsuario.Visible = false;
            this.txtUsuario.zzCampoBd = null;
            this.txtUsuario.zzValidateIsNumeric = false;
            this.txtUsuario.zzValidateLength = false;
            this.txtUsuario.zzValidMaxLength = ((short)(0));
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(130, 229);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(157, 20);
            this.txtFechaNacimiento.TabIndex = 27;
            this.txtFechaNacimiento.ValidValue = "";
            this.txtFechaNacimiento.zzCampoBd = null;
            this.txtFechaNacimiento.zzValidateIsNumeric = false;
            this.txtFechaNacimiento.zzValidateLength = false;
            this.txtFechaNacimiento.zzValidMaxLength = ((short)(0));
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(130, 200);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(157, 20);
            this.txtDNI.TabIndex = 26;
            this.txtDNI.ValidValue = "";
            this.txtDNI.zzCampoBd = null;
            this.txtDNI.zzValidateIsNumeric = false;
            this.txtDNI.zzValidateLength = false;
            this.txtDNI.zzValidMaxLength = ((short)(0));
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(130, 171);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(157, 20);
            this.txtMail.TabIndex = 25;
            this.txtMail.ValidValue = "";
            this.txtMail.zzCampoBd = null;
            this.txtMail.zzValidateIsNumeric = false;
            this.txtMail.zzValidateLength = false;
            this.txtMail.zzValidMaxLength = ((short)(0));
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Location = new System.Drawing.Point(130, 142);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(157, 20);
            this.txtPoblacion.TabIndex = 24;
            this.txtPoblacion.ValidValue = "";
            this.txtPoblacion.zzCampoBd = null;
            this.txtPoblacion.zzValidateIsNumeric = false;
            this.txtPoblacion.zzValidateLength = false;
            this.txtPoblacion.zzValidMaxLength = ((short)(0));
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(130, 113);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(157, 20);
            this.txtDireccion.TabIndex = 23;
            this.txtDireccion.ValidValue = "";
            this.txtDireccion.zzCampoBd = null;
            this.txtDireccion.zzValidateIsNumeric = false;
            this.txtDireccion.zzValidateLength = false;
            this.txtDireccion.zzValidMaxLength = ((short)(0));
            // 
            // txtTelfono
            // 
            this.txtTelfono.Location = new System.Drawing.Point(130, 84);
            this.txtTelfono.Name = "txtTelfono";
            this.txtTelfono.Size = new System.Drawing.Size(157, 20);
            this.txtTelfono.TabIndex = 22;
            this.txtTelfono.ValidValue = "";
            this.txtTelfono.zzCampoBd = null;
            this.txtTelfono.zzValidateIsNumeric = false;
            this.txtTelfono.zzValidateLength = false;
            this.txtTelfono.zzValidMaxLength = ((short)(0));
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(130, 55);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(157, 20);
            this.txtApellido.TabIndex = 21;
            this.txtApellido.ValidValue = "";
            this.txtApellido.zzCampoBd = null;
            this.txtApellido.zzValidateIsNumeric = false;
            this.txtApellido.zzValidateLength = false;
            this.txtApellido.zzValidMaxLength = ((short)(0));
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 20);
            this.txtNombre.TabIndex = 20;
            this.txtNombre.ValidValue = "";
            this.txtNombre.zzCampoBd = null;
            this.txtNombre.zzValidateIsNumeric = false;
            this.txtNombre.zzValidateLength = false;
            this.txtNombre.zzValidMaxLength = ((short)(0));
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(242, 329);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(140, 329);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // chkCrearUser
            // 
            this.chkCrearUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCrearUser.AutoSize = true;
            this.chkCrearUser.Location = new System.Drawing.Point(151, 259);
            this.chkCrearUser.Name = "chkCrearUser";
            this.chkCrearUser.Size = new System.Drawing.Size(116, 17);
            this.chkCrearUser.TabIndex = 16;
            this.chkCrearUser.Text = "Crear Usuario Web";
            this.chkCrearUser.UseVisualStyleBackColor = true;
            this.chkCrearUser.CheckedChanged += new System.EventHandler(this.chkCrearUser_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Poblacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtError
            // 
            this.txtError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtError.Location = new System.Drawing.Point(12, 397);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(325, 20);
            this.txtError.TabIndex = 1;
            this.txtError.ValidValue = "";
            this.txtError.Visible = false;
            this.txtError.zzCampoBd = null;
            this.txtError.zzValidateIsNumeric = false;
            this.txtError.zzValidateLength = false;
            this.txtError.zzValidMaxLength = ((short)(0));
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(53, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(49, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(49, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(47, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(46, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(73, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(74, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(6, 225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "*";
            // 
            // frmNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 422);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevoCliente";
            this.Text = "Nuevo Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox chkCrearUser;
        private System.Windows.Forms.Button btnCancelar;
        private CustomValidatorTextBox.CustomValidatorTextBox txtError;
        private CustomValidatorTextBox.CustomValidatorTextBox txtFechaNacimiento;
        private CustomValidatorTextBox.CustomValidatorTextBox txtDNI;
        private CustomValidatorTextBox.CustomValidatorTextBox txtMail;
        private CustomValidatorTextBox.CustomValidatorTextBox txtPoblacion;
        private CustomValidatorTextBox.CustomValidatorTextBox txtDireccion;
        private CustomValidatorTextBox.CustomValidatorTextBox txtTelfono;
        private CustomValidatorTextBox.CustomValidatorTextBox txtApellido;
        private CustomValidatorTextBox.CustomValidatorTextBox txtNombre;
        private CustomValidatorTextBox.CustomValidatorTextBox txtUsuario;
        private System.Windows.Forms.Label lblUsr;
        private System.Windows.Forms.CheckBox chkReactivar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}