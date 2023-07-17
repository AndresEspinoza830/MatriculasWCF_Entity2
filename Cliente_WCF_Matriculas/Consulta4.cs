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
    public partial class Consulta4 : Form
    {
        ProxyConsultas.ServicioConsultasClient objProxyConsultas = new ProxyConsultas.ServicioConsultasClient();
        ProxyCarrera.ServicioCarreraClient objProxyCarrera = new ProxyCarrera.ServicioCarreraClient();

        public Consulta4()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbCarrera.Text != "-Seleccione-")
            {
                try
                {
                    List<ProxyConsultas.MatriculadoDC> alumnos = objProxyConsultas.ListarAlumnosCarrera(Convert.ToInt16(cmbCarrera.SelectedValue)).ToList();
                    dtgResultados.DataSource = alumnos;

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error:" + ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Error: El campo no puede ser vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Consulta4_Load(object sender, EventArgs e)
        {
            dtgResultados.AutoGenerateColumns = false;
            var carreras = objProxyCarrera.ListarCarrera();

            cmbCarrera.DataSource = carreras;
            cmbCarrera.ValueMember = "Id_carrera";
            cmbCarrera.DisplayMember = "Nom_carrera";

            cmbCarrera.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtVacantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
