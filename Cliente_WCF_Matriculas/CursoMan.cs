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

	public partial class CursoMan : Form
	{

		ProxyCurso.ServicioCursoClient courseService = new ProxyCurso.ServicioCursoClient();
	
		public CursoMan()
		{
			InitializeComponent();
		}

		public void getCourses(String q) {
			List<ProxyCurso.CursoDC> courses = courseService.ListarCursos().ToList();

			courses = courses.Where(c => c.Des_curso.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0).ToList();


			dtgCourses.DataSource = courses;
			lblTotal.Text = courses.Count.ToString();
		}

		private void CursoMan_Load(object sender, EventArgs e)
		{
			dtgCourses.AutoGenerateColumns = false;
			getCourses("");
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			String query = txtDescCourse.Text;
			getCourses(query);
		}

		private void btnOpenAddCourse_Click(object sender, EventArgs e)
		{
			AgregarCurso addCourseModal = new AgregarCurso();
			addCourseModal.ShowDialog();
			getCourses("");
		}
	}
}
