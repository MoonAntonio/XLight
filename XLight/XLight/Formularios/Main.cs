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
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Reflection;
using System.Diagnostics;
using System.Data;
#endregion

namespace XLight
{
	/// <summary>
	/// <para>Formulario central del programa</para>
	/// </summary>
	public partial class Main : Form
	{
		#region Variables
		private string pathHistorial;
		private string pathData;
		private string pathClientes;
		private string pathAjustes;
		private string idActual;
		private string idRemove;
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
			BoxOpciones.Visible = false;
			BoxClientes.Visible = false;

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
				idActual = "0";

				Directory.CreateDirectory("Data");

				Directory.CreateDirectory("Ajustes");

				xml.CrearXML("Data/historial.xml", "Clientes");

				xml.CrearXML("Data/clientes.xml", "Clientes");

				CrearAjustes("Ajustes/ajustes.xml", "Ajustes");
			}
			else
			{
				CargarAjustes(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Ajustes\ajustes.xml"));
			}

			LblData.Text = pathData;
			LblRutaClientes.Text = pathClientes;
			LblRutaHistorial.Text = pathHistorial;

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

			XmlElement idInicial = doc.CreateElement("idactual");
			idInicial.AppendChild(doc.CreateTextNode("0"));
			elemento.AppendChild(idInicial);

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
			idActual = lista.Item(0).SelectSingleNode("idactual").InnerText;
		}

		/// <summary>
		/// <para>Guarda los ajustes</para>
		/// </summary>
		/// <param name="path"></param>
		public void GuardarAjustes(string path)// Guarda los ajustes
		{
			XmlDocument doc = new XmlDocument();

			XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
			XmlNode root = doc.DocumentElement;
			doc.InsertBefore(xmlDeclaration, root);

			XmlNode elemento = doc.CreateElement("Ajustes");
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

			XmlElement idActu = doc.CreateElement("idactual");
			idActu.AppendChild(doc.CreateTextNode(idActual));
			elemento.AppendChild(idActu);

			doc.Save(path);
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

		/// <summary>
		/// <para>Agrega un elemento.</para>
		/// </summary>
		/// <param name="id"></param>
		/// <param name="nom"></param>
		/// <param name="tipo"></param>
		/// <param name="fecha"></param>
		/// <param name="precio"></param>
		/// <param name="resultado"></param>
		public void AgregarCliente(string ruta, string id, string nom, TiposTratamiento tipo, string fecha, string precio, string resultado)// Agrega un elemento
		{
			XmlDocument doc = new XmlDocument();

			doc.Load(ruta);

			XmlNode cliente = doc.CreateElement("Cliente");
			XmlElement xid = doc.CreateElement("id");
			xid.InnerText = id;
			cliente.AppendChild(xid);

			XmlElement xnom = doc.CreateElement("nombre");
			xnom.InnerText = nom;
			cliente.AppendChild(xnom);

			XmlElement xtipo = doc.CreateElement("tipo");
			xtipo.InnerText = GetTipoString(tipo);
			cliente.AppendChild(xtipo);

			XmlElement xfecha = doc.CreateElement("fecha");
			xfecha.InnerText = fecha;
			cliente.AppendChild(xfecha);

			XmlElement xprecio = doc.CreateElement("precio");
			xprecio.InnerText = precio;
			cliente.AppendChild(xprecio);

			XmlElement xresultado = doc.CreateElement("resultado");
			xresultado.InnerText = resultado;
			cliente.AppendChild(xresultado);

			doc.DocumentElement.AppendChild(cliente);
			doc.Save(pathClientes);
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
		public void CrearEntradaHistoria(string ruta, string id, string nom, TiposTratamiento tipo, string fecha, string precio, string resultado)// Crea una entrada en el registro
		{
			XmlDocument doc = new XmlDocument();

			doc.Load(ruta);

			XmlNode cliente = doc.CreateElement("Cliente");
			XmlElement xid = doc.CreateElement("id");
			xid.InnerText = id;
			cliente.AppendChild(xid);

			XmlElement xnom = doc.CreateElement("nombre");
			xnom.InnerText = nom;
			cliente.AppendChild(xnom);

			XmlElement xtipo = doc.CreateElement("tipo");
			xtipo.InnerText = GetTipoString(tipo);
			cliente.AppendChild(xtipo);

			XmlElement xfecha = doc.CreateElement("fecha");
			xfecha.InnerText = fecha;
			cliente.AppendChild(xfecha);

			XmlElement xprecio = doc.CreateElement("precio");
			xprecio.InnerText = precio;
			cliente.AppendChild(xprecio);

			XmlElement xresultado = doc.CreateElement("resultado");
			xresultado.InnerText = resultado;
			cliente.AppendChild(xresultado);

			doc.DocumentElement.AppendChild(cliente);
			doc.Save(pathHistorial);
		}
		#endregion

		#region Funcionalidad
		/// <summary>
		/// <para>Obtiene el string de un tipo de tratamiento.</para>
		/// </summary>
		/// <param name="tipo"></param>
		/// <returns></returns>
		private string GetTipoString(TiposTratamiento tipo)// Obtiene el string de un tipo de tratamiento
		{
			switch (tipo)
			{
				case TiposTratamiento.Ninguno:
					return "Ninguno";

				case TiposTratamiento.Hipnosis:
					return "Hipnosis";

				case TiposTratamiento.Interpretar:
					return "Interpretar Sueños";

				case TiposTratamiento.Regresion:
					return "Regresion";

				case TiposTratamiento.Reiki:
					return "Reiki";

				case TiposTratamiento.TetraHealing:
					return "TetraHealing";

				default:
					return "No especificado";
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
			GuardarAjustes(pathAjustes);

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
			BoxOpciones.Visible = false;
			BoxClientes.Visible = false;

			listViewHistorial.Items.Clear();
			CargarHistorial(pathHistorial);
		}

		private void BtnOpciones_Click(object sender, EventArgs e)
		{
			if (BoxOpciones.Visible == true) return;

			BoxOpciones.Visible = true;
			BoxHistorial.Visible = false;
			BoxClientes.Visible = false;
		}

		private void BtnClientes_Click(object sender, EventArgs e)
		{
			if (BoxClientes.Visible == true) return;

			BoxClientes.Visible = true;
			BoxHistorial.Visible = false;
			BoxOpciones.Visible = false;
		}

		private void BtnRutaData_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog busqueda = new FolderBrowserDialog();

			if (busqueda.ShowDialog() == DialogResult.OK)
			{
				string path = busqueda.SelectedPath;
				LblData.Text = path;
				pathData = path;
				GuardarAjustes(pathAjustes);
			}

		}

		private void BtnRutaHistorial_Click(object sender, EventArgs e)
		{
			OpenFileDialog busqueda = new OpenFileDialog();

			if (busqueda.ShowDialog() == DialogResult.OK)
			{
				string path = busqueda.FileName;
				LblRutaHistorial.Text = path;
				pathHistorial = path;
				GuardarAjustes(pathAjustes);
			}
		}

		private void BtnRutaCllientes_Click(object sender, EventArgs e)
		{
			OpenFileDialog busqueda = new OpenFileDialog();

			if (busqueda.ShowDialog() == DialogResult.OK)
			{
				string path = busqueda.FileName;
				LblRutaClientes.Text = path;
				pathClientes = path;
				GuardarAjustes(pathAjustes);
			}
		}

		private void BtnAgregarNuevoCliente_Click(object sender, EventArgs e)
		{
			if (TextNombre.Text == string.Empty || TextApellidos.Text == string.Empty)
			{
				MessageBox.Show("Tienes que completar nombre y apellidos.");
			}
			else
			{
				DateTime diahora = DateTime.Now;
				string dia = diahora.ToString("dddd dd MMMM");
				int id = Int32.Parse(idActual) + 1;

				AgregarCliente(pathClientes, id.ToString(), TextNombre.Text + " " + TextApellidos.Text, TiposTratamiento.Ninguno, dia, "0", "Desconocido");

				idActual = id.ToString();

				CrearEntradaHistoria(pathHistorial, id.ToString(), TextNombre.Text + " " + TextApellidos.Text, TiposTratamiento.Ninguno, dia, "0", "Nuevo cliente");

				TextNombre.Text = "";
				TextApellidos.Text = "";

				MessageBox.Show("Cliente agregado.");
			}
		}

		private void TabClientes_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			XmlDocument doc = new XmlDocument();

			doc.Load(pathClientes);

			XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");
			XmlNode inCliente;

			DataTable tabla = new DataTable();


			for (int n = 0; n < listaClientes.Count; n++)
			{
				inCliente = listaClientes.Item(n);

				string id = inCliente.SelectSingleNode("id").InnerText;
				string nombre = inCliente.SelectSingleNode("nombre").InnerText;
				string tipo = inCliente.SelectSingleNode("tipo").InnerText;
				string fecha = inCliente.SelectSingleNode("fecha").InnerText;
				string precio = inCliente.SelectSingleNode("precio").InnerText;
				string resultado = inCliente.SelectSingleNode("resultado").InnerText;

				dataGridView1.Rows.Add(id, nombre, tipo, fecha, precio, resultado);
			}
		}

		private void BtnBuscar_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();

			XmlDocument doc = new XmlDocument();

			doc.Load(pathClientes);

			XmlNodeList listaClientesHistorial = doc.SelectNodes("Clientes/Cliente");
			XmlNode inCliente;

			for (int n = 0; n < listaClientesHistorial.Count; n++)
			{
				inCliente = listaClientesHistorial.Item(n);

				string id = inCliente.SelectSingleNode("id").InnerText;
				string nombre = inCliente.SelectSingleNode("nombre").InnerText;

				ListViewItem listaItems = new ListViewItem(id);
				listaItems.SubItems.Add(nombre);
				listView1.Items.Add(listaItems);
			}
		}

