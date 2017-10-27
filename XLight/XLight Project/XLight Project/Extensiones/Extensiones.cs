//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// Extensiones.cs (01/10/2017)                                              	\\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:     Extensiones para el sistema									\\
// Fecha Mod:       01/10/2017                                                  \\
// Ultima Mod:      Version Inicial												\\
//******************************************************************************\\

namespace XLight_Project.Extensiones
{
	/// <summary>
	/// <para>Extensiones para el sistema</para>
	/// </summary>
	public static class Extensiones
	{
		#region Funcionalidad
		/// <summary>
		/// <para>Obtiene el valor true o false.</para>
		/// </summary>
		/// <param name="valor">Valor</param>
		/// <returns></returns>
		public static bool GetValor(int valor)// Obtiene el valor true o false
		{
			return valor == 0 ? false : true;
		}
		#endregion
	}
}
