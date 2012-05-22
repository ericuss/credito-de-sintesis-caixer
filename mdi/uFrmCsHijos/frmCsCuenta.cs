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
    /// <summary>
    /// Formulario heredado del frmCs(Formulario de consulta-seleccion) para cuentas
    /// </summary>
    public partial class frmCsCuenta : uFrmCs.frmCs
    {
        #region "Propiedades"
        /// <summary>
        /// Entidad seleccionada
        /// </summary>
        public String strEntidad = "";
        /// <summary>
        /// Oficina seleccionada
        /// </summary>
        public String strOficina = "";
        /// <summary>
        /// Control seleccionado
        /// </summary>
        public String strControl = "";
        /// <summary>
        /// Cuenta seleccionada
        /// </summary>
        public String strCuenta = "";
        #endregion
        #region "New"
        /// <summary>
        /// Constructor vacio
        /// </summary>
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
        /// <summary>
        /// Constructor pasandole el From
        /// </summary>
        /// <param name="from">From</param>
        public frmCsCuenta(String from)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.strFrom = from;
            dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);

        }
        /// <summary>
        /// Constructor pasandole el From y el Where complementario
        /// </summary>
        /// <param name="from">From</param>
        /// <param name="where">Where complementario</param>
        public frmCsCuenta(String from, String where)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.strFrom = from;
            this.strWhere = where;
            dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);
        }
        #endregion
        #region "Eventos Sobreescritos"
        /// <summary>
        /// Metodo sobreescrito del padre para rellenar las propiedades
        /// </summary>
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
        #endregion
    }
}
