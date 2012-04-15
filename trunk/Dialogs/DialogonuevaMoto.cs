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
    public partial class DialogonuevaMoto : Form
    {
        public DialogonuevaMoto()
        {
            InitializeComponent();
        }
        private Moto _moto;

        public Moto Moto
        {
            get { return _moto; }
            set { _moto = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this._moto.CC = Convert.ToInt32(txtCC.Text);
            this._moto.Matricula = txtMatriucla.Text;
            this._moto.Ruedas = Convert.ToInt32(txtRuedas.Text);
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._moto.Matricula = null;
            this.Dispose();
        }
        
    }
}
