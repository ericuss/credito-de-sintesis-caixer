using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cliente
{
    public partial class frmMantCliente : Base.Base
    {
        public frmMantCliente()
        {
            InitializeComponent();
        }

        private void frmMantCliente_Load(object sender, EventArgs e)
        {
            loadAllClients();
        }

        private void loadAllClients()
        {
        
        }
    }
}
