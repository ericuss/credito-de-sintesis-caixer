using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace customBtn
{
    public class btnLink : System.Windows.Forms.Button
    {
        #region "Propiedades"
        public String dll { get; set; }
        public String formulario { get; set; }
        public String id { get; set; }
        #endregion

        public btnLink()
        {
            this.Click += new EventHandler(btnLink_Click);
        }

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

            }
        }
    }
}
