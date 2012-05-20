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
                String strSQL = " insert into usuario(login, password, idCliente, paginaPreferida, inactivo) " +
                " values('" + strUsuario + "','" + strPass + "', " + strIdCliente + ", '/backend/cuenta/cuenta',0";
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
