using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json;
using NoMasAccidentes.Modelo;
using Oracle.ManagedDataAccess.Client;

namespace NoMasAccidentes.Controlador
{
	public class EmpresaController
	{

		public DataTable ListarEmpresa()
		{			
			DataTable dt = new DataTable();
			string strFieldString;
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://localhost:44348/api/empresa/listar");
			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			using (Stream stream = response.GetResponseStream())
			using (StreamReader reader = new StreamReader(stream))
			{
				var json = reader.ReadToEnd();

				var a = JsonConvert.DeserializeObject<List<Empresa>>(json);
				dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
			}



			return dt;
		}


		public void ActualizarEmpresa(int idEmpresa,int idRubro,string rut,string dv,string nombre,int telefono,string email)
		{

			var url = $"https://localhost:44348/api/Empresa/actualizar";
			var request = (HttpWebRequest)WebRequest.Create(url);
			string json = $"{{\"idEmpresa\":\"{idEmpresa}\",\"idRubro\":\"{idRubro}\",\"rut\":\"{rut}\",\"dv_rut\":\"{dv}\",\"nombre\":\"{nombre}\",\"telefono\":\"{telefono}\",\"email\":\"{email}\"}}";
					   			 
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


		public void crearEmpresa(int idRubro, string rut, string dv, string nombre, int telefono, string email)
		{
			

			var url = $"https://localhost:44348/api/Empresa/crear";
			var request = (HttpWebRequest)WebRequest.Create(url);
			string json = $"{{\"idRubro\":\"{idRubro}\",\"rut\":\"{rut}\",\"dv_rut\":\"{dv}\",\"nombre\":\"{nombre}\",\"telefono\":\"{telefono}\",\"email\":\"{email}\"}}";




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


		public void eliminarEmpresa(int idEmpresa)
		{



			var url = $"https://localhost:44348/api/Empresa";
			var request = (HttpWebRequest)WebRequest.Create(url);
			string json = $"{{\"idEmpresa\":\"{idEmpresa}\"}}";
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
