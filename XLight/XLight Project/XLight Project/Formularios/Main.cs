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
		private int idActual;                                                   // Id actual
		/// <summary>
		/// <para>Temporizador del progress bar.</para>
		/// </summary>
		private bool isTemporizador = false;									// Temporizador del progress bar
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

			CargarHistorial();

			PanelClientes.Visible = false;
			PanelBalance.Visible = false;
			PanelHistorial.Visible = false;
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
			InitProgressBar();

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

			StopProgressBar();
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
			InitProgressBar();

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

			StopProgressBar();
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

		/// <summary>
		/// <para>Inicia el progreso.</para>
		/// </summary>
		public void InitProgressBar()// Inicia el progreso
		{
			if (BarProgress.Value > 0)
			{
				BarProgress.Value = 100;

				isTemporizador = true;
			}
		}

		/// <summary>
		/// <para>Detiene el progreso.</para>
		/// </summary>
		public void StopProgressBar()// Detiene el progreso
		{
			isTemporizador = false;
		}

		/// <summary>
		/// <para>Imprimir Lista</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnImprimirClientes_Click(object sender, EventArgs e)// Imprimir Lista
		{
			printDocument1.Print();
		}

		/// <summary>
		/// <para>Preparar pagina para imprimir.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)// Preparar pagina para imprimir
		{
			Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
			dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
			e.Graphics.DrawImage(bm, 10, 10);
		}

		private void CargarHistorial()
		{
			//dataGridView2.Rows.Clear();

			XmlDocument doc = new XmlDocument();

			doc.Load(usuarioActual.PathClientes);

			XmlNodeList listaClientes = doc.SelectNodes("Entradas/Entrada");
			XmlNode inCliente;

			DataTable tabla = new DataTable();


			for (int n = 0; n < listaClientes.Count; n++)
			{
				inCliente = listaClientes.Item(n);

				string nombre = inCliente.SelectSingleNode("nombre").InnerText;
				string apellidos = inCliente.SelectSingleNode("apellidos").InnerText;
				string suceso = inCliente.SelectSingleNode("suceso").InnerText;
				string fecha = inCliente.SelectSingleNode("fecha").InnerText;

				dataGridView2.Rows.Add(n.ToString(), nombre, apellidos, suceso, fecha);
			}
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
			if (PanelClientes.Visible) return;

			PanelClientes.Visible = true;
			PanelBalance.Visible = false;
			PanelHistorial.Visible = false;

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
				if (PanelBalance.Visible) return;

				PanelBalance.Visible = true;
				PanelClientes.Visible = false;
				PanelHistorial.Visible = false;

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
			if (PanelHistorial.Visible) return;

			PanelHistorial.Visible = true;
			PanelClientes.Visible = false;
			PanelBalance.Visible = false;

			LblUser.Text = "." + usuarioActual.Nombre + " nvl." + usuarioActual.NivelPrivilegios + " >> " + "Historial";

			CargarHistorial();
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

		/// <summary>
		/// <para>Abre la ficha del usuario.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnAbrirFicha_Click(object sender, EventArgs e)// Abre la ficha del usuario
		{
			InitProgressBar();

			if (txtBoxBuscadorRegistro.Text != string.Empty)
			{
				string nombreFicha = txtBoxBuscadorRegistro.Text;

				Ficha ficha = new Ficha(configuracionActual, usuarioActual, nombreFicha);
				ficha.Show();

				txtBoxBuscadorRegistro.Text = "";
			}
			else
			{
				MessageBox.Show("Tienes que buscar algun cliente.");
			}

			StopProgressBar();
		}

		/// <summary>
		/// <para>Borrar un cliente.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnBorrar_Click(object sender, EventArgs e)// Borrar un cliente
		{
			InitProgressBar();

			XmlDocument doc = new XmlDocument();
			DateTime diahora = DateTime.Now;
			string dia = diahora.ToString("dddd dd MMMM");
			string no = "";
			string ap = "";

			if (txtBoxBuscadorRegistro.Text != string.Empty)
			{
				doc.Load(usuarioActual.PathClientes);

				XmlElement cliente = doc.DocumentElement;

				XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

				foreach (XmlNode item in listaClientes)
				{
					string nombreConjunto = item.SelectSingleNode("nombre").InnerText + " " + item.SelectSingleNode("apellidos").InnerText;

					no = item.SelectSingleNode("nombre").InnerText;
					ap = item.SelectSingleNode("apellidos").InnerText;

					if (nombreConjunto == txtBoxBuscadorRegistro.Text)
					{
						MessageBoxButtons buttons = MessageBoxButtons.YesNo;
						DialogResult result = MessageBox.Show("¿Quieres eliminar a " + no + " ?", "Seguro", buttons);

						if (result == System.Windows.Forms.DialogResult.Yes)
						{
							XmlNode nodo = item;

							cliente.RemoveChild(nodo);

							CrearEntradaHistoria(no, ap, no + " " + ap + " ha sido borrado.", dia);
						}
					}
				}


				doc.Save(usuarioActual.PathClientes);

				ActualizarBusquedaRegistro();

				txtBoxBuscadorRegistro.Text = "";

				ActualizarBusquedaRegistro();
			}
			else
			{
				MessageBox.Show("Primero busca un usuario");
			}

			StopProgressBar();
		}

		/// <summary>
		/// <para>Editar un usuario.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnEditar_Click(object sender, EventArgs e)// Editar un usuario
		{
			InitProgressBar();

			if (txtBoxBuscadorRegistro.Text != string.Empty)
			{
				string nombreFicha = txtBoxBuscadorRegistro.Text;

				EditarUsuario ficha = new EditarUsuario(configuracionActual, usuarioActual, nombreFicha, this);
				ficha.Show();

				txtBoxBuscadorRegistro.Text = "";
			}
			else
			{
				MessageBox.Show("Tienes que buscar algun cliente.");
			}

			StopProgressBar();
		}

		/// <summary>
		/// <para>Temporizador</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void timerProgress_Tick(object sender, EventArgs e)// Temporizador
		{
			if (isTemporizador == true)
			{
				try
				{
					BarProgress.Value = BarProgress.Value + 25;

					if (BarProgress.Value >= 100)
					{
						isTemporizador = false;
						timerProgress.Stop();
					}
				}
				catch (Exception)
				{
					return;
				}
			}
			else
			{
				BarProgress.Value = 0;
			}
			
		}
		#endregion

		#region Metodos Estaticos
		/// <summary>
		/// <para>Actualizar la lista.</para>
		/// </summary>
		public void ActualizarLista()// Actualizar la lista
		{
			ActualizarBusquedaRegistro();
			ActualizarBusquedaRegistro();
		}
		#endregion
	}
}
