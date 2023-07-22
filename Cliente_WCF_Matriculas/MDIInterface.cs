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
    public partial class MDIInterface : Form
    {
        public MDIInterface()
        {
            InitializeComponent();

        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnoMan alumView = new AlumnoMan();
            alumView.MdiParent = this;
            alumView.Show();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfesorMan01 profesorView = new ProfesorMan01();
            profesorView.MdiParent = this;
            profesorView.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CursoMan cursoView = new CursoMan();
            cursoView.MdiParent = this;
            cursoView.Show();
        }

        private void listarCuotasPendientesAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta1 consulta1 = new Consulta1();
            consulta1.MdiParent = this;
            consulta1.Show();
        }

        private void listarMatriculadosFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta2 consulta2 = new Consulta2();
            consulta2.MdiParent = this;
            consulta2.Show();
        }

        private void listarVacantesBloquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta3 consulta3 = new Consulta3();
            consulta3.MdiParent = this;
            consulta3.Show();
        }

        private void listarAlumnosCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta4 consulta4 = new Consulta4();
            consulta4.MdiParent = this;
            consulta4.Show();
        }
    }
}
