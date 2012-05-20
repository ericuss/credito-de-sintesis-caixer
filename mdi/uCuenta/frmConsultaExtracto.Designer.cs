namespace uCuenta
{
    partial class frmConsultaExtracto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaExtracto));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.chkIncluirFechas = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar1 = new customTextCs.txtBuscar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCuenta = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtCon = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtDescrip = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtImporteFin = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtImporteIni = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtEntidad = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtOficina = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtControl = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSalir
            // 
            this.txtSalir.Location = new System.Drawing.Point(287, 157);
            this.txtSalir.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(354, 157);
            this.btnUpdate.Visible = false;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(15, 157);
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(700, 157);
            this.btnLimpiar.Visible = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gbResultado
            // 
            this.gbResultado.Location = new System.Drawing.Point(12, 186);
            this.gbResultado.Size = new System.Drawing.Size(789, 361);
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.label11);
            this.gbFiltro.Controls.Add(this.txtControl);
            this.gbFiltro.Controls.Add(this.txtOficina);
            this.gbFiltro.Controls.Add(this.txtEntidad);
            this.gbFiltro.Controls.Add(this.txtImporteIni);
            this.gbFiltro.Controls.Add(this.txtImporteFin);
            this.gbFiltro.Controls.Add(this.txtDescrip);
            this.gbFiltro.Controls.Add(this.txtCon);
            this.gbFiltro.Controls.Add(this.txtCuenta);
            this.gbFiltro.Controls.Add(this.label10);
            this.gbFiltro.Controls.Add(this.label9);
            this.gbFiltro.Controls.Add(this.label8);
            this.gbFiltro.Controls.Add(this.label7);
            this.gbFiltro.Controls.Add(this.txtBuscar1);
            this.gbFiltro.Controls.Add(this.label2);
            this.gbFiltro.Controls.Add(this.dtpIni);
            this.gbFiltro.Controls.Add(this.dtpFin);
            this.gbFiltro.Controls.Add(this.label6);
            this.gbFiltro.Controls.Add(this.label5);
            this.gbFiltro.Controls.Add(this.label4);
            this.gbFiltro.Controls.Add(this.label3);
            this.gbFiltro.Controls.Add(this.label1);
            this.gbFiltro.Controls.Add(this.chkIncluirFechas);
            this.gbFiltro.Location = new System.Drawing.Point(15, -1);
            this.gbFiltro.Size = new System.Drawing.Size(752, 156);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(774, 23);
            // 
            // btnLimpiarControles
            // 
            this.btnLimpiarControles.Location = new System.Drawing.Point(119, 157);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rango de fechas de:";
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(411, 127);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 9;
            // 
            // dtpIni
            // 
            this.dtpIni.Location = new System.Drawing.Point(132, 127);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(200, 20);
            this.dtpIni.TabIndex = 10;
            this.dtpIni.ValueChanged += new System.EventHandler(this.dtpIni_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "a:";
            // 
            // chkIncluirFechas
            // 
            this.chkIncluirFechas.AutoSize = true;
            this.chkIncluirFechas.Location = new System.Drawing.Point(627, 129);
            this.chkIncluirFechas.Name = "chkIncluirFechas";
            this.chkIncluirFechas.Size = new System.Drawing.Size(95, 17);
            this.chkIncluirFechas.TabIndex = 0;
            this.chkIncluirFechas.Text = "Incluir fechas?";
            this.chkIncluirFechas.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Concepto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Importe de:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "a:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(596, 157);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.Location = new System.Drawing.Point(86, 9);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(426, 33);
            this.txtBuscar1.TabIndex = 18;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Numero de cuenta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Entidad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Oficina:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Control:";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(523, 42);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(112, 20);
            this.txtCuenta.TabIndex = 27;
            this.txtCuenta.ValidValue = "";
            this.txtCuenta.zzCampoBd = null;
            this.txtCuenta.zzValidateIsNumeric = true;
            this.txtCuenta.zzValidateLength = true;
            this.txtCuenta.zzValidMaxLength = ((short)(8));
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(411, 99);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(200, 20);
            this.txtCon.TabIndex = 28;
            this.txtCon.ValidValue = "";
            this.txtCon.zzCampoBd = null;
            this.txtCon.zzValidateIsNumeric = false;
            this.txtCon.zzValidateLength = false;
            this.txtCon.zzValidMaxLength = ((short)(0));
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(132, 99);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(200, 20);
            this.txtDescrip.TabIndex = 29;
            this.txtDescrip.ValidValue = "";
            this.txtDescrip.zzCampoBd = null;
            this.txtDescrip.zzValidateIsNumeric = false;
            this.txtDescrip.zzValidateLength = false;
            this.txtDescrip.zzValidMaxLength = ((short)(0));
            // 
            // txtImporteFin
            // 
            this.txtImporteFin.Location = new System.Drawing.Point(411, 67);
            this.txtImporteFin.Name = "txtImporteFin";
            this.txtImporteFin.Size = new System.Drawing.Size(200, 20);
            this.txtImporteFin.TabIndex = 30;
            this.txtImporteFin.ValidValue = "";
            this.txtImporteFin.zzCampoBd = null;
            this.txtImporteFin.zzValidateIsNumeric = true;
            this.txtImporteFin.zzValidateLength = false;
            this.txtImporteFin.zzValidMaxLength = ((short)(0));
            // 
            // txtImporteIni
            // 
            this.txtImporteIni.Location = new System.Drawing.Point(132, 71);
            this.txtImporteIni.Name = "txtImporteIni";
            this.txtImporteIni.Size = new System.Drawing.Size(200, 20);
            this.txtImporteIni.TabIndex = 31;
            this.txtImporteIni.ValidValue = "";
            this.txtImporteIni.zzCampoBd = null;
            this.txtImporteIni.zzValidateIsNumeric = true;
            this.txtImporteIni.zzValidateLength = false;
            this.txtImporteIni.zzValidMaxLength = ((short)(0));
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(185, 42);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(71, 20);
            this.txtEntidad.TabIndex = 32;
            this.txtEntidad.ValidValue = "";
            this.txtEntidad.zzCampoBd = null;
            this.txtEntidad.zzValidateIsNumeric = true;
            this.txtEntidad.zzValidateLength = true;
            this.txtEntidad.zzValidMaxLength = ((short)(4));
            // 
            // txtOficina
            // 
            this.txtOficina.Location = new System.Drawing.Point(308, 42);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.Size = new System.Drawing.Size(71, 20);
            this.txtOficina.TabIndex = 33;
            this.txtOficina.ValidValue = "";
            this.txtOficina.zzCampoBd = null;
            this.txtOficina.zzValidateIsNumeric = true;
            this.txtOficina.zzValidateLength = true;
            this.txtOficina.zzValidMaxLength = ((short)(4));
            // 
            // txtControl
            // 
            this.txtControl.Location = new System.Drawing.Point(430, 42);
            this.txtControl.Name = "txtControl";
            this.txtControl.Size = new System.Drawing.Size(35, 20);
            this.txtControl.TabIndex = 34;
            this.txtControl.ValidValue = "";
            this.txtControl.zzCampoBd = null;
            this.txtControl.zzValidateIsNumeric = true;
            this.txtControl.zzValidateLength = true;
            this.txtControl.zzValidMaxLength = ((short)(2));
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(468, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Cuenta:";
            // 
            // frmConsultaExtracto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 559);
            this.Controls.Add(this.btnBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmConsultaExtracto";
            this.Text = "Consulta del Extracto";
            this.Load += new System.EventHandler(this.frmConsultaExtracto_Load);
            this.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.Controls.SetChildIndex(this.btnPdf, 0);
            this.Controls.SetChildIndex(this.btnLimpiarControles, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.gbFiltro, 0);
            this.Controls.SetChildIndex(this.gbResultado, 0);
            this.Controls.SetChildIndex(this.txtSalir, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnTodos, 0);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkIncluirFechas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private customTextCs.txtBuscar txtBuscar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private CustomValidatorTextBox.CustomValidatorTextBox txtControl;
        private CustomValidatorTextBox.CustomValidatorTextBox txtOficina;
        private CustomValidatorTextBox.CustomValidatorTextBox txtEntidad;
        private CustomValidatorTextBox.CustomValidatorTextBox txtImporteIni;
        private CustomValidatorTextBox.CustomValidatorTextBox txtImporteFin;
        private CustomValidatorTextBox.CustomValidatorTextBox txtDescrip;
        private CustomValidatorTextBox.CustomValidatorTextBox txtCon;
        private CustomValidatorTextBox.CustomValidatorTextBox txtCuenta;
    }
}