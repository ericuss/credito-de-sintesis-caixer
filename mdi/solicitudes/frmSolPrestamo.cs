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
    public partial class frmSolPrestamo : Form
    {
        private int idCuenta;
        private int idCliente;
        private int idSolicitud;
        private santanderEntities1 context = new santanderEntities1();
        public frmSolPrestamo()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmSolPrestamo_Load);
        }
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

        void frmSolPrestamo_Load(object sender, EventArgs e)
        {
            loadResumen();
            loadPersonalData();
            loadCuentas();
            loadAcciones();
            loadHistoricoAcciones();
            setInfoDatasourceDep(false);
        }

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
        private void loadResumen()
        {
        

        }

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
        private void setInfoDatasourceDep(Boolean doit)
        {
            var deps = from dep in context.depositocliente
                       join infd in context.deposito
                         on dep.idDeposito equals infd.id
                       where dep.idCliente == idCliente && dep.activo == true
                       select new
                       {
                           Importe = dep.importe,
                           TAE = infd.tae,
                           FechaActivacion = dep.fechaActivacion,
                           FechaVencimiento = dep.fechaVencimiento,
                           Plazos = infd.plazo
                       };
            txtDepCon.Text = Convert.ToString(deps.Count());
            if (doit)
            {
                this.dgvInfo.DataSource = deps;
            }
        }

        private void btnMantener_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
