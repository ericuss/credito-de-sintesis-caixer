using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccDatos;
using System.Data;

namespace bCliente
{
    /// <summary>
    /// Funciones para comprobar, obtener y/o comprobar clientes
    /// </summary>
    public class clsBCliente
    {
        #region "Propiedades"
        /// <summary>
        /// Objeto que enlaza con el proyecto que obtiene los datos
        /// </summary>
        AccDatos.OLEDBCON oDatos = new AccDatos.OLEDBCON();
        #endregion
        #region "New"
        /// <summary>
        /// Contructor vacio
        /// </summary>
        public clsBCliente()
        {
        }
        #endregion
        #region "Get"
        /// <summary>
        /// Devuelve el id del cliente separado por #, a partir de una cuenta
        /// </summary>
        /// <param name="strEntidad">Entidad de la cuenta</param>
        /// <param name="strOficina">Oficina de la cuenta</param>
        /// <param name="strControl">Control de la cuenta</param>
        /// <param name="strCuenta">Cuenta</param>
        /// <returns>Id del cliente</returns>
        public String dameIdClienteByCuenta(String strEntidad, String strOficina, String strControl, String strCuenta)
        {
            try
            {
                String strSQL = " select cliente.id " +
                                " from cuenta " +
                                " join cuentaCliente on cuenta.id = cuentaCliente.idCuenta  " +
                                " join cliente on cliente.id = cuentaCliente.idCliente  " +
                                " where codigoEntidad = " + strEntidad + " and codigoOficina = " + strOficina +
                                "   and codigoControl = " + strControl + " and codigoCuenta = " + strCuenta + " ;";
                DataSet ds = oDatos.LanzarQueryT(strSQL);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    String strIdCliente = "";
                    foreach (DataRow drTemp in ds.Tables[0].Rows)
                    {
                        strIdCliente += drTemp["id"] + "#";
                    }

                    return strIdCliente;
                }
                return "";
            }
            catch (Exception)
            {
                return "";
            }
        }

        /// <summary>
        /// Devuelve el id del cliente, a partir del Dni
        /// </summary>
        /// <param name="strDni">Dni del cliente</param>
        /// <returns>Id del cliente</returns>
        public string dameIdClienteByDni(String strDni)
        {
            DataTable dtCliente;
            dtCliente = oDatos.LanzarConsultaT("Select id from cliente where dni = '" + strDni + "'");
            if (dtCliente.Rows.Count == 1)
            {
                return dtCliente.Rows[0]["id"].ToString();
            }
            return "";
        }
        #endregion
        #region "Comprobacion"
        /// <summary>
        /// Comprueba si existe un Dni en la BDD
        /// </summary>
        /// <param name="strDni">Dni a comprobar</param>
        /// <returns>Verdadero/Falso</returns>
        public Boolean existeIdClienteByDni(String strDni)
        {
            DataTable dtCliente;
            dtCliente = oDatos.LanzarConsultaT("Select id from cliente where dni = '" + strDni + "'");
            if (dtCliente.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Comprueba si existe un usuario
        /// </summary>
        /// <param name="strUsuario">Usuario a comprobar</param>
        /// <returns>Devuelsi si existe</returns>
        public Boolean existeUsuario(String strUsuario)
        {
            try
            {
                DataTable dtUsuario;
                OLEDBCON datos = new OLEDBCON();
                dtUsuario = datos.LanzarConsultaT(" select login from usuario " +
                                                  " where login = '" + strUsuario + "'");
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
        /// <summary>
        /// Comprueba si un Dni(un cliente) tiene usuario
        /// </summary>
        /// <param name="strDni">Dni a comprobar</param>
        /// <returns>Devuelve si existe</returns>
        public Boolean tieneUsuario(String strDni)
        {
            try
            {

                DataTable dtUsuario;
                OLEDBCON datos = new OLEDBCON();
                dtUsuario = datos.LanzarConsultaT(" select dni from cliente " +
                                                  " join usuario on cliente.id =usuario.idCliente " +
                                                  " where dni = '" + strDni + "'");
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
        #endregion
        #region "Insert"
        /// <summary>
        /// Inserta un usuario en la BDD
        /// </summary>
        /// <param name="strIdCliente">Id del cliente</param>
        /// <param name="strUsuario">Usuario que tendra</param>
        /// <param name="strPass">Password que tendra</param>
        /// <returns>Boolean de la operacion</returns>
        public Boolean insertUsuario(String strIdCliente, String strUsuario, String strPass)
        {
            try
            {
                String strSQL = " insert into usuario(login, password, idCliente,idioma, paginaPreferida, inactivo) " +
                " values('" + strUsuario + "','" + strPass + "', " + strIdCliente + ",'es', '//backend//cuenta//cuenta',0);";
                oDatos.Ejecutar(strSQL);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
                return false;
            }


        }
        #endregion
    }
}
