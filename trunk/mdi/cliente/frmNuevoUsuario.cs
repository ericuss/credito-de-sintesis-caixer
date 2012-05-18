using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccDatos;
namespace cliente
{
    public partial class frmNuevoUsuario : Form
    {
        public frmNuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                bCliente.clsBCliente bCliente = new bCliente.clsBCliente();
                if (txtBuscar1.zzTxtId != "" && !bCliente.tieneUsuario(txtBuscar1.zzTxtId))
                {
                    if (!bCliente.existeUsuario(txtUser.Text))
                    {
                        String strIdCliente = bCliente.dameIdClienteByDni(txtBuscar1.zzCampoId);
                        bCliente.insertUsuario(strIdCliente, txtUser.Text, txtPass.Text);
                    }
                }
            }
            catch (Exception)
            {


            }
        }




    }
}
