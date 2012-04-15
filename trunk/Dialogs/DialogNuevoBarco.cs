using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestClasses.Class;
namespace TestClasses.Dialogs
{
    public partial class DialogNuevoBarco : Form
    {

        private Barco _barco;

        public DialogNuevoBarco()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this._barco.Matricula = null;
            this.Dispose();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this._barco.Matricula = txtMatricula.Text;
            this._barco.Manga = Convert.ToDouble(txtmanga.Text);
            this._barco.Eslora = Convert.ToDouble(txtEslora.Text);
            this._barco.Calado = Convert.ToDouble(txtcalado.Text);
            this.Dispose();
        }

        public Barco Barco
        {
            get { return _barco; }
            set { _barco = value; }
        }
    }
}
