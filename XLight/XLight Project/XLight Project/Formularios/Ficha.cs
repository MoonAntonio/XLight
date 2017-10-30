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
		public Cliente cliente;													// Cliente
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
		private void Ficha_Load(object sender, EventArgs e)
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
		}
		#endregion

		#region Metodos Publicos
		public void AbrirLog(string value)
		{
			MessageBox.Show(value);
		}
		#endregion

		#region Metodos GUI
		private void visualListBoxHipnosis_SelectedIndexChanged(object sender, EventArgs e)
		{
			AbrirLog(visualListBoxHipnosis.SelectedItem.ToString());
		}
		#endregion

		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start(usuarioActual.PathClientes);
		}
	}
}
