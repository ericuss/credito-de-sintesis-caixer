﻿namespace uCuenta
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
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImporteIni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImporteFin = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar1 = new customTextCs.txtBuscar();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSalir
            // 
            this.txtSalir.Location = new System.Drawing.Point(287, 167);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(287, 167);
            this.btnUpdate.Visible = false;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(15, 167);
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(150, 167);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gbResultado
            // 
            this.gbResultado.Location = new System.Drawing.Point(12, 199);
            this.gbResultado.Size = new System.Drawing.Size(817, 306);
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.txtBuscar1);
            this.gbFiltro.Controls.Add(this.label2);
            this.gbFiltro.Controls.Add(this.txtImporteFin);
            this.gbFiltro.Controls.Add(this.dtpIni);
            this.gbFiltro.Controls.Add(this.dtpFin);
            this.gbFiltro.Controls.Add(this.label6);
            this.gbFiltro.Controls.Add(this.label5);
            this.gbFiltro.Controls.Add(this.txtImporteIni);
            this.gbFiltro.Controls.Add(this.label4);
            this.gbFiltro.Controls.Add(this.label3);
            this.gbFiltro.Controls.Add(this.label1);
            this.gbFiltro.Controls.Add(this.txtCon);
            this.gbFiltro.Controls.Add(this.txtDescrip);
            this.gbFiltro.Controls.Add(this.chkIncluirFechas);
            this.gbFiltro.Size = new System.Drawing.Size(780, 151);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(810, 30);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rango de fechas de:";
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(410, 119);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 9;
            // 
            // dtpIni
            // 
            this.dtpIni.Location = new System.Drawing.Point(131, 119);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(200, 20);
            this.dtpIni.TabIndex = 10;
            this.dtpIni.ValueChanged += new System.EventHandler(this.dtpIni_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "a:";
            // 
            // chkIncluirFechas
            // 
            this.chkIncluirFechas.AutoSize = true;
            this.chkIncluirFechas.Location = new System.Drawing.Point(625, 97);
            this.chkIncluirFechas.Name = "chkIncluirFechas";
            this.chkIncluirFechas.Size = new System.Drawing.Size(95, 17);
            this.chkIncluirFechas.TabIndex = 0;
            this.chkIncluirFechas.Text = "Incluir fechas?";
            this.chkIncluirFechas.UseVisualStyleBackColor = true;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(129, 92);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(200, 20);
            this.txtDescrip.TabIndex = 1;
            this.txtDescrip.Leave += new System.EventHandler(this.txtDescrip_Leave);
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(407, 93);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(200, 20);
            this.txtCon.TabIndex = 2;
            this.txtCon.Leave += new System.EventHandler(this.txtCon_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Concepto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Importe de:";
            // 
            // txtImporteIni
            // 
            this.txtImporteIni.Location = new System.Drawing.Point(129, 64);
            this.txtImporteIni.Name = "txtImporteIni";
            this.txtImporteIni.Size = new System.Drawing.Size(200, 20);
            this.txtImporteIni.TabIndex = 15;
            this.txtImporteIni.Leave += new System.EventHandler(this.txtImporteIni_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "a:";
            // 
            // txtImporteFin
            // 
            this.txtImporteFin.Location = new System.Drawing.Point(406, 64);
            this.txtImporteFin.Name = "txtImporteFin";
            this.txtImporteFin.Size = new System.Drawing.Size(200, 20);
            this.txtImporteFin.TabIndex = 17;
            this.txtImporteFin.Leave += new System.EventHandler(this.txtImporteFin_Leave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(596, 167);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.Location = new System.Drawing.Point(60, 18);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(426, 33);
            this.txtBuscar1.TabIndex = 18;
            this.txtBuscar1.zzCampoDesc = "nombre, apellidos";
            this.txtBuscar1.zzCampoId = "dni";
            this.txtBuscar1.zzEtiqueta = "Cliente:";
            this.txtBuscar1.zzIdIsNumber = false;
            this.txtBuscar1.zzIdVisible = false;
            this.txtBuscar1.zzTabla = "cliente";
            this.txtBuscar1.zzWidthDesc = "160";
            this.txtBuscar1.zzWidthId = "100";
            // 
            // frmConsultaExtracto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 517);
            this.Controls.Add(this.btnBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaExtracto";
            this.Text = "Consulta del Extracto";
            this.Load += new System.EventHandler(this.frmConsultaExtracto_Load);
            this.Controls.SetChildIndex(this.btnPdf, 0);
            this.Controls.SetChildIndex(this.gbFiltro, 0);
            this.Controls.SetChildIndex(this.gbResultado, 0);
            this.Controls.SetChildIndex(this.txtSalir, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnTodos, 0);
            this.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
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
        private System.Windows.Forms.TextBox txtImporteFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImporteIni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Button btnBuscar;
        private customTextCs.txtBuscar txtBuscar1;
    }
}