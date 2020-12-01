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
	class AccidenteController
	{
		UsuarioController usuario = new UsuarioController();



		public DataTable listarAccidente()
		{
			string token = usuario.obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			DataTable dt = new DataTable();


			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "accidente", "listar");



			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);
			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())

			using (Stream stream = response.GetResponseStream())
			using (StreamReader reader = new StreamReader(stream))
			{
				var json = reader.ReadToEnd();

				//var a = JsonConvert.DeserializeObject<List<AccidenteModel>>(json);
				dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
			}



			return dt;

		}



		public bool crearAccidente(int IN_ID_DETALLE_CONTRATO, string IN_DETALLE_ACCIDENTE, DateTime IN_FECHA_ACCIDENTE, int IN_USUARIO)
		{

			UsuarioController usuario = new UsuarioController();
			string token = usuario.obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);

			bool ok = false;
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "accidente", "crear");

			var request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);

			string json = $"{{\"id_contrato\":\"{IN_ID_DETALLE_CONTRATO}\",\"detalle_accidente\":\"{IN_DETALLE_ACCIDENTE}\"," +
				$"\"fecha_accidente\":\"{IN_FECHA_ACCIDENTE}\",\"usuario\":\"{IN_USUARIO}\"}}";

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



		public bool ActualizarAccidente(int IN_ID_ACCIDENTE, int IN_ID_DETALLE_CONTRATO, string IN_DETALLE_ACCIDENTE, DateTime IN_FECHA_ACCIDENTE, int IN_USUARIO)
		{
			string token = usuario.obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "accidente", "actualizar");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);

			string json = $"{{\"id_acciente\":\"{IN_ID_ACCIDENTE}\",\"id_contrato\":\"{IN_ID_DETALLE_CONTRATO}\"," +
				$"\"detalle_accidente\":\"{IN_DETALLE_ACCIDENTE}\",\"fecha_accidente\":\"{IN_FECHA_ACCIDENTE}\",\"usuario\":\"{IN_USUARIO}\"}}";






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

		public void eliminarAccidente(int IN_ID_ACCIDENTE)
		{
			string token = usuario.obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "accidente", "eliminar");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);


			string json = $"{{\"id_acciente\":\"{IN_ID_ACCIDENTE}\"}}";
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
