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
	class VisitaController
	{
		UsuarioController usuario = new UsuarioController();

		public DataTable listarVisitas()
		{
			string token = usuario.obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			DataTable dt = new DataTable();


			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "visita", "listar");



			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);
			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			using (Stream stream = response.GetResponseStream())
			using (StreamReader reader = new StreamReader(stream))
			{
				var json = reader.ReadToEnd();

				//var a = JsonConvert.DeserializeObject<List<VisitaModel>>(json);
				dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
			}



			return dt;

		}


		public bool crearVisita(string IN_ID_DETALLE_CONTRATO, DateTime IN_FECHA_INICIO, DateTime IN_FECHA_TERMINMO, int IN_USUARIO)
		{
			string token = usuario.obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			bool ok = false;
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "visita", "crear");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);

			string json = $"{{\"id_contrato\":\"{IN_ID_DETALLE_CONTRATO}\",\"fecha_inicio\":\"{IN_FECHA_INICIO}\"," +
				$"\"fecha_termino\":\"{IN_FECHA_TERMINMO}\",\"usuario\":\"{IN_USUARIO}\"}}";

			


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



		public bool ActualizarVisita(int IN_ID_VISITA, int IN_ID_DETALLE_CONTRATO, DateTime IN_FECHA_INICIO, DateTime IN_FECHA_TERMINO, int IN_USUARIO, int IN_RESUELTO)
		{
			string token = usuario.obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "visita", "actualizar");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);


			string json = $"{{\"id_visita\":\"{IN_ID_VISITA}\",\"id_contrato\":\"{IN_ID_DETALLE_CONTRATO}\",\"fecha_inicio\":\"{IN_FECHA_INICIO}\",\"fecha_termino\":\"{IN_FECHA_TERMINO}\",\"usuario\":\"{IN_USUARIO}\",\"resuelto\":\"{IN_RESUELTO}\"}}";





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

		public void eliminarVisita(int IN_ID_VISITA)
		{
			string token = usuario.obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "visita", "eliminar");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);



			string json = $"{{\"id_visita\":\"{IN_ID_VISITA}\"}}";
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
