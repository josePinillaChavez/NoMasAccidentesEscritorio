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
	public partial class FormCursoAdministrador : Form
	{
		public FormCursoAdministrador()
		{
			InitializeComponent();

			UsuarioController usuario = new UsuarioController();
			DataTable dataEmpresa = new DataTable();
			dataEmpresa = usuario.ListarUsuarioCombo();

			cmbUsuario.DataSource = dataEmpresa;
			cmbUsuario.ValueMember = "id_usuario";
			cmbUsuario.DisplayMember = "usuario";


			ContratoController contrato = new ContratoController();
			DataTable dataDetalle = new DataTable();
			dataDetalle = contrato.ListarContratoCombo();

			cmbContrato.DataSource = dataDetalle;
			cmbContrato.ValueMember = "id_contrato";
			cmbContrato.DisplayMember = "id_contrato";



		}

		private void btnCrear_Click(object sender, EventArgs e)
		{

			CursoController curso = new CursoController();
			
			string IN_ID_CONTRATO = cmbContrato.SelectedValue.ToString();
			string IN_NOMBRE_CURSO = txtCurso.Text.ToString();
			DateTime IN_FECHA_INICIO = Convert.ToDateTime(dtmInicio.Text.ToString());
			DateTime IN_FECHA_TERMINMO = Convert.ToDateTime(dtmTermino.Text.ToString());
			string IN_MATERIALES = txtMateriales.Text.ToString();
			int IN_USUARIO =Convert.ToInt32(cmbUsuario.SelectedValue.ToString());


			curso.crearCurso(IN_ID_CONTRATO, IN_NOMBRE_CURSO,IN_FECHA_INICIO,IN_FECHA_TERMINMO,IN_MATERIALES,IN_USUARIO);

			var result = MessageBox.Show("Creado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();




		}

		private void FormCursoAdministrador_Load(object sender, EventArgs e)
		{
			ContratoController contrato = new ContratoController();
			DataTable dataDetalle = new DataTable();
			dataDetalle = contrato.ListarContratoCombo();

			cmbContrato.DataSource = dataDetalle;
			cmbContrato.ValueMember = "id_contrato";
			cmbContrato.DisplayMember = "id_contrato";



			string descripcion = txtidContrato1.Text;
			cmbContrato.SelectedIndex = cmbContrato.FindStringExact(descripcion);
			//cmbContrato.SelectedIndex = cmbContrato.FindStringExact(txtDetalleContrato.Text.ToString());
			//int id= int.Parse(txtDetalleContrato.Text.ToString());
			//cmbContrato.SelectedIndex = id;


		}

		private void btnActualizarCurso_Click(object sender, EventArgs e)
		{


			CursoController curso = new CursoController();
			int IN_ID_CURSO = int.Parse(txtIdCurso.Text.ToString());
			int IN_ID_DETALLE_CONTRATO = int.Parse(cmbContrato.SelectedValue.ToString());
			string IN_NOMBRE_CURSO = txtCurso.Text.ToString();
			DateTime IN_FECHA_INICIO =Convert.ToDateTime(dtmInicio.Value);
			DateTime IN_FECHA_TERMINMO = Convert.ToDateTime(dtmTermino.Value);
			//DateTime IN_FECHA_INICIO = Convert.ToDateTime(dtmInicio.Text.ToString());
			//DateTime IN_FECHA_TERMINMO = Convert.ToDateTime(dtmTermino.Text.ToString());
			string IN_MATERIALES = txtMateriales.Text.ToString();
			int IN_USUARIO = int.Parse(cmbUsuario.SelectedValue.ToString());
			curso.ActualizarCurso(IN_ID_CURSO,IN_ID_DETALLE_CONTRATO,IN_NOMBRE_CURSO,IN_FECHA_INICIO,IN_FECHA_TERMINMO,IN_MATERIALES,IN_USUARIO);
			var result = MessageBox.Show("Actualizado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();


		}

		private void btnEliminarCurso_Click(object sender, EventArgs e)
		{
			CursoController curso = new CursoController();
			int IN_ID_CURSO = int.Parse(txtIdCurso.Text.ToString());
			curso.eliminarCurso(IN_ID_CURSO);
			var result = MessageBox.Show("Actualizado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();
		}
	}
}
