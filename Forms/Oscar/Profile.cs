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
    public partial class Profile : Form
    {
        public string identification;
        public string pass;
        public Profile(string id, string password)
        {
            InitializeComponent();
            identification = id;
            pass = password;

            try
            {
                SqlConnection conexion = Clases.Connection.Connect();
                conexion.Open();
                string cadena = "select name, id from Users where id = '" + id + "' and password = '" + password + "'";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    nameLabel.Text = reader["name"].ToString();
                    idLabel.Text = reader["id"].ToString();
                    conexion.Close();
                    nameLabel.Visible = true;
                    idLabel.Visible = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la carga de Profile.");
                MessageBox.Show("Error en la conexión. Contacte con el administrador. " + e);
            }
        }

        private void changePassButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePassword(identification, pass).Show();
        }

        private void logOutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Forms.Oscar.Help(identification, pass).Show();
        }

        private void gradesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Forms.Oscar.Subjects(identification, pass).Show();
        }
    }
}
