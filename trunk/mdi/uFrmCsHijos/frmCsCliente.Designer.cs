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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chkActivos = new System.Windows.Forms.CheckBox();
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
            this.txt = new System.Windows.Forms.TextBox();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(657, 426);
            // 
            // gbDatos
            // 
            this.gbDatos.Location = new System.Drawing.Point(3, 144);
            this.gbDatos.Size = new System.Drawing.Size(764, 276);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.txt);
            this.gbFiltros.Controls.Add(this.txtDNI);
            this.gbFiltros.Controls.Add(this.txtMail);
            this.gbFiltros.Controls.Add(this.txtPoblacion);
            this.gbFiltros.Controls.Add(this.txtDireccion);
            this.gbFiltros.Controls.Add(this.txtTelefono);
            this.gbFiltros.Controls.Add(this.txtApellidos);
            this.gbFiltros.Controls.Add(this.txtNombre);
            this.gbFiltros.Controls.Add(this.btnBuscar);
            this.gbFiltros.Controls.Add(this.label7);
            this.gbFiltros.Controls.Add(this.chkActivos);
            this.gbFiltros.Controls.Add(this.label6);
            this.gbFiltros.Controls.Add(this.label5);
            this.gbFiltros.Controls.Add(this.label4);
            this.gbFiltros.Controls.Add(this.label3);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Controls.Add(this.label1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(664, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(553, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "DNI";
            // 
            // chkActivos
            // 
            this.chkActivos.AutoSize = true;
            this.chkActivos.Checked = true;
            this.chkActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivos.Location = new System.Drawing.Point(556, 72);
            this.chkActivos.Name = "chkActivos";
            this.chkActivos.Size = new System.Drawing.Size(85, 17);
            this.chkActivos.TabIndex = 22;
            this.chkActivos.Text = "Solo Activos";
            this.chkActivos.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Poblacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(89, 20);
            this.txtNombre.TabIndex = 25;
            this.txtNombre.ValidValue = "";
            this.txtNombre.zzValidateIsNumeric = false;
            this.txtNombre.zzValidateLength = false;
            this.txtNombre.zzValidMaxLength = ((short)(0));
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(78, 74);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(89, 20);
            this.txtApellidos.TabIndex = 26;
            this.txtApellidos.ValidValue = "";
            this.txtApellidos.zzValidateIsNumeric = false;
            this.txtApellidos.zzValidateLength = false;
            this.txtApellidos.zzValidMaxLength = ((short)(0));
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(249, 19);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 27;
            this.txtTelefono.ValidValue = "";
            this.txtTelefono.zzValidateIsNumeric = false;
            this.txtTelefono.zzValidateLength = false;
            this.txtTelefono.zzValidMaxLength = ((short)(0));
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(249, 70);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 28;
            this.txtDireccion.ValidValue = "";
            this.txtDireccion.zzValidateIsNumeric = false;
            this.txtDireccion.zzValidateLength = false;
            this.txtDireccion.zzValidMaxLength = ((short)(0));
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Location = new System.Drawing.Point(437, 19);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(100, 20);
            this.txtPoblacion.TabIndex = 29;
            this.txtPoblacion.ValidValue = "";
            this.txtPoblacion.zzValidateIsNumeric = false;
            this.txtPoblacion.zzValidateLength = false;
            this.txtPoblacion.zzValidMaxLength = ((short)(0));
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(437, 70);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 30;
            this.txtMail.ValidValue = "";
            this.txtMail.zzValidateIsNumeric = false;
            this.txtMail.zzValidateLength = false;
            this.txtMail.zzValidMaxLength = ((short)(0));
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(607, 23);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 31;
            this.txtDNI.ValidValue = "";
            this.txtDNI.zzValidateIsNumeric = false;
            this.txtDNI.zzValidateLength = false;
            this.txtDNI.zzValidMaxLength = ((short)(0));
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(106, 54);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 32;
            // 
            // frmCsCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 451);
            this.Name = "frmCsCliente";
            this.Text = "Selecciona un cliente";
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkActivos;
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
        private System.Windows.Forms.TextBox txt;

    }
}