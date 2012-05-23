using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntityModel;
namespace cliente
{
    /// <summary>
    /// Formulario para el Mantenimiento de Clientes
    /// </summary>
    public partial class frmMantCliente : Base.Base
    {
        #region "Propiedades"
        santanderEntities1 context = new santanderEntities1();
        #endregion

        #region "Constructores"

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public frmMantCliente()
        {
            InitializeComponent();

            this.strTitulo = "Consulta de Clientes";
        }
        #endregion

        #region "Eventos"

        /// <summary>
        /// Evento que se inicia cuando el formulario se muestra
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Objeto del evento</param>
        private void frmMantCliente_Load(object sender, EventArgs e)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            loadAllClients();
        }

        /// <summary>
        /// Evento que lanza el formulario para crear un nuevo Cliente
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Objeto del evento</param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            Form frmNew = new frmNuevoCliente();
            frmNew.ShowDialog();
        }

        /// <summary>
        /// Evento que lanza el borrado de clientes. Recoje el cliente seleccionado en la DataGridiew y lo elimina de la BBDD mediante LINQ
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Objeto del evento</param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count != 0)
                {
                    int idCliente = Convert.ToInt16(dgv.SelectedRows[0].Cells["idCliente"].Value.ToString());
                    EntityModel.cliente tmpC = new EntityModel.cliente();
                    var cliente = from cli in context.cliente
                                  where cli.id == idCliente
                                  select cli;
                    foreach (var v in cliente)
                    {
                        tmpC = v;
                    }

                    tmpC.inactivo = true;


                    EntityModel.usuario tmpU = new EntityModel.usuario();

                    var user = from us in context.usuario
                               where us.id == idCliente
                               select us;
                    foreach (var val in user)
                    {
                        tmpU = val;
                    }

                    tmpU.inactivo = true;
                    context.SaveChanges();
                    txtError.setOK("Cliente Borrado correctamente.");
                    loadAllClients();
                }
            }
            catch (Exception exx)
            {
                Console.WriteLine(exx.Message);
                txtError.setError("Error Borrando Cliente.");
            }
        }

        /// <summary>
        /// Evento que recoje el cliente seleccionado y lo envia al formulario de Nuevo Cliente para modificarlo
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Objeto del evento</param>
        private void btnMod_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0 && dgv.SelectedRows.Count <= 1)
            {
                Form frmEdit = new frmNuevoCliente(Convert.ToInt16(dgv.SelectedRows[0].Cells["idCliente"].Value.ToString()));
                frmEdit.ShowDialog();
            }
        }

        /// <summary>
        /// Evento que llama al metodo que  filtra los resultados de la DataGridView
        /// </summary>
        /// <param name="sender">Objeto del evento</param>
        /// <param name="e">Objeto del evento</param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtrarGrid();
        }

        #endregion

        #region "Metodos"

        /// <summary>
        /// Metodo que carga en la DataGridView todos los Clientes.
        /// </summary>
        private void loadAllClients()
        {
            var clientes = from cli in context.cliente
                           where cli.inactivo == false
                           select new
                            {
                                idCliente = cli.id,
                                Cliente = cli.nombre + " " + cli.apellidos,
                                Telefono = cli.telefono,
                                Direccion = cli.direccion,
                                Correo = cli.mail,
                                DNI = cli.dni,
                                FechaNacimiento = cli.fechaNacimiento,
                                Activo = (cli.inactivo == true) ? "NO" : "SI"

                            };
            this.dgv.DataSource = clientes;
            ocultarId();

        }


        /// <summary>
        /// Metodo sobreescrito que oculta los IDs de la DataGridView
        /// </summary>
        public override void ocultarId()
        {
            if (dgv.Columns.Contains("id"))
            {
                dgv.Columns["id"].Visible = false;
            }
            else if (dgv.Columns.Contains("idCliente"))
            {
                dgv.Columns["idCliente"].Visible = false;
            }
        }


        /// <summary>
        /// Metodo que filtra los datos de le DataGridView mediante SQL y el Objeto AccDatos.OLEDBCON
        /// Para construir las condiciones de la consulta utiliza el metodo buildWhere()
        /// </summary>
        public override void filtrarGrid()
        {

            AccDatos.OLEDBCON conn = new AccDatos.OLEDBCON();
            this.dgv.DataSource = conn.LanzarConsultaT("SELECT * FROM CLIENTE WHERE 1=1" + buildWhere());
            ocultarId();
        }

        /// <summary>
        /// Metodo que construye las condiciones de filtro a partir de los filtros. 
        /// </summary>
        /// <returns>String con las condiciones hechas</returns>
        private String buildWhere()
        {
            String where = " ";
            if (txtApellidos.ValidValue != "")
            {
                where += " and apellidos like '%" + txtApellidos.ValidValue + "%'";
            }
            if (txtDireccion.ValidValue != "")
            {
                where += " and direccion like '%" + txtDireccion.ValidValue + "%'";
            }
            if (txtDNI.ValidValue != "")
            {
                where += " and dni like '%" + txtDNI.ValidValue + "%'";
            }
            if (txtMail.ValidValue != "")
            {
                where += " and mail like '%" + txtMail.ValidValue + "%'";
            }
            if (txtNombre.ValidValue != "")
            {
                where += " and nombre like '%" + txtNombre.ValidValue + "%'";
            }
            if (txtPoblacion.ValidValue != "")
            {
                where += " and poblacion like '%" + txtPoblacion.ValidValue + "%'";
            }
            if (txtTelefono.ValidValue != "")
            {
                where += " and telefono like '%" + txtTelefono.ValidValue + "%'";
            }
            if (chkActivos.Checked)
            {
                where += " and inactivo = 0 ";
            }
            return where;
        }

        #endregion
    }
}
