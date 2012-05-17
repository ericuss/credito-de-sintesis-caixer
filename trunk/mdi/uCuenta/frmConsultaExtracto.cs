using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace uCuenta
{
    public partial class frmConsultaExtracto : Base.Base
    {
        #region "Variables privadas"
      
        #endregion
        #region "New"
        public frmConsultaExtracto()
        {
            InitializeComponent();
            tablaBBDD = "movimiento";
            strOpcional = "cuenta: 2100 - 2000 - 12 - 012345678       Nombre: Hannah42";
            txtBuscar1.LostFocus += new EventHandler(txtBuscar1_LostFocus);
        }

        void txtBuscar1_LostFocus(object sender, EventArgs e)
        {
            MessageBox.Show("pene");
        }

        #endregion


        private void dtpIni_ValueChanged(object sender, EventArgs e)
        {
            filtrarGrid();

        }



        #region "Filtrar"
        private void txtImporteIni_Leave(object sender, EventArgs e)
        {
            if (tools.clsTools.isNumeric(txtImporteIni.Text))
            {
                filtrarGrid();
            }
            else
            {
                txtImporteIni.Text = "";
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtrarGrid();
        }
        private void txtImporteFin_Leave(object sender, EventArgs e)
        {
            if (tools.clsTools.isNumeric(txtImporteFin.Text))
            {
                filtrarGrid();
            }
            else
            {
                txtImporteFin.Text = "";
            }
        }
        private void txtDescrip_Leave(object sender, EventArgs e)
        {
            filtrarGrid();
        }
        private void txtCon_Leave(object sender, EventArgs e)
        {
            filtrarGrid();
        }
        private void filtrarGrid()
        {
            string strQuery = "select * from movimiento where 1 = 1 ";

            if (chkIncluirFechas.Checked)
            {
                strQuery += " and fecha >= date('" + dtpIni.Value.Year + "/" + dtpIni.Value.Month + "/" + dtpIni.Value.Day + "') ";
                strQuery += " and fecha <= date('" + dtpFin.Value.Year + "/" + dtpFin.Value.Month + "/" + dtpFin.Value.Day + "') ";
            }
            if (txtImporteIni.Text != "")
            {
                strQuery += " and importe >= " + txtImporteIni.Text + " ";
            }

            if (txtImporteFin.Text != "")
            {
                strQuery += " and importe <= " + txtImporteFin.Text + " ";
            }
            if (txtDescrip.Text != "")
            {
                strQuery += " and descripcion like '%" + txtDescrip.Text + "%' ";
            }
            if (txtCon.Text != "")
            {
                strQuery += " and concepto like '%" + txtCon.Text + "%' ";
            }
            AccDatos.OLEDBCON conn = new AccDatos.OLEDBCON();
            DataTable dtTemp = conn.LanzarConsultaT(strQuery);
            dgv.DataSource = dtTemp;
            dts.Tables.Remove(dts.Tables[0]);
            dts.Tables.Add(dtTemp);

            ocultarId();


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtImporteIni.Text = "";

            txtImporteFin.Text = "";
            txtDescrip.Text = "";
            txtCon.Text = "";
            chkIncluirFechas.Checked = false;
        }
        private void btnTodos_Click(object sender, EventArgs e)
        {
            txtImporteIni.Text = "";

            txtImporteFin.Text = "";
            txtDescrip.Text = "";
            txtCon.Text = "";
            chkIncluirFechas.Checked = false;
        }
        #endregion
        public override void ocultarId()
        {
            //base.ocultarId();
            if (dgv.Columns.Contains("id"))
            {
                dgv.Columns["id"].Visible = false;
            }
            if (dgv.Columns.Contains("idCuenta"))
            {
                dgv.Columns["idCuenta"].Visible = false;
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
           
        }

        private void frmConsultaExtracto_Load(object sender, EventArgs e)
        {

        }

        //private void intentoPdf()
        //{

        //    //creamos el documento
        //    //...ahora configuramos para que el tamaño de hoja sea A4
        //    Document document = new Document(iTextSharp.text.PageSize.A4);
        //    //document.PageSize.BackgroundColor = new iTextSharp.text.colo(255, 255, 255);
        //    document.PageSize.Rotate();

        //    //...definimos el autor del documento.
        //    document.AddAuthor("Arbis Percy Reyes Paredes");

        //    //...el creador, que será el mismo eh!
        //    document.AddCreator("Arbis Percy Reyes Paredes");

        //    //hacemos que se inserte la fecha de creación para el documento
        //    document.AddCreationDate();
        //    //...título

        //    document.AddTitle("Generación de un pdf con itextSharp");
        //    //... el asunto

        //    document.AddSubject("Este es un paso muy important");
        //    //... palabras claves

        //    document.AddKeywords("pdf, PdfWriter; Documento; iTextSharp");

        //    //creamos un instancia del objeto escritor de documento
        //    PdfWriter writer = PdfWriter.GetInstance(document, new System.IO.FileStream
        //    ("Code.pdf", System.IO.FileMode.Create));


        //    //encriptamos el pdf, dándole como clave de usuario "key" y la clave del dueño será "owner"
        //    //si quitas los comentarios (en writer.SetEncryption...), entonces el documento generado
        //    //no mostrarà tanto la información de autor, titulo, fecha de creacion... 
        //    //que habiamos establecio más arriba. y sólo podrás abrirlo con una clave

        //    //writer.SetEncryption(PdfWriter.STRENGTH40BITS,"key","owner", PdfWriter.CenterWindow);

        //    //definimos la manera de inicialización de abierto del documento.
        //    //esto, hará que veamos al inicio, todas la páginas del documento
        //    //en la parte izquierda
        //    writer.ViewerPreferences = PdfWriter.PageModeUseThumbs;


        //    //con esto conseguiremos que el documento sea presentada de dos en dos 
        //    writer.ViewerPreferences = PdfWriter.PageLayoutTwoColumnLeft;

        //    //con esto podemos oculta las barras de herramienta y de menú respectivamente.
        //    //(quite las dos barras de comentario de la siguiente línea para ver los efectos)
        //    //PdfWriter.HideToolbar | PdfWriter.HideMenubar

        //    //abrimos el documento para agregarle contenido
        //    document.Open();

        //    //este stream es para jalar el código
        //    string TemPath = Application.StartupPath.ToString();
        //    TemPath = TemPath.Substring(0, TemPath.Length - 10);
        //    // string pathFileForm1cs = TemPath + @"\Form1.cs";
        //    System.IO.StreamReader reader = new System.IO.StreamReader("D:\\S2J\\Sintesi\\LanreSuit\\mdi\\solicitudes\\frmSolDeposito.cs");

        //    //leemos primera línea
        //    string linea = reader.ReadLine();

        //    //creamos la fuente
        //    iTextSharp.text.Font myfont = new iTextSharp.text.Font(
        //    FontFactory.GetFont(FontFactory.COURIER, 10, iTextSharp.text.Font.ITALIC));

        //    //creamos un objeto párrafo, donde insertamos cada una de las líneas que 
        //    //se vaya leyendo mediante el reader 
        //    Paragraph myParagraph = new Paragraph("Código fuente en Visual C# \n\n", myfont);
        //    iTextSharp.text.Image instanceImg = iTextSharp.text.Image.GetInstance(@"D:\\S2J\\Sintesi\\LanreSuit\\dll\\images\\pdf.png");
        //    myParagraph = new Paragraph();
        //    foreach (DataRow drTemp in dts.Tables[0].Rows)
        //    {

        //    }

        //    do
        //    {
        //        //leyendo linea de texto
        //        linea = reader.ReadLine();
        //        //concatenando cada parrafo que estará formado por una línea
        //        myParagraph.Add(new Paragraph(linea, myfont));
        //    } while (linea != null);  //mientras no llegue al final de documento, sigue leyendo

        //    //agregar todo el paquete de texto
        //    document.Add(myParagraph);

        //    //esto es importante, pues si no cerramos el document entonces no se creara el pdf.
        //    document.Close();

        //    //esto es para abrir el documento y verlo inmediatamente después de su creación
        //    System.Diagnostics.Process.Start("AcroRd32.exe", "Code.pdf");
        //}


    }
}
