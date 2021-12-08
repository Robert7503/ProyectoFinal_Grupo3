using Proyecto_Final_Grupo_3.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Grupo_3.Entidades
{   
    public class Servicios : Conexion
    {
        SqlCommand comando = new SqlCommand();
       
        StringBuilder sql = new StringBuilder();       

       Sql.Append("SELECT 1 FROM LOGIN WHERE USUARIOS =@Usuario AND CONTRASENA =@Contraseña;")


    }
}
