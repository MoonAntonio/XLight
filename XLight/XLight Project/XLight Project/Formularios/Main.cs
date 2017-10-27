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
using System.Windows.Forms;
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

		}
		#endregion

		#region Metodos GUI
		private void BtnMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

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
		#endregion

		private void BtnSalir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void BtnClientes_Click(object sender, EventArgs e)
		{

		}

		private void BtnBalance_Click(object sender, EventArgs e)
		{

		}

		private void BtnHistorial_Click(object sender, EventArgs e)
		{

		}

		private void BtnOpciones_Click(object sender, EventArgs e)
		{

		}
	}
}
