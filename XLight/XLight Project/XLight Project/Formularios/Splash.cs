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
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using XLight_Project.Clases;
using XLight_Project.Formularios;
#endregion

namespace XLight_Project
{
	/// <summary>
	/// <para>Formulario de splash</para>
	/// </summary>
	public partial class Splash : Form
	{
		#region Variables Publicas
		/// <summary>
		/// <para>Configuracion actual de los ajustes.</para>
		/// </summary>
		public Ajustes configuracionActual;										// Configuracion actual de los ajustes
		#endregion

		#region Constructor
		/// <summary>
		/// <para>Constructor de <see cref="Splash"/>.</para>
		/// </summary>
		public Splash()// Constructor de Splash
		{
			InitializeComponent();
		}
		#endregion

		#region Loader
		/// <summary>
		/// <para>Loader de <see cref="Splash"/>.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Splash_Load(object sender, EventArgs e)// Loader de Splash
		{
			// Comprobar si existen ajustes
			// Si no existen ajustes , crearlos
			if (!File.Exists("Ajustes/ajustes.xml"))
			{
				// Generar las paths
				string pD = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data");
				string pU = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), pD + @"\Usuarios");
				string pA = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Ajustes\ajustes.xml");
				string uU = "Admin";

				// Crear ajustes
				configuracionActual = new Ajustes(pD, pU, pA, uU);

				// Crear directorios
				Directory.CreateDirectory("Data");
				Directory.CreateDirectory("Data/Usuarios/Admin");
				Directory.CreateDirectory("Ajustes");

				// Crear Datas
				CrearAjustes("Ajustes/ajustes.xml", "Ajustes");
				CrearClientes("Data/Usuarios/Admin/clientes.xml", "Clientes");
				CrearHistorial("Data/Usuarios/Admin/historial.xml", "Entradas");
				CrearUsuario("Data/Usuarios/usuarios.xml", "Usuarios");
			}
			else
			{
				// Si existen guardarlos
				CargarAjustes(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Ajustes\ajustes.xml"));
			}
		}
		#endregion

