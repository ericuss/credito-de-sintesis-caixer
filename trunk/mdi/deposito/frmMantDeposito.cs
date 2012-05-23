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
	/// <summary>
	///  Formulario que hereda del Base.
	/// Nos Permite implementar un mantenimiento de una tabla de la BBDD muy rapidamente
	/// </summary>
    public partial class frmMantDeposito : Base.Base
    {
    	/// <summary>
    	/// Constructor. Inicializa la propiedad tablaBBDD para poder ser bindeada la dataGridView del base.
    	/// Informa el titulo del formulario.
    	/// </summary>
        public frmMantDeposito()
        {
            InitializeComponent();
            tablaBBDD = "deposito";
            this.strTitulo = "Depositos";
        }

        /// <summary>
        /// Metodo sobreescrito que oculta el campo identificador de la tabla
        /// </summary>
        public override void ocultarId()
        {
            dgv.Columns["id"].Visible = false;
        }
    }
}