		private void BtnQuitarCliente_Click(object sender, EventArgs e)
		{
			XmlDocument doc = new XmlDocument();
			DateTime diahora = DateTime.Now;
			string dia = diahora.ToString("dddd dd MMMM");

			if (idRemove != string.Empty)
			{
				doc.Load(pathClientes);

				XmlElement cliente = doc.DocumentElement;

				XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

				foreach (XmlNode item in listaClientes)
				{
					if (item.SelectSingleNode("id").InnerText == idRemove)
					{
						XmlNode nodo = item;

						cliente.RemoveChild(nodo);
					}
					else
					{
						MessageBox.Show("Error 0x0120.");
					}
				}
				doc.Save(pathClientes);


				MessageBox.Show("Cliente eliminado.");

				CrearEntradaHistoria(pathHistorial, idRemove, "--", TiposTratamiento.Ninguno, dia, "0", "Eliminado del sistema");
			}
			else
			{
				MessageBox.Show("Primero selecciona un cliente.");
			}
		}

		private void listView1_MouseClick(object sender, MouseEventArgs e)
		{
			string id = listView1.SelectedItems[0].SubItems[0].Text;
			string nombre = listView1.SelectedItems[0].SubItems[1].Text;
			idRemove = id;
		}
		#endregion

		#region Enum
		/// <summary>
		/// <para>Tipos de tratamientos</para>
		/// </summary>
		public enum TiposTratamiento
		{
			Ninguno,
			Interpretar,
			Regresion,
			TetraHealing,
			Reiki,
			Hipnosis
		}


		#endregion
	}
}
