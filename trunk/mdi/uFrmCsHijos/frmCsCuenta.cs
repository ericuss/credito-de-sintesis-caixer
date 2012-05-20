using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace uFrmCsHijos
{
    public partial class frmCsCuenta : uFrmCs.frmCs
    {
        public frmCsCuenta()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.strFrom = " cuenta " +
                            " join cuentacliente on cuenta.id = cuentacliente.idCuenta " +
                            " join cliente on cliente.id = cuentacliente.idCliente ";
            
            dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);
        }
        public frmCsCuenta(String from)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.strFrom = from;
            dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);

        }
        public frmCsCuenta(String from, String where)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.strFrom = from;
            this.strWhere = where;
            dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);

        }
    }
}
