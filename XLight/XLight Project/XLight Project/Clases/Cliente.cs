//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// Cliente.cs (01/10/2017)                                              		\\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:     Clase del cliente											\\
// Fecha Mod:       01/10/2017                                                  \\
// Ultima Mod:      Version Inicial												\\
//******************************************************************************\\

namespace XLight_Project.Clases
{
	/// <summary>
	/// <para>Clase del cliente</para>
	/// </summary>
	public class Cliente
	{
		#region Constructor
		/// <summary>
		/// <para>Constructor de la clase <see cref="Cliente"/>.</para>
		/// </summary>
		/// <param name="i">Id del cliente.</param>
		/// <param name="n">Nombre del cliente.</param>
		/// <param name="a">Apellidos del cliente.</param>
		/// <param name="d">DNI del cliente.</param>
		/// <param name="t">Telefono del cliente.</param>
		/// <param name="f">Fecha del cliente.</param>
		/// <param name="di">Direccion del cliente.</param>
		public Cliente(int i, string n, string a, string d, string t, string f, string di)// Constructor de la clase Cliente
		{
			id = i;
			nombre = n;
			apellidos = a;
			dni = d;
			telefono = t;
			fecha = f;
			direccion = di;
		}
		#endregion

		#region Variables Privadas
		/// <summary>
		/// <para>Id del cliente</para>
		/// </summary>
		private int id;									// Id del cliente
		/// <summary>
		/// <para>Nombre del cliente</para>
		/// </summary>
		private string nombre;							// Nombre del cliente
		/// <summary>
		/// <para>Apellidos del cliente</para>
		/// </summary>
		private string apellidos;						// Apellidos del cliente
		/// <summary>
		/// <para>DNI del cliente</para>
		/// </summary>
		private string dni;								// DNI del cliente
		/// <summary>
		/// <para>Telefono del cliente</para>
		/// </summary>
		private string telefono;						// Telefono del cliente
		/// <summary>
		/// <para>Fecha del cliente</para>
		/// </summary>
		private string fecha;							// Fecha del cliente
		/// <summary>
		/// <para>Direccion del cliente</para>
		/// </summary>
		private string direccion;                       // Direccion del cliente
		#endregion

		#region Propiedades
		/// <summary>
		/// <para>Id del cliente</para>
		/// </summary>
		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		/// <summary>
		/// <para>Nombre del cliente</para>
		/// </summary>
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		/// <summary>
		/// <para>Apellidos del cliente</para>
		/// </summary>
		public string Apellidos
		{
			get { return apellidos; }
			set { apellidos = value; }
		}

		/// <summary>
		/// <para>DNI del cliente</para>
		/// </summary>
		public string DNI
		{
			get { return dni; }
			set { dni = value; }
		}

		/// <summary>
		/// <para>Telefono del cliente</para>
		/// </summary>
		public string Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}

		/// <summary>
		/// <para>Fecha del cliente</para>
		/// </summary>
		public string Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}

		/// <summary>
		/// <para>Direccion del cliente</para>
		/// </summary>
		public string Direccion
		{
			get { return direccion; }
			set { direccion = value; }
		}
		#endregion
	}
}
