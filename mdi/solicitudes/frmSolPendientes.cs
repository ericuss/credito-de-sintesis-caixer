using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntityModel;

namespace solicitudes
{
    /// <summary>
    /// Formulario que nos permite gestionar las solicitudes pendientes.
    /// </summary>
    public partial class frmSolPendientes : Form
    {
        #region "Variables Privadas"

        private AccDatos.OLEDBCON conn = new AccDatos.OLEDBCON();

        #endregion

        #region "Constructores"

        /// <summary>
        /// Constructor del Formulario. Añade un nuevo handler al evento DoubleClick de la cabecera de las filas de la DataGridView.
        /// </summary>
        public frmSolPendientes()
        {
            InitializeComponent();
            dgvSolicitudes.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgvSolicitudes_RowHeaderMouseDoubleClick);
            dgvSolicitudes.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            
        }
  
        #endregion

        #region "Eventos"
        /// <summary>
        /// Lanza el evento de filtro de datos
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtrar();
        }
        /// <summary>
        /// Evento que se ejecuta al pulsar la tecla F3. 
        /// Llama a la funcion de Filtrado de la DataGridView
        /// </summary>
        /// <param name="sender">Parametro del Evento</param>
        /// <param name="e">Parametro del Evento</param>
        void frmSolPendientes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                filtrar();
            }
        }

        /// <summary>
        /// Eveto que se ejecuta al hacer DobleClick sobre la cabecera de las filas de la DataGridView. 
        /// Recoje el tipo de solicitud seleccionada y abre su formulario correspondiente
        /// </summary>
        /// <param name="sender">Parametro del Eento</param>
        /// <param name="e">Parametro del Eento</param>
        private void dgvSolicitudes_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            String tipoSol = dgvSolicitudes.SelectedRows[0].Cells["idTipoSol"].Value.ToString();
            if (tipoSol == "1")
            {
                Form petTarj = new frmSolicitudTarjeta(dgvSolicitudes.SelectedRows[0].Cells["idCliente"].Value.ToString(), dgvSolicitudes.SelectedRows[0].Cells["idCuenta"].Value.ToString(), dgvSolicitudes.SelectedRows[0].Cells["idSol"].Value.ToString());
                petTarj.ShowDialog();

            }
            else if (tipoSol == "3")
            {
                Form petTarj = new frmSolDeposito(dgvSolicitudes.SelectedRows[0].Cells["idCliente"].Value.ToString(), dgvSolicitudes.SelectedRows[0].Cells["idCuenta"].Value.ToString(), dgvSolicitudes.SelectedRows[0].Cells["idSol"].Value.ToString());
                petTarj.ShowDialog();
            }
            else if (tipoSol == "2" || tipoSol == "4")
            {
                Form petTarj = new frmSolPrestamo(dgvSolicitudes.SelectedRows[0].Cells["idCliente"].Value.ToString(), dgvSolicitudes.SelectedRows[0].Cells["idCuenta"].Value.ToString(), dgvSolicitudes.SelectedRows[0].Cells["idSol"].Value.ToString());
                petTarj.ShowDialog();
            }
            loadSolicitudesList();
        }

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario. 
        /// Se encarga de ejecutar la carga de todas las solicitudes a la DataGridView.
        /// </summary>
        /// <param name="sender">Parametro del Eento</param>
        /// <param name="e">Parametro del Eento</param>
        private void frmSolPendientes_Load(object sender, EventArgs e)
        {
            loadSolicitudesList();
            this.KeyPreview = true;
            this.KeyUp += new KeyEventHandler(frmSolPendientes_KeyUp);
        }
       
        /// <summary>
        /// Evento que se ejecuta cambiar el estado del chkTodos, de seleccionado a deseleccionado o a la inversa.
        /// Se encarga de llamar a la funcion Filtrar.
        /// </summary>
        /// <param name="sender">Parametro del Eento</param>
        /// <param name="e">Parametro del Eento</param>
        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        #endregion

        #region "Metodos"

        /// <summary>
        /// Metodo encargado de cargar la DataridView con la listade Solicitudes utilizando LINQ
        /// </summary>
        private void loadSolicitudesList()
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
                                 idSol = sol.id
                             };
            dgvSolicitudes.DataSource = datasource;
            this.dgvSolicitudes.Columns["idSol"].Visible = false;
            this.dgvSolicitudes.Columns["idTipoSol"].Visible = false;
            this.dgvSolicitudes.Columns["idCliente"].Visible = false;
            this.dgvSolicitudes.Columns["idCuenta"].Visible = false;
        }

        /// <summary>
        /// Metodo encargado de Filtrar los resultados de la DataGridView. 
        /// Utilizando el objeto OLDBCON y el metodo BuildWhere lanza una consulta a la BBDD que luego asignara  la DataGridView.
        /// </summary>
        public void filtrar()
        {
            String sql = "select concat(cuenta.codigoEntidad ,' - ' , concat(cuenta.codigoOficina ,' - ' , concat(cuenta.codigoControl,' - ' , cuenta.codigoCuenta))) as Cuenta, "
                             + " date_format(solicitud.fecha,'%d/%m/%Y')  as Fecha, concat(cliente.nombre,' ', cliente.apellidos) as Ciente, "
                             + " cliente.dni as DNI, replace(tiposolicitud.tag, 'solicitud','')as Tipo, estadosolicitud.tag as Estado, "
                             + " tiposolicitud.id as idTipoSol, cliente.id as idCliente, cuenta.id as idCuenta, solicitud.id as idSol "
                             + " from cuenta, solicitud, cliente, estadosolicitud, tiposolicitud "
                             + " where cuenta.id = solicitud.idCuenta and solicitud.idCliente= cliente.id and  "
                             + " solicitud.idTipoSolicitud = tiposolicitud.id and solicitud.idEstadoSolicitud= estadosolicitud.id " + buildWhere();

            DataTable ds = conn.LanzarConsultaT(sql);
            dgvSolicitudes.DataSource = ds;
        }

        /// <summary>
        /// Metodo que construye los condicionales de la consulta SQL para filtrar. 
        /// Segun esten informados o no los Filtros.
        /// </summary>
        /// <returns>Retorna el condicional de la consulta en forma de String.</returns>
        private String buildWhere()
        {
            String where = "";
            if (txtApellidos.ValidValue != "")
            {
                where += " and cliente.apellidos like '%" + txtApellidos.ValidValue + "%'";
            }
            if (txtCodCuenta.ValidValue != "")
            {
                where += " and cuenta.codigoCuenta like '%" + txtCodCuenta.ValidValue + "%'";
            }
            if (txtCodigoOficina.ValidValue != "")
            {
                where += " and cuenta.codigoOficina like '%" + txtCodigoOficina.ValidValue + "%'";
            }
            if (txtNombre.ValidValue != "")
            {
                where += " and cliente.nombre like '%" + txtNombre.ValidValue + "%'";
            }
            if (chkTodos.Checked == false)
            {
                where += " and estadosolicitud.tag = 'pendiente'";
            }
            return where;
        }

        #endregion

       
    }
}
