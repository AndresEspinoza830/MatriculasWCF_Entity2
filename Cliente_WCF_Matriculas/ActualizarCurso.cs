﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_WCF_Matriculas
{
    public partial class ActualizarCurso : Form
    {
        ProxyCurso.ServicioCursoClient courseService = new ProxyCurso.ServicioCursoClient();
        ProxyCurso.CursoDC objCursoDC = new ProxyCurso.CursoDC();

        private Int16 _IdCurso;
        public Int16 IdCurso
        {
            get { return _IdCurso; }
            set { _IdCurso = value; }

        }
        public ActualizarCurso()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescCurso.Text.Trim().Length == 0)
                {
                    throw new Exception("Escriba un nombre de curso");
                }
                ProxyCurso.CursoDC course = new ProxyCurso.CursoDC();

                course.Id_curso = IdCurso;
                course.Est_curso = 1;
                course.Des_curso = txtDescCurso.Text;
                course.Usu_Ult_Mod = "ADMIN";
                course.Fec_Ult_Mod = DateTime.Now;

                String selectedState = cmbEstado.SelectedItem.ToString();
                if (selectedState == "Inactivo")
                {
                    course.Est_curso = 0;
                }
                else
                {
                    course.Est_curso = 1;
                }

                if (courseService.ActualizarCurso(course))
                {
                    MessageBox.Show("Curso actualizado correctamente", "Success", MessageBoxButtons.OK);
                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarCurso_Load(object sender, EventArgs e)
        {
            ProxyCurso.CursoDC objCurso = courseService.ConsultarCurso(IdCurso);
            lblID.Text =Convert.ToString(IdCurso);
            if (objCurso.Est_curso == 1)
            {
                cmbEstado.SelectedItem = "Activo";
            }
            else
            {
                cmbEstado.SelectedItem = "Inactivo";
            }
            txtDescCurso.Text = objCurso.Des_curso;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
