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
    public partial class frmCs : Form
    {
        #region "properties"
        public Boolean isAceptar = false;
        public DataTable dt;
        public String idVisible;
        public string id = "";
        public DataGridViewRow dr;
        public String camposOcultos = "id";
        public String strFrom = "";
        public String strWhere = "";
        #endregion
        #region "new"
        public frmCs()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new KeyEventHandler(frmCs_KeyUp);
        }
        public frmCs(DataTable dtOriginal)
        {
            dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);
            InitializeComponent();
            dt = dtOriginal;
            this.KeyPreview = true;
            this.KeyUp += new KeyEventHandler(frmCs_KeyUp);
            filtrar();


        }
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
        void frmCs_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "114")
            {
                filtrar();
            }
        }
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


        public void filtrar()
        {
            try
            {

           
            String strQuery = "Select * from " + strFrom + " where 1=1 " + strWhere + montarWhere();
            AccDatos.OLEDBCON oDatos = new AccDatos.OLEDBCON();
            dt=oDatos.LanzarConsultaT(strQuery);
            this.dgv.DataSource = dt;
            }
            catch (Exception)
            {

                
            }
        }
        public String montarWhere()
        {
            String strMontarWhere = "";
            foreach (object item in this.Controls)
            {
                if (item.GetType().ToString() == "CustomValidatorTextBox.CustomValidatorTextBox" && ((CustomValidatorTextBox.CustomValidatorTextBox)item).Tag == "filtro" && ((CustomValidatorTextBox.CustomValidatorTextBox)item).Text.Length > 0)
                {
                    strMontarWhere += " and " + ((CustomValidatorTextBox.CustomValidatorTextBox)item).zzCampoBd + " like '%" + ((CustomValidatorTextBox.CustomValidatorTextBox)item).Text + "%' ";

                }
            }
            return strMontarWhere;
        }
        public void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dr = dgv.SelectedRows[0];
            id = dr.Cells["id"].Value.ToString();
            isAceptar = true;
            this.Dispose();
        }

        public void btnAceptar_Click(object sender, EventArgs e)
        {
            isAceptar = true;
            this.Dispose();
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            // isAceptar = false;
            this.Dispose();
        }

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

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            filtrar();
        }
    }
}
