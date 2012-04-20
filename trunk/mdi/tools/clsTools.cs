using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tools
{
    public class clsTools
    {


        /// <summary>
        /// Comprueba si el formulario ya existe entre los hijos y le da foco
        /// </summary>
        /// <param name="frm">Formulario tipo</param>
        /// <param name="children">Array de formularios hijos</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public Boolean compIfFormExistInChildrenAndFocus(Form frm, Form[] children)
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
        public Boolean compIfFormExistInChildren(Form frm, Form[] children)
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
    }
}