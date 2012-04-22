using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace frm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            
            //Application.Run(frm);
           //Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new mdiPral());
            // Application.Run(new uMdi.frmLoggin());
        
        }

     
    }
}
