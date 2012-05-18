﻿using System;
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
            if (txtBuscar1.zzTxtId != "" && !tieneUsuario())
            {
                if (!existeUsuario())
                {
                    bCliente.clsBCliente bCliente = new bCliente.clsBCliente();
                    String strIdCliente = bCliente.dameIdClienteByDni(txtBuscar1.zzCampoId);
                    insertUsuario(strIdCliente);
                }
            }
        }
        private Boolean insertUsuario(String strIdCliente)
        {
            try
            {
                String strSQL = " insert into usuario(login, password, idCliente, paginaPreferida, inactivo) " +
                " values('" + txtUser.Text + "','" + txtPass.Text + "', " + "" + ", '/backend/cuenta/cuenta',0";
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }
        private Boolean existeUsuario()
        {
            try
            {
                DataTable dtUsuario;
                OLEDBCON datos = new OLEDBCON();
                dtUsuario = datos.LanzarConsultaT(" select login from usuario " +
                                                  " where login = '" + txtUser.Text + "'");
                if (dtUsuario.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        private Boolean tieneUsuario()
        {
            try
            {

                DataTable dtUsuario;
                OLEDBCON datos = new OLEDBCON();
                dtUsuario = datos.LanzarConsultaT(" select dni from cliente " +
                                                  " join usuario on cliente.id =usuario.idCliente " +
                                                  " where dni = '" + txtBuscar1.zzTxtId + "'");
                if (dtUsuario.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}