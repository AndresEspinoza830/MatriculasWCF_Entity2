using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_WCF_Matriculas
{
    public partial class ProfesorMan02 : Form
    {
        ProxyProfesor.ServicioProfesorClient objServiceProfesor = new ProxyProfesor.ServicioProfesorClient();
        ProxyProfesor.ProfesorDC objProfesorDC = new ProxyProfesor.ProfesorDC();

        ProxyEspecialidad.ServicioEspecialidadClient objServiceEspecialidad = new ProxyEspecialidad.ServicioEspecialidadClient();
        ProxyEspecialidad.EspecialidadDC objEspecialidadDC = new ProxyEspecialidad.EspecialidadDC();
        public ProfesorMan02()
        {
            InitializeComponent();
        }

        private void ProfesorMan02_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargamos los combos
                var especialidades = objServiceEspecialidad.ListarEspecialidad();
                DataTable dt = ConvertToDataTable(especialidades);

                DataRow dr;

                dr = dt.NewRow();
                dr["Id_esp"] = 0;
                dr["Des_esp"] = "-Seleccione-";
                dt.Rows.InsertAt(dr, 0);
                cmbEspecialidad.DataSource = dt;
                cmbEspecialidad.ValueMember = "Id_esp";
                cmbEspecialidad.DisplayMember = "Des_esp";

                cmbEstado.SelectedItem = "-Seleccione-";
                cmbSexo.SelectedItem = "-Seleccione-";

            //    CargarUbigeo("14", "01", "01");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private DataTable ConvertToDataTable<T>(IEnumerable<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }

            return table;
        }
    




        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {

           /* cmbDepartamento.DataSource = objUbigeoBL.Ubigeo_Departamentos();
            cmbDepartamento.DisplayMember = "Departamento";
            cmbDepartamento.ValueMember = "IdDepa";
            cmbDepartamento.SelectedValue = IdDepa;

            cmbProvincia.DataSource = objUbigeoBL.Ubigeo_ProvinciasDepartamento(IdDepa);
            cmbProvincia.DisplayMember = "Provincia";
            cmbProvincia.ValueMember = "IdProv";
            cmbProvincia.SelectedValue = IdProv;

            cmbDistrito.DataSource = objUbigeoBL.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cmbDistrito.DisplayMember = "Distrito";
            cmbDistrito.ValueMember = "IdDist";
            cmbDistrito.SelectedValue = IdDist;*/


        }
    }
}
