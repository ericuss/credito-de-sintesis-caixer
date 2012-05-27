namespace uCuenta
{
    /// <summary>
    /// Añade titulares a una cuenta
    /// </summary>
    partial class frmAnadirTitulares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnadirTitulares));
            this.csBuscarCliente = new customTextCs.txtBuscar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTitulares = new System.Windows.Forms.DataGridView();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtError = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulares)).BeginInit();
            this.SuspendLayout();
            // 
            // csBuscarCliente
            // 
            this.csBuscarCliente.Location = new System.Drawing.Point(31, 36);
            this.csBuscarCliente.Name = "csBuscarCliente";
            this.csBuscarCliente.Size = new System.Drawing.Size(426, 35);
            this.csBuscarCliente.TabIndex = 0;
            this.csBuscarCliente.zzCampoDesc = "nombre,apellidos";
            this.csBuscarCliente.zzCampoId = "dni";
            this.csBuscarCliente.zzEtiqueta = "Cliente:";
            this.csBuscarCliente.zzIdIsNumber = false;
            this.csBuscarCliente.zzIdVisible = false;
            this.csBuscarCliente.zzTabla = "cliente";
            this.csBuscarCliente.zzTxtDesc = "";
            this.csBuscarCliente.zzTxtId = "";
            this.csBuscarCliente.zzWidthDesc = "160";
            this.csBuscarCliente.zzWidthId = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuenta";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Enabled = false;
            this.txtCuenta.Location = new System.Drawing.Point(100, 10);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(221, 20);
            this.txtCuenta.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTitulares);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Titulares";
            // 
            // dgvTitulares
            // 
            this.dgvTitulares.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTitulares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTitulares.BackgroundColor = System.Drawing.Color.White;
            this.dgvTitulares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitulares.Location = new System.Drawing.Point(10, 16);
            this.dgvTitulares.Name = "dgvTitulares";
            this.dgvTitulares.Size = new System.Drawing.Size(443, 136);
            this.dgvTitulares.TabIndex = 0;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(396, 77);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 23);
            this.btnAnadir.TabIndex = 4;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(305, 77);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(12, 272);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(459, 20);
            this.txtError.TabIndex = 6;
            this.txtError.ValidValue = "";
            this.txtError.Visible = false;
            this.txtError.zzCampoBd = null;
            this.txtError.zzValidateIsNumeric = false;
            this.txtError.zzValidateLength = false;
            this.txtError.zzValidMaxLength = ((short)(0));
            // 
            // frmAnadirTitulares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 304);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.csBuscarCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAnadirTitulares";
            this.Text = "Administrar Titulares";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private customTextCs.txtBuscar csBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTitulares;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnBorrar;
        private CustomValidatorTextBox.CustomValidatorTextBox txtError;
    }
}