using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClaseBase
{
    public class TrabajarAlquiler
    {
        public static DataTable listarAlquileres()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " alq_codigo as 'ID', alq_fecha as 'Fecha', dpto_codigo as 'DepartamentoID', inq_codigo as'InquilinoID', alq_fechaDesde as 'Fecha de Inicio',";
            cmd.CommandText += "  alq_fechaHasta as 'Fecha de Final', alq_precio as 'Precio'";
            cmd.CommandText += " FROM Alquiler as A";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static DataTable listarAlquileresVista()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " alq_codigo as 'ID Alquiler', E.edif_codigo 'Edificio Codigo' , edif_nombre 'Nombre Edificio', edif_direccion 'Direccion', a.dpto_codigo 'Depto Codigo' , dpto_numero 'Depto Numero',";
            cmd.CommandText += " dpto_piso 'Depto Piso' , A.inq_codigo 'Codigo Inquilino' ,inq_Apellido as  'Apellido Inquilino' , inq_Nombre as  'Nombre Inquilino', inq_telefono as  'Telefono', alq_fecha as 'Fecha Contrato',";
            cmd.CommandText += " alq_fechaDesde as 'Fecha de Inicio', alq_fechaHasta as 'Fecha de Final', alq_precio as 'Precio', tipoDpto_descripcion as 'Tipo'";
            cmd.CommandText += " FROM Alquiler as A LEFT OUTER JOIN Inquilino as I ON (I.inq_codigo = A.inq_codigo)";
            cmd.CommandText += "LEFT OUTER JOIN Departamento as D ON (D.dpto_codigo = A.dpto_codigo)";
            cmd.CommandText += "LEFT OUTER JOIN Edificio as E ON (D.edif_codigo = E.edif_codigo)";
            cmd.CommandText += "LEFT OUTER JOIN TipoDepartamento as T ON (D.tipoDpto_codigo = T.tipoDpto_codigo)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;


            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


         public static void addAlquiler(Alquiler alq)
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Alquiler(alq_fecha, dpto_codigo, inq_codigo, alq_fechadesde, alq_fechahasta, alq_precio) values (@fecha, @dptocodigo, @inqcodigo, @fechadesde, @fechahasta,@precio)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@fecha", alq.Alq_Fecha);
            cmd.Parameters.AddWithValue("@dptocodigo", alq.Dpto_Codigo);
            cmd.Parameters.AddWithValue("@inqcodigo", alq.Inq_Codigo);
            cmd.Parameters.AddWithValue("@fechadesde", alq.Alq_FechaDesde);
            cmd.Parameters.AddWithValue("@fechahasta", alq.Alq_FechaHasta);
            cmd.Parameters.AddWithValue("@precio", alq.Alq_Precio);
            
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

         public static void updateAlquiler(Alquiler alq)
         {
             SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = "UPDATE Alquiler ";
             cmd.CommandText += "SET alq_fecha = @fecha, dpto_codigo = @dptocodigo, inq_codigo = @inqcodigo, alq_fechadesde = @fechadesde, alq_fechahasta = @fechahasta, alq_precio = @precio ";
             cmd.CommandText += " WHERE alq_codigo = @id";

             cmd.CommandType = CommandType.Text;
             cmd.Connection = conexion;

             cmd.Parameters.AddWithValue("@id", alq.Alq_Codigo);
             cmd.Parameters.AddWithValue("@fecha", alq.Alq_Fecha);
             cmd.Parameters.AddWithValue("@dptocodigo", alq.Dpto_Codigo);
             cmd.Parameters.AddWithValue("@inqcodigo", alq.Inq_Codigo);
             cmd.Parameters.AddWithValue("@fechadesde", alq.Alq_FechaDesde);
             cmd.Parameters.AddWithValue("@fechahasta", alq.Alq_FechaHasta);
             cmd.Parameters.AddWithValue("@precio", alq.Alq_Precio);
             

             conexion.Open();
             cmd.ExecuteNonQuery();
             conexion.Close();
         }


         public static void deleteAlquilerByID(int id)
         {
             SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = "DELETE FROM Alquiler ";
             cmd.CommandText += " WHERE alq_codigo = @id";

             cmd.CommandType = CommandType.Text;
             cmd.Connection = conexion;

             cmd.Parameters.AddWithValue("@id", id);

             conexion.Open();
             cmd.ExecuteNonQuery();
             conexion.Close();

         }

         public static DataTable filtrarAlquileresPorSP(int var1, int var2, int var3, string nombreEdificio, DateTime fechaInicio, DateTime fechaFinal, string tipoDepartamento)
         {
             SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.agenciaConnectionString);

             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = "OrdenarAlquileresPor";
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Connection = conexion;
             cmd.Parameters.AddWithValue("@var1", var1);
             cmd.Parameters.AddWithValue("@var2", var2);
             cmd.Parameters.AddWithValue("@var3", var3);
             cmd.Parameters.AddWithValue("@edificio", nombreEdificio);
             cmd.Parameters.AddWithValue("@inicio", fechaInicio);
             cmd.Parameters.AddWithValue("@final", fechaFinal);
             cmd.Parameters.AddWithValue("@tipodepartamento", tipoDepartamento);

             SqlDataAdapter da = new SqlDataAdapter(cmd);

             DataTable dt = new DataTable();
             da.Fill(dt);

             return dt;
         }
        
    }
}
