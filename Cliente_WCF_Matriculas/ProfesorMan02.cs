using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        proxyUbigeo.ServicioUbigeoClient objServiceUbigeo = new proxyUbigeo.ServicioUbigeoClient();

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
                
               
                CargarUbigeo("01", "01", "01"); 
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
            var departamentos = objServiceUbigeo.Ubigeo_Departamentos();
            cmbDepartamento.DataSource = departamentos;
            cmbDepartamento.DisplayMember = "Departamento";
            cmbDepartamento.ValueMember = "IdDepa";
            cmbDepartamento.SelectedValue= IdDepa;

            var provincias = objServiceUbigeo.Ubigeo_ProvinciasDepartamento(IdDepa);
            cmbProvincia.DataSource = provincias;
            cmbProvincia.DisplayMember = "Provincia";
            cmbProvincia.ValueMember = "IdProv";
            cmbProvincia.SelectedValue = IdProv;

            var distritos = objServiceUbigeo.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cmbDistrito.DataSource = distritos;
            cmbDistrito.DisplayMember = "Distrito";
            cmbDistrito.ValueMember = "IdDis";
            cmbDistrito.SelectedValue = IdDist;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validando
                String selectedEsp = cmbEspecialidad.SelectedItem.ToString();
                String selectedSexo = cmbSexo.SelectedItem.ToString();
                String selectedState = cmbEstado.SelectedItem.ToString();

                if (selectedSexo == "-Seleccione-")
                {
                    throw new Exception("Seleccione el sexo");
                }

                if (selectedEsp == "-Seleccione-")
                {
                    throw new Exception("Seleccione la especialidad");
                }


                if (selectedState == "-Seleccione-")
                {
                    throw new Exception("Seleccione el estado");
                }

                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre esta vacio");
                }

                if (txtApeliido.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido esta vacio");
                }


                if (mskTel.MaskFull != true)
                {
                    throw new Exception("Debe ingresar un numero telefónico de 9 dígitos");
                }

                if (mskDNI.MaskFull != true)
                {
                    throw new Exception("El DNI debe ser de 8 caracteres");
                }
                //if (pctFotoProf.Image == null)
                //{
                //    throw new Exception("Debe registrar la foto.");
                //}

                //Valores

                objProfesorDC.Nom_profe = txtNombre.Text.Trim();
                objProfesorDC.Ape_profe = txtApeliido.Text.Trim();
                objProfesorDC.Dni_profe = mskDNI.Text.Trim();
                objProfesorDC.Tel_profe = mskTel.Text.Trim();
                objProfesorDC.Email_profe = txtEmail.Text.Trim();
                objProfesorDC.Id_esp = Convert.ToInt16(cmbEspecialidad.SelectedValue);
                if (selectedSexo == "Masculino")
                {
                    objProfesorDC.Sexo = "M";
                }
                else if (selectedSexo == "Femenino")
                {
                    objProfesorDC.Sexo = "F";
                }

                if (selectedState == "Activo")
                {
                    objProfesorDC.Est_prof = 1;
                }
                else if (selectedState == "Inactivo")
                {
                    objProfesorDC.Est_prof = 0;
                }

                //  objProfesorDC.Usu_Registro = UsuarioCredenciales.Usuario;
                objProfesorDC.Usu_Registro = null;

                //Foto
                if (pctFotoProf.Image != null)
                {
                    objProfesorDC.Foto_profe = File.ReadAllBytes(openFileDialog1.FileName);
                }
                else
                {
                    objProfesorDC.Foto_profe = File.ReadAllBytes(@".\Img\defaultUser.jpg");
                }

                //Combinacion de valores para el ID_UBIGEO
                objProfesorDC.Id_Ubigeo = cmbDepartamento.SelectedValue.ToString() +
                    cmbProvincia.SelectedValue.ToString() + cmbDistrito.SelectedValue.ToString();

                //Insert
                if (objServiceProfesor.InsertarProfesor(objProfesorDC) == true)
                {
                    MessageBox.Show("Profesor " + objProfesorDC.Nom_profe + " " + objProfesorDC.Ape_profe + " agregado correctamente", "Success", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarUbigeo(cmbDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarUbigeo(cmbDepartamento.SelectedValue.ToString(), cmbProvincia.SelectedValue.ToString(), "01");
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            try
            {

                openFileDialog1.FileName = String.Empty;
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();

                // Si se escogio una foto se carga en el picture Box
                if (openFileDialog1.FileName != String.Empty)
                {
                    pctFotoProf.Image = Image.FromFile(openFileDialog1.FileName);
                }


            }
            catch (Exception ex )
            {
                MessageBox.Show("Error: " + ex.Message); ;
            }
        }
    }
}
