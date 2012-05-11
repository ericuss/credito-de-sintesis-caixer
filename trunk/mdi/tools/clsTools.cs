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

namespace tools
{
    public static class clsTools
    {


        /// <summary>
        /// Comprueba si el formulario ya existe entre los hijos y le da foco
        /// </summary>
        /// <param name="frm">Formulario tipo</param>
        /// <param name="children">Array de formularios hijos</param>
        /// <returns></returns>
        /// <remarks></remarks>
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
        /// <returns></returns>
        /// <remarks></remarks>
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




        public static void imprimirDataTableEnPdf(DataSet dsOriginal)
        {

            Document document = new Document();
            String strNombreFichero = "";

            strNombreFichero = "borrar\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Millisecond.ToString() + ".pdf";
            
            PdfWriter.GetInstance(document, new FileStream(strNombreFichero, FileMode.OpenOrCreate));
            document.Open();
            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(System.AppDomain.CurrentDomain.BaseDirectory +
                                            "\\images\\logosantander.jpg");

            jpg.Alignment = iTextSharp.text.Image.LEFT_ALIGN;
            jpg.ScaleAbsoluteWidth(192);
            jpg.ScaleAbsoluteHeight(75);

            document.Add(jpg);

            document.Add(new Paragraph("Consulta de Saldo", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE)));
            document.Add(new Paragraph(" "));
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
                        String strTemp =  Convert.ToString(dcTemp).Substring(0, Convert.ToString(dcTemp).Length - 1) + " €";

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



        public static void msg(String strId)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(System.AppDomain.CurrentDomain.BaseDirectory + "msg.xml");
                foreach (DataRow drTemp in ds.Tables["msg"].Rows)
                {
                    if (drTemp["id"] == strId)
                    {

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}