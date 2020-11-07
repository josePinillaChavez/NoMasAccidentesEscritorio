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

		public DataTable listarCasos()
		{
			DataTable dt = new DataTable();


			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "caso", "listar");



			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlBase);
			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			using (Stream stream = response.GetResponseStream())
			using (StreamReader reader = new StreamReader(stream))
			{
				var json = reader.ReadToEnd();

				var a = JsonConvert.DeserializeObject<List<CasoModel>>(json);
				dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
			}



			return dt;

		}

		public bool crearCaso(int IN_ID_CONTRATO, int IN_ID_TIPO_CASO, DateTime IN_FECHA_CASO, string IN_RESUELTO)
		{

			bool ok = false;
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "caso", "crear");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);

			string json = $"{{\"IN_ID_CONTRATO\":\"{IN_ID_CONTRATO}\",\"IN_ID_TIPO_CASO\":\"{IN_ID_TIPO_CASO}\"," +
				$"\"IN_FECHA_CASO\":\"{IN_FECHA_CASO}\",\"IN_RESUELTO\":\"{IN_RESUELTO}\"}}";

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
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "caso", "actualizar");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);


			string json = $"{{\"IN_ID_CASO\":\"{IN_ID_CASO}\",\"IN_ID_CONTRATO\":\"{IN_ID_CONTRATO}\"," +
				$"\"IN_ID_TIPO_CASO\":\"{IN_ID_TIPO_CASO}\",\"IN_RESUELTO\":\"{IN_RESUELTO}\",\"IN_FECHA_CASO\":\"{IN_FECHA_CASO}\"}}";






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

			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "caso", "eliminar");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);



			string json = $"{{\"IN_ID_CASO\":\"{IN_ID_CASO}\"}}";
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
