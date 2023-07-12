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
    public partial class ProfesorMan01 : Form
    {
        ProxyProfesor.ServicioProfesorClient objServiceProfesor = new ProxyProfesor.ServicioProfesorClient();
        DataTable dtProfesores;
        DataView dtv;
        public ProfesorMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos(string strFiltro)
        {
           
            dtProfesores = ConvertToDataTable(objServiceProfesor.ListarProfesores());
            dtv = new DataView(dtProfesores);
            dtv.RowFilter = "Ape_profe like '%" + strFiltro + "%'";
            dtgProfe.DataSource = dtv;
            lblRegistros.Text = dtgProfe.Rows.Count.ToString();
        }

        private DataTable ConvertToDataTable<T>(IEnumerable<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }

            return table;
        }

        private void ProfesorMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgProfe.AutoGenerateColumns = false;
                CargarDatos("");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ProfesorMan02 agregarAlumno = new ProfesorMan02();
                agregarAlumno.ShowDialog();
                CargarDatos("");
                //    dtProfesores = ConvertToDataTable(objServiceProfesor.ListarProfesores());
                // dtv = new DataView(dtProfesores);
                // CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex )
            {

                MessageBox.Show("Error: " + ex.Message); 
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ProfesorMan03 profesorMan03 = new ProfesorMan03();
            profesorMan03.ID = Convert.ToInt16(dtgProfe.CurrentRow.Cells[0].Value);
            profesorMan03.ShowDialog();
            CargarDatos("");
        }
    }
}
