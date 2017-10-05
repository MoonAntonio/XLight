using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLight
{
	public partial class Main : Form
	{
		#region Constructor
		public Main()
		{
			InitializeComponent();
		}
		#endregion

		#region Loader
		private void Main_Load(object sender, EventArgs e)
		{
			BoxHistorial.Visible = false;
			BoxClientes.Visible = false;
			BoxOpciones.Visible = false;
		}
		#endregion

		#region Metodos Click
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

		private void BtnSalir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void BtnMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void BtnHistorial_Click(object sender, EventArgs e)
		{
			if (BoxHistorial.Visible == true) return;

			BoxHistorial.Visible = true;
			BoxClientes.Visible = false;
			BoxOpciones.Visible = false;
		}

		private void BtnClientes_Click(object sender, EventArgs e)
		{
			if (BoxClientes.Visible == true) return;

			BoxHistorial.Visible = false;
			BoxClientes.Visible = true;
			BoxOpciones.Visible = false;
		}

		private void BtnOpciones_Click(object sender, EventArgs e)
		{
			if (BoxOpciones.Visible == true) return;

			BoxHistorial.Visible = false;
			BoxClientes.Visible = false;
			BoxOpciones.Visible = true;
		}
		#endregion

	}
}
