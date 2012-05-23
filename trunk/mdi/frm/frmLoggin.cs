using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using uMdi;
using System.IO;

namespace uMdi
{
    /// <summary>
    /// Formulario de autenticacion
    /// </summary>
    public partial class frmLoggin : Form
    {
        #region "New"

        /// <summary>
        /// Constructor del Login
        /// </summary>
        public frmLoggin()
        {
            InitializeComponent();
        }

        #endregion

        #region "Eventos"

        /// <summary>
        /// Cierra la aplicacion
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Llama a la funcion submit
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            submit();
        }

        /// <summary>
        /// Comprueba si existe el usuario y si la contraseña es correcta
        /// </summary>
        /// <summary>
        /// Carga la posiblidad del enter para aceptar
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        private void frmLoggin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(frmLoggin_KeyPress);
        }

        /// <summary>
        /// Mira si la tecla pulsada es un retorno de carro
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        void frmLoggin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                submit();
            }
        }
        #endregion

        #region "Metodos"

        /// <summary>
        /// Funcion que se encarga de comprobar con la BBDD que el usuario y contraseña sean correctos. 
        /// En caso afirmativo cierra este formulario y abre el mdiPrincipal. De lo contrario marca el error.
        /// </summary>
        private void submit()
        {
            if (txtUsuario.Text.Trim() != "" && txtPass.Text.Trim() != "")
            {
                AccDatos.OLEDBCON conn = new AccDatos.OLEDBCON();
                DataSet loginDS = conn.LanzarConsulta("Select * from trabajador where login= '" + txtUsuario.ValidValue + "'");
                if (loginDS.Tables[0].Rows.Count != 0)
                {
                    if (tools.clsTools.getMD5(txtPass.ValidValue) == (loginDS.Tables[0].Rows[0]["password"].ToString()))
                    {
                        crearTXT();
                        this.Dispose();
                    }
                    else
                    {
                        txtPass.setErrorColor("Pass Erroneo");
                    }
                }
                else
                {
                    txtUsuario.setErrorColor("Usuario Erroneo");
                }
            }
        }

        /// <summary>
        /// Genera un fichero de control
        /// </summary>
        private void crearTXT()
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory + "user.ogt");
                //Write a line of text
                sw.WriteLine(txtUsuario.Text);
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                this.Close();
            }
        }

        #endregion
    }
}
