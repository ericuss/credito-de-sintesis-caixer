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
    /// Consulta de los extractos
    /// </summary>
    public partial class frmConsultaExtracto : Base.Base
    {
        #region "New"
        /// <summary>
        /// Constructor del formulario
        /// </summary>
        public frmConsultaExtracto()
        {
            strQuery = "select cuenta.codigoEntidad as Entidad,cuenta.codigoOficina as Oficina, cuenta.codigoControl as Control, cuenta.codigoCuenta as Cuenta, movimiento.* from movimiento " +
                     " join cuenta on cuenta.id = movimiento.idcuenta " +
                     " join cuentacliente on  cuenta.id = cuentacliente.idCuenta" +
                     " join cliente on cliente.id = cuentacliente.idcuenta " +
                    " where 1 = 1 ";  
            InitializeComponent();

            this.btnLimpiarControles.Click += new System.EventHandler(this.btnLimpiarControles_Click);
            tablaBBDD = "movimiento";
            strOpcional = "";

            this.strTitulo = "Consulta de Extracto";

        }     
        #endregion


        private void dtpIni_ValueChanged(object sender, EventArgs e)
        {
            filtrarGrid();
        }



        #region "Filtrar"
        private void txtImporteIni_Leave(object sender, EventArgs e)
        {
            if (tools.clsTools.isNumeric(txtImporteIni.Text))
            {
                filtrarGrid();
            }
            else
            {
                txtImporteIni.Text = "";
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtrarGrid();
        }
        private void txtImporteFin_Leave(object sender, EventArgs e)
        {
            if (tools.clsTools.isNumeric(txtImporteFin.Text))
            {
                filtrarGrid();
            }
            else
            {
                txtImporteFin.Text = "";
            }
        }
        private void txtDescrip_Leave(object sender, EventArgs e)
        {
            filtrarGrid();
        }
        private void txtCon_Leave(object sender, EventArgs e)
        {
            filtrarGrid();
        }
        public override void filtrarGrid()
        {
            string strQuery = "select cuenta.codigoEntidad as Entidad,cuenta.codigoOficina as Oficina, cuenta.codigoControl as Control, cuenta.codigoCuenta as Cuenta, movimiento.* from movimiento " +
                                " join cuenta on cuenta.id = movimiento.idcuenta "+
                                " join cuentacliente on  cuenta.id = cuentacliente.idCuenta"+
                                " join cliente on cliente.id = cuentacliente.idcuenta "+
                               " where 1 = 1 ";

            if (chkIncluirFechas.Checked)
            {
                strQuery += " and movimiento.fecha >= date('" + dtpIni.Value.Year + "/" + dtpIni.Value.Month + "/" + dtpIni.Value.Day + "') ";
                strQuery += " and movimiento.fecha <= date('" + dtpFin.Value.Year + "/" + dtpFin.Value.Month + "/" + dtpFin.Value.Day + "') ";
            }
            if (txtImporteIni.Text != "")
            {
                strQuery += " and movimiento.importe >= " + txtImporteIni.Text + " ";
            }

            if (txtImporteFin.Text != "")
            {
                strQuery += " and movimiento.importe <= " + txtImporteFin.Text + " ";
            }
            if (txtDescrip.Text != "")
            {
                strQuery += " and movimiento.descripcion like '%" + txtDescrip.Text + "%' ";
            }
            if (txtCon.Text != "")
            {
                strQuery += " and movimiento.concepto like '%" + txtCon.Text + "%' ";
            }
            if (txtEntidad.Text != "")
            {
                strQuery += " and cuenta.codigoEntidad like '%" + txtEntidad.Text + "%' ";
            }
            if (txtOficina.Text != "")
            {
                strQuery += " and cuenta.codigoOficina like '%" + txtOficina.Text + "%' ";
            }
            if (txtControl.Text != "")
            {
                strQuery += " and cuenta.codigoControl like '%" + txtControl.Text + "%' ";
            }
            if (txtCuenta.Text != "")
            {
                strQuery += " and cuenta.codigoCuenta like '%" + txtCuenta.Text + "%' ";
            }
            if (txtBuscar1.zzTxtId != "")
            {
                strQuery += " and cliente.dni = '" + txtBuscar1.zzTxtId + "' ";

            }

            AccDatos.OLEDBCON conn = new AccDatos.OLEDBCON();
            DataTable dtTemp = conn.LanzarConsultaT(strQuery);
            dgv.DataSource = dtTemp;
            dts.Tables.Remove(dts.Tables[0]);
            dts.Tables.Add(dtTemp);

            ocultarId();


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtImporteIni.Text = "";

            txtImporteFin.Text = "";
            txtDescrip.Text = "";
            txtCon.Text = "";
            chkIncluirFechas.Checked = false;
        }
        private void btnTodos_Click(object sender, EventArgs e)
        {
            txtImporteIni.Text = "";

            txtImporteFin.Text = "";
            txtDescrip.Text = "";
            txtCon.Text = "";
            chkIncluirFechas.Checked = false;
        }
        #endregion
        #region "Eventos sobreescritos"
        /// <summary>
        /// Sobreescribe el metodo del padre para ocultar los ids
        /// </summary>
        public override void ocultarId()
        {
            //base.ocultarId();
            if (dgv.Columns.Contains("id"))
            {
                dgv.Columns["id"].Visible = false;
            }
            if (dgv.Columns.Contains("idCuenta"))
            {
                dgv.Columns["idCuenta"].Visible = false;
            }
        }
        #endregion

    }
}
