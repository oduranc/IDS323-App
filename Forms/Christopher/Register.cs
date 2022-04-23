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

namespace ProyectoFinal___IDS323L.Forms
{
    public partial class Register : Form
    {
        string name = "";
        string access = "";
        string career = "";
        string email = "";
        string password = "";
        int id;
        public Register()
        {
            InitializeComponent();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Help().Show();
        }

        private void backLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            int validation = 0;

            name = nameTextBox.Text.ToString().Trim();
            if (accessComboBox.SelectedItem == null)
            {
                access = "";
            }
            else
            {
                access = accessComboBox.SelectedItem.ToString();
            }
            if (careerComboBox.SelectedItem == null)
            {
                career = "";
            }
            else
            {
                career = careerComboBox.SelectedItem.ToString();
            }
            email = emailTextBox.Text.ToString().Trim();
            password = passwordTextBox1.Text.ToString().Trim();
            if (passwordTextBox1.Text == passwordTextBox2.Text && passwordTextBox1.Text != "" && passwordTextBox2.Text != "")
            {
                password = passwordTextBox1.Text.ToString().Trim();
            }
            else
            {
                validation++;
            }

            if (name == "")
            {
                validation++;
            }
            if (access == "")
            {
                validation++;
            }
            if (access == "Estudiante" && career == "")
            {
                validation++;
            }
            if (email == "")
            {
                validation++;
            }
            try
            {
                SqlConnection conexion = Clases.Connection.Connect();
                conexion.Open();
                string cadena = "select email from Users where email = '" + email + "'";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("El correo electrónico ya está en uso.");
                    conexion.Close();
                } else
                {
                    conexion.Close();

                    if (validation == 0)
                    {
                        try
                        {
                            SqlConnection conexion1 = Clases.Connection.Connect();
                            conexion1.Open();
                            string cadena1 = "insert into users values (@param1,@param2,@param3,@param4,@param5)";
                            SqlCommand comando1 = new SqlCommand(cadena1, conexion1);

                            comando1.Parameters.AddWithValue("@param1", password);
                            comando1.Parameters.AddWithValue("@param2", name);
                            comando1.Parameters.AddWithValue("@param3", access);
                            comando1.Parameters.AddWithValue("@param4", career);
                            comando1.Parameters.AddWithValue("@param5", email);

                            comando1.ExecuteNonQuery();
                            conexion1.Close();

                            SqlConnection conexion2 = Clases.Connection.Connect();
                            conexion2.Open();
                            string cadena2 = "select id from users where email = '" + email + "'";
                            SqlCommand comando2 = new SqlCommand(cadena2, conexion2);
                            SqlDataReader reader2 = comando2.ExecuteReader();

                            if (reader2.Read())
                            {
                                id = Int32.Parse(reader2["id"].ToString());
                                MessageBox.Show("Se ha registrado exitosamente. Su id es " + id);

                                this.Hide();
                                new Login().Show();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error al registrarse.");
                            MessageBox.Show("Error al registrarse. Contacte con el administrador. " + ex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe llenar todos los campos correctamente.");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error al conectarse.");
                MessageBox.Show("Error al conectarse con la base de datos. Contacte con el administrador.");
            }
        }
        private void passwordTextBox2_TextChanged(object sender, EventArgs e)
        {
            AreTheyEqual();
        }

        private void passwordTextBox1_TextChanged(object sender, EventArgs e)
        {
            AreTheyEqual();
        }

        private void accessComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accessComboBox.SelectedItem.Equals("Estudiante"))
            {
                careerLabel.Enabled = true;
                careerComboBox.Enabled = true;
            }
            else
            {
                careerComboBox.SelectedItem = "";
                careerLabel.Enabled = false;
                careerComboBox.Enabled = false;
            }
        }

        public void AreTheyEqual()
        {
            if (passwordTextBox1.Text != "" && passwordTextBox2.Text != "")
            {
                if (passwordTextBox1.Text == passwordTextBox2.Text)
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

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
