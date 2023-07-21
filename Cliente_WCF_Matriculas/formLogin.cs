using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_WCF_Matriculas
{
    public partial class formLogin : Form
    {
        ProxyUsuario.ServicioUsuarioClient objServiceUsuario = new ProxyUsuario.ServicioUsuarioClient();
        Int16 intentos = 0;
        Int16 tiempo = 50;
        // Declaramos instancias para autenficacion de Usuarios....

        public formLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() != "" & txtPassword.Text.Trim() != "")
            {
                Boolean Respuesta;
                Respuesta = objServiceUsuario.ConsultarUsuario(txtLogin.Text.Trim(), txtPassword.Text.Trim());

                //Si el Login no existe
                if (!Respuesta)
                {
                    MessageBox.Show("Usuario no existe, o datos incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidaAccesos();
                }
                else
                {
                    this.Hide();
                    timer1.Enabled = false;
                    MDIInterface mainView = new MDIInterface();
                    mainView.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario o Password obligatorios",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
                ValidaAccesos();
            }

        }

        private void ValidaAccesos()
        {
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void formLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }

        private void formLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo -= 1;
            this.Text = "Ingrese su login y contraseña. Le quedan...." + tiempo;
            if (tiempo == 0)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera aceptado",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}
