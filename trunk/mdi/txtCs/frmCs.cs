﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic ;

namespace uFrmCs
{
    public partial class frmCs : Form
    {
        public Boolean isAceptar= false;
         public DataTable dt;
        public String idVisible;
        public string id = "";
        public DataGridViewRow dr;
        public frmCs()
        {
            InitializeComponent();
        }
        public frmCs(DataTable dtOriginal)
        {
            InitializeComponent();
            dt = dtOriginal;
            

        }
        public frmCs(DataTable dtOriginal, String idVis )
        {
            InitializeComponent();
            dgv.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgv_RowHeaderMouseDoubleClick);


            dt = dtOriginal;
           idVisible= idVis;

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
    }
}
