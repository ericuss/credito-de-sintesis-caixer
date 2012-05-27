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
    /// <summary>
    /// Formulario que nos permite Aceptar o denegar las Solicitudes de Prestmos
    /// </summary>
    public partial class frmSolPrestamo : Form
    {
        #region "Variables Privadas"
        private int idFinalidad;
        private int idCuenta;
        private int idCliente;
        private int idSolicitud;
        private santanderEntities1 context = new santanderEntities1();

        #endregion

        #region "Constructores"

        /// <summary>
        /// Constructor vacio del Formulario
        /// </summary>
        public frmSolPrestamo()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmSolPrestamo_Load);
        }

        /// <summary>
        /// Constrctor que inicializa idCliente, idCuenta, e idSol
        /// </summary>
        /// <param name="idCLiente">Id del Cliente</param>
        /// <param name="idCuenta">Id de la Cuenta</param>
        /// <param name="idSol">Id de la Solicitud</param>
        public frmSolPrestamo(String idCLiente, String idCuenta, String idSol)
        {
            InitializeComponent();

            this.idCliente = Convert.ToInt16(idCLiente);
            this.idCuenta = Convert.ToInt16(idCuenta);
            this.idSolicitud = Convert.ToInt16(idSol);
            this.Load += new EventHandler(frmSolPrestamo_Load);
            this.dgvCuentas.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dgvCuentas_RowHeaderMouseClick);
            disableIfNecessary();
        }

        #endregion

        #region "Eventos"

        /// <summary>
        /// Evento que es ejecutado cuando se muestra el Formularo. 
        /// Rellena todos los campos del Formulario a traves de las funciones.
        /// </summary>
        /// <param name="sender">Parametro del Evento</param>
        /// <param name="e">Parametro del Evento</param>
        void frmSolPrestamo_Load(object sender, EventArgs e)
        {
            loadResumen();
            loadPersonalData();
            loadCuentas();
            loadAcciones();
            loadHistoricoAcciones();
        }

        /// <summary>
        /// Evento que es ejecutado al hacer DobleClick sobre la cabecera de cada linia.
        /// Al hacer DobleClick carga en la otra grid los movimientos de la cuenta seleccionada
        /// </summary>
        /// <param name="sender">Parametro del Evento</param>
        /// <param name="e">Parametro del Evento</param>
        private void dgvCuentas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idCuenta = Convert.ToUInt16(dgvCuentas.SelectedRows[0].Cells["IDCU"].Value.ToString());
            var movs = from mv in context.movimiento
                       where mv.idCuenta == idCuenta
                       orderby mv.fecha descending
                       select new
                       {
                           Fecha = mv.fecha,
                           Importe = mv.importe,
                           Descripcion = mv.descripcion,
                           Resto = mv.resto
                       };
            this.dgvMovimientos.DataSource = movs;
        }

        /// <summary>
        /// Evento que se lanza al pulsar el boton Mantener.
        /// Cierra el Formulario sin hacer cambios
        /// </summary>
        /// <param name="sender">Parametro del Evento</param>
        /// <param name="e">Parametro del Evento</param>
        private void btnMantener_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Evento que se ejecuta al hacer click sobre el boton "Aceptar".
        /// El objetivo es aceptar la solicitud del Prestamo. 
        /// Mediante LINQ cambia el estado de la solicitud, añade el registro correspondiente en la tabla movimientos y notifica al usuario.
        /// </summary>
        /// <param name="sender">Parametro del Evento</param>
        /// <param name="e">Parametro del Evento</param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                //crar movimiento
                Decimal imp = Convert.ToDecimal(txtImporteSol.Text);
                movimiento mov = new movimiento()
                {
                    idCuenta = idCuenta,
                    fecha = DateTime.Now,
                    importe = imp,
                    concepto = "Prestamo",
                    descripcion = "Prestamo de " + imp + "€"
                };

                //aceptar solicitud
                solicitud sol = new solicitud();
                var tmpsol = from ss in context.solicitud
                             where ss.id == idSolicitud
                             select ss;
                foreach (var item in tmpsol)
                {
                    sol = item;
                }
                sol.idEstadoSolicitud = 2;

                context.AddTomovimiento(mov);

                prestamo pres = new prestamo();
                var tpres = from pr in context.prestamo
                            where pr.idSolicitud == idSolicitud && pr.idCliente == idCliente && pr.idCuenta == idCuenta
                            select pr;
                foreach (var item in tpres)
                {
                    pres = item;
                }
                pres.activo = true;


                context.SaveChanges();
                //notificar
                tools.clsTools.addNotificacion("Se ha aceptado la solicitud del prestamo con un importe de " + imp, "Prestamo Aceptado", idCliente);
                this.Dispose();
            }
            catch (Exception exx)
            {
                txtError.setError(exx.ToString());
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer click cobre el boton "Denegar".
        /// El objetivo es denegar la solicitud de Prestamo. 
        /// Mediante LINQ cambia el estad de la solicitud y crea la notificacion para el usuario.
        /// </summary>
        /// <param name="sender">Parametro del Evento</param>
        /// <param name="e">Parametro del Evento</param>
        private void btnDenegar_Click(object sender, EventArgs e)
        {
            try
            {
                prestamo pres = new prestamo();
                var tpres = from pr in context.prestamo
                            where pr.idSolicitud == idSolicitud && pr.idCliente == idCliente && pr.idCuenta == idCuenta
                            select pr;
                foreach (var item in tpres)
                {
                    pres = item;
                }

                pres.activo = false;

                solicitud sol = new solicitud();
                var tmpSol = from ss in context.solicitud
                             where ss.id == idSolicitud
                             select ss;
                foreach (var item in tmpSol)
                {
                    sol = item;
                }
                sol.idEstadoSolicitud = 4;
                context.SaveChanges();
                tools.clsTools.addNotificacion("Se le ha denegado el denegado el prestamo con un importe de " + txtImporteSol.Text, "Prestamo denegado", idCliente);
                this.Dispose();
            }
            catch (Exception exx)
            {
                Console.WriteLine(exx.Message);
                txtError.setError("Error al denegar Prestamo");
            }
        }

        #endregion

        #region "Metodos"

        /// <summary>
        /// Metodo que deshabilita los botones "Aceptar" y "Denegar" en el caso de que no sean necesarios
        /// porque la solicitud ya este aceptada o denegada.
        /// </summary>
        private void disableIfNecessary()
        {
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

        /// <summary>
        /// Metodo que rellena los datos de la pestaña de "Resumen".
        /// Carga los datos del prestamo solicitado y los del cliente que lo solicitó.
        /// Lo realiza a traves de LINQ
        /// </summary>
        private void loadResumen()
        {

            var pres = from pr in context.prestamo
                       join fin in context.finalidadprestamo
                        on pr.idFinalidad equals fin.id
                       join cli in context.cliente
                       on pr.idCliente equals cli.id
                       join cu in context.cuenta
                       on pr.idCuenta equals cu.id
                       join sol in context.solicitud
                         on pr.idSolicitud equals sol.id
                       where pr.idCliente == idCliente && pr.idCuenta == idCuenta && pr.idSolicitud == idSolicitud
                      
                       select new
                       {
                           Finalidad = fin.tag,
                           idFin = fin.id,
                           Importe = pr.importe,
                           Cuota = pr.cuota,
                           Plazo = pr.plazo,
                           Saldo = cu.saldo,
                           Fecha = sol.fecha
                       };
            foreach (var item in pres)
            {
                txtFinalidad.Text = item.Finalidad.ToString();
                idFinalidad = item.idFin;
                txtImporteSol.Text = item.Importe.ToString();
                txtSaldo.Text = item.Saldo.ToString();
                if (item.Plazo != null)
                {
                    txtPlazo.Text = item.Plazo.ToString();
                }
                if (item.Cuota != null)
                {
                    txtCuota.Text = item.Cuota.ToString();
                }
                txtFechaP.Text = item.Fecha.ToString();
            }



        }

        /// <summary>
        /// Metodo que carga el Historico de acciones de la pestaña "Acciones".
        /// Lo hace a traves de LINQ
        /// </summary>
        private void loadHistoricoAcciones()
        {
            var his = from hist in context.historicoinversion
                      join emp in context.empresa
                         on hist.idEmpresa equals emp.id
                      where hist.idCliente == idCliente
                      select new
                      {
                          Empresa = emp.nombre,
                          Cantidad = hist.cantidad,
                          PrecioCompra = hist.valorCompra,
                          PrecioVenta = hist.valorVenta,
                          Fecha = hist.fecha,
                          CompraVenta = (hist.compraVenta == false) ? "Compra" : "Venta"
                      };
            this.dgvHistAcciones.DataSource = his;
        }

        /// <summary>
        /// Carga la informacion de Acciones de la pestaña "Acciones"
        /// Lo hace a traves de LINQ
        /// </summary>
        private void loadAcciones()
        {
            var acc = from ac in context.accion
                      join emp in context.empresa
                        on ac.idEmpresa equals emp.id
                      where ac.idCliente == idCliente
                      select new
                      {
                          Empresa = emp.nombre,
                          Cantidad = ac.cantidad,
                          PrecioCompra = ac.valorCompra,
                          PrecioVenta = emp.valor

                      };
            this.dgvAcciones.DataSource = acc;
        }

        /// <summary>
        /// Metodo que carga las cuentas del Usuario.
        /// Lo hce a traves de LINQ
        /// </summary>
        private void loadCuentas()
        {
            var cuentas = from cue in context.cuenta
                          join cuec in context.cuentacliente
                            on cue.id equals cuec.idCuenta
                          where cuec.idCliente == idCliente

                          select new
                          {
                              Cuenta = cue.codigoEntidad + " - " + cue.codigoOficina + " - " + cue.codigoControl + " - " + cue.codigoCuenta,
                              Saldo = cue.saldo,
                              IDCU = cue.id
                          };
            this.dgvCuentas.DataSource = cuentas;
            this.dgvCuentas.Columns["IDCU"].Visible = false;
        }

        /// <summary>
        /// Metodo que carga los datos personales del Cliente. 
        /// Lo hace a traves de LINQ
        /// </summary>
        private void loadPersonalData()
        {

            var pdata = from cli in context.cliente
                        where cli.id == idCliente
                        select new
                        {
                            DNI = cli.dni,
                            Nombre = cli.nombre,
                            Apellido = cli.apellidos,
                            Telefono = cli.telefono,
                            Poblacion = cli.poblacion,
                            Correo = cli.mail
                        };


            foreach (var item in pdata)
            {
                txtDNI.Text = item.DNI;
                txtNombre.Text = item.Nombre;
                txtApellidos.Text = item.Apellido;
                txtPoblacion.Text = item.Poblacion;
                txtTelefono.Text = item.Telefono;
                txtCorreo.Text = item.Correo;
            }
        }

        #endregion

        private void frmSolPrestamo_Load_1(object sender, EventArgs e)
        {
            loadResumen();
            loadPersonalData();
            loadCuentas();
            loadAcciones();
            loadHistoricoAcciones();
        }

    }
}
