using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace uMdi
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada de la aplicacion
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
             Application.Run(new mdiPral());
        
        }

     
    }
}
