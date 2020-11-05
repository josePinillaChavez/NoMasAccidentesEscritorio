using System;
using System.Collections;
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
	public partial class EmpresaAdministrador : Form
	{
		public EmpresaAdministrador()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnVovler_Click(object sender, EventArgs e)
		{


			this.Close();
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			EmpresaController empresa = new EmpresaController();
			int idEmpresa = int.Parse(txtIdEmpresa.Text.ToString());
			int rubroEmpresa =int.Parse(cmdRubro.SelectedValue.ToString());
			string rutEmpresa=txtRutEmpresa.Text.ToString();
			string dvEmpresa=txtDvEmpresa.Text.ToString();
			string nombreEmpresa=txtNombreEmpresa.Text.ToString();
			int telefonoEmpresa=int.Parse(txtTelefonoEmpresa.Text.ToString());
			string emailEmpresa=txtEmailEmpresa.Text.ToString();
		    empresa.ActualizarEmpresa(idEmpresa,rubroEmpresa,rutEmpresa,dvEmpresa,nombreEmpresa,telefonoEmpresa,emailEmpresa);
			var result = MessageBox.Show("Actualizado Correctamente ","Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Question);			
			this.Close();			
		}

		private void EmpresaAdministrador_Load(object sender, EventArgs e)
		{
			RubroController rubro = new RubroController();
			DataTable data = new DataTable();
			data= rubro.ListarRubro();
			
			cmdRubro.DataSource = data;
			cmdRubro.ValueMember = "ID_RUBRO";
			cmdRubro.DisplayMember = "DESCRIPCION";
	

		}

		private void btnCrear_Click(object sender, EventArgs e)
		{
			EmpresaController empresa = new EmpresaController();
			int rubroEmpresa = int.Parse(cmdRubro.SelectedValue.ToString());
			string rutEmpresa = txtRutEmpresa.Text.ToString();
			string dvEmpresa = txtDvEmpresa.Text.ToString();
			string nombreEmpresa = txtNombreEmpresa.Text.ToString();
			int telefonoEmpresa = int.Parse(txtTelefonoEmpresa.Text.ToString());
			string emailEmpresa = txtEmailEmpresa.Text.ToString();
			empresa.crearEmpresa( rubroEmpresa, rutEmpresa, dvEmpresa, nombreEmpresa, telefonoEmpresa, emailEmpresa);
			var result = MessageBox.Show("Creado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			EmpresaController empresa = new EmpresaController();
			int idEmpresa = int.Parse(txtIdEmpresa.Text.ToString());

			empresa.eliminarEmpresa(idEmpresa);
			var result = MessageBox.Show("Eliminado Correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);
			this.Close();

		}
	}
}
