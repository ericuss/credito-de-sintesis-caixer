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
    public partial class frmIngreso : Form
    {
        AccDatos.OLEDBCON conn;
        public frmIngreso()
        {
            InitializeComponent();
            conn = new AccDatos.OLEDBCON();
        }

        private void frmIngreso_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyUp += new KeyEventHandler(frmIngreso_KeyUp);
        }

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

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

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
            this.dgvCuentas.Columns["idCuenta"].Visible=false;
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            if (this.dgvCuentas.SelectedRows.Count == 1)
            {
                try
                {
                    String id = csCliente.zzTxtId;
                    int idCuenta = Convert.ToInt16(this.dgvCuentas.SelectedRows[0].Cells["idCuenta"].Value.ToString());
                    conn.Ejecutar("insert into movimiento(idCuenta,importe,descripcion,concepto) values (" + idCuenta + "," + txtImporte.Text + ",'Ingreso por caja de " + txtImporte.Text + "','Ingreso')");
                    conn.Ejecutar("insert into notificacion ( text, idCliente, asunto) values ('Se han ingresado" + txtImporte.Text + " Euros.',(select id from cliente where dni='" + id + "'),'Ingreso')");
                    txtImporte.Text = "";
                    txtError.setOK("Ingreso Realizado");
                    Buscar();

                }
                catch (Exception exx)
                {
                    txtError.setError("Error Cuenta Erronia");
                }
            } 
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    





    }
}
