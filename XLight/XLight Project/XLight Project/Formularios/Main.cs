﻿//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// Main.cs (01/10/2017)                                              			\\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:     Formulario de Main											\\
// Fecha Mod:       01/10/2017                                                  \\
// Ultima Mod:      Version Inicial												\\
//******************************************************************************\\

#region Librerias
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using XLight_Project.Clases;
#endregion

namespace XLight_Project.Formularios
{
	/// <summary>
	/// <para>Formulario de Main</para>
	/// </summary>
	public partial class Main : Form
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
		/// <para>Nombre de los clientes</para>
		/// </summary>
		public List<string> nombresClientes = new List<string>();				// Nombre de los clientes
		#endregion

		#region Variables Privadas
		/// <summary>
		/// <para>Id actual</para>
		/// </summary>
		private int idActual;													// Id actual
		#endregion

		#region Constructores
		/// <summary>
		/// <para>Constructor de <see cref="Main"/>.</para>
		/// </summary>
		public Main()// Constructor de Main
		{
			InitializeComponent();
		}

		/// <summary>
		/// <para>Constructor de <see cref="Main"/>.</para>
		/// </summary>
		public Main(Ajustes config, Usuario user)// Constructor de Main
		{
			configuracionActual = config;
			usuarioActual = user;

			InitializeComponent();
		}
		#endregion

		#region Loader
		/// <summary>
		/// <para>Loader de <see cref="Main"/>.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Main_Load(object sender, EventArgs e)// Loader de Main
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

			LblUser.Text = "." + usuarioActual.Nombre + " nvl." + usuarioActual.NivelPrivilegios;
			idActual = usuarioActual.IdActual;

			ActualizarBusquedaRegistro();

