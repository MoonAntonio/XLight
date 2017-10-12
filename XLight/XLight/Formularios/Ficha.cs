using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XLight.Formularios
{
	public partial class Ficha : Form
	{
		#region Variables
		private int badget = 0;

		private string id = "";
		private string nombre = "";
		private string balance = "";
		private string tipo = "";
		private string fecha = "";

		private string pathCliente;
		private string nombreCliente = "Antonio Mateo";
		#endregion

		#region Constructor
		public Ficha()
		{
			InitializeComponent();

			nombreCliente = Main.nombreFicha;

			ComboTipo.Items.Add(GetTipoString(TiposTratamiento.Ninguno));
			ComboTipo.Items.Add(GetTipoString(TiposTratamiento.Hipnosis));
			ComboTipo.Items.Add(GetTipoString(TiposTratamiento.Interpretar));
			ComboTipo.Items.Add(GetTipoString(TiposTratamiento.Regresion));
			ComboTipo.Items.Add(GetTipoString(TiposTratamiento.Reiki));
			ComboTipo.Items.Add(GetTipoString(TiposTratamiento.TetraHealing));
		}
		#endregion

		#region Loader
		private void Ficha_Load(object sender, EventArgs e)
		{
			// TODO Test
			nombreCliente = "Antonio Mateo";
			// Instanciar String y XML
			Xml xml = new Xml();

			// Comprobar si existen los ajustes
			if (!File.Exists("Data/" + nombreCliente + "/" + nombreCliente + ".xml"))
			{
				pathCliente = Main.pathData + "/" + nombreCliente;

				Directory.CreateDirectory("Data/" + nombreCliente);
				Directory.CreateDirectory("Data/" + nombreCliente + "/Hipnosis");
				Directory.CreateDirectory("Data/" + nombreCliente + "/Interpretar");
				Directory.CreateDirectory("Data/" + nombreCliente + "/Regresion");
				Directory.CreateDirectory("Data/" + nombreCliente + "/Reiki");
				Directory.CreateDirectory("Data/" + nombreCliente + "/TetraHealing");

				xml.CrearXML("Data/" + nombreCliente + "/" + nombreCliente + ".xml", "Rutas");

				MessageBox.Show("Data no encontrada. Creandola.");

				CargarCliente();
			}
			else
			{
				pathCliente = Main.pathData + "/" + nombreCliente;

				CargarCliente();
			}
		}
		#endregion

		#region Metodos
		public void CargarCliente()
		{
			XmlDocument doc = new XmlDocument();

			doc.Load(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\clientes.xml"));

			XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");
			XmlNode inCliente;

			for (int n = 0; n < listaClientes.Count; n++)
			{
				inCliente = listaClientes.Item(n);

				if (inCliente.SelectSingleNode("nombre").InnerText == nombreCliente)
				{
					visualTextBox1.Text = inCliente.SelectSingleNode("id").InnerText;
					TxtNombre.Text = inCliente.SelectSingleNode("nombre").InnerText;
					ComboTipo.Text = inCliente.SelectSingleNode("tipo").InnerText;
					Fecha.Text = inCliente.SelectSingleNode("fecha").InnerText;
					TxtBalance.Text = inCliente.SelectSingleNode("precio").InnerText;
				}
			}
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

		#region Eventos
		private void TxtNombre_TextChanged(object sender, EventArgs e)
		{
			badget++;
			visualBadge1.Text = badget.ToString();
			nombre = TxtNombre.Text;
		}

		private void TxtBalance_TextChanged(object sender, EventArgs e)
		{
			badget++;
			visualBadge1.Text = badget.ToString();
			balance = TxtBalance.Text;
		}

		private void ComboTipo_SelectedIndexChanged(object sender, EventArgs e)
		{
			badget++;
			visualBadge1.Text = badget.ToString();
			tipo = ComboTipo.Text.ToString();
			
		}

		private void Fecha_ValueChanged(object sender, EventArgs e)
		{
			badget++;
			visualBadge1.Text = badget.ToString();
			fecha = Fecha.Value.ToString();
		}

		private void visualTextBox1_TextChanged(object sender, EventArgs e)
		{
			badget++;
			visualBadge1.Text = badget.ToString();
			id = visualTextBox1.Text.ToString();
		}

		private void BtnGuardar_Click(object sender, EventArgs e)
		{
			badget = 0;
			visualBadge1.Text = "0";

			XmlDocument doc = new XmlDocument();

			doc.Load(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\clientes.xml"));

			XmlElement clientes = doc.DocumentElement;

			XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

			XmlNode nuevoCliente = doc.CreateElement("Cliente");

			XmlElement xid = doc.CreateElement("id");
			xid.InnerText = id;
			nuevoCliente.AppendChild(xid);

			XmlElement xnom = doc.CreateElement("nombre");
			xnom.InnerText = nombre;
			nuevoCliente.AppendChild(xnom);

			XmlElement xtipo = doc.CreateElement("tipo");
			xtipo.InnerText = tipo;
			nuevoCliente.AppendChild(xtipo);

			XmlElement xfecha = doc.CreateElement("fecha");
			xfecha.InnerText = fecha;
			nuevoCliente.AppendChild(xfecha);

			XmlElement xprecio = doc.CreateElement("precio");
			xprecio.InnerText = balance;
			nuevoCliente.AppendChild(xprecio);

			foreach (XmlNode item in listaClientes)
			{
				if (item.FirstChild.InnerText == id)
				{
					XmlNode nodo = item;
					clientes.ReplaceChild(nuevoCliente, nodo);
				}
			}

			doc.Save(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\clientes.xml"));

			MessageBox.Show("Guardado");
		}

		private void BtnSource_Click(object sender, EventArgs e)
		{
			Process.Start(pathCliente);
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

		private void BtnGuardarHipnosis_Click(object sender, EventArgs e)
		{
			
		}


	}
}
