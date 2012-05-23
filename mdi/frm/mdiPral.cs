using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using uMdi;
using customBtn;
using Microsoft.VisualBasic;
using System.IO;


namespace uMdi
{
    /// <summary>
    /// Formulario MDI
    /// </summary>
    public partial class mdiPral : Form
    {
        #region "Variables Privadas"
        #endregion
        #region "New"
        /// <summary>
        /// Constructor del MDI Principal
        /// </summary>
        public mdiPral()
        {
            InitializeComponent();
        }
        #endregion
        #region "Metodos por Defecto del Mdi"
        /// <summary>
        /// Muestra el formulario que muestra el acercaDe
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new frmAbout();
            about.ShowDialog();
        }
        /// <summary>
        /// Sale de la aplicacion
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// Minimiza los formularios
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        private void minimizarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        /// <summary>
        /// Ordena los formularios verticalmente
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        /// <summary>
        /// Ordena los formularios horizontalmente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        /// <summary>
        /// Alinia los iconos
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        private void aliniarIconosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        /// <summary>
        /// Cierra todos los formularios
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        private void cerrarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        #endregion
        #region "Load"
        /// <summary>
        /// Evento de carga del mdi, carga el splashScreen, el login y la barra de herramientas
        /// </summary>
        /// <param name="sender">Parametro del evento</param>
        /// <param name="e">Parametro del evento</param>
        private void mdiPral_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(DoSplash));
            th.Start();
            Thread.Sleep(2800);
            th.Abort();
            Thread.Sleep(2800);
            doLogin();
            loadMenuLateral();
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.White;
        }
        #endregion
        #region "Metodos"
        /// <summary>
        /// Carga el menu lateral
        /// </summary>
        private void loadMenuLateral()
        {
            DataSet dsMenu = new DataSet();
            AccDatos.OLEDBCON CON = new AccDatos.OLEDBCON();
            dsMenu = CON.LanzarConsulta("select * from MDImenu where padre = 0 order by nombreMenu ; select * from MDImenu where padre <> 0");
            List<customBtn.btnLink> lstBotones = new List<customBtn.btnLink>();
            foreach (DataRow drTronco in dsMenu.Tables[0].Rows)
            {

                Guifreaks.Navisuite.NaviBand btnTronco = new Guifreaks.Navisuite.NaviBand();
                btnTronco.Text = drTronco["nombreMenu"].ToString();
                DataRow[] arrDrHijo;
                arrDrHijo = dsMenu.Tables[1].Select("padre = " + drTronco["id"].ToString());
                btnTronco.LargeImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images/" + drTronco["icoXL"].ToString());
                btnTronco.SmallImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images/" + drTronco["icoXL"].ToString());

                int pos = 1;
                foreach (DataRow drHijo in arrDrHijo)
                {
                    customBtn.btnLink btnHijo = new customBtn.btnLink();
                    btnHijo.id = drHijo["id"].ToString();
                    btnHijo.dll = drHijo["dll"].ToString();
                    btnHijo.Text = drHijo["nombreMenu"].ToString();
                    btnHijo.formulario = drHijo["form"].ToString();

                    btnHijo.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images/" + drHijo["icoS"].ToString());
                    btnHijo.BackgroundImageLayout = ImageLayout.None;
                    btnHijo.Name = drHijo["id"].ToString() + drHijo["nombreMenu"].ToString();
                    btnHijo.Width = 145;
                    btnHijo.Location = new System.Drawing.Point(0, 28 * pos);
                    btnHijo.Visible = true;
                    btnHijo.Parent = this;
                    this.Controls.Add(btnHijo);
                    btnTronco.ClientArea.Controls.Add(btnHijo);
                    pos++;
                }
                naviBar2.Bands.Add(btnTronco);
            }


        }
        /// <summary>
        /// Carga el formulario del login
        /// </summary>
        private void doLogin()
        {
            uMdi.frmLoggin login = new uMdi.frmLoggin();
            login.ShowDialog();
            loadStrip();
        }
        /// <summary>
        /// Carga el formulario del SplashScreen
        /// </summary>
        void DoSplash()
        {
            uMdi.frmSplashScreen sp = new uMdi.frmSplashScreen();
            sp.ShowDialog();
        }
        /// <summary>
        /// Carga el usuario
        /// </summary>
        private void loadStrip()
        {
            String line = "";
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + "user.ogt");
                //Read the first line of text
                line = sr.ReadLine();

                //close the file
                sr.Close();

                System.IO.File.Delete(@System.AppDomain.CurrentDomain.BaseDirectory + "user.ogt");


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            stripLabel.BackColor = System.Drawing.Color.Transparent;
            stripLabel.Text = line;
        }
        #endregion
    }
}
