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
        }
        public frmCsCliente(DataTable dtOriginal)
        {
            InitializeComponent();
            dt = dtOriginal;
            dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);
        }

        public frmCsCliente(DataTable dtOriginal, String idVis)
        {
            InitializeComponent();
            idVisible = idVis;
            dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);

        }
        public frmCsCliente(String from, String where)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.strFrom = from;
            this.strWhere = where;
            dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);


        }
        public frmCsCliente(String from)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.strFrom = from;
            dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);

        }

        void frmCsCliente_KeyUp(object sender, KeyEventArgs e)
        {
         
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            filtrar();
        }

      



     

      
    }
}
