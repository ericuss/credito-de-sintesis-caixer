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
    public partial class frmCsCliente : uFrmCs.frmCs
    {
        public frmCsCliente()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new KeyEventHandler(frmCsCliente_KeyUp);
        }
        public frmCsCliente(DataTable dtOriginal)
        {
            InitializeComponent();

            this.KeyUp += new KeyEventHandler(frmCsCliente_KeyUp);
             dt = dtOriginal;
         }

        public frmCsCliente(DataTable dtOriginal, String idVis)
        {
            InitializeComponent();

            this.KeyUp += new KeyEventHandler(frmCsCliente_KeyUp);
                InitializeComponent();
                       dt = dtOriginal;
           idVisible= idVis;

        }

        void frmCsCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "114")
            {
                filtrarGrid();
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtrarGrid();
        }

        public void filtrarGrid()
        {

            AccDatos.OLEDBCON conn = new AccDatos.OLEDBCON();
            dgv.DataSource = null;
            String strWhere= buildWhere();
            dt = conn.LanzarConsultaT("SELECT * FROM CLIENTE WHERE 1=1 " + strWhere);
            dgv.DataSource = dt;
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
            if (this.txtTelefono.Text != "")
            {
                where += " and telefono like '%" + txtTelefono.Text + "%'";
            }
            if (chkActivos.Checked)
            {
                where += " and inactivo = 0 ";
            }
            return where;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            filtrarGrid();
        }
    }
}
