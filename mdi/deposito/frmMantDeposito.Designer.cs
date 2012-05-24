namespace deposito
{
    partial class frmMantDeposito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantDeposito));
            this.customTextBox1 = new CusomTextBox.CustomTextBox();
            this.customTextBox2 = new CusomTextBox.CustomTextBox();
            this.customTextBox3 = new CusomTextBox.CustomTextBox();
            this.customTextBox4 = new CusomTextBox.CustomTextBox();
            this.customTextBox5 = new CusomTextBox.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtError = new CustomValidatorTextBox.CustomValidatorTextBox();
            this.SuspendLayout();
            // 
            // txtSalir
            // 
            this.txtSalir.Location = new System.Drawing.Point(423, 67);
            this.txtSalir.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(527, 67);
            this.btnUpdate.Text = "Guardar";
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(30, 67);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(254, 67);
            this.btnLimpiar.Visible = false;
            // 
            // gbResultado
            // 
            this.gbResultado.Location = new System.Drawing.Point(12, 96);
            this.gbResultado.Size = new System.Drawing.Size(650, 333);
            // 
            // gbFiltro
            // 
            this.gbFiltro.Location = new System.Drawing.Point(500, 6);
            this.gbFiltro.Size = new System.Drawing.Size(48, 46);
            this.gbFiltro.Visible = false;
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(632, 6);
            // 
            // btnLimpiarControles
            // 
            this.btnLimpiarControles.Location = new System.Drawing.Point(134, 67);
            this.btnLimpiarControles.Size = new System.Drawing.Size(103, 23);
            // 
            // customTextBox1
            // 
            this.customTextBox1.CAMPDB = "id";
            this.customTextBox1.Dll = null;
            this.customTextBox1.Form = null;
            this.customTextBox1.isID = "True";
            this.customTextBox1.Location = new System.Drawing.Point(445, 6);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.NomTaula = null;
            this.customTextBox1.Size = new System.Drawing.Size(36, 20);
            this.customTextBox1.TabIndex = 16;
            this.customTextBox1.Tag = "CustomTXT";
            this.customTextBox1.TipoDato = CusomTextBox.CustomTextBox.eTipoDato.Numerico;
            this.customTextBox1.Visible = false;
            // 
            // customTextBox2
            // 
            this.customTextBox2.CAMPDB = "plazo";
            this.customTextBox2.Dll = null;
            this.customTextBox2.Form = null;
            this.customTextBox2.isID = "False";
            this.customTextBox2.Location = new System.Drawing.Point(99, 6);
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.NomTaula = null;
            this.customTextBox2.Size = new System.Drawing.Size(100, 20);
            this.customTextBox2.TabIndex = 17;
            this.customTextBox2.Tag = "CustomTXT";
            this.customTextBox2.TipoDato = CusomTextBox.CustomTextBox.eTipoDato.Numerico;
            // 
            // customTextBox3
            // 
            this.customTextBox3.CAMPDB = "importeMinimo";
            this.customTextBox3.Dll = null;
            this.customTextBox3.Form = null;
            this.customTextBox3.isID = "False";
            this.customTextBox3.Location = new System.Drawing.Point(99, 32);
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.NomTaula = null;
            this.customTextBox3.Size = new System.Drawing.Size(100, 20);
            this.customTextBox3.TabIndex = 18;
            this.customTextBox3.Tag = "CustomTXT";
            this.customTextBox3.TipoDato = CusomTextBox.CustomTextBox.eTipoDato.Numerico;
            // 
            // customTextBox4
            // 
            this.customTextBox4.CAMPDB = "tae";
            this.customTextBox4.Dll = null;
            this.customTextBox4.Form = null;
            this.customTextBox4.isID = "False";
            this.customTextBox4.Location = new System.Drawing.Point(318, 6);
            this.customTextBox4.Name = "customTextBox4";
            this.customTextBox4.NomTaula = null;
            this.customTextBox4.Size = new System.Drawing.Size(100, 20);
            this.customTextBox4.TabIndex = 19;
            this.customTextBox4.Tag = "CustomTXT";
            this.customTextBox4.TipoDato = CusomTextBox.CustomTextBox.eTipoDato.Numerico;
            // 
            // customTextBox5
            // 
            this.customTextBox5.CAMPDB = "multaCancelacion";
            this.customTextBox5.Dll = null;
            this.customTextBox5.Form = null;
            this.customTextBox5.isID = "False";
            this.customTextBox5.Location = new System.Drawing.Point(318, 32);
            this.customTextBox5.Name = "customTextBox5";
            this.customTextBox5.NomTaula = null;
            this.customTextBox5.Size = new System.Drawing.Size(100, 20);
            this.customTextBox5.TabIndex = 20;
            this.customTextBox5.Tag = "CustomTXT";
            this.customTextBox5.TipoDato = CusomTextBox.CustomTextBox.eTipoDato.Numerico;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Plazos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Importe Minimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "TAE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Multa Cancelacion";
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(12, 435);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(650, 20);
            this.txtError.TabIndex = 25;
            this.txtError.ValidValue = "";
            this.txtError.Visible = false;
            this.txtError.zzCampoBd = null;
            this.txtError.zzValidateIsNumeric = false;
            this.txtError.zzValidateLength = false;
            this.txtError.zzValidMaxLength = ((short)(0));
            // 
            // frmMantDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 467);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customTextBox5);
            this.Controls.Add(this.customTextBox4);
            this.Controls.Add(this.customTextBox3);
            this.Controls.Add(this.customTextBox2);
            this.Controls.Add(this.customTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmMantDeposito";
            this.Text = "Mantenimiento de  Deposito";
            this.Controls.SetChildIndex(this.btnLimpiarControles, 0);
            this.Controls.SetChildIndex(this.btnTodos, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.gbResultado, 0);
            this.Controls.SetChildIndex(this.txtSalir, 0);
            this.Controls.SetChildIndex(this.gbFiltro, 0);
            this.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.Controls.SetChildIndex(this.btnPdf, 0);
            this.Controls.SetChildIndex(this.customTextBox1, 0);
            this.Controls.SetChildIndex(this.customTextBox2, 0);
            this.Controls.SetChildIndex(this.customTextBox3, 0);
            this.Controls.SetChildIndex(this.customTextBox4, 0);
            this.Controls.SetChildIndex(this.customTextBox5, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtError, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CusomTextBox.CustomTextBox customTextBox1;
        private CusomTextBox.CustomTextBox customTextBox2;
        private CusomTextBox.CustomTextBox customTextBox3;
        private CusomTextBox.CustomTextBox customTextBox4;
        private CusomTextBox.CustomTextBox customTextBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomValidatorTextBox.CustomValidatorTextBox txtError;
    }
}