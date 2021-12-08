using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Grupo_3.Entidades
{
    public class Registro
    {
        //public int IDENTIDAD { get; set; }
        public string NOMBRE { get; set; }
        public string APELIDO { get; set; }
        public int CELULAR { get; set; }
        public string DIRECCION { get; set; }
        public string CORREO { get; set; }
        public int EDAD { get; set; }
        public string SEXO { get; set; }

        public Registro(string nombre, string apellido, int celular, string direccion, string correo, int edad, string genero)
        {
            //IDENTIDAD = identidad;
            NOMBRE = nombre;
            APELIDO = apellido;
            CELULAR = celular;
            DIRECCION = direccion;
            CORREO = correo;
            EDAD = edad;
            SEXO = genero;
        }

    }
}
