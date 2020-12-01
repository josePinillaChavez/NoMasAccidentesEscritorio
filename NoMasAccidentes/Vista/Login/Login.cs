using NoMasAccidentes.Controlador;
using NoMasAccidentes.Modelo;
using NoMasAccidentes.Vista.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoMasAccidentes.Vista.Login
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}

		private void btnIIniciarSesion_Click(object sender, EventArgs e)
		{
			UsuarioController usuario = new UsuarioController();			
			string nombreUsuario = txtUsuario.Text;
			string contrasena = txtContrasena.Text;
			string token = null;
			bool flag = true;

			if (string.IsNullOrEmpty(nombreUsuario)){
				MessageBox.Show("Faltan Ingresar Usuario");
				flag = false;
			}
			if (string.IsNullOrEmpty(contrasena))
			{
				MessageBox.Show("Falta Ingresar Contraseña");
				flag = false;
			}

			if (flag){
				token = usuario.obtenertoken(nombreUsuario, contrasena,3);
			}

			if (string.IsNullOrEmpty(token))
			{
				MessageBox.Show("Error en sus credenciales");
				flag = false;
			}

			if (flag)
			{
				LoginInfo.nombreUsuario = nombreUsuario;
				LoginInfo.contrasena = contrasena;
				LoginInfo.perfil = 3;

				this.Hide();
				HomeAdministrador home = new HomeAdministrador();
				home.Show();
			
				
			}




		}
	}
}
