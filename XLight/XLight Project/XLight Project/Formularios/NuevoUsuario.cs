//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// NuevoUsuario.cs (01/10/2017)                                              	\\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:     Formulario de NuevoUsuario									\\
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
	/// <para>Formulario de NuevoUsuario</para>
	/// </summary>
	public partial class NuevoUsuario : Form
	{
		#region Variables Publicas
		/// <summary>
		/// <para>Configuracion actual de los ajustes.</para>
		/// </summary>
		public Ajustes configuracionActual;                                     // Configuracion actual de los ajustes
		#endregion

		#region Constructores
		/// <summary>
		/// <para>Constructor de <see cref="NuevoUsuario"/></para>
		/// </summary>
		public NuevoUsuario()// Constructor de NuevoUsuario
		{
			InitializeComponent();
		}

		/// <summary>
		/// <para>Constructor de <see cref="NuevoUsuario"/></para>
		/// </summary>
		/// <param name="config">Configuracion actual.</param>
		public NuevoUsuario(Ajustes config)// Constructor de NuevoUsuario
		{
			configuracionActual = config;

			InitializeComponent();
		}
		#endregion

		#region Metodos GUI
		/// <summary>
		/// <para>Crear usuaio</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnCrear_Click(object sender, EventArgs e)// Crear usuaio
		{
			XmlDocument doc = new XmlDocument();

			doc.Load(configuracionActual.PathUsuarios + "/usuarios.xml");

			XmlNode cliente = doc.CreateElement("Usuario");

			XmlElement nombr = doc.CreateElement("nombre");
			nombr.InnerText = visualTextBoxNombre.Text;
			cliente.AppendChild(nombr);

			XmlElement pass = doc.CreateElement("password");
			pass.InnerText = visualTextBoxApellidos.Text;
			cliente.AppendChild(pass);

			XmlElement nvl = doc.CreateElement("nivel");
			nvl.InnerText = visualNumericUpDown1.Text;
			cliente.AppendChild(nvl);

			XmlElement rutaHistorial = doc.CreateElement("rutahistorial");
			rutaHistorial.AppendChild(doc.CreateTextNode(configuracionActual.PathUsuarios + @"\" + visualTextBoxNombre.Text + @"\historial.xml"));
			cliente.AppendChild(rutaHistorial);

			XmlElement rutaClientes = doc.CreateElement("rutaclientes");
			rutaClientes.AppendChild(doc.CreateTextNode(configuracionActual.PathUsuarios +@"\" + visualTextBoxNombre.Text + @"\clientes.xml"));
			cliente.AppendChild(rutaClientes);

			XmlElement idInicial = doc.CreateElement("idactual");
			idInicial.AppendChild(doc.CreateTextNode("0"));
			cliente.AppendChild(idInicial);

			XmlElement inicioAut = doc.CreateElement("inicioautomatico");
			inicioAut.AppendChild(doc.CreateTextNode("0"));
			cliente.AppendChild(inicioAut);

			doc.DocumentElement.AppendChild(cliente);
			doc.Save(configuracionActual.PathUsuarios + "/usuarios.xml");

			Directory.CreateDirectory("Data/Usuarios/" + visualTextBoxNombre.Text);

			CrearClientes("Data/Usuarios/" + visualTextBoxNombre.Text + "/clientes.xml", "Clientes");
			CrearHistorial("Data/Usuarios/" + visualTextBoxNombre.Text + "/historial.xml", "Entradas");

			MessageBox.Show("Usuario creado.");

			this.Close();
		}
		#endregion

		#region Metodos
		/// <summary>
		/// <para>Crear los clientes del sistema</para>
		/// </summary>
		/// <param name="ruta">Ruta del archivo.</param>
		/// <param name="nodoRaiz">Nodo principal.</param>
		private void CrearClientes(string ruta, string nodoRaiz)// Crear los clientes del sistema
		{
			XmlDocument doc = new XmlDocument();

			XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
			XmlNode root = doc.DocumentElement;
			doc.InsertBefore(xmlDeclaration, root);

			XmlNode elemento = doc.CreateElement(nodoRaiz);
			doc.AppendChild(elemento);

			doc.Save(ruta);
		}

		/// <summary>
		/// <para>Crear el historial del sistema</para>
		/// </summary>
		/// <param name="ruta">Ruta del archivo.</param>
		/// <param name="nodoRaiz">Nodo principal.</param>
		private void CrearHistorial(string ruta, string nodoRaiz)// Crear el historial del sistema
		{
			XmlDocument doc = new XmlDocument();

			XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
			XmlNode root = doc.DocumentElement;
			doc.InsertBefore(xmlDeclaration, root);

			XmlNode elemento = doc.CreateElement(nodoRaiz);
			doc.AppendChild(elemento);

			doc.Save(ruta);
		}
		#endregion
	}
}
