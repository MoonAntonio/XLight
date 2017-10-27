//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// Ajustes.cs (01/10/2017)                                              		\\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:     Clase con los ajustes										\\
// Fecha Mod:       01/10/2017                                                  \\
// Ultima Mod:      Version Inicial												\\
//******************************************************************************\\

namespace XLight_Project.Clases
{
	public class Ajustes
	{
		#region Constructor
		/// <summary>
		/// <para>Constructor de <see cref="Ajustes"/>.</para>
		/// </summary>
		/// <param name="pData">Ruta de Data.</param>
		/// <param name="pUser">Ruta de usuarios.</param>
		/// <param name="pHisto">Ruta de historial.</param>
		/// <param name="pClien">Ruta de clientes.</param>
		/// <param name="pAjustes">Ruta de ajustes.</param>
		/// <param name="idAc">Id actual.</param>
		/// <param name="uUser">Ultimo usuario logeado.</param>
		public Ajustes(string pData,string pUser, string pAjustes, string uUser)// Constructor de Ajustes
		{
			pathData = pData;
			pathUsuarios = pUser;
			pathAjustes = pAjustes;
			ultimoUser = uUser;
		}
		#endregion

		#region Variables Privadas
		/// <summary>
		/// <para>Ruta de data.</para>
		/// </summary>
		private string pathData;					// Ruta de data
		/// <summary>
		/// <para>Ruta de usuarios.</para>
		/// </summary>
		private string pathUsuarios;				// Ruta de usuarios
		/// <summary>
		/// <para>Ruta de ajustes.</para>
		/// </summary>
		private string pathAjustes;					// Ruta de ajustes
		/// <summary>
		/// <para>Ultimo usuario logeado.</para>
		/// </summary>
		private string ultimoUser;                  // Ultimo usuario logeado
		#endregion

		#region Propiedades
		/// <summary>
		/// <para>Ruta de data</para>
		/// </summary>
		public string PathData
		{
			get { return pathData; }
			set { pathData = value; }
		}

		/// <summary>
		/// <para>Ruta de usuarios</para>
		/// </summary>
		public string PathUsuarios
		{
			get { return pathUsuarios; }
			set { pathUsuarios = value; }
		}

		/// <summary>
		/// <para>Ruta de ajustes</para>
		/// </summary>
		public string PathAjustes
		{
			get { return pathAjustes; }
			set { pathAjustes = value; }
		}

		/// <summary>
		/// <para>Ultimo usuario logeado.</para>
		/// </summary>
		public string UltimoUser
		{
			get { return ultimoUser; }
			set { ultimoUser = value; }
		}
		#endregion
	}
}
