using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntityModel;

namespace uCuenta
{
    public partial class frmNuevaCuenta : Form
    {
        #region "Propiedades"
        /// <summary>
        /// Entity del formulario
        /// </summary>
        santanderEntities1 context = new santanderEntities1();
        #endregion
        #region "New"
        /// <summary>
        /// Constructor
        /// </summary>
        public frmNuevaCuenta()
        {
            InitializeComponent();
        }
        #endregion
        #region "Eventos"
        /// <summary>
        /// Sale del formulario
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// Genera la cuenta y la enlaza con el cliente
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        private void tnAceptar_Click(object sender, EventArgs e)
        {
            cuenta tmpCuenta = new cuenta
            {
                codigoEntidad = "2100",
                codigoOficina = "9999",
                codigoControl = genrandom(2, false),
                codigoCuenta = genrandom(8, true),
                saldo = 0
            };
            context.AddTocuenta(tmpCuenta);


            int pidCliente = Convert.ToInt16(dameIdClienteByDni(csBuscar.zzTxtId));
            cuentacliente tmpcc = new cuentacliente
            {
                idCliente = pidCliente,
                idCuenta = tmpCuenta.id
            };
            context.AddTocuentacliente(tmpcc);

            AccDatos.OLEDBCON conn = new AccDatos.OLEDBCON();
            conn.Ejecutar("insert into notificacion (text, asunto, idCliente) values ('Tienes una nueva Cuenta, numero de cuenta: "+tmpCuenta.codigoEntidad+" - "+tmpCuenta.codigoOficina+" - "+tmpCuenta.codigoControl+" - "+tmpCuenta.codigoCuenta+"','Nueva Cuenta', "+pidCliente+")");
            context.SaveChanges();
            this.Dispose();
        }
        #endregion
        #region "Metodos"
        /// <summary>
        /// Genera un numero aleatorio de la longitud que le pases comoprobando si quieres si valida el numero en la base de datos
        /// </summary>
        /// <param name="numDigitos">Numero de digitos que genera</param>
        /// <param name="check">Si tiene que validar en BDD</param>
        /// <returns>Devuelve un string con el numero aleatorio</returns>
        private String genrandom(int numDigitos, Boolean check)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            String ret = "";

            for (int i = 0; i < numDigitos; i++)
            {
                ret += r.Next(0, 9).ToString();
            }
            if (check)
            {
                if (Validate(ret))
                {

                    return ret;
                }
                else
                {
                    return genrandom(numDigitos, true);
                }
            }
            else
            {
                return ret;
            }
        }
        /// <summary>
        /// Valida si la cuenta existe
        /// </summary>
        /// <param name="ret">Cuenta a validar</param>
        /// <returns>Devuelve si existe</returns>
        private Boolean Validate(string ret)
        {
            var count = (from cuents in context.cuenta
                         where cuents.codigoCuenta == ret
                         select cuents).Count();
            if (count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Devuelve el id del cliente, a partir del Dni
        /// </summary>
        /// <param name="strDni">Dni a comprobar</param>
        /// <returns>Id del cliente</returns>
        private string dameIdClienteByDni(String strDni)
        {
            AccDatos.OLEDBCON oDatos = new AccDatos.OLEDBCON();
            DataTable dtCliente = oDatos.LanzarConsultaT("Select id from cliente where dni = '" + strDni + "'");
            if (dtCliente.Rows.Count == 1)
            {
                return dtCliente.Rows[0]["id"].ToString();
            }
            return null;
        }
        #endregion
    }
}
