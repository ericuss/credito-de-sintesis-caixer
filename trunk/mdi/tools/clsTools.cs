using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

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