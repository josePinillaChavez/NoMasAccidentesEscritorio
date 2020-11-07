using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMasAccidentes.Modelo
{
	public class AccidenteModel
	{
		public int ID_ACCIDENTE { get; set; }
		public int ID_DETALLE_CONTRATO { get; set; }
		public string DETALLE_ACCIDENTE { get; set; }
		public DateTime FECHA_ACCIDENTE { get; set; }
		public int USUARIO { get; set; }
	}



	public class RootAccidenteModel
	{
		public List<AccidenteModel> MyArray { get; set; }
	}


}
