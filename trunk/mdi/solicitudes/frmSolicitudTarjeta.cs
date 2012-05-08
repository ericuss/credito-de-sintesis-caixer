using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace solicitudes
{
    public partial class frmSolicitudTarjeta : Form
    {
        public frmSolicitudTarjeta()
        {
            InitializeComponent();
        }
        public frmSolicitudTarjeta(String idCliente, String idCuenta)
        {
            InitializeComponent();
            fillTextbox(idCliente);
        }

        private void fillTextbox(string idCliente)
        {
            int idcl = Convert.ToInt32(idCliente);
              santanderEntities1 context = new santanderEntities1();
              var cliente = from cli in context.cliente
                            where cli.id == idcl
                            select new
                            {
                                DNI = cli.dni,
                                Nombre= cli.nombre,
                                Apellido = cli.apellidos,
                                Telefono = cli.telefono,
                                Poblacion = cli.poblacion,
                                Correo = "Algun Dia"
                            };

            
              foreach (var item in cliente)
              {
                  txtDNI.Text = item.DNI;
                  txtNombre.Text = item.Nombre;
                  txtApellidos.Text = item.Apellido;
                  txtPoblacion.Text = item.Poblacion;
                  txtTelefono.Text = item.Telefono;
              }
        }

      

    
    }
}
