using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace uCuenta
{
    /// <summary>
    /// Ingresa dinero en una cuenta
    /// </summary>
    public partial class frmIngreso : Form
    {
        #region "Propiedades"
        /// <summary>
        /// Objeto que Consulta/Modifica/Borra/inserta querys
        /// </summary>
        AccDatos.OLEDBCON conn;
        #endregion
        #region "Contructor"
        /// <summary>
        /// Constructor
        /// </summary>
        public frmIngreso()
        {
            InitializeComponent();
            conn = new AccDatos.OLEDBCON();
        }
        #endregion
        #region "Load"
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        private void frmIngreso_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyUp += new KeyEventHandler(frmIngreso_KeyUp);
        }
        #endregion
        #region "Eventos"
        /// <summary>
        /// Si pulsas F3 filtra los datos
        /// </summary>
        /// <param name="sender">Parametros del evento</param>
        /// <param name="e">Parametros del evento</param>
        void frmIngreso_KeyUp(object sender, KeyEventArgs e)
        {
            if (csCliente.zzTxtId != "")
            {
                if (e.KeyValue.ToString() == "114")
                {
                    Buscar();
                }
            }
        }
        /// <summary>
        /// Filtra los datos de la DataGrid
        /// </summary>
        /// <param name="sender">Parametros del evento</param>
        /// <param name="e">Parametros del evento</param>
        private void txtBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        /// <summary>
        /// Genera el reintegro
        /// </summary>
        /// <param name="sender">Parametros del evento</param>
        /// <param name="e">Parametros del evento</param>
        private void btnRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtImporte.Text) > 0)
                {
                    String id = csCliente.zzTxtId;
                    int idCuenta = Convert.ToInt16(this.dgvCuentas.SelectedRows[0].Cells["idCuenta"].Value.ToString());
                    conn.Ejecutar("insert into movimiento(idCuenta,importe,descripcion,concepto) values (" + idCuenta + ", -" + txtImporte.Text + ",'Reintegro por caja de " + txtImporte.Text + "','Reintegro')");
                    conn.Ejecutar("insert into notificacion ( text, idCliente, asunto) values ('Se han ingresado" + txtImporte.Text + " Euros.',(select id from cliente where dni='" + id + "'),'Reintegro')");
                    txtImporte.Text = "";
                    txtError.setOK("Ingreso Realizado");
                    Buscar();
                }
                else
                {
                    txtError.setError("Error Reintegro Negativo");
                }
            }
            catch (Exception exx)
            {
                Console.WriteLine(exx.Message);
                txtError.setError("Error Cuenta Erronia");
            }
        }

        /// <summary>
        /// Genera el ingreso
        /// </summary>
        /// <param name="sender">Parametros del evento</param>
        /// <param name="e">Parametros del evento</param>
        private void btnRealizar_Click(object sender, EventArgs e)
        {
            if (this.dgvCuentas.SelectedRows.Count == 1)
            {
                try
                {
                    if (Convert.ToDouble(txtImporte.Text) > 0)
                    {
                        String id = csCliente.zzTxtId;
                        int idCuenta = Convert.ToInt16(this.dgvCuentas.SelectedRows[0].Cells["idCuenta"].Value.ToString());
                        conn.Ejecutar("insert into movimiento(idCuenta,importe,descripcion,concepto) values (" + idCuenta + "," + txtImporte.Text + ",'Ingreso por caja de " + txtImporte.Text + "','Ingreso')");
                        conn.Ejecutar("insert into notificacion ( text, idCliente, asunto) values ('Se han ingresado" + txtImporte.Text + " Euros.',(select id from cliente where dni='" + id + "'),'Ingreso')");
                        txtImporte.Text = "";
                        txtError.setOK("Ingreso Realizado");
                        Buscar();
                    }
                    else
                    {
                        txtError.setError("Error Ingreso Negativo");
                    }
                }
                catch (Exception exx)
                {
                    Console.WriteLine(exx.Message);
                    txtError.setError("Error Cuenta Erronia");
                }
            }
        }
        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender">Parametros del evento</param>
        /// <param name="e">Parametros del evento</param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion
        #region "Metodos"
        /// <summary>
        /// Filtra la DataGrid con los datos
        /// </summary>
        private void Buscar()
        {

            String id = csCliente.zzTxtId;

            this.dgvCuentas.DataSource = conn.LanzarConsultaT("select cuenta.id as idCuenta, codigoEntidad, codigoOficina, codigoControl, codigoCuenta, saldo"
                                                            + "  from cuenta "
                                                            + "  join cuentacliente  "
                                                            + "    on cuenta.id = cuentacliente.idCuenta"
                                                            + "  join cliente "
                                                            + "    on cuentacliente.idCliente = cliente.id"
                                                            + " where dni='" + id + "'");
            this.dgvCuentas.Columns["idCuenta"].Visible = false;
        }
        #endregion


    }
}
