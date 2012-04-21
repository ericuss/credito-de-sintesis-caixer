using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace uMdi
{
    public partial class frmLoggin : Form
    {
        /// <summary>
        /// Constructor del Login
        /// </summary>
        public frmLoggin()
        {
            InitializeComponent();
        }

        private void frmLoggin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cbTipo.SelectedIndex != -1)
            {
                if (txtUsuario.Text.Trim() != "" && txtPass.Text.Trim() != "")
                {
                    
                }// error de usuario y/o contraseña mal




            }//error de que no has seleccionado la combo
        }
    }
}
