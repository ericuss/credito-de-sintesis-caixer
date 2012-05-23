using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace bTransferencia
{
    /// <summary>
    /// Funciones para comprobar, obtener y/o comprobar transferencias
    /// </summary>
    public class clsBTransferencia
    {
        #region "Propiedades"
        /// <summary>
        /// Objeto que enlaza con el proyecto que obtiene los datos
        /// </summary>
        AccDatos.OLEDBCON oDatos = new AccDatos.OLEDBCON();
        #endregion
        #region "New"
        /// <summary>
        /// Constructor vacio
        /// </summary>
        public clsBTransferencia()
        {
        }
        #endregion
        #region "Insert"
        /// <summary>
        /// Inserta una transferencia de origen
        /// </summary>
        /// <param name="strEntidad">Entidad origen</param>
        /// <param name="strOficina">Oficina origen</param>
        /// <param name="strControl">Control origen</param>
        /// <param name="strCuenta">Cuenta origen</param>
        /// <param name="strImporte">Importe</param>
        /// <param name="strPorCuentaDe">Por cuenta de quien es la transferencia</param>
        /// <param name="strConcepto">Concepto de la transferencia</param>
        /// <param name="strReferencia">Renferencia de la transferencia</param>
        /// <param name="strConceptoAd">Concepto adicional de la transferencia</param>
        /// <param name="strBeneficiario">Beneficiario de la transferencia</param>
        /// <param name="strDescripcion">Descripcion de la transferencia</param>
        /// <param name="strEntidadDes">Entidad destino</param>
        /// <param name="strOficinaDes">Oficina destino</param>
        /// <param name="strControlDes">Control destino</param>
        /// <param name="strCuentaDes">Cuenta destino</param>
        /// <returns>Devuelve si se ha efectuado correctamente</returns>
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
       /// <summary>
        /// Inserta una transferencia de destino
       /// </summary>
        /// <param name="strImporte">Importe</param>
        /// <param name="strPorCuentaDe">Por cuenta de quien es la transferencia</param>
        /// <param name="strConcepto">Concepto de la transferencia</param>
        /// <param name="strReferencia">Renferencia de la transferencia</param>
        /// <param name="strConceptoAd">Concepto adicional de la transferencia</param>
        /// <param name="strBeneficiario">Beneficiario de la transferencia</param>
        /// <param name="strDescripcion">Descripcion de la transferencia</param>
        /// <param name="strEntidadDes">Entidad destino</param>
        /// <param name="strOficinaDes">Oficina destino</param>
        /// <param name="strControlDes">Control destino</param>
        /// <param name="strCuentaDes">Cuenta destino</param>
       /// <param name="strCuentaOrigen">Cuenta de origen(completa)</param>
       /// <returns></returns>
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
        #endregion
        #region "Get"
        /// <summary>
        /// Devuelve el id de la cuenta, a partir de los campos de la cuenta
        /// </summary>
        /// <param name="strEntidad">Entidad</param>
        /// <param name="strOficina">Oficina</param>
        /// <param name="strControl">Control</param>
        /// <param name="strCuenta">Cuenta</param>
        /// <returns>Id cuenta</returns>
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
        /// <summary>
        /// Devuelve el id del ultimo movimiento
        /// </summary>
        /// <returns>Id del ultimo movimiento</returns>
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
        #endregion
        #region "Comprobaciones"
        /// <summary>
        /// Comprueba si existe una cuenta
        /// </summary>
        /// <param name="strEntidad">Entidad</param>
        /// <param name="strOficina">Oficina</param>
        /// <param name="strControl">Control</param>
        /// <param name="strCuenta">Cuenta</param>
        /// <returns>Devuelve si existe una cuenta</returns>
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
        /// <summary>
        /// Comprueba si quitando el importe el saldo es positivo
        /// </summary>
        /// <param name="strEntidad">Entidad</param>
        /// <param name="strOficina">Oficina</param>
        /// <param name="strControl">Control</param>
        /// <param name="strCuenta">Cuenta</param>
        /// <param name="strImporte">Importe</param>
        /// <returns>Devuelve si lo ha hecho bien</returns>
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
                Console.WriteLine("Error: " + ex.ToString());
                return false;
            }
        }
        #endregion
    }
}
