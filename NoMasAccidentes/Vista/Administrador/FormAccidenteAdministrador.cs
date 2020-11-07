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
	public partial class FormAccidenteAdministrador : Form
	{
		public FormAccidenteAdministrador()
		{
			InitializeComponent();
			ContratoController contrato = new ContratoController();
			DataTable data = new DataTable();
			data = contrato.ListarContratoCombo();

			cmbContrato.DataSource = data;
			cmbContrato.ValueMember = "id_contrato";
			cmbContrato.DisplayMember = "id_contrato";


			UsuarioController usuario = new UsuarioController();
			DataTable dataUsuario= new DataTable();
			dataUsuario = usuario.ListarUsuarioCombo();

			cmbUsuario.DataSource = dataUsuario;
			cmbUsuario.ValueMember = "id_usuario";
			cmbUsuario.DisplayMember = "usuario";

		}

		private void btnCrearAccidente_Click(object sender, EventArgs e)
		{


			AccidenteController accidente = new AccidenteController();
			int IN_ID_DETALLE_CONTRATO = int.Parse(cmbContrato.SelectedValue.ToString());
			string IN_DETALLE_ACCIDENTE = txtDetalleAccidente.Text.ToString();
			DateTime IN_FECHA_ACCIDENTE =Convert.ToDateTime(dtmAccidente.Text.ToString());
			int IN_USUARIO = int.Parse(cmbUsuario.SelectedValue.ToString());

			accidente.crearAccidente(IN_ID_DETALLE_CONTRATO,IN_DETALLE_ACCIDENTE,IN_FECHA_ACCIDENTE,IN_USUARIO);
			var result = MessageBox.Show("Creado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();

		}

		private void FormAccidenteAdministrador_Load(object sender, EventArgs e)
		{
			ContratoController contrato = new ContratoController();
			DataTable data = new DataTable();
			data = contrato.ListarContratoCombo();

			cmbContrato.DataSource = data;
			cmbContrato.ValueMember = "id_contrato";
			cmbContrato.DisplayMember = "id_contrato";

			string descripcion = txtIdContrato.Text;
			cmbContrato.SelectedIndex = cmbContrato.FindStringExact(descripcion);


			UsuarioController usuario = new UsuarioController();
			DataTable dataUsuario = new DataTable();
			dataUsuario = usuario.ListarUsuarioCombo();

			cmbUsuario.DataSource = dataUsuario;
			cmbUsuario.ValueMember = "id_usuario";
			cmbUsuario.DisplayMember = "usuario";

			string descripcion2 = cmbUsuario.Text;
			cmbUsuario.SelectedIndex = cmbUsuario.FindStringExact(descripcion2);
		}

		private void btnActualizarAccidente_Click(object sender, EventArgs e)
		{
			AccidenteController accidente = new AccidenteController();
			int IN_ID_ACCIDENTE = int.Parse(txtIdAccidente.Text.ToString());
			int IN_ID_DETALLE_CONTRATO = int.Parse(cmbContrato.SelectedValue.ToString());
			string IN_DETALLE_ACCIDENTE = txtDetalleAccidente.Text.ToString();
			DateTime IN_FECHA_ACCIDENTE = Convert.ToDateTime(dtmAccidente.Text.ToString());
			int IN_USUARIO = int.Parse(cmbUsuario.SelectedValue.ToString());

			accidente.ActualizarAccidente(IN_ID_ACCIDENTE, IN_ID_DETALLE_CONTRATO, IN_DETALLE_ACCIDENTE,IN_FECHA_ACCIDENTE,IN_USUARIO);

			var result = MessageBox.Show("Actualizado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();
		}

		private void btnBorrarAccidente_Click(object sender, EventArgs e)
		{
			AccidenteController accidente = new AccidenteController();
			int IN_ID_ACCIDENTE = int.Parse(txtIdAccidente.Text.ToString());

			accidente.eliminarAccidente(IN_ID_ACCIDENTE);
			var result = MessageBox.Show("Eliminado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();
		}
	}
}
