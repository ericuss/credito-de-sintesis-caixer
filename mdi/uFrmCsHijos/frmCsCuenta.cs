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
        public String strEntidad = "";
        public String strOficina = "";
        public String strControl = "";
        public String strCuenta = "";
        public frmCsCuenta()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.strSelect = " cuenta.id, codigoEntidad as Entidad, codigoOficina as Oficina, codigoControl as Control, codigoCuenta as Cuenta, cuenta.saldo as Saldo ";
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
        public override void drDoubleClick()
        {
            dr = dgv.SelectedRows[0];
            strEntidad = dr.Cells["Entidad"].Value.ToString();
            strOficina = dr.Cells["Oficina"].Value.ToString();
            strControl = dr.Cells["Control"].Value.ToString();
            strCuenta = dr.Cells["Cuenta"].Value.ToString();
            isAceptar = true;
            this.Dispose();
        }
    }
}
