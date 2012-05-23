using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace uFrmCs
{
    /// <summary>
    /// Formculario de consulta - seleccion base
    /// </summary>
    public partial class frmCs : Form
    {
        #region "properties"
        /// <summary>
        /// Si se ha pulsado el boton de aceptar
        /// </summary>
        public Boolean isAceptar = false;
        /// <summary>
        /// Datatable con los datos de la tabla
        /// </summary>
        public DataTable dt;
        /// <summary>
        /// Se le pasan si tiene id que no se tengan que ver
        /// </summary>
        public String idVisible;
        /// <summary>
        /// Id que retorna
        /// </summary>
        public string id = "";
        /// <summary>
        /// DataRow seleccionada
        /// </summary>
        public DataGridViewRow dr;
        /// <summary>
        /// Campos que se ocultan
        /// </summary>
        public String camposOcultos = "id";
        /// <summary>
        /// Si quieres un select diferente a *
        /// </summary>
        public String strSelect = "";
        /// <summary>
        /// From de la query
        /// </summary>
        public String strFrom = "";
        /// <summary>
        /// Si quieres un where complementario
        /// </summary>
        public String strWhere = "";
        #endregion
        #region "new"
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public frmCs()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new KeyEventHandler(frmCs_KeyUp);
        }
        /// <summary>
        /// Constructor pasandole el datatable con los datos
        /// </summary>
        /// <param name="dtOriginal">DataTable con los datos</param>
        public frmCs(DataTable dtOriginal)
        {
            dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);
            InitializeComponent();
            dt = dtOriginal;
            this.KeyPreview = true;
            this.KeyUp += new KeyEventHandler(frmCs_KeyUp);
            filtrar();


        }
        /// <summary>
        /// Constructor pasandole el datatable con los datos y los id's no visibles
        /// </summary>
        /// <param name="dtOriginal">DataTable con los datos</param>
        /// <param name="idVis">Id's no visibles</param>
        public frmCs(DataTable dtOriginal, String idVis)
        {
            InitializeComponent();
            dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);

            this.KeyPreview = true;
            dt = dtOriginal;
            idVisible = idVis;
            this.KeyUp += new KeyEventHandler(frmCs_KeyUp);
            filtrar();

        }
        /// <summary>
        /// Constructor pasandole el datatable con los datos, los id's no visibles y los campos ocultos
        /// </summary>
        /// <param name="dtOriginal">DataTable con los datos</param>
        /// <param name="idVis">Id's no visibles</param>
        /// <param name="caposOcultos">Campos que se tienen que ocultar</param>
        public frmCs(DataTable dtOriginal, String idVis, String caposOcultos)
        {
            InitializeComponent();
            dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);

            this.KeyPreview = true;
            this.KeyUp += new KeyEventHandler(frmCs_KeyUp);

            dt = dtOriginal;
            idVisible = idVis;
            camposOcultos = caposOcultos;
            filtrar();

        }
        /// <summary>
        /// Constructor pasandole el datatable con los datos, los id's no visibles, los campos ocultos, el from y el where para filtrar
        /// </summary>
        /// <param name="dtOriginal">DataTable con los datos</param>
        /// <param name="idVis">Id's no visibles</param>
        /// <param name="caposOcultos">Campos que se tienen que ocultar</param>
        /// <param name="from">From para filtrar</param>
        /// <param name="where">Where complementario para filtrar</param>
        public frmCs(DataTable dtOriginal, String idVis, String caposOcultos, String from, String where)
        {
            InitializeComponent();
            dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);

            this.KeyUp += new KeyEventHandler(frmCs_KeyUp);
            this.KeyPreview = true;
            strFrom = from;
            strWhere = where;
            dt = dtOriginal;
            idVisible = idVis;
            camposOcultos = caposOcultos;
            filtrar();

        }
        /// <summary>
        /// Constructor pasandole el datatable con los datos, los id's no visibles, los campos ocultos, el from para filtrar
        /// </summary>
        /// <param name="dtOriginal">DataTable con los datos</param>
        /// <param name="idVis">Id's no visibles</param>
        /// <param name="caposOcultos">Campos que se tienen que ocultar</param>
        /// <param name="from">From para filtrar</param>
        public frmCs(DataTable dtOriginal, String idVis, String caposOcultos, String from)
        {
            InitializeComponent();
            dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);

            this.KeyUp += new KeyEventHandler(frmCs_KeyUp);
            this.KeyPreview = true;
            strFrom = from;
            dt = dtOriginal;
            idVisible = idVis;
            camposOcultos = caposOcultos;
            filtrar();

        }
        #endregion
        #region "Load"
        /// <summary>
        /// Load del formulario podra el datasource de la grid y ocultara el campo id de base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void frmCs_Load(object sender, EventArgs e)
        {
            filtrar();
            if (dt != null)
            {
                dgv.DataSource = dt;
            }
            if (dgv.Columns.Contains("id"))
            {
                dgv.Columns["id"].Visible = false;
            }
        }
        #endregion
        #region "Eventos"
        /// <summary>
        /// Si pulsas la tecla F3 filtrara el contenido
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        void frmCs_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "114")
            {
                filtrar();
            }
        }
        /// <summary>
        /// DataGrid que devuelve el Datarow seleccionado o el id
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        public void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            drDoubleClick();
        }
        /// <summary>
        /// En desuso
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        public void btnAceptar_Click(object sender, EventArgs e)
        {
            isAceptar = true;
            this.Dispose();
        }
        /// <summary>
        /// Sale del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnCancel_Click(object sender, EventArgs e)
        {
            // isAceptar = false;
            this.Dispose();
        }
        /// <summary>
        /// Filtra la grid
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtrar();
        }
        #endregion 
        #region "Metodos"
        /// <summary>
        /// Oculta los campos que le has indicado en el constructor
        /// </summary>
        public void ocultarId()
        {
            foreach (String strCampo in camposOcultos.Split(Convert.ToChar(",")))
            {
                if (dgv.Columns.Contains(strCampo))
                {
                    dgv.Columns[strCampo].Visible = false;
                }
            }
        }
        /// <summary>
        /// Funcion para filtrar totalmente dinamica
        /// </summary>
        public void filtrar()
        {
            try
            {
                String strQuery = "";
                if (strSelect == "")
                {
                    strQuery = "Select * from " + strFrom + " where 1=1 " + strWhere + montarWhere();
                }
                else
                {
                    strQuery = "Select " + strSelect + " from " + strFrom + " where 1=1 " + strWhere + montarWhere();
                }
             
            AccDatos.OLEDBCON oDatos = new AccDatos.OLEDBCON();
            dt=oDatos.LanzarConsultaT(strQuery);
            this.dgv.DataSource = dt;
            }
            catch (Exception)
            {

                
            }
        }
        /// <summary>
        /// Monta el where del filtro
        /// </summary>
        /// <returns>Devuelve el where</returns>
        public String montarWhere()
        {
            String strMontarWhere = "";
            foreach (object item in this.Controls)
            {
                if (item.GetType().ToString() == "CustomValidatorTextBox.CustomValidatorTextBox" && ((CustomValidatorTextBox.CustomValidatorTextBox)item).Tag.ToString() == "filtro" && ((CustomValidatorTextBox.CustomValidatorTextBox)item).Text.Length > 0)
                {
                    strMontarWhere += " and " + ((CustomValidatorTextBox.CustomValidatorTextBox)item).zzCampoBd + " like '%" + ((CustomValidatorTextBox.CustomValidatorTextBox)item).Text + "%' ";

                }
                else if ( item.GetType().ToString() == "customTextCs.txtBuscar" && ((customTextCs.txtBuscar)item).zzTxtId != "")
                {
                    strMontarWhere += " and " + ((customTextCs.txtBuscar)item).zzCampoId + " = '" + ((customTextCs.txtBuscar)item).zzTxtId + "' ";
 
                }
            }
            return strMontarWhere;
        }
        /// <summary>
        /// Devuelve el Datarow seleccionado o el id
        /// </summary>
        public virtual void drDoubleClick()
        {
            dr = dgv.SelectedRows[0];
            id = dr.Cells["id"].Value.ToString();
            isAceptar = true;
            this.Dispose();
        }
        #endregion
    }
}
