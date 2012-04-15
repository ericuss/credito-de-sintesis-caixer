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
    public partial class DialogoNuevoAvion : Form
    {
        private Avion _avion;
        public DialogoNuevoAvion()
        {
            InitializeComponent();
        }

        

        public Avion Avion
        {
            get { return _avion; }
            set { _avion = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._avion.Matricula = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this._avion.Matricula = txtMatricula.Text;
            this._avion.Compania = txtCompania.Text;
            this._avion.Motores = Convert.ToInt32(numMotores.Value);
            this._avion.Velocidad = Convert.ToDouble(txtVel.Text);
            this.Dispose();


        }
        
    }
}
