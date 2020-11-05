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
	}
}
