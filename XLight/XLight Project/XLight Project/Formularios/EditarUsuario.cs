using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XLight_Project.Clases;

namespace XLight_Project.Formularios
{
	public partial class EditarUsuario : Form
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
		/// <para>Cliente</para>
		/// </summary>
		public string cliente;// Cliente
		#endregion

		public EditarUsuario()
		{
			InitializeComponent();
		}

		public EditarUsuario(Ajustes config, Usuario user, string nombre)
		{
			configuracionActual = config;
			usuarioActual = user;
			cliente = nombre;

			InitializeComponent();
		}

		private void BtnGuardarUsuario_Click(object sender, EventArgs e)
		{

		}
	}
}
