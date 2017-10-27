//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// Usuario.cs (01/10/2017)                                              		\\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:     Clase de usuario											\\
// Fecha Mod:       01/10/2017                                                  \\
// Ultima Mod:      Version Inicial												\\
//******************************************************************************\\


namespace XLight_Project.Clases
{
	/// <summary>
	/// <para>Clase de usuario</para>
	/// </summary>
	public class Usuario
	{
		#region Constructor
		/// <summary>
		/// <para>Constructor de <see cref="Usuario"/>.</para>
		/// </summary>
		public Usuario(string nom,string pass, int nvl, string pH,string pC, int idAc, int iA)// Constructor de Usuario
		{
			nombre = nom;
			password = pass;
			nvlPrivilegios = nvl;
			pathHistorial = pH;
			pathClientes = pC;
			idActual = idAc;
			inicioAutomatico = iA;
		}
		#endregion

		#region Variables Privadas
		/// <summary>
		/// <para>Nombre del usuario</para>
		/// </summary>
		private string nombre;						// Nombre del usuario
		/// <summary>
		/// <para>Password del usuario.</para>
		/// </summary>
		private string password;					// Password del usuario
		/// <summary>
		/// <para>Nivel de seguridad</para>
		/// </summary>
		private int nvlPrivilegios;					// Nivel de seguridad
		/// <summary>
		/// <para>Ruta de historial.</para>
		/// </summary>
		private string pathHistorial;				// Ruta de historial
		/// <summary>
		/// <para>Ruta de clientes.</para>
		/// </summary>
		private string pathClientes;				// Ruta de clientes
		/// <summary>
		/// <para>ID actual.</para>
		/// </summary>
		private int idActual;                       // ID actual
		/// <summary>
		/// <para>Inicio automatico de sesion.</para>
		/// </summary>
		private int inicioAutomatico;				// Inicio automatico de sesion
		#endregion

		#region Propiedades
		/// <summary>
		/// <para>Nombre del usuario</para>
		/// </summary>
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		/// <summary>
		/// <para>Password del usuario</para>
		/// </summary>
		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		/// <summary>
		/// <para>Nivel de seguridad</para>
		/// </summary>
		public int NivelPrivilegios
		{
			get { return nvlPrivilegios; }
			set { nvlPrivilegios = value; }
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
		/// <para>ID actual</para>
		/// </summary>
		public int IdActual
		{
			get { return idActual; }
			set { idActual = value; }
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
