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
                           where cli.inactivo==false
                           select new
                            {
                                idCliente = cli.id,
                                Cliente = cli.nombre + " " + cli.apellidos,
                                Telefono = cli.telefono,
                                Direccion = cli.direccion,
                                Correo = cli.mail,
                                DNI = cli.dni,
                                FechaNacimiento = cli.fechaNacimiento

                            };
            this.dgv.DataSource = clientes;
            this.dgv.Columns["idCliente"].Visible = false;

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
                int idCliente =Convert.ToInt16(dgv.SelectedRows[0].Cells["idCliente"].Value.ToString());
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
    }
}
