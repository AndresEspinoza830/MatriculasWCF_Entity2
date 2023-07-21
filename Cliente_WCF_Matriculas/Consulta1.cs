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
    public partial class Consulta1 : Form
    {
        ProxyConsultas.ServicioConsultasClient objProxyConsultas = new ProxyConsultas.ServicioConsultasClient();

        public Consulta1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtIdAlumno.Text.Trim() != "")
            {
                try
                {
                    dtgResultados.DataSource = objProxyConsultas.ListarCuotasPendientesAlumnos(Convert.ToInt32(txtIdAlumno.Text.Trim()));

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error:" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Error: El campo no puede ser vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Consulta1_Load(object sender, EventArgs e)
        {
            dtgResultados.AutoGenerateColumns = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
