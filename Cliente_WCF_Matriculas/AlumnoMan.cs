
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
    public partial class AlumnoMan : Form
    {
        ProxyAlumno.ServicioAlumnoClient objServiceAlumno = new ProxyAlumno.ServicioAlumnoClient();
        DataView dtv;

        public AlumnoMan()
        {
            InitializeComponent();
        }
        public void obtenerAlumnos(String query)
        {
            List<ProxyAlumno.AlumnoDC> alumnos = objServiceAlumno.ListarAlumnos().ToList();

            alumnos = alumnos.Where(a => a.Nom_alum.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            //DataTable table = new DataTable();
            //dtv = new DataView(objServiceAlumno.ListarAlumnos());


            dtgAlumno.DataSource = alumnos;
            lblRegistros.Text = dtgAlumno.Rows.Count.ToString();

        }

        private void AlumnoMan_Load(object sender, EventArgs e)
        {
            dtgAlumno.AutoGenerateColumns = false;
            obtenerAlumnos("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarAlumno matricularModal = new AgregarAlumno();
            matricularModal.ShowDialog();
            obtenerAlumnos("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActualizarAlumno actualizarModal = new ActualizarAlumno();
            if (dtgAlumno.CurrentRow != null)
                actualizarModal.IdAlumno = Convert.ToInt16(dtgAlumno.CurrentRow.Cells[0].Value);
            actualizarModal.ShowDialog();
            obtenerAlumnos("");
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            obtenerAlumnos(txtFiltro.Text);
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (objServiceAlumno.EliminarAlumno(Convert.ToInt16(dtgAlumno.CurrentRow.Cells[0].Value)))
            {
                MessageBox.Show("Alumno eliminado correctamente");
                obtenerAlumnos("");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
