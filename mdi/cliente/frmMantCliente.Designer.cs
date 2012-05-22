namespace cliente
{
    partial class frmMantCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantCliente));
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkActivos = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtApellidos = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtTelefono = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtDireccion = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtPoblacion = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtMail = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtDNI = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtError = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSalir
            // 
            this.txtSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalir.Location = new System.Drawing.Point(553, 124);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(72, 124);
            this.btnUpdate.Size = new System.Drawing.Size(10, 23);
            this.btnUpdate.Visible = false;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(40, 124);
            this.btnTodos.Size = new System.Drawing.Size(10, 23);
            this.btnTodos.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(56, 124);
            this.btnLimpiar.Size = new System.Drawing.Size(10, 23);
            this.btnLimpiar.Visible = false;
            // 
            // gbResultado
            // 
            this.gbResultado.Location = new System.Drawing.Point(12, 153);
            this.gbResultado.Size = new System.Drawing.Size(656, 281);
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.txtDNI);
            this.gbFiltro.Controls.Add(this.txtMail);
            this.gbFiltro.Controls.Add(this.txtPoblacion);
            this.gbFiltro.Controls.Add(this.txtDireccion);
            this.gbFiltro.Controls.Add(this.txtTelefono);
            this.gbFiltro.Controls.Add(this.txtApellidos);
            this.gbFiltro.Controls.Add(this.txtNombre);
            this.gbFiltro.Controls.Add(this.btnBuscar);
            this.gbFiltro.Controls.Add(this.label7);
            this.gbFiltro.Controls.Add(this.chkActivos);
            this.gbFiltro.Controls.Add(this.label6);
            this.gbFiltro.Controls.Add(this.label5);
            this.gbFiltro.Controls.Add(this.label4);
            this.gbFiltro.Controls.Add(this.label3);
            this.gbFiltro.Controls.Add(this.label2);
            this.gbFiltro.Controls.Add(this.label1);
            this.gbFiltro.Size = new System.Drawing.Size(650, 106);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(662, 24);
            this.btnPdf.Size = new System.Drawing.Size(10, 37);
            this.btnPdf.Visible = false;
            // 
            // btnLimpiarControles
            // 
            this.btnLimpiarControles.Location = new System.Drawing.Point(82, 124);
            this.btnLimpiarControles.Size = new System.Drawing.Size(99, 23);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(187, 124);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(268, 124);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "Borrar";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(391, 124);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 18;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Poblacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mail";
            // 
            // chkActivos
            // 
            this.chkActivos.AutoSize = true;
            this.chkActivos.Checked = true;
            this.chkActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivos.Location = new System.Drawing.Point(455, 67);
            this.chkActivos.Name = "chkActivos";
            this.chkActivos.Size = new System.Drawing.Size(85, 17);
            this.chkActivos.TabIndex = 6;
            this.chkActivos.Text = "Solo Activos";
            this.chkActivos.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "DNI";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(546, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(57, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(97, 20);
            this.txtNombre.TabIndex = 16;
            this.txtNombre.ValidValue = "";
            this.txtNombre.zzCampoBd = null;
            this.txtNombre.zzValidateIsNumeric = false;
            this.txtNombre.zzValidateLength = false;
            this.txtNombre.zzValidMaxLength = ((short)(0));
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(57, 69);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(97, 20);
            this.txtApellidos.TabIndex = 17;
            this.txtApellidos.ValidValue = "";
            this.txtApellidos.zzCampoBd = null;
            this.txtApellidos.zzValidateIsNumeric = false;
            this.txtApellidos.zzValidateLength = false;
            this.txtApellidos.zzValidMaxLength = ((short)(0));
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(216, 19);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(85, 20);
            this.txtTelefono.TabIndex = 18;
            this.txtTelefono.ValidValue = "";
            this.txtTelefono.zzCampoBd = null;
            this.txtTelefono.zzValidateIsNumeric = false;
            this.txtTelefono.zzValidateLength = false;
            this.txtTelefono.zzValidMaxLength = ((short)(0));
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(216, 69);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(85, 20);
            this.txtDireccion.TabIndex = 19;
            this.txtDireccion.ValidValue = "";
            this.txtDireccion.zzCampoBd = null;
            this.txtDireccion.zzValidateIsNumeric = false;
            this.txtDireccion.zzValidateLength = false;
            this.txtDireccion.zzValidMaxLength = ((short)(0));
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Location = new System.Drawing.Point(367, 18);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(77, 20);
            this.txtPoblacion.TabIndex = 20;
            this.txtPoblacion.ValidValue = "";
            this.txtPoblacion.zzCampoBd = null;
            this.txtPoblacion.zzValidateIsNumeric = false;
            this.txtPoblacion.zzValidateLength = false;
            this.txtPoblacion.zzValidMaxLength = ((short)(0));
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(339, 69);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(93, 20);
            this.txtMail.TabIndex = 21;
            this.txtMail.ValidValue = "";
            this.txtMail.zzCampoBd = null;
            this.txtMail.zzValidateIsNumeric = false;
            this.txtMail.zzValidateLength = false;
            this.txtMail.zzValidMaxLength = ((short)(0));
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(484, 17);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(110, 20);
            this.txtDNI.TabIndex = 22;
            this.txtDNI.ValidValue = "";
            this.txtDNI.zzCampoBd = null;
            this.txtDNI.zzValidateIsNumeric = false;
            this.txtDNI.zzValidateLength = false;
            this.txtDNI.zzValidMaxLength = ((short)(0));
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(15, 440);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(653, 20);
            this.txtError.TabIndex = 19;
            this.txtError.ValidValue = "";
            this.txtError.Visible = false;
            this.txtError.zzCampoBd = null;
            this.txtError.zzValidateIsNumeric = false;
            this.txtError.zzValidateLength = false;
            this.txtError.zzValidMaxLength = ((short)(0));
            // 
            // frmMantCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 467);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmMantCliente";
            this.Text = "Mantenimiento de Clientes";
            this.Load += new System.EventHandler(this.frmMantCliente_Load);
            this.Controls.SetChildIndex(this.btnPdf, 0);
            this.Controls.SetChildIndex(this.btnTodos, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.gbResultado, 0);
            this.Controls.SetChildIndex(this.txtSalir, 0);
            this.Controls.SetChildIndex(this.gbFiltro, 0);
            this.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.Controls.SetChildIndex(this.btnLimpiarControles, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnDel, 0);
            this.Controls.SetChildIndex(this.btnMod, 0);
            this.Controls.SetChildIndex(this.txtError, 0);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkActivos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private CustomValidatorTextBox.CustomValidatorTextBox txtDNI;
        private CustomValidatorTextBox.CustomValidatorTextBox txtMail;
        private CustomValidatorTextBox.CustomValidatorTextBox txtPoblacion;
        private CustomValidatorTextBox.CustomValidatorTextBox txtDireccion;
        private CustomValidatorTextBox.CustomValidatorTextBox txtTelefono;
        private CustomValidatorTextBox.CustomValidatorTextBox txtApellidos;
        private CustomValidatorTextBox.CustomValidatorTextBox txtNombre;
        private CustomValidatorTextBox.CustomValidatorTextBox txtError;
    }
}