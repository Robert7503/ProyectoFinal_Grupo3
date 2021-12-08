using Proyecto_Final_Grupo_3.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Grupo_3.Entidades
{
    public class Detalles
    {
        public int NumeroRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaConsulta { get; set; }
        public int IdCliente { get; set; }
        public string  NombreCliente { get; set; }
        public string TipoCaso { get; set; }
        public string DescripcionCaso { get; set; }
        public string AbogadoConsulta { get; set; }
        public string EstadoCaso { get; set; }


    }
}
