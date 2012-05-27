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
    /// Formulario que nos permite administrar las solicitudes de Depositos.
    /// </summary>
    public partial class frmSolDeposito : Form
    {
        #region "Variables Privadas"

        private int idCuenta;
        private int idCliente;
        private int idSolicitud;
        private santanderEntities1 context = new santanderEntities1();

        #endregion

        #region "Constructor"

        /// <summary>
        /// Constructor sin parametros del Formulario
        /// </summary>
        public frmSolDeposito()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmSolDeposito_Load);
        }

        /// <summary>
        /// Constrctor que inicializa idCliente, idCuenta, e idSol
        /// </summary>
        /// <param name="idCLiente">Id del Cliente</param>
        /// <param name="idCuenta">Id de la Cuenta</param>
        /// <param name="idSol">Id de la Solicitud</param>
        public frmSolDeposito(String idCLiente, String idCuenta, String idSol)
        {
            InitializeComponent();

            this.idCliente = Convert.ToInt16(idCLiente);
            this.idCuenta = Convert.ToInt16(idCuenta);
            this.idSolicitud = Convert.ToInt16(idSol);
            this.Load += new EventHandler(frmSolDeposito_Load);
            this.dgvCuentas.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dgvCuentas_RowHeaderMouseClick);
            disableIfNecessary();
        }

        #endregion

        #region "Eventos"

        /// <summary>
        /// Evento que es ejecutado cuando se muestra el Frmularo. 
        /// Rellena todos los campos del Formulario a traves de las funciones.
        /// </summary>
        /// <param name="sender">Parametro del Evento</param>
        /// <param name="e">Parametro del Evento</param>
        void frmSolDeposito_Load(object sender, EventArgs e)
        {
            loadResumen();
            loadPersonalData();
            loadCuentas();
            loadAcciones();
            loadHistoricoAcciones();

        }


        private void frmSolDeposito_Load_1(object sender, EventArgs e)
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
        void dgvCuentas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
        /// Evento que se ejecuta al hacer click sobre el boton "Aceptar".
        /// El objetivo es aceptar la solicitud del Deposito. 
        /// Mediante LINQ cambia el estado de la solicitud, añade el registro correspondiente en la tabla depositocliente, crea un movimiento y una notificacion al usuario.
        /// </summary>
        /// <param name="sender">Parametro del Evento</param>
        /// <param name="e">Parametro del Evento</param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtSaldo.Text == "" || txtImporteSol.Text == "")
            {
                txtError.setError("Error Genral.");

            }
            else if (Convert.ToDouble(txtImporteSol.Text) > Convert.ToDouble(txtSaldo.Text))
            {
                txtError.setError("Saldo en cuenta Insuficiente.");
            }
            else
            {

                solicitud tmpSol = new solicitud();
                var ttsol = from ss in context.solicitud
                            where ss.id == idSolicitud
                            select ss;
                foreach (var item in ttsol)
                {
                    tmpSol = item;
                }
                tmpSol.idEstadoSolicitud = 2;


                depositocliente tmpDepC = new depositocliente();
                var ttdepc = from dd in context.depositocliente
                             where dd.idSolicitud == idSolicitud
                             select dd;
                foreach (var item in ttdepc)
                {
                    tmpDepC = item;
                }


                tmpDepC.activo = true;
                tmpDepC.fechaActivacion = DateTime.Now;
                tmpDepC.fechaVencimiento = DateTime.Now.AddMonths(Convert.ToInt16(txtPlazos.Text));
                Decimal imp = Convert.ToDecimal(txtImporteSol.Text);

                movimiento mov = new movimiento()
                {
                    idCuenta = idCuenta,
                    fecha = DateTime.Now,
                    importe = imp * (-1),
                    concepto = "Deposito",
                    descripcion = "Aceptacion de la solicitud del deposito de " + txtImporteSol.Text + "€ a " + txtPlazos.Text + " meses."
                };


                tools.clsTools.addNotificacion("Se ha aceptado la solicitud del deposito con el importe de " + txtImporteSol.Text + " con un TAE de " + txtTAE.Text + ".", "Solicitud de Deposito Aceptado", idCliente);

                context.AddTomovimiento(mov);
                context.SaveChanges();

                this.Dispose();
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer click cobre el boton "Denegar".
        /// El objetivo es denegar la solicitud de Deposito. 
        /// Mediante LINQ cambia el estad de la solicitud, borra la relacion en depositocliente y crea la notificacion para el usuario.
        /// </summary>
        /// <param name="sender">Parametro del Evento</param>
        /// <param name="e">Parametro del Evento</param>
        private void btnDenegar_Click(object sender, EventArgs e)
        {
            santanderEntities1 context = new santanderEntities1();

            depositocliente dc = new depositocliente();
            var tmodc = from tdc in context.depositocliente
                        where tdc.idSolicitud == idSolicitud &&
                              tdc.idCliente == idCliente &&
                              tdc.idCuenta == idCuenta
                        select tdc;
            foreach (var item in tmodc)
            {
                dc = item;
            }

            context.DeleteObject(dc);

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
                idCliente = idCliente,
                text = "Se ha denegado la solicitud de Deposito con el importe de " + txtImporteSol.Text + ". Dirijase a su oficina para mas información.",
                asunto = "Solicitud de Deposito Denegado",
                fecha = DateTime.Now
            };
            context.AddTonotificacion(tnot);
            context.SaveChanges();
            this.Dispose();
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
        /// Carga los datos del deposito solicitado y los del cliente que lo solicitó.
        /// Lo realiza a traves de LINQ
        /// </summary>
        private void loadResumen()
        {
            int depp = 0;
            var res = from resm in context.depositocliente
                      join dep in context.deposito
                        on resm.idDeposito equals dep.id
                      join cue in context.cuenta
                        on resm.idCuenta equals cue.id
                      where resm.idCliente == idCliente && resm.idSolicitud == idSolicitud
                      select new
                      {
                          Importe = resm.importe,
                          Saldo = cue.saldo,
                          FechaP = resm.fechaSolicitud,
                          IDDep = resm.idDeposito
                      };
            foreach (var item in res)
            {
                txtImporteSol.Text = Convert.ToString(item.Importe);
                txtSaldo.Text = Convert.ToString(item.Saldo);
                txtFechaP.Text = Convert.ToString(item.FechaP);
                depp = item.IDDep;
            }

            var depos = from dep in context.deposito
                        where dep.id == depp
                        select dep;
            foreach (var item in depos)
            {
                txtImporteMin.Text = item.importeMinimo.ToString();
                txtPlazos.Text = item.plazo.ToString();
                txtTAE.Text = item.tae.ToString();
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

  

    }
}
