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
    public partial class Consulta3 : Form
    {
        ProxyConsultas.ServicioConsultasClient objProxyConsultas = new ProxyConsultas.ServicioConsultasClient();

        public Consulta3()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtVacantes.Text.Trim() != "")
            {
                try
                {
                    dtgResultados.DataSource = objProxyConsultas.ListarBloquesVacantes(Convert.ToInt16(txtVacantes.Text.Trim()));

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

        private void Consulta3_Load(object sender, EventArgs e)
        {
            dtgResultados.AutoGenerateColumns = false;
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
