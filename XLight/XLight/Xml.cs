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

			XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0.0", "UTF-8", null);
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
		public void AgregarHistorial(string id, string nom, TiposTratamiento tipo, string fecha, string precio, string resultado)// Agrega un elemento al historial
		{

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
