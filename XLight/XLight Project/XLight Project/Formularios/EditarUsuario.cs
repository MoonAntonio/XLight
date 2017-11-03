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
using System.IO;
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
		public string nombre;                                                   // Cliente
		/// <summary>
		/// <para>Cliente</para>
		/// </summary>
		public Cliente cliente;                                                 // Cliente
		/// <summary>
		/// <para>Formulario main actual.</para>
		/// </summary>
		public Main mainForm;                                                   // Formulario main actual
		#endregion

		#region Variables Privadas
		private string nombreAntiguo;
		private string apellidosAntiguo;
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
		public EditarUsuario(Ajustes config, Usuario user, string nombreC, Main m)// Constructor de EditarUsuario
		{
			configuracionActual = config;
			usuarioActual = user;
			nombre = nombreC;
			mainForm = m;

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

				nombreAntiguo = nombr;
				apellidosAntiguo = apelli;

				if (nombre == nombr + " " + apelli)
				{
					TextNombre.Text = inCliente.SelectSingleNode("nombre").InnerText;
					TextApellidos.Text = inCliente.SelectSingleNode("apellidos").InnerText;
					TextDNI.Text = inCliente.SelectSingleNode("dni").InnerText;
					TextTelefono.Text = inCliente.SelectSingleNode("telefono").InnerText;
					DataFecha.Text = inCliente.SelectSingleNode("fecha").InnerText;
					TextDireccion.Text = inCliente.SelectSingleNode("direccion").InnerText;

					cliente = new Cliente(Int32.Parse(inCliente.SelectSingleNode("id").InnerText), inCliente.SelectSingleNode("nombre").InnerText,
											inCliente.SelectSingleNode("apellidos").InnerText, inCliente.SelectSingleNode("dni").InnerText,
											inCliente.SelectSingleNode("telefono").InnerText, inCliente.SelectSingleNode("fecha").InnerText,
											inCliente.SelectSingleNode("direccion").InnerText,"Nunca");
				}
			}

			LblTitulo.Text = "Editando al usuario " + nombre;
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
			string subID = cliente.ID.ToString();
			string subNom = TextNombre.Text;
			string subApell = TextApellidos.Text;
			string subDni = TextDNI.Text;
			string subTele = TextTelefono.Text;
			string subFech = DataFecha.Text;
			string subDire = TextDireccion.Text;


			XmlDocument doc = new XmlDocument();

			doc.Load(usuarioActual.PathClientes);

			XmlElement clientes = doc.DocumentElement;

			XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

			XmlNode nuevoCliente = doc.CreateElement("Cliente");

			XmlElement xid = doc.CreateElement("id");
			xid.InnerText = subID;
			nuevoCliente.AppendChild(xid);

			XmlElement xnom = doc.CreateElement("nombre");
			xnom.InnerText = subNom;
			nuevoCliente.AppendChild(xnom);

			XmlElement xape = doc.CreateElement("apellidos");
			xape.InnerText = subApell;
			nuevoCliente.AppendChild(xape);

			XmlElement xdni = doc.CreateElement("dni");
			xdni.InnerText = subDni;
			nuevoCliente.AppendChild(xdni);

			XmlElement xtele = doc.CreateElement("telefono");
			xtele.InnerText = subTele;
			nuevoCliente.AppendChild(xtele);

			XmlElement xfech = doc.CreateElement("fecha");
			xfech.InnerText = subFech;
			nuevoCliente.AppendChild(xfech);

			XmlElement xdir = doc.CreateElement("direccion");
			xdir.InnerText = subDire;
			nuevoCliente.AppendChild(xdir);

			foreach (XmlNode item in listaClientes)
			{
				if (item.FirstChild.InnerText == subID)
				{
					XmlNode nodo = item;
					clientes.ReplaceChild(nuevoCliente, nodo);
				}
			}

			doc.Save(usuarioActual.PathClientes);

			if (nombreAntiguo != subNom)
			{
				if (apellidosAntiguo != subApell)
				{
					if (File.Exists(configuracionActual.PathUsuarios + "/" + usuarioActual.Nombre + "/" + nombreAntiguo + " " + apellidosAntiguo))
					{
						Directory.Move(configuracionActual.PathUsuarios + "/" + usuarioActual.Nombre + "/" + nombreAntiguo + " " + apellidosAntiguo,
										configuracionActual.PathUsuarios + "/" + usuarioActual.Nombre + "/" + subNom + " " + subApell);

						Directory.Delete(configuracionActual.PathUsuarios + "/" + usuarioActual.Nombre + "/" + nombreAntiguo + " " + apellidosAntiguo);
					}
				}
			}

			mainForm.ActualizarLista();

			this.Close();
		}
		#endregion
	}
}
