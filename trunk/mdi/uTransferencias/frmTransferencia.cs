using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using bTransferencia;
namespace uTransferencia
{
    /// <summary>
    /// Formulario de transferencias de una cuenta a otra
    /// </summary>
    public partial class frmTransferencia : Form
    {
        #region "New"
        /// <summary>
        /// Constructor vacio
        /// </summary>
        public frmTransferencia()
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
        /// Comprueba los datos antes de intentar hacer la transferencia
        /// </summary>
        /// <param name="sender">Parametro del Evento</param>
        /// <param name="e">Parametro del evento</param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (camposObligatorios())
            {
                bTransferencia.clsBTransferencia btrans = new bTransferencia.clsBTransferencia();
                String cueOrig = txtEntidad.Text + "" + txtOficina.Text + "" + txtControl.Text + "" + txtCuenta.Text;
                String cueDes = txtEntidadDes.Text + "" + txtOficinaDes.Text + "" + txtControlDes.Text + "" + txtCuentaDes.Text;
                if (cueDes != cueOrig)
                {
                    if (txtEntidadDes.Text.Length == 4 || txtOficinaDes.Text.Length == 4 || txtControlDes.Text.Length == 2 || txtCuentaDes.Text.Length == 8)
                    {
                        if (btrans.hayDinero(txtEntidad.Text, txtOficina.Text, txtControl.Text, txtCuenta.Text, txtImporte.Text))
                        {
                            Boolean blnInsert = btrans.insertTransferenciaOrigen(txtEntidad.Text, txtOficina.Text, txtControl.Text, txtCuenta.Text, txtImporte.Text,
                                                               txtPorCuentaDe.Text, txtConcepto.Text, txtReferencia.Text, txtConceptoAd.Text, txtBeneficiario.Text,
                                                               txtDescripcion.Text, txtEntidadDes.Text, txtOficinaDes.Text, txtControlDes.Text, txtCuentaDes.Text);
                            if (blnInsert)
                            {
                                txtError.setOK("Transferencia efectuada correctamente");
                            }
                            else
                            {
                                txtError.setError("Ha ocurrido un error haciendo la transferencia");
                            }
                        }
                        else
                        {
                            txtError.setError("No hay suficiente dinero");
                        }
                    }
                    else
                    {
                        txtError.setError("La cuenta de destino no tiene un formato correcto");

                    }
                }
                else
                {
                    txtError.setError("La cuenta de Destino y la cuenta de origen son las mismas");
                }
            }
            else
            {
                txtError.setError("Faltan por rellenar campos obligatorios");
            }
        }
        /// <summary>
        /// Abre un formulario de consulta - seleccion para buscar la cuenta
        /// </summary>
        /// <param name="sender">Parametros del evento</param>
        /// <param name="e">Parametro del evento</param>
        private void btnBuscarCuenta_Click(object sender, EventArgs e)
        {
            uFrmCsHijos.frmCsCuenta frm = new uFrmCsHijos.frmCsCuenta();
            frm.ShowDialog();
            if (frm.isAceptar)
            {
                txtEntidad.Text = frm.strEntidad;
                txtOficina.Text = frm.strOficina;
                txtControl.Text = frm.strControl;
                txtCuenta.Text = frm.strCuenta;
                gbDatos.Enabled = true;
            }
        }
        /// <summary>
        /// Cuando pierde el foco habilita la insercion de la cuenta de destino
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        private void txtImporte_Leave(object sender, EventArgs e)
        {
            gbCuentaDestino.Enabled = true;
        }
        /// <summary>
        /// Abre un formulario de consulta - seleccion para buscar la cuenta
        /// </summary>
        /// <param name="sender">Parametros del evento</param>
        /// <param name="e">Parametros del evento</param>
        private void btnBuscarCuentaDes_Click(object sender, EventArgs e)
        {
            uFrmCsHijos.frmCsCuenta frm = new uFrmCsHijos.frmCsCuenta();
            frm.ShowDialog();
            if (frm.isAceptar)
            {
                txtEntidadDes.Text = frm.strEntidad;
                txtOficinaDes.Text = frm.strOficina;
                txtControlDes.Text = frm.strControl;
                txtCuentaDes.Text = frm.strCuenta;
            }
        }
        #endregion
        #region "Metodos"
        /// <summary>
        /// Comprueba los datos obligatorios
        /// </summary>
        /// <returns>Devuelve si es correcto</returns>
        private Boolean camposObligatorios()
        {
            try
            {
                if (txtEntidad.Text.Trim() == "" && txtOficina.Text.Trim() == "" && txtControl.Text.Trim() == "" && txtCuenta.Text.Trim() == "")
                {
                    return false;
                }
                if (txtImporte.Text.Trim() == "" && Convert.ToInt64(txtImporte.Text) <= 1)
                {
                    return false;
                }
                if (txtEntidadDes.Text.Trim() == "" && txtOficinaDes.Text.Trim() == "" && txtControlDes.Text.Trim() == "" && txtCuentaDes.Text.Trim() == "")
                {
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}
