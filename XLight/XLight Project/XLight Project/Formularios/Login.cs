//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// Login.cs (01/10/2017)                                              			\\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:     Formulario de Login											\\
// Fecha Mod:       01/10/2017                                                  \\
// Ultima Mod:      Version Inicial												\\
//******************************************************************************\\

#region Librerias
using System;
using System.Windows.Forms;
using XLight_Project.Clases;
#endregion

namespace XLight_Project.Formularios
{
	/// <summary>
	/// <para>Formulario de Login</para>
	/// </summary>
	public partial class Login : Form
	{
		#region Variables Publicas
		/// <summary>
		/// <para>Configuracion actual de los ajustes.</para>
		/// </summary>
		public Ajustes configuracionActual;                                     // Configuracion actual de los ajustes
		#endregion

		#region Constructores
		/// <summary>
		/// <para>Constructor de <see cref="Login"/>.</para>
		/// </summary>
		public Login()// Constructor de Login
		{
			InitializeComponent();
		}

		/// <summary>
		/// <para>Constructor de <see cref="Login"/>.</para>
		/// </summary>
		/// <param name="config">Configuracion actual del sistema.</param>
		public Login(Ajustes config)// Constructor de Login
		{
			configuracionActual = config;

			InitializeComponent();
		}
		#endregion

		#region Loader
		/// <summary>
		/// <para>Loader de <see cref="Login"/>.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Login_Load(object sender, EventArgs e)// Loader de Login
		{

		}
		#endregion

	}
}
