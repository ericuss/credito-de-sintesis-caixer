using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace customBtn
{
    /// <summary>
    /// Boton del menu lateral que provoca la apertura d elos formularios
    /// </summary>
    public class btnLink : System.Windows.Forms.Button
    {
        #region "Propiedades"
        /// <summary>
        /// Dll donde esta el formulario
        /// </summary>
        public String dll { get; set; }
        /// <summary>
        /// Nombre del formulario
        /// </summary>
        public String formulario { get; set; }
        /// <summary>
        /// Id del formulario, no necesario
        /// </summary>
        public String id { get; set; }
        #endregion
        #region "New"
        /// <summary>
        /// Constructor
        /// </summary>
        public btnLink()
        {
            this.Click += new EventHandler(btnLink_Click);
           // this.Height = 48;
          //  this.Width = 48;
        }
        #endregion
        #region "Eventos"
        /// <summary>
        /// Abre el formulario mediante reflection
        /// </summary>
        /// <param name="sender">Parametro de evento</param>
        /// <param name="e">Parametro de evento</param>
        void btnLink_Click(object sender, EventArgs e)
        {
            try
            {
                System.Reflection.Assembly extAssembly = System.Reflection.Assembly.LoadFrom(dll + ".dll");
                Form extForm = ((Form)extAssembly.CreateInstance(dll + "." + formulario, true));

                if (tools.clsTools.compIfFormExistInChildrenAndFocus(extForm, this.Parent.FindForm().MdiChildren))
                {
                    extForm.MdiParent = this.Parent.FindForm();
                    extForm.Show();
                }

            }
            catch (Exception exx)
            {
                Console.WriteLine("Error:"+exx.ToString());
            }
        }
        #endregion
    }
}
