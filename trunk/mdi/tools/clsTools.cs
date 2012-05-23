using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.Security.Cryptography;

namespace tools
{
    /// <summary>
    /// Funciones utiles
    /// </summary>
    public static class clsTools
    {
        #region "Comprobaciones"
        /// <summary>
        /// Comprueba si el formulario ya existe entre los hijos y le da foco
        /// </summary>
        /// <param name="frm">Formulario tipo</param>
        /// <param name="children">Array de formularios hijos</param>
        /// <returns>Devuelve si existe</returns>
        public static Boolean compIfFormExistInChildrenAndFocus(Form frm, Form[] children)
        {
            Boolean res = true;
            foreach (Form temp in children)
            {
                if (temp.Name == frm.Name)
                {
                    temp.Focus();
                    res = false;
                }
            }
            return res;
        }
        /// <summary>
        /// Comprueba si el formulario ya existe entre los hijos
        /// </summary>
        /// <param name="frm">Formulario tipo</param>
        /// <param name="children">Array de formularios hijos</param>
        /// <returns>Devuelve si el formulario existe</returns>
        public static Boolean compIfFormExistInChildren(Form frm, Form[] children)
        {
            Boolean res = true;
            foreach (Form temp in children)
            {
                if (temp.Name == frm.Name)
                {
                    //temp.Focus();
                    res = false;
                }
            }
            return res;
        }
        /// <summary>
        /// Comprueba si un numero es numerico
        /// </summary>
        /// <param name="str">String con el campo para comprobar</param>
        /// <returns>Devuelve si es numerico</returns>
        public static Boolean isNumeric(String str)
        {
            try
            {
                Double i;
                i = Convert.ToDouble(str);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
        #region "Inserts"
        /// <summary>
        /// Inserta una notificacion con los datos que le transmitas
        /// </summary>
        /// <param name="strText">Texto de la notificacion</param>
        /// <param name="strAsunto">Asunto de la notificacion</param>
        /// <param name="intIdCliente">Id del cliente</param>
        /// <returns>Devuelve si ha ido bien la operacion</returns>
        public static Boolean addNotificacion(String strText, String strAsunto, int intIdCliente)
        {
            try
            {
                AccDatos.OLEDBCON conn = new AccDatos.OLEDBCON();
                conn.Ejecutar(" insert into notificacion (text, asunto, idCliente) " +
                              " values ('" + strText + "' ,'" + strAsunto + "', " + intIdCliente + ");");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Imprime en pdf la primera tabla del DataSet que le transfieras
        /// </summary>
        /// <param name="dsOriginal">DataSet con la tabla para imprimir</param>
        /// <param name="strParamTitulo">Si le quieres poner un Tilo al PDF</param>
        /// <param name="strParamOp">Si le quieres poner datos adicionales</param>
        public static void imprimirDataTableEnPdf(DataSet dsOriginal, String strParamTitulo, String strParamOp)
        {
            try
            {
                Document document = new Document();
                String strNombreFichero = "";

                strNombreFichero = "borrar\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Millisecond.ToString() + ".pdf";

                PdfWriter.GetInstance(document, new FileStream(strNombreFichero, FileMode.OpenOrCreate));
                document.Open();

                document.Add(new Paragraph("Banco Santander S.A. Todos los derechos reservados. Sede corporativa: CGS Av. Cantabria s/n 28660 Boadilla del Monte, Madrid (España) " + DateTime.Now.ToString(), FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.UNDERLINE)));
                iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(System.AppDomain.CurrentDomain.BaseDirectory +
                                                "\\images\\logosantander.jpg");

                jpg.Alignment = iTextSharp.text.Image.LEFT_ALIGN;
                jpg.ScaleAbsoluteWidth(192);
                jpg.ScaleAbsoluteHeight(75);

                document.Add(jpg);

                document.Add(new Paragraph(strParamTitulo, FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE)));
                document.Add(new Paragraph(" "));
                document.Add(new Paragraph(strParamOp));
                document.Add(new Paragraph(" "));
                int columnasSinId = 0;

                DataTable dtTemp = new DataTable();
                dtTemp = dsOriginal.Tables[0].Copy();
                dtTemp.PrimaryKey = null;
                foreach (DataColumn dcTemp in dsOriginal.Tables[0].Columns)
                {
                    if (!dcTemp.ColumnName.ToString().StartsWith("id"))
                    {
                        columnasSinId++;
                    }
                    else
                    {
                        dtTemp.Columns.Remove(dcTemp.ColumnName);
                    }
                }
                PdfPTable tabla = new PdfPTable(columnasSinId);
                tabla.WidthPercentage = 100;
                PdfPCell cell = new PdfPCell();

                foreach (DataColumn dcTemp in dtTemp.Columns)
                {
                    cell = new PdfPCell(new Phrase(dcTemp.ColumnName.ToUpper()));
                    cell.HorizontalAlignment = 1;
                    tabla.AddCell(cell);
                }
                foreach (DataRow drTemp in dtTemp.Rows)
                {
                    foreach (var dcTemp in drTemp.ItemArray)
                    {
                        if (dcTemp.GetType().ToString() == "System.DateTime")
                        {

                            cell = new PdfPCell(new Phrase(Convert.ToDateTime(dcTemp).ToShortDateString()));
                            cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;

                        }
                        else if (dcTemp.GetType().ToString() == "System.Decimal")
                        {
                            // Convert.ToString(dcTemp).Substring(0, Convert.ToString(dcTemp).Length - 1)
                            String strTemp = Convert.ToString(dcTemp).Substring(0, Convert.ToString(dcTemp).Length - 1) + " ";

                            cell = new PdfPCell(new Phrase(strTemp));
                            cell.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
                            //cell.HorizontalAlignment = Element.ALIGN_l;
                        }
                        else
                        {

                            cell = new PdfPCell(new Phrase(Convert.ToString(dcTemp)));
                            cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;

                        }
                        cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                        tabla.AddCell(cell);
                    }
                }

                document.Add(tabla);
                // Chunk chunk = new Chunk("Texto subrayado", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE));
                //document.Add(new Paragraph(chunk));

                document.Close();
                System.Diagnostics.Process.Start("AcroRd32.exe", strNombreFichero);
            }
            catch (Exception)
            {

            }
        }
        #endregion
        #region "Otros"
        /// <summary>
        /// Codifica el String en MD5
        /// </summary>
        /// <param name="input">String a codificar</param>
        /// <returns>String codificado en MD5</returns>
        public static String getMD5(String input)
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
        #endregion
    }
}