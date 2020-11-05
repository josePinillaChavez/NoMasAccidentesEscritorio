using NoMasAccidentes.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMasAccidentes.Controlador
{
	class ContratoController
	{

		public DataTable ListarContrato()
		{
			DataSet dti = new DataSet();
			DataTable dt = new DataTable();
			try
			{
				ContratoModel contrato = new ContratoModel();
				dt = contrato.ListarContrato();
			}
			catch (Exception ex)
			{

			}
			return dt;
		}

	}
}
