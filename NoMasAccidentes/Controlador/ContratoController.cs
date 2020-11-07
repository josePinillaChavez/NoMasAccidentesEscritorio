using Newtonsoft.Json;
using NoMasAccidentes.Modelo;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NoMasAccidentes.Controlador
{
	class ContratoController
	{

		public DataTable ListarContrato()
		{
			DataTable dt = new DataTable();
			string strFieldString;
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://localhost:44348/api/Contrato/listar");
			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			using (Stream stream = response.GetResponseStream())
			using (StreamReader reader = new StreamReader(stream))
			{
				var json = reader.ReadToEnd();



				var a = JsonConvert.DeserializeObject<List<Contrato>>(json);
				dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
			}



			return dt;
		}


		public void EliminarContrato(int idcontrato)
		{

			var url = $"https://localhost:44348/api/Contrato/eliminar";
			var request = (HttpWebRequest)WebRequest.Create(url);
			string json = $"{{\"idcontrato\":\"{idcontrato}\"}}";
			request.Method = "POST";
			request.ContentType = "application/json";
			request.Accept = "application/json";

			using (var streamWriter = new StreamWriter(request.GetRequestStream()))
			{
				streamWriter.Write(json);
				streamWriter.Flush();
				streamWriter.Close();
			}

			try
			{
				using (WebResponse response = request.GetResponse())
				{
					using (Stream strReader = response.GetResponseStream())
					{
						if (strReader == null) return;
						using (StreamReader objReader = new StreamReader(strReader))
						{
							string responseBody = objReader.ReadToEnd();
							// Do something with responseBody
							Console.WriteLine(responseBody);
						}
					}
				}
			}
			catch (WebException ex)
			{
				// Handle error
			}
		}



		public void crearContrato(int idProfesional, int idEmpresa)
		{


			var url = $"https://localhost:44348/api/Contrato/crear";
			var request = (HttpWebRequest)WebRequest.Create(url);
			string json = $"{{\"idEmpresa\":\"{idEmpresa}\",\"idProfesional\":\"{idProfesional}\"}}";




			request.Method = "POST";
			request.ContentType = "application/json";
			request.Accept = "application/json";

			using (var streamWriter = new StreamWriter(request.GetRequestStream()))
			{
				streamWriter.Write(json);
				streamWriter.Flush();
				streamWriter.Close();
			}

			try
			{
				using (WebResponse response = request.GetResponse())
				{
					using (Stream strReader = response.GetResponseStream())
					{
						if (strReader == null) return;
						using (StreamReader objReader = new StreamReader(strReader))
						{
							string responseBody = objReader.ReadToEnd();
							// Do something with responseBody
							Console.WriteLine(responseBody);
						}
					}
				}
			}
			catch (WebException ex)
			{

				
				// Handle error
			}




		}



		public DataTable ListarContratoCombo()
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
					cmd.CommandText = "SP_LISTAR_CONTRATO_COMBO";
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

	}
}
