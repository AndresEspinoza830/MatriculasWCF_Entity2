using SIS_MAT_MVC.ProxyEspecialidad;
using SIS_MAT_MVC.ProxyProfesor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIS_MAT_MVC.Models
{
	public class ProfesorModel
	{
		public Ubigeo Ubigeo { get; set; }

		public ProfesorDC Profesor { get; set; }

		public Especialidad Especialidad { get; set; }
	}
}