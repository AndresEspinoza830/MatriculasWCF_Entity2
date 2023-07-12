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
    }
}
