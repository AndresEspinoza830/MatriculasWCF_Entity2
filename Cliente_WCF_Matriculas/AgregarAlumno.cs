
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_WCF_Matriculas
{
    public partial class AgregarAlumno : Form
    {
        ProxyAlumno.ServicioAlumnoClient objServiceAlumno = new ProxyAlumno.ServicioAlumnoClient();
        ProxyAlumno.AlumnoDCINSERTS objAlumnoDC = new ProxyAlumno.AlumnoDCINSERTS();
        proxyUbigeo.ServicioUbigeoClient objServiceUbigeo = new proxyUbigeo.ServicioUbigeoClient();


        String actualIdUbigeo = "";

        OpenFileDialog openFileDialog = new OpenFileDialog();
        public AgregarAlumno()
        {
            InitializeComponent();
        }

        private void MatricularAlumno_Load(object sender, EventArgs e)
        {

            cmbSexo.SelectedItem = "-Seleccione-";
            cmbEstado.SelectedItem = "-Seleccione-";

            CargarUbigeo("14", "01", "01");

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

            cmbDist.DataSource = objServiceUbigeo.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cmbDist.DisplayMember = "Distrito";
            cmbDist.ValueMember = "IdDis";
            cmbDist.SelectedValue = IdDist;


        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            try
            {
                String selectedSexo = cmbSexo.SelectedItem.ToString();
                String selectedState = cmbEstado.SelectedItem.ToString();

                if (txtNombre.Text.Trim() == "" | txtApellido.Text.Trim() == "" | mskDNI.MaskFull != true | mskTelefono.MaskFull != true | txtEmail.Text.Trim() == "" | dtpFechaNacimiento.Text.Trim() == "" | selectedSexo == "-Seleccione-" | selectedState == "-Seleccione-" | txtDireccion.Text.Trim() == "")
                {
                    throw new Exception("Todos los campos son obligatorios");
                }
                //if (cmbDist.SelectedIndex == 0 | cmbProvincia.SelectedIndex == 0 | cmbDepartamento.SelectedIndex == 0)
                //{
                //    throw new Exception("Debe seleccionar el ubigeo");
                //}
                //if (pctbFoto.Image == null)
                //{
                //    throw new Exception("Una foto es necesaria");
                //}


                objAlumnoDC.Nom_alum = txtNombre.Text;
                objAlumnoDC.Ape_Alum = txtApellido.Text;
                objAlumnoDC.Dni_alum = mskDNI.Text;
                objAlumnoDC.Email_alum = txtEmail.Text;
                objAlumnoDC.Dir_alum = txtDireccion.Text;
                objAlumnoDC.Tel_alum = mskTelefono.Text;
                objAlumnoDC.Est_alum = 1;
                if (selectedSexo == "Masculino")
                {
                    objAlumnoDC.Sexo = "M";
                }
                else
                {
                    objAlumnoDC.Sexo = "F";
                }
                if (selectedState == "Inactivo")
                {
                    objAlumnoDC.Est_alum = 0;
                }
                else
                {
                    objAlumnoDC.Est_alum = 1;
                }

                //Ubigeo

                objAlumnoDC.Id_Ubigeo = cmbDepartamento.SelectedValue.ToString() +
                    cmbProvincia.SelectedValue.ToString() + cmbDist.SelectedValue.ToString();

                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(basePath, @"..\..\Img\defaultUser.jpeg");



                if (openFileDialog.FileName.Length > 0)
                {
                    objAlumnoDC.Foto_alum = File.ReadAllBytes(openFileDialog.FileName);
                }
                else
                {
                    objAlumnoDC.Foto_alum = File.ReadAllBytes(filePath);
                }


                objAlumnoDC.Usu_Registro = "ADMIN";
                objAlumnoDC.Fec_nac = Convert.ToDateTime(dtpFechaNacimiento.Text);


                if (objServiceAlumno.InsertarAlumno(objAlumnoDC))
                {
                    MessageBox.Show("Alumno " + objAlumnoDC.Nom_alum + " " + objAlumnoDC.Ape_Alum + " agregado correctamente", "Success", MessageBoxButtons.OK);
                    this.Close();

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
            openFileDialog.FileName = String.Empty;
            openFileDialog.Multiselect = false;
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != String.Empty)
            {
                pctbFoto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
