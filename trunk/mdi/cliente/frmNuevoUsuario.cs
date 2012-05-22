using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccDatos;
using System.Security.Cryptography;
namespace cliente
{
    /// <summary>
    /// Formulario para Crear Nuevos Usuarios
    /// </summary>
    public partial class frmNuevoUsuario : Form
    {
        #region "Constructores"

        /// <summary>
        /// Constructor del Formulario
        /// </summary>
        public frmNuevoUsuario()
        {
            InitializeComponent();
        }


        //public frmNuevoUsuario(String dni)
        //{
        //    InitializeComponent();
        //    txtBuscar1.zzTxtId = dni;
        //    txtBuscar1.evLostFocus();
        //}
        #endregion

        #region "Eventos"


        /// <summary>
        /// Evento que cierra el formulario
        /// </summary>
        /// <param name="sender">Parametro del Evento</param>
        /// <param name="e">Parametro del Evento</param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Evento que llama a la comprobacion de los datos, y en caso de que estancorrectos se guardan en la BBDD
        /// </summary>
        /// <param name="sender">Parametro del Evento</param>
        /// <param name="e">Parametro del Evento</param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                bCliente.clsBCliente bCliente = new bCliente.clsBCliente();
                if (txtBuscar1.zzTxtId != "" && !bCliente.tieneUsuario(txtBuscar1.zzTxtId))
                {
                    if (!bCliente.existeUsuario(txtUser.Text))
                    {
                        String strIdCliente = bCliente.dameIdClienteByDni(txtBuscar1.zzTxtId);
                        if (strIdCliente.Trim() != "")
                        {
                            if (bCliente.insertUsuario(strIdCliente, txtUser.Text, tools.clsTools.getMD5("12345")))
                            {
                                txtError.setOK(" Se ha generado correctamente, recuerda que la contraseña es 12345");
                            }
                            else
                            {
                                txtError.setError(" No se ha guardado correctamente");
                            }
                        }
                        else
                        {
                            txtError.setError(" No se ha encontrado el cliente ");
                        }
                    }
                    else
                    {
                        txtError.setError(" Ya existe un usuario con ese usuario");
                    }
                }
                else
                {
                    txtError.setError(" La cuenta ya tiene un usuario");
                }
            }
            catch (Exception eex)
            {
                txtError.setError(eex.ToString());

            }
        }

        /// <summary>
        /// Genera y muestra el usuario a partir de los datos introducidos
        /// </summary>
        /// <param name="sender">Parametros del evento</param>
        /// <param name="e">Parametros del evento</param>
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar1.zzTxtId.Trim() != "")
                {
                    txtUser.Text = txtBuscar1.zzTxtDesc.Split(Convert.ToChar(" "))[0].Substring(0, 2) + txtBuscar1.zzTxtDesc.Split(Convert.ToChar(" "))[1].Substring(0, 2) + genrandom(2);
                }
            }
            catch (Exception)
            {
                txtError.setError("No se puede generar el usuario");
            }
        }

        #endregion

        #region "Metodos"

        /// <summary>
        /// Metodo que genera un numero aleatorio de N Longitud
        /// </summary>
        /// <param name="numDigitos">Longitud del numero aleatorio a generar</param>
        /// <returns>Cadena con el numero aleatorio</returns>
        private String genrandom(int numDigitos)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            String ret = "";

            for (int i = 0; i < numDigitos; i++)
            {
                ret += r.Next(0, 9).ToString();
            }

            return ret;

        }

        #endregion
    }
}