		#region Metodos Privados
		/// <summary>
		/// <para>Temporizador</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Temporizador_Tick(object sender, EventArgs e)// Temporizador
		{
			try
			{
				ProgressBarFill.Width += 5;
				ProgressBarFill.Height = 15;
				ProcesarTexto();
				if (ProgressBarFill.Width >= 635f)
				{
					Temporizador.Stop();
					Login login = new Login(configuracionActual);
					login.Show();
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
			switch (ProgressBarFill.Width)
			{
				case 100:
					lblSeguimiento.Text = "Cargando componentes ...";
					break;

				case 300:
					lblSeguimiento.Text = "Cargando usuarios ...";
					break;

				case 500:
					lblSeguimiento.Text = "Cargando sistema ...";
					break;

				case 600:
					lblSeguimiento.Text = "Inicializando sistema ...";
					break;
			}
		}

		/// <summary>
		/// <para>Crear los ajustes del sistema</para>
		/// </summary>
		/// <param name="ruta">Ruta del archivo.</param>
		/// <param name="nodoRaiz">Nodo principal.</param>
		private void CrearAjustes(string ruta, string nodoRaiz)// Crear los ajustes del sistema
		{
			XmlDocument doc = new XmlDocument();

			XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
			XmlNode root = doc.DocumentElement;
			doc.InsertBefore(xmlDeclaration, root);

			XmlNode elemento = doc.CreateElement(nodoRaiz);
			doc.AppendChild(elemento);

			XmlElement rutaData = doc.CreateElement("rutadata");
			rutaData.AppendChild(doc.CreateTextNode(configuracionActual.PathData));
			elemento.AppendChild(rutaData);

			XmlElement rutaUsuarios = doc.CreateElement("rutausuarios");
			rutaUsuarios.AppendChild(doc.CreateTextNode(configuracionActual.PathUsuarios));
			elemento.AppendChild(rutaUsuarios);

			XmlElement rutaAjustes = doc.CreateElement("rutaajustes");
			rutaAjustes.AppendChild(doc.CreateTextNode(configuracionActual.PathAjustes));
			elemento.AppendChild(rutaAjustes);

			XmlElement ultimoUser = doc.CreateElement("ultimouser");
			ultimoUser.AppendChild(doc.CreateTextNode(configuracionActual.UltimoUser));
			elemento.AppendChild(ultimoUser);

			doc.Save(ruta);
		}

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

		/// <summary>
		/// <para>Crea el admin del sistema</para>
		/// </summary>
		/// <param name="ruta">Ruta del archivo.</param>
		/// <param name="nodoRaiz">Nodo principal.</param>
		private void CrearUsuario(string ruta, string nodoRaiz)// Crear el admin del sistema
		{
			XmlDocument doc = new XmlDocument();

			XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
			XmlNode root = doc.DocumentElement;
			doc.InsertBefore(xmlDeclaration, root);

			XmlNode elemento = doc.CreateElement(nodoRaiz);
			doc.AppendChild(elemento);
			doc.Save(ruta);

			AgregarAdmin();
		}

		/// <summary>
		/// <para>Agrega el administrador.</para>
		/// </summary>
		private void AgregarAdmin()// Agrega el administrador
		{
			XmlDocument doc = new XmlDocument();

			doc.Load(configuracionActual.PathUsuarios + "/usuarios.xml");

			XmlNode cliente = doc.CreateElement("Usuario");

			XmlElement nombr = doc.CreateElement("nombre");
			nombr.InnerText = "Admin";
			cliente.AppendChild(nombr);

			XmlElement pass = doc.CreateElement("password");
			pass.InnerText = "Admin";
			cliente.AppendChild(pass);

			XmlElement nvl = doc.CreateElement("nivel");
			nvl.InnerText = "0";
			cliente.AppendChild(nvl);

			XmlElement rutaHistorial = doc.CreateElement("rutahistorial");
			rutaHistorial.AppendChild(doc.CreateTextNode(configuracionActual.PathUsuarios + @"\Admin\historial.xml"));
			cliente.AppendChild(rutaHistorial);

			XmlElement rutaClientes = doc.CreateElement("rutaclientes");
			rutaClientes.AppendChild(doc.CreateTextNode(configuracionActual.PathUsuarios + @"\Admin\clientes.xml"));
			cliente.AppendChild(rutaClientes);

			XmlElement idInicial = doc.CreateElement("idactual");
			idInicial.AppendChild(doc.CreateTextNode("0"));
			cliente.AppendChild(idInicial);

			XmlElement inicioAut = doc.CreateElement("inicioautomatico");
			inicioAut.AppendChild(doc.CreateTextNode("0"));
			cliente.AppendChild(inicioAut);

			doc.DocumentElement.AppendChild(cliente);
			doc.Save(configuracionActual.PathUsuarios + "/usuarios.xml");
		}

		/// <summary>
		/// <para>Carga los ajustes</para>
		/// </summary>
		/// <param name="path">Ruta de los ajustes.</param>
		private void CargarAjustes(string path)// Carga los ajustes
		{
			XmlDocument doc = new XmlDocument();

			doc.Load(path);

			XmlNodeList lista = doc.SelectNodes("Ajustes");

			string pathData = lista.Item(0).SelectSingleNode("rutadata").InnerText;
			string pathUsuario = lista.Item(0).SelectSingleNode("rutausuarios").InnerText;
			string pathAjustes = lista.Item(0).SelectSingleNode("rutaajustes").InnerText;
			string ultiUser = lista.Item(0).SelectSingleNode("ultimouser").InnerText;

			configuracionActual = new Ajustes(pathData, pathUsuario, pathAjustes, ultiUser);
		}
		#endregion
	}
}
