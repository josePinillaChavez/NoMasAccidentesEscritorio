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

		public DataTable listarAccidente()
		{
			DataTable dt = new DataTable();


			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "accidente", "listar");



			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlBase);
			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			using (Stream stream = response.GetResponseStream())
			using (StreamReader reader = new StreamReader(stream))
			{
				var json = reader.ReadToEnd();

				var a = JsonConvert.DeserializeObject<List<AccidenteModel>>(json);
				dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
			}



			return dt;

		}



		public bool crearAccidente(int IN_ID_DETALLE_CONTRATO, string IN_DETALLE_ACCIDENTE, DateTime IN_FECHA_ACCIDENTE, int IN_USUARIO)
		{
		

			bool ok = false;
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "accidente", "crear");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);

			string json = $"{{\"IN_ID_DETALLE_CONTRATO\":\"{IN_ID_DETALLE_CONTRATO}\",\"IN_DETALLE_ACCIDENTE\":\"{IN_DETALLE_ACCIDENTE}\"," +
				$"\"IN_FECHA_ACCIDENTE\":\"{IN_FECHA_ACCIDENTE}\",\"IN_USUARIO\":\"{IN_USUARIO}\"}}";

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
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "accidente", "actualizar");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);


			string json = $"{{\"IN_ID_ACCIDENTE\":\"{IN_ID_ACCIDENTE}\",\"IN_ID_DETALLE_CONTRATO\":\"{IN_ID_DETALLE_CONTRATO}\"," +
				$"\"IN_DETALLE_ACCIDENTE\":\"{IN_DETALLE_ACCIDENTE}\",\"IN_FECHA_ACCIDENTE\":\"{IN_FECHA_ACCIDENTE}\",\"IN_USUARIO\":\"{IN_USUARIO}\"}}";






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

			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "accidente", "eliminar");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);



			string json = $"{{\"IN_ID_ACCIDENTE\":\"{IN_ID_ACCIDENTE}\"}}";
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
