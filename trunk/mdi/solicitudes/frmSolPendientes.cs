using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace solicitudes
{
    public partial class frmSolPendientes : Form
    {
        AccDatos.OLEDBCON conn = new AccDatos.OLEDBCON();
        public frmSolPendientes()
        {
            InitializeComponent();
            dgvSolicitudes.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgvSolicitudes_RowHeaderMouseDoubleClick);
           
        }





        void dgvSolicitudes_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            String tipoSol = dgvSolicitudes.SelectedRows[0].Cells["idTipoSol"].Value.ToString();
            if (tipoSol == "1")
            {
                Form petTarj = new frmSolicitudTarjeta(dgvSolicitudes.SelectedRows[0].Cells["idCliente"].Value.ToString(), dgvSolicitudes.SelectedRows[0].Cells["idCuenta"].Value.ToString(), dgvSolicitudes.SelectedRows[0].Cells["idSol"].Value.ToString());
                petTarj.MdiParent = this.MdiParent;
                petTarj.Show();

            }
            else if (tipoSol == "3")
            {
                Form petTarj = new frmSolDeposito(dgvSolicitudes.SelectedRows[0].Cells["idCliente"].Value.ToString(), dgvSolicitudes.SelectedRows[0].Cells["idCuenta"].Value.ToString(), dgvSolicitudes.SelectedRows[0].Cells["idSol"].Value.ToString());
                petTarj.MdiParent = this.MdiParent;
                petTarj.Show();
            }
        }

        private void frmSolPendientes_Load(object sender, EventArgs e)
        {
            santanderEntities1 context = new santanderEntities1();
            var datasource = from sol in context.solicitud
                             join cue in context.cuenta
                                on sol.idCuenta equals cue.id
                             join cli in context.cliente
                                on sol.idCliente equals cli.id
                             join esol in context.estadosolicitud
                                on sol.idEstadoSolicitud equals esol.id
                             join tsol in context.tiposolicitud
                                on sol.idTipoSolicitud equals tsol.id
                             where esol.tag == "pendiente"
                             select new
                             {
                                 Cuenta = cue.codigoEntidad + " - " + cue.codigoOficina + " - " + cue.codigoControl + " - " + cue.codigoCuenta,
                                 Fecha = sol.fecha,
                                 Cliente = cli.nombre + " " + cli.apellidos,
                                 DNI = cli.dni,
                                 Descripcion = (tsol.tag).Replace("solicitud", ""),
                                 Estado = esol.tag,
                                 idTipoSol = tsol.id,
                                 idCliente = cli.id,
                                 idCuenta = cue.id,
                                 idSol=sol.id
                             };
            dgvSolicitudes.DataSource = datasource;
            this.dgvSolicitudes.Columns["idSol"].Visible = false;
            this.dgvSolicitudes.Columns["idTipoSol"].Visible = false;
            this.dgvSolicitudes.Columns["idCliente"].Visible = false;
            this.dgvSolicitudes.Columns["idCuenta"].Visible = false;
        }


        private void txtCodCuenta_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void txtCodigoOficina_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private String buildWhere()
        {
            String where = "";
            if (txtApellidos.Text != "")
            {
                where += " and cliente.apellidos like '%" + txtApellidos.Text + "%'";
            }
            if (txtCodCuenta.Text != "")
            {
                where += " and cuenta.codigoCuenta like '%" + txtCodCuenta.Text + "%'";
            }
            if (txtCodigoOficina.Text != "")
            {
                where += " and cuenta.codigoOficina like '%" + txtCodigoOficina.Text + "%'";
            }
            if (txtNombre.Text != "")
            {
                where += " and cliente.nombre like '%" + txtNombre.Text + "%'";
            }
            if (chkTodos.Checked == false)
            {
                where += " and estadosolicitud.tag = 'pendiente'";
            }



            return where;
        }
        public void filtrar()
        {
            String jaja = "select concat(cuenta.codigoEntidad ,' - ' , concat(cuenta.codigoOficina ,' - ' , concat(cuenta.codigoControl,' - ' , cuenta.codigoCuenta))) as Cuenta, "
                             + " date_format(solicitud.fecha,'%d/%m/%Y')  as Fecha, concat(cliente.nombre,' ', cliente.apellidos) as Ciente, "
                             + " cliente.dni as DNI, replace(tiposolicitud.tag, 'solicitud','')as Tipo, estadosolicitud.tag as Estado, "
                             + " tiposolicitud.id as idTipoSol, cliente.id as idCliente, cuenta.id as idCuenta, solicitud.id as idSol "
                             + " from cuenta, solicitud, cliente, estadosolicitud, tiposolicitud "
                             + " where cuenta.id = solicitud.idCuenta and solicitud.idCliente= cliente.id and  "
                             + " solicitud.idTipoSolicitud = tiposolicitud.id and solicitud.idEstadoSolicitud= estadosolicitud.id " + buildWhere();

            DataTable ds = conn.LanzarConsultaT(jaja);
            dgvSolicitudes.DataSource = ds;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            filtrar();
        }








    }
}
