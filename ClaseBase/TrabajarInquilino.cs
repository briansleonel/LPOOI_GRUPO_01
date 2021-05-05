using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//base de datos
using System.Data;
using System.Data.SqlClient;


namespace ClaseBase
{
    public class TrabajarInquilino
    {
        public static void insert_inquilino(Inquilino inquilino)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Inquilino(inq_Apellido,inq_Nombre,inq_Telefono) values(@ape,@nom,@tel)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@ape", inquilino.Inq_Apellido);
            cmd.Parameters.AddWithValue("@nom", inquilino.Inq_Nombre);
            cmd.Parameters.AddWithValue("@tel", inquilino.Inq_Telefono);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void update_inquilino(Inquilino inquilino)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();

            cmd = cnn.CreateCommand();
            cmd.CommandText = "UPDATE Inquilino SET inq_Apellido = @ape, inq_Nombre = @nom, inq_Telefono = @tel WHERE inq_codigo = @id";
            cmd.Parameters.AddWithValue("@id", inquilino.Inq_Codigo);
            cmd.Parameters.AddWithValue("@ape", inquilino.Inq_Apellido);
            cmd.Parameters.AddWithValue("@nom", inquilino.Inq_Nombre);
            cmd.Parameters.AddWithValue("@tel", inquilino.Inq_Telefono);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable buscarInquilinos(string sPattern)
        {

            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " inq_codigo as 'ID', inq_apellido as 'Apellido', inq_nombre as 'Nombre', inq_Telefono as'Telefono'"; //, inq_nombre as 'Nombre', ";
            //cmd.CommandText += " inq_telefono as 'Telefono', ";
            cmd.CommandText += " FROM Inquilino as I";

            cmd.CommandText += " WHERE";
            cmd.CommandText += " inq_apellido LIKE @pattern or inq_nombre LIKE @pattern";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable listarInquilinos()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " inq_codigo as 'ID', inq_apellido as 'Apellido', inq_nombre as 'Nombre', inq_Telefono as'Telefono'"; //, inq_nombre as 'Nombre', ";
            //cmd.CommandText += " inq_telefono as 'Telefono', ";
            cmd.CommandText += " FROM Inquilino as I";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;



            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void deleteInquilinoByID(int id)
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Inquilino ";
            cmd.CommandText += " WHERE inq_codigo = @id";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@id", id);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();

        }

    }

}
