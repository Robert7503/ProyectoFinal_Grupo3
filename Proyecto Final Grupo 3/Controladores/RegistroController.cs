using Proyecto_Final_Grupo_3.Entidades;
using Proyecto_Final_Grupo_3.Modelos;
using Proyecto_Final_Grupo_3.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Grupo_3.Controladores
{
    public class RegistroController
    {
        RegistroView vista;
        ExpedientesDAO expidienteDAO = new ExpedientesDAO();
        Registro zx = new Registro();
        string operacion = string.Empty;

        public RegistroController(RegistroView view)
        {
            vista = view;
            vista.btnRegistro.Click += BtnRegistro_Click;

        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            zx.NOMBRE = vista.txtNombreTextBox.Text;
            zx.APELIDO = vista.txtApellidoTextBox3.Text;
            zx.CELULAR = Convert.ToInt32(vista.txtNumCelularTextBox4);
            zx.DIRECCION = vista.txtDireccionTextBox5.Text;
            zx.EDAD = Convert.ToInt32(vista.txtEdadTextBox);
            zx.SEXO = vista.txtEdadTextBox.Text;

        }         
    }
}
