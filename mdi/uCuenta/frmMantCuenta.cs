using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntityModel;

namespace uCuenta
{
    public partial class frmMantCuenta : Base.Base
    {
        santanderEntities1 context = new santanderEntities1();
        public frmMantCuenta()
        {
            InitializeComponent();

        }

        private void frmMantCuenta_Load(object sender, EventArgs e)
        {
            loadCuentas();
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseClick);
            ocultarId();
        }

        void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idCuenta = Convert.ToInt16(dgv.SelectedRows[0].Cells["idCuenta"].Value.ToString());
            var clientes = from cli in context.cliente
                           join cuc in context.cuentacliente
                             on cli.id equals cuc.idCliente
                           where cuc.idCuenta == idCuenta
                           select new
                           {
                               Cliente = cli.nombre + " " + cli.apellidos,
                               DNI = cli.dni,
                               idCliente = cli.id
                           };

            this.dgvCliente.DataSource = clientes;
            dgvCliente.Columns["idCliente"].Visible = false;
        }


        public override void ocultarId()
        {
            if (dgv.Columns.Contains("idCuenta"))
            {
                this.dgv.Columns["idCuenta"].Visible = false;
            }

        }

        private void loadCuentas()
        {
            var cuentas = from cue in context.cuenta
                          select new
                          {
                              idCuenta = cue.id,
                              CodigoEntidad = cue.codigoEntidad,
                              CodigoOficina = cue.codigoOficina,
                              CodigoControl = cue.codigoControl,
                              CodigoCuenta = cue.codigoCuenta,
                              Saldo = cue.saldo
                          };
            dgv.DataSource = cuentas;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmNueva = new frmNuevaCuenta();
            frmNueva.ShowDialog();
            loadCuentas();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idCuenta = Convert.ToInt16(dgv.SelectedRows[0].Cells["idCuenta"].Value.ToString());

            cuenta tmpCuenta = new cuenta();
            var cun = from cu in context.cuenta
                      where cu.id == idCuenta
                      select cu;
            foreach (var item in cun)
            {
                tmpCuenta = item;
            }

            cuentacliente tmpCC = new cuentacliente();
            var ccu = from cc in context.cuentacliente
                      where cc.idCuenta == idCuenta
                      select cc;
            foreach (var item in ccu)
            {
                notificarEliminacion(item.idCliente, tmpCuenta);
                tmpCC = item;
                context.DeleteObject(tmpCC);
            }


            context.DeleteObject(tmpCuenta);
            context.SaveChanges();
            loadCuentas();
        }

        private void notificarEliminacion(int p, cuenta cuenta)
        {

            AccDatos.OLEDBCON oldb = new AccDatos.OLEDBCON();
            oldb.Ejecutar("insert into notificacion (asunto, text, idCliente) values ('Cuenta eliminada','Se ha eliminado la cuenta " + cuenta.codigoEntidad + " - " + cuenta.codigoOficina + " - " + cuenta.codigoControl + " - " + cuenta.codigoCuenta + "'," + p + ")");

        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            int idCuenta = Convert.ToInt16(dgv.SelectedRows[0].Cells["idCuenta"].Value.ToString());
            Form frmAn = new frmAnadirTitulares(idCuenta);
          
            frmAn.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtrarGrid();
        }

        public override void filtrarGrid()
        {

            AccDatos.OLEDBCON conn = new AccDatos.OLEDBCON();
            this.dgv.DataSource = conn.LanzarConsultaT("select id as idCuenta, codigoEntidad, codigoOficina, codigoControl, codigoCuenta , saldo from cuenta " + buildWhere());
        }

        private String buildWhere()
        {
            String where = " where 1=1 ";
            if (csBuscar.zzTxtId != "")
            {
                int idCliente = Convert.ToInt16(dameIdClienteByDni(csBuscar.zzTxtId));
                where += "and id in "
                      + "  (select cuenta.id "
                      + "     from cuenta "
                      + "     join cuentacliente on cuenta.id = cuentacliente.idCuenta   "
                      + "     join cliente on cuentacliente.idCliente= cliente.id   "
                      + "    where cliente.id="+idCliente+"    )";

            }
            if (txtCuenta.ValidValue != "")
            {
                where += " and codigocuenta like '%" + txtCuenta.ValidValue + "%'";
            }
            return where;
        }
        private string dameIdClienteByDni(String strDni)
        {
            AccDatos.OLEDBCON oDatos = new AccDatos.OLEDBCON();
            DataTable dtCliente = oDatos.LanzarConsultaT("Select id from cliente where dni = '" + strDni + "'");
            if (dtCliente.Rows.Count == 1)
            {
                return dtCliente.Rows[0]["id"].ToString();
            }
            return null;
        }
    }
}
