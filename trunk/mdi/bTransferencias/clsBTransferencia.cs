using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace bTransferencia
{
    public class clsBTransferencia
    {
        AccDatos.OLEDBCON oDatos = new AccDatos.OLEDBCON();
        public clsBTransferencia()
        {

        }
        public Boolean insertTransferenciaOrigen(String strEntidad, String strOficina, String strControl, String strCuenta,
                                                String strImporte, String strPorCuentaDe, String strConcepto, String strReferencia,
                                                String strConceptoAd, String strBeneficiario, String strDescripcion, String strEntidadDes,
                                                String strOficinaDes, String strControlDes, String strCuentaDes)
        {
            try
            {
                double dblImporte = Convert.ToDouble(strImporte);
                if (dblImporte > 0)
                {
                    dblImporte = dblImporte * -1;
                }
                String strIdCuenta = getIdCuentaByCampos(strEntidad, strOficina, strControl, strCuenta);
                if (strIdCuenta != "")
                {
                    String strSQL = " insert into movimiento(idCuenta, importe, descripcion, concepto) " +
                                " values( " + strIdCuenta + ", " + dblImporte + ", 'Transferencia " + strDescripcion + "', '" + strConcepto + "'); ";
                    oDatos.Ejecutar(strSQL);
                    String strIdMovimiento = getLastIdMovimientos();
                    if (strIdMovimiento != "")
                    {
                     strSQL = " insert into transferencia(idMovimiento, idCuentaOrigen, cuentaDestino, porCuentaDe, referencia, beneficiario, conceptoAd) " +
                                " values( " +strIdMovimiento + ", " + strIdCuenta + ", '" + strEntidad + strOficina + strControl + strCuenta + "', " +
                                " '" + strPorCuentaDe + "', '" + strReferencia + "', '" + strBeneficiario + "', 'KD" + strConceptoAd + "'); ";
                    oDatos.Ejecutar(strSQL);
                        bCliente.clsBCliente bCliente = new bCliente.clsBCliente();
                        String strIdCuentas = bCliente.dameIdClienteByCuenta(strEntidad, strOficina, strControl, strCuenta );
                        foreach (String strId in strIdCuentas.Split(Convert.ToChar("#")))
	                    {
                            if(tools.clsTools.isNumeric(strId)){
                                tools.clsTools.addNotificacion("Se ha hecho una transferencia de la cuenta " + strEntidad + strOficina + strControl + strCuenta +
                                                            " a la cuenta " + strEntidadDes + strOficinaDes + strControlDes + strCuentaDes + " por un importe de " +
                                                            dblImporte, "Transferencia Efectuada " + strDescripcion,Convert.ToInt32(strId));
                            }
		   
	                    }
                      
                    if (existeCuenta(strEntidad ,strOficina , strControl , strCuenta ))
                    {
                        insertTransferenciaDestino(strImporte, strPorCuentaDe, strConcepto, strReferencia,
                                                 strConceptoAd, strBeneficiario, strDescripcion, strEntidadDes,
                                                 strOficinaDes, strControlDes, strCuentaDes, strEntidad + strOficina + strControl + strCuenta);
                    }
                        
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean insertTransferenciaDestino(String strImporte, String strPorCuentaDe, String strConcepto, String strReferencia,
                                                String strConceptoAd, String strBeneficiario, String strDescripcion, String strEntidadDes,
                                                String strOficinaDes, String strControlDes, String strCuentaDes,String strCuentaOrigen)
        {
            try
            {
                double dblImporte = Convert.ToDouble(strImporte);
                if (dblImporte < 0)
                {
                    dblImporte = dblImporte * -1;
                }
                String strIdCuenta = getIdCuentaByCampos(strEntidadDes, strOficinaDes, strControlDes, strCuentaDes);
                if (strIdCuenta != "")
                {
                    String strSQL = " insert into movimiento(idCuenta, importe, descripcion, concepto) " +
                                " values( " + strIdCuenta + ", " + dblImporte + ", 'Transferencia " + strDescripcion + "', '" + strConcepto + "'); ";
                    oDatos.Ejecutar(strSQL);
                    String strIdMovimiento = getLastIdMovimientos();
                    if (strIdMovimiento != "")
                    {
                        strSQL = " insert into transferencia(idMovimiento, idCuentaOrigen, cuentaDestino, porCuentaDe, referencia, beneficiario, conceptoAd) " +
                                   " values( " + strIdMovimiento + ", " + strIdCuenta + ", '" + strEntidadDes + strOficinaDes + strControlDes + strCuentaDes + "', " +
                                   " '" + strPorCuentaDe + "', '" + strReferencia + "', '" + strBeneficiario + "', '" + strConceptoAd + "'); ";
                        oDatos.Ejecutar(strSQL);
                        bCliente.clsBCliente bCliente = new bCliente.clsBCliente();
                        String strIdCuentas = bCliente.dameIdClienteByCuenta(strEntidadDes, strOficinaDes, strControlDes, strCuentaDes);
                        foreach (String strId in strIdCuentas.Split(Convert.ToChar("#")))
                        {
                            if (tools.clsTools.isNumeric(strId))
                            {
                                tools.clsTools.addNotificacion("Se ha hecho una transferencia de la cuenta " + strCuentaOrigen +
                                                            " a la cuenta " + strEntidadDes + strOficinaDes + strControlDes + strCuentaDes + " por un importe de " +
                                                            dblImporte, "Transferencia Recibida " + strDescripcion, Convert.ToInt32(strId));
                            }

                        }

                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public String getIdCuentaByCampos(String strEntidad, String strOficina, String strControl, String strCuenta)
        {
            try
            {
                String strSQL = " select id from cuenta " +
                          " where codigoEntidad = " + strEntidad + " and codigoOficina = " + strOficina +
                          "   and codigoControl = " + strControl + " and codigoCuenta = " + strCuenta + " ;";
                DataSet ds = oDatos.LanzarQueryT(strSQL);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    return ds.Tables[0].Rows[0]["id"].ToString();
                }
                return "";
            }
            catch (Exception)
            {
                return "";
            }
        }
        public String getLastIdMovimientos()
        {
            try
            {
                String strSQL = " SELECT  * FROM santander.movimiento order by id desc limit 1;";
                DataSet ds = oDatos.LanzarQueryT(strSQL);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    return ds.Tables[0].Rows[0]["id"].ToString();
                }
                return "";
            }
            catch (Exception)
            {
                return "";
            }
        }
        public Boolean existeCuenta(String strEntidad, String strOficina, String strControl, String strCuenta)
        {
            try
            {
                DataSet ds = oDatos.LanzarQueryT("Select id from cuenta where cuenta.codigoEntidad = " + strEntidad + " and cuenta.codigoOficina = " + strOficina + " and cuenta.codigoControl = " + strControl + " and cuenta.codigoCuenta = " + strCuenta + " ");
                if (ds.Tables[0].Rows.Count == 1)
                {
                    return true;
                }
                return false;
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
                DataSet ds = oDatos.LanzarQueryT("Select * from cuenta where cuenta.codigoEntidad = " + strEntidad + " and cuenta.codigoOficina = " + strOficina + " and cuenta.codigoControl = " + strControl + " and cuenta.codigoCuenta = " + strCuenta + " ");
                if (ds.Tables[0].Rows.Count == 1)
                {
                    if ((Convert.ToInt64(ds.Tables[0].Rows[0]["saldo"]) - Convert.ToInt64(strImporte)) > 0)
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
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
