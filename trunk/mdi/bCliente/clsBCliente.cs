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
    }
}
