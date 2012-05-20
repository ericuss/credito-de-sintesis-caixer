using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntityModel;
using System.Security.Cryptography;

namespace cliente
{
    public partial class frmNuevoCliente : Form
    {
        private int idCliente;
        santanderEntities1 context = new santanderEntities1();
        public frmNuevoCliente()
        {
            InitializeComponent();
            idCliente = -1;
        }

        public frmNuevoCliente(int idc)
        {
            InitializeComponent();
            this.idCliente = idc;
            setData(idc);
        }

        private void setData(int idc)
        {
            var cliente = from cli in context.cliente
                          where cli.id == idc
                          select new
                          {
                              idCliente = cli.id,
                              Nombre = cli.nombre,
                              Apellido = cli.apellidos,
                              Telefono = cli.telefono,
                              Direccion = cli.direccion,
                              Poblacion = cli.poblacion,
                              Correo = cli.mail,
                              DNI = cli.dni,
                              FechaNacimiento = cli.fechaNacimiento

                          };
            foreach (var item in cliente)
            {
                txtApellido.Text = item.Apellido;
                txtDireccion.Text = item.Direccion;
                txtDNI.Text = item.DNI;
                txtFechaNacimiento.Text = item.FechaNacimiento;
                txtMail.Text = item.Correo;
                txtNombre.Text = item.Nombre;
                txtPoblacion.Text = item.Poblacion;
                txtTelfono.Text = item.Telefono;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!checkCampos())
            {

                txtError.setError("Error! Faltan Datos.");

            }
            else
            {
                if (idCliente == -1)
                {
                    crearCliente();
                }
                else
                {
                    updateCliente();
                }

            }
        }

        private void updateCliente()
        {
            EntityModel.cliente clientFnal = new EntityModel.cliente();
            var clieT = from cln in context.cliente
                        where cln.id == idCliente
                        select cln;
            foreach (var item in clieT)
            {
                clientFnal = item;
            }
            clientFnal.nombre = txtNombre.Text;
            clientFnal.apellidos = txtApellido.Text;
            clientFnal.telefono = txtTelfono.Text;
            clientFnal.direccion = txtDireccion.Text;
            clientFnal.poblacion = txtPoblacion.Text;
            clientFnal.mail = txtMail.Text;
            clientFnal.dni = txtDNI.Text;
            clientFnal.fechaNacimiento = txtFechaNacimiento.Text;
            context.SaveChanges();
        }

        private void crearCliente()
        {
            EntityModel.cliente tmpCliente = new EntityModel.cliente
            {
                nombre = txtNombre.Text,
                apellidos = txtApellido.Text,
                telefono = txtTelfono.Text,
                direccion = txtDireccion.Text,
                poblacion = txtPoblacion.Text,
                mail = txtMail.Text,
                dni = txtDNI.Text,
                fechaNacimiento = txtFechaNacimiento.Text
            };


            context.AddTocliente(tmpCliente);
            cuenta tmpCuenta = new cuenta
            {
                codigoEntidad = "2100",
                codigoOficina = "9999",
                codigoControl = genrandom(2, false),
                codigoCuenta = genrandom(8, true),
                saldo = 0
            };
            context.AddTocuenta(tmpCuenta);


            cuentacliente tmpcc = new cuentacliente
            {
                idCliente = tmpCliente.id,
                idCuenta = tmpCuenta.id
            };
            context.AddTocuentacliente(tmpcc);

            if (chkCrearUser.Checked == true)
            {
                usuario tmpUsuario = new usuario
                {
                    login = txtNombre.Text + txtApellido.Text.Substring(0, 2) + genrandom(2, false),
                    password = getmd5("12345"),
                    idioma = "es",
                    paginaPreferida = "/backend/cuenta/cuenta",
                    inactivo = false
                };
                context.AddTousuario(tmpUsuario);
            }


            context.SaveChanges();
        }

        private bool checkCampos()
        {
            if (txtApellido.Text == "")
            {
                return false;
            }
            else if (txtDireccion.Text == "")
            {
                return false;
            }
            else if (txtDNI.Text == "")
            {
                return false;
            }
            else if (txtFechaNacimiento.Text == "")
            {
                return false;
            }
            else if (txtMail.Text == "")
            {
                return false;
            }
            else if (txtNombre.Text == "")
            {
                return false;
            }
            else if (txtPoblacion.Text == "")
            {
                return false;
            }
            else if (txtTelfono.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
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

        private string getmd5(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }


    }
}

