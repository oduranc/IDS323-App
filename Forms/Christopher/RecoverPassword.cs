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
    public partial class RecoverPassword : Form
    {
        public string id = "";
        public string email = "";
        public string name = "";
        private string password = "";

        public RecoverPassword()
        {
            InitializeComponent();
        }

        private void backLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
        private void helpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Forms.Help().Show();
        }
        private void recoverButton_Click(object sender, EventArgs e)
        {
            id = idTextBox.Text.ToString();
            email = emailTextBox.Text.ToString();

            if (!id.Equals("") && !email.Equals(""))
            {
                try
                {
                    SqlConnection conexion = Clases.Connection.Connect();
                    conexion.Open();
                    string cadena = "select name, password from Users where id = '" + id + "' and email = '" + email + "'";
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        name = reader["name"].ToString();
                        password = reader["password"].ToString();
                        conexion.Close();

                        MessageBox.Show($"Saludos, {name}. El email y el ID ingresados coinciden con los de su registro. Su contraseña es {password}. Por favor no la vuelva a perder.");
                    }
                    else
                    {
                        MessageBox.Show("El ID o correo electrónico ingresados no coinciden con los de su registro. Si no se trata de su cuenta, por favor no intente acceder a la de otro.");
                        idTextBox.Text = "";
                        emailTextBox.Text = "";
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error en el botón de Recuperar Contraseña.");
                    MessageBox.Show("Error en la conexión. Contacte con el administrador.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, llena todos los campos con los datos ingresados en el momento de registro.");
            }
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
