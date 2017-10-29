//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// EditarUsuario.cs (01/10/2017)                                              	\\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:     Formulario de EditarUsuario									\\
// Fecha Mod:       01/10/2017                                                  \\
// Ultima Mod:      Version Inicial												\\
//******************************************************************************\\

#region Librerias
using System;
using System.Windows.Forms;
using System.Xml;
using XLight_Project.Clases;
#endregion

namespace XLight_Project.Formularios
{
	/// <summary>
	/// <para>Formulario de EditarUsuario.</para>
	/// </summary>
	public partial class EditarUsuario : Form
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
		/// <para>Cliente</para>
		/// </summary>
		public string cliente;                                                  // Cliente
		#endregion

		#region Constructores
		/// <summary>
		/// <para>Constructor de <see cref="EditarUsuario"/>.</para>
		/// </summary>
		public EditarUsuario()// Constructor de EditarUsuario
		{
			InitializeComponent();
		}

		/// <summary>
		/// <para>Constructor de <see cref="EditarUsuario"/>.</para>
		/// </summary>
		/// <param name="config">Configuracion actual.</param>
		/// <param name="user">Usuario actual.</param>
		/// <param name="nombre">Nombre del cliente.</param>
		public EditarUsuario(Ajustes config, Usuario user, string nombre)// Constructor de EditarUsuario
		{
			configuracionActual = config;
			usuarioActual = user;
			cliente = nombre;

			InitializeComponent();
		}
		#endregion

		#region Loader
		/// <summary>
		/// <para>Loader de <see cref="EditarUsuario"/>.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EditarUsuario_Load(object sender, EventArgs e)// Loader de EditarUsuario
		{
			XmlDocument doc = new XmlDocument();

			doc.Load(usuarioActual.PathClientes);

			XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");
			XmlNode inCliente;

			for (int n = 0; n < listaClientes.Count; n++)
			{
				inCliente = listaClientes.Item(n);

				string nombr = inCliente.SelectSingleNode("nombre").InnerText;
				string apelli = inCliente.SelectSingleNode("apellidos").InnerText;

				if (cliente == nombr + " " + apelli)
				{
					TextNombre.Text = inCliente.SelectSingleNode("nombre").InnerText;
					TextApellidos.Text = inCliente.SelectSingleNode("apellidos").InnerText;
					TextDNI.Text = inCliente.SelectSingleNode("dni").InnerText;
					TextTelefono.Text = inCliente.SelectSingleNode("telefono").InnerText;
					DataFecha.Text = inCliente.SelectSingleNode("fecha").InnerText;
					TextDireccion.Text = inCliente.SelectSingleNode("direccion").InnerText;
				}
			}
		}

		#endregion

		#region Metodos GUI
		/// <summary>
		/// <para>Guardar y salir.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnGuardarUsuario_Click(object sender, EventArgs e)// Guardar y salir
		{


			this.Close();
		}
		#endregion
	}
}
