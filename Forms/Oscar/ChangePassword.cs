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

namespace ProyectoFinal___IDS323L.Forms.Oscar
{
    public partial class ChangePassword : Form
    {
        public string newPassword;
        public string id;
        public ChangePassword(string identification, string pass)
        {
            InitializeComponent();
            id = identification;
            newPassword = pass;
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            AreTheyEqual();
        }

        private void passTextBox2_TextChanged(object sender, EventArgs e)
        {
            AreTheyEqual();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int validation = 0;

            if (passTextBox1.Text == passTextBox2.Text && passTextBox1.Text != "" && passTextBox2.Text != "")
            {
                newPassword = passTextBox1.Text.ToString().Trim();
            }
            else
            {
                validation++;
            }
            if (validation == 0)
            {
                try
                {
                    SqlConnection conexion = Clases.Connection.Connect();
                    conexion.Open();
                    string cadena = "update Users set password = @newPassword where id = '" + id + "'";
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.Parameters.AddWithValue("@newPassword", newPassword);
                    comando.ExecuteNonQuery();

                    conexion.Close();

                    MessageBox.Show("Cambio realizado con éxito.");
                    passTextBox1.Text = "";
                    passTextBox2.Text = "";
                    this.Hide();
                    new Profile(id, newPassword).Show();
                }
                catch (Exception)
                {
                    Console.WriteLine("Error al cambiar la contraseña.");
                    MessageBox.Show("Error al cambiar la contraseña. Contacte con el administrador.");
                }
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos correctamente.");
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Profile(id, newPassword).Show();
        }
        private void helpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Forms.Oscar.Help(id, newPassword).Show();
        }
        public void AreTheyEqual()
        {
            if (passTextBox1.Text != "" && passTextBox2.Text != "")
            {
                if (passTextBox1.Text == passTextBox2.Text)
                {
                    correctPassPicture.Visible = true;
                    wrongPassPicture.Visible = false;
                    confirmationLabel.Visible = false;
                }
                else
                {
                    correctPassPicture.Visible = false;
                    wrongPassPicture.Visible = true;
                    confirmationLabel.Visible = true;
                }
            }
            else
            {
                correctPassPicture.Visible = false;
                wrongPassPicture.Visible = false;
                confirmationLabel.Visible = false;
            }
        }
    }
}
