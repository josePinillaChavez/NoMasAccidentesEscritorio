using Newtonsoft.Json;
using NoMasAccidentes.Modelo;
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
	class CasosController
	{
		UsuarioController usuario = new UsuarioController();

		public DataTable listarCasos()
		{
			string token = usuario.obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			DataTable dt = new DataTable();


			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "caso", "listar");



			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);
			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			using (Stream stream = response.GetResponseStream())
			using (StreamReader reader = new StreamReader(stream))
			{
				var json = reader.ReadToEnd();

				//var a = JsonConvert.DeserializeObject<List<CasoModel>>(json);
				dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
			}



			return dt;

		}
		
		public bool crearCaso(int IN_ID_CONTRATO, int IN_ID_TIPO_CASO, DateTime IN_FECHA_CASO, string IN_RESUELTO)
		{
			string token = usuario.obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			bool ok = false;
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "caso", "crear");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);
			string json = $"{{\"id_contrato\":\"{IN_ID_CONTRATO}\",\"id_tipo_caso\":\"{IN_ID_TIPO_CASO}\"," +
				$"\"fecha_caso\":\"{IN_FECHA_CASO}\",\"resuelto\":\"{IN_RESUELTO}\"}}";

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


		public bool ActualizarCaso(int IN_ID_CASO, int IN_ID_CONTRATO, string IN_ID_TIPO_CASO, string IN_RESUELTO, DateTime IN_FECHA_CASO)
		{
			string token = usuario.obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "caso", "actualizar");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);

			string json = $"{{\"id_caso\":\"{IN_ID_CASO}\",\"id_contrato\":\"{IN_ID_CONTRATO}\"," +
				$"\"id_tipo_caso\":\"{IN_ID_TIPO_CASO}\",\"resuelto\":\"{IN_RESUELTO}\",\"fecha_caso\":\"{IN_FECHA_CASO}\"}}";






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

		public void eliminarCaso(int IN_ID_CASO)
		{
			string token = usuario.obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "caso", "eliminar");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);


			string json = $"{{\"id_caso\":\"{IN_ID_CASO}\"}}";
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










	}
}
