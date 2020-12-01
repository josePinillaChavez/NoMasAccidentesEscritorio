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
	class UsuarioController
	{
		

		public string obtenertoken(string usuario, string password,int perfil)
		{
			DataTable dt = new DataTable();
			bool ok = false;
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "login", "login");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);
			string responseBody = null;
			string token = null;
			string json = $"{{\"usuario\":\"{usuario}\",\"password\":\"{password}\",\"perfil\":\"{perfil}\"}}";

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
						if (strReader == null) return token;
						using (StreamReader objReader = new StreamReader(strReader))
						{
							 responseBody = objReader.ReadToEnd();

							dynamic jsonObj = JsonConvert.DeserializeObject(responseBody);
							token = jsonObj["token"].ToString();


							// Do something with responseBody

						}
					}
				}
			}
			catch (WebException ex)
			{
				return token;
				// Handle error
			}

			return token;
		}


		public DataTable ListarUsuario()
		{
			string token = obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			DataTable dt = new DataTable();


			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "usuario", "listar");



			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);
			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			using (Stream stream = response.GetResponseStream())
			using (StreamReader reader = new StreamReader(stream))
			{
				var json = reader.ReadToEnd();

				var a = JsonConvert.DeserializeObject<List<ProfesioanlReturn>>(json);
				dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
			}



			return dt;
		}


		public bool ActualizarUsuario(int idUsuario, string usuario, string contrasena, string rutUsuario,  string dvRut)
		{
			string token = obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "usuario", "actualizar");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);

			string json = $"{{\"id_usuario\":\"{idUsuario}\",\"usuario\":\"{usuario}\",\"contrasena\":\"{contrasena}\",\"rut_usuario\":\"{rutUsuario}\",\"dv_rut\":\"{dvRut}\"}}";



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
						if (strReader == null) return false;
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
				return false;
				// Handle error
			}

			return true;

		}



		public bool crearUsuario(string idPerfil, string usuario, string contrasena, string estado, string rutUsuario, string dvRut)
		{
			string token = obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			bool ok = false;
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "usuario", "crear");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);
			string json = $"{{\"id_perfil\":\"{idPerfil}\",\"usuario\":\"{usuario}\",\"contrasena\":\"{contrasena}\",\"estado\":\"{estado}\",\"rut_usuario\":\"{rutUsuario}\",\"dv_rut\":\"{dvRut}\"}}";




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
						if (strReader == null) return false;
						using (StreamReader objReader = new StreamReader(strReader))
						{
							string responseBody = objReader.ReadToEnd();
							// Do something with responseBody
							ok = true;
						}
					}
				}
			}
			catch (WebException ex)
			{
				return false;
				// Handle error
			}
			return true;

		}

		public bool eliminarUsuario(int idUsuario)
		{
			string token = obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "usuario", "eliminar");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);



			string json = $"{{\"id_usuario\":\"{idUsuario}\"}}";
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
						if (strReader == null) return false;
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
				return false;
				// Handle error
			}
			return true;
		}

		public DataTable ListarUsuarioCombo()
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
					cmd.CommandText = "SP_LISTAR_USUARIO_COMBO";
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
