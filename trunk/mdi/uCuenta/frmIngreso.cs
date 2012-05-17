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

        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            String id = csCliente.zzTxtId;
           
            this.dgvCuentas.DataSource = conn.LanzarConsultaT("select cuenta.id as idCuenta, codigoEntidad, codigoOficina, codigoControl, codigoCuenta, saldo"
                                                            + "  from cuenta "
                                                            + "  join cuentacliente  "
                                                            + "    on cuenta.id = cuentacliente.idCuenta"
                                                            + "  join cliente "
                                                            + "    on cuentacliente.idCliente = cliente.id"
                                                            + " where dni='"+id+"'");

        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            int idCuenta = Convert.ToInt16(this.dgvCuentas.SelectedRows[0].Cells["idCuenta"].Value.ToString());
            conn.LanzarConsulta("insert into movimiento(idCuenta,importe,descripcion,concepto) values ("+idCuenta+","+txtImporte.Text+",'Ingreso por caja de "+txtImporte.Text+"','Ingreso')");
            txtImporte.Text = "";
            msgOK();
        }

        private void msgOK()
        {
            txtError.ForeColor = System.Drawing.Color.Black;
            txtError.BackColor = System.Drawing.Color.Green;
            txtError.Text = "Ingreso realizado";
        }





    }
}
