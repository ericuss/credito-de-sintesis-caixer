using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic ;

namespace txtCs
{
    public partial class frmCs : Form
    {
        Boolean isAceptar= false;
        DataTable dt;
        public frmCs()
        {
            InitializeComponent();
        }
        public frmCs(DataTable dtOriginal)
        {
            InitializeComponent();
            dt = dtOriginal;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            isAceptar = true;
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isAceptar = false;
            this.Dispose();
        }

        private void frmCs_Load(object sender, EventArgs e)
        {
            if (dt != null)
            {
                dgv.DataSource = dt;
            }
        }
    }
}
