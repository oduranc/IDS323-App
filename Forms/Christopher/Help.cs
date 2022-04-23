using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal___IDS323L.Forms
{
    public partial class Help : Form
    {

        public Help()
        {
            InitializeComponent();

            firstQuestionLabel.Text = "1. ¿Qué hago cuando mi\ncontraseña no es válida?";
            firstAnswerLabel.Text = "Confirma que la misma cumpla con\nlas indicaciones del sistema, como\nque sea mayor o igual a ocho\ndígitos.";
            secondQuestionLabel.Text = "2. ¿Qué pasa si no me llega el\ncorreo para recuperar contraseña?";
            secondAnswerLabel.Text = "Comunícate a través de nuestras\nvías de contacto y te ayudaremos\nen tu caso.";
        }

        private void backLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void emailLabel2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(emailLabel2.Text.ToString());
            MessageBox.Show("Email copiado al portapapeles.");
        }
    }
}
