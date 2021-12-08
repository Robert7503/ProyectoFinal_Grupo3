using Proyecto_Final_Grupo_3.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Grupo_3.Vistas
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
            LoginController controlador = new LoginController(this);
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {

        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void NombretextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContraseñaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalirButton_Click(object sender, EventArgs e)
        {

        }
    }
}
