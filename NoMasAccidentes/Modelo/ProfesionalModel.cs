using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMasAccidentes.Modelo
{


	public class ProfesioanlReturn
	{
		public int idProfesional { get; set; }
		public string nombre { get; set; }
		public string apellidoPaterno { get; set; }
		public string apellidoMaterno { get; set; }
		public string rut { get; set; }
		public string dvRu { get; set; }
		public int telefono { get; set; }
		public string email { get; set; }
		public string vigente { get; set; }
	}

	public class RootprofesioanlReturn
	{
		public List<ProfesioanlReturn> MyArray { get; set; }
	}




	public class ProfesionalModel
	{

		public DataTable ListarEmpresa()
		{
			DataSet dti = new DataSet();
			DataTable dt = new DataTable();
			try
			{
				using (OracleConnection cn = new OracleConnection(ConfigurationManager.AppSettings["Bd"].ToString()))
				{
					OracleDataAdapter da = new OracleDataAdapter();
					OracleCommand cmd = new OracleCommand();
					cmd.Connection = cn;
					cmd.InitialLONGFetchSize = 1000;
					cmd.CommandText = "SP_LISTAR_PROFESIONAL";
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add("T_CURSOR", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
					da.SelectCommand = cmd;
					da.Fill(dt);
				}
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
				using (OracleConnection cn = new OracleConnection(ConfigurationManager.AppSettings["Bd"].ToString()))
				{
					OracleDataAdapter da = new OracleDataAdapter();
					OracleCommand cmd = new OracleCommand();
					cmd.Connection = cn;
					cmd.InitialLONGFetchSize = 1000;
					cmd.CommandText = "SP_UPDATE_EMOPRESA";
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add("IN_ID_EMPRESA", OracleDbType.Int32).Value = idEmpresa;
					cmd.Parameters.Add("IN_ID_RUBRO", OracleDbType.Int32).Value = idRubro;
					cmd.Parameters.Add("IN_RUT", OracleDbType.NVarchar2).Value = rut;
					cmd.Parameters.Add("IN_DV_RUT", OracleDbType.NVarchar2).Value = dv;
					cmd.Parameters.Add("IN_NOMBRE", OracleDbType.NVarchar2).Value = nombre;
					cmd.Parameters.Add("IN_TELEFONO", OracleDbType.Int32).Value = telefono;
					cmd.Parameters.Add("IN_EMAIL", OracleDbType.NVarchar2).Value = email;
					cmd.Parameters.Add("OUT_ESTADO", OracleDbType.Int32).Direction = ParameterDirection.Output;
					cmd.Parameters.Add("OUT_ID_SALIDA", OracleDbType.Int32).Direction = ParameterDirection.Output;
					da.SelectCommand = cmd;
					da.Fill(dt);
				}
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
				using (OracleConnection cn = new OracleConnection(ConfigurationManager.AppSettings["Bd"].ToString()))
				{
					OracleDataAdapter da = new OracleDataAdapter();
					OracleCommand cmd = new OracleCommand();
					cmd.Connection = cn;
					cmd.InitialLONGFetchSize = 1000;
					cmd.CommandText = "SP_CREAR_EMPRESA";
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add("IN_TBL_RUBRO_ID_RUBRO", OracleDbType.Int32).Value = idRubro;
					cmd.Parameters.Add("IN_RUT", OracleDbType.NVarchar2).Value = rut;
					cmd.Parameters.Add("IN_DV_RUT", OracleDbType.NVarchar2).Value = dv;
					cmd.Parameters.Add("IN_NOMBRE", OracleDbType.NVarchar2).Value = nombre;
					cmd.Parameters.Add("IN_TELEFONO", OracleDbType.Int32).Value = telefono;
					cmd.Parameters.Add("IN_EMAIL", OracleDbType.NVarchar2).Value = email;
					cmd.Parameters.Add("IN_VIGENTE", OracleDbType.Char).Value = "1";
					cmd.Parameters.Add("OUT_ESTADO", OracleDbType.Int32).Direction = ParameterDirection.Output;
					cmd.Parameters.Add("OUT_ID_SALIDA", OracleDbType.Int32).Direction = ParameterDirection.Output;



					da.SelectCommand = cmd;
					da.Fill(dt);
				}
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
				using (OracleConnection cn = new OracleConnection(ConfigurationManager.AppSettings["Bd"].ToString()))
				{
					OracleDataAdapter da = new OracleDataAdapter();
					OracleCommand cmd = new OracleCommand();
					cmd.Connection = cn;
					cmd.InitialLONGFetchSize = 1000;
					cmd.CommandText = "SP_DEL_EMPRESA";
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add("IN_ID_EMPRESA", OracleDbType.Int32).Value = idEmpresa;
					cmd.Parameters.Add("OUT_ESTADO", OracleDbType.Int32).Direction = ParameterDirection.Output;
					cmd.Parameters.Add("OUT_ID_SALIDA", OracleDbType.Int32).Direction = ParameterDirection.Output;
					da.SelectCommand = cmd;
					da.Fill(dt);
				}
			}
			catch (Exception ex)
			{

			}



			return dt;

		}
	}
}
