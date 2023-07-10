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
    public partial class ProfesorMan01 : Form
    {
        ProxyProfesor.ServicioProfesorClient objServiceProfesor = new ProxyProfesor.ServicioProfesorClient();
        public ProfesorMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {

            dtgProfe.DataSource = objServiceProfesor.ListarProfesores();
            lblRegistros.Text = dtgProfe.Rows.Count.ToString();
            
        }

        private void ProfesorMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgProfe.AutoGenerateColumns = false;
                CargarDatos("");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ProfesorMan02 profesorMan02 = new ProfesorMan02();
                profesorMan02.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
