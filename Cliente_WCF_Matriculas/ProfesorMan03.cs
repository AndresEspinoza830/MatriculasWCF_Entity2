using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Cliente_WCF_Matriculas
{
    public partial class ProfesorMan03 : Form
    {
        ProxyProfesor.ServicioProfesorClient objServiceProfesor = new ProxyProfesor.ServicioProfesorClient();
        ProxyEspecialidad.ServicioEspecialidadClient objServiceEspecialidad = new ProxyEspecialidad.ServicioEspecialidadClient();
        ProxyProfesor.ProfesorDC objProfesorDC = new ProxyProfesor.ProfesorDC();
        proxyUbigeo.ServicioUbigeoClient objServiceUbigeo = new proxyUbigeo.ServicioUbigeoClient();
        DataTable dtProfesores;
        DataView dtv;

        Boolean blnCambioFoto;

        Byte[] FotoOriginal;
        public ProfesorMan03()
        {
            InitializeComponent();
        }
        public Int16 ID { get; set; }

        private void ProfesorMan03_Load(object sender, EventArgs e)
        {
            try
            {
                objProfesorDC = objServiceProfesor.ConsultarProfesor(this.ID);
                Console.WriteLine(objProfesorDC.Distrito);
                Console.WriteLine(objProfesorDC.Provincia);
                Console.WriteLine(objProfesorDC.Departamento);
                Console.WriteLine(objProfesorDC.Est_prof);
                Console.WriteLine(objProfesorDC.Sexo);
                lblID.Text = objProfesorDC.Id_profe.ToString();
                txtNombre.Text = objProfesorDC.Nom_profe;
                txtApeliido.Text = objProfesorDC.Ape_profe;
                mskDNI.Text = objProfesorDC.Dni_profe;
                mskTel.Text = objProfesorDC.Tel_profe;
                txtEmail.Text = objProfesorDC.Email_profe;

                if (objProfesorDC.Est_prof == 1)
                {
                    cmbEstado.SelectedItem = "Activo";
                }
                else if (objProfesorDC.Est_prof == 0)
                {
                    cmbEstado.SelectedItem = "Inactivo";
                }


                if (objProfesorDC.Sexo == "M")
                {
                    cmbSexo.SelectedItem = "Masculino";
                }
                else if (objProfesorDC.Sexo == "F")
                {
                    cmbSexo.SelectedItem = "Femenino";
                }

                //Cargar combos

                var especialidades = objServiceEspecialidad.ListarEspecialidad();
                DataTable dt = ConvertToDataTable(especialidades);

                DataRow dr;

                dr = dt.NewRow();
                dr["Id_esp"] = 0;
                dr["Des_esp"] = "-Seleccione-";
                dt.Rows.InsertAt(dr, 0);
                cmbEspecialidad.DataSource = dt;
                cmbEspecialidad.DisplayMember = "Des_esp";
                cmbEspecialidad.ValueMember = "Id_esp";
                cmbEspecialidad.SelectedValue = objProfesorDC.Id_esp.ToString();

                //Ubigeo
                String Id_Ubigeo = objProfesorDC.Id_Ubigeo;
                Console.WriteLine(Id_Ubigeo.Substring(0, 2));
                Console.WriteLine(Id_Ubigeo.Substring(2, 2));
                Console.WriteLine(Id_Ubigeo.Substring(4, 2));
                CargarUbigeo(Id_Ubigeo.Substring(0, 2), Id_Ubigeo.Substring(2, 2), Id_Ubigeo.Substring(4, 2));

                //Cargar foto
                // Si no tiene foto....
                if (objProfesorDC.Foto_profe != null && objProfesorDC.Foto_profe.Length == 0)
                {
                    pctFotoProf.Image = null;
                }
                else if (objProfesorDC.Foto_profe != null)
                {
                    MemoryStream fotoStream = new MemoryStream(objProfesorDC.Foto_profe);
                    pctFotoProf.Image = Image.FromStream(fotoStream);
                    // Guardamos la foto original, por si no se hace cambios...
                    FotoOriginal = objProfesorDC.Foto_profe;
                }
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

            cmbDepartamento.DataSource = objServiceUbigeo.Ubigeo_Departamentos();
            cmbDepartamento.DisplayMember = "Departamento";
            cmbDepartamento.ValueMember = "IdDepa";
            cmbDepartamento.SelectedValue = IdDepa;


            cmbProvincia.DataSource = objServiceUbigeo.Ubigeo_ProvinciasDepartamento(IdDepa);
            cmbProvincia.DisplayMember = "Provincia";
            cmbProvincia.ValueMember = "IdProv";
            cmbProvincia.SelectedValue = IdProv;

            cmbDistrito.DataSource = objServiceUbigeo.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cmbDistrito.DisplayMember = "Distrito";
            cmbDistrito.ValueMember = "IdDis";
            cmbDistrito.SelectedValue = IdDist;

        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = String.Empty;
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();


                // Si se escogio una foto se carga en el picture Box y la variable blnCambio se pone en true
                // Esta variable permitira saber si se cambio la foto en la categoria.
                if (openFileDialog1.FileName != String.Empty)
                {
                    pctFotoProf.Image = Image.FromFile(openFileDialog1.FileName);
                    blnCambioFoto = true;
                }
                else // de lo contrario la variable blnCambio se mantiene en falso
                {
                    blnCambioFoto = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validando
                String selectedEsp = cmbEspecialidad.SelectedItem.ToString();
                String selectedSexo = cmbSexo.SelectedItem.ToString();
                String selectedState = cmbEstado.SelectedItem.ToString();

                if (selectedSexo != "Masculino" && selectedSexo != "Femenino")
                {
                    throw new Exception("Seleccione el sexo");
                }

                if (selectedEsp == "-Seleccione-")
                {
                    throw new Exception("Seleccione la especialidad");
                }

                if (selectedState != "Activo" && selectedState != "Inactivo")
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
                if (pctFotoProf.Image == null)
                {
                    throw new Exception("Si el profesor no tenia foto previamente, ahora si debe de tener, Porfavor ingrese una foto");
                }

                //Valores

                objProfesorDC.Id_profe = Convert.ToInt16(lblID.Text);

                objProfesorDC.Nom_profe = txtNombre.Text.Trim();
                objProfesorDC.Ape_profe = txtApeliido.Text.Trim();
                objProfesorDC.Dni_profe = mskDNI.Text;
                objProfesorDC.Tel_profe = mskTel.Text.Trim();
                objProfesorDC.Email_profe = txtEmail.Text.Trim();
                objProfesorDC.Id_esp = Convert.ToInt16(cmbEspecialidad.SelectedValue);

                objProfesorDC.Usu_Ult_Mod = "ADMIN";



                //Foto

                if (blnCambioFoto == true)
                {
                    objProfesorDC.Foto_profe = File.ReadAllBytes(openFileDialog1.FileName);
                }
                else  //Mantenemos la foto original
                {
                    objProfesorDC.Foto_profe = FotoOriginal;
                }


                if (selectedState == "Activo")
                {
                    objProfesorDC.Est_prof = 1;
                }
                else if (selectedState == "Inactivo")
                {
                    objProfesorDC.Est_prof = 0;
                }

                if (selectedSexo == "Masculino")
                {
                    objProfesorDC.Sexo = "M";
                }
                else if (selectedSexo == "Femenino")
                {
                    objProfesorDC.Sexo = "F";
                }

                //Combinacion de valores para el ID_UBIGEO
                objProfesorDC.Id_Ubigeo = cmbDepartamento.SelectedValue.ToString() +
                    cmbProvincia.SelectedValue.ToString() + cmbDistrito.SelectedValue.ToString();



                //Insert
                if (objServiceProfesor.ActualizarProfesor(objProfesorDC) == true)
                {
                    MessageBox.Show("Profesor " + objProfesorDC.Nom_profe + " " + objProfesorDC.Ape_profe + " actualizado correctamente", "Success", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
