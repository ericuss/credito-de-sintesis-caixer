using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccDatos;
using System.Security.Cryptography;
namespace cliente
{
    public partial class frmNuevoUsuario : Form
    {
        public frmNuevoUsuario()
        {
            InitializeComponent();
        }
        public frmNuevoUsuario(String dni)
        {
            InitializeComponent();
            txtBuscar1.zzTxtId = dni;
            txtBuscar1.evLostFocus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                bCliente.clsBCliente bCliente = new bCliente.clsBCliente();
                if (txtBuscar1.zzTxtId != "" && !bCliente.tieneUsuario(txtBuscar1.zzTxtId))
                {
                    if (!bCliente.existeUsuario(txtUser.Text))
                    {
                        String strIdCliente = bCliente.dameIdClienteByDni(txtBuscar1.zzTxtId);
                        if (strIdCliente.Trim() != "")
                        {
                            if (bCliente.insertUsuario(strIdCliente, txtUser.Text, getmd5("12345")))
                            {
                                txtError.setOK(" Se ha generado correctamente, recuerda que la contraseña es 12345");
                            }
                            else
                            {
                                txtError.setError(" No se ha guardado correctamente");
                            }
                        }
                        else
                        {
                            txtError.setError(" No se ha encontrado el cliente ");
                        }  
                    }
                    else
                    {
                        txtError.setError(" Ya existe un usuario con ese usuario");
                    }
                }
                else
                {
                    txtError.setError(" La cuenta ya tiene un usuario");
                }
            }
            catch (Exception)
            {


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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try 
	        {	   
                if (txtBuscar1.zzTxtId.Trim() != "")
	            {
                    txtUser.Text = txtBuscar1.zzTxtDesc.Split(Convert.ToChar(" "))[0].Substring(0, 2) + txtBuscar1.zzTxtDesc.Split(Convert.ToChar(" "))[1].Substring(0, 2) + genrandom(2, false);
	            }	
            }
	        catch (Exception)
	        {
                txtError.setError("No se puede generar el usuario");
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
         
                return ret;
            
        }




    }
}
