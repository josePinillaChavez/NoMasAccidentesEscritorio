using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMasAccidentes.Modelo
{

	// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
	public class Empresa
	{
		public int id_empresa { get; set; }
		public string rut { get; set; }
		public string dv_rut { get; set; }
		public string nombre { get; set; }
		public int telefono { get; set; }
		public string email { get; set; }
		public string vigente { get; set; }
		public string descripcion { get; set; }
	}

	public class RootEmpresa
	{
		public List<Empresa> MyArray { get; set; }
	}





}
