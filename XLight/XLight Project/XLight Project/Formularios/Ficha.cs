//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// Ficha.cs (01/10/2017)                                              			\\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:     Formulario de Ficha											\\
// Fecha Mod:       01/10/2017                                                  \\
// Ultima Mod:      Version Inicial												\\
//******************************************************************************\\

#region Librerias
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using XLight_Project.Clases;
#endregion

namespace XLight_Project.Formularios
{
	/// <summary>
	/// <para>Formulario de Ficha</para>
	/// </summary>
	public partial class Ficha : Form
	{
		#region Variables Publicas
		/// <summary>
		/// <para>Configuracion actual de los ajustes.</para>
		/// </summary>
		public Ajustes configuracionActual;                                     // Configuracion actual de los ajustes
		/// <summary>
		/// <para>Usuario actual del sistema.</para>
		/// </summary>
		public Usuario usuarioActual;                                           // Usuario actual del sistema
		/// <summary>
		/// <para>Nombre y apellidos del cliente.</para>
		/// </summary>
		public string clienteN;                                                 // Nombre y apellidos del cliente
		/// <summary>
		/// <para>Cliente</para>
		/// </summary>
		public Cliente cliente;                                                 // Cliente
		/// <summary>
		/// <para>Ruta del cliente.</para>
		/// </summary>
		public string rutaCliente;												// Ruta del cliente
		/// <summary>
		/// <para>Ruta de los recordatorios.</para>
		/// </summary>
		public string rutaClienteRecordatorio;									// Ruta de los recordatorios
		/// <summary>
		/// <para>Ruta de hipnosis.</para>
		/// </summary>
		public string rutaClienteHipnosis;										// Ruta de hipnosis
		/// <summary>
		/// <para>Ruta de interpretar.</para>
		/// </summary>
		public string rutaClienteSueno;											// Ruta de interpretar
		/// <summary>
		/// <para>Ruta de regresion.</para>
		/// </summary>
		public string rutaClienteRegresion;										// Ruta de regresion
		/// <summary>
		/// <para>Ruta de reiki.</para>
		/// </summary>
		public string rutaClienteReiki;											// Ruta de reiki
		/// <summary>
		/// <para>Ruta de tetra.</para>
		/// </summary>
		public string rutaClienteTetra;											// Ruta de tetra
		#endregion

		#region Variables Privadas
		/// <summary>
		/// <para>Determina si se esta creando actualmente el archivo.</para>
		/// </summary>
		private bool isCreando = false;											// Determina si se esta creando actualmente el archivo
		/// <summary>
		/// <para>Ruta de lectura del archivo.</para>
		/// </summary>
		private string rutaLectura;												// Ruta de lectura del archivo
		#endregion

		#region Constructores
		/// <summary>
		/// <para>Constructor de <see cref="Ficha"/>.</para>
		/// </summary>
		public Ficha()// Constructor de Ficha
		{
			InitializeComponent();
		}

		/// <summary>
		/// <para>Constructor de <see cref="Ficha"/>.</para>
		/// </summary>
		/// <param name="config">Configuracion actual de los ajustes</param>
		/// <param name="user">Usuario actual del sistema</param>
		/// <param name="nombre">Nombre y apellidos del cliente</param>
		public Ficha(Ajustes config, Usuario user, string nombre)// Constructor de Ficha
		{
			configuracionActual = config;
			usuarioActual = user;
			clienteN = nombre;

			InitializeComponent();
		}
		#endregion

		#region Loader
		/// <summary>
		/// <para>Loader de <see cref="Ficha"/>.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Ficha_Load(object sender, EventArgs e)// Loader de Ficha
		{
			// TODO Para testear
			if (configuracionActual == null)
			{
				string pD = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data");
				string pU = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), pD + @"\Usuarios");
				string pA = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Ajustes\ajustes.xml");
				string uU = "Admin";

				configuracionActual = new Ajustes(pD, pU, pA, uU);
			}

