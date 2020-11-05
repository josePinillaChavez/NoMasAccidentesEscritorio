using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoMasAccidentes.Controlador;

namespace NoMasAccidentes.Vista.Administrador
{
	public partial class HomeAdministrador : Form
	{
		public HomeAdministrador()
		{

	
			InitializeComponent();
			cargarGrillaEmpresa();
			cargarGrillaProfesional();
			cargarGrillaUsuario();
			cargarGrillaContrato();


		}

		public void cargarGrillaEmpresa()
		{
			EmpresaController empresa = new EmpresaController();
			DataTable dt = new DataTable();
			dt = empresa.ListarEmpresa();
			//empresa.ListarEmpresa();

			try
			{
				dataGridViewEmpresa.Refresh();
				dataGridViewEmpresa.DataSource = dt;
		        dataGridViewEmpresa.Update();
			}
			catch (Exception ex)
			{


			}

		}

		public void cargarGrillaProfesional()
		{
			ProfesionalController profesional = new ProfesionalController();
			DataTable dt = new DataTable();
			dt = profesional.ListarProfesional();

			try
			{
				dgvprofesional.Refresh();
				dgvprofesional.DataSource = dt;
				dgvprofesional.Update();
			}
			catch (Exception ex)
			{


			}

		}

		public void cargarGrillaUsuario()
		{
			UsuarioController usuario = new UsuarioController();
			DataTable dt = new DataTable();
			dt = usuario.ListarUsuario();

			try
			{
				dgvUsuario.Refresh();
				dgvUsuario.DataSource = dt;
				dgvUsuario.Update();
			}
			catch (Exception ex)
			{


			}

		}

		public void cargarGrillaContrato()
		{
			ContratoController contrato = new ContratoController();
			DataTable dt = new DataTable();
			dt = contrato.ListarContrato();

			try
			{
				dgvContrato.Refresh();
				dgvContrato.DataSource = dt;
				dgvUsuario.Update();
			}
			catch (Exception ex)
			{


			}

		}

		private void dataGridViewEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{			
			EmpresaAdministrador formEmpresa = new EmpresaAdministrador();
			DataGridViewRow rellenaDatos = dataGridViewEmpresa.Rows[e.RowIndex];
			formEmpresa.txtEstadoEmpresa.Enabled = false;
			formEmpresa.txtIdEmpresa.Text = rellenaDatos.Cells["id_empresa"].Value.ToString();
			formEmpresa.txtRutEmpresa.Text = rellenaDatos.Cells["rut"].Value.ToString();
			formEmpresa.txtDvEmpresa.Text = rellenaDatos.Cells["dv_rut"].Value.ToString();
			formEmpresa.txtNombreEmpresa.Text = rellenaDatos.Cells["nombre"].Value.ToString();
			formEmpresa.txtTelefonoEmpresa.Text = rellenaDatos.Cells["telefono"].Value.ToString();
			formEmpresa.txtEmailEmpresa.Text = rellenaDatos.Cells["email"].Value.ToString();
			formEmpresa.txtEstadoEmpresa.Text = rellenaDatos.Cells["vigente"].Value.ToString();
			formEmpresa.txtRubroEmpresa.Text = rellenaDatos.Cells["descripcion"].Value.ToString();

			if (!string.IsNullOrEmpty(rellenaDatos.Cells["id_empresa"].Value.ToString()))
			{
				formEmpresa.btnCrear.Enabled = false;
			}
			else
			{
				formEmpresa.btnActualizar.Enabled = false;
				formEmpresa.btnEliminar.Enabled = false;
				formEmpresa.txtEstadoEmpresa.Text = "1";
				formEmpresa.txtEstadoEmpresa.Enabled = false;


			}
			formEmpresa.Show();

		}

		private void btnAgregarEmpresa_Click(object sender, EventArgs e)
		{

			EmpresaAdministrador formEmpresa = new EmpresaAdministrador();

			formEmpresa.btnActualizar.Enabled = false;
			formEmpresa.btnEliminar.Enabled = false;
			formEmpresa.txtEstadoEmpresa.Text = "1";
			formEmpresa.txtEstadoEmpresa.Enabled = false;



			formEmpresa.Show();

		}

		private void tabPage2_Click(object sender, EventArgs e)
		{

		}

		private void dgvprofesional_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

			ProfesionalAdministrador formProfesional = new ProfesionalAdministrador();
			DataGridViewRow rellenaDatos = dgvprofesional.Rows[e.RowIndex];
			formProfesional.txtEstadoProfesional.Enabled = false;
			formProfesional.txtIdProfesional.Text = rellenaDatos.Cells["ID_PROFESIONAL"].Value.ToString();
			formProfesional.txtNombreProfesional.Text = rellenaDatos.Cells["NOMBRE"].Value.ToString();
			formProfesional.txtEstadoProfesional.Text = rellenaDatos.Cells["VIGENTE"].Value.ToString();
			formProfesional.txtApellidopaterno.Text = rellenaDatos.Cells["APELLIDO_PATERNO"].Value.ToString();
			formProfesional.txtApellidoMaterno.Text = rellenaDatos.Cells["APELLIDO_MATERNO"].Value.ToString();
			formProfesional.txtRutProfesional.Text = rellenaDatos.Cells["RUT"].Value.ToString();
			formProfesional.txtDvProfesional.Text = rellenaDatos.Cells["DV_RUT"].Value.ToString();
			formProfesional.txtTelefonoProfesional.Text = rellenaDatos.Cells["TELEFONO"].Value.ToString();
			formProfesional.txtEmailProfesional.Text = rellenaDatos.Cells["EMAIL"].Value.ToString();

			if (!string.IsNullOrEmpty(rellenaDatos.Cells["ID_PROFESIONAL"].Value.ToString()))
			{
				formProfesional.btnCrearProfesional.Enabled = false;
			}
			else
			{
				formProfesional.btnActualizarProfesional.Enabled = false;
				formProfesional.btnEliminarProfesional.Enabled = false;
				formProfesional.txtEstadoProfesional.Text = "1";
				formProfesional.txtEstadoProfesional.Enabled = false;


			}
			formProfesional.Show();




		}

		private void btnAgregarUsuario_Click(object sender, EventArgs e)
		{

		}

		private void btnCrearprofesional_Click(object sender, EventArgs e)
		{

		}
	}
}
