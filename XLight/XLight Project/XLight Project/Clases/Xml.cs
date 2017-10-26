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

namespace XLight_Project.Clases
{
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
		/// <summary>
		/// <para>Ruta XML</para>
		/// </summary>
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
		/// <param name="ruta">Ruta del archivo.</param>
		/// <param name="nodoRaiz">Nodo inicial.</param>
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
		#endregion
	}
}
