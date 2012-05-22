using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccDatos;
using System.Data;

namespace bCliente
{
    public class clsBCliente
    {
        public clsBCliente()
        {

        }
        AccDatos.OLEDBCON oDatos = new AccDatos.OLEDBCON();

        public String dameIdClienteByCuenta(String strEntidad, String strOficina, String strControl, String strCuenta)
        {
            try
            {
                String strSQL = " select idCliente " +
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

        public string dameIdClienteByDni(String strDni)
        {
            DataTable dtCliente;
            dtCliente = oDatos.LanzarConsultaT("Select id from cliente where dni = '" + strDni + "'");
            if (dtCliente.Rows.Count == 1)
            {
               return dtCliente.Rows[0]["id"].ToString();
            }
            return null;
        }
        public Boolean insertUsuario(String strIdCliente, String strUsuario, String strPass)
        {
            try
            {
                String strSQL = " insert into usuario(login, password, idCliente,idioma, paginaPreferida, inactivo) " +
                " values('" + strUsuario + "','" + strPass + "', " + strIdCliente + ",'es', '/backend/cuenta/cuenta',0);";
                oDatos.Ejecutar(strSQL);
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }
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
    }
}
