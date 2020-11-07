using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMasAccidentes.Modelo
{
	// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
	public class DocTributario
	{
		public int id_doc_tributarios { get; set; }
		public int id_contrato { get; set; }
		public string detalle { get; set; }
		public string pagado { get; set; }
		public DateTime fecha_vencimiento { get; set; }
		public string nombre { get; set; }
	}

	public class RootDocTributario
	{
		public List<DocTributario> MyArray { get; set; }
	}


}
