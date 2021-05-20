using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClaseBase
{
    public class TrabajarEdificio
    {
        public static DataTable listarEdificio()
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM edificio";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable listarEdificioSP()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListarEdificio";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;


            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable NuevoEdificioSP(Edificio edificio)
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "NuevoEdificio";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@Nombre", edificio.Edif_Nombre);
            cmd.Parameters.AddWithValue("@Direccion", edificio.Edif_Direccion);
            cmd.Parameters.AddWithValue("@Telefono", edificio.Edif_Telefono);
            cmd.Parameters.AddWithValue("@administrador", edificio.Edif_Administrador);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable UpdateEdificioSP(Edificio edificio)
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UpdateEdificio";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@id", edificio.Edif_Codigo);
            cmd.Parameters.AddWithValue("@Nombre", edificio.Edif_Nombre);
            cmd.Parameters.AddWithValue("@Direccion", edificio.Edif_Direccion);
            cmd.Parameters.AddWithValue("@Telefono", edificio.Edif_Telefono);
            cmd.Parameters.AddWithValue("@Administrador", edificio.Edif_Administrador);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable EliminarEdificiobyIdSP(int edificioId)
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "EliminarEdificio";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@Id", edificioId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable listarEdificcioPorNombreORDireccionSP(String valor)
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "OrednarEdificioPorNombreoDireccion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@dato", valor);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
