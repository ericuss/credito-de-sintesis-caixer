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
    public partial class frmSolDeposito : Form
    {
        private int idCuenta;
        private int idCliente;
        private int idSolicitud;
        private santanderEntities1 context = new santanderEntities1();


        public frmSolDeposito()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmSolDeposito_Load);
        }
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



        void frmSolDeposito_Load(object sender, EventArgs e)
        {
            loadResumen();
            loadPersonalData();
            loadCuentas();
            loadAcciones();
            loadHistoricoAcciones();
            setInfoDatasourceDep(false);
        }

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

        private void rbDepContratados_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDepContratados.Checked == true)
            {
                setInfoDatasourceDep(true);
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtSaldo.Text == "" || txtImporteSol.Text=="")
            {
                txtError.BackColor = Color.Red;
                txtError.ForeColor = Color.Black;
                txtError.Text = "Error Genral.";
                txtError.Visible = true;
            }
            else if (Convert.ToDouble(txtImporteSol.Text) > Convert.ToDouble(txtSaldo.Text))
            {
                txtError.BackColor = Color.Red;
                txtError.ForeColor = Color.Black;
                txtError.Text = "Saldo en cuenta Insuficiente.";
                txtError.Visible = true;
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

                //notificacion nott = new notificacion()
                //{
                //    borrado = false,
                //    leido = false,
                //    idCliente = idCliente,
                //    text = "Se ha aceptado la solicitud del deposito con el importe de " + txtImporteSol.Text + " con un TAE de " + txtTAE.Text + ".",
                //    asunto = "Solicitud de Deposito Aceptado",
                //    fecha = DateTime.Now

                //};
                AccDatos.OLEDBCON conn = new AccDatos.OLEDBCON();
                conn.Ejecutar("insert into notificacion (text, asunto, idCliente) values ('Se ha aceptado la solicitud del deposito con el importe de " + txtImporteSol.Text + " con un TAE de " + txtTAE.Text + ".','Solicitud de Deposito Aceptado', " + idCliente + ")");
                
                context.AddTomovimiento(mov);
                context.SaveChanges();

                this.Dispose();
            }
        }

        private void btnDenegar_Click(object sender, EventArgs e)
        {
            santanderEntities1 context = new santanderEntities1();
            solicitud solt = new solicitud();
            var tmpSol = from sol in context.solicitud
                         where sol.idCliente == idCliente &&
                                sol.idCuenta == idCuenta
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

     

    }
}
