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
    public partial class frmTransferencia : Form
    {
        public frmTransferencia()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (camposObligatorios())
            {
                bTransferencia.clsBTransferencia btrans = new bTransferencia.clsBTransferencia();
                
                if (btrans.hayDinero(txtEntidad.Text,txtOficina.Text,txtControl.Text,txtCuenta.Text,txtImporte.Text))
                {
                  Boolean blnInsert =  btrans.insertTransferenciaOrigen(txtEntidad.Text, txtOficina.Text, txtControl.Text, txtCuenta.Text, txtImporte.Text,
                                                     txtPorCuentaDe.Text, txtConcepto.Text, txtReferencia.Text, txtConceptoAd.Text, txtBeneficiario.Text,
                                                     txtDescripcion.Text, txtEntidadDes.Text, txtOficinaDes.Text, txtControlDes.Text, txtCuentaDes.Text);
                  if (blnInsert)
                  {

                  }
                  else
                  {

                  }
                }
            }
        }

        private Boolean camposObligatorios()
        {
            try
            {
                if (txtEntidad.Text.Trim() == "" && txtOficina.Text.Trim() == "" && txtControl.Text.Trim() == "" && txtCuenta.Text.Trim() == ""  )
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

        private void txtImporte_Leave(object sender, EventArgs e)
        {
            gbCuentaDestino.Enabled = true;
        }

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
    }
}
