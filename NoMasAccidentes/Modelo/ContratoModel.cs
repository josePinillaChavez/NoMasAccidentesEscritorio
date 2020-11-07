using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMasAccidentes.Modelo
{
	// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
	public class Contrato
	{
		public int id_contrato { get; set; }
		public DateTime fecha_contrato { get; set; }
		public DateTime fecha_termino { get; set; }
		public string activo { get; set; }
		public string nombre { get; set; }
		public string nombreProfesional { get; set; }
	}

	public class Root
	{
		public List<Contrato> MyArray { get; set; }
	}


}
