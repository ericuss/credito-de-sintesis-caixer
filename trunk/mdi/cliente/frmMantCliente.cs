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
    public partial class frmMantCliente : Base.Base
    {
        santanderEntities1 context = new santanderEntities1();
        public frmMantCliente()
        {
            InitializeComponent();
        }

        private void frmMantCliente_Load(object sender, EventArgs e)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            loadAllClients();
        }


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
            

        }

        public override void ocultarId()
        {
            if (dgv.Columns.Contains("id"))
            {
               dgv.Columns["id"].Visible = false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form frmNew = new frmNuevoCliente();
            frmNew.MdiParent = this.MdiParent;
            frmNew.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
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
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0 && dgv.SelectedRows.Count <= 1)
            {
                Form frmEdit = new frmNuevoCliente(Convert.ToInt16(dgv.SelectedRows[0].Cells["idCliente"].Value.ToString()));
                frmEdit.MdiParent = this.MdiParent;
                frmEdit.Show();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtrarGrid();
        }

        public override void filtrarGrid()
        {

            AccDatos.OLEDBCON conn = new AccDatos.OLEDBCON();
            this.dgv.DataSource = conn.LanzarConsultaT("SELECT * FROM CLIENTE WHERE 1=1" + buildWhere());
        }

        private String buildWhere()
        {
            String where = " ";
            if (txtApellidos.Text != "")
            {
                where += " and apellidos like '%" + txtApellidos.Text + "%'";
            }
            if (txtDireccion.Text != "")
            {
                where += " and direccion like '%" + txtDireccion.Text + "%'";
            }
            if (txtDNI.Text != "")
            {
                where += " and dni like '%" + txtDNI.Text + "%'";
            }
            if (txtMail.Text != "")
            {
                where += " and mail like '%" + txtMail.Text + "%'";
            }
            if (txtNombre.Text != "")
            {
                where += " and nombre like '%" + txtNombre.Text + "%'";
            }
            if (txtPoblacion.Text != "")
            {
                where += " and poblacion like '%" + txtPoblacion.Text + "%'";
            }
            if (txtTelefono.Text != "")
            {
                where += " and telefono like '%" + txtTelefono.Text + "%'";
            }
            if (chkActivos.Checked)
            {
                where += " and inactivo = 0 ";
            }
            return where;
        }
    }
}
