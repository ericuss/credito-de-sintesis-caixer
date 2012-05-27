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
    /// <summary>
    /// Formulario para crear o modificar un Cliente
    /// </summary>
    public partial class frmNuevoCliente : Form
    {
        #region Propiedades

        /// <summary>
        /// ID del Cliente que se va ha editar
        /// </summary>
        private int idCliente;

        /// <summary>
        /// Objeto usado para acceder a la base de datos mediante Entity Framework
        /// </summary>
        santanderEntities1 context = new santanderEntities1();

        #endregion

        #region "Constructores"

        /// <summary>
        /// Constructor de la clase. Se llama cuando se inicia el proceso de creacion de un nuevo Cliente
        /// </summary>
        public frmNuevoCliente()
        {
            InitializeComponent();
            idCliente = -1;
        }

        /// <summary>
        /// Constructor de la clase. Se llama cuando se inicia el proceso de Edicion de un Cliente.
        /// </summary>
        /// <param name="idc">ID del Cliente a modificar</param>
        public frmNuevoCliente(int idc)
        {
            InitializeComponent();
            this.idCliente = idc;
            setData(idc);
        }

        #endregion

        #region "Eventos"

        /// <summary>
        /// Evento que guarda los cambios. Si se trata de una edicion, redirije el flujo de la aplicacion hacia el metodo de updatear.
        /// Si se trata de una alta redirije el flujo de la aplicacion hacia el insert.
        /// </summary>
        /// <param name="sender">Parametro del Evento</param>
        /// <param name="e">Parametro del Evento</param>
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (!checkCampos())
            {
                txtError.setError("Error! Faltan datos.");
            }
            else
            {
                bCliente.clsBCliente bCliente = new bCliente.clsBCliente();
                if (!bCliente.existeIdClienteByDni(txtDNI.Text))
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
                else
                {
                    txtError.setError("Error! Ya existe el Dni.");
                }
            }
        }


        /// <summary>
        /// Evento que cierra el formulario
        /// </summary>
        /// <param name="sender">Parametros del evento</param>
        /// <param name="e">Parametros del evento</param>
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }


        /// <summary>
        /// Evento que al marcar el checkbox, genera un usuario y lo muestra en un TextBox
        /// </summary>
        /// <param name="sender">Parametro del Eento</param>
        /// <param name="e">Parametro del Eento</param>
        private void chkCrearUser_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCrearUser.Checked == true)
            {
                try
                {
                    txtUsuario.Text = txtNombre.ValidValue + txtApellido.ValidValue.Substring(0, 2) + genrandom(2, false);
                    txtUsuario.Visible = true;
                }
                catch (Exception exx)
                {
                    txtError.setError(exx.Message);

                }
            }
            else
            {
                txtUsuario.Visible = false;
            }
        }

 
        
        #endregion

        #region "Metodos"

        /// <summary>
        /// Metodo que Updatea el Cliente pasado al constructor. Recoje su id de la propiedad de la calse.
        /// Utiliza LINQ para modificar el cliente en la BBDD.
        /// </summary>
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
            clientFnal.nombre = txtNombre.ValidValue;
            clientFnal.apellidos = txtApellido.ValidValue;
            clientFnal.telefono = txtTelfono.ValidValue;
            clientFnal.direccion = txtDireccion.ValidValue;
            clientFnal.poblacion = txtPoblacion.ValidValue;
            clientFnal.mail = txtMail.ValidValue;
            clientFnal.dni = txtDNI.ValidValue;
            clientFnal.fechaNacimiento = txtFechaNacimiento.ValidValue;
            context.SaveChanges();
            this.Dispose();
        }

        /// <summary>
        /// Metodo que inserta los datos del nuevo cliente en la BBDD. 
        /// Utiliza LINQ para enviar los datos.
        /// </summary>
        private void crearCliente()
        {
            EntityModel.cliente tmpCliente = new EntityModel.cliente
            {
                nombre = txtNombre.ValidValue,
                apellidos = txtApellido.ValidValue,
                telefono = txtTelfono.ValidValue,
                direccion = txtDireccion.ValidValue,
                poblacion = txtPoblacion.ValidValue,
                mail = txtMail.ValidValue,
                dni = txtDNI.ValidValue,
                fechaNacimiento = txtFechaNacimiento.ValidValue
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
                    login = txtUsuario.ValidValue,
                    password = tools.clsTools.getMD5("12345"),
                    idioma = "es",
                    paginaPreferida = "/backend/cuenta/cuenta",
                    inactivo = false
                };
                context.AddTousuario(tmpUsuario);
            }

            context.SaveChanges();
            this.Dispose();
        }


        /// <summary>
        /// Metodo que se llama al principo de cargar la aplicacion, en modo Edicion, para rellenar los datos del formulario.
        /// </summary>
        /// <param name="idc">ID del Cliente</param>
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
                txtApellido.ValidValue = item.Apellido;
                txtDireccion.ValidValue = item.Direccion;
                txtDNI.ValidValue = item.DNI;
                txtFechaNacimiento.ValidValue = item.FechaNacimiento;
                txtMail.ValidValue = item.Correo;
                txtNombre.ValidValue = item.Nombre;
                txtPoblacion.ValidValue = item.Poblacion;
                txtTelfono.ValidValue = item.Telefono;
            }

        }

        /// <summary>
        /// Metodo que comprueba que los datos esten todos introducidos.
        /// </summary>
        /// <returns>Devuelve true o false segun esten llenos o no.</returns>
        private bool checkCampos()
        {
            if (txtApellido.ValidValue == "")
            {
                return false;
            }
            else if (txtDireccion.ValidValue == "")
            {
                return false;
            }
            else if (txtDNI.ValidValue == "")
            {
                return false;
            }
            else if (txtFechaNacimiento.ValidValue == "")
            {
                return false;
            }
            else if (txtMail.ValidValue == "")
            {
                return false;
            }
            else if (txtNombre.ValidValue == "")
            {
                return false;
            }
            else if (txtPoblacion.ValidValue == "")
            {
                return false;
            }
            else if (txtTelfono.ValidValue == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Metodo que genera N numeros aleatorios y median al funcion validate, en el caso de pasarle un true como segundo parametro, comprobara si esta repetido en la BBDD.
        /// </summary>
        /// <param name="numDigitos">Longitud del Numero Aleatorio a Generar</param>
        /// <param name="check">Indica si se ha de comprobar que no exista en la BBDD</param>
        /// <returns>Devuelve un String con el numero Generado</returns>
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


        /// <summary>
        /// Metodo que valida que el nuemro que se le envia por parametro no este repetido en la BBDD
        /// </summary>
        /// <param name="ret">Cadena a Comprobar</param>
        /// <returns>Devuelve true o false segun exista o no</returns>
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
        #endregion

    


    }
}

