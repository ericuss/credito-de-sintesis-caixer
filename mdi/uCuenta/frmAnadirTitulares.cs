using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntityModel;

namespace uCuenta
{
    public partial class frmAnadirTitulares : Form
    {
        private int idCuenta;
        private santanderEntities1 context = new santanderEntities1();
        public frmAnadirTitulares(int pidCuenta)
        {
            InitializeComponent();
            this.idCuenta = pidCuenta;
            loadtxtCueta();
            loadGrid();
        }

        private void loadtxtCueta()
        {
            var cun = from c in context.cuenta
                      where c.id == idCuenta
                      select new
                      {
                          Cuenta = c.codigoEntidad + " - " + c.codigoOficina + " - " + c.codigoControl + " - " + c.codigoCuenta
                      };
            foreach (var item in cun)
            {
                txtCuenta.Text = item.Cuenta;
            }
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                if (csBuscarCliente.zzTxtId != "")
                {
                    bCliente.clsBCliente bcliente = new bCliente.clsBCliente();
                    int pidCliente = Convert.ToInt16(bcliente.dameIdClienteByDni(csBuscarCliente.zzTxtId));

                    cuentacliente cc = new cuentacliente()
                    {
                        idCliente = pidCliente,
                        idCuenta = idCuenta
                    };

                    context.AddTocuentacliente(cc);
                    context.SaveChanges();
                    loadGrid();

                    cuenta tmpCuenta = new cuenta();
                    var cun = from cu in context.cuenta
                              where cu.id == idCuenta
                              select cu;
                    foreach (var item in cun)
                    {
                        tmpCuenta = item;
                    }

                    tools.clsTools.addNotificacion("Ahora es titular de la cuenta " + tmpCuenta.codigoEntidad + " - " + tmpCuenta.codigoOficina + " - " + tmpCuenta.codigoControl + " - " + tmpCuenta.codigoCuenta + ".", "Cuenta Nueva", pidCliente);
                }
            }
            catch (Exception exx)
            {
                txtError.setError("Error Añadiendo Titual");
            }
        }

        private void loadGrid()
        {
            var grd = from cli in context.cliente
                      join ccc in context.cuentacliente
                        on cli.id equals ccc.idCliente
                      join cuu in context.cuenta
                        on ccc.idCuenta equals cuu.id
                      where cuu.id == idCuenta
                      select new
                      {
                          Cliente = cli.nombre + " " + cli.apellidos,
                          DNI = cli.dni,
                          idCliente = cli.id
                      };
            dgvTitulares.DataSource = grd;
            dgvTitulares.Columns["idCliente"].Visible = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTitulares.SelectedRows.Count > 0)
                {
                    if (dgvTitulares.Rows.Count == 1)
                    {
                        DialogResult result2 = MessageBox.Show("Se borrara la cuenta, ¿Continuar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result2 == DialogResult.Yes)
                        {
                            deleteTitular();
                            deleteAccount();
                        }
                    }
                    else
                    {
                        deleteTitular();
                    }

                }
            }
            catch (Exception exx)
            {
                txtError.setError("Error Borrando Titular.");
            }

        }

        private void deleteAccount()
        {
            cuenta tmpCuenta = new cuenta();
            var cuen = from cue in context.cuenta
                       where cue.id == idCuenta
                       select cue;
            foreach (var item in cuen)
            {
                tmpCuenta = item;
            }
            context.DeleteObject(tmpCuenta);
            context.SaveChanges();
            this.Dispose();
        }

        private void deleteTitular()
        {
            try
            {
                int idCliente = Convert.ToInt16(dgvTitulares.SelectedRows[0].Cells["idCliente"].Value.ToString());
                cuentacliente tmpcc = new cuentacliente();
                var cc = from cuc in context.cuentacliente
                         where cuc.idCliente == idCliente && cuc.idCuenta == idCuenta
                         select cuc;
                foreach (var item in cc)
                {
                    tmpcc = item;
                }
                context.DeleteObject(tmpcc);
                context.SaveChanges();
                loadGrid();

                cuenta tmpCuenta = new cuenta();
                var cun = from cu in context.cuenta
                          where cu.id == idCuenta
                          select cu;
                foreach (var item in cun)
                {
                    tmpCuenta = item;
                }


                tools.clsTools.addNotificacion("Ya no es titular de la cuenta " + tmpCuenta.codigoEntidad + " - " + tmpCuenta.codigoOficina + " - " + tmpCuenta.codigoControl + " - " + tmpCuenta.codigoCuenta + ".", "Cuenta Eliminada", idCliente);
            }
            catch (Exception exx)
            {
                txtError.setError("Error Borrando titular");
            }
        }
    }
}
