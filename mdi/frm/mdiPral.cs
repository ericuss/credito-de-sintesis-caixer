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
using CustomTreeViewNode;
using customBtn;
using Microsoft.VisualBasic;
using System.IO;


namespace uMdi
{
    public partial class mdiPral : Form
    {
        private String loggedUser;
        #region "Variables Privadas"
        private int childFormNumber = 0;
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
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }



        #endregion


        #region "Load"
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


        private void doLogin()
        {
            uMdi.frmLoggin login = new uMdi.frmLoggin();
            login.ShowDialog();
            loadStrip();
        }


        void DoSplash()
        {
            uMdi.frmSplashScreen sp = new uMdi.frmSplashScreen();
            sp.ShowDialog();
        }
        #endregion
        #region "Metodos"


        #endregion



        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new frmAbout();
            about.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void minimizarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void aliniarIconosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cerrarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        private void loadStrip()
        {
            String line = "";
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + "user.ogt");
                //Read the first line of text
                line = sr.ReadLine();
                //Read the next line
                line = sr.ReadLine();
                //close the file
                sr.Close();

            }
            catch (Exception e)
            {
            }
            statusStrip.Text = line;
        }



    }
}
