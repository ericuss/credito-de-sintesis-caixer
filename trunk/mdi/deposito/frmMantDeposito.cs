using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace deposito
{
    public partial class frmMantDeposito : Base.Base
    {
        public frmMantDeposito()
        {
            InitializeComponent();
            tablaBBDD = "deposito";
        }

        public override void ocultarId()
        {
            dgv.Columns["id"].Visible = false;
        }

      

       
    }
}
