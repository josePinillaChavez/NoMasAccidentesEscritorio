using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMasAccidentes.Modelo
{
	public class CursoModel
	{
		public int id_curso { get; set; }
		public string nombre_curso { get; set; }
		public DateTime fecha_inicio { get; set; }
		public DateTime fecha_terminmo { get; set; }
		public string nombre { get; set; }
		public string nombreProfesional { get; set; }
		public string resuelto { get; set; }
	}


	public class RootCursoModel
	{
		public List<CursoModel> MyArray { get; set; }
	}


}
