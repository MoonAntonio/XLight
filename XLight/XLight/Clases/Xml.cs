//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// Xml.cs (06/10/2017)                                              			\\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:     Clase para controlar XML									\\
// Fecha Mod:       06/10/2017                                                  \\
// Ultima Mod:      Version Inicial												\\
//******************************************************************************\\

#region Librerias
using System.Xml;
#endregion

namespace XLight
{
	/// <summary>
	/// <para>Clase para controlar XML</para>
	/// </summary>
	class Xml
	{
		#region Variables Privadas
		/// <summary>
		/// <para>Ruta del archivo xml de origen.</para>
		/// </summary>
		private string rutaXML;											// Ruta del archivo xml de origen
		/// <summary>
		/// <para>Documento</para>
		/// </summary>
		private XmlDocument doc;                                        // Documento
		#endregion

		#region Propiedades
		public string RutaXML
		{
			get { return rutaXML; }
			set { rutaXML = value; }
		}
		#endregion

		#region Metodos
		/// <summary>
		/// <para>Crear un archivo xml en la ruta dada.</para>
		/// </summary>
		/// <param name="ruta"></param>
		/// <param name="nodoRaiz"></param>
		public void CrearXML(string ruta, string nodoRaiz)// Crear un archivo xml en la ruta dada
		{
			this.rutaXML = ruta;
			doc = new XmlDocument();

			XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
			XmlNode root = doc.DocumentElement;
			doc.InsertBefore(xmlDeclaration, root);

			XmlNode elemento = doc.CreateElement(nodoRaiz);
			doc.AppendChild(elemento);
			doc.Save(ruta);
		}

		/// <summary>
		/// <para>Agrega un elemento al historial.</para>
		/// </summary>
		/// <param name="id"></param>
		/// <param name="nom"></param>
		/// <param name="tipo"></param>
		/// <param name="fecha"></param>
		/// <param name="precio"></param>
		/// <param name="resultado"></param>
		public void AgregarHistorial(string ruta,string id, string nom, TiposTratamiento tipo, string fecha, string precio, string resultado)// Agrega un elemento al historial
		{
			doc.Load(ruta);

			XmlNode cliente = CrearClienteHistorial(id, nom, tipo, fecha, precio, resultado);

			XmlNode nodoRaiz = doc.DocumentElement;

			nodoRaiz.InsertAfter(cliente, nodoRaiz.LastChild);

			doc.Save(rutaXML);
		}

		/// <summary>
		/// <para>Lee el xml del historial</para>
		/// </summary>
		public void LeerXMLHistorial()// Lee el xml del historial
		{
			doc.Load(rutaXML);

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
			}
		}

		/// <summary>
		/// <para>Borra un nodo</para>
		/// </summary>
		/// <param name="id"></param>
		public void BorrarNodoHistorial(string id)// Borra un nodo
		{
			doc.Load(rutaXML);

			XmlElement cliente = doc.DocumentElement;

			XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

			foreach (XmlNode item in listaClientes)
			{
				if (item.SelectSingleNode("id").InnerText == id)
				{
					XmlNode nodo = item;

					cliente.RemoveChild(nodo);
				}
			}

			doc.Save(rutaXML);
		}

		/// <summary>
		/// <para>Actualiza los datos</para>
		/// </summary>
		/// <param name="id"></param>
		/// <param name="nom"></param>
		/// <param name="tipo"></param>
		/// <param name="fecha"></param>
		/// <param name="precio"></param>
		/// <param name="resultado"></param>
		public void ActualizarHistorial(string id, string nom, TiposTratamiento tipo, string fecha, string precio, string resultado)// Actualiza los datos
		{
			XmlElement clientes = doc.DocumentElement;

			XmlNodeList listaClientes = doc.SelectNodes("Clientes/Cliente");

			XmlNode nuevoCliente = CrearClienteHistorial(id, nom, tipo, fecha, precio, resultado);

			foreach (XmlNode item in listaClientes)
			{
				if (item.FirstChild.InnerText == id)
				{
					XmlNode nodo = item;
					clientes.ReplaceChild(nuevoCliente, nodo);
				}
			}

			doc.Save(rutaXML);
		}
		#endregion

		#region Funcionalidad
		/// <summary>
		/// <para>Crea un cliente para el xml.</para>
		/// </summary>
		/// <param name="id"></param>
		/// <param name="nom"></param>
		/// <param name="tipo"></param>
		/// <param name="fecha"></param>
		/// <param name="precio"></param>
		/// <param name="resultado"></param>
		/// <returns></returns>
		private XmlNode CrearClienteHistorial(string id, string nom, TiposTratamiento tipo, string fecha, string precio, string resultado)// Crea un cliente para el xml
		{
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

			return cliente;
		}

		/// <summary>
		/// <para>Obtiene el string de un tipo de tratamiento.</para>
		/// </summary>
		/// <param name="tipo"></param>
		/// <returns></returns>
		private string GetTipoString(TiposTratamiento tipo)// Obtiene el string de un tipo de tratamiento
		{
			switch (tipo)
			{
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

		#region Enum
		/// <summary>
		/// <para>Tipos de tratamientos</para>
		/// </summary>
		public enum TiposTratamiento
		{
			Interpretar,
			Regresion,
			TetraHealing,
			Reiki,
			Hipnosis
		}
		#endregion
	}
}
