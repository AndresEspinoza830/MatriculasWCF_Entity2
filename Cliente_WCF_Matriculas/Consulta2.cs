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
    public partial class Consulta2 : Form
    {
        ProxyConsultas.ServicioConsultasClient objProxyConsultas = new ProxyConsultas.ServicioConsultasClient();
        public Consulta2()
        {
            InitializeComponent();
        }

        private void Consulta2_Load(object sender, EventArgs e)
        {
            dtgResultados.AutoGenerateColumns = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                dtgResultados.DataSource = objProxyConsultas.ListarMatriculadosFechas(dtpFecInicio.Value.Date, dtpFecFin.Value.Date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
