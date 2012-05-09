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

namespace frm
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
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        #endregion

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uMdi.frmAbout frm = new uMdi.frmAbout();
            frm.Show();
        }
        #region "Load"
        private void mdiPral_Load(object sender, EventArgs e)
        {
            tvMenu.MouseDoubleClick += new MouseEventHandler(tvMenu_MouseDoubleClick);
            Thread th = new Thread(new ThreadStart(DoSplash));
            th.Start();
            Thread.Sleep(1000);
            th.Abort();
            Thread.Sleep(1000);
            doLogin();

            loadMenu();

        }

        private void loadMenu()
        {
            DataSet ArbolDataSet = new DataSet();
            AccDatos.OLEDBCON CON = new AccDatos.OLEDBCON();
            ArbolDataSet = CON.LanzarConsulta("select * from MDImenu");


            String NombreNodo = "nombreMenu";
            String TextoNodo = "nombreMenu";
            String identificadorNodo = "id";
            String form = "form";
            String dll = "dll";
            DataView datavie = new DataView();
            datavie.Table = ArbolDataSet.Tables[0];
            datavie.RowFilter = string.Format("padre = 0");
            for (int i = 0; i <= datavie.Count - 1; i++)
            {
                CustomTreeViewNode.CustomTreeViewNode Nod = new CustomTreeViewNode.CustomTreeViewNode();
                Nod.Text = datavie[i][TextoNodo].ToString();
                Nod.Name = datavie[i][NombreNodo].ToString();
                Nod.Tag = -1;
                tvMenu.Nodes.Add(Nod);
                datavie.RowFilter = string.Format("padre = " + datavie[i]["id"]);
                for (int k = 0; k <= datavie.Count - 1; k++)
                {
                    CustomTreeViewNode.CustomTreeViewNode Nodd = new CustomTreeViewNode.CustomTreeViewNode();
                    Nodd.Text = datavie[k][TextoNodo].ToString();
                    Nodd.Name = datavie[k][NombreNodo].ToString();
                    Nodd.Tag = datavie[k][identificadorNodo];
                    Nodd.dll = datavie[k][dll].ToString();
                    Nodd.Form = datavie[k][form].ToString();
                    tvMenu.Nodes[i].Nodes.Add(Nodd);
                }
                datavie.RowFilter = string.Format("padre = 0");
            }
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

            if (tvMenu.SelectedNode.Tag.ToString() != "-1")
            {
                String dll = ((CustomTreeViewNode.CustomTreeViewNode)tvMenu.SelectedNode).dll;
                String form = ((CustomTreeViewNode.CustomTreeViewNode)tvMenu.SelectedNode).Form;

                System.Reflection.Assembly extAssembly = System.Reflection.Assembly.LoadFrom(dll + ".dll");
                Form extForm = ((Form)extAssembly.CreateInstance(dll + "." + form, true));

                if (tools.clsTools.compIfFormExistInChildrenAndFocus(extForm, this.MdiChildren))
                {
                    extForm.MdiParent = this;
                    extForm.Show();
                }
            }

        }
    }
}
