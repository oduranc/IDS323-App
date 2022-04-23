using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal___IDS323L.Forms.Oscar
{
    public partial class Help : Form
    {
        public string identification;
        public string pass;
        public Help(string id, string password)
        {
            InitializeComponent();
            identification = id;
            pass = password;
            firstQuestionLabel.Text = "1. ¿Cómo agregar calificaciones?";
            firstAnswerLabel.Text = "   a) Busque la sección. Dentro de la\n         sección busque al estudiante.\n   b) En la parte derecha de la \n         información del estudiante verá un\n         cuadro de texto.";
            secondQuestionLabel.Text = "2. ¿Qué hacer si no encuentro una\nsección?";
            secondAnswerLabel.Text = "   a) Verifica que no haya puesto nada en\n         la barra de buscar. Coloque el orden\n         de la tabla en orden alfabético.\n   b) Busque la asignatura y sección que\n         desea.\n   c) De no encontrar la sección,\n         comuníquese con soporte.";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Profile(identification, pass).Show();
        }
    }
}
