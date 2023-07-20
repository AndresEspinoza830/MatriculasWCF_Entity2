using SIS_MAT_MVC.ProxyUbigeo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIS_MAT_MVC.Models
{
	public class Ubigeo
	{

		public string IdDepa { get; set; }
		public string IdProv { get; set; }
		public string IdDis { get; set; }

		public List<UbigeoDepartamentoDC> Departamentos { get; set; }
		public List<Ubigeo_ProvinciasDepartamentoDC> Provincias { get; set; }
		public List<Ubigeo_DistritosProvinciaDepartamentoDC> Distritos { get; set; }

	}
}