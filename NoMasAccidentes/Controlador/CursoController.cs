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
	class CursoController
	{
		UsuarioController usuario = new UsuarioController();

		public DataTable listarCurso()
		{
			string token = usuario.obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			DataTable dt = new DataTable();


			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "curso", "listar");



			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);
			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			using (Stream stream = response.GetResponseStream())
			using (StreamReader reader = new StreamReader(stream))
			{
				var json = reader.ReadToEnd();

				//var a = JsonConvert.DeserializeObject<List<CursoModel>>(json);
				dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
			}



			return dt;

		}


		public bool crearCurso(string IN_ID_CONTRATO, string IN_NOMBRE_CURSO, DateTime IN_FECHA_INICIO, DateTime IN_FECHA_TERMINMO, string IN_MATERIALES, int IN_USUARIO)
		{
			string token = usuario.obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			bool ok = false;
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "curso", "crear");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);
			string json = $"{{\"id_contrato\":\"{IN_ID_CONTRATO}\",\"nombre_curso\":\"{IN_NOMBRE_CURSO}\"," +
				$"\"fecha_inicio\":\"{IN_FECHA_INICIO}\",\"fecha_termino\":\"{IN_FECHA_TERMINMO}\",\"materiales\":\"{IN_MATERIALES}\",\"usuario\":\"{IN_USUARIO}\"}}";

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

		public bool ActualizarCurso(int IN_ID_CURSO, int IN_ID_DETALLE_CONTRATO, string IN_NOMBRE_CURSO, DateTime IN_FECHA_INICIO, DateTime IN_FECHA_TERMINMO, string IN_MATERIALES, int IN_USUARIO)
		{
			string token = usuario.obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "curso", "actualizar");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);

			string json = $"{{\"id_curso\":\"{IN_ID_CURSO}\",\"id_contrato\":\"{IN_ID_DETALLE_CONTRATO}\",\"nombre_curso\":\"{IN_NOMBRE_CURSO}\",\"fecha_inicio\":\"{IN_FECHA_INICIO}\",\"fecha_termino\":\"{IN_FECHA_TERMINMO}\",\"materiales\":\"{IN_MATERIALES}\",\"usuario\":\"{IN_USUARIO}\"}}";






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


		public void eliminarCurso(int IN_ID_CURSO)
		{
			string token = usuario.obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "curso", "eliminar");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);


			string json = $"{{\"id_curso\":\"{IN_ID_CURSO}\"}}";
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
