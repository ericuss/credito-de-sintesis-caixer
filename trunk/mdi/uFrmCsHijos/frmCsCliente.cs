using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using uFrmCs;

namespace uFrmCsHijos
{
    /// <summary>
    /// Formulario heredado del frmCs(Formulario de consulta-seleccion) para clientes
    /// </summary>
    public partial class frmCsCliente : uFrmCs.frmCs
    {
        #region "New"
        /// <summary>
        /// Contructor sin parametros
        /// </summary>
        public frmCsCliente()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        /// <summary>
        /// Constructor pasandole el DataTable con los datos
        /// </summary>
        /// <param name="dtOriginal">DataTable con los datos</param>
        public frmCsCliente(DataTable dtOriginal)
        {
            InitializeComponent();
            dt = dtOriginal;
            dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);
        }
        /// <summary>
        ///  Constructor pasandole el datatable con los datos, los id's no visibles y los campos ocultos
        /// </summary>
        /// <param name="dtOriginal">DataTable con los datos</param>
        /// <param name="idVis">Id's no visibles</param>
        public frmCsCliente(DataTable dtOriginal, String idVis)
        {
            InitializeComponent();
            idVisible = idVis;
            dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);

        }
        /// <summary>
        ///  Constructor pasandole el From y el where complementario
        /// </summary>
        /// <param name="from">From</param>
        /// <param name="where">Where Complementario</param>
        public frmCsCliente(String from, String where)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.strFrom = from;
            this.strWhere = where;
            dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);


        }
        /// <summary>
        /// Constructor pasandole el From 
        /// </summary>
        /// <param name="from">From</param>
        public frmCsCliente(String from)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.strFrom = from;
            dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);

        }
        #endregion
        #region "Evento"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtrar();
        }
        #endregion
    }
}
