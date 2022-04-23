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
    public partial class Subjects : Form
    {
        public string id;
        public string password;
        public Subjects(string identification, string pass)
        {
            InitializeComponent();
            id = identification;
            password = pass;

            try
            {
                SqlConnection conexion = Clases.Connection.Connect();
                conexion.Open();
                string cadena = "select section, name from Subjects where idTeacher = '" + id + "'";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                string a = "";
                string b = "";

                while (reader.Read())
                {
                    int n = dtgvMaterias.Rows.Add();

                    if (a == reader.GetValue(reader.GetOrdinal("section")).ToString() && b == reader.GetValue(reader.GetOrdinal("name")).ToString())
                    {
                        dtgvMaterias.Rows.Remove(dtgvMaterias.Rows[n]);
                        continue;
                    }

                    dtgvMaterias.Rows[n].Cells["seccionColumn"].Value = reader.GetValue(reader.GetOrdinal("section")).ToString();
                    a = dtgvMaterias.Rows[n].Cells["seccionColumn"].Value.ToString();
                    dtgvMaterias.Rows[n].Cells["nameColumn"].Value = reader.GetValue(reader.GetOrdinal("name")).ToString();
                    b = dtgvMaterias.Rows[n].Cells["nameColumn"].Value.ToString();
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el llenado de la tabla.");
                MessageBox.Show("Error en el llenado de la tabla. Contacte con el administrador. " + e);
            }
        }

        private void myProfileLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Forms.Oscar.Profile(id, password).Show();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Forms.Oscar.Help(id, password).Show();
        }

        private void dtgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string nameSubject = senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                string sectionSubject = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

                this.Hide();
                new Forms.Oscar.Grades(id, password, nameSubject, sectionSubject).Show();
            }
        }
    }
}
