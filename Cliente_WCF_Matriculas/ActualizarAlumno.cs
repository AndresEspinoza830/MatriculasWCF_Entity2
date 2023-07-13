
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
    public partial class ActualizarAlumno : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();

        ProxyAlumno.ServicioAlumnoClient objServiceAlumno = new ProxyAlumno.ServicioAlumnoClient();
        ProxyAlumno.AlumnoDC objAlumnoDC = new ProxyAlumno.AlumnoDC();
        proxyUbigeo.ServicioUbigeoClient objServiceUbigeo = new proxyUbigeo.ServicioUbigeoClient();

        Byte[] FotoOriginal;

        String actualIdUbigeo = "";
        Boolean isActualPhotoChanged = false;


        private Int16 _IdAlumno;
        public Int16 IdAlumno
        {
            get { return _IdAlumno; }
            set { _IdAlumno = value; }

        }

        public ActualizarAlumno()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarAlumno_Load(object sender, EventArgs e)
        {

            ProxyAlumno.AlumnoDC objAlumno = objServiceAlumno.ConsultarAlumno(IdAlumno);
            txtNombre.Text = objAlumno.Nom_alum;
            if (objAlumno.Sexo == "F")
            {
                cmbSexo.SelectedItem = "Femenino";
            }
            else
            {
                cmbSexo.SelectedItem = "Masculino";
            }
            lblID.Text = objAlumno.Id_alum.ToString();
            txtApellido.Text = objAlumno.Ape_Alum;
            txtDireccion.Text = objAlumno.Dir_alum;
            mskDNI.Text = objAlumno.Dni_alum;
            mskTelefono.Text = objAlumno.Tel_alum;
            txtEmail.Text = objAlumno.Email_alum;
            dtpNacimiento.Text = Convert.ToDateTime(objAlumno.Fec_nac).ToString();

            String Id_Ubigeo = objAlumno.Id_Ubigeo;
            CargarUbigeo(Id_Ubigeo.Substring(0, 2), Id_Ubigeo.Substring(2, 2), Id_Ubigeo.Substring(4, 2));


            if (objAlumno.Est_alum == 1)
            {
                cmbEstado.SelectedItem = "Activo";
            }
            else
            {
                cmbEstado.SelectedItem = "Inactivo";
            }

            if (objAlumno.Foto_alum != null)
            {
                MemoryStream fotoStream = new MemoryStream(objAlumno.Foto_alum);
                pctFoto.Image = Image.FromStream(fotoStream);

                FotoOriginal = objAlumno.Foto_alum;
            }
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


        private void btnActualizarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                String selectedState = cmbEstado.SelectedItem.ToString();
                String selectedSexo = cmbSexo.SelectedItem.ToString();


                if (selectedState == "-Seleccione-")
                {
                    throw new Exception("Seleccione el estado");
                }
                if (selectedSexo == "-Seleccione-")
                {
                    throw new Exception("Seleccione el sexo");
                }
                if (txtNombre.Text.Trim() == "" | txtApellido.Text.Trim() == "" | mskDNI.MaskFull != true | mskTelefono.MaskFull != true | txtEmail.Text.Trim() == "" | dtpNacimiento.Text.Trim() == "" | txtDireccion.Text.Trim() == "")
                {
                    throw new Exception("Todos los campos son obligatorios");
                }

                if (pctFoto.Image == null)
                {
                    throw new Exception("Si el alumno no tenia foto previamente, ahora si debe de tener, Porfavor ingrese una foto");
                }

                ProxyAlumno.AlumnoDC objAlumnoDC = new ProxyAlumno.AlumnoDC();
                objAlumnoDC.Id_alum = IdAlumno;
                objAlumnoDC.Nom_alum = txtNombre.Text;
                objAlumnoDC.Ape_Alum = txtApellido.Text;
                objAlumnoDC.Dni_alum = mskDNI.Text;
                objAlumnoDC.Email_alum = txtEmail.Text;
                objAlumnoDC.Dir_alum = txtDireccion.Text;
                objAlumnoDC.Tel_alum = mskTelefono.Text;
                if (selectedState == "Inactivo")
                {
                    objAlumnoDC.Est_alum = 0;
                }
                else
                {
                    objAlumnoDC.Est_alum = 1;
                }

                if (selectedSexo == "Masculino")
                {
                    objAlumnoDC.Sexo = "M";
                }
                else
                {
                    objAlumnoDC.Sexo = "F";
                }

                objAlumnoDC.Id_Ubigeo = cmbDepartamento.SelectedValue.ToString() +
                                    cmbProvincia.SelectedValue.ToString() + cmbDist.SelectedValue.ToString();

                if (openFileDialog.FileName.Length > 0)
                {
                    objAlumnoDC.Foto_alum = File.ReadAllBytes(openFileDialog.FileName);
                }
                else
                {
                    objAlumnoDC.Foto_alum = FotoOriginal;
                }
                objAlumnoDC.Usu_Ult_Mod = "ADMIN";
                objAlumnoDC.Fec_nac = Convert.ToDateTime(dtpNacimiento.Text);


                if (objServiceAlumno.ActualizarAlumno(objAlumnoDC))
                {
                    MessageBox.Show("Alumno " + objAlumnoDC.Nom_alum + " " + objAlumnoDC.Ape_Alum + " actualizado correctamente", "Success", MessageBoxButtons.OK);
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
            try
            {
                openFileDialog.FileName = String.Empty;
                openFileDialog.Multiselect = false;
                openFileDialog.ShowDialog();

                if (openFileDialog.FileName != String.Empty)
                {
                    pctFoto.Image = Image.FromFile(openFileDialog.FileName);
                    isActualPhotoChanged = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
