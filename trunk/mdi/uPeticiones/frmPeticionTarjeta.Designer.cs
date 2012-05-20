namespace uPeticiones
{
    partial class frmPeticionTarjeta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPers = new System.Windows.Forms.TabPage();
            this.tabCuenta = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtFechaNaci = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbxTitulares = new System.Windows.Forms.GroupBox();
            this.dgvTitulares = new System.Windows.Forms.DataGridView();
            this.btnVerCuenta = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnDenegar = new System.Windows.Forms.Button();
            this.btnMantener = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPers.SuspendLayout();
            this.tabCuenta.SuspendLayout();
            this.gbxTitulares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulares)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPers);
            this.tabControl1.Controls.Add(this.tabCuenta);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(463, 406);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPers
            // 
            this.tabPers.Controls.Add(this.label8);
            this.tabPers.Controls.Add(this.label4);
            this.tabPers.Controls.Add(this.label5);
            this.tabPers.Controls.Add(this.label6);
            this.tabPers.Controls.Add(this.label3);
            this.tabPers.Controls.Add(this.txtFechaNaci);
            this.tabPers.Controls.Add(this.txtCorreo);
            this.tabPers.Controls.Add(this.txtPoblacion);
            this.tabPers.Controls.Add(this.txtTelefono);
            this.tabPers.Controls.Add(this.txtApellidos);
            this.tabPers.Controls.Add(this.txtNombre);
            this.tabPers.Controls.Add(this.label2);
            this.tabPers.Controls.Add(this.txtDni);
            this.tabPers.Controls.Add(this.label1);
            this.tabPers.Location = new System.Drawing.Point(4, 22);
            this.tabPers.Name = "tabPers";
            this.tabPers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPers.Size = new System.Drawing.Size(455, 380);
            this.tabPers.TabIndex = 0;
            this.tabPers.Text = "Datos Personales";
            this.tabPers.UseVisualStyleBackColor = true;
            this.tabPers.Click += new System.EventHandler(this.tabPers_Click);
            // 
            // tabCuenta
            // 
            this.tabCuenta.Controls.Add(this.btnVerCuenta);
            this.tabCuenta.Controls.Add(this.gbxTitulares);
            this.tabCuenta.Controls.Add(this.txtSaldo);
            this.tabCuenta.Controls.Add(this.label7);
            this.tabCuenta.Controls.Add(this.txtCuenta);
            this.tabCuenta.Controls.Add(this.label9);
            this.tabCuenta.Location = new System.Drawing.Point(4, 22);
            this.tabCuenta.Name = "tabCuenta";
            this.tabCuenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabCuenta.Size = new System.Drawing.Size(455, 380);
            this.tabCuenta.TabIndex = 1;
            this.tabCuenta.Text = "Datos de la Cuenta";
            this.tabCuenta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dni:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(112, 29);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(181, 20);
            this.txtDni.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(181, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(112, 113);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(181, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(112, 84);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(181, 20);
            this.txtApellidos.TabIndex = 4;
            // 
            // txtFechaNaci
            // 
            this.txtFechaNaci.Location = new System.Drawing.Point(112, 194);
            this.txtFechaNaci.Name = "txtFechaNaci";
            this.txtFechaNaci.Size = new System.Drawing.Size(181, 20);
            this.txtFechaNaci.TabIndex = 8;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(112, 168);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(181, 20);
            this.txtCorreo.TabIndex = 7;
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Location = new System.Drawing.Point(112, 139);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(181, 20);
            this.txtPoblacion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Poblacion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fecha Naci.:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(111, 53);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(181, 20);
            this.txtSaldo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saldo:";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(111, 24);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(181, 20);
            this.txtCuenta.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cuenta:";
            // 
            // gbxTitulares
            // 
            this.gbxTitulares.Controls.Add(this.dgvTitulares);
            this.gbxTitulares.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxTitulares.Location = new System.Drawing.Point(3, 146);
            this.gbxTitulares.Name = "gbxTitulares";
            this.gbxTitulares.Size = new System.Drawing.Size(449, 231);
            this.gbxTitulares.TabIndex = 8;
            this.gbxTitulares.TabStop = false;
            this.gbxTitulares.Text = "Titulares de la cuenta";
            // 
            // dgvTitulares
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTitulares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTitulares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTitulares.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTitulares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTitulares.Location = new System.Drawing.Point(3, 16);
            this.dgvTitulares.Name = "dgvTitulares";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTitulares.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTitulares.Size = new System.Drawing.Size(443, 212);
            this.dgvTitulares.TabIndex = 0;
            // 
            // btnVerCuenta
            // 
            this.btnVerCuenta.Location = new System.Drawing.Point(336, 107);
            this.btnVerCuenta.Name = "btnVerCuenta";
            this.btnVerCuenta.Size = new System.Drawing.Size(100, 23);
            this.btnVerCuenta.TabIndex = 9;
            this.btnVerCuenta.Text = "Ver la Cuenta";
            this.btnVerCuenta.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(22, 451);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnDenegar
            // 
            this.btnDenegar.Location = new System.Drawing.Point(206, 451);
            this.btnDenegar.Name = "btnDenegar";
            this.btnDenegar.Size = new System.Drawing.Size(100, 23);
            this.btnDenegar.TabIndex = 11;
            this.btnDenegar.Text = "Denegar";
            this.btnDenegar.UseVisualStyleBackColor = true;
            // 
            // btnMantener
            // 
            this.btnMantener.Location = new System.Drawing.Point(370, 451);
            this.btnMantener.Name = "btnMantener";
            this.btnMantener.Size = new System.Drawing.Size(100, 23);
            this.btnMantener.TabIndex = 12;
            this.btnMantener.Text = "Mantener";
            this.btnMantener.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Solicitud:";
            // 
            // frmPeticionTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 496);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnMantener);
            this.Controls.Add(this.btnDenegar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPeticionTarjeta";
            this.Text = "Consulta de Peticion de Tarjetas al Detalle";
            this.tabControl1.ResumeLayout(false);
            this.tabPers.ResumeLayout(false);
            this.tabPers.PerformLayout();
            this.tabCuenta.ResumeLayout(false);
            this.tabCuenta.PerformLayout();
            this.gbxTitulares.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFechaNaci;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtPoblacion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabCuenta;
        private System.Windows.Forms.GroupBox gbxTitulares;
        private System.Windows.Forms.DataGridView dgvTitulares;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVerCuenta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnDenegar;
        private System.Windows.Forms.Button btnMantener;
        private System.Windows.Forms.Label label10;
    }
}