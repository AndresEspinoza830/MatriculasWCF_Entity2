using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Matriculas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUbigeo" en el código y en el archivo de configuración a la vez.
    public class ServicioUbigeo : IServicioUbigeo
    {
        public List<UbigeoDepartamentoDC> Ubigeo_Departamentos()
        {
            try
            {
                SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
                List<UbigeoDepartamentoDC> objLista = new List<UbigeoDepartamentoDC>();

                var query = (from miUbigeo in MisMatriculas.Tb_Ubigeo
                             orderby miUbigeo.Departamento
                             select new UbigeoDepartamentoDC
                             {
                                 IdDepa = miUbigeo.IdDepa,
                                 Departamento = miUbigeo.Departamento
                             }).Distinct().ToList();

                foreach (var objConsulta in query)
                {
                    objLista.Add(objConsulta);
                }

                return objLista;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Ubigeo_ProvinciasDepartamentoDC> Ubigeo_ProvinciasDepartamento(String strIdDepartamento)
        {
            try
            {
                SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
                List<Ubigeo_ProvinciasDepartamentoDC> objLista = new List<Ubigeo_ProvinciasDepartamentoDC>();

                var query = (from miUbigeo in MisMatriculas.Tb_Ubigeo
                             where miUbigeo.IdDepa == strIdDepartamento
                             orderby miUbigeo.IdProv
                             select new Ubigeo_ProvinciasDepartamentoDC
                             {
                                 IdProv = miUbigeo.IdProv,
                                 Provincia = miUbigeo.Provincia
                             }).Distinct().ToList();

                foreach (var objConsulta in query)
                {
                    objLista.Add(objConsulta);
                }

                return objLista;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Ubigeo_DistritosProvinciaDepartamentoDC> Ubigeo_DistritosProvinciaDepartamento(String strIdDepartamento, String strIdProvincia)
        {
            try
            {
                SISTEMA_MATRICULASEntities MisMatriculas = new SISTEMA_MATRICULASEntities();
                List<Ubigeo_DistritosProvinciaDepartamentoDC> objLista = new List<Ubigeo_DistritosProvinciaDepartamentoDC>();

                var query = (from miUbigeo in MisMatriculas.Tb_Ubigeo
                             where miUbigeo.IdDepa == strIdDepartamento && miUbigeo.IdProv == strIdProvincia
                             orderby miUbigeo.Distrito
                             select new Ubigeo_DistritosProvinciaDepartamentoDC
                             {
                                 IdDis = miUbigeo.IdDist,
                                 Distrito = miUbigeo.Distrito
                             }).Distinct().ToList();

                foreach (var objConsulta in query)
                {
                    objLista.Add(objConsulta);
                }

                return objLista;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
