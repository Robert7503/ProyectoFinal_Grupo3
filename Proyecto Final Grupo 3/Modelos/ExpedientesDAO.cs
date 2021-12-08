using Proyecto_Final_Grupo_3.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Grupo_3.Modelos
{
    public class ExpedientesDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertDetalle(Detalles user)
        {
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append("Insert into EXPEDIENTE");
                sql.Append("Values(@NumeroRegistro,getdate(),getdate(),@IdCliente,@NombreCliente,@TipoCaso,@Descripcion,@Abogado,@EstadoCaso)");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                 comando.CommandText = sql.ToString();
                 comando.Parameters.Add("@NumeroRegistro", SqlDbType.Int).Value = Detalles.NumeroRegistro;
                 comando.Parameters.Add("@FechaAtencion", SqlDbType.datetime).Value = Detalles.FechaRegistro;
                 comando.Parameters.Add("@FechaConsulta", SqlDbType.datetime).Value = Detalles.FechaConsulta;
                 comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = Detalles.IdCliente;
                 comando.Parameters.Add("@NombreCliente", SqlDbType.Varchar,70).Value = Detalles.NombreCliente;
                 comando.Parameters.Add("@TipoCaso", SqlDbType.VarChar, 50).Value = Detalles.;
                 comando.Parameters.Add("@DescripcionCaso", SqlDbType.VarChar, 50).Value = Detalles.TipoTransaccion;
                 comando.Parameters.Add("@Abogado", SqlDbType.Varchar,50).Value = Detalles.SaldoInicail;
                 comando.Parameters.Add("@EstadoCaso", SqlDbType.Varchar,30).Value = Detalles.SaldoFinal;
                 //comando.ExecuteNonQuery();
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
