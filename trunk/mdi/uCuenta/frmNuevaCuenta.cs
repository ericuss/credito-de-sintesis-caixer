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
    public partial class frmNuevaCuenta : Form
    {
        santanderEntities1 context = new santanderEntities1();
        public frmNuevaCuenta()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tnAceptar_Click(object sender, EventArgs e)
        {
            cuenta tmpCuenta = new cuenta
            {
                codigoEntidad = "2100",
                codigoOficina = "9999",
                codigoControl = genrandom(2, false),
                codigoCuenta = genrandom(8, true),
                saldo = 0
            };
            context.AddTocuenta(tmpCuenta);


            int pidCliente = Convert.ToInt16(dameIdClienteByDni(csBuscar.zzTxtId));
            cuentacliente tmpcc = new cuentacliente
            {
                idCliente = pidCliente,
                idCuenta = tmpCuenta.id
            };
            context.AddTocuentacliente(tmpcc);
            context.SaveChanges();
        }
        private String genrandom(int numDigitos, Boolean check)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            String ret = "";

            for (int i = 0; i < numDigitos; i++)
            {
                ret += r.Next(0, 9).ToString();
            }
            if (check)
            {
                if (Validate(ret))
                {

                    return ret;
                }
                else
                {
                    return genrandom(numDigitos, true);
                }
            }
            else
            {
                return ret;
            }
        }

        private Boolean Validate(string ret)
        {
            var count = (from cuents in context.cuenta
                         where cuents.codigoCuenta == ret
                         select cuents).Count();
            if (count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
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
    }
}
