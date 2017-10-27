//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// Login.cs (01/10/2017)                                              			\\
// Autor: Antonio Mateo (Moon Pincho) 									        \\
// Descripcion:     Formulario de Login											\\
// Fecha Mod:       01/10/2017                                                  \\
// Ultima Mod:      Version Inicial												\\
//******************************************************************************\\

#region Librerias
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using XLight_Project.Clases;
#endregion

namespace XLight_Project.Formularios
{
	/// <summary>
	/// <para>Formulario de Login</para>
	/// </summary>
	public partial class Login : Form
	{
		#region Variables Publicas
		/// <summary>
		/// <para>Configuracion actual de los ajustes.</para>
		/// </summary>
		public Ajustes configuracionActual;                                     // Configuracion actual de los ajustes
		/// <summary>
		/// <para>Usuario actual del sistema.</para>
		/// </summary>
		public Usuario usuarioActual;                                           // Usuario actual del sistema
		#endregion

		#region Variables Privadas
		/// <summary>
		/// <para>Lista de usuarios totales.</para>
		/// </summary>
		private List<Usuario> usuarios = new List<Usuario>();					// Lista de usuarios totales
		#endregion

		#region Constructores
		/// <summary>
		/// <para>Constructor de <see cref="Login"/>.</para>
		/// </summary>
		public Login()// Constructor de Login
		{
			InitializeComponent();
		}

		/// <summary>
		/// <para>Constructor de <see cref="Login"/>.</para>
		/// </summary>
		/// <param name="config">Configuracion actual del sistema.</param>
		public Login(Ajustes config)// Constructor de Login
		{
			// Crear ajustes
			configuracionActual = new Ajustes(config.PathData, config.PathUsuarios, config.PathHistorial, config.PathClientes, config.PathAjustes, config.IdActual, config.UltimoUser, config.InicioAutomatico);

			InitializeComponent();
		}
		#endregion

		#region Loader
		/// <summary>
		/// <para>Loader de <see cref="Login"/>.</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Login_Load(object sender, EventArgs e)// Loader de Login
		{
			// Si esta activado autologin, logear
			if (Extensiones.Extensiones.GetValor(configuracionActual.InicioAutomatico) == true)
			{
				CargarUsuarioActivo();
			}
			else
			{
				CargarUsuarios();
			}
		}
		#endregion

		#region Metodos Privados
		/// <summary>
		/// <para>Logeo manual del usuario.</para>
		/// </summary>
		/// <param name="usuario">Nombre del usuario.</param>
		/// <param name="password">Password del usuario.</param>
		private void Logear(string usuario, string password)// Logeo manual del usuario
		{
			foreach (Usuario u in usuarios)
			{
				if (usuario == u.Nombre)
				{
					if (password == u.Password)
					{
						usuarioActual = new Usuario(usuario, password, u.NivelPrivilegios);

						Main main = new Main(configuracionActual, usuarioActual);
						main.Show();
						this.Close();
					}
					else
					{
						MessageBox.Show("Nombre o contraseña incorrecta.");
						InputName.text = "";
						InputPassword.text = "";
					}
				}
				else
				{
					MessageBox.Show("Nombre o contraseña incorrecta.");
					InputName.text = "";
					InputPassword.text = "";
				}
			}
		}

		/// <summary>
		/// <para>Carga los ajustes</para>
		/// </summary>
		/// <param name="path">Ruta de los ajustes.</param>
		private void CargarAjustes(string path)// Carga los ajustes
		{
			XmlDocument doc = new XmlDocument();

			doc.Load(path);

			XmlNodeList lista = doc.SelectNodes("Ajustes");

			string pathData = lista.Item(0).SelectSingleNode("rutadata").InnerText;
			string pathUsuario = lista.Item(0).SelectSingleNode("rutausuarios").InnerText;
			string pathHistorial = lista.Item(0).SelectSingleNode("rutahistorial").InnerText;
			string pathClientes = lista.Item(0).SelectSingleNode("rutaclientes").InnerText;
			string pathAjustes = lista.Item(0).SelectSingleNode("rutaajustes").InnerText;
			string idActual = lista.Item(0).SelectSingleNode("idactual").InnerText;
			string ultiUser = lista.Item(0).SelectSingleNode("ultimouser").InnerText;
			string inicioAu = lista.Item(0).SelectSingleNode("inicioautomatico").InnerText;

			configuracionActual = new Ajustes(pathData, pathUsuario, pathHistorial, pathClientes, pathAjustes, Int32.Parse(idActual), ultiUser, Int32.Parse(inicioAu));
		}

		/// <summary>
		/// <para>Cargar usuario activo.</para>
		/// </summary>
		private void CargarUsuarioActivo()// Cargar usuario activo
		{
			XmlDocument doc = new XmlDocument();

			doc.Load(configuracionActual.PathUsuarios + "/usuarios.xml");

			XmlNodeList listaUsuarios = doc.SelectNodes("Usuarios/Usuario");
			XmlNode inUser;

			for (int n = 0; n < listaUsuarios.Count; n++)
			{
				inUser = listaUsuarios.Item(n);

				string nom = inUser.SelectSingleNode("nombre").InnerText;
				string pass = inUser.SelectSingleNode("password").InnerText;
				string nvl = inUser.SelectSingleNode("nivel").InnerText;

				if (nom == configuracionActual.UltimoUser)
				{
					usuarioActual = new Usuario(nom, pass, Int32.Parse(nvl));

					Main main = new Main(configuracionActual, usuarioActual);
					main.Show();
					this.Close();
				}
				else
				{
					MessageBox.Show("Nombre o contraseña incorrecta.");
					InputName.text = "";
					InputPassword.text = "";
				}
			}
		}

		/// <summary>
		/// <para>Cargar usuarios.</para>
		/// </summary>
		private void CargarUsuarios()// Cargar usuarios
		{
			XmlDocument doc = new XmlDocument();

			doc.Load(configuracionActual.PathUsuarios + "/usuarios.xml");

			XmlNodeList listaUsuarios = doc.SelectNodes("Usuarios/Usuario");
			XmlNode inUser;

			for (int n = 0; n < listaUsuarios.Count; n++)
			{
				inUser = listaUsuarios.Item(n);

				string nom = inUser.SelectSingleNode("nombre").InnerText;
				string pass = inUser.SelectSingleNode("password").InnerText;
				string nvl = inUser.SelectSingleNode("nivel").InnerText;

				usuarios.Add(new Usuario(nom, pass, Int32.Parse(nvl)));
			}
		}
		#endregion

		#region Metodos GUI
		/// <summary>
		/// <para>Btn Cerrar</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnCerrar_Click(object sender, EventArgs e)// Btn Cerrar
		{
			Application.Exit();
		}

		/// <summary>
		/// <para>Btn Logear</para>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnLogin_Click(object sender, EventArgs e)// Btn Logear
		{
			Logear(InputName.text, InputPassword.text);
		}
		#endregion
	}
}
