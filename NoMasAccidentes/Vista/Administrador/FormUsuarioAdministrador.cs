using NoMasAccidentes.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoMasAccidentes.Vista.Administrador
{
	public partial class FormUsuarioAdministrador : Form
	{
		public FormUsuarioAdministrador()
		{
			InitializeComponent();




		}

		private void btnCrearUsuario_Click(object sender, EventArgs e)
		{

			UsuarioController usuarioController = new UsuarioController();

			string idPerfil = cmbPerfiUsuario.SelectedValue.ToString();
			string usuario = txtNombreUsuario.Text.ToString();
			string contrasena = txtContrasenaUsuario.Text.ToString();
			string estado = txtEstadoUsuario.Text.ToString();
			string rutUsuario = txtRutUsuario.Text.ToString();
			string dvRut = txtDvUsuario.Text.ToString();

			usuarioController.crearUsuario(idPerfil,usuario,contrasena,estado,rutUsuario,dvRut);

			var result = MessageBox.Show("Creado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();

		}

		private void FormUsuarioAdministrador_Load(object sender, EventArgs e)
		{
			PerfilController perfil = new PerfilController();
			DataTable data = new DataTable();
			data = perfil.ListarPerfil();

			cmbPerfiUsuario.DataSource = data;
			cmbPerfiUsuario.ValueMember = "id_perfil";
			cmbPerfiUsuario.DisplayMember = "DESCRIPCION";

			string descripcion = txtPerfilUsuario.Text;
			cmbPerfiUsuario.SelectedIndex = cmbPerfiUsuario.FindStringExact(descripcion);
		}

		private void btnEliminarUsuario_Click(object sender, EventArgs e)
		{
			UsuarioController usuarioController = new UsuarioController();
			int idUsuario = Convert.ToInt32(txtIdUsuario.Text.ToString());

			usuarioController.eliminarUsuario(idUsuario);


			var result = MessageBox.Show("Creado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();

		}

		private void btnActualizarUsuario_Click(object sender, EventArgs e)
		{
			UsuarioController usuarioController = new UsuarioController();
			int idUsuario = Convert.ToInt32(txtIdUsuario.Text.ToString());//Convert.ToInt32(cmbPerfiUsuario.SelectedValue.ToString());
			string usuario = txtNombreUsuario.Text.ToString();
			string contrasena = txtContrasenaUsuario.Text.ToString();
			string rutUsuario = txtRutUsuario.Text.ToString();
			string dvRut = txtDvUsuario.Text.ToString();


			usuarioController.ActualizarUsuario(idUsuario,usuario,contrasena,rutUsuario,dvRut);


			var result = MessageBox.Show("Creado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();
		}

		private void btnVovlerUsuario_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
