using NoMasAccidentes.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMasAccidentes.Controlador
{
	class UsuarioController
	{

		public DataTable ListarUsuario()
		{
			DataSet dti = new DataSet();
			DataTable dt = new DataTable();
			try
			{
				UsuarioModel usuario = new UsuarioModel();
				dt = usuario.ListarUsuario();
			}
			catch (Exception ex)
			{

			}
			return dt;
		}



		public DataTable ActualizarEmpresa(int idEmpresa, int idRubro, string rut, string dv, string nombre, int telefono, string email)
		{
			DataSet dti = new DataSet();
			DataTable dt = new DataTable();
			try
			{
				
				
			}
			catch (Exception ex)
			{

			}



			return dt;

		}



		public DataTable crearEmpresa(int idRubro, string rut, string dv, string nombre, int telefono, string email)
		{
			DataSet dti = new DataSet();
			DataTable dt = new DataTable();
			try
			{
				
				
			}
			catch (Exception ex)
			{

			}



			return dt;

		}

		public DataTable eliminarEmpresa(int idEmpresa)
		{
			DataSet dti = new DataSet();
			DataTable dt = new DataTable();
			try
			{
				
			}
			catch (Exception ex)
			{

			}



			return dt;

		}

	}
}
