using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntityModel;

namespace solicitudes
{
    public partial class frmSolicitudTarjeta : Form
    {
        private Int16 idCliente;
        private Int16 idCuenta;
        private int idSolicitud;


        public frmSolicitudTarjeta()
        {
            InitializeComponent();
        }


        public frmSolicitudTarjeta(String idCliente, String idCuenta, String idSol)
        {
            InitializeComponent();
            this.idCliente = Convert.ToInt16(idCliente);
            this.idCuenta = Convert.ToInt16(idCuenta);
            this.idSolicitud = Convert.ToInt16(idSol);
            fillTextbox();
            fillTextCuenta();
            disableIfNecessary();
        }

        private void disableIfNecessary()
        {
           
            santanderEntities1 context = new santanderEntities1();
            var sol = from ss in context.solicitud
                      where ss.id == idSolicitud
                      select ss;
            foreach (var item in sol)
            {
                if (item.idEstadoSolicitud != 1)
                {
                    btnAceptar.Visible = false;
                    btnDenegar.Visible = false;
                    btnMantener.Text = "Cerrar";
                }
            }
        }



        private void fillTextCuenta()
        {
            int idcl = idCuenta;
            santanderEntities1 context = new santanderEntities1();

            var centas = from cue in context.cuenta
                         join cuc in context.cuentacliente
                           on cue.id equals cuc.idCuenta
                         join cli in context.cliente
                           on cuc.idCliente equals cli.id
                         where cue.id == idcl
                         select new
                         {
                             Saldo = cue.saldo,
                             Cuenta = cue.codigoEntidad + " - " + cue.codigoOficina + " - " + cue.codigoControl + " - " + cue.codigoCuenta,
                             Nombre = cli.nombre,
                             Apellidos = cli.apellidos,
                             DNI = cli.dni
                         };
            dgvTitulares.DataSource = centas;
            this.dgvTitulares.Columns["Cuenta"].Visible = false;
            foreach (var item in centas)
            {
                txtCenta.Text = item.Cuenta;
                txtSaldo.Text = item.Saldo.ToString();
            }
        }

        private void fillTextbox()
        {
            int idcl = idCliente;
            santanderEntities1 context = new santanderEntities1();
            var cliente = from cli in context.cliente
                          where cli.id == idcl
                          select new
                          {
                              DNI = cli.dni,
                              Nombre = cli.nombre,
                              Apellido = cli.apellidos,
                              Telefono = cli.telefono,
                              Poblacion = cli.poblacion,
                              Correo = cli.mail
                          };


            foreach (var item in cliente)
            {
                txtDNI.Text = item.DNI;
                txtNombre.Text = item.Nombre;
                txtApellidos.Text = item.Apellido;
                txtPoblacion.Text = item.Poblacion;
                txtTelefono.Text = item.Telefono;
                txtCorreo.Text = item.Correo;
            }
        }

        private void btnMantener_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            aceptarSolicitud();

        }

        private void aceptarSolicitud()
        {
            santanderEntities1 context = new santanderEntities1();
            solicitud solt = new solicitud();
            var tmpSol = from sol in context.solicitud
                         where sol.idCliente == idCliente &&
                                sol.idCuenta == idCuenta &&
                                sol.id == idSolicitud
                         select sol;
            foreach (var item in tmpSol)
            {
                solt = item;

            }
            solt.idEstadoSolicitud = 2;

            int mon = DateTime.Now.Month;
            String cdigo = genRandCod();
            String yr = (DateTime.Now.Year + 5).ToString().Substring(2,2);
           
            Random r = new Random(DateTime.Now.Millisecond);
            String tcvv = Convert.ToString(r.Next(100, 999));

            //  String titular = txtNombre.Text + " " + txtApellidos.Text;
            tarjeta tmpTarj = new tarjeta
            {
                idCuenta = idCuenta,
                idCliente = idCliente,
                fechaCaducidad = mon + "/" + yr,
                codigo = cdigo,
                cvv = tcvv
            };
            context.AddTotarjeta(tmpTarj);
            notificacion tnot = new notificacion
            {
                idCliente = Convert.ToInt16(idCliente),
                text = "Se ha aceptado la solicitud de la tarjeta para la cuenta " + txtCenta.Text,
                asunto = "Solicitud Tarjeta Acetada",
                fecha = DateTime.Now,
                borrado=false
            };
            context.AddTonotificacion(tnot);
            context.SaveChanges();
            this.Dispose();
        }

        private string genRandCod()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            String tnum = "";
            for (int i = 0; i < 4; i++)
            {
                tnum += "" + r.Next(1000, 9999);
            }

            santanderEntities1 context = new santanderEntities1();

            int num = (from tarj in context.tarjeta
                       where tarj.codigo == tnum
                       select tarj).Count();
            if (num > 0)
            {
                tnum = genRandCod();
            }
            return tnum;
        }

        private void btnDenegar_Click(object sender, EventArgs e)
        {
            santanderEntities1 context = new santanderEntities1();
            solicitud solt = new solicitud();
            var tmpSol = from sol in context.solicitud
                         where sol.idCliente == idCliente &&
                                sol.idCuenta == idCuenta &&
                                sol.id == idSolicitud
                         select sol;
            foreach (var item in tmpSol)
            {
                solt = item;

            }
            solt.idEstadoSolicitud = 4;
            notificacion tnot = new notificacion
            {
                borrado = false,
                leido = false,
                idCliente = Convert.ToInt16(idCliente),
                text = "Se ha denegado la solicitud de la tarjeta para la cuenta " + txtCenta.Text + ". Dirijase a su oficina para mas información.",
                asunto = "Solicitud Tarjeta Denegada",
                fecha = DateTime.Now
            };
            context.AddTonotificacion(tnot);
            context.SaveChanges();
            this.Dispose();
        }








    }
}
