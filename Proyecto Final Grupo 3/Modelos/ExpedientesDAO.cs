using Proyecto_Final_Grupo_3.Entidades;
using Proyecto_Final_Grupo_3.Vistas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Grupo_3.Modelos
{
    public class ExpedientesDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool ValidarUsuario(Detalles user)
        {
            Registro es = new Registro();

            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append("Insert into EXPEDIENTE");
                sql.Append("Values(@NumeroRegistro,getdate(),getdate(),@IdCliente,@NombreCliente,@TipoCaso,@Descripcion,@Abogado,@EstadoCaso)");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                 comando.CommandText = sql.ToString();
                 comando.Parameters.Add("@NumeroRegistro",SqlDbType.Int).Value = user.NumeroRegistro;
                 comando.Parameters.Add("@FechaAtencion", SqlDbType.DateTime).Value = user.FechaRegistro;
                 comando.Parameters.Add("@FechaConsulta", SqlDbType.DateTime).Value = user.FechaConsulta;
                 comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value =es.IDENTIDAD;
                 comando.Parameters.Add("@NombreCliente", SqlDbType.VarChar,70).Value = es.NOMBRE;
                 comando.Parameters.Add("@TipoCaso", SqlDbType.VarChar, 50).Value = user.TipoCaso;
                 comando.Parameters.Add("@DescripcionCaso", SqlDbType.VarChar, 50).Value = user.DescripcionCaso;
                 comando.Parameters.Add("@Abogado", SqlDbType.VarChar,50).Value = user.AbogadoConsulta;
                 comando.Parameters.Add("@EstadoCaso", SqlDbType.VarChar,30).Value = user.EstadoCaso;
                 comando.ExecuteNonQuery();
                MiConexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }

        }
        public DataTable GetDetalles()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("Select * from DETALLES");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                MiConexion.Close();
            }
            catch (Exception)
            {
            }

            return dt;

        }

    }
}
