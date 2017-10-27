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
		public Usuario(string nom,string pass, int nvl)// Constructor de Usuario
		{
			nombre = nom;
			password = pass;
			nvlPrivilegios = nvl;
		}
		#endregion

		#region Variables Privadas
		/// <summary>
		/// <para>Nombre del usuario</para>
		/// </summary>
		private string nombre;					// Nombre del usuario
		/// <summary>
		/// <para>Password del usuario.</para>
		/// </summary>
		private string password;				// Password del usuario
		/// <summary>
		/// <para>Nivel de seguridad</para>
		/// </summary>
		private int nvlPrivilegios;				// Nivel de seguridad
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
		#endregion
	}
}
