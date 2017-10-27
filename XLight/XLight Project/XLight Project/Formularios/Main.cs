//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// Main.cs (01/10/2017)                                              			\\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:     Formulario de Main											\\
// Fecha Mod:       01/10/2017                                                  \\
// Ultima Mod:      Version Inicial												\\
//******************************************************************************\\

#region Librerias
using System;
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
		#endregion

		#region Variables Privadas
		/// <summary>
		/// <para>Id actual</para>
		/// </summary>
		private string idActual;												// Id actual
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
				string pH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), configuracionActual.PathData + @"\Admin\historial.xml");
				string pC = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), configuracionActual.PathData + @"\Admin\clientes.xml");

				usuarioActual = new Usuario("Admin", "Admin", 0, pH, pC, 0, 0);
			}

			LblUser.Text = "." + usuarioActual.Nombre + " nvl." + usuarioActual.NivelPrivilegios;
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
		public void AgregarCliente(string id, string nom, string fecha, string precio, string resultado)// Agrega un elemento
		{
			/*XmlDocument doc = new XmlDocument();

			doc.Load(configuracionActual.PathClientes);

			XmlNode cliente = doc.CreateElement("Cliente");
			XmlElement xid = doc.CreateElement("id");
			xid.InnerText = id;
			cliente.AppendChild(xid);

			XmlElement xnom = doc.CreateElement("nombre");
			xnom.InnerText = nom;
			cliente.AppendChild(xnom);

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
			doc.Save(pathClientes);*/
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

		}

		/// <summary>
		/// <para>Abre el balance.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnBalance_Click(object sender, EventArgs e)// Abre el balance
		{

		}

		/// <summary>
		/// <para>Abre el historial</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnHistorial_Click(object sender, EventArgs e)// Abre el historial
		{

		}

		/// <summary>
		/// <para>Abre las opciones</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnOpciones_Click(object sender, EventArgs e)// Abre las opciones
		{

		}
		#endregion

		private void BtnAgregarNuevoCliente_Click(object sender, EventArgs e)
		{
			/*if (TextNombre.Text == string.Empty)
			{
				MessageBox.Show("Tienes que completar nombre como minimo.");
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

				ActualizarBusquedaRegistro();

				MessageBox.Show("Cliente agregado.");
			}*/
		}

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
