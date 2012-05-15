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
                           select new
                            {
                                idCliente = cli.id,
                                Cliente = cli.nombre + " " + cli.apellidos,
                                Telefono = cli.telefono,
                                Direccion = cli.direccion,
                                Correo = cli.mail,
                                DNI = cli.dni,
                                FechaNacimiento =cli.fechaNacimiento

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
               String idCliente= dgv.SelectedRows[0].Cells["idCliente"].Value.ToString();
            }
        }
    }
}
