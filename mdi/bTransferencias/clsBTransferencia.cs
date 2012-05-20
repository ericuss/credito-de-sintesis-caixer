using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace bTransferencias
{
    class clsBTransferencia
    {
        AccDatos.OLEDBCON oDatos = new AccDatos.OLEDBCON();
        public Boolean insertTransferencia()
        {
            try
            {

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean hayDinero(String strEntidad, String strOficina, String strControl, String strCuenta, String strImporte)
        {
            try
            {
               DataSet ds = oDatos.LanzarQueryT("Select * from cuenta where cuenta.codigoEntidad = " + strEntidad + "cuenta.codigoOficina = " + strOficina + "cuenta.codigoControl = " + strControl + "cuenta.codigoCuenta = " + strCuenta + " ");
                if (ds.Tables[0].Rows.Count == 1 )
                {
                    if ( (Convert.ToInt64( ds.Tables[0].Rows[0]["saldo"]) - Convert.ToInt64(strImporte)) > 0 )
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
