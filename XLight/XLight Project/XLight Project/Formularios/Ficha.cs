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
		public string rutaCliente;
		public string rutaClienteRecordatorio;
		public string rutaClienteHipnosis;
		public string rutaClienteSueno;
		public string rutaClienteRegresion;
		public string rutaClienteReiki;
		public string rutaClienteTetra;

		public List<string> archivosHipnosis = new List<string>();
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

			if (cliente == null)
			{
				cliente = new Cliente(0, "Antonio", "Mateo", "0000", "0000000", "jueves, 02 de febrero de 2017", "Murcia");
			}

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

			// Cargar el cliente

			CargarHipnosis();


			richTextBoxHipnosis.Visible = false;
			BtnGuardarHipnosis.Visible = false;
		}
		#endregion

		#region Metodos Publicos
		public void CargarHipnosis()
		{
			DirectoryInfo d = new DirectoryInfo(rutaClienteHipnosis);
			FileInfo[] Files = d.GetFiles("*.txt");
			foreach (FileInfo file in Files)
			{
				archivosHipnosis.Add(file.Name);
				visualListBoxHipnosis.Items.Add(file.Name);
			}
		}

		/// <summary>
		/// <para>Abrir el log.</para>
		/// </summary>
		/// <param name="value"></param>
		public void AbrirLogHipnosis(string value)// Abrir el log
		{
			MessageBox.Show(value);
		}
		#endregion

		#region Metodos GUI
		private void visualListBoxHipnosis_SelectedIndexChanged(object sender, EventArgs e)
		{
			AbrirLogHipnosis(visualListBoxHipnosis.SelectedItem.ToString());
		}
		#endregion

		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start(usuarioActual.PathClientes);
		}

		private void BtnGuardarHipnosis_Click(object sender, EventArgs e)
		{

		}

		private void BtnCrearHipnosis_Click(object sender, EventArgs e)
		{
			richTextBoxHipnosis.Visible = true;
		}

		private void richTextBoxHipnosis_TextChanged(object sender, EventArgs e)
		{
			BtnGuardarHipnosis.Visible = true;
		}
	}
}
