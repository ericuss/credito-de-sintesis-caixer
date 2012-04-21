using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace conn
{
    public class cnx
    {
        #region "Variables"
        private String strTipo = "";
        public String strConexion = "";
        #endregion
        #region "New"

        public void New()
        {


        }
        public void New(String tipo)
        {


        }
        #endregion


        #region "Metodos"
        private void generarConn()
        {
            if (this.strTipo == "")
            {

                DataSet dsConString = new DataSet();
                try
                {
                    dsConString.ReadXml(System.AppDomain.CurrentDomain.BaseDirectory + "DatosConnect.xml");
                    foreach (DataRow drTemp in dsConString.Tables["conexion"].Rows)
                    {
                        String strId = drTemp["id"].ToString();
                        strId = strId.Trim();
                        if (strId == strTipo.Trim())
                        {
                            strConexion = drTemp["string"].ToString();
                        }

                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }
            else
            {
                //mensage  de error

            }

        }
        #endregion
    }
}
