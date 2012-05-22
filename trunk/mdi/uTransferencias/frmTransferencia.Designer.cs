namespace uTransferencia
{
    partial class frmTransferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransferencia));
            this.btnBuscarCuenta = new System.Windows.Forms.Button();
            this.gbCuentaOrigen = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCuenta = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtControl = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtOficina = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEntidad = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDescripcion = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReferencia = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtPorCuentaDe = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBeneficiario = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtConceptoAd = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtConcepto = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImporte = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbCuentaDestino = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCuentaDes = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtControlDes = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.txtOficinaDes = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEntidadDes = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnBuscarCuentaDes = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtError = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.gbCuentaOrigen.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.gbCuentaDestino.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscarCuenta
            // 
            this.btnBuscarCuenta.Location = new System.Drawing.Point(28, 19);
            this.btnBuscarCuenta.Name = "btnBuscarCuenta";
            this.btnBuscarCuenta.Size = new System.Drawing.Size(31, 23);
            this.btnBuscarCuenta.TabIndex = 0;
            this.btnBuscarCuenta.Text = "...";
            this.btnBuscarCuenta.UseVisualStyleBackColor = true;
            this.btnBuscarCuenta.Click += new System.EventHandler(this.btnBuscarCuenta_Click);
            // 
            // gbCuentaOrigen
            // 
            this.gbCuentaOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCuentaOrigen.Controls.Add(this.label18);
            this.gbCuentaOrigen.Controls.Add(this.txtCuenta);
            this.gbCuentaOrigen.Controls.Add(this.txtControl);
            this.gbCuentaOrigen.Controls.Add(this.txtOficina);
            this.gbCuentaOrigen.Controls.Add(this.label4);
            this.gbCuentaOrigen.Controls.Add(this.label3);
            this.gbCuentaOrigen.Controls.Add(this.label2);
            this.gbCuentaOrigen.Controls.Add(this.txtEntidad);
            this.gbCuentaOrigen.Controls.Add(this.label1);
            this.gbCuentaOrigen.Controls.Add(this.btnBuscarCuenta);
            this.gbCuentaOrigen.Location = new System.Drawing.Point(12, 1);
            this.gbCuentaOrigen.Name = "gbCuentaOrigen";
            this.gbCuentaOrigen.Size = new System.Drawing.Size(690, 52);
            this.gbCuentaOrigen.TabIndex = 3;
            this.gbCuentaOrigen.TabStop = false;
            this.gbCuentaOrigen.Text = "Selecciona una Cuenta de Origen";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(18, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "*";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Enabled = false;
            this.txtCuenta.Location = new System.Drawing.Point(465, 21);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(116, 20);
            this.txtCuenta.TabIndex = 20;
            this.txtCuenta.ValidValue = "";
            this.txtCuenta.zzCampoBd = "cuenta.codigoCuenta";
            this.txtCuenta.zzValidateIsNumeric = true;
            this.txtCuenta.zzValidateLength = true;
            this.txtCuenta.zzValidMaxLength = ((short)(8));
            // 
            // txtControl
            // 
            this.txtControl.Enabled = false;
            this.txtControl.Location = new System.Drawing.Point(369, 21);
            this.txtControl.Name = "txtControl";
            this.txtControl.Size = new System.Drawing.Size(40, 20);
            this.txtControl.TabIndex = 19;
            this.txtControl.ValidValue = "";
            this.txtControl.zzCampoBd = "cuenta.codigoControl";
            this.txtControl.zzValidateIsNumeric = true;
            this.txtControl.zzValidateLength = true;
            this.txtControl.zzValidMaxLength = ((short)(2));
            // 
            // txtOficina
            // 
            this.txtOficina.Enabled = false;
            this.txtOficina.Location = new System.Drawing.Point(243, 21);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.Size = new System.Drawing.Size(71, 20);
            this.txtOficina.TabIndex = 18;
            this.txtOficina.ValidValue = "";
            this.txtOficina.zzCampoBd = "cuenta.codigoOficina";
            this.txtOficina.zzValidateIsNumeric = true;
            this.txtOficina.zzValidateLength = true;
            this.txtOficina.zzValidMaxLength = ((short)(4));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cuenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Control:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Oficina:";
            // 
            // txtEntidad
            // 
            this.txtEntidad.Enabled = false;
            this.txtEntidad.Location = new System.Drawing.Point(117, 21);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(71, 20);
            this.txtEntidad.TabIndex = 13;
            this.txtEntidad.ValidValue = "";
            this.txtEntidad.zzCampoBd = "cuenta.codigoEntidad";
            this.txtEntidad.zzValidateIsNumeric = true;
            this.txtEntidad.zzValidateLength = true;
            this.txtEntidad.zzValidMaxLength = ((short)(4));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Entidad:";
            // 
            // gbDatos
            // 
            this.gbDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDatos.Controls.Add(this.label12);
            this.gbDatos.Controls.Add(this.txtDescripcion);
            this.gbDatos.Controls.Add(this.label11);
            this.gbDatos.Controls.Add(this.txtReferencia);
            this.gbDatos.Controls.Add(this.txtPorCuentaDe);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.label9);
            this.gbDatos.Controls.Add(this.txtBeneficiario);
            this.gbDatos.Controls.Add(this.label10);
            this.gbDatos.Controls.Add(this.txtConceptoAd);
            this.gbDatos.Controls.Add(this.txtConcepto);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.txtImporte);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Enabled = false;
            this.gbDatos.Location = new System.Drawing.Point(12, 59);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(690, 109);
            this.gbDatos.TabIndex = 21;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Rellena los Datos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(22, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "*";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(80, 73);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(223, 20);
            this.txtDescripcion.TabIndex = 27;
            this.txtDescripcion.ValidValue = "";
            this.txtDescripcion.zzCampoBd = "cuenta.codigoEntidad";
            this.txtDescripcion.zzValidateIsNumeric = false;
            this.txtDescripcion.zzValidateLength = false;
            this.txtDescripcion.zzValidMaxLength = ((short)(0));
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Descripción:";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(544, 47);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(134, 20);
            this.txtReferencia.TabIndex = 26;
            this.txtReferencia.ValidValue = "";
            this.txtReferencia.zzCampoBd = "cuenta.codigoCuenta";
            this.txtReferencia.zzValidateIsNumeric = false;
            this.txtReferencia.zzValidateLength = false;
            this.txtReferencia.zzValidMaxLength = ((short)(0));
            // 
            // txtPorCuentaDe
            // 
            this.txtPorCuentaDe.Location = new System.Drawing.Point(306, 47);
            this.txtPorCuentaDe.Name = "txtPorCuentaDe";
            this.txtPorCuentaDe.Size = new System.Drawing.Size(134, 20);
            this.txtPorCuentaDe.TabIndex = 25;
            this.txtPorCuentaDe.ValidValue = "";
            this.txtPorCuentaDe.zzCampoBd = "cuenta.codigoControl";
            this.txtPorCuentaDe.zzValidateIsNumeric = false;
            this.txtPorCuentaDe.zzValidateLength = false;
            this.txtPorCuentaDe.zzValidMaxLength = ((short)(0));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Referencia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Por Cuenta De:";
            // 
            // txtBeneficiario
            // 
            this.txtBeneficiario.Location = new System.Drawing.Point(80, 47);
            this.txtBeneficiario.Name = "txtBeneficiario";
            this.txtBeneficiario.Size = new System.Drawing.Size(134, 20);
            this.txtBeneficiario.TabIndex = 21;
            this.txtBeneficiario.ValidValue = "";
            this.txtBeneficiario.zzCampoBd = "cuenta.codigoEntidad";
            this.txtBeneficiario.zzValidateIsNumeric = false;
            this.txtBeneficiario.zzValidateLength = false;
            this.txtBeneficiario.zzValidMaxLength = ((short)(0));
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Beneficiario:";
            // 
            // txtConceptoAd
            // 
            this.txtConceptoAd.Location = new System.Drawing.Point(544, 21);
            this.txtConceptoAd.Name = "txtConceptoAd";
            this.txtConceptoAd.Size = new System.Drawing.Size(134, 20);
            this.txtConceptoAd.TabIndex = 20;
            this.txtConceptoAd.ValidValue = "";
            this.txtConceptoAd.zzCampoBd = "cuenta.codigoCuenta";
            this.txtConceptoAd.zzValidateIsNumeric = false;
            this.txtConceptoAd.zzValidateLength = false;
            this.txtConceptoAd.zzValidMaxLength = ((short)(0));
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(306, 21);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(134, 20);
            this.txtConcepto.TabIndex = 19;
            this.txtConcepto.ValidValue = "";
            this.txtConcepto.zzCampoBd = "cuenta.codigoControl";
            this.txtConcepto.zzValidateIsNumeric = false;
            this.txtConcepto.zzValidateLength = false;
            this.txtConcepto.zzValidMaxLength = ((short)(0));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Concepto Ad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Concepto:";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(80, 21);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(134, 20);
            this.txtImporte.TabIndex = 13;
            this.txtImporte.ValidValue = "";
            this.txtImporte.zzCampoBd = "cuenta.codigoEntidad";
            this.txtImporte.zzValidateIsNumeric = true;
            this.txtImporte.zzValidateLength = false;
            this.txtImporte.zzValidMaxLength = ((short)(0));
            this.txtImporte.Leave += new System.EventHandler(this.txtImporte_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Importe:";
            // 
            // gbCuentaDestino
            // 
            this.gbCuentaDestino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCuentaDestino.Controls.Add(this.label17);
            this.gbCuentaDestino.Controls.Add(this.txtCuentaDes);
            this.gbCuentaDestino.Controls.Add(this.txtControlDes);
            this.gbCuentaDestino.Controls.Add(this.txtOficinaDes);
            this.gbCuentaDestino.Controls.Add(this.label13);
            this.gbCuentaDestino.Controls.Add(this.label14);
            this.gbCuentaDestino.Controls.Add(this.label15);
            this.gbCuentaDestino.Controls.Add(this.txtEntidadDes);
            this.gbCuentaDestino.Controls.Add(this.label16);
            this.gbCuentaDestino.Controls.Add(this.btnBuscarCuentaDes);
            this.gbCuentaDestino.Enabled = false;
            this.gbCuentaDestino.Location = new System.Drawing.Point(12, 174);
            this.gbCuentaDestino.Name = "gbCuentaDestino";
            this.gbCuentaDestino.Size = new System.Drawing.Size(690, 52);
            this.gbCuentaDestino.TabIndex = 21;
            this.gbCuentaDestino.TabStop = false;
            this.gbCuentaDestino.Text = "Selecciona una cuenta de destino o introducela manualmente";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(18, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "*";
            // 
            // txtCuentaDes
            // 
            this.txtCuentaDes.Location = new System.Drawing.Point(465, 21);
            this.txtCuentaDes.Name = "txtCuentaDes";
            this.txtCuentaDes.Size = new System.Drawing.Size(116, 20);
            this.txtCuentaDes.TabIndex = 20;
            this.txtCuentaDes.ValidValue = "";
            this.txtCuentaDes.zzCampoBd = "cuenta.codigoCuenta";
            this.txtCuentaDes.zzValidateIsNumeric = true;
            this.txtCuentaDes.zzValidateLength = true;
            this.txtCuentaDes.zzValidMaxLength = ((short)(8));
            // 
            // txtControlDes
            // 
            this.txtControlDes.Location = new System.Drawing.Point(369, 21);
            this.txtControlDes.Name = "txtControlDes";
            this.txtControlDes.Size = new System.Drawing.Size(40, 20);
            this.txtControlDes.TabIndex = 19;
            this.txtControlDes.ValidValue = "";
            this.txtControlDes.zzCampoBd = "cuenta.codigoControl";
            this.txtControlDes.zzValidateIsNumeric = true;
            this.txtControlDes.zzValidateLength = true;
            this.txtControlDes.zzValidMaxLength = ((short)(2));
            // 
            // txtOficinaDes
            // 
            this.txtOficinaDes.Location = new System.Drawing.Point(243, 21);
            this.txtOficinaDes.Name = "txtOficinaDes";
            this.txtOficinaDes.Size = new System.Drawing.Size(71, 20);
            this.txtOficinaDes.TabIndex = 18;
            this.txtOficinaDes.ValidValue = "";
            this.txtOficinaDes.zzCampoBd = "cuenta.codigoOficina";
            this.txtOficinaDes.zzValidateIsNumeric = true;
            this.txtOficinaDes.zzValidateLength = true;
            this.txtOficinaDes.zzValidMaxLength = ((short)(4));
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(415, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Cuenta:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(320, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Control:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(194, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Oficina:";
            // 
            // txtEntidadDes
            // 
            this.txtEntidadDes.Location = new System.Drawing.Point(117, 21);
            this.txtEntidadDes.Name = "txtEntidadDes";
            this.txtEntidadDes.Size = new System.Drawing.Size(71, 20);
            this.txtEntidadDes.TabIndex = 13;
            this.txtEntidadDes.ValidValue = "";
            this.txtEntidadDes.zzCampoBd = "cuenta.codigoEntidad";
            this.txtEntidadDes.zzValidateIsNumeric = true;
            this.txtEntidadDes.zzValidateLength = true;
            this.txtEntidadDes.zzValidMaxLength = ((short)(4));
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(65, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Entidad:";
            // 
            // btnBuscarCuentaDes
            // 
            this.btnBuscarCuentaDes.Location = new System.Drawing.Point(28, 19);
            this.btnBuscarCuentaDes.Name = "btnBuscarCuentaDes";
            this.btnBuscarCuentaDes.Size = new System.Drawing.Size(31, 23);
            this.btnBuscarCuentaDes.TabIndex = 0;
            this.btnBuscarCuentaDes.Text = "...";
            this.btnBuscarCuentaDes.UseVisualStyleBackColor = true;
            this.btnBuscarCuentaDes.Click += new System.EventHandler(this.btnBuscarCuentaDes_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(390, 246);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(81, 23);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(581, 246);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(12, 232);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(299, 20);
            this.txtError.TabIndex = 23;
            this.txtError.ValidValue = "";
            this.txtError.Visible = false;
            this.txtError.zzCampoBd = null;
            this.txtError.zzValidateIsNumeric = false;
            this.txtError.zzValidateLength = false;
            this.txtError.zzValidMaxLength = ((short)(0));
            // 
            // frmTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 281);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbCuentaDestino);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.gbCuentaOrigen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTransferencia";
            this.Text = "Hacer Transferencias";
            this.gbCuentaOrigen.ResumeLayout(false);
            this.gbCuentaOrigen.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbCuentaDestino.ResumeLayout(false);
            this.gbCuentaDestino.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarCuenta;
        private System.Windows.Forms.GroupBox gbCuentaOrigen;
        private CustomValidatorTextBox.CustomValidatorTextBox txtCuenta;
        private CustomValidatorTextBox.CustomValidatorTextBox txtControl;
        private CustomValidatorTextBox.CustomValidatorTextBox txtOficina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomValidatorTextBox.CustomValidatorTextBox txtEntidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label label12;
        private CustomValidatorTextBox.CustomValidatorTextBox txtDescripcion;
        private System.Windows.Forms.Label label11;
        private CustomValidatorTextBox.CustomValidatorTextBox txtReferencia;
        private CustomValidatorTextBox.CustomValidatorTextBox txtPorCuentaDe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private CustomValidatorTextBox.CustomValidatorTextBox txtBeneficiario;
        private System.Windows.Forms.Label label10;
        private CustomValidatorTextBox.CustomValidatorTextBox txtConceptoAd;
        private CustomValidatorTextBox.CustomValidatorTextBox txtConcepto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private CustomValidatorTextBox.CustomValidatorTextBox txtImporte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbCuentaDestino;
        private CustomValidatorTextBox.CustomValidatorTextBox txtCuentaDes;
        private CustomValidatorTextBox.CustomValidatorTextBox txtControlDes;
        private CustomValidatorTextBox.CustomValidatorTextBox txtOficinaDes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private CustomValidatorTextBox.CustomValidatorTextBox txtEntidadDes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnBuscarCuentaDes;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private CustomValidatorTextBox.CustomValidatorTextBox txtError;
    }
}