namespace solicitudes
{
    partial class frmSolPendientes
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolPendientes));
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSolicitudes = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApellidos = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtNombre = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtCodigoOficina = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtCodCuenta = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.gbSolicitudes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToDeleteRows = false;
            this.dgvSolicitudes.AllowUserToOrderColumns = true;
            this.dgvSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSolicitudes.BackgroundColor = System.Drawing.Color.White;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Location = new System.Drawing.Point(6, 19);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ReadOnly = true;
            this.dgvSolicitudes.Size = new System.Drawing.Size(772, 328);
            this.dgvSolicitudes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Cuenta";
            // 
            // gbSolicitudes
            // 
            this.gbSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSolicitudes.Controls.Add(this.dgvSolicitudes);
            this.gbSolicitudes.Location = new System.Drawing.Point(12, 105);
            this.gbSolicitudes.Name = "gbSolicitudes";
            this.gbSolicitudes.Size = new System.Drawing.Size(784, 353);
            this.gbSolicitudes.TabIndex = 3;
            this.gbSolicitudes.TabStop = false;
            this.gbSolicitudes.Text = "Solicitudes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCodigoOficina);
            this.groupBox1.Controls.Add(this.txtCodCuenta);
            this.groupBox1.Controls.Add(this.chkTodos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(346, 41);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(160, 20);
            this.txtApellidos.TabIndex = 12;
            this.txtApellidos.ValidValue = "";
            this.txtApellidos.zzCampoBd = null;
            this.txtApellidos.zzValidateIsNumeric = false;
            this.txtApellidos.zzValidateLength = false;
            this.txtApellidos.zzValidMaxLength = ((short)(0));
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 20);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.ValidValue = "";
            this.txtNombre.zzCampoBd = null;
            this.txtNombre.zzValidateIsNumeric = false;
            this.txtNombre.zzValidateLength = false;
            this.txtNombre.zzValidMaxLength = ((short)(0));
            // 
            // txtCodigoOficina
            // 
            this.txtCodigoOficina.Location = new System.Drawing.Point(101, 18);
            this.txtCodigoOficina.Name = "txtCodigoOficina";
            this.txtCodigoOficina.Size = new System.Drawing.Size(133, 20);
            this.txtCodigoOficina.TabIndex = 10;
            this.txtCodigoOficina.ValidValue = "";
            this.txtCodigoOficina.zzCampoBd = null;
            this.txtCodigoOficina.zzValidateIsNumeric = false;
            this.txtCodigoOficina.zzValidateLength = false;
            this.txtCodigoOficina.zzValidMaxLength = ((short)(0));
            // 
            // txtCodCuenta
            // 
            this.txtCodCuenta.Location = new System.Drawing.Point(346, 15);
            this.txtCodCuenta.Name = "txtCodCuenta";
            this.txtCodCuenta.Size = new System.Drawing.Size(160, 20);
            this.txtCodCuenta.TabIndex = 9;
            this.txtCodCuenta.ValidValue = "";
            this.txtCodCuenta.zzCampoBd = null;
            this.txtCodCuenta.zzValidateIsNumeric = false;
            this.txtCodCuenta.zzValidateLength = false;
            this.txtCodCuenta.zzValidMaxLength = ((short)(0));
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(639, 48);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(94, 17);
            this.chkTodos.TabIndex = 5;
            this.chkTodos.Text = "Mostrar Todas";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo Oficina";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(715, 83);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmSolPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 470);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSolicitudes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSolPendientes";
            this.Text = "Solicitudes";
            this.Load += new System.EventHandler(this.frmSolPendientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.gbSolicitudes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSolicitudes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkTodos;
        private CustomValidatorTextBox.CustomValidatorTextBox txtCodCuenta;
        private CustomValidatorTextBox.CustomValidatorTextBox txtCodigoOficina;
        private CustomValidatorTextBox.CustomValidatorTextBox txtApellidos;
        private CustomValidatorTextBox.CustomValidatorTextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
    }
}

