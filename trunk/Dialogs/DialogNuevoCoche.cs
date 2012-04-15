using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestClasses.Class;

namespace TestClasses
{
    public partial class DialogNuevoCoche : Form
    {
        private Coche _coche;
        public DialogNuevoCoche()
        {
            InitializeComponent();

        }
      

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this._coche.Matricula = null;
            this.Dispose();
        }

   

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           _coche.CV= Convert.ToInt32(txtCV.Text);
           _coche.Marca = txtMarca.Text;
           _coche.Matricula = txtMatricula.Text;
           _coche.Modelo = txtModelo.Text;
            this.Dispose();
        }


     

        public Coche Coche
        {
            get { return _coche; }
            set { _coche = value; }
        }
        
    }
}
