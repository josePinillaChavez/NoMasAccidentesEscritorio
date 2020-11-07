using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMasAccidentes.Modelo
{
	public class VisitaModel
	{
		public int id_visita { get; set; }
		public DateTime fecha_inicio { get; set; }
		public DateTime fecha_termino { get; set; }
		public string nombre { get; set; }
		public string nombreProfesional { get; set; }
		public string resuelto { get; set; }

	}


	public class RootVisitaModel
	{
		public List<VisitaModel> MyArray { get; set; }
	}


}
