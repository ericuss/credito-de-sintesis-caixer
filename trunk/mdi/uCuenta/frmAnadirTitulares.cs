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
            if (csBuscarCliente.zzTxtId != "")
            {
                int pidCliente = Convert.ToInt16(dameIdClienteByDni(csBuscarCliente.zzTxtId));

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

                AccDatos.OLEDBCON conn = new AccDatos.OLEDBCON();
                conn.Ejecutar("insert into notificacion (asunto, text, idCliente) values ('Cuenta Nueva','Ahora es titular de la cuenta " + tmpCuenta.codigoEntidad + " - " + tmpCuenta.codigoOficina + " - " + tmpCuenta.codigoControl + " - " + tmpCuenta.codigoCuenta + "',"+pidCliente+")");
               
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

        private string dameIdClienteByDni(String strDni)
        {
            AccDatos.OLEDBCON oDatos = new AccDatos.OLEDBCON();
            DataTable dtCliente = oDatos.LanzarConsultaT("Select id from cliente where dni = '" + strDni + "'");
            if (dtCliente.Rows.Count == 1)
            {
                return dtCliente.Rows[0]["id"].ToString();
            }
            return null;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
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

            AccDatos.OLEDBCON conn = new AccDatos.OLEDBCON();
            conn.Ejecutar("insert into notificacion (asunto, text, idCliente) values ('Cuenta Eliminada','Ya no es titular de la cuenta " + tmpCuenta.codigoEntidad + " - " + tmpCuenta.codigoOficina + " - " + tmpCuenta.codigoControl + " - " + tmpCuenta.codigoCuenta + "'," + idCliente + ")");
               
        }
    }
}
