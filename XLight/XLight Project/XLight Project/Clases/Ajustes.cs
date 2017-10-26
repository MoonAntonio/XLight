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
		public Ajustes(string pData,string pUser, string pHisto, string pClien, string pAjustes, int idAc, string uUser, int iAuto)// Constructor de Ajustes
		{
			pathData = pData;
			pathUsuarios = pUser;
			pathHistorial = pHisto;
			pathClientes = pClien;
			pathAjustes = pAjustes;
			idActual = idAc;
			ultimoUser = uUser;
			inicioAutomatico = iAuto;
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
		/// <para>Ruta de historial.</para>
		/// </summary>
		private string pathHistorial;				// Ruta de historial
		/// <summary>
		/// <para>Ruta de clientes.</para>
		/// </summary>
		private string pathClientes;				// Ruta de clientes
		/// <summary>
		/// <para>Ruta de ajustes.</para>
		/// </summary>
		private string pathAjustes;					// Ruta de ajustes
		/// <summary>
		/// <para>ID actual.</para>
		/// </summary>
		private int idActual;                       // ID actual
		/// <summary>
		/// <para>Ultimo usuario logeado.</para>
		/// </summary>
		private string ultimoUser;                  // Ultimo usuario logeado
		/// <summary>
		/// <para>Inicio automatico de sesion.</para>
		/// </summary>
		private int inicioAutomatico;				// Inicio automatico de sesion
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
		/// <para>Ruta de historial</para>
		/// </summary>
		public string PathHistorial
		{
			get { return pathHistorial; }
			set { pathHistorial = value; }
		}

		/// <summary>
		/// <para>Ruta de clientes</para>
		/// </summary>
		public string PathClientes
		{
			get { return pathClientes; }
			set { pathClientes = value; }
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
		/// <para>ID actual</para>
		/// </summary>
		public int IdActual
		{
			get { return idActual; }
			set { idActual = value; }
		}

		/// <summary>
		/// <para>Ultimo usuario logeado.</para>
		/// </summary>
		public string UltimoUser
		{
			get { return ultimoUser; }
			set { ultimoUser = value; }
		}

		/// <summary>
		/// <para>Inicio automatico</para>
		/// </summary>
		public int InicioAutomatico
		{
			get { return inicioAutomatico; }
			set { inicioAutomatico = value; }
		}
		#endregion
	}
}
