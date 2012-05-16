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
                               DNI = cli.dni

                           };
            this.dgvCliente.DataSource = clientes;
            
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
    }
}
