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
	public partial class FormCasoAdministrador : Form
	{
		public FormCasoAdministrador()
		{
			InitializeComponent();

			ContratoController contrato = new ContratoController();
			DataTable data = new DataTable();
			data = contrato.ListarContratoCombo();

			cmbContrato.DataSource = data;
			cmbContrato.ValueMember = "id_contrato";
			cmbContrato.DisplayMember = "id_contrato";


			TipoCasoController tipoCaso = new TipoCasoController();
			DataTable dataTipoCaso = new DataTable();
			dataTipoCaso = tipoCaso.ListarTipoCasoCombo();

			cmbTipoCaso.DataSource = dataTipoCaso;
			cmbTipoCaso.ValueMember = "id_tipo_caso";
			cmbTipoCaso.DisplayMember = "descripcion";

		}

		private void btnCrearCaso_Click(object sender, EventArgs e)
		{
			CasosController caso = new CasosController();
			int IN_ID_CONTRATO = int.Parse(cmbContrato.SelectedValue.ToString());
			int IN_ID_TIPO_CASO = int.Parse(cmbTipoCaso.SelectedValue.ToString());
			DateTime IN_FECHA_CASO = Convert.ToDateTime(dtmCaso.Text.ToString());
			string IN_RESUELTO = "0";

			
			caso.crearCaso(IN_ID_CONTRATO, IN_ID_TIPO_CASO, IN_FECHA_CASO, IN_RESUELTO);
			var result = MessageBox.Show("Creado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();

		}

		private void FormCasoAdministrador_Load(object sender, EventArgs e)
		{



			ContratoController contrato = new ContratoController();
			DataTable data = new DataTable();
			data = contrato.ListarContratoCombo();

			cmbContrato.DataSource = data;
			cmbContrato.ValueMember = "id_contrato";
			cmbContrato.DisplayMember = "id_contrato";

			string descripcion = txtIdContrato.Text;
			cmbContrato.SelectedIndex = cmbContrato.FindStringExact(descripcion);


			TipoCasoController tipoCaso = new TipoCasoController();
			DataTable dataTipoCaso = new DataTable();
			dataTipoCaso = tipoCaso.ListarTipoCasoCombo();

			cmbTipoCaso.DataSource = dataTipoCaso;
			cmbTipoCaso.ValueMember = "id_tipo_caso";
			cmbTipoCaso.DisplayMember = "descripcion";

			string descripcion2 = txtDescripcion.Text;
			cmbTipoCaso.SelectedIndex = cmbTipoCaso.FindStringExact(descripcion2);


		}

		private void btnActualizarContrato_Click(object sender, EventArgs e)
		{
			CasosController casos = new CasosController();
			int IN_ID_CASO = int.Parse(txtIdCaso.Text.ToString());
			int IN_ID_CONTRATO = int.Parse(cmbContrato.SelectedValue.ToString());
			string IN_ID_TIPO_CASO = cmbTipoCaso.SelectedValue.ToString();
			string IN_RESUELTO = "0";
			DateTime IN_FECHA_CASO =Convert.ToDateTime( dtmCaso.Text.ToString());
			casos.ActualizarCaso(IN_ID_CASO,IN_ID_CONTRATO,IN_ID_TIPO_CASO,IN_RESUELTO,IN_FECHA_CASO);

			var result = MessageBox.Show("Actualizado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();
		}

		private void btnBorrarContrato_Click(object sender, EventArgs e)
		{
			CasosController casos = new CasosController();
			int idCaso = int.Parse(txtIdCaso.Text.ToString());

			casos.eliminarCaso(idCaso);
			var result = MessageBox.Show("Eliminado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();

		}
	}
}