			if (usuarioActual == null)
			{
				string pH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), configuracionActual.PathData + @"\Usuarios\Admin\historial.xml");
				string pC = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), configuracionActual.PathData + @"\Usuarios\Admin\clientes.xml");

				usuarioActual = new Usuario("Admin", "Admin", 0, pH, pC, 0, 0);
			}

			// Cargar el cliente
			// TODO Version final
			if (cliente == null)
			{
				cliente = new Cliente(0, "Antonio", "Mateo", "0000", "0000000", "jueves, 02 de febrero de 2017", "Murcia", "Noviembre 03");
			}

			// Si la patch no existe
			if (!File.Exists(configuracionActual.PathUsuarios + "/" + usuarioActual.Nombre + "/" + cliente.Nombre + " " + cliente.Apellidos))
			{

				rutaCliente = configuracionActual.PathUsuarios + "/" + usuarioActual.Nombre + "/" + cliente.Nombre + " " + cliente.Apellidos + "/";
				rutaClienteRecordatorio = rutaCliente + "Recordatorio";
				rutaClienteHipnosis = rutaCliente + "Hipnosis";
				rutaClienteSueno = rutaCliente + "Interpretar";
				rutaClienteRegresion = rutaCliente + "Regresion";
				rutaClienteReiki = rutaCliente + "Reiki";
				rutaClienteTetra = rutaCliente + "Tetra";

				Directory.CreateDirectory(configuracionActual.PathUsuarios + "/" + usuarioActual.Nombre + "/" + cliente.Nombre + " " + cliente.Apellidos);
				Directory.CreateDirectory(rutaCliente + "Recordatorio");
				Directory.CreateDirectory(rutaCliente + "Hipnosis");
				Directory.CreateDirectory(rutaCliente + "Interpretar");
				Directory.CreateDirectory(rutaCliente + "Regresion");
				Directory.CreateDirectory(rutaCliente + "Reiki");
				Directory.CreateDirectory(rutaCliente + "Tetra");
			}
			else
			{
				rutaCliente = configuracionActual.PathUsuarios + "/" + usuarioActual.Nombre + "/" + cliente.Nombre + " " + cliente.Apellidos + "/";
				rutaClienteRecordatorio = rutaCliente + "Recordatorio";
				rutaClienteHipnosis = rutaCliente + "Hipnosis";
				rutaClienteSueno = rutaCliente + "Interpretar";
				rutaClienteRegresion = rutaCliente + "Regresion";
				rutaClienteReiki = rutaCliente + "Reiki";
				rutaClienteTetra = rutaCliente + "Tetra";
			}

			
			// Cargar los documentos
			CargarHipnosis();
			CargarInterpretar();
			CargarRegresion();

			// Resetear GUI
			richTextBoxHipnosis.Visible = false;
			BtnGuardarHipnosis.Visible = false;
			BtnImprimirHipnosis.Visible = false;

			richTextBoxInterpretar.Visible = false;
			BtnGuardarInterpretar.Visible = false;
			BtnImprimirInterpretar.Visible = false;

			richTextBoxRegresion.Visible = false;
			BtnGuardarRegresion.Visible = false;
			BtnImprimirRegresion.Visible = false;
		}
		#endregion

		#region Metodos Publicos
		#region Hipnosis
		/// <summary>
		/// <para>Cargar los documentos de hipnosis.</para>
		/// </summary>
		public void CargarHipnosis()// Cargar los documentos de hipnosis
		{
			visualListBoxHipnosis.Items.Clear();

			DirectoryInfo d = new DirectoryInfo(rutaClienteHipnosis);
			FileInfo[] Files = d.GetFiles("*.txt");
			foreach (FileInfo file in Files)
			{
				visualListBoxHipnosis.Items.Add(file.Name);
			}
		}

		/// <summary>
		/// <para>Abrir el log.</para>
		/// </summary>
		/// <param name="value"></param>
		public void AbrirLogHipnosis(string value)// Abrir el log
		{
			richTextBoxHipnosis.Visible = true;
			richTextBoxHipnosis.Text = File.ReadAllText(rutaClienteHipnosis + "/" + value);
			rutaLectura = rutaClienteHipnosis + "/" + value;
		}
		#endregion

		#region Interpretar
		/// <summary>
		/// <para>Cargar los documentos de sueños.</para>
		/// </summary>
		public void CargarInterpretar()// Cargar los documentos de sueños
		{
			visualListBoxInterpretar.Items.Clear();

			DirectoryInfo d = new DirectoryInfo(rutaClienteSueno);
			FileInfo[] Files = d.GetFiles("*.txt");
			foreach (FileInfo file in Files)
			{
				visualListBoxInterpretar.Items.Add(file.Name);
			}
		}

		/// <summary>
		/// <para>Abrir el log.</para>
		/// </summary>
		/// <param name="value"></param>
		public void AbrirLogInterpretar(string value)// Abrir el log
		{
			richTextBoxInterpretar.Visible = true;
			richTextBoxInterpretar.Text = File.ReadAllText(rutaClienteSueno + "/" + value);
			rutaLectura = rutaClienteSueno + "/" + value;
		}
		#endregion

		#region Regresion
		/// <summary>
		/// <para>Cargar los documentos de regresion.</para>
		/// </summary>
		public void CargarRegresion()// Cargar los documentos de regresion
		{
			visualListBoxRegresion.Items.Clear();

			DirectoryInfo d = new DirectoryInfo(rutaClienteRegresion);
			FileInfo[] Files = d.GetFiles("*.txt");
			foreach (FileInfo file in Files)
			{
				visualListBoxRegresion.Items.Add(file.Name);
			}
		}

		/// <summary>
		/// <para>Abrir el log.</para>
		/// </summary>
		/// <param name="value"></param>
		public void AbrirLogRegresion(string value)// Abrir el log
		{
			richTextBoxRegresion.Visible = true;
			richTextBoxRegresion.Text = File.ReadAllText(rutaClienteRegresion + "/" + value);
			rutaLectura = rutaClienteRegresion + "/" + value;
		}
		#endregion
		#endregion

		#region Metodos GUI
		/// <summary>
		/// <para>Cuando cambia</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void visualListBoxHipnosis_SelectedIndexChanged(object sender, EventArgs e)// Cuando cambia
		{
			AbrirLogHipnosis(visualListBoxHipnosis.SelectedItem.ToString());
		}

		#region Hipnosis
		/// <summary>
		/// <para>Cuando hay texto</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void richTextBoxHipnosis_TextChanged(object sender, EventArgs e)// Cuando hay texto
		{
			BtnGuardarHipnosis.Visible = true;
			BtnImprimirHipnosis.Visible = true;
		}

		/// <summary>
		/// <para>Para crear un nuevo log.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnCrearHipnosis_Click(object sender, EventArgs e)// Para crear un nuevo log
		{
			richTextBoxHipnosis.Visible = true;
			isCreando = true;
		}

		/// <summary>
		/// <para>Guarda el documento hipnosis.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnGuardarHipnosis_Click(object sender, EventArgs e)// Guarda el documento hipnosis
		{
			DateTime diahora = DateTime.Now;
			string dia = diahora.ToString("dddd dd MMMM");

			if (isCreando)
			{
				isCreando = false;
				File.WriteAllText(rutaClienteHipnosis + "/" + dia + ".txt", richTextBoxHipnosis.Text);
				richTextBoxHipnosis.Clear();
				richTextBoxHipnosis.Visible = false;
				CargarHipnosis();
			}
			else
			{
				isCreando = false;
				File.WriteAllText(rutaClienteHipnosis + "/" + rutaLectura, richTextBoxHipnosis.Text);
				richTextBoxHipnosis.Clear();
				richTextBoxHipnosis.Visible = false;
				CargarHipnosis();
			}
		}

		/// <summary>
		/// <para>Imprime el documento de hipnosis.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnImprimirHipnosis_Click(object sender, EventArgs e)// Imprime el documento de hipnosis
		{

		}
		#endregion

		#region Interpretar
		/// <summary>
		/// <para>Cuando hay texto</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void richTextBoxInterpretar_TextChanged(object sender, EventArgs e)// Cuando hay texto
		{
			BtnGuardarInterpretar.Visible = true;
			BtnImprimirInterpretar.Visible = true;
		}

		/// <summary>
		/// <para>Para crear un nuevo log.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnCrearInterpretar_Click(object sender, EventArgs e)// Para crear un nuevo log
		{
			richTextBoxInterpretar.Visible = true;
			isCreando = true;
		}

		/// <summary>
		/// <para>Guarda el documento interpretar</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnGuardarInterpretar_Click(object sender, EventArgs e)// Guarda el documento interpretar
		{
			DateTime diahora = DateTime.Now;
			string dia = diahora.ToString("dddd dd MMMM");

			if (isCreando)
			{
				isCreando = false;
				File.WriteAllText(rutaClienteSueno + "/" + dia + ".txt", richTextBoxInterpretar.Text);
				richTextBoxInterpretar.Clear();
				richTextBoxInterpretar.Visible = false;
				CargarInterpretar();
			}
			else
			{
				isCreando = false;
				File.WriteAllText(rutaClienteSueno + "/" + rutaLectura, richTextBoxInterpretar.Text);
				richTextBoxInterpretar.Clear();
				richTextBoxInterpretar.Visible = false;
				CargarInterpretar();
			}
		}

		/// <summary>
		/// <para>Imprime el documento de hipnosis.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnImprimirInterpretar_Click(object sender, EventArgs e)// Imprime el documento de hipnosis
		{

		}
		#endregion

		#region Regresion
		/// <summary>
		/// <para>Cuando hay texto</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void richTextBoxRegresion_TextChanged(object sender, EventArgs e)// Cuando hay texto
		{
			BtnGuardarRegresion.Visible = true;
			BtnImprimirRegresion.Visible = true;
		}

		/// <summary>
		/// <para>Para crear un nuevo log</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnCrearRegresion_Click(object sender, EventArgs e)// Para crear un nuevo log
		{
			richTextBoxRegresion.Visible = true;
			isCreando = true;
		}

		/// <summary>
		/// <para>Guarda el documento regresion</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnGuardarRegresion_Click(object sender, EventArgs e)// Guarda el documento regresion
		{
			DateTime diahora = DateTime.Now;
			string dia = diahora.ToString("dddd dd MMMM");

			if (isCreando)
			{
				isCreando = false;
				File.WriteAllText(rutaClienteRegresion + "/" + dia + ".txt", richTextBoxRegresion.Text);
				richTextBoxRegresion.Clear();
				richTextBoxRegresion.Visible = false;
				CargarRegresion();
			}
			else
			{
				isCreando = false;
				File.WriteAllText(rutaClienteRegresion + "/" + rutaLectura, richTextBoxRegresion.Text);
				richTextBoxRegresion.Clear();
				richTextBoxRegresion.Visible = false;
				CargarRegresion();
			}
		}

		/// <summary>
		/// <para>Imprime el documento de hipnosis.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnImprimirRegresion_Click(object sender, EventArgs e)// Imprime el documento de hipnosis
		{

		}
		#endregion

		#endregion


	}
}
