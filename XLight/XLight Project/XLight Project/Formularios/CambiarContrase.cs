//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// CambiarContrase.cs (01/10/2017)                                              \\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:     Formulario de CambiarContrase								\\
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
	/// <para>Formulario de CambiarContrase</para>
	/// </summary>
	public partial class CambiarContrase : Form
	{
		#region Variables Publicas
		/// <summary>
		/// <para>Usuario actual del sistema.</para>
		/// </summary>
		public Usuario usuarioActual;                                           // Usuario actual del sistema
		/// <summary>
		/// <para>Formulario</para>
		/// </summary>
		public Main form;														// Formulario
		#endregion

		#region Constructores
		/// <summary>
		/// <para>Constructor de <see cref="CambiarContrase"/>.</para>
		/// </summary>
		public CambiarContrase()// Constructor de CambiarContrase
		{
			InitializeComponent();
		}

		/// <summary>
		/// <para>Constructor de <see cref="CambiarContrase"/>.</para>
		/// </summary>
		/// <param name="user">Usuario</param>
		public CambiarContrase(Usuario user, Main forms)// Constructor de CambiarContrase
		{
			usuarioActual = user;
			form = forms;

			InitializeComponent();
		}
		#endregion

		#region Metodos GUI
		/// <summary>
		/// <para>Cmabia la contras</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnCambiar_Click(object sender, EventArgs e)// Cmabia la contras
		{
			if (visualTextBox1.Text != string.Empty)
			{
				if (visualTextBox1.Text == usuarioActual.Password)
				{
					usuarioActual.Password = visualTextBox2.Text;

					MessageBox.Show("Contraseña cambiada");

					form.CambioContr(usuarioActual);

					this.Close();
				}
				else
				{
					MessageBox.Show("Introduce la contraseña correcta.");
				}
			}
			else
			{
				MessageBox.Show("Introduce una contraseña antigua.");
			}
		}
		#endregion
	}
}
