using Newtonsoft.Json;
using NoMasAccidentes.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NoMasAccidentes.Controlador
{
	class DocTributarioController
	{

		public DataTable ListarContrato()
		{
			DataTable dt = new DataTable();
			string strFieldString;
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://localhost:44348/api/docTributario/listar");
			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			using (Stream stream = response.GetResponseStream())
			using (StreamReader reader = new StreamReader(stream))
			{
				var json = reader.ReadToEnd();



				var a = JsonConvert.DeserializeObject<List<DocTributario>>(json);
				dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
			}



			return dt;
		}
	}
}
