//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// Ficha.cs (01/10/2017)                                              			\\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:     Formulario de Ficha											\\
// Fecha Mod:       01/10/2017                                                  \\
// Ultima Mod:      Version Inicial												\\
//******************************************************************************\\

#region Librerias
using System;
using System.Windows.Forms;
using System.Xml;
using XLight_Project.Clases;
#endregion

namespace XLight_Project.Formularios
{
	/// <summary>
	/// <para>Formulario de Ficha</para>
	/// </summary>
	public partial class Ficha : Form
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
		/// <para>Nombre y apellidos del cliente.</para>
		/// </summary>
		public string cliente;													// Nombre y apellidos del cliente
		#endregion

		#region Constructores
		/// <summary>
		/// <para>Constructor de <see cref="Ficha"/>.</para>
		/// </summary>
		public Ficha()// Constructor de Ficha
		{
			InitializeComponent();
		}

		/// <summary>
		/// <para>Constructor de <see cref="Ficha"/>.</para>
		/// </summary>
		/// <param name="config">Configuracion actual de los ajustes</param>
		/// <param name="user">Usuario actual del sistema</param>
		/// <param name="nombre">Nombre y apellidos del cliente</param>
		public Ficha(Ajustes config, Usuario user, string nombre)// Constructor de Ficha
		{
			configuracionActual = config;
			usuarioActual = user;
			cliente = nombre;

			InitializeComponent();
		}
		#endregion

		#region Loader
		private void Ficha_Load(object sender, EventArgs e)
		{

		}
		#endregion
	}
}
