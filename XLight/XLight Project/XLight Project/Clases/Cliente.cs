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
		public Cliente(int i, string n, string a, string d, string t, string f, string di)
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
		private int id;
		private string nombre;
		private string apellidos;
		private string dni;
		private string telefono;
		private string fecha;
		private string direccion;
		#endregion

		#region Propiedades
		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public string Apellidos
		{
			get { return apellidos; }
			set { apellidos = value; }
		}

		public string DNI
		{
			get { return dni; }
			set { dni = value; }
		}

		public string Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}

		public string Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}

		public string Direccion
		{
			get { return direccion; }
			set { direccion = value; }
		}
		#endregion
	}
}