			AutoCompletar();
		}
		#endregion

		#region Metodos
		/// <summary>
		/// <para>Agrega un elemento.</para>
		/// </summary>
		/// <param name="id"></param>
		/// <param name="nom"></param>
		/// <param name="tipo"></param>
		/// <param name="fecha"></param>
		/// <param name="precio"></param>
		/// <param name="resultado"></param>
		public void AgregarCliente(string id, string nom, string apell, string dni, string telefon, string fecha, string direccion)// Agrega un elemento
		{
			XmlDocument doc = new XmlDocument();

			doc.Load(usuarioActual.PathClientes);

			XmlNode cliente = doc.CreateElement("Cliente");
			XmlElement xid = doc.CreateElement("id");
			xid.InnerText = id;
			cliente.AppendChild(xid);

			XmlElement xnom = doc.CreateElement("nombre");
			xnom.InnerText = nom;
			cliente.AppendChild(xnom);

			XmlElement xapell = doc.CreateElement("apellidos");
			xapell.InnerText = apell;
			cliente.AppendChild(xapell);

			XmlElement xdni = doc.CreateElement("dni");
			xdni.InnerText = dni;
			cliente.AppendChild(xdni);

			XmlElement xtele = doc.CreateElement("telefono");
			xtele.InnerText = telefon;
			cliente.AppendChild(xtele);

			XmlElement xfecha = doc.CreateElement("fecha");
			xfecha.InnerText = fecha;
			cliente.AppendChild(xfecha);

			XmlElement xdirecc = doc.CreateElement("direccion");
			xdirecc.InnerText = direccion;
			cliente.AppendChild(xdirecc);

			doc.DocumentElement.AppendChild(cliente);
			doc.Save(usuarioActual.PathClientes);

			usuarioActual.IdActual = usuarioActual.IdActual + 1;
			idActual = usuarioActual.IdActual;

			GuardarCliente(idActual.ToString(), nom, apell, dni, telefon, fecha, direccion);
		}

		/// <summary>
		/// <para>Guarda los datos de un cliente.</para>
		/// </summary>
		/// <param name="id"></param>
		/// <param name="nom"></param>
		/// <param name="apell"></param>
		/// <param name="dni"></param>
		/// <param name="telefon"></param>
		/// <param name="fecha"></param>
		/// <param name="direccion"></param>
		public void GuardarCliente(string id, string nom, string apell, string dni, string telefon, string fecha, string direccion)// Guarda los datos de un cliente
		{
			XmlDocument doc = new XmlDocument();

			doc.Load(usuarioActual.PathClientes);

			XmlElement clientes = doc.DocumentElement;

			XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

			XmlNode nuevoCliente = doc.CreateElement("Cliente");

			XmlElement xid = doc.CreateElement("id");
			xid.InnerText = id;
			nuevoCliente.AppendChild(xid);

			XmlElement xnom = doc.CreateElement("nombre");
			xnom.InnerText = nom;
			nuevoCliente.AppendChild(xnom);

			XmlElement xapell = doc.CreateElement("apellidos");
			xapell.InnerText = apell;
			nuevoCliente.AppendChild(xapell);

			XmlElement xdni = doc.CreateElement("dni");
			xdni.InnerText = dni;
			nuevoCliente.AppendChild(xdni);

			XmlElement xtele = doc.CreateElement("telefono");
			xtele.InnerText = telefon;
			nuevoCliente.AppendChild(xtele);

			XmlElement xfecha = doc.CreateElement("fecha");
			xfecha.InnerText = fecha;
			nuevoCliente.AppendChild(xfecha);

			XmlElement xdirecc = doc.CreateElement("direccion");
			xdirecc.InnerText = direccion;
			nuevoCliente.AppendChild(xdirecc);

			foreach (XmlNode item in listaClientes)
			{
				if (item.FirstChild.InnerText == id)
				{
					XmlNode nodo = item;
					clientes.ReplaceChild(nuevoCliente, nodo);
				}
			}

			doc.Save(usuarioActual.PathClientes);
		}

		/// <summary>
		/// <para>Crea una entrada en el registro</para>
		/// </summary>
		/// <param name="ruta"></param>
		/// <param name="id"></param>
		/// <param name="nom"></param>
		/// <param name="tipo"></param>
		/// <param name="fecha"></param>
		/// <param name="precio"></param>
		/// <param name="resultado"></param>
		public void CrearEntradaHistoria(string nombre, string apellidos, string suceso , string fecha)// Crea una entrada en el registro
		{
			XmlDocument doc = new XmlDocument();

			doc.Load(usuarioActual.PathHistorial);

			XmlNode cliente = doc.CreateElement("Entrada");

			XmlElement xnomb = doc.CreateElement("nombre");
			xnomb.InnerText = nombre;
			cliente.AppendChild(xnomb);

			XmlElement xapell = doc.CreateElement("apellidos");
			xapell.InnerText = apellidos;
			cliente.AppendChild(xapell);

			XmlElement xsuceso = doc.CreateElement("suceso");
			xsuceso.InnerText = suceso;
			cliente.AppendChild(xsuceso);

			XmlElement xfecha = doc.CreateElement("fecha");
			xfecha.InnerText = fecha;
			cliente.AppendChild(xfecha);

			doc.DocumentElement.AppendChild(cliente);
			doc.Save(usuarioActual.PathHistorial);
		}

		/// <summary>
		/// <para>Actualiza la busqueda de registro</para>
		/// </summary>
		public void ActualizarBusquedaRegistro()// Actualiza la busqueda de registro
		{
			dataGridView1.Rows.Clear();
			XmlDocument doc = new XmlDocument();

			doc.Load(usuarioActual.PathClientes);

			XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");
			XmlNode inCliente;

			DataTable tabla = new DataTable();


			for (int n = 0; n < listaClientes.Count; n++)
			{
				inCliente = listaClientes.Item(n);

				string id = inCliente.SelectSingleNode("id").InnerText;
				string nombre = inCliente.SelectSingleNode("nombre").InnerText;
				string apellidos = inCliente.SelectSingleNode("apellidos").InnerText;
				string dni = inCliente.SelectSingleNode("dni").InnerText;
				string telefono = inCliente.SelectSingleNode("telefono").InnerText;
				string fecha = inCliente.SelectSingleNode("fecha").InnerText;
				string direccion = inCliente.SelectSingleNode("direccion").InnerText;

				dataGridView1.Rows.Add(id, nombre, apellidos,dni,telefono,fecha,direccion);
			}
		}

		/// <summary>
		/// <para>Autocompleta la busqueda</para>
		/// </summary>
		public void AutoCompletar()// Autocompleta la busqueda
		{
			nombresClientes.Clear();

			txtBoxBuscadorRegistro.AutoCompleteSource = AutoCompleteSource.CustomSource;
			txtBoxBuscadorRegistro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

			XmlDocument doc = new XmlDocument();

			doc.Load(usuarioActual.PathClientes);

			XmlElement cliente = doc.DocumentElement;

			XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

			foreach (XmlNode item in listaClientes)
			{
				string nodo = item["nombre"].InnerText;
				string nodoape = item["apellidos"].InnerText;

				nombresClientes.Add(nodo + " " + nodoape);
			}

			doc.Save(usuarioActual.PathClientes);

			DataTable dt = new DataTable();
			dt.Columns.Add("nombre", typeof(string));

			for (int i = 0; i < nombresClientes.Count; i++)
			{
				dt.Rows.Add(nombresClientes[i]);
			}

			for (int n = 0; n < dt.Rows.Count; n++)
			{
				string name = dt.Rows[n]["nombre"].ToString();
				coll.Add(name);
			}

			txtBoxBuscadorRegistro.AutoCompleteCustomSource = coll;
		}
		#endregion

		#region Metodos GUI
		/// <summary>
		/// <para>Minimiza la pantalla.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnMinimizar_Click(object sender, EventArgs e)// Minimiza la pantalla
		{
			this.WindowState = FormWindowState.Minimized;
		}

		/// <summary>
		/// <para>Maximiza la pantalla.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnMaximizar_Click(object sender, EventArgs e)// Maximiza la pantalla
		{
			if (this.WindowState == FormWindowState.Maximized)
			{
				this.WindowState = FormWindowState.Normal;
			}
			else
			{
				this.WindowState = FormWindowState.Maximized;
			}
		}

		/// <summary>
		/// <para>Sale de la app.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnSalir_Click(object sender, EventArgs e)// Sale de la app
		{
			Application.Exit();
		}

		/// <summary>
		/// <para>Abre clientes.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnClientes_Click(object sender, EventArgs e)// Abre clientes
		{
			LblUser.Text = "." + usuarioActual.Nombre + " nvl." + usuarioActual.NivelPrivilegios + " >> " + "Clientes";
		}

		/// <summary>
		/// <para>Abre el balance.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnBalance_Click(object sender, EventArgs e)// Abre el balance
		{
			if (usuarioActual.NivelPrivilegios == 0)
			{
				LblUser.Text = "." + usuarioActual.Nombre + " nvl." + usuarioActual.NivelPrivilegios + " >> " + "Balance";
			}
			else
			{
				MessageBox.Show("No tienes privilegios suficientes. Contacta con tu admin.");
			}
		}

		/// <summary>
		/// <para>Abre el historial</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnHistorial_Click(object sender, EventArgs e)// Abre el historial
		{
			LblUser.Text = "." + usuarioActual.Nombre + " nvl." + usuarioActual.NivelPrivilegios + " >> " + "Historial";
		}

		/// <summary>
		/// <para>Abre las opciones</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnOpciones_Click(object sender, EventArgs e)// Abre las opciones
		{
			LblUser.Text = "." + usuarioActual.Nombre + " nvl." + usuarioActual.NivelPrivilegios + " >> " + "Opciones";
		}

		/// <summary>
		/// <para>Agregar cliente</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnAgregarNuevoCliente_Click(object sender, EventArgs e)// Agregar cliente
		{
			if (TextNombre.Text == string.Empty)
			{
				MessageBox.Show("Tienes que completar nombre como minimo.");
			}
			else
			{
				DateTime diahora = DateTime.Now;
				string dia = diahora.ToString("dddd dd MMMM");

				// Agregar cliente
				AgregarCliente(idActual.ToString(), TextNombre.Text, TextApellidos.Text, TextDNI.Text, TextTelefono.Text, DataFecha.Text, TextDireccion.Text);

				// Agregar entrada
				CrearEntradaHistoria(TextNombre.Text, TextApellidos.Text, "Nuevo cliente", dia);

				// Borrar info
				TextNombre.Text = "";
				TextApellidos.Text = "";

				// Actualizar lista
				ActualizarBusquedaRegistro();
				AutoCompletar();

				// Mostrar mensaje
				MessageBox.Show("Cliente agregado.");
			}
		}
		#endregion



		private void BtnAbrirFicha_Click(object sender, EventArgs e)
		{

		}

		private void BtnEditar_Click(object sender, EventArgs e)
		{

		}

		private void BtnBorrar_Click(object sender, EventArgs e)
		{

		}
	}
}