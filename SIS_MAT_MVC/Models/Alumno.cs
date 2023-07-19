using SIS_MAT_MVC.ProxyAlumno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIS_MAT_MVC.Models
{
    public class AlumnoModel
    {
        public AlumnoDC Alumno { get; set; }
        public Ubigeo Ubigeo { get; set; }
    }
}