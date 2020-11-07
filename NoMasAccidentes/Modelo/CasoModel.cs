using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMasAccidentes.Modelo
{
	// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
	public class CasoModel
	{
		public int ID_CASO { get; set; }
		public int ID_CONTRATO { get; set; }
		public string descripcion { get; set; }
		public string nombre { get; set; }
		public DateTime fecha_caso { get; set; }
		public string resuelto { get; set; }
	}

	public class RootCasoModel
	{
		public List<CasoModel> MyArray { get; set; }
	}


}
