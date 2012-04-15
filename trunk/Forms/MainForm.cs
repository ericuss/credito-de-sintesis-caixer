using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestClasses.Class;
using TestClasses.Dialogs;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Serialization;
using System.IO;
using TestClasses.Helper;

namespace TestClasses
{
	public partial class MainForm : Form
	{
		List<Vehiculo> listavehiculos = new List<Vehiculo>();
		public MainForm()
		{
			InitializeComponent();
		}

		private void btnAddCoche_Click(object sender, EventArgs e)
		{
			Coche tmpCoche = new Coche();
			DialogNuevoCoche dialogCoche = new DialogNuevoCoche();

			dialogCoche.Coche = tmpCoche;
			dialogCoche.ShowDialog();
			if (tmpCoche.Matricula != null)
			{
				listavehiculos.Add(tmpCoche);
				refreshList();
			}
		}

		private void btnMoto_Click(object sender, EventArgs e)
		{
			Moto tmpMoto = new Moto();
			DialogonuevaMoto dialogmoto = new DialogonuevaMoto();

			dialogmoto.Moto = tmpMoto;
			dialogmoto.ShowDialog();
			if (tmpMoto.Matricula != null)
			{
				listavehiculos.Add(tmpMoto);
				refreshList();
			}
		}
		private void btnAddAvion_Click(object sender, EventArgs e)
		{
			Avion tmpAvion = new Avion();
			DialogoNuevoAvion dialogAvion = new DialogoNuevoAvion();

			dialogAvion.Avion = tmpAvion;
			dialogAvion.ShowDialog();
			if (tmpAvion.Matricula != null)
			{
				listavehiculos.Add(tmpAvion);
				refreshList();
			}
		}

		private void btnAddBarco_Click(object sender, EventArgs e)
		{
			Barco tmpbarco = new Barco();
			DialogNuevoBarco dialogbarco = new DialogNuevoBarco();

			dialogbarco.Barco = tmpbarco;
			dialogbarco.ShowDialog();
			if (tmpbarco.Matricula != null)
			{
				listavehiculos.Add(tmpbarco);
				refreshList();
			}
		}
		private void refreshList()
		{
			for (int i = 0; i < lbVehiculos.Items.Count; i++)
			{
				lbVehiculos.Items.RemoveAt(i);
			}
			foreach (Vehiculo i in listavehiculos)
			{
				lbVehiculos.Items.Add(i);
			}
		}

		private void btnExportar_Click(object sender, EventArgs e)
		{
			String file;
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();

			saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			saveFileDialog1.FilterIndex = 2;
			saveFileDialog1.RestoreDirectory = true;

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				if ((file = saveFileDialog1.FileName) != null)
				{
					String text = "";
					foreach (Vehiculo i in listavehiculos)
					{
						text += i.ToString() + "\n";
					}

					File.WriteAllText(file, text);
					MessageBox.Show("Exportado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void btnImportar_Click(object sender, EventArgs e)
		{
			Instanciador instancier = new Instanciador();
			try
			{
				String file;
				OpenFileDialog openFileDialog1 = new OpenFileDialog();

				openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
				openFileDialog1.FilterIndex = 2;
				openFileDialog1.RestoreDirectory = true;

				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					if ((file = openFileDialog1.FileName) != null)
					{
						using (StreamReader sr = new StreamReader(file))
						{
							String line;
							Boolean error = false;
							while ((line = sr.ReadLine()) != null)
							{
								String obj = line.Split(':')[0];
								String att = line.Split(':')[1];

								switch (obj)
								{
									case "Coche":
										Coche tmpCoche = instancier.instanciarCoche(att);
										listavehiculos.Add(tmpCoche);
										break;
									case "Moto":
										Moto tmpMoto = instancier.instanciarMoto(att);
										listavehiculos.Add(tmpMoto);
										break;
									case "Avion":
										Avion tmpAvion = instancier.instanciarAvion(att);
										listavehiculos.Add(tmpAvion);
										break;
									case "Barco":
										Barco tmpBarco = instancier.instanciarBarco(att);
										listavehiculos.Add(tmpBarco);
										break;
									default:
										error = true;
										break;
								}
							}

							if (error)
							{
								MessageBox.Show("Tipo de Objeto no contemplado. \n Por favor revisa el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			refreshList();
		}
	}
}
