//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// Splash.cs (01/10/2017)                                              			\\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:     Formulario de splash										\\
// Fecha Mod:       01/10/2017                                                  \\
// Ultima Mod:      Version Inicial												\\
//******************************************************************************\\

#region Librerias
using System;
using System.IO;
using System.Windows.Forms;
using XLight.Clases;
#endregion


namespace XLight
{
	/// <summary>
	/// <para>Formulario de splash</para>
	/// </summary>
	public partial class Splash : Form
	{
		#region Constructor
		public Splash()
		{
			InitializeComponent();

		}
		#endregion

		#region Loader
		private void Splash_Load(object sender, EventArgs e)
		{
			StringMaestro master = new StringMaestro();

			if (master.pathHistorial == string.Empty)
			{
				if (!File.Exists("Data"))
				{
					Directory.CreateDirectory("Data");
				}

				if (!File.Exists("Data/historial.xml"))
				{
					Xml xml = new Xml();
					xml.CrearXML("Data/historial.xml", "Clientes");
				}

				if (!File.Exists("Data/clientes.xml"))
				{
					Xml xml = new Xml();
					xml.CrearXML("Data/clientes.xml", "Clientes");
				}
			}
		}
		#endregion

		#region Metodos
		/// <summary>
		/// <para>Timer</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Timer1_Tick(object sender, EventArgs e)// Timer
		{
			try
			{
				progressBar.Width += 1;
				ProcesarTexto();
				if (progressBar.Width >= 635f)
				{
					timer1.Stop();
					Main main = new Main();
					main.Show();
					this.Hide();
				}
			}
			catch (Exception)
			{
				return;
			}
		}

		/// <summary>
		/// <para>Procesa el texto.</para>
		/// </summary>
		private void ProcesarTexto()// Procesa el texto
		{
			switch (progressBar.Width)
			{
				case 100:
					lblSeguimiento.Text = "Cargando componentes ...";
					break;

				case 300:
					lblSeguimiento.Text = "Generando recursos ...";
					break;

				case 500:
					lblSeguimiento.Text = "Cargando sistema ...";
					break;

				case 600:
					lblSeguimiento.Text = "Inicializando sistema ...";
					break;
			}
		}
		#endregion
	}
}
