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
        public frmSolPendientes()
        {
            InitializeComponent();
            dgvSolicitudes.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgvSolicitudes_RowHeaderMouseDoubleClick);
            this.GotFocus += new EventHandler(frmSolPendientes_GotFocus);
        }

        void frmSolPendientes_GotFocus(object sender, EventArgs e)
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
                                 idCuenta = cue.id
                             };
            dgvSolicitudes.DataSource = datasource;
            this.dgvSolicitudes.Columns["idTipoSol"].Visible = false;
            this.dgvSolicitudes.Columns["idCliente"].Visible = false;
            this.dgvSolicitudes.Columns["idCuenta"].Visible = false;
        }

        void dgvSolicitudes_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            String tipoSol = dgvSolicitudes.SelectedRows[0].Cells["idTipoSol"].Value.ToString();
            if (tipoSol == "1")
            {
                Form petTarj = new frmSolicitudTarjeta(dgvSolicitudes.SelectedRows[0].Cells["idCliente"].Value.ToString(), dgvSolicitudes.SelectedRows[0].Cells["idCuenta"].Value.ToString());
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
                                 idCuenta = cue.id
                             };
            dgvSolicitudes.DataSource = datasource;
            this.dgvSolicitudes.Columns["idTipoSol"].Visible = false;
            this.dgvSolicitudes.Columns["idCliente"].Visible = false;
            this.dgvSolicitudes.Columns["idCuenta"].Visible = false;
        }

        private void txtCodCuenta_TextChanged(object sender, EventArgs e)
        {

            santanderEntities1 context = new santanderEntities1();
            if (chkTodos.Checked == true)
            {
                var datasource = from sol in context.solicitud
                                 join cue in context.cuenta
                                    on sol.idCuenta equals cue.id
                                 join cli in context.cliente
                                    on sol.idCliente equals cli.id
                                 join esol in context.estadosolicitud
                                    on sol.idEstadoSolicitud equals esol.id
                                 join tsol in context.tiposolicitud
                                    on sol.idTipoSolicitud equals tsol.id
                                 where cue.codigoCuenta.Contains(@txtCodCuenta.Text)
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
                                     idCuenta = cue.id
                                 };
                dgvSolicitudes.DataSource = datasource;
                this.dgvSolicitudes.Columns["idTipoSol"].Visible = false;
                this.dgvSolicitudes.Columns["idCliente"].Visible = false;
                this.dgvSolicitudes.Columns["idCuenta"].Visible = false;
            }
            else
            {
                var datasource = from sol in context.solicitud
                                 join cue in context.cuenta
                                    on sol.idCuenta equals cue.id
                                 join cli in context.cliente
                                    on sol.idCliente equals cli.id
                                 join esol in context.estadosolicitud
                                    on sol.idEstadoSolicitud equals esol.id
                                 join tsol in context.tiposolicitud
                                    on sol.idTipoSolicitud equals tsol.id
                                 where cue.codigoCuenta.Contains(@txtCodCuenta.Text) && esol.tag == "pendiente"
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
                                     idCuenta = cue.id
                                 };
                dgvSolicitudes.DataSource = datasource;
                this.dgvSolicitudes.Columns["idTipoSol"].Visible = false;
                this.dgvSolicitudes.Columns["idCliente"].Visible = false;
                this.dgvSolicitudes.Columns["idCuenta"].Visible = false;
            }
        }

        private void txtCodigoOficina_TextChanged(object sender, EventArgs e)
        {
            santanderEntities1 context = new santanderEntities1();
            if (chkTodos.Checked == true)
            {
                var datasource = from sol in context.solicitud
                                 join cue in context.cuenta
                                    on sol.idCuenta equals cue.id
                                 join cli in context.cliente
                                    on sol.idCliente equals cli.id
                                 join esol in context.estadosolicitud
                                    on sol.idEstadoSolicitud equals esol.id
                                 join tsol in context.tiposolicitud
                                    on sol.idTipoSolicitud equals tsol.id
                                 where cue.codigoOficina.Contains(@txtCodigoOficina.Text)
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
                                     idCuenta = cue.id
                                 };
                dgvSolicitudes.DataSource = datasource;
                this.dgvSolicitudes.Columns["idTipoSol"].Visible = false;
                this.dgvSolicitudes.Columns["idCliente"].Visible = false;
                this.dgvSolicitudes.Columns["idCuenta"].Visible = false;
            }
            else
            {
                var datasource = from sol in context.solicitud
                                 join cue in context.cuenta
                                    on sol.idCuenta equals cue.id
                                 join cli in context.cliente
                                    on sol.idCliente equals cli.id
                                 join esol in context.estadosolicitud
                                    on sol.idEstadoSolicitud equals esol.id
                                 join tsol in context.tiposolicitud
                                    on sol.idTipoSolicitud equals tsol.id
                                 where cue.codigoOficina.Contains(@txtCodigoOficina.Text) && esol.tag == "pendiente"
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
                                     idCuenta = cue.id
                                 };
                dgvSolicitudes.DataSource = datasource;
                this.dgvSolicitudes.Columns["idTipoSol"].Visible = false;
                this.dgvSolicitudes.Columns["idCliente"].Visible = false;
                this.dgvSolicitudes.Columns["idCuenta"].Visible = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            santanderEntities1 context = new santanderEntities1();
            if (chkTodos.Checked == true)
            {
                var datasource = from sol in context.solicitud
                                 join cue in context.cuenta
                                    on sol.idCuenta equals cue.id
                                 join cli in context.cliente
                                    on sol.idCliente equals cli.id
                                 join esol in context.estadosolicitud
                                    on sol.idEstadoSolicitud equals esol.id
                                 join tsol in context.tiposolicitud
                                    on sol.idTipoSolicitud equals tsol.id
                                 where cli.nombre.Contains(txtNombre.Text)
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
                                     idCuenta = cue.id
                                 };
                dgvSolicitudes.DataSource = datasource;
                this.dgvSolicitudes.Columns["idTipoSol"].Visible = false;
                this.dgvSolicitudes.Columns["idCliente"].Visible = false;
                this.dgvSolicitudes.Columns["idCuenta"].Visible = false;
            }
            else
            {
                var datasource = from sol in context.solicitud
                                 join cue in context.cuenta
                                    on sol.idCuenta equals cue.id
                                 join cli in context.cliente
                                    on sol.idCliente equals cli.id
                                 join esol in context.estadosolicitud
                                    on sol.idEstadoSolicitud equals esol.id
                                 join tsol in context.tiposolicitud
                                    on sol.idTipoSolicitud equals tsol.id
                                 where cli.nombre.Contains(txtNombre.Text) && esol.tag == "pendiente"
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
                                     idCuenta = cue.id
                                 };
                dgvSolicitudes.DataSource = datasource;
                this.dgvSolicitudes.Columns["idTipoSol"].Visible = false;
                this.dgvSolicitudes.Columns["idCliente"].Visible = false;
                this.dgvSolicitudes.Columns["idCuenta"].Visible = false;
            }
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked == true)
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
                                 where cli.apellidos.Contains(@txtApellidos.Text)
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
                                     idCuenta = cue.id
                                 };
                dgvSolicitudes.DataSource = datasource;
                this.dgvSolicitudes.Columns["idTipoSol"].Visible = false;
                this.dgvSolicitudes.Columns["idCliente"].Visible = false;
                this.dgvSolicitudes.Columns["idCuenta"].Visible = false;
            }
            else
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
                                 where cli.apellidos.Contains(@txtApellidos.Text) && esol.tag == "pendiente"
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
                                     idCuenta = cue.id
                                 };
                dgvSolicitudes.DataSource = datasource;
                this.dgvSolicitudes.Columns["idTipoSol"].Visible = false;
                this.dgvSolicitudes.Columns["idCliente"].Visible = false;
                this.dgvSolicitudes.Columns["idCuenta"].Visible = false;
            }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked == true)
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
                                     idCuenta = cue.id
                                 };
                dgvSolicitudes.DataSource = datasource;
                this.dgvSolicitudes.Columns["idTipoSol"].Visible = false;
                this.dgvSolicitudes.Columns["idCliente"].Visible = false;
                this.dgvSolicitudes.Columns["idCuenta"].Visible = false;
            }
            else
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
                                     idCuenta = cue.id
                                 };
                dgvSolicitudes.DataSource = datasource;
                this.dgvSolicitudes.Columns["idTipoSol"].Visible = false;
                this.dgvSolicitudes.Columns["idCliente"].Visible = false;
                this.dgvSolicitudes.Columns["idCuenta"].Visible = false;
            }
        }

      









    }
}
