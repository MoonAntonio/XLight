//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// Main.cs (01/10/2017)                                              			\\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:     Formulario central del programa								\\
// Fecha Mod:       01/10/2017                                                  \\
// Ultima Mod:      Version Inicial												\\
//******************************************************************************\\

#region Librerias
using System;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Diagnostics;
#endregion

namespace XLight
{
	/// <summary>
	/// <para>Formulario central del programa</para>
	/// </summary>
	public partial class Main : Form
	{
		#region Variables
		string pathHistorial;
		string pathData;
		string pathClientes;
		string pathAjustes;
		#endregion

		#region Constructor
		public Main()
		{
			InitializeComponent();
		}
		#endregion

		#region Loader
		private void Main_Load(object sender, EventArgs e)
		{
			// Hacer invisible los box
			BoxHistorial.Visible = false;

			// Instanciar String y XML
			Xml xml = new Xml();

			// Comprobar si existen los ajustes
			if (!File.Exists("Ajustes/ajustes.xml"))
			{
				// Generar las paths
				pathHistorial = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\historial.xml");
				pathData = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data");
				pathClientes = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\clientes.xml");
				pathAjustes = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Ajustes\ajustes.xml");

				Directory.CreateDirectory("Data");

				Directory.CreateDirectory("Ajustes");

				xml.CrearXML("Data/historial.xml", "Clientes");

				for (int n = 0; n < 10; n++)
				{

					xml.AgregarHistorial(pathHistorial, n.ToString(), "Moon" + n.ToString(), Xml.TiposTratamiento.Reiki, "10/10/2017", "20", "Bueno");
				}

				xml.CrearXML("Data/clientes.xml", "Clientes");

				CrearAjustes("Ajustes/ajustes.xml", "Ajustes");
			}
			else
			{
				CargarAjustes(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Ajustes\ajustes.xml"));
			}

			CargarHistorial(pathHistorial);
		}
		#endregion

		#region Metodos
		/// <summary>
		/// <para>Crear los ajustes del sistema</para>
		/// </summary>
		/// <param name="ruta"></param>
		/// <param name="nodoRaiz"></param>
		public void CrearAjustes(string ruta, string nodoRaiz)// Crear los ajustes del sistema
		{
			string pathData = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data");
			string pathHistorial = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\historial.xml");
			string pathClientes = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\clientes.xml");
			string pathAjustes = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Ajustes\ajustes.xml");

			XmlDocument doc = new XmlDocument();

			XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
			XmlNode root = doc.DocumentElement;
			doc.InsertBefore(xmlDeclaration, root);

			XmlNode elemento = doc.CreateElement(nodoRaiz);
			doc.AppendChild(elemento);

			XmlElement rutaData = doc.CreateElement("rutadata");
			rutaData.AppendChild(doc.CreateTextNode(pathData));
			elemento.AppendChild(rutaData);

			XmlElement rutaHistorial = doc.CreateElement("rutahistorial");
			rutaHistorial.AppendChild(doc.CreateTextNode(pathHistorial));
			elemento.AppendChild(rutaHistorial);

			XmlElement rutaClientes = doc.CreateElement("rutaclientes");
			rutaClientes.AppendChild(doc.CreateTextNode(pathClientes));
			elemento.AppendChild(rutaClientes);

			XmlElement rutaAjustes = doc.CreateElement("rutaajustes");
			rutaAjustes.AppendChild(doc.CreateTextNode(pathAjustes));
			elemento.AppendChild(rutaAjustes);

			doc.Save(ruta);
		}

		/// <summary>
		/// <para>Carga los ajustes</para>
		/// </summary>
		/// <param name="path"></param>
		public void CargarAjustes(string path)// Carga los ajustes
		{
			XmlDocument doc = new XmlDocument();

			doc.Load(path);

			XmlNodeList lista = doc.SelectNodes("Ajustes");

			Debug.Print(lista.Item(0).SelectSingleNode("rutadata").InnerText);

			pathData = lista.Item(0).SelectSingleNode("rutadata").InnerText;
			pathHistorial = lista.Item(0).SelectSingleNode("rutahistorial").InnerText;
			pathClientes = lista.Item(0).SelectSingleNode("rutaclientes").InnerText;
			pathAjustes = lista.Item(0).SelectSingleNode("rutaajustes").InnerText;
		}

		/// <summary>
		/// <para>Carga el historial</para>
		/// </summary>
		/// <param name="path"></param>
		public void CargarHistorial(string path)// Carga el historial
		{
			XmlDocument doc = new XmlDocument();

			doc.Load(path);

			XmlNodeList listaClientesHistorial = doc.SelectNodes("Clientes/Cliente");
			XmlNode inCliente;

			for (int n = 0; n < listaClientesHistorial.Count; n++)
			{
				inCliente = listaClientesHistorial.Item(n);

				string id = inCliente.SelectSingleNode("id").InnerText;
				string nombre = inCliente.SelectSingleNode("nombre").InnerText;
				string tipo = inCliente.SelectSingleNode("tipo").InnerText;
				string fecha = inCliente.SelectSingleNode("fecha").InnerText;
				string precio = inCliente.SelectSingleNode("precio").InnerText;
				string resultado = inCliente.SelectSingleNode("resultado").InnerText;

				ListViewItem listaItems = new ListViewItem(id);
				listaItems.SubItems.Add(nombre);
				listaItems.SubItems.Add(tipo);
				listaItems.SubItems.Add(fecha);
				listaItems.SubItems.Add(precio);
				listaItems.SubItems.Add(resultado);
				listViewHistorial.Items.Add(listaItems);
			}
		}
		#endregion

		#region Metodos Click
		private void BtnMaximizar_Click(object sender, EventArgs e)
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

		private void BtnSalir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void BtnMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void BtnHistorial_Click(object sender, EventArgs e)
		{
			if (BoxHistorial.Visible == true) return;

			BoxHistorial.Visible = true;
		}
		#endregion
	}
}
