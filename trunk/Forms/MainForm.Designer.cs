namespace TestClasses
{
    partial class MainForm
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
            this.btnAddCoche = new System.Windows.Forms.Button();
            this.lbVehiculos = new System.Windows.Forms.ListBox();
            this.btnMoto = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnAddAvion = new System.Windows.Forms.Button();
            this.btnAddBarco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCoche
            // 
            this.btnAddCoche.Location = new System.Drawing.Point(25, 29);
            this.btnAddCoche.Name = "btnAddCoche";
            this.btnAddCoche.Size = new System.Drawing.Size(75, 23);
            this.btnAddCoche.TabIndex = 0;
            this.btnAddCoche.Text = "Add Coche";
            this.btnAddCoche.UseVisualStyleBackColor = true;
            this.btnAddCoche.Click += new System.EventHandler(this.btnAddCoche_Click);
            // 
            // lbVehiculos
            // 
            this.lbVehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVehiculos.FormattingEnabled = true;
            this.lbVehiculos.Location = new System.Drawing.Point(166, 12);
            this.lbVehiculos.Name = "lbVehiculos";
            this.lbVehiculos.Size = new System.Drawing.Size(204, 303);
            this.lbVehiculos.TabIndex = 1;
            // 
            // btnMoto
            // 
            this.btnMoto.Location = new System.Drawing.Point(25, 67);
            this.btnMoto.Name = "btnMoto";
            this.btnMoto.Size = new System.Drawing.Size(75, 23);
            this.btnMoto.TabIndex = 2;
            this.btnMoto.Text = "Add Moto";
            this.btnMoto.UseVisualStyleBackColor = true;
            this.btnMoto.Click += new System.EventHandler(this.btnMoto_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(25, 292);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(25, 263);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnAddAvion
            // 
            this.btnAddAvion.Location = new System.Drawing.Point(25, 107);
            this.btnAddAvion.Name = "btnAddAvion";
            this.btnAddAvion.Size = new System.Drawing.Size(75, 23);
            this.btnAddAvion.TabIndex = 5;
            this.btnAddAvion.Text = "Add Avion";
            this.btnAddAvion.UseVisualStyleBackColor = true;
            this.btnAddAvion.Click += new System.EventHandler(this.btnAddAvion_Click);
            // 
            // btnAddBarco
            // 
            this.btnAddBarco.Location = new System.Drawing.Point(25, 151);
            this.btnAddBarco.Name = "btnAddBarco";
            this.btnAddBarco.Size = new System.Drawing.Size(75, 23);
            this.btnAddBarco.TabIndex = 6;
            this.btnAddBarco.Text = "Add Barco";
            this.btnAddBarco.UseVisualStyleBackColor = true;
            this.btnAddBarco.Click += new System.EventHandler(this.btnAddBarco_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 327);
            this.Controls.Add(this.btnAddBarco);
            this.Controls.Add(this.btnAddAvion);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnMoto);
            this.Controls.Add(this.lbVehiculos);
            this.Controls.Add(this.btnAddCoche);
            this.Name = "MainForm";
            this.Text = "Test Classes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCoche;
        private System.Windows.Forms.ListBox lbVehiculos;
        private System.Windows.Forms.Button btnMoto;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnAddAvion;
        private System.Windows.Forms.Button btnAddBarco;
    }
}

