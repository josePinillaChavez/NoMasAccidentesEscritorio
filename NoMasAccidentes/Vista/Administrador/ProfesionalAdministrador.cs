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
	public partial class ProfesionalAdministrador : Form
	{
		public ProfesionalAdministrador()
		{
			InitializeComponent();
		}

		private void ProfesionalAdministrador_Load(object sender, EventArgs e)
		{

		}

		private void btnVovlerProfesional_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCrearProfesional_Click(object sender, EventArgs e)
		{
			ProfesionalController profesional= new ProfesionalController();
			string nombre = txtNombreProfesional.Text.ToString();
			string apellidoPaterno = txtApellidopaterno.Text.ToString();
			string apellidoMaterno = txtApellidoMaterno.Text.ToString();
			string rut = txtRutProfesional.Text.ToString();
			string dvRut = txtDvProfesional.Text.ToString();
			int telefono = Convert.ToInt32(txtTelefonoProfesional.Text.ToString());
			string email = txtEmailProfesional.Text.ToString();
			profesional.crearProfesional(nombre,apellidoPaterno,apellidoMaterno, rut, dvRut,telefono,email);
			var result = MessageBox.Show("Creado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();


		}

		private void btnActualizarProfesional_Click(object sender, EventArgs e)
		{
			ProfesionalController profesional = new ProfesionalController();
			int idProfesional = Convert.ToInt32(txtIdProfesional.Text.ToString());
			string nombre = txtNombreProfesional.Text.ToString();
			string apellidoPaterno = txtApellidopaterno.Text.ToString();
			string apellidoMaterno = txtApellidoMaterno.Text.ToString();
			string rut = txtRutProfesional.Text.ToString();
			string dvRut = txtDvProfesional.Text.ToString();
			int telefono = Convert.ToInt32(txtTelefonoProfesional.Text.ToString());
			string email = txtEmailProfesional.Text.ToString();
			profesional.ActualizarProfesional(idProfesional,nombre, apellidoPaterno, apellidoMaterno, rut, dvRut, telefono, email);


			var result = MessageBox.Show("Creado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();


		}

		private void btnEliminarProfesional_Click(object sender, EventArgs e)
		{
			ProfesionalController profesional = new ProfesionalController();
			int idProfesional = Convert.ToInt32(txtIdProfesional.Text.ToString());

			profesional.eliminarProfesional(idProfesional);


			var result = MessageBox.Show("Creado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();

		}
	}
}
