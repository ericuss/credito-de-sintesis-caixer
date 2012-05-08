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
                Thread th = new Thread(new ThreadStart(DoSplash));
                th.Start();
                Thread.Sleep(1000);
                th.Abort();
                Thread.Sleep(1000);
                doLogin();
                frmLoggin frm = new frmLoggin();
                frm.Show();

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
    }
}
