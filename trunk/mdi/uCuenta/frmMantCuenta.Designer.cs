namespace uCuenta
{
    partial class frmMantCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantCuenta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnNuevaCuenta = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.csBuscar = new customTextCs.txtBuscar();
            this.txtCuenta = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbFiltro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSalir
            // 
            this.txtSalir.Location = new System.Drawing.Point(566, 83);
            this.txtSalir.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(405, 83);
            this.btnUpdate.Size = new System.Drawing.Size(12, 23);
            this.btnUpdate.Visible = false;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(40, 83);
            this.btnTodos.Size = new System.Drawing.Size(11, 23);
            this.btnTodos.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(375, 83);
            this.btnLimpiar.Size = new System.Drawing.Size(10, 23);
            this.btnLimpiar.Visible = false;
            // 
            // gbResultado
            // 
            this.gbResultado.Location = new System.Drawing.Point(12, 112);
            this.gbResultado.Size = new System.Drawing.Size(672, 201);
            this.gbResultado.Text = "Cuentas";
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.btnBuscar);
            this.gbFiltro.Controls.Add(this.label1);
            this.gbFiltro.Controls.Add(this.txtCuenta);
            this.gbFiltro.Controls.Add(this.csBuscar);
            this.gbFiltro.Location = new System.Drawing.Point(15, 0);
            this.gbFiltro.Size = new System.Drawing.Size(645, 80);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(666, 9);
            this.btnPdf.Visible = false;
            // 
            // btnLimpiarControles
            // 
            this.btnLimpiarControles.Location = new System.Drawing.Point(21, 83);
            this.btnLimpiarControles.Size = new System.Drawing.Size(117, 23);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvCliente);
            this.groupBox1.Location = new System.Drawing.Point(15, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 130);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Titulares";
            // 
            // dgvCliente
            // 
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(6, 19);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(657, 105);
            this.dgvCliente.TabIndex = 0;
            // 
            // btnNuevaCuenta
            // 
            this.btnNuevaCuenta.Location = new System.Drawing.Point(439, 83);
            this.btnNuevaCuenta.Name = "btnNuevaCuenta";
            this.btnNuevaCuenta.Size = new System.Drawing.Size(75, 23);
            this.btnNuevaCuenta.TabIndex = 17;
            this.btnNuevaCuenta.Text = "Nuevo";
            this.btnNuevaCuenta.UseVisualStyleBackColor = true;
            this.btnNuevaCuenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(589, 83);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 18;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMantenimiento.Location = new System.Drawing.Point(15, 319);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(157, 23);
            this.btnMantenimiento.TabIndex = 19;
            this.btnMantenimiento.Text = "Administrar Titulares";
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            this.btnMantenimiento.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // csBuscar
            // 
            this.csBuscar.Location = new System.Drawing.Point(52, 11);
            this.csBuscar.Name = "csBuscar";
            this.csBuscar.Size = new System.Drawing.Size(426, 35);
            this.csBuscar.TabIndex = 0;
            this.csBuscar.zzCampoDesc = "nombre, apellidos";
            this.csBuscar.zzCampoId = "dni";
            this.csBuscar.zzEtiqueta = "Titular:";
            this.csBuscar.zzIdIsNumber = false;
            this.csBuscar.zzIdVisible = false;
            this.csBuscar.zzTabla = "cliente";
            this.csBuscar.zzTxtDesc = "";
            this.csBuscar.zzTxtId = "";
            this.csBuscar.zzWidthDesc = "160";
            this.csBuscar.zzWidthId = "100";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(122, 46);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(211, 20);
            this.txtCuenta.TabIndex = 1;
            this.txtCuenta.ValidValue = "";
            this.txtCuenta.zzCampoBd = null;
            this.txtCuenta.zzValidateIsNumeric = false;
            this.txtCuenta.zzValidateLength = false;
            this.txtCuenta.zzValidMaxLength = ((short)(0));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero Cuenta:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(564, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmMantCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 490);
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnNuevaCuenta);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmMantCuenta";
            this.Text = "Mantenimiento de Cuentas";
            this.Load += new System.EventHandler(this.frmMantCuenta_Load);
            this.Controls.SetChildIndex(this.btnLimpiarControles, 0);
            this.Controls.SetChildIndex(this.btnTodos, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.gbResultado, 0);
            this.Controls.SetChildIndex(this.txtSalir, 0);
            this.Controls.SetChildIndex(this.gbFiltro, 0);
            this.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.Controls.SetChildIndex(this.btnPdf, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnNuevaCuenta, 0);
            this.Controls.SetChildIndex(this.btnBorrar, 0);
            this.Controls.SetChildIndex(this.btnMantenimiento, 0);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnNuevaCuenta;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private CustomValidatorTextBox.CustomValidatorTextBox txtCuenta;
        private customTextCs.txtBuscar csBuscar;
    }
}