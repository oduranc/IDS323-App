using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal___IDS323L.Forms.Victor
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            firstQuestionLabel.Text = "1. ¿Qué hago en caso de que no aparezcan\nmis materias?";
            firstAnswerLabel.Text = "Notifica a tu profesor a través de las vías de\ncomunicación estudiantil.";
            secondQuestionLabel.Text = "2. No tengo calificación.";
            secondAnswerLabel.Text = "Comunícate con el profesor de la asignatura\npara que rectifique en el sistema.";
            thirdQuestionLabel.Text = "3. No estoy en el Ranking";
            thirdAnswerLabel.Text = "Contacta al centro para atender la\nsituación.";
        }
    }
}
