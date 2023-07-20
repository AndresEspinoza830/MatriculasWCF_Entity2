using SIS_MAT_MVC.ProxyEspecialidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIS_MAT_MVC.Models
{
	public class Especialidad
	{
		public int Id_esp { get; set; }
		public String Des_esp { get; set; }
		

		public List<EspecialidadDC> Especialidades { get; set; }
	}
}