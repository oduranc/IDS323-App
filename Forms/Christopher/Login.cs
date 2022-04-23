using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoFinal___IDS323L
{

    public partial class Login : Form
    {
        public string access = "";
        public string name = "";
        public string id = "";
        public string password = "";

        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            id = idTextBox.Text.ToString();
            password = passTextBox.Text.Trim();

            if (!id.Equals("") && !password.Equals(""))
            {
                try
                {
                    SqlConnection conexion = Clases.Connection.Connect();
                    conexion.Open();
                    string cadena = "select name, access from Users where id = '" + id + "' and password = '" + password + "'";
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        access = reader["access"].ToString();
                        name = reader["name"].ToString();
                        conexion.Close();

                        MessageBox.Show("Bienvenido " + name);
                        this.Hide();

                        if (access == "Administrador")
                        {
                            new Forms.Admin().Show();

                        }
                        else if (access == "Profesor")
                        {
                            new Forms.Oscar.Profile(id, password).Show();

                        }
                        else if (access == "Estudiante")
                        {
                            new Forms.Victor.Profile().Show();

                        }
                        else
                        {
                            MessageBox.Show("Error al validar el acceso del usuario. Contacte con el administrador.");
                            Application.Exit();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Datos de acceso incorrectos.");
                        idTextBox.Text = "";
                        passTextBox.Text = "";
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error en el botón Acceder de Login.");
                    MessageBox.Show("Error en la conexión. Contacte con el administrador.");
                }
            }
            else
            {
                MessageBox.Show("Debes de llenar todos los campos");
            }

        }

        private void forgotPassLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new RecoverPassword().Show();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Forms.Help().Show();
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Forms.Register().Show();
        }

        private void exitLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void idTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
