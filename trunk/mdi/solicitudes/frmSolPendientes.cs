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
        }

        void dgvSolicitudes_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           MessageBox.Show(dgvSolicitudes.SelectedRows[0].Cells["idTipoSol"].Value.ToString());
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
                             select new
                             {
                                 Cuenta = cue.codigoEntidad + " - " + cue.codigoOficina + " - " + cue.codigoControl + " - " + cue.codigoCuenta,
                                 Fecha = sol.fecha,
                                 Cliente = cli.nombre + " " + cli.apellidos,
                                 DNI = cli.dni,
                                 Descripcion = tsol.descripcion,
                                 Estado = esol.tag,
                                 idTipoSol = tsol.id
                             };
            dgvSolicitudes.DataSource = datasource;
            this.dgvSolicitudes.Columns["idTipoSol"].Visible = false;
        }
    }
}
