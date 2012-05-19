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


namespace uMdi
{
    public partial class mdiPral : Form
    {
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
           // tvMenu.MouseDoubleClick += new MouseEventHandler(tvMenu_MouseDoubleClick);
            Thread th = new Thread(new ThreadStart(DoSplash));
            th.Start();
            Thread.Sleep(2800);
            th.Abort();
            Thread.Sleep(2800);
            doLogin();

            loadMenuLateral();
            loadMenu();
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.White;
            //Guifreaks.Navisuite.NaviBand temp = new Guifreaks.Navisuite.NaviBand();
            //customBtn.btnLink jj = new customBtn.btnLink();
            //jj.dll = "hh.dll";
            //jj.formulario = "uoo";
            //temp.Text = "esto es editado";

            //// btn = new Button();
            ////btn.Text = "butun";
            //temp.ClientArea.Controls.Add(jj);
            //naviBar2.Bands.Add(temp);

            //naviBar2.VisibleLargeButtons = naviBar2.Bands.Count;


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
                    customBtn.btnLink btnHijo =new customBtn.btnLink();
                    btnHijo.id = drHijo["id"].ToString();
                    btnHijo.dll = drHijo["dll"].ToString();
                    btnHijo.Text = drHijo["nombreMenu"].ToString();
                    btnHijo.formulario = drHijo["form"].ToString();

                    btnHijo.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images/" + drHijo["icoS"].ToString());
                    btnHijo.BackgroundImageLayout=ImageLayout.None;
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
        private void loadMenu()
        {
            //DataSet ArbolDataSet = new DataSet();
            //AccDatos.OLEDBCON CON = new AccDatos.OLEDBCON();
            //ArbolDataSet = CON.LanzarConsulta("select * from MDImenu");


            //String NombreNodo = "nombreMenu";
            //String TextoNodo = "nombreMenu";
            //String identificadorNodo = "id";
            //String form = "form";
            //String dll = "dll";
            //DataView datavie = new DataView();
            //datavie.Table = ArbolDataSet.Tables[0];
            //datavie.RowFilter = string.Format("padre = 0");
            //for (int i = 0; i <= datavie.Count - 1; i++)
            //{
            //    CustomTreeViewNode.CustomTreeViewNode Nod = new CustomTreeViewNode.CustomTreeViewNode();
            //    Nod.Text = datavie[i][TextoNodo].ToString();
            //    Nod.Name = datavie[i][NombreNodo].ToString();
            //    Nod.Tag = -1;
            //    tvMenu.Nodes.Add(Nod);
            //    datavie.RowFilter = string.Format("padre = " + datavie[i]["id"]);
            //    for (int k = 0; k <= datavie.Count - 1; k++)
            //    {
            //        CustomTreeViewNode.CustomTreeViewNode Nodd = new CustomTreeViewNode.CustomTreeViewNode();
            //        Nodd.Text = datavie[k][TextoNodo].ToString();
            //        Nodd.Name = datavie[k][NombreNodo].ToString();
            //        Nodd.Tag = datavie[k][identificadorNodo];
            //        Nodd.dll = datavie[k][dll].ToString();
            //        Nodd.Form = datavie[k][form].ToString();
            //        tvMenu.Nodes[i].Nodes.Add(Nodd);
            //    }
            //    datavie.RowFilter = string.Format("padre = 0");
            //}
        }

        private void doLogin()
        {
            uMdi.frmLoggin login = new uMdi.frmLoggin();
            login.ShowDialog();
        }
        void DoSplash()
        {
            uMdi.frmSplashScreen sp = new uMdi.frmSplashScreen();
            sp.ShowDialog();
        }
        #endregion
        #region "Metodos"


        #endregion

        void tvMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //try
            //{
            //    if (tvMenu.SelectedNode.Tag.ToString() != "-1")
            //    {
            //        String dll = ((CustomTreeViewNode.CustomTreeViewNode)tvMenu.SelectedNode).dll;
            //        String form = ((CustomTreeViewNode.CustomTreeViewNode)tvMenu.SelectedNode).Form;

            //        System.Reflection.Assembly extAssembly = System.Reflection.Assembly.LoadFrom(dll + ".dll");
            //        Form extForm = ((Form)extAssembly.CreateInstance(dll + "." + form, true));

            //        if (tools.clsTools.compIfFormExistInChildrenAndFocus(extForm, this.MdiChildren))
            //        {
            //            extForm.MdiParent = this;
            //            extForm.Show();
            //        }
            //    }
            //}
            //catch (Exception exx)
            //{

            //}

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }



    }
}
