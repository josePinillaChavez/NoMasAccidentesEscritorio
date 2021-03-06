﻿using Newtonsoft.Json;
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
	public class ProfesionalController
	{
		UsuarioController usuario = new UsuarioController();

		public DataTable ListarProfesional()
		{
			string token = usuario.obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			DataTable dt = new DataTable();


			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			//var url = $"https://localhost:44348/api/Empresa/crear";
			urlBase = string.Format(urlBase, "api", "profesional", "listar");



			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);

			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			using (Stream stream = response.GetResponseStream())
			using (StreamReader reader = new StreamReader(stream))
			{
				var json = reader.ReadToEnd();

				//var a = JsonConvert.DeserializeObject<List<ProfesioanlReturn>>(json);
				dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
			}



			return dt;
		}


		public bool ActualizarProfesional(int idProfesional, string nombre, string apellidoPaterno, string apellidoMaterno, string rut, string dvRut, int telefono, string email)
		{
			string token = usuario.obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			//var url = $"https://localhost:44348/api/Empresa/crear";
			urlBase = string.Format(urlBase, "api", "profesional", "actualizar");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);

			string json = $"{{\"id_profesional\":\"{idProfesional}\",\"nombre\":\"{nombre}\",\"apellido_paterno\":\"{apellidoPaterno}\",\"apellido_materno\":\"{apellidoMaterno}\",\"rut\":\"{rut}\",\"dv_rut\":\"{dvRut}\",\"telefono\":\"{telefono}\",\"email\":\"{email}\"}}";



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

		
		public bool crearProfesional(string nombre, string apellidoPaterno, string apellidoMaterno, string rut, string dvRut, int telefono, string email)
		{
			string token = usuario.obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			bool ok = false;
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			//var url = $"https://localhost:44348/api/Empresa/crear";
			urlBase = string.Format(urlBase, "api", "profesional", "crear");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);
			string json = $"{{\"nombre\":\"{nombre}\",\"apellido_paterno\":\"{apellidoPaterno}\",\"apellido_materno\":\"{apellidoMaterno}\",\"rut\":\"{rut}\",\"dv_rut\":\"{dvRut}\",\"telefono\":\"{telefono}\",\"email\":\"{email}\",\"vigente\":\"{1}\"}}";




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

		public bool eliminarProfesional(int idProfesional)
		{
			string token = usuario.obtenertoken(LoginInfo.nombreUsuario, LoginInfo.contrasena, LoginInfo.perfil);
			string urlBase = ConfigurationManager.AppSettings["UrlApi"].ToString();
			urlBase = string.Format(urlBase, "api", "profesional", "eliminar");
			var request = (HttpWebRequest)WebRequest.Create(urlBase);
			request.Headers.Add("Authorization", "Bearer " + token);


			string json = $"{{\"id_profesional\":\"{idProfesional}\"}}";
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
	}
}
