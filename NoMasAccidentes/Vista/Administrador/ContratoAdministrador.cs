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
	public partial class ContratoAdministrador : Form
	{
		public ContratoAdministrador()
		{
			InitializeComponent();

			ProfesionalController profesional = new ProfesionalController();
			DataTable dataProfesional = new DataTable();
			dataProfesional = profesional.ListarProfesional();

			cmbProfesional.DataSource = dataProfesional;
			cmbProfesional.ValueMember = "idProfesional";
			cmbProfesional.DisplayMember = "nombre";



			EmpresaController empresa = new EmpresaController();
			DataTable dataEmpresa = new DataTable();
			dataEmpresa = empresa.ListarEmpresaCombo();

			cmdEmpresa.DataSource = dataEmpresa;
			cmdEmpresa.ValueMember = "id_empresa";
			cmdEmpresa.DisplayMember = "nombre";


		}

		private void btnVolverContrato_Click(object sender, EventArgs e)
		{
			ContratoAdministrador ventanaContrato = new ContratoAdministrador();
			ventanaContrato.Close();
		}

		private void btnCrearContrato_Click(object sender, EventArgs e)
		{
			ContratoController contrato = new ContratoController();
			contrato.crearContrato(int.Parse(cmbProfesional.SelectedValue.ToString()), int.Parse(cmdEmpresa.SelectedValue.ToString()));
			MessageBox.Show("Creado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();

		}

		private void ContratoAdministrador_Load(object sender, EventArgs e)
		{



		}
	}
}
