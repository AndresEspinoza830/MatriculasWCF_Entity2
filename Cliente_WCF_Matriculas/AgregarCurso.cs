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
	public partial class AgregarCurso : Form
	{

		ProxyCurso.ServicioCursoClient courseService = new ProxyCurso.ServicioCursoClient();

		public AgregarCurso()
		{
			InitializeComponent();
		}

		private void txtDescCurso_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{

			try {
				if (txtDescCurso.Text.Trim().Length == 0) {
					throw new Exception("Escriba un nombre de curso");
				}
				ProxyCurso.CursoDC course = new ProxyCurso.CursoDC();

				course.Est_curso = 1;
				course.Des_curso = txtDescCurso.Text;
				course.Usu_Registro = "ADMIN";
				course.Fec_reg = DateTime.Now;

				if (courseService.InsertarCurso(course)) {

					MessageBox.Show("Curso agregado correctamente", "Success", MessageBoxButtons.OK);
					this.Close();
				}

			} catch(Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
