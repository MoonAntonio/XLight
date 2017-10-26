//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// Program.cs (01/10/2017)                                              		\\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:     Clase central del programa									\\
// Fecha Mod:       01/10/2017                                                  \\
// Ultima Mod:      Version Inicial												\\
//******************************************************************************\\

#region Librerias
using System;
using System.Windows.Forms;
using XLight.Formularios;
#endregion

namespace XLight
{
	static class Program
	{
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Splash());
			// TODO Testeo
			//Application.Run(new Main());
		}
	}
}
