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
	public partial class FormVisitaAdministrador : Form
	{
		public FormVisitaAdministrador()
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

		private void btnCrearCurso_Click(object sender, EventArgs e)
		{
			VisitaController visita = new VisitaController();

			string IN_ID_CONTRATO = cmbContrato.SelectedValue.ToString();			
			DateTime IN_FECHA_INICIO = Convert.ToDateTime(dtmInicio.Text.ToString());
			DateTime IN_FECHA_TERMINMO = Convert.ToDateTime(dtmTermino.Text.ToString());			
			int IN_USUARIO = Convert.ToInt32(cmbUsuario.SelectedValue.ToString());


			visita.crearVisita(IN_ID_CONTRATO,IN_FECHA_INICIO,IN_FECHA_TERMINMO,IN_USUARIO);

			var result = MessageBox.Show("Creado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();

		}

		private void btnActualizarVisita_Click(object sender, EventArgs e)
		{
			VisitaController visita = new VisitaController();

			int id_visita = int.Parse(txtVisitaId.Text.ToString());
			int IN_ID_DETALLE_CONTRATO = int.Parse(cmbContrato.SelectedValue.ToString());
			DateTime IN_FECHA_INICIO = Convert.ToDateTime(dtmInicio.Text.ToString());
			DateTime IN_FECHA_TERMINMO = Convert.ToDateTime(dtmTermino.Text.ToString());

			int IN_USUARIO = int.Parse(cmbUsuario.SelectedValue.ToString());

			visita.ActualizarVisita(id_visita,IN_ID_DETALLE_CONTRATO,IN_FECHA_INICIO,IN_FECHA_TERMINMO,IN_USUARIO,0);
			var result = MessageBox.Show("Actualizado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();

		}

		private void btnEliminarVisita_Click(object sender, EventArgs e)
		{
			VisitaController visita = new VisitaController();
			int IN_ID_VISITA = int.Parse(txtVisitaId.Text.ToString());
			visita.eliminarVisita(IN_ID_VISITA);
			var result = MessageBox.Show("Actualizado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();
		}
	}
}
