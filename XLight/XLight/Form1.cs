using System;
using System.Windows.Forms;

namespace XLight
{
	public partial class Splash : Form
	{
		#region Constructor
		public Splash()
		{
			InitializeComponent();

		}
		#endregion

		#region Metodos
		/// <summary>
		/// <para>Timer</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Timer1_Tick(object sender, EventArgs e)// Timer
		{
			try
			{
				progressBar.Width += 1;
				ProcesarTexto();
				if (progressBar.Width >= 635f)
				{
					timer1.Stop();
					Main main = new Main();
					main.Show();
					this.Hide();
				}
			}
			catch (Exception)
			{
				return;
			}
		}

		/// <summary>
		/// <para>Procesa el texto.</para>
		/// </summary>
		private void ProcesarTexto()// Procesa el texto
		{
			switch (progressBar.Width)
			{
				case 100:
					lblSeguimiento.Text = "Cargando componentes ...";
					break;

				case 300:
					lblSeguimiento.Text = "Generando recursos ...";
					break;

				case 500:
					lblSeguimiento.Text = "Cargando sistema ...";
					break;

				case 600:
					lblSeguimiento.Text = "Inicializando sistema ...";
					break;
			}
		}
		#endregion
	}
}
