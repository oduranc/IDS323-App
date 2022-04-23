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
    public partial class Grades : Form
    {
        public string id;
        public string password;
        public string nameSubject;
        public string sectionSubject;
        public Grades(string identification, string pass, string name, string section)
        {
            InitializeComponent();
            id = identification;
            password = pass;
            nameSubject = name;
            sectionSubject = section;

            try
            {
                SqlConnection conexion = Clases.Connection.Connect();
                conexion.Open();
                string cadena = "select idStudent, grade, code from Subjects where name = '" + nameSubject + "' and section = '" + sectionSubject + "'";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    titleLabel.Text = reader.GetValue(reader.GetOrdinal("code")).ToString();

                    SqlConnection conexion2 = Clases.Connection.Connect();
                    conexion2.Open();
                    string cadena2 = "select name, career from Users where id = '" + reader.GetValue(reader.GetOrdinal("idStudent")).ToString() + "'";
                    SqlCommand comando2 = new SqlCommand(cadena2, conexion2);
                    SqlDataReader reader2 = comando2.ExecuteReader();

                    while (reader2.Read())
                    {
                        int n = dtgvStudents.Rows.Add();
                        dtgvStudents.Rows[n].Cells["idColumn"].Value = reader.GetValue(reader.GetOrdinal("idStudent")).ToString();
                        dtgvStudents.Rows[n].Cells["nameColumn"].Value = reader2.GetValue(reader2.GetOrdinal("name")).ToString();
                        dtgvStudents.Rows[n].Cells["careerColumn"].Value = reader2.GetValue(reader2.GetOrdinal("career")).ToString();
                        dtgvStudents.Rows[n].Cells["gradeColumn"].Value = reader.GetValue(reader.GetOrdinal("grade")).ToString();
                    }
                    conexion2.Close();
                }
                conexion.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Error en el llenado de la tabla.");
                MessageBox.Show("Error en el llenado de la tabla. Contacte con el administrador.");
            }
        }

        private void backLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Forms.Oscar.Subjects(id, password).Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha actualizado correctamente.");
            this.Hide();
            new Forms.Oscar.Subjects(id, password).Show();
        }
    }
}
