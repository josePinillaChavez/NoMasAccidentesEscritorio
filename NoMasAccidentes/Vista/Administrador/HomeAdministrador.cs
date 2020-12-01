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
			cargarGrillaDocTributario();
			cargarGrillaCurso();
			cargarGrillaVisita();
			cargarGrillaAccidente();
			cargarGrillaCaso();






		}

		public void cargarGrillaAccidente()
		{
			AccidenteController accidente = new AccidenteController();
			DataTable dt = new DataTable();
			dt = accidente.listarAccidente();
			//empresa.ListarEmpresa();

			try
			{
				dgvAccidentes.Refresh();
				dgvAccidentes.DataSource = dt;

				dgvAccidentes.Update();
			}
			catch (Exception ex)
			{


			}

		}


		public void cargarGrillaCaso()
		{
			CasosController caso = new CasosController();
			DataTable dt = new DataTable();
			dt = caso.listarCasos();
			//empresa.ListarEmpresa();

			try
			{
				dgvCasos.Refresh();
				dgvCasos.DataSource = dt;

				dgvCasos.Update();
			}
			catch (Exception ex)
			{


			}

		}


		public void cargarGrillaVisita()
		{
			VisitaController visita = new VisitaController();
			DataTable dt = new DataTable();
			dt = visita.listarVisitas();
			//empresa.ListarEmpresa();

			try
			{
				dgvVisitas.Refresh();
				dgvVisitas.DataSource = dt;

				dgvVisitas.Update();
			}
			catch (Exception ex)
			{


			}

		}


		public void cargarGrillaCurso()
		{
			CursoController curso = new CursoController();
			DataTable dt = new DataTable();
			dt = curso.listarCurso();
			//empresa.ListarEmpresa();

			try
			{
				dgvCurso.Refresh();
				dgvCurso.DataSource = dt;

				dgvCurso.Update();
			}
			catch (Exception ex)
			{


			}

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
				dataGridViewEmpresa.Columns["id_empresa"].Visible = false;
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
				dgvprofesional.Columns["ID_PROFESIONAL"].Visible = false;
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
				dgvUsuario.Columns["ID_USUARIO"].Visible = false;
				
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

		public void cargarGrillaDocTributario()
		{
			DocTributarioController docTributario = new DocTributarioController();
			DataTable dt = new DataTable();
			dt = docTributario.ListarContrato();

			try
			{
				dgvDocTribu.Refresh();
				dgvDocTribu.DataSource = dt;
				dgvDocTribu.Update();
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
			formEmpresa.txtRutEmpresa.Text = rellenaDatos.Cells["Rut empresa"].Value.ToString();
			formEmpresa.txtDvEmpresa.Text = rellenaDatos.Cells["Dv empresa"].Value.ToString();
			formEmpresa.txtNombreEmpresa.Text = rellenaDatos.Cells["Nombre empresa"].Value.ToString();
			formEmpresa.txtTelefonoEmpresa.Text = rellenaDatos.Cells["Telefono Empresa"].Value.ToString();
			formEmpresa.txtEmailEmpresa.Text = rellenaDatos.Cells["Email empresa"].Value.ToString();
			formEmpresa.txtEstadoEmpresa.Text = rellenaDatos.Cells["Estado Empresa"].Value.ToString();
			formEmpresa.txtRubroEmpresa.Text = rellenaDatos.Cells["Rubro empresa"].Value.ToString();

		
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

			formEmpresa.FormClosed += new FormClosedEventHandler(formEmpresa_FormClosed);


		}









			private void btnAgregarEmpresa_Click(object sender, EventArgs e)
		{

			EmpresaAdministrador formEmpresa = new EmpresaAdministrador();

			formEmpresa.btnActualizar.Enabled = false;
			formEmpresa.btnEliminar.Enabled = false;
			formEmpresa.txtEstadoEmpresa.Text = "1";
			formEmpresa.txtEstadoEmpresa.Enabled = false;



			formEmpresa.Show();
			formEmpresa.FormClosed += new FormClosedEventHandler(formEmpresa_FormClosed);

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
			formProfesional.txtNombreProfesional.Text = rellenaDatos.Cells["Nombre profesional"].Value.ToString();
			formProfesional.txtEstadoProfesional.Text = rellenaDatos.Cells["Estado profesional"].Value.ToString();
			formProfesional.txtApellidopaterno.Text = rellenaDatos.Cells["Apellido paterno"].Value.ToString();
			formProfesional.txtApellidoMaterno.Text = rellenaDatos.Cells["Apellido materno"].Value.ToString();
			formProfesional.txtRutProfesional.Text = rellenaDatos.Cells["Rut profesional"].Value.ToString();
			formProfesional.txtDvProfesional.Text = rellenaDatos.Cells["Dv rut"].Value.ToString();
			formProfesional.txtTelefonoProfesional.Text = rellenaDatos.Cells["Telefono"].Value.ToString();
			formProfesional.txtEmailProfesional.Text = rellenaDatos.Cells["Email"].Value.ToString();


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
			formProfesional.FormClosed += new FormClosedEventHandler(formProfesional_FormClosed);




		}

		private void btnAgregarUsuario_Click(object sender, EventArgs e)
		{
			FormUsuarioAdministrador formUsuario = new FormUsuarioAdministrador();

			formUsuario.txtEstadoUsuario.Enabled = false;
			formUsuario.txtIdUsuario.Enabled = false;
			formUsuario.txtEstadoUsuario.SelectedText = "1";


			formUsuario.Show();
			formUsuario.FormClosed += new FormClosedEventHandler(formUsuario_FormClosed);
		}

		private void btnCrearprofesional_Click(object sender, EventArgs e)
		{
			ProfesionalAdministrador formProfesional = new ProfesionalAdministrador();
			
			formProfesional.txtEstadoProfesional.Enabled = false;


			formProfesional.Show();
			formProfesional.FormClosed += new FormClosedEventHandler(formProfesional_FormClosed);
		}

		private void dgvContrato_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow rellenaDatos = dgvContrato.Rows[e.RowIndex];
			ContratoController contrato = new ContratoController();
            contrato.EliminarContrato(int.Parse(rellenaDatos.Cells["id_contrato"].Value.ToString()));
			cargarGrillaContrato();
			cargarGrillaDocTributario();
		}

		private void btnCrearContrato_Click(object sender, EventArgs e)
		{


			ContratoAdministrador formContrato = new ContratoAdministrador();
			formContrato.Show();

			formContrato.FormClosed += new FormClosedEventHandler(formContrato_FormClosed);


		}




		private void btnRefrescar_Click(object sender, EventArgs e)
		{
			cargarGrillaEmpresa();
			
			cargarGrillaUsuario();
			cargarGrillaContrato();
		}

		private void formEmpresa_FormClosed(object sender, FormClosedEventArgs e)
		{
			//when child form is closed, this code is executed   
			// Bind the Grid view       
			cargarGrillaEmpresa();
		}


		private void formProfesional_FormClosed(object sender, FormClosedEventArgs e)
		{
			//when child form is closed, this code is executed   
			// Bind the Grid view       
			cargarGrillaProfesional();
		}



		private void formUsuario_FormClosed(object sender, FormClosedEventArgs e)
		{
			//when child form is closed, this code is executed   
			// Bind the Grid view       
			cargarGrillaUsuario();
		}

		private void formContrato_FormClosed(object sender, FormClosedEventArgs e)
		{
			//when child form is closed, this code is executed   
			// Bind the Grid view       
			cargarGrillaContrato();
			cargarGrillaDocTributario();
		}

		private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{


			FormUsuarioAdministrador formUsuario = new FormUsuarioAdministrador();
			DataGridViewRow rellenaDatos = dgvUsuario.Rows[e.RowIndex];
			formUsuario.txtIdUsuario.Enabled = false;
			formUsuario.txtIdUsuario.Text = rellenaDatos.Cells["ID_USUARIO"].Value.ToString();
			formUsuario.txtPerfilUsuario.Text = rellenaDatos.Cells["Perfil usuario"].Value.ToString();
			formUsuario.txtNombreUsuario.Text = rellenaDatos.Cells["Nombre usuario"].Value.ToString();
			formUsuario.txtContrasenaUsuario.Text = rellenaDatos.Cells["Contraseña Usuario"].Value.ToString();
			formUsuario.txtEstadoUsuario.Text = rellenaDatos.Cells["Estado usuario"].Value.ToString();
			formUsuario.txtRutUsuario.Text = rellenaDatos.Cells["Rut usuario"].Value.ToString();
			formUsuario.txtDvUsuario.Text = rellenaDatos.Cells["Dv Usuario"].Value.ToString();



			if (!string.IsNullOrEmpty(rellenaDatos.Cells["ID_USUARIO"].Value.ToString()))
			{
				formUsuario.btnCrearUsuario.Enabled = false;
			}
			else
			{
				formUsuario.btnActualizarUsuario.Enabled = false;
				formUsuario.btnEliminarUsuario.Enabled = false;
				formUsuario.txtEstadoUsuario.Text = "1";
				formUsuario.txtEstadoUsuario.Enabled = false;


			}
			formUsuario.Show();
			formUsuario.FormClosed += new FormClosedEventHandler(formUsuario_FormClosed);



		}

		private void formCurso_FormClosed(object sender, FormClosedEventArgs e)
		{
			//when child form is closed, this code is executed   
			// Bind the Grid view       
			cargarGrillaCurso();
		}
		private void btnCrearCurso_Click(object sender, EventArgs e)
		{

			FormCursoAdministrador formCurso = new FormCursoAdministrador();
			formCurso.txtIdCurso.Enabled = false;
			formCurso.Show();

			formCurso.FormClosed += new FormClosedEventHandler(formCurso_FormClosed);
		}

		private void dgvCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			FormCursoAdministrador formCurso= new FormCursoAdministrador();
			DataGridViewRow rellenaDatos = dgvCurso.Rows[e.RowIndex];
			formCurso.txtidContrato1.Enabled = false;
			formCurso.btnCrearCurso.Enabled = false;

		
			formCurso.txtidContrato1.Text = rellenaDatos.Cells["Numero de contrato"].Value.ToString();
			

			//formCurso.txtidContrato1.Text = rellenaDatos.Cells["id_curso"].Value.ToString();
			formCurso.txtIdCurso.Text = rellenaDatos.Cells["Numero de curso"].Value.ToString();
			formCurso.txtCurso.Text = rellenaDatos.Cells["Nombre de curso"].Value.ToString();
			formCurso.dtmInicio.Value = Convert.ToDateTime(rellenaDatos.Cells["Inicio curso"].Value.ToString());
			formCurso.dtmTermino.Value = Convert.ToDateTime(rellenaDatos.Cells["Termino curso"].Value.ToString());
			//formCurso.txtidContrato1.Text = rellenaDatos.Cells["nombre"].Value.ToString();
			formCurso.txtMateriales.Text = rellenaDatos.Cells["Materiales"].Value.ToString();
			//formCurso.cmbUsuario.Text = rellenaDatos.Cells["nombre_curso"].Value.ToString();




		

			formCurso.Show();
			formCurso.FormClosed += new FormClosedEventHandler(formCurso_FormClosed);
		}

		private void btnCrearVisita_Click(object sender, EventArgs e)
		{
			FormVisitaAdministrador formCurso = new FormVisitaAdministrador();

			formCurso.txtVisitaId.Enabled = false;
			formCurso.Show();

			formCurso.FormClosed += new FormClosedEventHandler(formVivita_FormClosed);


		}

		private void formVivita_FormClosed(object sender, FormClosedEventArgs e)
		{
			//when child form is closed, this code is executed   
			// Bind the Grid view       
			cargarGrillaVisita();
		}

		private void dgvVisitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			FormVisitaAdministrador formCurso = new FormVisitaAdministrador();
			DataGridViewRow rellenaDatos = dgvVisitas.Rows[e.RowIndex];
			formCurso.cmbUsuario.Enabled = false;
			formCurso.cmbContrato.Enabled = false;
			formCurso.txtVisitaId.Enabled = false;
			formCurso.btnCrearVisita.Enabled = false;
			
			formCurso.txtVisitaId.Text = rellenaDatos.Cells["id_visita"].Value.ToString();
			formCurso.dtmInicio.Value = Convert.ToDateTime(rellenaDatos.Cells["Fecha inicio visita"].Value.ToString());
			formCurso.dtmTermino.Value = Convert.ToDateTime(rellenaDatos.Cells["Fecha termino vitisa"].Value.ToString());





			formCurso.Show();
			formCurso.FormClosed += new FormClosedEventHandler(formVivita_FormClosed);
		}

		private void formCaso_FormClosed(object sender, FormClosedEventArgs e)
		{
			//when child form is closed, this code is executed   
			// Bind the Grid view       
			cargarGrillaCaso();
		}
		private void btnCaso_Click(object sender, EventArgs e)
		{
			FormCasoAdministrador formCaso= new FormCasoAdministrador();

			formCaso.txtIdCaso.Enabled = false;
			formCaso.Show();

			formCaso.FormClosed += new FormClosedEventHandler(formCaso_FormClosed);
		}



		private void dgvCasos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			FormCasoAdministrador formCaso= new FormCasoAdministrador();
			DataGridViewRow rellenaDatos = dgvCasos.Rows[e.RowIndex];
			formCaso.txtIdCaso.Enabled = false;
			formCaso.btnCrearCaso.Enabled = false;
			
			formCaso.txtIdContrato.Text = rellenaDatos.Cells["Numero de contrato"].Value.ToString();
			formCaso.txtIdCaso.Text = rellenaDatos.Cells["Numero de caso"].Value.ToString();
			formCaso.dtmCaso.Text = rellenaDatos.Cells["Fecha caso"].Value.ToString();
			formCaso.txtDescripcion.Text = rellenaDatos.Cells["Descripcion caso"].Value.ToString();
			
			//formCaso.txtVisitaId.Text = rellenaDatos.Cells["id_visita"].Value.ToString();
			//formCaso.dtmInicio.Value = Convert.ToDateTime(rellenaDatos.Cells["fecha_inicio"].Value.ToString());
			//formCaso.dtmTermino.Value = Convert.ToDateTime(rellenaDatos.Cells["fecha_termino"].Value.ToString());






			formCaso.Show();
			formCaso.FormClosed += new FormClosedEventHandler(formCaso_FormClosed);
		}


		private void formAccidente_FormClosed(object sender, FormClosedEventArgs e)
		{
			//when child form is closed, this code is executed   
			// Bind the Grid view       
			cargarGrillaAccidente();
		}
		private void btnCrearAccidente_Click(object sender, EventArgs e)
		{
			FormAccidenteAdministrador accidente = new FormAccidenteAdministrador();

			accidente.txtIdAccidente.Enabled = false;
			accidente.Show();

			accidente.FormClosed += new FormClosedEventHandler(formAccidente_FormClosed);
		}

		private void dgvAccidentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			FormAccidenteAdministrador formAccidente= new FormAccidenteAdministrador();
			DataGridViewRow rellenaDatos = dgvAccidentes.Rows[e.RowIndex];
			btnCrearAccidente.Enabled = false;
			formAccidente.txtIdAccidente.Enabled = false;
			formAccidente.txtIdAccidente.Text = rellenaDatos.Cells["Numero De accidente"].Value.ToString();
			formAccidente.txtIdContrato.Text = rellenaDatos.Cells["Numero de contrato"].Value.ToString();

			//formAccidente.txt.Text = rellenaDatos.Cells["ID_DETALLE_CONTRATO"].Value.ToString();
			formAccidente.txtDetalleAccidente.Text = rellenaDatos.Cells["Detalle accidente"].Value.ToString();
			formAccidente.dtmAccidente.Text = rellenaDatos.Cells["Fecha accidente"].Value.ToString();
			//formCaso.txtIdContrato.Text = rellenaDatos.Cells["USUARIO"].Value.ToString();

		//formCaso.txtVisitaId.Text = rellenaDatos.Cells["id_visita"].Value.ToString();
		//formCaso.dtmInicio.Value = Convert.ToDateTime(rellenaDatos.Cells["fecha_inicio"].Value.ToString());
		//formCaso.dtmTermino.Value = Convert.ToDateTime(rellenaDatos.Cells["fecha_termino"].Value.ToString());






		formAccidente.Show();
			formAccidente.FormClosed += new FormClosedEventHandler(formAccidente_FormClosed);
		}
	}
}
