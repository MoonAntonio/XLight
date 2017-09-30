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
	public partial class Splash : Form
	{
		public Splash()
		{
			InitializeComponent();
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				progressBar.Width += 2;
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
	}
}
