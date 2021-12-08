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
    public class DetallesController
    {
        RegistroView vista;
        ExpedientesDAO expidienteDAO = new ExpedientesDAO();
        Registro movimento = new Registro();
        string operacion = string.Empty;

        public DetallesController(RegistroView view)
        {
            vista = view;
            vista.btnRegistro.Click += BtnRegistro_Click;

        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            movimiento.NOMBRE = Convert.ToString(vista.txtNombreTextBox);
            movimiento.APELIDO = Convert.ToString(vista.txtApellidoTextBox3);
            movimiento.CELULAR = Convert.ToInt32(vista.txtNumCelularTextBox4);
            movimiento.DIRECCION = Convert.ToString(vista.txtDireccionTextBox5);
            movimiento.EDAD = Convert.ToInt32(vista.txtEdadTextBox);
            movimiento.SEXO = Convert.ToString(vista.txtEdadTextBox);

        }         
    }
}
