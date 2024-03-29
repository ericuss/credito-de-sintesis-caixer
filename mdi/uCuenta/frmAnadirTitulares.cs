﻿using System;
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
    /// <summary>
    /// Añade titulares a una cuenta
    /// </summary>
    public partial class frmAnadirTitulares : Form
    {
        #region "Propiedades"
        /// <summary>
        /// Id de la cuenta
        /// </summary>
        private int idCuenta;
        /// <summary>
        /// El entities context del formulario
        /// </summary>
        private santanderEntities1 context = new santanderEntities1();
        #endregion
        #region "New"
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pidCuenta">El id de la cuenta a modificar</param>
        public frmAnadirTitulares(int pidCuenta)
        {
            InitializeComponent();
            this.idCuenta = pidCuenta;
            loadtxtCueta();
            loadGrid();
        }
        #endregion
        #region "Eventos"
        /// <summary>
        /// Añade una cuenta
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
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
                Console.WriteLine(exx.Message);
                txtError.setError("Error Añadiendo Titual");
            }
        }
        /// <summary>
        /// Borra el titular de la cuenta
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
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
                Console.WriteLine(exx.Message);
                txtError.setError("Error Borrando Titular.");
            }

        }
        #endregion
        #region "Metodos"
        /// <summary>
        /// Carta el txtCuenta con la entidad, oficina, control y cuenta
        /// </summary>
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
        /// <summary>
        /// Carga la DataGrid con los titulares
        /// </summary>
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
        /// <summary>
        /// Marca como borrada la cuenta
        /// </summary>
        private void deleteAccount()
        {
            try
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
            catch (Exception EX)
            {
                txtError.setError("Error borrando cuenta, tiene dependencias");
                Console.WriteLine(EX.Message);
            }
        }
        /// <summary>
        /// Borra el titular
        /// </summary>
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
                Console.WriteLine(exx.Message);
                txtError.setError("Error Borrando titular");
            }
        }
        #endregion
    }
}
