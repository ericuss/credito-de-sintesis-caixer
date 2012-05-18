using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using uMdi;

namespace uMdi
{
    public partial class frmLoggin : Form
    {
        /// <summary>
        /// Constructor del Login
        /// </summary>
        public frmLoggin()
        {
            InitializeComponent();

        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            submit();
        }

        private void submit()
        {

            if (txtUsuario.Text.Trim() != "" && txtPass.Text.Trim() != "")
            {
                AccDatos.OLEDBCON conn = new AccDatos.OLEDBCON();
                DataSet loginDS = conn.LanzarConsulta("Select * from usuario where login= '" + txtUsuario.ValidValue + "'");
                if (loginDS.Tables[0].Rows.Count != 0)
                {
                    if (getmd5(txtPass.ValidValue) == (loginDS.Tables[0].Rows[0]["password"].ToString()))
                    {

                        this.Dispose();
                    }
                    else
                    {
                        
                        txtPass.setErrorColor("Pass Erroneo");
                    }
                }
                else
                {
                    txtUsuario.setErrorColor("Usuario Erroneo");
                }
            }// error de usuario y/o contraseña mal

           
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

        private void frmLoggin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(frmLoggin_KeyPress);

        }

        void frmLoggin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                submit();
            }
        }




    }
}
